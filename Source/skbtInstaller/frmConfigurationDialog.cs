using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using IWshRuntimeLibrary;
using System.Threading;
using System.Management;

namespace skbtInstaller
{
    public partial class frmConfigWindow : Form
    {
        // Reference to the Server Control Object
        skbtServerControl sc;

        // Affinity boxes built flag
        Boolean affChkBuilt = false;

        // Current Selected Process ID
        short? selectedCustomID = null;

        // Saved Flag
        Boolean formSaved = false;

        // Timer for activity check
        System.Windows.Forms.Timer activityTimer = new System.Windows.Forms.Timer();

        // Affinity box list
        Dictionary<String, Dictionary<int, CheckBox>> AffinityBoxes;

        // colors :)
        Color redForeGround = Color.FromArgb(132, 0, 0);
        Color greenForeGround = Color.FromName("Green");
        Color redBackGround = Color.FromArgb(255, 128, 128);
        Color greenBackGround = Color.FromArgb(192, 255, 192);
        Color redMouseDown = Color.FromArgb(64, 0, 0);
        Color greenMouseDown = Color.FromArgb(0, 64, 0);

        Color changedBack = Color.FromArgb(28, 43, 43);
        Color changedFore = Color.FromArgb(95, 146, 146);

        // New Process Originals
        Dictionary<short, skbtProcessConfigCustom> objOriginalCusProc = new Dictionary<short, skbtProcessConfigCustom>() { };

        // Copies of Originals (NOT ref)
        skbtServerConfig sConfig;
        skbtServerMeta sMeta;

        // Design Flag
        Boolean pageLoaded;
        Boolean pageLoadedCustom;
        Boolean pageCustomLoading;

        // If Batch Settings Path Changed
        Boolean onSaveRenameConfig;

        // Current Tab
        String tabPageCurrent;

        // Delegates
        delegate String profilePathProcessor(String profilePath);

        public frmConfigWindow(skbtServerControl sc)
        {
            InitializeComponent();

            // Appearance

            this.sc = sc;
        }
        public void DisplayConfigWindow(skbtServerMeta thisConfigMeta, skbtServerConfig thisConfigObject)
        {
            this.formSaved = false;
            this.pageLoaded = false;
            this.pageLoadedCustom = false;
            this.pageCustomLoading = false;

            this.activityTimer.Tick += new EventHandler(activityTimer_Check);
            this.activityTimer.Interval = 5000;
            this.activityTimer.Enabled = true;
            this.activityTimer.Start();

            if (!System.IO.File.Exists(thisConfigMeta.PathToConfig.Trim('"')))
            {
                MessageBox.Show("No batch settings were found. Reverting to defaults.",
                    "Settings not found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
            }

            // Set the Config Objects

            // Create copies of the meta and config objects.
            this.sMeta = new skbtServerMeta(
                thisConfigMeta.Identifier,
                thisConfigMeta.textualName,
                thisConfigMeta.PathToEXE,
                thisConfigMeta.PathToConfig,
                thisConfigMeta.isInstalled
            );

            this.sConfig = new skbtServerConfig(thisConfigObject);

            // Load details from config meta and object in form components.

            // Main Config Meta
            this.txtConfigName.Text = this.sMeta.textualName;
            this.txtArmaExePath.Text = this.sMeta.PathToEXE;
            this.txtBatchSettingsPath.Text = this.sMeta.PathToConfig;

            // Build Affinity Checkbox Area
            this.buildAffinityBoxes();

            // Select First Tab (fire events needed)
            this.selectAndDisplayTab("btnTabSelectServer");

            // disable all checkboxes
            this.resetAllAffinityCheckboxes();

            // reset all text box colors
            this.resetAllControlColors();

            this.setKeepaliveButtonColor(
                btnProcessKeepaliveBEC,
                this.sConfig.objBECProc.Keepalive ? false : true);

            this.setKeepaliveButtonColor(
                btnProcessKeepaliveHC,
                this.sConfig.objHeadlessClientProc.Keepalive ? false : true);

            this.setKeepaliveButtonColor(
                btnProcessKeepaliveTS,
                this.sConfig.objTeamspeakProc.Keepalive ? false : true);

            this.setKeepaliveButtonColor(
                btnProcessKeepaliveASM,
                this.sConfig.objASMProc.Keepalive ? false : true);

            // [Server Process Data]

            // Keepalive Button State
            this.setKeepaliveButtonColor(
                btnProcessKeepaliveServer,
                this.sConfig.objServerProc.Keepalive ? false : true);

            // Path to Process EXE
            this.txtPathToEXEServer.Text = Path.Combine(this.sConfig.objServerProc.Path, this.sConfig.objServerProc.EXEFile);

            // Selected Priority Setting
            this.cBoxPriorityServer.SelectedItem = this.getPriorityNameByLowercase(this.sConfig.objServerProc.Priority.ToLower());

            // Selected Affinity Settings
            this.setAffinityChkBoxes("Server", this.sConfig.objServerProc.Affinity);

            // Zip Logs
            this.chkUseZipLogs.Checked = this.sConfig.objServerProc.UseZipLogs;

            // Path to Server Log File
            this.txtPathToServerLog.Text = this.sConfig.objServerProc.LogFilePath;

            // Path Log File to Backup Folder
            this.txtPathToBackupLog.Text = this.sConfig.objServerProc.LogFileBackupPath;

            // Clean WER Dialogs
            this.chkCleanWERs.Checked = this.sConfig.CleanWER;

            // Debug Level
            this.cBoxDebugLevel.SelectedItem = this.getDebugLevelTextFromInt(this.sConfig.skbtDebugLevel);

            // Restart Delay
            this.numAutoDelay.Value = this.sConfig.AutoRestartDelay;

            // Restart Timeout
            this.numAutoTimeout.Value = this.sConfig.AutoTimeoutLength;

            // Manual Timeout
            this.numManualTimeout.Value = this.sConfig.ManualTimeoutLength;

            // Server Start Timeout
            this.numStartTimeout.Value = this.sConfig.ServerStartTimeout;

            // Server IP
            String[] ipArr = this.sConfig.IP.Split('.');
            this.numServerIP1.Value = Convert.ToDecimal(ipArr[0]);
            this.numServerIP2.Value = Convert.ToDecimal(ipArr[1]);
            this.numServerIP3.Value = Convert.ToDecimal(ipArr[2]);
            this.numServerIP4.Value = Convert.ToDecimal(ipArr[3]);

            // Server Port
            this.numServerPort.Text = this.sConfig.objServerProc.Port.ToString();

            // Bind to IP
            this.chkServerBindToIP.Checked = this.sConfig.BindToIP == true;

            // Command line
            this.txtServerCommand.Text = this.sConfig.objServerProc.CommandLine;

            // Modline
            this.txtServerModline.Text = this.sConfig.objServerProc.ModLine;

            // Path to Config
            this.txtPathToConfigCFG.Text = this.sConfig.objServerProc.ConfigPathServer;

            // Path to Basic
            this.txtPathToBasicCFG.Text = this.sConfig.objServerProc.ConfigPathBasic;

            // Path to Profiles
            this.txtPathToProfile.Text = this.sConfig.objServerProc.ProfilePath;

            // Profile Name
            this.txtProfileName.Text = this.sConfig.objServerProc.ProfileName;

            // [Database Process Data]

            // Keepalive Button State
            this.setKeepaliveButtonColor(
                btnProcessKeepaliveDatabase,
                this.sConfig.objDatabaseProc.Keepalive ? false : true);

            // Path to Process EXE
            this.txtPathToEXEDB.Text = Path.Combine(this.ExpandPathVars(this.sConfig.objDatabaseProc.Path), this.sConfig.objDatabaseProc.EXEFile);

            // Selected Priority Setting
            this.cBoxPriorityDatabase.SelectedItem = this.getPriorityNameByLowercase(this.sConfig.objDatabaseProc.Priority.ToLower());

            // Selected Affinity Settings
            this.setAffinityChkBoxes("Database", this.sConfig.objDatabaseProc.Affinity);

            // Zip Backups
            this.chkUseZipBackups.Checked = this.sConfig.objDatabaseProc.UseZipBackups;

            // Database Backup Interval
            this.numBackupInterval.Text = this.sConfig.objDatabaseProc.DatabaseBackupInterval.ToString();

            // Database Dump File Path
            this.txtPathToDBFile.Text = this.CollapsePathVars(Path.Combine(this.ExpandPathVars(this.sConfig.objDatabaseProc.DatabaseDumpFilePath), this.sConfig.objDatabaseProc.DatabaseDumpFileName));

            // Database Backup Folder
            this.txtPathToBackupFolder.Text = this.sConfig.objDatabaseProc.BackupFolder;

            // [BEC Process Data]

            // Keepalive Button State
            this.setKeepaliveButtonColor(
                btnProcessKeepaliveBEC,
                this.sConfig.objBECProc.Keepalive ? false : true);

            // Path to Process EXE
            this.txtPathToEXEBEC.Text = Path.Combine(this.ExpandPathVars(this.sConfig.objBECProc.Path), this.sConfig.objBECProc.EXEFile);

            // Selected Priority Setting
            this.cBoxPriorityBEC.SelectedItem = this.getPriorityNameByLowercase(this.sConfig.objBECProc.Priority.ToLower());

            // Selected Affinity Settings
            this.setAffinityChkBoxes("BEC", this.sConfig.objBECProc.Affinity);

            // BEC DSC Flag
            this.chkBecUseDsc.Checked = this.sConfig.objBECProc.useDSC;

            // Path to Battleye Folder
            this.txtPathToBattleye.Text = this.sConfig.objBECProc.BEPath;

            // [Headless Client Process Data]

            // Keepalive Button State
            this.setKeepaliveButtonColor(
                btnProcessKeepaliveHC,
                this.sConfig.objHeadlessClientProc.Keepalive ? false : true);

            // Path to Process EXE
            this.txtPathToEXEHC.Text = Path.Combine(this.ExpandPathVars(this.sConfig.objHeadlessClientProc.Path), this.sConfig.objHeadlessClientProc.EXEFile);

            // Selected Priority Setting
            this.cBoxPriorityHeadlessClient.SelectedItem = this.getPriorityNameByLowercase(this.sConfig.objHeadlessClientProc.Priority.ToLower());

            // Selected Affinity Settings
            this.setAffinityChkBoxes("HeadlessClient", this.sConfig.objHeadlessClientProc.Affinity);

            // Launch Parameters
            this.txtHeadlessClientLaunchArgs.Text = this.sConfig.objHeadlessClientProc.LaunchParams;

            // [Teamspeak Process Data]

            // Keepalive Button State
            this.setKeepaliveButtonColor(
                btnProcessKeepaliveTS,
                this.sConfig.objTeamspeakProc.Keepalive ? false : true);

            // Path to Process EXE
            this.txtPathToEXETS.Text = Path.Combine(this.ExpandPathVars(this.sConfig.objTeamspeakProc.Path), this.sConfig.objTeamspeakProc.EXEFile);

            // Selected Priority Setting
            this.cBoxPriorityTeamspeak.SelectedItem = this.getPriorityNameByLowercase(this.sConfig.objTeamspeakProc.Priority.ToLower());

            // Selected Affinity Settings
            this.setAffinityChkBoxes("Teamspeak", this.sConfig.objTeamspeakProc.Affinity);

            // Teamspeak Server Port
            this.numTeamspeakPortNumber.Text = this.sConfig.objTeamspeakProc.PortNumber.ToString();

            // [ASM Process Data]

            // Keepalive Button State
            this.setKeepaliveButtonColor(
                btnProcessKeepaliveASM,
                this.sConfig.objASMProc.Keepalive ? false : true);

            // Path to Process EXE
            this.txtPathToEXEASM.Text = Path.Combine(this.ExpandPathVars(this.sConfig.objASMProc.Path), this.sConfig.objASMProc.EXEFile);

            // Selected Priority Setting
            this.cBoxPriorityASM.SelectedItem = this.getPriorityNameByLowercase(this.sConfig.objASMProc.Priority.ToLower());

            // Selected Affinity Settings
            this.setAffinityChkBoxes("ASM", this.sConfig.objASMProc.Affinity);

            // ASM Logging Interval
            this.numASMLogInterval.Text = this.sConfig.objASMProc.LogInterval.ToString();

            // ASM Log File Name
            this.txtASMLogName.Text = this.sConfig.objASMProc.LogFileName;

            // Custom Proc Tab
            this.resetTabCustom();

            // Fire first activity check
            this.activityTimer_Check(new object(), new EventArgs());

            this.pageLoaded = true;

            // Show Dialog
            this.ShowDialog();

        
        }

        private void executeBatchFile(string filepath){
            Process myProcess = new Process();
            myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            myProcess.StartInfo.CreateNoWindow = true;
            myProcess.StartInfo.UseShellExecute = false;
            myProcess.StartInfo.FileName = "cmd.exe";
            myProcess.StartInfo.Arguments = "/c " + filepath;
            myProcess.EnableRaisingEvents = true;
            //myProcess.Exited += new EventHandler(process_Exited);
            myProcess.Start();
            // int ExitCode = myProcess.ExitCode;
        }

        public Process getProcessByPath(String path)
        {
            var wmiQueryString = "SELECT ProcessId, ExecutablePath, CommandLine FROM Win32_Process";
            using (var searcher = new ManagementObjectSearcher(wmiQueryString))
            using (var results = searcher.Get())
            {
                var query = from p in Process.GetProcesses()
                            join mo in results.Cast<ManagementObject>()
                            on p.Id equals (int)(uint)mo["ProcessId"]
                            select new
                            {
                                Process = p,
                                Path = (string)mo["ExecutablePath"],
                                CommandLine = (string)mo["CommandLine"]
                            };
                foreach (var item in query)
                {
                    string exe = Path.GetFileName(path);
                    if (item.Path == null)
                    {
                    }
                    else
                    {
                        // def
                        if (Path.GetFullPath(item.Path).ToLower() == Path.GetFullPath(path).ToLower())
                        {
                            return item.Process;
                        }
                    }
                }
            }
            return null;
        }

        public bool isProcessRunning(String path)
        {
            var wmiQueryString = "SELECT ProcessId, Name, ExecutablePath, CommandLine FROM Win32_Process";
            using (var searcher = new ManagementObjectSearcher(wmiQueryString))
            using (var results = searcher.Get())
            {
                var query = from p in Process.GetProcesses()
                            join mo in results.Cast<ManagementObject>()
                            on p.Id equals (int)(uint)mo["ProcessId"]
                            select new
                            {
                                Process = p,
                                Path = (string)mo["ExecutablePath"],
                                CommandLine = (string)mo["CommandLine"],
                                Name = (string)mo["Name"]
                            };
                foreach (var item in query)
                {
                    string exe = Path.GetFileName(path);
                    if (item.Path == null)
                    {
                        // maybe
                        if (item.Name == exe)
                        {
                            // maybe
                        }
                    }
                    else 
                    { 
                        // def
                        if (Path.GetFullPath(item.Path).ToLower() == Path.GetFullPath(path).ToLower())
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        public void activityTimer_Check(object sender, EventArgs e)
        {
            if (this.sMeta == null) { return; }
            if (this.sMeta.isInstalled == false) { return; }

            // Server Process

            string filep = Path.GetFullPath(Path.Combine(this.sConfig.objServerProc.Path, this.sConfig.objServerProc.EXEFile));
            Process tProc = this.getProcessByPath(filep);

            // Active Flags
            Boolean keepaliveRunning = this.sc.frmMainWindowHandle.IsKeepaliveActive(this.sConfig)? true : false;
            Boolean serverProcessRunning = (tProc != null) ? true : false;

            // Keepalive batch check
            if (keepaliveRunning)
            {
                this.pbActive.BackColor = System.Drawing.Color.FromArgb(0, 200, 0);
                this.toolTip1.SetToolTip(this.pbActive, "Keepalive Activity Detected. Keepalive is running (within last 15 seconds)");

                // enable server controls if applicable. disable keepalive start/clean batch_lib
                tsmConfigKeepaliveStop.Enabled = true;
                tsmConfigKeepaliveStart.Enabled = false;
                tsmConfigKeepaliveClean.Enabled = false;
            }
            else
            {
                tsmConfigKeepaliveStop.Enabled = false;
                tsmConfigKeepaliveClean.Enabled = true;

                tsmConfigKeepaliveStart.Enabled = (this.sMeta.isInstalled)? true : false;

                this.pbActive.BackColor = System.Drawing.Color.FromArgb(200, 0, 0);
                this.toolTip1.SetToolTip(this.pbActive, "Keepalive Activity NOT Detected. Keepalive is not running");
            }

            // Server Process Check
            if (!serverProcessRunning)
            {
                tsmConfigControlStop.Enabled = false;
                tsmItemConfigControlStart.Enabled = (keepaliveRunning)? true : false;
                tsmItemConfigControlRestart.Enabled = false;

                this.pbConfigServer.BackColor = System.Drawing.Color.FromArgb(200, 0, 0);
                this.toolTip1.SetToolTip(this.pbConfigServer, "Server Process Activity NOT Detected.");
            }
            else
            {
                tsmConfigControlStop.Enabled = (keepaliveRunning) ? true : false;
                tsmItemConfigControlStart.Enabled = false;
                tsmItemConfigControlRestart.Enabled = (keepaliveRunning) ? true : false;

                if (tProc.Responding == false)
                {

                    this.pbConfigServer.BackColor = System.Drawing.Color.FromArgb(255, 255, 120);
                    this.toolTip1.SetToolTip(this.pbConfigServer, "Server Process NOT Responding.");
                }
                else
                {
                    this.pbConfigServer.BackColor = System.Drawing.Color.FromArgb(0, 200, 0);
                    this.toolTip1.SetToolTip(this.pbConfigServer, "Server Process Activity Detected.");
                }
            }
        }
        private void buildAffinityBoxes()
        {
            if (this.affChkBuilt == true)
            {
                return;
            }
            this.affChkBuilt = true;
            // TODO: finish this (infinite affinity)
            // loop for each affinity available, reposition form elements accordingly, repeat for each tab. (Move a container)

            String[] tabs = {
                "Server",
                "Database",
                "BEC",
                "HeadlessClient",
                "Teamspeak",
                "ASM",
                "Custom"
            };
            var tabPanels = new Dictionary<String, FlowLayoutPanel>(){
                {"Server", this.flpServer},
                {"Database", this.flpDatabase},
                {"BEC", this.flpBEC},
                {"HeadlessClient", this.flpHeadlessClient},
                {"Teamspeak", this.flpTeamspeak},
                {"ASM", this.flpASM},
                {"Custom", this.flpCustom},
            };
            this.AffinityBoxes = new Dictionary<string,Dictionary<int,CheckBox>>();
            foreach (String tab in tabs)
            {
                Dictionary<int, CheckBox> chkList = new Dictionary<int, CheckBox>();
                for (int i = 0; i < this.sc.CoreConfig.totalCores; i++)
                {
                    CheckBox tChk = new CheckBox();
                    tChk.Name = "chkAffinity"+tab.ToString()+i.ToString();
                    tChk.Appearance = System.Windows.Forms.Appearance.Button;
                    tChk.AutoSize = true;
                    tChk.FlatAppearance.BorderColor = System.Drawing.Color.Black;
                    tChk.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
                    tChk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    tChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    tChk.ForeColor = System.Drawing.SystemColors.ScrollBar;
                    tChk.Location = new System.Drawing.Point(297, 80);
                    tChk.Size = new System.Drawing.Size(30, 23);
                    tChk.TabIndex = 35;
                    tChk.Text = i.ToString();
                    this.toolTip1.SetToolTip(tChk, "Process EXE Affinity. The cores with which this process can utilize.");
                    tChk.UseVisualStyleBackColor = true;
                    tChk.CheckedChanged += new System.EventHandler(this.evntChkAffinityChange);
                    tabPanels[tab].Controls.Add(tChk);
                    chkList.Add(i, tChk);
                }
                this.AffinityBoxes.Add(tab, chkList);
            }



        }

        private void actionSaveConfig(object sender, EventArgs e)
        {

            if (this.sc.frmMainWindowHandle.IsKeepaliveActive(this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier]))
            {
                MessageBox.Show("KEEPALIVE ACTIVE" + Environment.NewLine + "You must close the keepalive for this config and wait 15 seconds before saving this config.");
                return;
            }

            String newFile = this.sMeta.PathToConfig;
            String oldFile = this.sc.CoreConfig.getServerMetaObject(this.sMeta.Identifier).PathToConfig;

            bool showChangePathDialog = false;

            // Check if config name is in use by another config
            if (this.sc.CoreConfig.getServerMetaObject(this.sMeta.Identifier).textualName != this.sMeta.textualName)
            {
                if (this.sc.configNameInUse(this.txtConfigName.Text))
                {
                    MessageBox.Show("The configuration name you set is already in use by another config!");
                    return;
                }
            }

            // Check if config path is in use by another config
            if (this.sc.CoreConfig.ServerConfigInUse(newFile, this.sMeta.Identifier))
            {
                showChangePathDialog = true;
            }

            if (newFile != oldFile) {

                // If rename flag is set, rename current config
                if (this.onSaveRenameConfig == true)
                {
                    // rename current config, then overwrite
                    if (System.IO.File.Exists(newFile)) { System.IO.File.Delete(newFile); }
                    System.IO.File.Move(oldFile, newFile);
                }
            }

            if (showChangePathDialog == true)
            {
                MessageBox.Show(this,
                    "This action would overwrite an existing config, save operation was canceled."
                    + Environment.NewLine
                    + Environment.NewLine
                    + "Config is used by: \"" + this.sc.CoreConfig.getNameOfConfigFromConfigPath(newFile, this.sMeta.Identifier) + "\""
                    + Environment.NewLine
                    + "Please change your Batch Settings Path.",
                    "Cannot Save Your Settings",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1
                );
                return;
            }

            // quik fix
            this.sConfig.objServerProc.ModLine = this.sConfig.objServerProc.ModLine.Trim(' ');

            string cusProcLines = "";
            // Build Custom Process Lines
            if (this.sConfig.objCustomProc.Count() >= 1)
            {
                foreach (KeyValuePair<short, skbtProcessConfigCustom> cProc in this.sConfig.objCustomProc)
                {
                    cusProcLines +=
                        "set keepalive_cusproc["+cProc.Key+"]="+((cProc.Value.Keepalive==true)? "1":"0")+Environment.NewLine+
                        "set cusproc_name[" + cProc.Key + "]=" + cProc.Value.Name + Environment.NewLine +
                        "set cusproc_path[" + cProc.Key + "]=" + cProc.Value.Path + Environment.NewLine +
                        "set cusproc_filename[" + cProc.Key + "]=" + cProc.Value.EXEFile + Environment.NewLine +
                        "set cusproc_params[" + cProc.Key + "]=" + cProc.Value.LaunchParams + Environment.NewLine +
                        "set cusproc_affinity[" + cProc.Key + "]=" + cProc.Value.Affinity + Environment.NewLine +
                        "set cusproc_priority[" + cProc.Key + "]=" + cProc.Value.Priority+Environment.NewLine+
                        Environment.NewLine
                    ;
                }
            }

            // Map of replacement strings to values
            Dictionary<String, String> replacements = new Dictionary<string, string>()
            {

                {"{DEBUG_LEVEL}", this.sConfig.skbtDebugLevel.ToString()},
                {"{KEEPALIVE_DATABASE}", this.sConfig.objDatabaseProc.Keepalive ? "1" : "0"},
                {"{KEEPALIVE_BEC}", this.sConfig.objBECProc.Keepalive ? "1" : "0"},
                {"{KEEPALIVE_ASM}", this.sConfig.objASMProc.Keepalive ? "1" : "0"},
                {"{KEEPALIVE_TS}", this.sConfig.objTeamspeakProc.Keepalive ? "1" : "0"},
                {"{KEEPALIVE_HC}", this.sConfig.objHeadlessClientProc.Keepalive ? "1" : "0"},
                {"{SERVERPORT}", this.sConfig.objServerProc.Port.ToString()},
                {"{BINDTOIP}", this.sConfig.BindToIP ? "1" : "0"},
                {"{SERVERIP}", this.sConfig.IP},
                {"{BEC_FLAG_DSC}", (this.sConfig.objBECProc.useDSC==true)? "1" : "0"},
                {"{TEAMSPEAK_PORT}", this.sConfig.objTeamspeakProc.PortNumber.ToString()},
                {"{ASM_LOG_INTERVAL}", this.sConfig.objASMProc.LogInterval.ToString()},
                {"{SERVER_START_TIMEOUT}", this.sConfig.ServerStartTimeout.ToString()},
                {"{DB_BACKUP_INTERVAL}", this.sConfig.objDatabaseProc.DatabaseBackupInterval.ToString()},
                {"{UZE_ZIP_LOGS}", this.sConfig.objServerProc.UseZipLogs ? "1" : "0"},
                {"{USE_ZIP_BACKUPS}", this.sConfig.objDatabaseProc.UseZipBackups ? "1" : "0"},
                {"{DATABASE_BACKUP_FOLDER}", this.sConfig.objDatabaseProc.BackupFolder},
                {"{LOG_BACKUP_FOLDER}", this.sConfig.objServerProc.LogFileBackupPath},
                {"{MANUAL_TIMEOUT_LENGTH}", this.sConfig.ManualTimeoutLength.ToString()},
                {"{AUTO_TIMEOUT_LENGTH}", this.sConfig.AutoTimeoutLength.ToString()},
                {"{AUTO_RESTART_DELAY_LENGTH}", this.sConfig.AutoRestartDelay.ToString()},
                {"{CLEAN_WER_DIALOGS}", this.sConfig.CleanWER ? "1":"0"},
                {"{HC_LAUNCH_PARAMS}", this.sConfig.objHeadlessClientProc.LaunchParams},
                {"{ARMA_SERVER_EXE}", this.sConfig.objServerProc.EXEFile},
                {"{HC_EXE}", this.sConfig.objHeadlessClientProc.EXEFile},
                {"{TS_EXE_NAME}", this.sConfig.objTeamspeakProc.EXEFile},
                {"{REDIS_EXE_NAME}", this.sConfig.objDatabaseProc.EXEFile},
                {"{BEC_EXE_NAME}", this.sConfig.objBECProc.EXEFile},
                {"{ASM_EXE_NAME}", this.sConfig.objASMProc.EXEFile},
                {"{DATABASE_DUMP_NAME}", this.sConfig.objDatabaseProc.DatabaseDumpFileName},
                {"{ASM_LOG_NAME}", this.sConfig.objASMProc.LogFileName},
                {"{ARMA_PATH}", this.sConfig.objServerProc.Path},
                {"{HC_PATH}", this.sConfig.objHeadlessClientProc.Path},
                {"{TS_PATH}", this.sConfig.objTeamspeakProc.Path},
                {"{DB_PATH}", this.sConfig.objDatabaseProc.Path},
                {"{ASM_PATH}", this.sConfig.objASMProc.Path},
                {"{BE_PATH}", this.sConfig.objBECProc.BEPath},
                {"{LOG_PATH}", this.sConfig.objServerProc.LogFilePath},
                {"{BEC_PATH}", this.sConfig.objBECProc.Path},
                {"{DB_FILE_FULLPATH}", Path.Combine(this.ExpandPathVars(this.sConfig.objDatabaseProc.DatabaseDumpFilePath), this.sConfig.objDatabaseProc.DatabaseDumpFileName)},
                {"{SERVER_CONFIG_PATH}", this.sConfig.objServerProc.ConfigPathServer},
                {"{SERVER_BASIC_PATH}", this.sConfig.objServerProc.ConfigPathBasic},
                {"{PROFILE_PATH}", this.sConfig.objServerProc.ProfilePath},
                {"{PROFILE_NAME}", this.sConfig.objServerProc.ProfileName},
                {"{MOD_STRING}", this.sConfig.objServerProc.ModLine},
                {"{COMMAND_LINE}", this.sConfig.objServerProc.CommandLine},
                {"{AFFINITY_SERVER}", this.sConfig.objServerProc.Affinity},
                {"{AFFINITY_BEC}", this.sConfig.objBECProc.Affinity},
                {"{AFFINITY_HC}", this.sConfig.objHeadlessClientProc.Affinity},
                {"{AFFINITY_DB}", this.sConfig.objDatabaseProc.Affinity},
                {"{AFFINITY_TS}", this.sConfig.objTeamspeakProc.Affinity},
                {"{AFFINITY_ASM}", this.sConfig.objASMProc.Affinity},
                {"{PRIORITY_SERVER}", this.sConfig.objServerProc.Priority},
                {"{PRIORITY_BEC}", this.sConfig.objBECProc.Priority},
                {"{PRIORITY_HC}", this.sConfig.objHeadlessClientProc.Priority},
                {"{PRIORITY_DB}", this.sConfig.objDatabaseProc.Priority},
                {"{PRIORITY_TS}", this.sConfig.objTeamspeakProc.Priority},
                {"{PRIORITY_ASM}", this.sConfig.objASMProc.Priority},
                {"{CUSTOM_PROCESS_ENTRIES}", cusProcLines},
                {"{SPECIFIC_PROC_CHECK}", this.sConfig.SpecificProcCheck ? "1" : "0"}
            };
            this.sMeta.textualName = this.txtConfigName.Text;

            // Prepare new Batch Settings File
            String newConfigData = skbtInstaller.Properties.Resources.skbtConfigTemplate;

            foreach (KeyValuePair<String, String> str in replacements)
            {
                newConfigData = newConfigData.Replace(str.Key, str.Value);
            }

            // Write new batch settings file
            System.IO.File.WriteAllText(newFile, newConfigData);

            // Update Batch Files if Necessary
            if (oldFile != newFile)
            {
                this.sc.doBatchLibFiles(newFile, this.ExpandPathVars(this.sConfig.objServerProc.Path));
            }

            // Config Name Change Flag
            Boolean configNamechanged = false;
            if (this.sMeta.textualName != this.sc.CoreConfig.getServerMetaObject(this.sMeta.Identifier).textualName)
            {
                configNamechanged = true;
            }
            // Show saving dialog
            dlgSavingConfig dlg = new dlgSavingConfig();
            dlg.StartPosition = FormStartPosition.CenterScreen;
            dlg.Show();
            dlg.Update();

            // Check if first time installation. If so, add shortcuts.
            if (this.sMeta.isInstalled == false || configNamechanged)
            {
                // Old Name
                String StartMenuProgName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonStartMenu), "Programs", skbtServerControl.ProgramGroupName, this.sc.CoreConfig.getServerMetaObject(this.sMeta.Identifier).textualName);

                if (configNamechanged)
                {
                    // Delete Shrotcuts/Program Group
                    Dictionary<UInt32, String> Shortcuts = new Dictionary<uint, string>() {
                        {0,Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Start Keepalive (" + this.sc.CoreConfig.getServerMetaObject(this.sMeta.Identifier).textualName + ").lnk")},
                        {1,Path.Combine(StartMenuProgName, "Start Keepalive.lnk")},
                        {2,Path.Combine(StartMenuProgName, "Auto Restart Test.lnk")},
                        {3,Path.Combine(StartMenuProgName, "Manual Restart.lnk")},
                        {4,Path.Combine(StartMenuProgName, "Manual Start.lnk")},
                        {5,Path.Combine(StartMenuProgName, "Manual Stop.lnk")},
                        {6,Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "README.txt")}
                    };
                    foreach (KeyValuePair<UInt32, String> shortcut in Shortcuts)
                    {
                        while (System.IO.File.Exists(Path.GetFullPath(shortcut.Value.ToString())))
                        {
                            System.IO.File.Delete(Path.GetFullPath(shortcut.Value.ToString()));
                        }
                    }
                    if (Directory.Exists(StartMenuProgName)) { Directory.Delete(StartMenuProgName, true); }
                }

                // Current Name
                StartMenuProgName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonStartMenu), "Programs", skbtServerControl.ProgramGroupName, this.sMeta.textualName);

                // Create Shortcuts on desktop / add to programs start menu
                String BatchLibPath = Path.Combine(this.sConfig.objServerProc.Path, "batch_lib");

                if (!addShortcut(
                    Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Start Keepalive (" + this.sMeta.textualName + ").lnk"),
                    Path.Combine(BatchLibPath, "start_keepalive.bat")))
                {
                    MessageBox.Show("There was an error creating a shortcut in the Start Menu (0).");
                }

                if (!addShortcut(
                    Path.Combine(StartMenuProgName, "Start Keepalive.lnk"),
                    Path.Combine(BatchLibPath, "start_keepalive.bat")))
                {
                    MessageBox.Show("There was an error creating a shortcut in the Start Menu (1).");
                }

                if (!addShortcut(
                    Path.Combine(StartMenuProgName, "Auto Restart Test.lnk"),
                    Path.Combine(BatchLibPath, "control", "auto_restart.bat")))
                {
                    MessageBox.Show("There was an error creating a shortcut in the Start Menu (2).");
                }

                if (!addShortcut(
                    Path.Combine(StartMenuProgName, "Manual Restart.lnk"),
                    Path.Combine(BatchLibPath, "control", "manual_restart.bat")))
                {
                    MessageBox.Show("There was an error creating a shortcut in the Start Menu (3).");
                }

                if (!addShortcut(
                    Path.Combine(StartMenuProgName, "Manual Start.lnk"),
                    Path.Combine(BatchLibPath, "control", "manual_start.bat")))
                {
                    MessageBox.Show("There was an error creating a shortcut in the Start Menu (4).");
                }

                if (!addShortcut(
                    Path.Combine(StartMenuProgName, "Manual Stop.lnk"),
                    Path.Combine(BatchLibPath, "control", "manual_stop.bat")))
                {
                    MessageBox.Show("There was an error creating a shortcut in the Start Menu (5).");
                }
            }

            // Finally Installed
            this.sMeta.isInstalled = true;

            // Update Objects
            this.sc.CoreConfig.setServerConfig(this.sMeta.Identifier, this.sConfig);
            this.sc.CoreConfig.setServerMeta(this.sMeta.Identifier, this.sMeta);

            // Update List Box Items
            this.sc.refreshListBox();

            // Re select this config in list box
            this.sc.frmMainWindowHandle.setSelectedIndexOnList(this.sMeta.Identifier);

            // Save core Config Changes
            this.sc.CoreConfig.saveCoreConfig();

            // Saved Flag
            this.formSaved = true;

            // close Saving Dialog
            dlg.Close();

            // Close Configuration Window
            this.Close();
        }

        private static Boolean addShortcut(String ShortcutPath, String TargetPath)
        {

            try
            {
                WshShell shell = new WshShell();
                IWshShortcut link = (IWshShortcut)shell.CreateShortcut(ShortcutPath);
                link.TargetPath = TargetPath;

                if (!Directory.Exists(Path.GetDirectoryName(ShortcutPath)))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(ShortcutPath));
                }
                link.Save();

                return true;
            }
            catch
            {
                return false;
            }
        }
        private void actionSelectTabButton(object sender, EventArgs e)
        {
            this.selectAndDisplayTab(((Button)sender).Name);
        }
        private void actionProcessKeepaliveToggle(object sender, EventArgs e)
        {
            Button thisBtn = (Button)sender;
            // Set Keepalive Opposite
            if (this.getProcessFromButtonName(((Button)sender).Name).Keepalive == true)
            {
                this.getProcessFromButtonName(((Button)sender).Name).Keepalive = false;
                // Update Button Appearance
                this.setKeepaliveButtonColor(sender, true);
            }
            else
            {
                this.getProcessFromButtonName(((Button)sender).Name).Keepalive = true;
                this.setKeepaliveButtonColor(sender, false);
            }

            // Force listbox redraw
            if (this.tabPageCurrent == "Custom")
            {
                this.cBoxCustomProcessSelector.Invalidate();
            }
        }
        private void actionCancelConfig(object sender, EventArgs e)
        {
            this.Close();
        }
        private void actionPriorityChanged(object sender, EventArgs e)
        {
            if (this.pageLoaded == false) return;
            if (this.pageLoadedCustom == false) return;

            // Get object from list name
            ComboBox cBox = ((ComboBox)sender);
            String objectName = cBox.Name.Substring(12);
            String selPriority = cBox.SelectedItem.ToString().ToLower();

            skbtProcessConfigBasic thisObj = null;

            // Reflect Process Object by Name
            thisObj = (objectName == "Custom") ?
                ((Dictionary<short, skbtProcessConfigCustom>)this.sConfig.GetType().GetProperty("obj" + objectName + "Proc").GetValue(this.sConfig, null))[(short)this.selectedCustomID]
                :
                (skbtProcessConfigBasic)this.sConfig.GetType().GetProperty("obj" + objectName + "Proc").GetValue(this.sConfig, null);

            // Set new Priority
            thisObj.Priority = selPriority;

            skbtProcessConfigBasic origin = null;
            if (objectName == "Custom")
            {
                // Custom routine for these processes
                if (this.objOriginalCusProc.ContainsKey((short)this.selectedCustomID))
                {
                    origin = (skbtProcessConfigBasic)this.objOriginalCusProc[(short)this.selectedCustomID];
                }
                else
                {
                    origin = (skbtProcessConfigBasic)((Dictionary<short, skbtProcessConfigCustom>)this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier].GetType().GetProperty("obj" + objectName + "Proc").GetValue(this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier], null))[(short)this.selectedCustomID];
                }
            }
            else
            {
                origin = (skbtProcessConfigBasic) this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier].GetType().GetProperty("obj" + objectName + "Proc").GetValue(this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier], null);
            }


            // origin
            if (origin.Priority.ToLower() != thisObj.Priority.ToLower())
            {
                cBox.BackColor = changedBack;
            }
            else
            {
                cBox.BackColor = Color.FromArgb(40, 40, 40);
            }

            // Force Redraw
            if (objectName == "Custom")
            {
                this.cBoxCustomProcessSelector.Invalidate();
            }
        }
        private void actionDebugChanged(object sender, EventArgs e)
        {
            if (this.pageLoaded == false) return;

            // Get object from list name
            ComboBox cBox = ((ComboBox)sender);
            String selDebug = cBox.SelectedItem.ToString();

            this.sConfig.skbtDebugLevel = Convert.ToUInt16(selDebug[0].ToString());
            if (this.sConfig.skbtDebugLevel != this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier].skbtDebugLevel)
            {
                // red
                this.cBoxDebugLevel.BackColor = changedBack;
            }
            else
            {
                // normal
                this.cBoxDebugLevel.BackColor = Color.FromArgb(40, 40, 40);
            }
        }
        private void actionUseZipLogs(object sender, EventArgs e)
        {
            this.sConfig.objServerProc.UseZipLogs = (((CheckBox)sender).Checked == true) ? true : false;
            if (this.chkUseZipLogs.Checked != this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier].objServerProc.UseZipLogs)
            {
                // red
                this.chkUseZipLogs.ForeColor = changedFore;
            }
            else
            {
                // normal
                this.chkUseZipLogs.ForeColor = Color.FromKnownColor(KnownColor.ScrollBar);
            }
        }
        private void actionCleanWER(object sender, EventArgs e)
        {
            this.sConfig.CleanWER = (((CheckBox)sender).Checked == true) ? true : false;
            if (this.chkCleanWERs.Checked != this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier].CleanWER)
            {
                // red
                this.chkCleanWERs.ForeColor = changedFore;
            }
            else
            {
                // normal
                this.chkCleanWERs.ForeColor = Color.FromKnownColor(KnownColor.ScrollBar);
            }
        }
        private void actionUseZipBackups(object sender, EventArgs e)
        {
            this.sConfig.objDatabaseProc.UseZipBackups = (((CheckBox)sender).Checked == true) ? true : false;
            if (this.chkUseZipBackups.Checked != this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier].objDatabaseProc.UseZipBackups)
            {
                // red
                this.chkUseZipBackups.ForeColor = changedFore;
            }
            else
            {
                // normal
                this.chkUseZipBackups.ForeColor = Color.FromKnownColor(KnownColor.ScrollBar);
            }
        }
        private void actionUseBecDsc(object sender, EventArgs e)
        {
            this.sConfig.objBECProc.useDSC = (((CheckBox)sender).Checked == true) ? true : false;
            if (this.chkBecUseDsc.Checked != this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier].objBECProc.useDSC)
            {
                // red
                this.chkBecUseDsc.ForeColor = changedFore;
            }
            else
            {
                // normal
                this.chkBecUseDsc.ForeColor = Color.FromKnownColor(KnownColor.ScrollBar);
            }
        }
        private void actionServerPortChanged(object sender, EventArgs e)
        {
            this.sConfig.objServerProc.Port = (UInt16)((NumericUpDown)sender).Value;
            if ((int)this.numServerPort.Value != (int)this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier].objServerProc.Port)
            {
                // red
                this.numServerPort.ForeColor = changedFore;
            }
            else
            {
                // normal
                this.numServerPort.ForeColor = Color.FromKnownColor(KnownColor.ScrollBar);
            }
        }
        private void actionAutoDelayChanged(object sender, EventArgs e)
        {
            this.sConfig.AutoRestartDelay = (UInt16)((NumericUpDown)sender).Value;
            int originVal = (int)this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier].AutoRestartDelay;
            if ((int)this.numAutoDelay.Value != originVal)
            {
                // red
                this.numAutoDelay.ForeColor = changedFore;
            }
            else
            {
                // normal
                this.numAutoDelay.ForeColor = Color.FromKnownColor(KnownColor.ScrollBar);
            }
        }
        private void actionAutoTimeoutChanged(object sender, EventArgs e)
        {
            this.sConfig.AutoTimeoutLength = (UInt16)((NumericUpDown)sender).Value;
            int originVal = (int)this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier].AutoTimeoutLength;
            if ((int)this.numAutoTimeout.Value != originVal)
            {
                // red
                this.numAutoTimeout.ForeColor = changedFore;
            }
            else
            {
                // normal
                this.numAutoTimeout.ForeColor = Color.FromKnownColor(KnownColor.ScrollBar);
            }
        }
        private void actionManualTimeoutChanged(object sender, EventArgs e)
        {
            this.sConfig.ManualTimeoutLength = (UInt16)((NumericUpDown)sender).Value;
            int originVal = (int)this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier].ManualTimeoutLength;
            if ((int)this.numManualTimeout.Value != originVal)
            {
                // red
                this.numManualTimeout.ForeColor = changedFore;
            }
            else
            {
                // normal
                this.numManualTimeout.ForeColor = Color.FromKnownColor(KnownColor.ScrollBar);
            }
        }
        private void actionStartTimeoutChanged(object sender, EventArgs e)
        {
            this.sConfig.ServerStartTimeout = (UInt16)((NumericUpDown)sender).Value;
            int originVal = (int)this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier].ServerStartTimeout;
            if ((int)this.numStartTimeout.Value != originVal)
            {
                // red
                this.numStartTimeout.ForeColor = changedFore;
            }
            else
            {
                // normal
                this.numStartTimeout.ForeColor = Color.FromKnownColor(KnownColor.ScrollBar);
            }
        }
        private void actionTeamspeakPortChanged(object sender, EventArgs e)
        {
            this.sConfig.objTeamspeakProc.PortNumber = (UInt16)((NumericUpDown)sender).Value;
            if ((int)this.numTeamspeakPortNumber.Value != (int)this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier].objTeamspeakProc.PortNumber)
            {
                // red
                this.numTeamspeakPortNumber.ForeColor = changedFore;
            }
            else
            {
                // normal
                this.numTeamspeakPortNumber.ForeColor = Color.FromKnownColor(KnownColor.ScrollBar);
            }
        }
        private void actionBackupIntervalChanged(object sender, EventArgs e)
        {
            this.sConfig.objDatabaseProc.DatabaseBackupInterval = (UInt32)((NumericUpDown)sender).Value;
            if ((int)this.numBackupInterval.Value != (int)this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier].objDatabaseProc.DatabaseBackupInterval)
            {
                // red
                this.numBackupInterval.ForeColor = changedFore;
            }
            else
            {
                // normal
                this.numBackupInterval.ForeColor = Color.FromKnownColor(KnownColor.ScrollBar);
            }
        }
        private void actionASMLogIntervalChanged(object sender, EventArgs e)
        {
            this.sConfig.objASMProc.LogInterval = (UInt16)((NumericUpDown)sender).Value;
            if ((int)this.numASMLogInterval.Value != (int)this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier].objASMProc.LogInterval)
            {
                // red
                this.numASMLogInterval.ForeColor = changedFore;
            }
            else
            {
                // normal
                this.numASMLogInterval.ForeColor = Color.FromKnownColor(KnownColor.ScrollBar);
            }
        }
        private void actionServerModLineTouched(object sender, EventArgs e)
        {
            this.sConfig.objServerProc.ModLine = ((TextBox)sender).Text;

            if (this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier].objServerProc.ModLine != ((TextBox)sender).Text)
            {
                ((TextBox)sender).BackColor = this.changedBack;
            }
            else
            {
                ((TextBox)sender).BackColor = Color.FromArgb(64, 64, 64);
            }
        }
        private void actionServerCmdLineTouched(object sender, EventArgs e)
        {
            this.sConfig.objServerProc.CommandLine = ((TextBox)sender).Text;

            if (this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier].objServerProc.CommandLine != ((TextBox)sender).Text)
            {
                ((TextBox)sender).BackColor = this.changedBack;
            }
            else
            {
                ((TextBox)sender).BackColor = Color.FromArgb(64, 64, 64);
            }
        }
        private void actionConfigNameTouched(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Length < 1)
            {
                MessageBox.Show("Please choose a name with 1 or more characters.",
                    "Name too short",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);
                ((TextBox)sender).Text = this.sMeta.textualName;
                return;
            }
            this.sMeta.textualName = ((TextBox)sender).Text;

            if (this.sc.CoreConfig.getServerMetaObject(this.sMeta.Identifier).textualName != ((TextBox)sender).Text)
            {
                ((TextBox)sender).BackColor = this.changedBack;
            }
            else
            {
                ((TextBox)sender).BackColor = Color.FromArgb(64, 64, 64);
            }
        }
        private void actionCustomProcessNameTouched(object sender, KeyEventArgs e)
        {
            if (((TextBox)sender).Text.Length < 1)
            {
                MessageBox.Show("Please choose a name with 1 or more characters.",
                    "Name too short",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);
                ((TextBox)sender).Text = this.sConfig.objCustomProc[(short)this.selectedCustomID].Name;
                return;
            }
            this.sConfig.objCustomProc[(short)this.selectedCustomID].Name = ((TextBox)sender).Text;

            string name;
            // origin name
            if (this.objOriginalCusProc.ContainsKey((short)this.selectedCustomID))
            {
                // new process
                name = this.objOriginalCusProc[(short)this.selectedCustomID].Name;
            }
            else
            {
                name = this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier].objCustomProc[(short)this.selectedCustomID].Name;
            }

            if (name != ((TextBox)sender).Text)
            {
                ((TextBox)sender).BackColor = this.changedBack;
            }
            else
            {
                ((TextBox)sender).BackColor = Color.FromArgb(64, 64, 64);
            }

            // Update Listbox Value
            ComboboxItem cBox = new ComboboxItem();
            cBox.Text = ((TextBox)sender).Text;
            cBox.Value = (short)this.selectedCustomID;
            this.cBoxCustomProcessSelector.Items[this.cBoxCustomProcessSelector.SelectedIndex] = cBox;
        }
        private void actionCustomProcessNameKeyDown(object sender, EventArgs e)
        {
            // Updates Listbox Value in Realtime

        }
        private void actionCustomProcessLPTouched(object sender, EventArgs e)
        {
            this.sConfig.objCustomProc[(short)this.selectedCustomID].LaunchParams = ((TextBox)sender).Text;

            // origin
            string lp;
            if (this.objOriginalCusProc.ContainsKey((short)this.selectedCustomID))
            {
                lp = this.objOriginalCusProc[(short)this.selectedCustomID].LaunchParams;
            }
            else
            {
                lp = this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier].objCustomProc[(short)this.selectedCustomID].LaunchParams;
            }

            if (lp != ((TextBox)sender).Text)
            {
                ((TextBox)sender).BackColor = this.changedBack;
            }
            else
            {
                ((TextBox)sender).BackColor = Color.FromArgb(64, 64, 64);
            }
            this.cBoxCustomProcessSelector.Invalidate();
        }
        private void actionHeadlessClientParamsTouched(object sender, EventArgs e)
        {
            this.sConfig.objHeadlessClientProc.LaunchParams = ((TextBox)sender).Text;

            if (this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier].objHeadlessClientProc.LaunchParams != ((TextBox)sender).Text)
            {
                ((TextBox)sender).BackColor = this.changedBack;
            }
            else
            {
                ((TextBox)sender).BackColor = Color.FromArgb(64, 64, 64);
            }
        }
        private void actionBindToIpChanged(object sender, EventArgs e)
        {
            this.sConfig.BindToIP = this.chkServerBindToIP.Checked;

            if (this.chkServerBindToIP.Checked != this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier].BindToIP)
            {
                // red
                this.chkServerBindToIP.ForeColor = changedFore;
            }
            else
            {
                // normal
                this.chkServerBindToIP.ForeColor = Color.FromKnownColor(KnownColor.ScrollBar);
            }
        }
        private void actionServerIPChanged(object sender, EventArgs e)
        {
            if (this.pageLoaded==false) return;
            // Full Ip
            this.sConfig.IP = this.numServerIP1.Value.ToString() + "." + this.numServerIP2.Value.ToString() + "." + this.numServerIP3.Value.ToString() + "." + this.numServerIP4.Value.ToString();

            if(this.sConfig.IP != this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier].IP){
                // set boxes red
                this.numServerIP1.ForeColor = changedFore;
                this.numServerIP2.ForeColor = changedFore;
                this.numServerIP3.ForeColor = changedFore;
                this.numServerIP4.ForeColor = changedFore;
            }
            else
            {
                // set boxes normal
                this.numServerIP1.ForeColor = Color.FromKnownColor(KnownColor.ScrollBar);
                this.numServerIP2.ForeColor = Color.FromKnownColor(KnownColor.ScrollBar);
                this.numServerIP3.ForeColor = Color.FromKnownColor(KnownColor.ScrollBar);
                this.numServerIP4.ForeColor = Color.FromKnownColor(KnownColor.ScrollBar);
            }
            
        }
        private void actionDelegateBrowseAction(userPathHandleDialog dDialog, userPathValidation dValidation, userPathSetWithCondition dSetWithCondition, userPathColorCheck dColorCheck)
        {
            if (dDialog == null || dValidation == null || dSetWithCondition == null || dColorCheck == null) { return; }
            String nulref="";
            this.actionDelegateBrowseAction(null, null, ref nulref, dDialog, dValidation, dSetWithCondition, dColorCheck);
        }
        private void actionDelegateBrowseAction(TextBox txtThis, String originPath, ref String currentPath, userPathHandleDialog dDialog, userPathValidation dValidation, userPathSetWithCondition dSetWithCondition=null, userPathColorCheck dColorCheck=null)
        {

            // Show Dialog
            String newPath = this.CollapsePathVars(dDialog());

            // might use later
            if (newPath == null) { return; }

            // Validate
            String validResult = (dValidation == null)? null : dValidation(newPath);

            // Check if validation was succesfull
            if (validResult == null)
            {


                // Change text box and internal config data to reflect succesfull path selection
                if (dSetWithCondition != null) { dSetWithCondition(newPath); }
                else if(txtThis != null) { txtThis.Text = currentPath = this.CollapsePathVars(newPath); }
                else { /* Internal error fall silently */ }

                // Do Color checks
                if (dColorCheck != null) { dColorCheck(newPath); }
                else if (txtThis == null)
                {
                    MessageBox.Show("Internal Error #5461353",
                        "Internal Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
                }
                else { txtThis.BackColor = (this.CollapsePathVars(originPath).ToLower() != newPath.ToLower()) ? this.changedBack : Color.FromArgb(64, 64, 64); }
            }
            // Failed Validation with Message
            else if (validResult != "silent")
            {
                MessageBox.Show(validResult,
                    "Couldn't change path/file",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);
            }
        }
        private void actionBrowseButtonForFilePath(object sender, EventArgs e)
        {
            // Show custom dialogs for each browser button.

            String newPath;

            switch (((Button)sender).Name)
            {
                case "btnFortxtPathToBackupLog":    // Choose Folder

                    this.actionDelegateBrowseAction(
                        // TEXT BOX
                        this.txtPathToBackupLog,
                        // ORIGIN PATH STRING
                        this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier].objServerProc.LogFileBackupPath,
                        // REF TO CURRENT PATH STRING
                        ref this.sConfig.objServerProc.LogFileBackupPath,
                        // DIALOG
                        (userPathHandleDialog) delegate(){
                            return this.CollapsePathVars(showFolderDialog(
                                "Choose a folder to store log backup files.",
                                this.ExpandPathVars(this.sConfig.objServerProc.LogFileBackupPath)
                            ));
                        },
                        // VALIDATION
                        null
                    );

                    return;

                case "btnFortxtPathToBackupFolder": // Choose Folder

                    this.actionDelegateBrowseAction(
                        // TEXT BOX
                        this.txtPathToBackupFolder,
                        // ORIGIN PATH STRING
                        this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier].objDatabaseProc.BackupFolder,
                        // REF TO CURRENT PATH STRING
                        ref this.sConfig.objDatabaseProc.BackupFolder,
                        // DIALOG
                        (userPathHandleDialog)delegate()
                    {
                        return this.CollapsePathVars(showFolderDialog(
                            "Choose a folder to store database backup files.",
                            this.ExpandPathVars(this.sConfig.objDatabaseProc.BackupFolder)
                        ));
                    },
                        // VALIDATION
                        null
                    );
                    return;

                case "btnFortxtPathToBattleye":     // Choose Folder

                    this.actionDelegateBrowseAction(
                        // TEXT BOX
                        this.txtPathToBattleye,
                        // ORIGIN PATH STRING
                        this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier].objBECProc.BEPath,
                        // REF TO CURRENT PATH STRING
                        ref this.sConfig.objBECProc.BEPath,
                        // DIALOG
                        (userPathHandleDialog)delegate()
                        {
                            return this.CollapsePathVars(showFolderDialog(
                                "Choose the folder where your battleye logs are stored.",
                                this.ExpandPathVars(this.sConfig.objBECProc.BEPath)
                            ));
                        },
                        // VALIDATION
                        null
                    );
                    return;

                case "btnFortxtPathToServerLog":    // Open File Server Log (*.log)

                    this.actionDelegateBrowseAction(
                        // TEXT BOX
                        this.txtPathToServerLog,
                        // ORIGIN PATH STRING
                        this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier].objServerProc.LogFilePath,
                        // REF TO CURRENT PATH STRING
                        ref this.sConfig.objServerProc.LogFilePath,
                        // DIALOG
                        (userPathHandleDialog)delegate()
                        {
                            return Path.GetDirectoryName(showOpenFileDialog(
                               "Select the Arma Server Log file (server.log?)",
                               "server.log",
                               "Arma Server Log File|*.log",
                               this.ExpandPathVars(this.sConfig.objServerProc.LogFilePath)
                           ));
                        },
                        // VALIDATION
                        (userPathValidation)delegate(String newPathStr)
                        {
                            if (!Directory.Exists(this.ExpandPathVars(newPathStr)) || this.ExpandPathVars(this.sConfig.objServerProc.LogFilePath) == this.ExpandPathVars(newPathStr))
                            {
                                return "silent";
                            }
                            else
                            {
                                return null;
                            }
                        }
                    );
                    return;

                case "btnFortxtPathToProfile":      // Open File Profile (*.Arma3Profile)

                    // Figure out where to start file dialog
                    String startFolder = this.ExpandPathVars(this.sConfig.objServerProc.ProfilePath);

                    // Check if path is absolute or relative
                    if (startFolder[0] != '\\' && startFolder[0] != ':' && startFolder[1] != ':' && startFolder[0] != '/')
                    {
                        // Position is Relative
                        startFolder = Path.Combine(Path.GetDirectoryName(this.sMeta.PathToEXE), startFolder, "Users", this.sConfig.objServerProc.ProfileName);
                    }

                    profilePathProcessor processor = delegate(String profilePath)
                    {
                        // Get Profile Name
                        String profileFileName = Path.GetFileNameWithoutExtension(this.ExpandPathVars(profilePath));

                        // Get Profile Directory
                        String profileFolder = this.CollapsePathVars(Path.GetDirectoryName(this.ExpandPathVars(profilePath)));

                        // Should we shorten profile path?
                        if (profileFolder.Contains("%armapath%\\") || profileFolder.Contains("%armapath:\"=%\\"))
                        {
                            // Shorten Path
                            profileFolder = profileFolder.Replace("%armapath%\\", "");
                            profileFolder = profileFolder.Replace("%armapath:\"=%\\", "");
                            profileFolder = profileFolder.Replace(
                                profileFolder.Substring(profileFolder.Length - (@"\Users\" + profileFileName).Length),
                                ""
                            );
                        }

                        return profileFolder;
                    };

                    this.actionDelegateBrowseAction(
                        // DIALOG
                        (userPathHandleDialog)delegate()
                        {
                            return showOpenFileDialog(
                                "Select the profile associated with this instance",
                                this.sConfig.objServerProc.ProfileName + ".Arma3Profile",
                                "Arma Profile|*.Arma3Profile",
                                startFolder
                            );
                        },
                        // VALIDATION
                        (userPathValidation)delegate(String newPathStr)
                        {
                            if (startFolder != this.ExpandPathVars(newPathStr) && System.IO.File.Exists(this.ExpandPathVars(newPathStr)))
                            {
                                // Get Profile Name
                                String profileFileName = Path.GetFileNameWithoutExtension(this.ExpandPathVars(newPathStr));

                                String UserFolderName = Path.GetDirectoryName(
                                    this.ExpandPathVars(newPathStr)).Replace(Path.GetDirectoryName(Path.GetDirectoryName(this.ExpandPathVars(newPathStr))) + @"\", ""
                                    );
                                // If User Folder name != Profile File Name
                                if ((this.CollapsePathVars(newPathStr).Contains("%armapath%") || this.CollapsePathVars(newPathStr).Contains("%armapath:\"=%")) && UserFolderName != profileFileName)
                                {
                                    // Path not valid
                                    return "Cancelled, Your Profile Filename (" + profileFileName + ".Arma#Profile) must match your Profile Folder Name (" + UserFolderName + ")...";
                                }
                                else
                                {
                                    return null;
                                }
                            }else{
                                return "silent";
                            }
                        },
                        // UPDATE FIELDS/PROPERTIES (if Valid)
                        (userPathSetWithCondition)delegate(String newPathStr)
                        {
                            String profileFileName = Path.GetFileNameWithoutExtension(this.ExpandPathVars(newPathStr));

                            // Get Profile Path (Shortened)
                            String profilePath = processor(newPathStr);

                            // Set Properties to Result Values
                            this.txtPathToProfile.Text = this.sConfig.objServerProc.ProfilePath = profilePath;
                            this.txtProfileName.Text = this.sConfig.objServerProc.ProfileName = profileFileName;
                        },
                        // SET TEXTBOX COLOR (if Valid)
                        (userPathColorCheck)delegate(String newPathStr)
                        {
                            // Get Profile Name
                            String profileFileName = Path.GetFileNameWithoutExtension(this.ExpandPathVars(newPathStr));

                            // Get Profile Path (Shortened)
                            String profilePath = processor(newPathStr);

                            // Default Colors
                            this.txtPathToProfile.BackColor = this.txtProfileName.BackColor = Color.FromArgb(64, 64, 64);

                            // Check if Value same as Origin Value
                            if (profileFileName != this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier].objServerProc.ProfileName)
                            {
                                this.txtProfileName.BackColor = this.changedBack;
                            }

                            // Check if Value same as Origin Value
                            if (profilePath != this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier].objServerProc.ProfilePath)
                            {
                                this.txtPathToProfile.BackColor = this.changedBack;
                            }
                        }
                    );

                    return;

                case "btnFortxtPathToDBFile":       // Open File Database Dump (*.*)

                    this.actionDelegateBrowseAction(
                        // TEXT BOX
                        this.txtPathToDBFile,
                        // ORIGIN PATH STRING
                        Path.Combine(
                            this.ExpandPathVars(this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier].objDatabaseProc.DatabaseDumpFilePath), 
                            this.ExpandPathVars(this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier].objDatabaseProc.DatabaseDumpFileName)
                        ),
                        // REF TO CURRENT PATH STRING
                        ref this.sConfig.objDatabaseProc.DatabaseDumpFilePath,
                        // DIALOG
                        (userPathHandleDialog)delegate()
                        {
                            return this.CollapsePathVars(showOpenFileDialog(
                                "Select the database dump (or storage) file to backup",
                                "dump.rdb",
                                "Database File|*.*",
                                this.ExpandPathVars(this.sConfig.objDatabaseProc.DatabaseDumpFilePath)
                            ));
                        },
                        // VALIDATION
                        (userPathValidation)delegate(String newPathStr)
                        {
                            if (
                                Path.Combine(
                                    this.ExpandPathVars(this.sConfig.objDatabaseProc.DatabaseDumpFilePath), 
                                    this.ExpandPathVars(this.sConfig.objDatabaseProc.DatabaseDumpFileName)) 
                                == newPathStr
                                || !System.IO.File.Exists(this.ExpandPathVars(newPathStr)))
                            {
                                return "silent";
                            }
                            else
                            {
                                return null;
                            }
                        },
                        // SET WITH CONDITION
                        (userPathSetWithCondition)delegate(String newPathStr)
                        {
                            this.txtPathToDBFile.Text = newPathStr;
                            this.sConfig.objDatabaseProc.DatabaseDumpFilePath = this.CollapsePathVars(Path.GetDirectoryName(this.ExpandPathVars(newPathStr)));
                            this.sConfig.objDatabaseProc.DatabaseDumpFileName = Path.GetFileName(this.ExpandPathVars(newPathStr));
                        }
                    );
                    return;

                case "btnFortxtPathToBasicCFG":     // Open File Config Basic (*.cfg)

                    this.actionDelegateBrowseAction(
                        // TEXT BOX
                        this.txtPathToBasicCFG,
                        // ORIGIN PATH STRING
                        this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier].objServerProc.ConfigPathBasic,
                        // REF TO CURRENT PATH STRING
                        ref this.sConfig.objServerProc.ConfigPathBasic,
                        // DIALOG
                        (userPathHandleDialog)delegate()
                        {
                            return showOpenFileDialog(
                                "Select the basic .cfg file",
                                "basic.cfg",
                                "Arma Config File|*.cfg",
                                Path.GetDirectoryName(this.ExpandPathVars(this.sConfig.objServerProc.ConfigPathBasic))
                           );
                        },
                        // VALIDATION
                        (userPathValidation)delegate(String newPathStr)
                        {
                            if (this.sConfig.objServerProc.ConfigPathBasic == newPathStr || !System.IO.File.Exists(this.ExpandPathVars(newPathStr)))
                            { return "silent"; }
                            else { return null; }
                        }
                    );
                    return;

                case "btnFortxtPathToConfigCFG":    // Open File Config Server (*.cfg)

                    this.actionDelegateBrowseAction(
                        // TEXT BOX
                        this.txtPathToConfigCFG,
                        // ORIGIN PATH STRING
                        this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier].objServerProc.ConfigPathServer,
                        // REF TO CURRENT PATH STRING
                        ref this.sConfig.objServerProc.ConfigPathServer,
                        // DIALOG
                        (userPathHandleDialog)delegate()
                        {
                            return showOpenFileDialog(
                                "Select the server/config .cfg file",
                                "server.cfg",
                                "Arma Config File|*.cfg",
                                Path.GetDirectoryName(this.ExpandPathVars(this.sConfig.objServerProc.ConfigPathServer))
                           );
                        },
                        // VALIDATION
                        (userPathValidation)delegate(String newPathStr)
                        {
                            if (this.sConfig.objServerProc.ConfigPathServer == newPathStr || !System.IO.File.Exists(this.ExpandPathVars(newPathStr)))
                            { return "silent"; }
                            else { return null; }
                        }
                    );
                    return;

                // for now this function is DISABLED (buttons disabled on form) 
                case "btnFortxtPathToEXEServer":    // Open File Server EXE (*.exe)

                    return;

                case "btnFortxtPathToEXEDB":        // Open File Database EXE (*.exe)

                    String dbPath = this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier].objDatabaseProc.Path;
                    String dbFile = this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier].objDatabaseProc.EXEFile;
                    String originPathStr = Path.Combine(this.ExpandPathVars(dbPath), this.ExpandPathVars(dbFile));

                    this.actionDelegateBrowseAction(
                        // TEXT BOX
                        this.txtPathToEXEDB,
                        // ORIGIN PATH STRING
                        originPathStr,
                        // REF TO CURRENT PATH STRING
                        ref this.sConfig.objDatabaseProc.Path,
                        // DIALOG
                        (userPathHandleDialog)delegate()
                        {
                            return showOpenFileDialog(
                                "Select the database server executable",
                                this.sConfig.objDatabaseProc.EXEFile,
                                "Database EXE|*.exe",
                                this.ExpandPathVars(this.sConfig.objDatabaseProc.Path)
                           );
                        },
                        // VALIDATION
                        (userPathValidation)delegate(String newPathStr)
                        {
                            var current = this.ExpandPathVars(Path.Combine(this.ExpandPathVars(this.sConfig.objDatabaseProc.Path), this.sConfig.objDatabaseProc.EXEFile));
                            var newP = this.ExpandPathVars(newPathStr);

                            if (current == newP || !System.IO.File.Exists(newP)) { return "silent"; }
                            else { return null; }
                        },
                        // SET WITH CONDITION
                        (userPathSetWithCondition)delegate(String newPathStr)
                        {
                            this.txtPathToEXEDB.Text = newPathStr;
                            this.sConfig.objDatabaseProc.EXEFile = Path.GetFileName(this.ExpandPathVars(newPathStr));
                            this.sConfig.objDatabaseProc.Path = Path.GetDirectoryName(this.ExpandPathVars(newPathStr));
                        }
                    );
                    return;

                case "btnFortxtPathToEXEBEC":       // Open File BEC (*.exe)

                    this.actionDelegateBrowseAction(
                        // TEXT BOX
                        this.txtPathToEXEBEC,
                        // ORIGIN PATH STRING
                        Path.Combine(this.ExpandPathVars(this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier].objBECProc.Path), this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier].objBECProc.EXEFile),
                        // REF TO CURRENT PATH STRING
                        ref this.sConfig.objBECProc.Path,
                        // DIALOG
                        (userPathHandleDialog)delegate()
                        {
                            return showOpenFileDialog(
                                "Select the BEC executable",
                                this.sConfig.objBECProc.EXEFile,
                                "BEC EXE|*.exe",
                                this.ExpandPathVars(this.sConfig.objBECProc.Path)
                           );
                        },
                        // VALIDATION
                        (userPathValidation)delegate(String newPathStr)
                        {
                            var current = Path.Combine(this.ExpandPathVars(this.sConfig.objBECProc.Path), this.sConfig.objBECProc.EXEFile);
                            var newP = this.ExpandPathVars(newPathStr);

                            if (current == newP || !System.IO.File.Exists(newP)) { return "silent"; }
                            else { return null; }
                        },
                        // SET WITH CONDITION
                        (userPathSetWithCondition)delegate(String newPathStr)
                        {
                            this.txtPathToEXEBEC.Text = newPathStr;
                            this.sConfig.objBECProc.EXEFile = Path.GetFileName(this.ExpandPathVars(this.txtPathToEXEBEC.Text));
                            this.sConfig.objBECProc.Path = Path.GetDirectoryName(this.ExpandPathVars(this.txtPathToEXEBEC.Text));
                        }
                    );
                    return;

                case "btnFortxtPathToEXEHC":        // Open File HC (*.exe)

                    this.actionDelegateBrowseAction(
                        // TEXT BOX
                        this.txtPathToEXEHC,
                        // ORIGIN PATH STRING
                        Path.Combine(this.ExpandPathVars(this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier].objHeadlessClientProc.Path), this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier].objHeadlessClientProc.EXEFile),
                        // REF TO CURRENT PATH STRING
                        ref this.sConfig.objHeadlessClientProc.Path,
                        // DIALOG
                        (userPathHandleDialog)delegate()
                        {
                            return showOpenFileDialog(
                                "Select the Headless Client executable",
                                this.sConfig.objHeadlessClientProc.EXEFile,
                                "Headless Cli EXE|*.exe",
                                this.ExpandPathVars(this.sConfig.objHeadlessClientProc.Path)
                           );
                        },
                        // VALIDATION
                        (userPathValidation)delegate(String newPathStr)
                        {
                            var current = Path.Combine(this.ExpandPathVars(this.sConfig.objHeadlessClientProc.Path), this.sConfig.objHeadlessClientProc.EXEFile);
                            var newP = this.ExpandPathVars(newPathStr);

                            if (current == newP || !System.IO.File.Exists(newP)) { return "silent"; }
                            else { return null; }
                        },
                        // SET WITH CONDITION
                        (userPathSetWithCondition)delegate(String newPathStr)
                        {
                            this.txtPathToEXEHC.Text = newPathStr;
                            this.sConfig.objHeadlessClientProc.EXEFile = Path.GetFileName(this.ExpandPathVars(this.txtPathToEXEHC.Text));
                            this.sConfig.objHeadlessClientProc.Path = Path.GetDirectoryName(this.ExpandPathVars(this.txtPathToEXEHC.Text));
                        }
                    );
                    return;

                case "btnFortxtPathToEXETS":        // Open File TS (*.exe)

                    this.actionDelegateBrowseAction(
                        // TEXT BOX
                        this.txtPathToEXETS,
                        // ORIGIN PATH STRING
                        Path.Combine(this.ExpandPathVars(this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier].objTeamspeakProc.Path), this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier].objTeamspeakProc.EXEFile),
                        // REF TO CURRENT PATH STRING
                        ref this.sConfig.objTeamspeakProc.Path,
                        // DIALOG
                        (userPathHandleDialog)delegate()
                        {
                            return showOpenFileDialog(
                                "Select the Teamspeak server executable",
                                this.sConfig.objTeamspeakProc.EXEFile,
                                "Teamspeak EXE|*.exe",
                                this.ExpandPathVars(this.sConfig.objTeamspeakProc.Path)
                           );
                        },
                        // VALIDATION
                        (userPathValidation)delegate(String newPathStr)
                        {
                            var current = Path.Combine(this.ExpandPathVars(this.sConfig.objTeamspeakProc.Path), this.sConfig.objTeamspeakProc.EXEFile);
                            var newP = this.ExpandPathVars(newPathStr);

                            if (current == newP || !System.IO.File.Exists(newP)) { return "silent"; }
                            else { return null; }
                        },
                        // SET WITH CONDITION
                        (userPathSetWithCondition)delegate(String newPathStr)
                        {
                            this.txtPathToEXETS.Text = newPathStr;
                            this.sConfig.objTeamspeakProc.EXEFile = Path.GetFileName(this.ExpandPathVars(this.txtPathToEXETS.Text));
                            this.sConfig.objTeamspeakProc.Path = Path.GetDirectoryName(this.ExpandPathVars(this.txtPathToEXETS.Text));
                        }
                    );
                    return;

                case "btnFortxtPathToEXEASM":       // Open File ASM (*.exe)

                    this.actionDelegateBrowseAction(
                        // TEXT BOX
                        this.txtPathToEXEASM,
                        // ORIGIN PATH STRING
                        Path.Combine(this.ExpandPathVars(this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier].objASMProc.Path), this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier].objASMProc.EXEFile),
                        // REF TO CURRENT PATH STRING
                        ref this.sConfig.objASMProc.Path,
                        // DIALOG
                        (userPathHandleDialog)delegate()
                        {
                            return showOpenFileDialog(
                                "Select the Arma Server Monitor executable",
                                this.sConfig.objASMProc.EXEFile,
                                "ASM EXE|*.exe",
                                this.ExpandPathVars(this.sConfig.objASMProc.Path)
                           );
                        },
                        // VALIDATION
                        (userPathValidation)delegate(String newPathStr)
                        {
                            var current = Path.Combine(this.ExpandPathVars(this.sConfig.objASMProc.Path), this.sConfig.objASMProc.EXEFile);
                            var newP = this.ExpandPathVars(newPathStr);

                            if (current == newP || !System.IO.File.Exists(newP)) { return "silent"; }
                            else { return null; }
                        },
                        // SET WITH CONDITION
                        (userPathSetWithCondition)delegate(String newPathStr)
                        {
                            this.txtPathToEXEASM.Text = newPathStr;
                            this.sConfig.objASMProc.EXEFile = Path.GetFileName(this.ExpandPathVars(this.txtPathToEXEASM.Text));
                            this.sConfig.objASMProc.Path = Path.GetDirectoryName(this.ExpandPathVars(this.txtPathToEXEASM.Text));
                        }
                    );
                    return;

                case "btnCustomProcessBrowseEXE":       // Open File Custom Process (*.exe)

                    skbtProcessConfigCustom originObj;
                    if (this.objOriginalCusProc.ContainsKey((short)this.selectedCustomID))
                    {
                        originObj = this.objOriginalCusProc[(short)this.selectedCustomID];
                    }
                    else
                    {
                        originObj = this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier].objCustomProc[(short)this.selectedCustomID];
                    }

                   string origin = Path.GetFullPath(Path.Combine(this.ExpandPathVars(originObj.Path), originObj.EXEFile));

                    this.actionDelegateBrowseAction(
                        // TEXT BOX
                        this.txtPathToEXECustom,
                        // ORIGIN PATH STRING
                        origin,
                        // REF TO CURRENT PATH STRING
                        ref this.sConfig.objCustomProc[(short)this.selectedCustomID].Path,
                        // DIALOG
                        (userPathHandleDialog)delegate()
                        {
                            return showOpenFileDialog(
                                "Select the custom process executable",
                                this.sConfig.objCustomProc[(short)this.selectedCustomID].EXEFile,
                                "CUSTOM EXE|*.exe",
                                this.ExpandPathVars(this.sConfig.objCustomProc[(short)this.selectedCustomID].Path)
                           );
                        },
                        // VALIDATION
                        (userPathValidation)delegate(String newPathStr)
                        {
                            var current = Path.GetFullPath(this.sConfig.objCustomProc[(short)this.selectedCustomID].Path).ToLower();
                            var newP = Path.GetFullPath(this.ExpandPathVars(newPathStr)).ToLower();

                            if (current.ToLower() == newP.ToLower() || !System.IO.File.Exists(newP)) { return "silent"; }

                            // Check if used elsewhere (returns null if OK/Error Message if not)
                            return this.isPathInUse(newP);
                        },
                        // SET WITH CONDITION
                        (userPathSetWithCondition)delegate(String newPathStr)
                        {
                            this.txtPathToEXECustom.Text = newPathStr;
                            this.sConfig.objCustomProc[(short)this.selectedCustomID].EXEFile = Path.GetFileName(this.ExpandPathVars(this.txtPathToEXECustom.Text));
                            this.sConfig.objCustomProc[(short)this.selectedCustomID].Path = Path.GetDirectoryName(this.ExpandPathVars(this.txtPathToEXECustom.Text));
                        },
                        // SET TEXTBOX COLOR (if Valid)
                        (userPathColorCheck)delegate(String newPathStr)
                        {
                            // get origin
                            skbtProcessConfigCustom cProc;
                            if (this.objOriginalCusProc.ContainsKey((short) this.selectedCustomID))
                            {
                                // New Process
                                cProc = this.objOriginalCusProc[(short)this.selectedCustomID];
                            }
                            else
                            {
                                // Get Obj
                                cProc = this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier].objCustomProc[(short)this.selectedCustomID];
                            }

                            // get current
                            skbtProcessConfigCustom cProcNow = this.sConfig.objCustomProc[(short)this.selectedCustomID];

                            // Default Colors
                            this.txtPathToEXECustom.BackColor = Color.FromArgb(64, 64, 64);

                            // Check if Value same as Origin Value
                            if (Path.GetFullPath(Path.Combine(cProc.Path, cProc.EXEFile)).ToLower() != Path.GetFullPath(Path.Combine(cProcNow.Path, cProcNow.EXEFile)).ToLower())
                            {
                                this.txtPathToEXECustom.BackColor = this.changedBack;
                            }
                            this.cBoxCustomProcessSelector.Invalidate();
                        }
                    );

                    return;

                // DISABLED
                case "btnFortxtArmaExePath":        // Open File Server EXE (*.exe) -- not used
                    // Need to check if this path is in use.
                    // Need to check if this path is installed/has batch_lib etc. myabe prompt to load/override or cancel batch settings already found.
                    return;

                case "btnFortxtBatchSettingsPath":  // Save File Batch Settings (*.cmd)

                    Boolean Cancelled = false;
                    this.actionDelegateBrowseAction(
                        // TEXT BOX
                        this.txtBatchSettingsPath,
                        // ORIGIN PATH STRING
                        this.sc.CoreConfig.getServerMetaObject(this.sMeta.Identifier).PathToConfig,
                        // REF TO CURRENT PATH STRING
                        ref this.sMeta.PathToConfig,
                        // DIALOG
                        (userPathHandleDialog)delegate()
                        {
                            return this.showSaveFileDialog(
                                "Select new settings location",
                                (Path.GetFileName(this.sMeta.PathToConfig) == null) ? "batch_settings.cmd" : Path.GetFileName(this.sMeta.PathToConfig),
                                "Batch Tools Settings |*.cmd",
                                Path.GetDirectoryName(this.sMeta.PathToConfig),
                                "cmd",
                                true
                            );
                        },
                        // VALIDATION
                        (userPathValidation)delegate(String newPathStr)
                        {
                            if (this.sMeta.PathToConfig.ToLower() == newPathStr.ToLower())
                            { return "silent"; }
                            else { return null; }
                        },
                        // SET WITH CONDITION
                        (userPathSetWithCondition)delegate(String newPathStr)
                        {
                            String originPath = this.sc.CoreConfig.getServerMetaObject(this.sMeta.Identifier).PathToConfig.ToLower();
                            // Different from origin
                            if (originPath != newPathStr.ToLower() && System.IO.File.Exists(originPath) && this.sMeta.isInstalled == true)
                            {
                                DialogResult dRes = MessageBox.Show(
                                    "Would you like to keep the old config file?"
                                        + "\n\n Note: Changes will not take effect until you click \"SAVE\"",
                                    "Rename Config",
                                    MessageBoxButtons.YesNoCancel,
                                    MessageBoxIcon.Warning,
                                    MessageBoxDefaultButton.Button1);

                                if (dRes == DialogResult.Yes)
                                {
                                    this.onSaveRenameConfig = false;
                                }
                                else if (dRes == DialogResult.No)
                                {
                                    this.onSaveRenameConfig = true;
                                }
                                else if (dRes == DialogResult.Cancel)
                                {
                                    Cancelled = true;
                                    return;
                                }
                            }
                            else
                            {
                                // reset
                                this.onSaveRenameConfig = false;
                            }

                            // Update Properties
                            this.sConfig.skbtConfigPath = this.sMeta.PathToConfig = this.txtBatchSettingsPath.Text = this.ExpandPathVars(newPathStr);
                        },
                        (userPathColorCheck) delegate(String newPathStr){
                            if (Cancelled == true) { return; }

                            this.txtBatchSettingsPath.BackColor = Color.FromArgb(64, 64, 64);
                            if (this.ExpandPathVars(newPathStr) != this.ExpandPathVars(this.sc.CoreConfig.getServerMetaObject(this.sMeta.Identifier).PathToConfig))
                            {
                                this.txtBatchSettingsPath.BackColor = this.changedBack;
                            }
                        }

                    );
                    return;

                case "btnFortxtASMLogName":  // Text Input Dialog

                    this.actionDelegateBrowseAction(
                        // TEXT BOX
                        this.txtASMLogName,
                        // ORIGIN PATH STRING
                        this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier].objASMProc.LogFileName,
                        // REF TO CURRENT PATH STRING
                        ref this.sConfig.objASMProc.LogFileName,
                        // DIALOG
                        (userPathHandleDialog)delegate()
                        {
                            String value=this.sConfig.objASMProc.LogFileName;
                            if(InputBox.Show("Enter a name for the ASM Log File", "ASM Log Name::", ref value, (InputBoxValidation) delegate(String val)
                            {
                                if (val == "")
                                    return "Value cannot be empty.";
                                if (!(new Regex(@"^[a-zA-Z0-9_ .-]+$")).IsMatch(val))
                                    return "Must use standard alphanumeric characters";
                                return "";
                            }) == DialogResult.OK)
                            {
                                return value;
                            }
                            else
                            {
                                return null;
                            }
                        },
                        // VALIDATION
                        (userPathValidation)delegate(String newPathStr)
                        {
                            Match rMatch = Regex.Match(newPathStr, "^[a-zA-Z0-9_.-]+$");
                            if (rMatch.Captures.Count <= 0)
                            {
                                return "Filename can only contain the characters: a-z A-Z 0-9 _ . -";
                            }
                            return null;
                        }
                    );
                    return;

                default:
                    return;
            }

        }
        private string isPathInUse(string newP)
        {

            string thisPath;
            // Check if the path is in use anywhere else
            foreach (KeyValuePair<short, skbtProcessConfigCustom> cProc in this.sConfig.objCustomProc)
            {
                thisPath = Path.GetFullPath(Path.Combine(this.ExpandPathVars(cProc.Value.Path), cProc.Value.EXEFile));
                if (thisPath.ToLower() == newP.ToLower()) { return "The path is currently in use by another custom process (" + cProc.Value.Name + ")"; }
            }
            // Check default Processes
            skbtProcessConfigBasic[] pArr = 
                            { 
                                this.sConfig.objServerProc,
                                this.sConfig.objDatabaseProc,
                                this.sConfig.objBECProc,
                                this.sConfig.objHeadlessClientProc,
                                this.sConfig.objTeamspeakProc,
                                this.sConfig.objASMProc
                            };

            foreach (skbtProcessConfigBasic p in pArr)
            {
                thisPath = Path.GetFullPath(Path.Combine(this.ExpandPathVars(p.Path), p.EXEFile));
                if (thisPath.ToLower() == newP.ToLower()) { return "This exe path is already in use by a main process config (" + thisPath + ")"; }
            }

            return null;
        }
        private void actionCustomProcSelector(object sender, EventArgs e)
        {
            if (this.pageLoaded == false) { return; }
            this.pageLoadedCustom = false;

            // Get/Set Selected Index
            ComboboxItem item = (ComboboxItem) ((ComboBox)sender).SelectedItem;
            short idx = (short) item.Value;
            this.selectedCustomID = idx;

            // Get Custom Process Object via Index
            skbtProcessConfigCustom cProcObj = (skbtProcessConfigCustom)this.sConfig.objCustomProc[idx];

            // Get original process object via index
            // (Check if its a new process)
            skbtProcessConfigCustom cProcOrigin = null;
            if (!objOriginalCusProc.ContainsKey(idx))
            {
                cProcOrigin = this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier].objCustomProc[idx];
            }
            else
            {
                cProcOrigin = this.objOriginalCusProc[idx];
            }

            // Load Data to controls (Reset Tab)

            // Keepalive Button State
            this.setKeepaliveButtonColor(
                btnProcessKeepaliveCustom,
                cProcObj.Keepalive ? false : true);

            // Path to Process EXE
            this.txtPathToEXECustom.Text = Path.Combine(this.ExpandPathVars(cProcObj.Path), cProcObj.EXEFile);

            // Selected Priority Setting
            this.cBoxPriorityCustom.SelectedItem = this.getPriorityNameByLowercase(cProcObj.Priority.ToLower());

            // Selected Affinity Settings
            this.setAffinityChkBoxes("Custom", cProcObj.Affinity);

            // Name of Custom Process
            this.txtCustomProcessName.Text = cProcObj.Name;

            // Process Launch Parameters
            this.txtCustomProcessLaunchParams.Text = cProcObj.LaunchParams;

            // Enable Controls

            this.cBoxCustomProcessSelector.Enabled  = true;
            this.btnProcessKeepaliveCustom.Enabled  = true;
            this.btnCustomProcessDelete.Enabled     = true;
            this.btnCustomProcessBrowseEXE.Enabled  = true;
            this.cBoxPriorityCustom.Enabled         = true;
            this.txtCustomProcessName.Enabled       = true;
            this.txtCustomProcessLaunchParams.Enabled = true;
            this.pageLoadedCustom = true;

            // Reset Colors
            this.txtCustomProcessName.BackColor = (cProcOrigin.Name != cProcObj.Name) ?
                this.changedBack
                :
                this.txtCustomProcessName.BackColor = Color.FromArgb(64, 64, 64);

            this.txtCustomProcessLaunchParams.BackColor = (cProcOrigin.LaunchParams != cProcObj.LaunchParams) ?
                this.changedBack
                :
                this.txtCustomProcessLaunchParams.BackColor = Color.FromArgb(64, 64, 64);

            this.txtPathToEXECustom.BackColor = (Path.GetFullPath(Path.Combine(cProcOrigin.Path, cProcOrigin.EXEFile)).ToLower() != Path.GetFullPath(Path.Combine(cProcObj.Path, cProcObj.EXEFile)).ToLower()) ?
                this.changedBack
                :
                this.txtPathToEXECustom.BackColor = Color.FromArgb(64, 64, 64);

            this.cBoxPriorityCustom.BackColor = (cProcOrigin.Priority != cProcObj.Priority) ?
                this.changedBack
                :
                this.cBoxPriorityCustom.BackColor = Color.FromArgb(40, 40, 40);
        }
        private short getUnusedCustomProcessID()
        {
            bool[] usedIDs = new bool[100];

            foreach (KeyValuePair<short, skbtProcessConfigCustom> cProc in this.sConfig.objCustomProc)
            {
                usedIDs[cProc.Key] = true;
            }
            short keyIndex = (short) Array.FindIndex(usedIDs, w => w == false);

            return keyIndex;
        }
        private void actionCustomProcAdd(object sender, EventArgs e){
            // Ask for new EXE path to custom process / check if that EXE path is used by another process.

            if (this.sConfig.objCustomProc.Count == 100)
            {
                MessageBox.Show("There are already 100 custom process entries! Cannot add any more, edit or delete some existing custom processes!");
                return;
            }

            string exePath = this.showOpenFileDialog("Add new custom process", "", "Executable Files|*.exe", @"C:\");
            if (exePath == null)
            {
                // Canceled /?
                return;
            }
            else
            {
                // Check if path is used elsewhere
                var isInUse = this.isPathInUse(exePath);
                if (isInUse == null)
                {
                    // Get another unused ID
                    short newID;
                    newID = this.getUnusedCustomProcessID();


                    // Populate new Data/New Object
                    skbtProcessConfigCustom newCProcObj = new skbtProcessConfigCustom(Path.GetFileName(exePath), Path.GetDirectoryName(exePath), true, "normal", "0", newID, "New Custom Process " + newID, "");
                    this.sConfig.objCustomProc.Add(newID, newCProcObj);
                    this.objOriginalCusProc.Add(newID, new skbtProcessConfigCustom(Path.GetFileName(exePath), Path.GetDirectoryName(exePath), true, "normal", "0", newID, "New Custom Process " + newID, "")); // Create an Origin Template (for diff gui colors)

                    // Add to combolist/select
                    ComboboxItem cBoxItem = new ComboboxItem();
                    cBoxItem.Text = newCProcObj.Name;
                    cBoxItem.Value = newCProcObj.ID;

                    this.cBoxCustomProcessSelector.Items.Add(cBoxItem);
                    this.cBoxCustomProcessSelector.SelectedItem = cBoxItem;

                    return;
                }
                else
                {
                    // Error
                    MessageBox.Show(isInUse);
                    this.actionCustomProcAdd(sender, e);
                    return;
                }
            }
        }
        private void actionCustomProcDel(object sender, EventArgs e)
        {
            if(this.selectedCustomID == null) return;

            DialogResult r = MessageBox.Show("Are you sure you wish to delete this custom process config?" + Environment.NewLine + "Changes will only take effect when clicking the save button", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                short id = (short) this.selectedCustomID;
                // delete it!
                if (this.objOriginalCusProc.ContainsKey(id))
                {
                    this.objOriginalCusProc.Remove(id);
                }
                this.sConfig.objCustomProc.Remove(id);

                // update custom tab
                this.resetTabCustom();
            }
            return;
        }
        private void onMouseOverKeepalive(object sender)
        {
            Button thisBtn = (Button)sender;
            skbtProcessConfigBasic proc = this.getProcessFromButtonName(((Button)sender).Name);
            if (proc != null)
            {
                if (proc.Keepalive == true)
                {
                    // Keepalive is true, (button should go to red state)
                    if (thisBtn.ForeColor == greenForeGround)
                    {
                        thisBtn.ForeColor = redForeGround;
                    }
                }
                else
                {
                    // Keepalive is false, (button should go to green state)
                    if (thisBtn.ForeColor == redForeGround)
                    {
                        thisBtn.ForeColor = greenForeGround;
                    }
                }
            }
        }
        private void onMouseOutKeepalive(object sender)
        {
            Button thisBtn = (Button)sender;
            skbtProcessConfigBasic proc = this.getProcessFromButtonName(((Button)sender).Name);
            if (proc != null)
            {
                if (proc.Keepalive == true)
                {
                    // Keepalive is true, (button should return to green state)
                    if (thisBtn.ForeColor == redForeGround)
                    {
                        thisBtn.ForeColor = greenForeGround;
                    }
                }
                else
                {
                    // Keepalive is false, (button should return to red state)
                    if (thisBtn.ForeColor == greenForeGround)
                    {
                        thisBtn.ForeColor = redForeGround;
                    }
                }
            }
        }
        private void evntKeepProcessAlive_MouseMove(object sender, MouseEventArgs e)
        {
            this.onMouseOverKeepalive(sender);
        }
        private void evntKeepProcessAlive_MouseLeave(object sender, EventArgs e)
        {
            this.onMouseOutKeepalive(sender);
        }
        private void evntKeepProcessAlive_Leave(object sender, EventArgs e)
        {
            this.onMouseOutKeepalive(sender);
        }
        private void evntChkAffinityChange(object sender, EventArgs e)
        {
            // quik fix
            if ((this.tabPageCurrent == "Custom" && this.pageLoadedCustom == false) || this.pageCustomLoading == true)
            {
                return;
            }

            CheckBox thisChk = (CheckBox)sender;
            String thisName = thisChk.Name;
            int dig = 1;
            if (Char.IsNumber(thisChk.Name[thisChk.Name.Length - 2]))
            {
                dig = 2;
            }

            String thisTabPage = thisChk.Name.Substring(11, (thisChk.Name.Length - 11) - dig);
            String thisCoreNum = thisChk.Name.Substring(thisChk.Name.Length - dig);

            skbtProcessConfigBasic obj = null;

            // For Custom Process
            if(thisTabPage == "Custom"){
                var t = (Dictionary<short, skbtProcessConfigCustom>)this.sConfig.GetType().GetProperty("obj" + thisTabPage + "Proc").GetValue(this.sConfig, null);
                if(t.Count >= 1){
                    if(this.selectedCustomID == null){
                        // Get first element
                        foreach(KeyValuePair<short, skbtProcessConfigCustom> kvp in this.sConfig.objCustomProc){
                            this.selectedCustomID = kvp.Key;
                            obj = kvp.Value;
                            break;
                        }
                    }
                    else
                    {
                        obj = t[(short) this.selectedCustomID];
                    }
                }
                else
                {
                    // No Processes
                    return;
                }
            }
            else
            {
                obj = (skbtProcessConfigBasic)this.sConfig.GetType().GetProperty("obj" + thisTabPage + "Proc").GetValue(this.sConfig, null);
            }

            // hmmm... strange...
            // First run (setup)
            if (this.pageLoaded == false) 
            {
                if (!obj.Affinity.Contains(thisCoreNum))
                {
                    // Add this core to the affinity string
                    obj.Affinity = obj.Affinity + ((obj.Affinity.Length >= 1)? "," : "") + thisCoreNum;
                }
                
                return; 
            }

            // get name and find object+core num

            // First check if this is the last "on" check box, if it is, disallow it. (Cant run on 0 cores??)

            if (obj.Affinity.Contains(thisCoreNum))
            {
                if (obj.Affinity.Length == 1)
                {
                    MessageBox.Show("You can't run a process on 0 cores. (To disable the process just click keepalive to red)",
                    "Selected Cores Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);
                    return;
                }

                // This core is selected (was green, so change red)
                this.setAffinityChkColor(thisChk, true);

                // Remove this core from the affinity string
                String newAffinityString = "";
                String[] AffinityArray = obj.Affinity.Split(',');
                foreach (var core in AffinityArray)
                {
                    if (thisCoreNum == core) continue;
                    newAffinityString += (newAffinityString.Length > 0) ? "," + core : core;
                }

                obj.Affinity = newAffinityString;
            }
            else
            {
                // This core is not selected (was red, so change green)
                this.setAffinityChkColor(thisChk, false);

                // Add this core to the affinity string
                obj.Affinity = obj.Affinity + "," + thisCoreNum;
            }

            // Force Redraw
            if (this.tabPageCurrent == "Custom")
            {
                this.cBoxCustomProcessSelector.Invalidate();
            }
        }
        private void resetTabCustom()
        {
            // Load current selected (or default) custom process from object map in coreconfig instance.
            // if no objects in map, disable all function except add.
            // If no selected tab, default to first process item in list (whichever read first from config)

            this.pageCustomLoading = true;
            this.cBoxCustomProcessSelector.Items.Clear();

            if (this.sConfig.objCustomProc.Count() > 0)
            {
                // default
                skbtProcessConfigCustom selProc_ref = this.sConfig.objCustomProc.First().Value;

                // keep same process between config open/close for this session
                if (this.selectedCustomID != null)
                {
                    if (this.sConfig.objCustomProc.ContainsKey((short)this.selectedCustomID))
                    {
                        selProc_ref = this.sConfig.objCustomProc[(short)this.selectedCustomID];
                    }
                }

                bool temp_first = false;
                this.cBoxCustomProcessSelector.Items.Clear();
                // iterate custom processes and populate controls with data
                foreach(KeyValuePair<short, skbtProcessConfigCustom> kvp in this.sConfig.objCustomProc){

                    // Add to drop down
                    ComboboxItem item = new ComboboxItem();
                    item.Text = kvp.Value.Name;
                    item.Value = kvp.Key;

                    this.cBoxCustomProcessSelector.Items.Add(item);

                    if (temp_first == false)
                    {
                        // Populate Controls
                        this.cBoxCustomProcessSelector.SelectedIndex = 0;
                        selProc_ref = kvp.Value;

                        // Keepalive Button State
                        this.setKeepaliveButtonColor(
                            btnProcessKeepaliveCustom,
                            kvp.Value.Keepalive ? false : true);

                        // Path to Process EXE
                        this.txtPathToEXECustom.Text = Path.Combine(this.ExpandPathVars(kvp.Value.Path), kvp.Value.EXEFile);

                        // Selected Priority Setting
                        this.cBoxPriorityCustom.SelectedItem = this.getPriorityNameByLowercase(kvp.Value.Priority.ToLower());

                        // Selected Affinity Settings
                        this.setAffinityChkBoxes("Custom", kvp.Value.Affinity);

                        // Name of Custom Process
                        this.txtCustomProcessName.Text = kvp.Value.Name;

                        // Process Launch Parameters
                        this.txtCustomProcessLaunchParams.Text = kvp.Value.LaunchParams;

                        // Set Selected Index
                        this.selectedCustomID = kvp.Key;

                        this.actionCustomProcSelector(this.cBoxCustomProcessSelector, new EventArgs() { });

                        // Make sure list is enabled
                        this.cBoxCustomProcessSelector.Enabled = true;

                        // Flag
                        temp_first = true;
                    }
                }
            }
            else
            {
                // Disable all but add btn

                this.cBoxCustomProcessSelector.Enabled = false;
                this.btnProcessKeepaliveCustom.Enabled = false;
                this.btnCustomProcessDelete.Enabled = false;
                this.btnCustomProcessBrowseEXE.Enabled = false;
                this.cBoxPriorityCustom.Enabled = false;

                foreach (var chkList in this.AffinityBoxes["Custom"])
                {
                    chkList.Value.Enabled = false;
                }
                this.txtCustomProcessName.Enabled = false;
                this.txtCustomProcessLaunchParams.Enabled = false;
            }
            this.pageCustomLoading = false;
            this.pageLoadedCustom = true;
        }
        private void selectAndDisplayTab(String btnName)
        {
            switch (btnName)
            {
                case "btnTabSelectServer":
                    this.resetTabSelectButtons();

                    this.tabControlMainConfig.SelectTab("tabPageProcessServer");
                    this.btnTabSelectServer.Enabled = false;
                    this.btnTabSelectServer.BackColor = System.Drawing.Color.FromArgb(64, 0, 0);
                    this.tabPageCurrent = "Server";
                    break;

                case "btnTabSelectBEC":
                    this.resetTabSelectButtons();

                    this.tabControlMainConfig.SelectTab("tabPageProcessBEC");
                    this.btnTabSelectBEC.Enabled = false;
                    this.btnTabSelectBEC.BackColor = System.Drawing.Color.FromArgb(64, 0, 0);
                    this.tabPageCurrent = "BEC";
                    break;

                case "btnTabSelectDatabase":
                    this.resetTabSelectButtons();

                    this.tabControlMainConfig.SelectTab("tabPageProcessDatabase");
                    this.btnTabSelectDatabase.Enabled = false;
                    this.btnTabSelectDatabase.BackColor = System.Drawing.Color.FromArgb(64, 0, 0);
                    this.tabPageCurrent = "Database";
                    break;

                case "btnTabSelectHC":
                    this.resetTabSelectButtons();

                    this.tabControlMainConfig.SelectTab("tabPageProcessHC");
                    this.btnTabSelectHC.Enabled = false;
                    this.btnTabSelectHC.BackColor = System.Drawing.Color.FromArgb(64, 0, 0);
                    this.tabPageCurrent = "HC";
                    break;

                case "btnTabSelectTS":
                    this.resetTabSelectButtons();

                    this.tabControlMainConfig.SelectTab("tabPageProcessTS");
                    this.btnTabSelectTS.Enabled = false;
                    this.btnTabSelectTS.BackColor = System.Drawing.Color.FromArgb(64, 0, 0);
                    this.tabPageCurrent = "TS";
                    break;

                case "btnTabSelectASM":
                    this.resetTabSelectButtons();

                    this.tabControlMainConfig.SelectTab("tabPageProcessASM");
                    this.btnTabSelectASM.Enabled = false;
                    this.btnTabSelectASM.BackColor = System.Drawing.Color.FromArgb(64, 0, 0);
                    this.tabPageCurrent = "ASM";
                    break;

                case "btnTabSelectCustom":
                    this.resetTabSelectButtons();

                    this.tabControlMainConfig.SelectTab("tabPageProcessCustom");
                    this.btnTabSelectCustom.Enabled = false;
                    this.btnTabSelectCustom.BackColor = System.Drawing.Color.FromArgb(64, 0, 0);
                    this.tabPageCurrent = "Custom";
                    break;

                default:
                    break;
            }

        }
        private void resetTabSelectButtons()
        {
            // Reset Enabled States
            this.btnTabSelectServer.Enabled = true;
            this.btnTabSelectDatabase.Enabled = true;
            this.btnTabSelectBEC.Enabled = true;
            this.btnTabSelectHC.Enabled = true;
            this.btnTabSelectASM.Enabled = true;
            this.btnTabSelectCustom.Enabled = true;
            this.btnTabSelectTS.Enabled = true;

            // Reset Color States
            this.btnTabSelectServer.BackColor = System.Drawing.Color.FromName("Gray");
            this.btnTabSelectDatabase.BackColor = System.Drawing.Color.FromName("Gray");
            this.btnTabSelectBEC.BackColor = System.Drawing.Color.FromName("Gray");
            this.btnTabSelectHC.BackColor = System.Drawing.Color.FromName("Gray");
            this.btnTabSelectASM.BackColor = System.Drawing.Color.FromName("Gray");
            this.btnTabSelectCustom.BackColor = System.Drawing.Color.FromName("Gray");
            this.btnTabSelectTS.BackColor = System.Drawing.Color.FromName("Gray");

        }
        private void resetAllControlColors()
        {
            // Text Boxes
            Color tbBackCol = Color.FromArgb(64,64,64);
            this.txtArmaExePath.BackColor = tbBackCol;
            this.txtASMLogName.BackColor = tbBackCol;
            this.txtBatchSettingsPath.BackColor = tbBackCol;
            this.txtConfigName.BackColor = tbBackCol;
            this.txtHeadlessClientLaunchArgs.BackColor = tbBackCol;
            this.txtPathToBackupFolder.BackColor = tbBackCol;
            this.txtPathToBackupLog.BackColor = tbBackCol;
            this.txtPathToBasicCFG.BackColor = tbBackCol;
            this.txtPathToBattleye.BackColor = tbBackCol;
            this.txtPathToConfigCFG.BackColor = tbBackCol;
            this.txtPathToDBFile.BackColor = tbBackCol; ;
            this.txtPathToEXEASM.BackColor = tbBackCol; ;
            this.txtPathToEXEBEC.BackColor = tbBackCol; ;
            this.txtPathToEXEDB.BackColor = tbBackCol; ;
            this.txtPathToEXEHC.BackColor = tbBackCol; ;
            this.txtPathToEXEServer.BackColor = tbBackCol;
            this.txtPathToEXETS.BackColor = tbBackCol;
            this.txtPathToProfile.BackColor = tbBackCol;
            this.txtPathToServerLog.BackColor = tbBackCol;
            this.txtProfileName.BackColor = tbBackCol;
            this.txtServerCommand.BackColor = tbBackCol;
            this.txtServerModline.BackColor = tbBackCol;
            this.txtCustomProcessName.BackColor = tbBackCol;
            this.txtCustomProcessLaunchParams.BackColor = tbBackCol;
            this.txtPathToEXECustom.BackColor = tbBackCol;

            // Lone Checkboxes
            Color cbForeCol = Color.FromKnownColor(KnownColor.ScrollBar);
            this.chkServerBindToIP.ForeColor = cbForeCol;
            this.chkUseZipBackups.ForeColor = cbForeCol;
            this.chkBecUseDsc.ForeColor = cbForeCol;
            this.chkUseZipLogs.ForeColor = cbForeCol;
            this.chkCleanWERs.ForeColor = cbForeCol;

            // List Boxes (priorites)
            Color cBoxBackCol = Color.FromArgb(40, 40, 40);
            this.cBoxPriorityASM.BackColor = cBoxBackCol;
            this.cBoxPriorityBEC.BackColor = cBoxBackCol;
            this.cBoxPriorityDatabase.BackColor = cBoxBackCol;
            this.cBoxPriorityHeadlessClient.BackColor = cBoxBackCol;
            this.cBoxPriorityServer.BackColor = cBoxBackCol;
            this.cBoxPriorityTeamspeak.BackColor = cBoxBackCol;
            this.cBoxPriorityCustom.BackColor = cBoxBackCol;

            // Num Selectors
            this.numBackupInterval.ForeColor = Color.FromKnownColor(KnownColor.ScrollBar);
            this.numASMLogInterval.ForeColor = Color.FromKnownColor(KnownColor.ScrollBar);
            this.numTeamspeakPortNumber.ForeColor = Color.FromKnownColor(KnownColor.ScrollBar);
            this.numServerIP1.ForeColor = Color.FromKnownColor(KnownColor.ScrollBar);
            this.numServerIP2.ForeColor = Color.FromKnownColor(KnownColor.ScrollBar);
            this.numServerIP3.ForeColor = Color.FromKnownColor(KnownColor.ScrollBar);
            this.numServerIP4.ForeColor = Color.FromKnownColor(KnownColor.ScrollBar);
            this.numServerPort.ForeColor = Color.FromKnownColor(KnownColor.ScrollBar);

        }
        private void resetAllAffinityCheckboxes()
        {
            int procCount = this.sc.CoreConfig.totalCores;

            String[] tabNames = new String[] {
                "Server",
                "Database",
                "BEC",
                "HeadlessClient",
                "Teamspeak",
                "ASM",
                "Custom"
            };

            foreach (String tabName in tabNames)
            {
                for (int i = 0; i < procCount; i++)
                {
                    // Get checkbox
                    CheckBox tChk = (CheckBox)this.Controls.Find("chkAffinity" + tabName + (i).ToString(), true)[0];

                    this.setAffinityChkColor(tChk, true);

                    // Only for the cores we can use
                    if (i <= procCount - 1)
                    {
                        tChk.Enabled = true;
                    }else{
                        tChk.Enabled = false;
                    }
                }
            }

        }
        private void setAffinityChkBoxes(String ctrlSuffix, String affinityStr)
        {

            int procCount = this.sc.CoreConfig.totalCores;
            String[] selCores = affinityStr.Split(',');

            for (int i = 0; i < procCount; i++)
            {
                CheckBox tmpChkHandle = (CheckBox)this.Controls.Find("chkAffinity" + ctrlSuffix + (i).ToString(), true)[0];

                // Enable the checkbox
                tmpChkHandle.Enabled = true;

                // Core is selected in config
                if (selCores.Contains(i.ToString()))
                {
                    tmpChkHandle.Checked = true;
                    this.setAffinityChkColor(tmpChkHandle, false);

                }
                // Core is not selected
                else
                {
                    tmpChkHandle.Checked = false;
                    this.setAffinityChkColor(tmpChkHandle, true);
                }
            }
        }
        private void setAffinityChkColor(CheckBox thisChk, Boolean redOrGreen)
        {
            if (redOrGreen == true)
            {
                thisChk.FlatAppearance.BorderColor = redForeGround;
                thisChk.ForeColor = redForeGround;
                thisChk.BackColor = Color.Black;
                thisChk.FlatAppearance.CheckedBackColor = Color.Black;
                thisChk.FlatAppearance.MouseOverBackColor = Color.Transparent;
                thisChk.FlatAppearance.MouseDownBackColor = Color.Transparent;
            }
            else
            {
                thisChk.FlatAppearance.BorderColor = greenForeGround;
                thisChk.ForeColor = greenForeGround;
                thisChk.BackColor = Color.Black;
                thisChk.FlatAppearance.CheckedBackColor = Color.Black;
                thisChk.FlatAppearance.MouseOverBackColor = Color.Transparent;
                thisChk.FlatAppearance.MouseDownBackColor = Color.Transparent;
            }
        }
        private void setKeepaliveButtonColor(object sender, Boolean Red)
        {
            // Set button to "off" look
            if (Red == true)
            {
                ((Button)sender).ForeColor = redForeGround;
                ((Button)sender).FlatAppearance.MouseOverBackColor = this.greenBackGround;
                ((Button)sender).FlatAppearance.MouseDownBackColor = greenMouseDown;
            }
            // Set to "On"
            else
            {
                ((Button)sender).ForeColor = greenForeGround;
                ((Button)sender).FlatAppearance.MouseOverBackColor = this.redBackGround;
                ((Button)sender).FlatAppearance.MouseDownBackColor = redMouseDown;
            }
        }

        private skbtProcessConfigBasic getProcessFromButtonName(String n)
        {
            switch (n)
            {
                case "btnProcessKeepaliveServer":
                    return this.sConfig.objServerProc;
                case "btnProcessKeepaliveDatabase":
                    return this.sConfig.objDatabaseProc;
                case "btnProcessKeepaliveBEC":
                    return this.sConfig.objBECProc;
                case "btnProcessKeepaliveHC":
                    return this.sConfig.objHeadlessClientProc;
                case "btnProcessKeepaliveTS":
                    return this.sConfig.objTeamspeakProc;
                case "btnProcessKeepaliveASM":
                    return this.sConfig.objASMProc;
                case "btnProcessKeepaliveCustom":
                    if (this.selectedCustomID != null)
                    {
                        if (this.sConfig.objCustomProc.ContainsKey((short)this.selectedCustomID))
                        {
                            return this.sConfig.objCustomProc[(short)this.selectedCustomID];
                        }
                    }
                    return null;

                default:
                    return null;
            }
        }
        private String getPriorityNameByLowercase(String str)
        {
            switch (str)
            {
                case "realtime":
                    return "Realtime";
                case "high":
                    return "High";
                case "abovenormal":
                    return "AboveNormal";
                case "normal":
                    return "Normal";
                case "belownormal":
                    return "BelowNormal";
                case "low":
                    return "Low";

                default:
                    return null;
            }
        }
        private String showOpenFileDialog(String title, String defaultFileName, String filter, String startFolder){
            

            // Launch Open File Dialog
            this.openFileDialog.Title = title;
            this.openFileDialog.FileName = defaultFileName;
            this.openFileDialog.InitialDirectory = Directory.Exists(startFolder) ? startFolder.Replace("/", @"\").TrimEnd('\\') : Path.GetDirectoryName(this.sMeta.PathToEXE).Replace("/", @"\").TrimEnd('\\');
            
            this.openFileDialog.CheckFileExists = true;
            this.openFileDialog.Filter = filter;

            String newFilePath;
            DialogResult result = this.openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                newFilePath = this.openFileDialog.FileName;
            }
            else
            {
                return null;
            }

            return newFilePath;
        }
        private String showFolderDialog(String desc, String startFolder)
        {

            if (Directory.Exists(startFolder))
            {
                folderBrowseDialog.Description = desc;
                folderBrowseDialog.SelectedPath = startFolder;
            }

            // Show Dialog
            DialogResult result = folderBrowseDialog.ShowDialog();
            String newFolder;

            // Check if user Canceled
            if (result == DialogResult.OK)
            {
                // Return Chosen Path/Filename
                newFolder = folderBrowseDialog.SelectedPath;
            }
            else
            {
                // User Cancelled
                newFolder = startFolder;
            }

            return newFolder;
        }
        private String showSaveFileDialog(String title, String defaultFileName, String filter, String startFolder, String defaultExt, Boolean overwritePrompt=false)
        {
            String newFilePath;

            // Set Dialog Properties
            this.saveFileDialog.Title = title;
            this.saveFileDialog.Filter = filter;
            this.saveFileDialog.DefaultExt = defaultExt;
            this.saveFileDialog.CheckFileExists = false;
            this.saveFileDialog.CheckPathExists = true;
            this.saveFileDialog.CreatePrompt = false;
            this.saveFileDialog.AddExtension = true;
            this.saveFileDialog.OverwritePrompt = overwritePrompt;
            this.saveFileDialog.InitialDirectory = startFolder;
            this.saveFileDialog.FileName = defaultFileName;

            // Show Dialog
            DialogResult result = this.saveFileDialog.ShowDialog();

            // Check if user Canceled
            if (result == DialogResult.OK)
            {
                // Return Chosen Path/Filename
                newFilePath = this.saveFileDialog.FileName;

                if (newFilePath == Path.Combine(startFolder, defaultFileName))
                {
                    // No Change
                    return null;
                }
            }
            else
            {
                // User Cancelled
                newFilePath = Path.Combine(startFolder, defaultFileName);
                return null;
            }

            return newFilePath;
        }
        private String ExpandPathVars(String path)
        {
            // %armapath%
            String armapath = Path.GetDirectoryName(this.sMeta.PathToEXE);
            return path.Replace("%armapath%", armapath).Replace("%armapath:\"=%", armapath);
        }
        private String CollapsePathVars(String path)
        {
            // maybe re activate if i have time to fix
            return path;
            if (path == null) { return null; }
            // %armapaths%
            String armapath = Path.GetDirectoryName(this.sMeta.PathToEXE);
            return path.Replace(armapath, "%armapath:\"=%");
        }
        private String getDebugLevelTextFromInt(UInt16 dLevel)
        {
            String StringOfInt = Convert.ToString(dLevel);
            foreach (String item in this.cBoxDebugLevel.Items)
            {
                char a = StringOfInt[0];
                char b = item[0];
                if (a == b)
                {
                    return item;
                }
            }
            return null;
        }

        private void configFormClosed(object sender, FormClosedEventArgs e)
        {
            // Cleanup
            this.objOriginalCusProc.Clear();
            this.selectedCustomID = null;
        }

        private void customProcessListDrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index == -1)
                return;
            ComboBox combo = ((ComboBox)sender);

            ComboboxItem item = (ComboboxItem) combo.Items[e.Index];
            skbtProcessConfigCustom origin = null;
            if (this.objOriginalCusProc.ContainsKey((short) item.Value))
            {
                origin = this.objOriginalCusProc[(short) item.Value];
            }
            else
            {
                origin = this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier].objCustomProc[(short) item.Value];
            }

            using (SolidBrush brush = new SolidBrush(e.ForeColor))
            {
                Font font = e.Font;
                if (!checkIsCustomObjectsEqual(origin, this.sConfig.objCustomProc[(short) item.Value]))
                    font = new System.Drawing.Font(font, FontStyle.Bold);
                e.DrawBackground();
                e.Graphics.DrawString(combo.Items[e.Index].ToString(), font, brush, e.Bounds);
                e.DrawFocusRectangle();
            }
        }

        private bool checkIsCustomObjectsEqual(skbtProcessConfigCustom a, skbtProcessConfigCustom b)
        {
            string apath = Path.GetFullPath(a.Path).ToLower();
            string bpath = Path.GetFullPath(b.Path).ToLower();

            if (a.EXEFile.ToLower() != b.EXEFile.ToLower()) return false;
            if (a.Affinity != b.Affinity) return false;
            if (a.ID != b.ID) return false;
            if (a.Keepalive != b.Keepalive) return false;
            if (a.LaunchParams != b.LaunchParams) return false;
            if (a.Name != b.Name) return false;
            if (apath.TrimEnd('\\') != bpath.TrimEnd('\\')) return false;
            if (a.Priority.ToLower() != b.Priority.ToLower()) return false;

            return true;
        }

        // New confirm close/cancel dialog
        private void configFormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.formSaved == false)
            {
                DialogResult window;
                if (this.sMeta.isInstalled == false)
                {
                    window = MessageBox.Show("Are you sure you want to close the configuration manager? " + Environment.NewLine + "The keepalive has not been installed properly until you click SAVE!", "Any changes made will be lost!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }
                else
                {
                    window = MessageBox.Show("Are you sure you want to close the configuration manager? " + Environment.NewLine + "Any changes made will be lost!", "You are about to lose config data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }
                if (window == DialogResult.No) e.Cancel = true;
                else e.Cancel = false;
            }
            // this.configFormClosed(sender, new FormClosedEventArgs(CloseReason.UserClosing));
        }

        private void frmConfigWindow_Load(object sender, EventArgs e)
        {
            this.mStripConfig.Renderer = new ToolStripProfessionalRenderer(new TestColorTable());
        }

        private void tsmItemConfigControlStart_Click(object sender, EventArgs e)
        {
            this.executeBatchFile(Path.Combine(this.sConfig.objServerProc.Path, "batch_lib", "control", "manual_start.bat"));
        }

        private void tsmConfigControlStop_Click(object sender, EventArgs e)
        {
            this.executeBatchFile(Path.Combine(this.sConfig.objServerProc.Path, "batch_lib", "control", "manual_stop.bat"));
        }

        private void tsmItemConfigControlRestart_Click(object sender, EventArgs e)
        {
            this.executeBatchFile(Path.Combine(this.sConfig.objServerProc.Path, "batch_lib", "control", "manual_restart.bat"));
        }

        private void tsmConfigKeepaliveStart_Click(object sender, EventArgs e)
        {
            this.executeBatchFile(Path.GetFullPath(Path.Combine(this.sConfig.objServerProc.Path, "batch_lib", "start_keepalive.bat")));
            ((ToolStripItem)sender).Enabled = false;
        }

        private void tsmConfigKeepaliveStop_Click(object sender, EventArgs e)
        {
            this.executeBatchFile(Path.GetFullPath(Path.Combine(this.sConfig.objServerProc.Path, "batch_lib", "lib", "stop_keepalive.bat")));
        }

        private void tsmConfigKeepaliveLog_Click(object sender, EventArgs e)
        {
            string log = Path.GetFullPath(Path.Combine(this.sConfig.objServerProc.Path, "batch_lib", "batchrun.log"));
            if (System.IO.File.Exists(log))
            {
                System.Diagnostics.Process.Start(log);
            }
            else
            {
                MessageBox.Show("Can't find batchrun log file. (Recently Cleaned?)");
            }
        }

        private void tsmConfigKeepaliveOpenLib_Click(object sender, EventArgs e)
        {
            string batchlib = Path.GetFullPath(Path.Combine(this.sConfig.objServerProc.Path, "batch_lib"));
            if (System.IO.Directory.Exists(batchlib))
            {
                System.Diagnostics.Process.Start(batchlib);
            }
            else
            {
                MessageBox.Show("Can't find batch_lib folder. (Make sure to click SAVE first)");
            }
        }

        private void tsmConfigKeepaliveOpenSettings_Click(object sender, EventArgs e)
        {
            string settings = Path.GetFullPath(this.sMeta.PathToConfig);
            if (System.IO.File.Exists(settings))
            {
                System.Diagnostics.Process.Start("notepad.exe", settings);
            }
            else
            {
                MessageBox.Show("Can't find batch settings file. (Make sure to click SAVE first)");
            }
        }

        private void tsmConfigKeepaliveClean_Click(object sender, EventArgs e)
        {
            // Delete logs/wrkdir items
            System.IO.File.Delete(Path.GetFullPath(Path.Combine(this.sConfig.objServerProc.Path, "batch_lib", "batchrun.log")));
            System.IO.File.Delete(Path.GetFullPath(Path.Combine(this.sConfig.objServerProc.Path, "batch_lib", "wrkdir", "lastauto.txt")));
            System.IO.File.Delete(Path.GetFullPath(Path.Combine(this.sConfig.objServerProc.Path, "batch_lib", "wrkdir", "lastdb_backup.txt")));
            System.IO.File.Delete(Path.GetFullPath(Path.Combine(this.sConfig.objServerProc.Path, "batch_lib", "wrkdir", "lastmanual.txt")));
            System.IO.File.Delete(Path.GetFullPath(Path.Combine(this.sConfig.objServerProc.Path, "batch_lib", "wrkdir", "laststarted.txt")));
            System.IO.File.Delete(Path.GetFullPath(Path.Combine(this.sConfig.objServerProc.Path, "batch_lib", "wrkdir", "stopkeepalive.txt")));

            string[] kaClones = Directory.GetFiles(Path.GetFullPath(Path.Combine(this.sConfig.objServerProc.Path, "batch_lib", "core")), "server_keepalive.*.bat");
            foreach (string clone in kaClones)
            {
                System.IO.File.Delete(clone);
            }
        }

        private void viewReadmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string readme = Properties.Resources.README.ToString();
            string tempFile = System.IO.Path.GetTempPath() + "README" + ".txt";
            if (System.IO.File.Exists(tempFile))
            {
                System.IO.File.Delete(tempFile);
            }
            System.IO.File.WriteAllText(tempFile, readme);
            System.Diagnostics.Process.Start(tempFile);
        }

        private void tsmConfigAbout_Click(object sender, EventArgs e)
        {
            AboutDialog abt = new AboutDialog();
            abt.ShowDialog();
        }

        private void actionUseNewRoutine(object sender, EventArgs e)
        {
            this.sConfig.SpecificProcCheck = (((CheckBox)sender).Checked == true) ? true : false;
            if (this.chkUseNewIDRoutine.Checked != this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier].SpecificProcCheck)
            {
                // red
                this.chkUseNewIDRoutine.ForeColor = changedFore;
            }
            else
            {
                // normal
                this.chkUseNewIDRoutine.ForeColor = Color.FromKnownColor(KnownColor.ScrollBar);
            }
        }
    }

    // Custom Tabless Container
    public class TablessControl : TabControl
    {
        private const int TCM_ADJUSTRECT = 0x1328;
        protected override void WndProc(ref System.Windows.Forms.Message m)
        {

            // Hide tabs by trapping the TCM_ADJUSTRECT message
            if (m.Msg == 0x1328 && !DesignMode) m.Result = (IntPtr)1;
            else base.WndProc(ref m);
        }
    }

    // Custom Combo Items
    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }

    public class TestColorTable : ProfessionalColorTable
    {
        public override Color MenuItemSelected
        {
            get { return Color.FromArgb(25,150,25); }
        }

        public override Color MenuBorder  //added for changing the menu border
        {
            get { return Color.Green; }
        }

        public override Color MenuItemBorder
        {
            get { return Color.Green; }
        }

        public override Color MenuItemPressedGradientBegin
        {
            get { return Color.Green; }
        }

        public override Color MenuItemPressedGradientEnd
        {
            get { return Color.Green; }
        }

        public override Color MenuItemPressedGradientMiddle
        {
            get { return Color.Green; }
        }

        public override Color MenuItemSelectedGradientBegin
        {
            get { return Color.FromArgb(100,190,80); }
        }

        public override Color MenuItemSelectedGradientEnd
        {
            get { return Color.FromArgb(90, 90, 90); ; }
        }

        public override Color MenuStripGradientBegin
        {
            get { return Color.Green; }
        }

        public override Color MenuStripGradientEnd
        {
            get { return Color.Green; }
        }

        public override Color ButtonCheckedGradientBegin
        {
            get { return Color.Green; }
        }

        public override Color ButtonCheckedGradientEnd
        {
            get { return Color.Green; }
        }

        public override Color ButtonCheckedGradientMiddle
        {
            get { return Color.Green; }
        }

        public override Color ButtonCheckedHighlight
        {
            get { return Color.Green; }
        }

        public override Color ButtonCheckedHighlightBorder
        {
            get { return Color.Green; }
        }

        public override Color ButtonPressedBorder
        {
            get { return Color.Green; }
        }

        public override Color ButtonPressedGradientBegin
        {
            get { return Color.Green; }
        }

        public override Color ButtonPressedGradientEnd
        {
            get { return Color.Green; }
        }

        public override Color ButtonPressedGradientMiddle
        {
            get { return Color.Green; }
        }

        public override Color ButtonPressedHighlight
        {
            get { return Color.Green; }
        }

        public override Color ButtonPressedHighlightBorder
        {
            get { return Color.Green; }
        }

        public override Color ButtonSelectedBorder
        {
            get { return Color.Black; }
        }

        public override Color ButtonSelectedGradientBegin
        {
            get { return Color.Green; }
        }

        public override Color ButtonSelectedGradientEnd
        {
            get { return Color.Green; }
        }

        public override Color ButtonSelectedGradientMiddle
        {
            get { return Color.Green; }
        }

        public override Color ButtonSelectedHighlight
        {
            get { return Color.Green; }
        }

        public override Color ButtonSelectedHighlightBorder
        {
            get { return Color.Green; }
        }
    }
}
