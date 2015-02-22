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

namespace skbtInstaller
{
    public partial class frmConfigWindow : Form
    {
        // Reference to the Server Control Object
        skbtServerControl sc;

        // colors :)
        Color redForeGround = Color.FromArgb(132, 0, 0);
        Color greenForeGround = Color.FromName("Green");
        Color redBackGround = Color.FromArgb(255, 128, 128);
        Color greenBackGround = Color.FromArgb(192, 255, 192);
        Color redMouseDown = Color.FromArgb(64, 0, 0);
        Color greenMouseDown = Color.FromArgb(0, 64, 0);

        Color changedBack = Color.FromArgb(28, 43, 43);
        Color changedFore = Color.FromArgb(95, 146, 146);

        // Copies of Originals (NOT ref)
        skbtServerConfig sConfig;
        skbtServerMeta sMeta;

        // Design Flag
        Boolean pageLoaded;

        // If Batch Settings Path Changed
        Boolean onSaveRenameConfig;

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
            this.pageLoaded = false;
            if (sc.getSelectedPathIdentifier() == null)
            {
                MessageBox.Show("No Path was selected. \n(How did you even do this? Please report this as a bug.)");
                return;
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
            this.txtPathToEXEDB.Text = Path.Combine(this.sConfig.objDatabaseProc.Path, this.sConfig.objDatabaseProc.EXEFile);

            // Selected Priority Setting
            this.cBoxPriorityDatabase.SelectedItem = this.getPriorityNameByLowercase(this.sConfig.objDatabaseProc.Priority.ToLower());

            // Selected Affinity Settings
            this.setAffinityChkBoxes("Database", this.sConfig.objDatabaseProc.Affinity);

            // Zip Backups
            this.chkUseZipBackups.Checked = this.sConfig.objDatabaseProc.UseZipBackups;

            // Database Backup Interval
            this.numBackupInterval.Text = this.sConfig.objDatabaseProc.DatabaseBackupInterval.ToString();

            // Database Dump File Path
            this.txtPathToDBFile.Text = Path.Combine(this.sConfig.objDatabaseProc.DatabaseDumpFilePath, this.sConfig.objDatabaseProc.DatabaseDumpFileName);

            // Database Backup Folder
            this.txtPathToBackupFolder.Text = this.sConfig.objDatabaseProc.BackupFolder;

            // [BEC Process Data]

            // Keepalive Button State
            this.setKeepaliveButtonColor(
                btnProcessKeepaliveBEC,
                this.sConfig.objBECProc.Keepalive ? false : true);

            // Path to Process EXE
            this.txtPathToEXEBEC.Text = Path.Combine(this.sConfig.objBECProc.Path, this.sConfig.objBECProc.EXEFile);

            // Selected Priority Setting
            this.cBoxPriorityBEC.SelectedItem = this.getPriorityNameByLowercase(this.sConfig.objBECProc.Priority.ToLower());

            // Selected Affinity Settings
            this.setAffinityChkBoxes("BEC", this.sConfig.objBECProc.Affinity);

            // Path to Battleye Folder
            this.txtPathToBattleye.Text = this.sConfig.objBECProc.BEPath;

            // [Headless Client Process Data]

            // Keepalive Button State
            this.setKeepaliveButtonColor(
                btnProcessKeepaliveHC,
                this.sConfig.objHeadlessClientProc.Keepalive ? false : true);

            // Path to Process EXE
            this.txtPathToEXEHC.Text = Path.Combine(this.sConfig.objHeadlessClientProc.Path, this.sConfig.objHeadlessClientProc.EXEFile);

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
            this.txtPathToEXETS.Text = Path.Combine(this.sConfig.objTeamspeakProc.Path, this.sConfig.objTeamspeakProc.EXEFile);

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
            this.txtPathToEXEASM.Text = Path.Combine(this.sConfig.objASMProc.Path, this.sConfig.objASMProc.EXEFile);

            // Selected Priority Setting
            this.cBoxPriorityASM.SelectedItem = this.getPriorityNameByLowercase(this.sConfig.objASMProc.Priority.ToLower());

            // Selected Affinity Settings
            this.setAffinityChkBoxes("ASM", this.sConfig.objASMProc.Affinity);

            // ASM Logging Interval
            this.numASMLogInterval.Text = this.sConfig.objASMProc.LogInterval.ToString();

            // ASM Log File Name
            this.txtASMLogName.Text = this.sConfig.objASMProc.LogFileName;

            this.pageLoaded = true;

            // Show Dialog
            this.ShowDialog();

        }
        private void actionSaveConfig(object sender, EventArgs e)
        {
            // Check Settings before saving! Meh, shouldn't be a need

            // Assume all files are already installed (at least the templates, can check if they are templates).

            String newfile = this.sMeta.PathToConfig;
            String oldFile = this.sc.CoreConfig.getServerMetaObject(this.sMeta.Identifier).PathToConfig;

            if (newfile != oldFile) {
                // TODO
                // Edit every single reference in all zip files to new config location. (check for spaces? alert? cancel? wrap in quotes?)
                    // Unzip Batch Lib from res to Batch Lib in arma folder
                    // Loop file list and replace every occurence of "oldFile" to "newFile"


                // If rename flag is set, rename current config
                if (this.onSaveRenameConfig == true)
                {
                    // rename current config, then overwrite

                    File.Move(oldFile, newfile);
                }
            }

            // Map of replacement strings to values
            Dictionary<String, String> replacements = new Dictionary<string, string>()
            {
                {"{KEEPALIVE_DATABASE}", this.sConfig.objDatabaseProc.Keepalive ? "1" : "0"},
                {"{KEEPALIVE_BEC}", this.sConfig.objBECProc.Keepalive ? "1" : "0"},
                {"{KEEPALIVE_ASM}", this.sConfig.objASMProc.Keepalive ? "1" : "0"},
                {"{KEEPALIVE_TS}", this.sConfig.objTeamspeakProc.Keepalive ? "1" : "0"},
                {"{KEEPALIVE_HC}", this.sConfig.objHeadlessClientProc.Keepalive ? "1" : "0"},
                {"{SERVERPORT}", this.sConfig.objServerProc.Port.ToString()},
                {"{BINDTOIP}", this.sConfig.BindToIP ? "1" : "0"},
                {"{SERVERIP}", this.sConfig.IP},
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
                {"{DB_FILE_FULLPATH}", Path.Combine(this.sConfig.objDatabaseProc.Path, this.sConfig.objDatabaseProc.EXEFile)},
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
                {"{PRIORITY_ASM}", this.sConfig.objASMProc.Priority}
            };

            this.sMeta.textualName = this.txtConfigName.Text;

            // Prepare new Batch Settings File
            String newConfigData = skbtInstaller.Properties.Resources.skbtConfigTemplate;

            foreach (KeyValuePair<String, String> str in replacements)
            {
                newConfigData = newConfigData.Replace(str.Key, str.Value);
            }

            // Write new batch settings file
            System.IO.File.WriteAllText(newfile, newConfigData);

            // Update Objects
            this.sc.CoreConfig.setServerConfig(this.sMeta.Identifier, this.sConfig);
            this.sc.CoreConfig.setServerMeta(this.sMeta.Identifier, this.sMeta);

            // Update List Box Items
            this.sc.refreshListBox();

            // Re select this config in list box
            this.sc.frmMainWindowHandle.setSelectedIndexOnList(this.sMeta.Identifier);

            // Save core Config Changes
            this.sc.CoreConfig.saveCoreConfig();

            // Close Configuration Window
            this.Close();
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
        }
        private void actionCancelConfig(object sender, EventArgs e)
        {
            this.Close();
        }
        private void actionPriorityChanged(object sender, EventArgs e)
        {
            if (this.pageLoaded == false) return;

            // Get object from list name
            ComboBox cBox = ((ComboBox)sender);
            String objectName = cBox.Name.Substring(12);
            String selPriority = cBox.SelectedItem.ToString().ToLower();

            // Reflect Process Object by Name
            skbtProcessConfigBasic thisObj = (skbtProcessConfigBasic)this.sConfig.GetType().GetProperty("obj" + objectName + "Proc").GetValue(this.sConfig, null);

            // Set new Priority
            thisObj.Priority = selPriority;

            // origin
            skbtProcessConfigBasic origin = (skbtProcessConfigBasic)this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier].GetType().GetProperty("obj" + objectName + "Proc").GetValue(this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier], null);
            if (origin.Priority.ToLower() != thisObj.Priority.ToLower())
            {
                cBox.BackColor = changedBack;
            }
            else 
            {
                cBox.BackColor = Color.FromArgb(40, 40, 40);
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
            if (((TextBox)sender).Text.Length < 5)
            {
                MessageBox.Show("Please choose a name with more than 4 characters.");
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
                // Do Color checks
                if (dColorCheck != null) { dColorCheck(newPath); }
                else if (txtThis == null) { MessageBox.Show("Internal Error #5461353"); }
                else { txtThis.BackColor = (this.CollapsePathVars(originPath).ToLower() != newPath.ToLower()) ? this.changedBack : Color.FromArgb(64, 64, 64); }

                // Change text box and internal config data to reflect succesfull path selection
                if (dSetWithCondition != null) { dSetWithCondition(newPath); }
                else if(txtThis != null) { txtThis.Text = currentPath = newPath; }
                else { /* Internal error fall silently */ }
            }
            // Failed Validation with Message
            else if (validResult != "silent") { MessageBox.Show(validResult); }
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
                        String profileFileName = Path.GetFileNameWithoutExtension(profilePath);

                        // Get Profile Directory
                        String profileFolder = this.CollapsePathVars(Path.GetDirectoryName(profilePath));

                        // Should we shorten profile path?
                        if (profileFolder.Contains(@"%armapath%\"))
                        {
                            // Shorten Path
                            profileFolder = profileFolder.Replace(@"%armapath%\", "");
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
                            if (startFolder != this.ExpandPathVars(newPathStr) && File.Exists(this.ExpandPathVars(newPathStr)))
                            {
                                // Get Profile Name
                                String profileFileName = Path.GetFileNameWithoutExtension(newPathStr);

                                String UserFolderName = Path.GetDirectoryName(newPathStr).Replace(Path.GetDirectoryName(Path.GetDirectoryName(newPathStr))+@"\", "");
                                // If User Folder name != Profile File Name
                                if (this.CollapsePathVars(newPathStr).Contains(@"%armapath%") && UserFolderName != profileFileName)
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
                            String profileFileName = Path.GetFileNameWithoutExtension(newPathStr);

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
                            String profileFileName = Path.GetFileNameWithoutExtension(newPathStr);

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
                        Path.Combine(this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier].objDatabaseProc.DatabaseDumpFilePath, this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier].objDatabaseProc.DatabaseDumpFileName),
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
                                    this.sConfig.objDatabaseProc.DatabaseDumpFilePath, 
                                    this.sConfig.objDatabaseProc.DatabaseDumpFileName) 
                                == newPathStr
                                || !File.Exists(this.ExpandPathVars(newPathStr)))
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
                            this.sConfig.objDatabaseProc.DatabaseDumpFilePath = Path.GetDirectoryName(newPathStr);
                            this.sConfig.objDatabaseProc.DatabaseDumpFileName = Path.GetFileName(newPathStr);
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
                            if (this.sConfig.objServerProc.ConfigPathBasic == newPathStr || !File.Exists(this.ExpandPathVars(newPathStr)))
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
                            if (this.sConfig.objServerProc.ConfigPathServer == newPathStr || !File.Exists(this.ExpandPathVars(newPathStr)))
                            { return "silent"; }
                            else { return null; }
                        }
                    );
                    return;

                // for now this function is DISABLED (buttons disabled on form) 
                case "btnFortxtPathToEXEServer":    // Open File Server EXE (*.exe)

                    return;

                case "btnFortxtPathToEXEDB":        // Open File Database EXE (*.exe)

                    this.actionDelegateBrowseAction(
                        // TEXT BOX
                        this.txtPathToEXEDB,
                        // ORIGIN PATH STRING
                        Path.Combine(this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier].objDatabaseProc.Path, this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier].objDatabaseProc.EXEFile),
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
                            var current = this.ExpandPathVars(Path.Combine(this.sConfig.objDatabaseProc.Path, this.sConfig.objDatabaseProc.EXEFile));
                            var newP = this.ExpandPathVars(newPathStr);

                            if (current == newP || !File.Exists(newP)){ return "silent"; }
                            else { return null; }
                        },
                        // SET WITH CONDITION
                        (userPathSetWithCondition)delegate(String newPathStr)
                        {
                            this.txtPathToEXEDB.Text = newPathStr;
                            this.sConfig.objDatabaseProc.EXEFile = Path.GetFileName(newPathStr);
                            this.sConfig.objDatabaseProc.Path = Path.GetDirectoryName(newPathStr);
                        }
                    );
                    return;

                case "btnFortxtPathToEXEBEC":       // Open File BEC (*.exe)

                    this.actionDelegateBrowseAction(
                        // TEXT BOX
                        this.txtPathToEXEBEC,
                        // ORIGIN PATH STRING
                        Path.Combine(this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier].objBECProc.Path, this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier].objBECProc.EXEFile),
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
                            var current = this.ExpandPathVars(Path.Combine(this.sConfig.objBECProc.Path, this.sConfig.objBECProc.EXEFile));
                            var newP = this.ExpandPathVars(newPathStr);

                            if (current == newP || !File.Exists(newP)) { return "silent"; }
                            else { return null; }
                        },
                        // SET WITH CONDITION
                        (userPathSetWithCondition)delegate(String newPathStr)
                        {
                            this.txtPathToEXEBEC.Text = newPathStr;
                            this.sConfig.objBECProc.EXEFile = Path.GetFileName(this.txtPathToEXEBEC.Text);
                            this.sConfig.objBECProc.Path = Path.GetDirectoryName(this.txtPathToEXEBEC.Text);
                        }
                    );
                    return;

                case "btnFortxtPathToEXEHC":        // Open File HC (*.exe)

                    this.actionDelegateBrowseAction(
                        // TEXT BOX
                        this.txtPathToEXEHC,
                        // ORIGIN PATH STRING
                        Path.Combine(this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier].objHeadlessClientProc.Path, this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier].objHeadlessClientProc.EXEFile),
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
                            var current = this.ExpandPathVars(Path.Combine(this.sConfig.objHeadlessClientProc.Path, this.sConfig.objHeadlessClientProc.EXEFile));
                            var newP = this.ExpandPathVars(newPathStr);

                            if (current == newP || !File.Exists(newP)) { return "silent"; }
                            else { return null; }
                        },
                        // SET WITH CONDITION
                        (userPathSetWithCondition)delegate(String newPathStr)
                        {
                            this.txtPathToEXEHC.Text = newPathStr;
                            this.sConfig.objHeadlessClientProc.EXEFile = Path.GetFileName(this.txtPathToEXEHC.Text);
                            this.sConfig.objHeadlessClientProc.Path = Path.GetDirectoryName(this.txtPathToEXEHC.Text);
                        }
                    );
                    return;

                case "btnFortxtPathToEXETS":        // Open File TS (*.exe)

                    this.actionDelegateBrowseAction(
                        // TEXT BOX
                        this.txtPathToEXETS,
                        // ORIGIN PATH STRING
                        Path.Combine(this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier].objTeamspeakProc.Path, this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier].objTeamspeakProc.EXEFile),
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
                            var current = this.ExpandPathVars(Path.Combine(this.sConfig.objTeamspeakProc.Path, this.sConfig.objTeamspeakProc.EXEFile));
                            var newP = this.ExpandPathVars(newPathStr);

                            if (current == newP || !File.Exists(newP)) { return "silent"; }
                            else { return null; }
                        },
                        // SET WITH CONDITION
                        (userPathSetWithCondition)delegate(String newPathStr)
                        {
                            this.txtPathToEXETS.Text = newPathStr;
                            this.sConfig.objTeamspeakProc.EXEFile = Path.GetFileName(this.txtPathToEXETS.Text);
                            this.sConfig.objTeamspeakProc.Path = Path.GetDirectoryName(this.txtPathToEXETS.Text);
                        }
                    );
                    return;

                case "btnFortxtPathToEXEASM":       // Open File ASM (*.exe)

                    this.actionDelegateBrowseAction(
                        // TEXT BOX
                        this.txtPathToEXEASM,
                        // ORIGIN PATH STRING
                        Path.Combine(this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier].objASMProc.Path, this.sc.CoreConfig.getServerConfigList()[this.sMeta.Identifier].objASMProc.EXEFile),
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
                            var current = this.ExpandPathVars(Path.Combine(this.sConfig.objASMProc.Path, this.sConfig.objASMProc.EXEFile));
                            var newP = this.ExpandPathVars(newPathStr);

                            if (current == newP || !File.Exists(newP)) { return "silent"; }
                            else { return null; }
                        },
                        // SET WITH CONDITION
                        (userPathSetWithCondition)delegate(String newPathStr)
                        {
                            this.txtPathToEXEASM.Text = newPathStr;
                            this.sConfig.objASMProc.EXEFile = Path.GetFileName(this.txtPathToEXEASM.Text);
                            this.sConfig.objASMProc.Path = Path.GetDirectoryName(this.txtPathToEXEASM.Text);
                        }
                    );
                    return;

                // DISABLED
                case "btnFortxtArmaExePath":        // Open File Server EXE (*.exe) -- not used
                    // Need to check if this path is in use.
                    // Need to check if this path is installed/has batch_lib etc. myabe prompt to load/override or cancel batch settings already found.
                    return;

                case "btnFortxtBatchSettingsPath":  // Save File Batch Settings (*.cmd)

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
                                "cmd"
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
                            // Different from origin
                            if (this.sc.CoreConfig.getServerMetaObject(this.sMeta.Identifier).PathToConfig.ToLower() != newPathStr.ToLower())
                            {
                                DialogResult dRes = MessageBox.Show(
                                    "Click Yes to rename the current settings file or No to create a new one"
                                        + "\n\n Note: Changes will not take effect until you click \"SAVE\"",
                                    "Rename Config",
                                    MessageBoxButtons.YesNoCancel);

                                if (dRes == DialogResult.Yes)
                                {
                                    this.onSaveRenameConfig = true;
                                }
                                else if (dRes == DialogResult.No)
                                {
                                    this.onSaveRenameConfig = false;
                                }
                                else if (dRes == DialogResult.Cancel)
                                {
                                    return;
                                }
                            }
                            else
                            {
                                // reset
                                this.onSaveRenameConfig = false;
                            }

                            // Update Properties
                            this.sConfig.skbtConfigPath = this.sMeta.PathToConfig = this.txtBatchSettingsPath.Text = newPathStr;
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
            CheckBox thisChk = (CheckBox)sender;
            String thisName = thisChk.Name;
            String thisTabPage = thisChk.Name.Substring(11, (thisChk.Name.Length - 11) - 1);
            String thisCoreNum = thisChk.Name.Substring(thisChk.Name.Length - 1);

            skbtProcessConfigBasic obj = (skbtProcessConfigBasic)this.sConfig.GetType().GetProperty("obj" + thisTabPage + "Proc").GetValue(this.sConfig, null);

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
                    MessageBox.Show("You can't run a process on 0 cores now can you?\nSelect the cores you want, then deselect the ones you dont.");
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
                    break;

                case "btnTabSelectBEC":
                    this.resetTabSelectButtons();

                    this.tabControlMainConfig.SelectTab("tabPageProcessBEC");
                    this.btnTabSelectBEC.Enabled = false;
                    this.btnTabSelectBEC.BackColor = System.Drawing.Color.FromArgb(64, 0, 0);
                    break;

                case "btnTabSelectDatabase":
                    this.resetTabSelectButtons();

                    this.tabControlMainConfig.SelectTab("tabPageProcessDatabase");
                    this.btnTabSelectDatabase.Enabled = false;
                    this.btnTabSelectDatabase.BackColor = System.Drawing.Color.FromArgb(64, 0, 0);
                    break;

                case "btnTabSelectHC":
                    this.resetTabSelectButtons();

                    this.tabControlMainConfig.SelectTab("tabPageProcessHC");
                    this.btnTabSelectHC.Enabled = false;
                    this.btnTabSelectHC.BackColor = System.Drawing.Color.FromArgb(64, 0, 0);
                    break;

                case "btnTabSelectTS":
                    this.resetTabSelectButtons();

                    this.tabControlMainConfig.SelectTab("tabPageProcessTS");
                    this.btnTabSelectTS.Enabled = false;
                    this.btnTabSelectTS.BackColor = System.Drawing.Color.FromArgb(64, 0, 0);
                    break;

                case "btnTabSelectASM":
                    this.resetTabSelectButtons();

                    this.tabControlMainConfig.SelectTab("tabPageProcessASM");
                    this.btnTabSelectASM.Enabled = false;
                    this.btnTabSelectASM.BackColor = System.Drawing.Color.FromArgb(64, 0, 0);
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
            this.btnTabSelectTS.Enabled = true;

            // Reset Color States
            this.btnTabSelectServer.BackColor = System.Drawing.Color.FromName("Gray");
            this.btnTabSelectDatabase.BackColor = System.Drawing.Color.FromName("Gray");
            this.btnTabSelectBEC.BackColor = System.Drawing.Color.FromName("Gray");
            this.btnTabSelectHC.BackColor = System.Drawing.Color.FromName("Gray");
            this.btnTabSelectASM.BackColor = System.Drawing.Color.FromName("Gray");
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

            // Lone Checkboxes
            Color cbForeCol = Color.FromKnownColor(KnownColor.ScrollBar);
            this.chkServerBindToIP.ForeColor = cbForeCol;
            this.chkUseZipBackups.ForeColor = cbForeCol;
            this.chkUseZipLogs.ForeColor = cbForeCol;

            // List Boxes (priorites)
            Color cBoxBackCol = Color.FromArgb(40, 40, 40);
            this.cBoxPriorityASM.BackColor = cBoxBackCol;
            this.cBoxPriorityBEC.BackColor = cBoxBackCol;
            this.cBoxPriorityDatabase.BackColor = cBoxBackCol;
            this.cBoxPriorityHeadlessClient.BackColor = cBoxBackCol;
            this.cBoxPriorityServer.BackColor = cBoxBackCol;
            this.cBoxPriorityTeamspeak.BackColor = cBoxBackCol;

        }
        private void resetAllAffinityCheckboxes()
        {
            String[] tabNames = new String[] {
                "Server",
                "Database",
                "BEC",
                "HeadlessClient",
                "Teamspeak",
                "ASM"
            };

            foreach (String tabName in tabNames)
            {
                for (int i = 0; i < 8; i++)
                {
                    CheckBox tChk = (CheckBox)this.Controls.Find("chkAffinity" + tabName + (i).ToString(), true)[0];
                    tChk.Enabled = (i > Environment.ProcessorCount - 1) ? false : true;
                }
            }

        }
        private void setAffinityChkBoxes(String ctrlSuffix, String affinityStr)
        {

            String[] selCores = affinityStr.Split(',');

            for (int i = 0; i < Environment.ProcessorCount; i++)
            {
                CheckBox tmpChkHandle = (CheckBox)this.Controls.Find("chkAffinity" + ctrlSuffix + (i).ToString(), true)[0];

                // Enable the checkbox
                tmpChkHandle.Enabled = true;

                if (selCores.Contains((i).ToString()) || affinityStr == null || affinityStr == "")
                {
                    tmpChkHandle.Checked = true;

                    // set to green
                    this.setAffinityChkColor(tmpChkHandle, false);
                }
                else
                {
                    // set to red
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
            this.openFileDialog.InitialDirectory = Directory.Exists(startFolder) ? startFolder : Path.GetDirectoryName(this.sMeta.PathToEXE);
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
        private String showSaveFileDialog(String title, String defaultFileName, String filter, String startFolder, String defaultExt)
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
            this.saveFileDialog.OverwritePrompt = false;
            this.saveFileDialog.InitialDirectory = startFolder;
            this.saveFileDialog.FileName = defaultFileName;

            // Show Dialog
            DialogResult result = this.saveFileDialog.ShowDialog();

            // Check if user Canceled
            if (result == DialogResult.OK)
            {
                // Return Chosen Path/Filename
                newFilePath = this.saveFileDialog.FileName;
            }
            else
            {
                // User Cancelled
                newFilePath = Path.Combine(startFolder, defaultFileName);
            }

            return newFilePath;
        }
        private String ExpandPathVars(String path)
        {
            // %armapath%
            String armapath = Path.GetDirectoryName(this.sMeta.PathToEXE);
            return path.Replace("%armapath%", armapath);
        }
        private String CollapsePathVars(String path)
        {
            if (path == null) { return null; }
            // %armapaths%
            String armapath = Path.GetDirectoryName(this.sMeta.PathToEXE);
            return path.Replace(armapath, "%armapath%");
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
}
