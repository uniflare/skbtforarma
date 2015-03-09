using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace skbtInstaller
{
    /*  class skbtServerConfig
     * 
     *  SKBT Config for a server (Maps to batch_settings.cmd for use of SKBT)
     * 
     */
    public class skbtServerConfig
    {

        // Path to batch settings file for this server
        public String skbtConfigPath; // move to CoreConfig

        // Process Config Objects
        public skbtProcessConfigServer objServerProc       // Server Process
        { get; private set; }
        public skbtProcessConfigASM objASMProc             // ASM Process
        { get; private set; }
        public skbtProcessConfigDatabase objDatabaseProc   // Database Process
        { get; private set; }
        public skbtProcessConfigTeamspeak objTeamspeakProc // Teamspeak Process
        { get; private set; }
        public skbtProcessConfigHC objHeadlessClientProc   // Headless Client Process
        { get; private set; }
        public skbtProcessConfigBEC objBECProc             // BEC Process
        { get; private set; }

        // Ref Prop
        String refPathToEXE;


        // Keepalive Flags
        public bool CleanWER;

        // Bind to IP (via command line)
        public bool BindToIP;
        public string IP;
        public UInt16 Port;

        // Keepalive Settings
        public Int32 ServerStartTimeout;
        public Int32 ManualTimeoutLength;
        public Int32 AutoTimeoutLength;

        /*  skbtServerConfig(String configPath)
         * 
         * Either attempts to load configPath File or will otherwise 
         * revert to default values.
         */
        public skbtServerConfig(String PathToEXE, String configPath = null)
        {
            this.skbtConfigPath = configPath;
            this.refPathToEXE = PathToEXE;

            // attempt to load skbt settings
            if (configPath == null || !File.Exists(this.skbtConfigPath))
            {
                // No Config, set default properties
                this.loadDefaultsForEpoch();
            }
            else
            {
                // Load skbt configuration from file
                this.loadBatchSettingsFromFile();
            }
        }

        public skbtServerConfig(skbtServerConfig origin)
        {
            this.AutoTimeoutLength = origin.AutoTimeoutLength;
            this.BindToIP = origin.BindToIP;
            this.CleanWER = origin.CleanWER;
            this.IP = origin.IP;
            this.ManualTimeoutLength = origin.ManualTimeoutLength;
            this.objASMProc = new skbtProcessConfigASM(
                origin.objASMProc.EXEFile, 
                origin.objASMProc.Path,
                origin.objASMProc.Keepalive,
                origin.objASMProc.Priority,
                origin.objASMProc.Affinity,
                origin.objASMProc.LogFileName,
                origin.objASMProc.LogInterval
            );
            this.objBECProc = new skbtProcessConfigBEC(
                origin.objBECProc.EXEFile, 
                origin.objBECProc.Path,
                origin.objBECProc.Keepalive,
                origin.objBECProc.Priority,
                origin.objBECProc.Affinity,
                origin.objBECProc.BEPath,
                origin.objBECProc.useDSC
            );
            this.objDatabaseProc = new skbtProcessConfigDatabase(
                origin.objDatabaseProc.EXEFile,
                origin.objDatabaseProc.Path,
                origin.objDatabaseProc.Keepalive,
                origin.objDatabaseProc.Priority,
                origin.objDatabaseProc.Affinity,
                origin.objDatabaseProc.UseZipBackups,
                origin.objDatabaseProc.DatabaseBackupInterval,
                origin.objDatabaseProc.BackupFolder,
                origin.objDatabaseProc.DatabaseDumpFileName,
                origin.objDatabaseProc.DatabaseDumpFilePath
            );
            this.objHeadlessClientProc = new skbtProcessConfigHC(
                origin.objHeadlessClientProc.EXEFile,
                origin.objHeadlessClientProc.Path,
                origin.objHeadlessClientProc.Keepalive,
                origin.objHeadlessClientProc.Priority,
                origin.objHeadlessClientProc.Affinity,
                origin.objHeadlessClientProc.LaunchParams
            );
            this.objServerProc = new skbtProcessConfigServer(
                origin.objServerProc.EXEFile,
                origin.objServerProc.Path,
                origin.objServerProc.Keepalive,
                origin.objServerProc.Priority,
                origin.objServerProc.Affinity,
                origin.objServerProc.Port,
                origin.objServerProc.ConfigPathBasic,
                origin.objServerProc.ConfigPathServer,
                origin.objServerProc.ProfileName,
                origin.objServerProc.ProfilePath,
                origin.objServerProc.CommandLine,
                origin.objServerProc.ModLine,
                origin.objServerProc.LogFilePath,
                origin.objServerProc.LogFileBackupPath,
                origin.objServerProc.UseZipLogs
            );
            this.objTeamspeakProc = new skbtProcessConfigTeamspeak(
                origin.objTeamspeakProc.EXEFile,
                origin.objTeamspeakProc.Path,
                origin.objTeamspeakProc.Keepalive,
                origin.objTeamspeakProc.Priority,
                origin.objTeamspeakProc.Affinity,
                origin.objTeamspeakProc.PortNumber
            );
            this.Port = origin.Port;
            this.ServerStartTimeout = origin.ServerStartTimeout;
            this.skbtConfigPath = origin.skbtConfigPath;
        }

        /*  loadDefaultsForEpoch()
         * 
         * Loads default config values for a default epoch installation
         * (Some pre loaded defaults for external programs will no doubt be wrong)
         */
        public void loadDefaultsForEpoch()
        {

            this.CleanWER = false;
            this.BindToIP = false;
            this.IP = "127.0.0.1";
            this.Port = (UInt16) 2302;
            this.ServerStartTimeout = 30;   // 30 sec for retry
            this.ManualTimeoutLength = 300; // 5 minutes
            this.AutoTimeoutLength = 25; // 25 sec for graceful shutdown

            this.objServerProc = new skbtProcessConfigServer(
                Path.GetFileName(refPathToEXE),
                Path.GetDirectoryName(refPathToEXE), 
                true, 
                "normal",
                skbtServerControl.getDefaultAffinityString(),
                (UInt16) 2302,
                "%armapath:\"=%\\SC\\basic.cfg", 
                "%armapath:\"=%\\SC\\config.cfg",
                "SC",
                "SC",
                "%armaserverexe% \"%mod_string:\"=%\" \"-config=%servercfgpath:\"=%\" %ip_param% -port=%serverport% \"-profiles=%profilepathname:\"=%\" \"-cfg=%serverbasicpath:\"=%\" \"-name=%cli_username:\"=%\" -autoinit",
                "-mod=@Epoch;@EpochHive",
                "%armapath:\"=%\\SC",
                @"C:\apps\epoch_log_backups",
                true
            );

            this.objDatabaseProc = new skbtProcessConfigDatabase(
                "redis-server.exe",
                "%armapath:\"=%\\DB",
                true,
                "normal",
                skbtServerControl.getDefaultAffinityString(),
                true,
                5,
                @"C:\apps\epoch_redis_backups",
                "dump.rdb",
                "%armapath:\"=%\\DB"
            );

            this.objBECProc = new skbtProcessConfigBEC(
                "bec.exe",
                "%armapath:\"=%\\BEC",
                true,
                "normal",
                skbtServerControl.getDefaultAffinityString(),
                "%armapath:\"=%\\SC\\BattlEye",
                true
            );

            this.objASMProc = new skbtProcessConfigASM(
                "ArmaServerMonitor.exe", 
                "%armapath:\"=%", 
                false, 
                "normal",
                skbtServerControl.getDefaultAffinityString(), 
                "asm_performance.log", 
                (UInt16)5
            );

            this.objTeamspeakProc = new skbtProcessConfigTeamspeak(
                "ts3server_win64.exe",
                @"C:\apps\teamspeak",
                false,
                "normal",
                skbtServerControl.getDefaultAffinityString(),
                (UInt16) 2310
            );

            this.objHeadlessClientProc = new skbtProcessConfigHC(
                "arma3serverHC.exe",
                "%armapath:\"=%",
                false,
                "normal",
                skbtServerControl.getDefaultAffinityString(),
                "-connect=%serverip% -port=%serverport% -client -nosound -mod=@Epoch;"
            );

            // Defaults loaded
        }

        /*  LoadBatchSettingsFromFile()
         *  
         *  Opens this.skbtConfigPath batch settings file and reads its settings.
         *  Copies settings into this object for usage.
         */
        private void loadBatchSettingsFromFile(){

            // Settings Array
            var skbtConfigArray = new Dictionary<String, String>();

            var skbtConfigStream = new StreamReader(this.skbtConfigPath);
            String line;
            try
            {
                while ((line = skbtConfigStream.ReadLine()) != null)
                {
                    if (line.Length > 5)
                    {
                        if (line.Substring(0, 3) == "set")
                        {
                            // Find Property to save
                            String propString = line.Substring(4);
                            String[] propStringSplit = propString.Split(new char[] { '=' }, 2);

                            if (propStringSplit.Count<String>() > 1)
                            {
                                if (skbtConfigArray.ContainsKey(propStringSplit[0]))
                                {
                                    skbtConfigArray[propStringSplit[0]] = expandPathVar(propStringSplit[1].Trim(' ', '"'));
                                }
                                else
                                {
                                    skbtConfigArray.Add(propStringSplit[0], expandPathVar(propStringSplit[1].Trim(' ', '"')));
                                }
                            }
                        }
                    }
                }
                skbtConfigStream.Close();
            }
            catch
            {
                MessageBox.Show("ERROR 874237:: COULD NOT LOAD BATCH_SETTINGS");
                skbtConfigStream.Close();
                this.loadDefaultsForEpoch();
                return;
            }


            // Setup this Object using array contents

            // Make sure config is correctly formatted with all values defined
            if(
                skbtConfigArray.ContainsKey("keepalive_database") &&
                skbtConfigArray.ContainsKey("keepalive_bec") &&
                skbtConfigArray.ContainsKey("keepalive_asm") &&
                skbtConfigArray.ContainsKey("keepalive_ts") &&
                skbtConfigArray.ContainsKey("keepalive_hc") &&
                skbtConfigArray.ContainsKey("serverport") &&
                skbtConfigArray.ContainsKey("bindtoip") &&
                skbtConfigArray.ContainsKey("serverip") &&
                skbtConfigArray.ContainsKey("teamspeak_port") &&
                skbtConfigArray.ContainsKey("asm_log_interval") &&
                skbtConfigArray.ContainsKey("serverStartTimeout") &&
                skbtConfigArray.ContainsKey("db_backup_interval") &&
                skbtConfigArray.ContainsKey("use_zip_logs") &&
                skbtConfigArray.ContainsKey("use_zip_backups") &&
                skbtConfigArray.ContainsKey("databasebackupfolder") &&
                skbtConfigArray.ContainsKey("logfilebackupfolder") &&
                skbtConfigArray.ContainsKey("manual_timeout_length") &&
                skbtConfigArray.ContainsKey("auto_timeout_length") &&
                skbtConfigArray.ContainsKey("cleanWerDialogs") &&
                skbtConfigArray.ContainsKey("hclaunchparams") &&
                skbtConfigArray.ContainsKey("armaserverexe") &&
                skbtConfigArray.ContainsKey("hcexename") &&
                skbtConfigArray.ContainsKey("teamspeakfilename") &&
                skbtConfigArray.ContainsKey("redisexename") &&
                skbtConfigArray.ContainsKey("becexename") &&
                skbtConfigArray.ContainsKey("asmexename") &&
                skbtConfigArray.ContainsKey("databasefile_name") &&
                skbtConfigArray.ContainsKey("asm_log_file") &&
                skbtConfigArray.ContainsKey("armapath") &&
                skbtConfigArray.ContainsKey("hcarmapath") &&
                skbtConfigArray.ContainsKey("teamspeakpath") &&
                skbtConfigArray.ContainsKey("redispath") &&
                skbtConfigArray.ContainsKey("asmpath") &&
                skbtConfigArray.ContainsKey("Battleyepath") &&
                skbtConfigArray.ContainsKey("LogPath") &&
                skbtConfigArray.ContainsKey("becpath") &&
                skbtConfigArray.ContainsKey("databasefile") &&
                skbtConfigArray.ContainsKey("servercfgpath") &&
                skbtConfigArray.ContainsKey("serverbasicpath") &&
                skbtConfigArray.ContainsKey("profilepathname") &&
                skbtConfigArray.ContainsKey("cli_username") &&
                skbtConfigArray.ContainsKey("mod_string") &&
                skbtConfigArray.ContainsKey("servercommandline") &&
                skbtConfigArray.ContainsKey("serverAffinity") &&
                skbtConfigArray.ContainsKey("becAffinity") &&
                skbtConfigArray.ContainsKey("hcAffinity") &&
                skbtConfigArray.ContainsKey("redisAffinity") &&
                skbtConfigArray.ContainsKey("teamspeakAffinity") &&
                skbtConfigArray.ContainsKey("asmAffinity") &&
                skbtConfigArray.ContainsKey("serverPriority") &&
                skbtConfigArray.ContainsKey("becPriority") &&
                skbtConfigArray.ContainsKey("hcPriority") &&
                skbtConfigArray.ContainsKey("redisPriority") &&
                skbtConfigArray.ContainsKey("teamspeakPriority") &&
                skbtConfigArray.ContainsKey("asmPriority")
            )
            {
                // Backwards Compatibility
                Boolean useDSC = true;  // Default on, most compatible setting.
                if (skbtConfigArray.ContainsKey("bec_flag_dsc")){
                    useDSC = (skbtConfigArray["bec_flag_dsc"].ToString() == "0") ? false : true;
                }


                this.CleanWER = (skbtConfigArray["cleanWerDialogs"] == "true")? true : false;
                this.BindToIP = (skbtConfigArray["bindtoip"] == "1")? true : false;
                this.IP = skbtConfigArray["serverip"];
                this.Port = Convert.ToUInt16(skbtConfigArray["serverport"]);

                this.ServerStartTimeout = Convert.ToInt32(skbtConfigArray["serverStartTimeout"]);
                this.ManualTimeoutLength = Convert.ToInt32(skbtConfigArray["manual_timeout_length"]);
                this.AutoTimeoutLength = Convert.ToInt32(skbtConfigArray["auto_timeout_length"]);

                String exePath = Path.Combine(skbtConfigArray["armapath"], skbtConfigArray["armaserverexe"]);

                // New Server Process Config Instance
                this.objServerProc = new skbtProcessConfigServer(
                        skbtConfigArray["armaserverexe"],
                        skbtConfigArray["armapath"],
                        true,
                        skbtConfigArray["serverPriority"],
                        skbtConfigArray["serverAffinity"],
                        Convert.ToUInt16(skbtConfigArray["serverport"]),
                        skbtConfigArray["serverbasicpath"],
                        skbtConfigArray["servercfgpath"],
                        skbtConfigArray["cli_username"],
                        skbtConfigArray["profilepathname"],
                        skbtConfigArray["servercommandline"],
                        skbtConfigArray["mod_string"],
                        skbtConfigArray["LogPath"],
                        skbtConfigArray["logfilebackupfolder"],
                        (skbtConfigArray["use_zip_logs"] == "1")? true : false
                );

                // New Database Process Config Instance
                this.objDatabaseProc = new skbtProcessConfigDatabase(
                        skbtConfigArray["redisexename"],
                        skbtConfigArray["redispath"],
                        (skbtConfigArray["keepalive_database"] == "1")? true : false,
                        skbtConfigArray["redisPriority"],
                        skbtConfigArray["redisAffinity"],
                        (skbtConfigArray["use_zip_backups"] == "1")? true : false,
                        Convert.ToUInt32(skbtConfigArray["db_backup_interval"]),
                        skbtConfigArray["databasebackupfolder"],
                        skbtConfigArray["databasefile_name"],
                        Path.GetDirectoryName(skbtConfigArray["databasefile"].Replace("%databasefile_name:\"=%", skbtConfigArray["databasefile_name"]))
                );

                // New BEC Process Config Instance
                this.objBECProc = new skbtProcessConfigBEC(
                        skbtConfigArray["becexename"],
                        skbtConfigArray["becpath"],
                        (skbtConfigArray["keepalive_bec"] == "1") ? true : false,
                        skbtConfigArray["becPriority"],
                        skbtConfigArray["becAffinity"],
                        skbtConfigArray["Battleyepath"],
                        useDSC
                );

                // New Teamspeak Process Config Instance
                this.objTeamspeakProc = new skbtProcessConfigTeamspeak(
                        skbtConfigArray["teamspeakfilename"],
                        skbtConfigArray["teamspeakpath"],
                        (skbtConfigArray["keepalive_ts"] == "1") ? true : false,
                        skbtConfigArray["teamspeakPriority"],
                        skbtConfigArray["teamspeakAffinity"],
                        Convert.ToUInt16(skbtConfigArray["teamspeak_port"])
                );

                // New ASM Process Config Instance
                this.objASMProc = new skbtProcessConfigASM(
                        skbtConfigArray["asmexename"],
                        skbtConfigArray["asmpath"],
                        (skbtConfigArray["keepalive_asm"] == "1") ? true : false,
                        skbtConfigArray["asmPriority"],
                        skbtConfigArray["asmAffinity"],
                        skbtConfigArray["asm_log_file"],
                        Convert.ToUInt16(skbtConfigArray["asm_log_interval"])
                );

                // New HC Process Config Instance
                this.objHeadlessClientProc = new skbtProcessConfigHC(
                        skbtConfigArray["hcexename"],
                        skbtConfigArray["hcarmapath"],
                        (skbtConfigArray["keepalive_hc"] == "1") ? true : false,
                        skbtConfigArray["hcPriority"],
                        skbtConfigArray["hcAffinity"],
                        skbtConfigArray["hclaunchparams"]
                );
            }else{
                MessageBox.Show("ERROR: Could not load batch_settings properly, has it been modified incorrectly? or from a different version?");

                // Revert to defaults
                this.loadDefaultsForEpoch();
            }
        }

        private String expandPathVar(String path)
        {
            return path.Replace("%armapath%", Path.GetDirectoryName(this.refPathToEXE)).Replace("%armapath:\"=%", Path.GetDirectoryName(this.refPathToEXE));
            return path;
        }
    }
}
