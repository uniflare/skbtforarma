using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO.Compression;
using System.Reflection;
using System.Collections;
using System.Runtime.InteropServices;

namespace skbtInstaller
{
    /*  class skbtServerControl(frmMainWindow FormWindowHandle)
     * 
     * Backend Mechanism for User Interaction
     * Handles all tasks required by user actions
     * 
     */
    public class skbtServerControl
    {
        [DllImport("kernel32", EntryPoint = "GetShortPathName", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int GetShortPathName(string longPath, StringBuilder shortPath, int bufSize);

        [DllImport("kernel32.dll", EntryPoint = "GetLongPathName", SetLastError = true, CharSet = CharSet.Auto)]
        private static extern int GetLongPathName(string shortPath, StringBuilder longPath, int buffer);

        public static String ProgramGroupName = "SKBT for Arma";

        // Handle to Main Form Components
        public frmMainWindow frmMainWindowHandle;

        // Handle config Form components
        public frmConfigWindow frmConfigWindowHandle;

        // Core Config for Application
        public skbtCoreConfig CoreConfig;


        /*  skbtServerControl(frmMainWindow FormWindowHandle)
         * 
         * Constructs and Sets all memebrs for use
         * Loads config class
         * Refreshes List box after potentially loading new list items
         * 
         * [FormWindowHandle] Handle to the Main Form Window Class
         */
        public skbtServerControl(frmMainWindow f)
        {
            // Set the form handle
            this.frmMainWindowHandle = f;
            this.frmConfigWindowHandle = new frmConfigWindow(this);

            // Load Config
            CoreConfig = new skbtCoreConfig(this);

            // Refresh List Box Items
            this.refreshListBox();

            // Refresh Buttons
            this.refreshButtons();
        }

        /*  AddNewServerConfig()
         * 
         * Attempts to add a new config object for the selected server EXE
         * 
         * Checks whether the selected EXE already has an Installed SKBT
         */
        public void AddNewServerConfig(){

            String PathToEXE = this.frmMainWindowHandle.getNewServerEXEPathFromUser();

            if (PathToEXE == null)
            {
                return;
            }

            String FileName = Path.GetFileName(PathToEXE);
            String FilePath = Path.GetDirectoryName(PathToEXE);

            // Get a new unique id
            String newID = this.getNewID();

            // Initialize
            String textualName;

            // Check if path is already in use
            if (this.CoreConfig.ServerPathInUse(PathToEXE))
            {
                // get name 
                MessageBox.Show("This path is already in use as a server config (\"" + this.CoreConfig.getConfigNameFromEXEPath(PathToEXE) + "\"). \nPlease select it from the list and click configure.");
                return;
            }

            String batch_libPath = Path.Combine(FilePath, "batch_lib");

            String cPath = getConfigPathFromBatchFiles(batch_libPath);
            if (cPath != null)
            {

                if (System.IO.File.Exists(cPath))
                {

                    // No Folder, Not Installed
                    textualName = this.frmMainWindowHandle.getNewServerConfigNameFromUser();
                    if (textualName == null)
                    {
                        // User Cancelled
                        return;
                    }
                    else
                    {
                        // Check if config name is in use by another config
                        while (this.configNameInUse(textualName))
                        {
                            MessageBox.Show("The configuration name you set is already in use by another config!");
                            textualName = this.frmMainWindowHandle.getNewServerConfigNameFromUser();
                            if (textualName == null)
                            {
                                return;
                            }
                        }

                        // Add Server config instance to core config list
                        this.CoreConfig.addServerConfig(newID, new skbtServerConfig(PathToEXE, cPath));

                        // Add server meta for Application to keep track
                        this.CoreConfig.addServerMeta(newID, new skbtServerMeta(newID, textualName, PathToEXE, cPath, true));

                        // Update List Contents
                        this.refreshListBox();

                        // Refresh Buttons
                        this.refreshButtons();

                        // Saev core Config Changes
                        this.CoreConfig.saveCoreConfig();

                        // Be Sure to Select New Item
                        this.frmMainWindowHandle.setSelectedIndexOnList(newID);
                        return;
                    }
                }
                else
                {
                    // No Config File, Not installed?
                    MessageBox.Show("CAUTION! It seems your batch_lib folder has already been installed. But the batch_settings file cannot be found where it should be... Using Defaults...");
                }
            }

            // No Folder, Not Installed
            textualName = this.frmMainWindowHandle.getNewServerConfigNameFromUser();
            if(textualName == null){
                return;
            }

            // Check if config name is in use by another config
            while(this.configNameInUse(textualName))
            {
                MessageBox.Show("The configuration name you set is already in use by another config!");
                textualName = this.frmMainWindowHandle.getNewServerConfigNameFromUser();
                if (textualName == null)
                {
                    return;
                }
            }

            MessageBox.Show("There was no installation found. Please install.");

            // Add config internally
            this.CoreConfig.addServerConfig(newID, new skbtServerConfig(PathToEXE));

            // Add Config Meta
            this.CoreConfig.addServerMeta(newID, new skbtServerMeta(newID, textualName, PathToEXE, null, false));

            // Update List Contents
            this.refreshListBox();

            // Be Sure to Select New Item
            this.frmMainWindowHandle.setSelectedIndexOnList(newID);

            // refresh buttons
            this.refreshButtons();

            this.CoreConfig.saveCoreConfig();
        }

        public String getConfigPathFromBatchFiles(String batchLibPath)
        {
            if (Directory.Exists(batchLibPath) && System.IO.File.Exists(Path.Combine(batchLibPath, "start_keepalive.bat")))
            {
                // Decl
                String result;

                // Load Known Batch File
                var file = new StreamReader(Path.Combine(batchLibPath, "start_keepalive.bat"));

                // Skip read first line
                file.ReadLine();

                // Read Second line and remove "call " so we get the path
                result = file.ReadLine().Substring(5);

                String longPath = result;

                // Check if result is shortpath
                if (result.Contains('~'))
                {
                    // Get Short Path (just in case)
                    var buffer = new StringBuilder(259);
                    int len = GetLongPathName(longPath, buffer, buffer.Capacity);
                    if (len == 0)
                    {
                        // Might need to sort this at some point
                        // MessageBox.Show("Could not convert batch settings path from \"8.3 short path\" to normal \"Long path\".\n\nYou can continue, but be warned you will have to re-set the batch settings path in the configuration window.", "Kernel32.dll error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        longPath = buffer.ToString();
                    }
                }


                // ...
                file.Close();
                return longPath;
            }
            else
            {
                return null;
            }

        }

        /*  refreshListBox()
         * 
         * Refreshes the ListBox with the current Server Object List
         */
        public void refreshListBox()
        {
            // Clear Drop Box
            this.frmMainWindowHandle.clearPathBox();

            List<KeyValuePair<String, String>> newSource = new List<KeyValuePair<String, String>>();

            foreach (KeyValuePair<String, skbtServerConfig> pair in CoreConfig.getServerConfigList())
            {
                // Populate Drop Box
                newSource.Add(new KeyValuePair<String, String>(pair.Key, this.CoreConfig.getServerMetaObject(pair.Key).textualName));
            }

            this.frmMainWindowHandle.setServerPathDatasource(newSource);
        }

        /* refreshButtons()
         * 
         * Sets whether isntall/uninstall and configure buttons are enabled or disabled 
         * depending on whether the selected server object is installed or not.
         */
        public void refreshButtons()
        {
            // check if installed or not.
            String Identifier = this.getSelectedPathIdentifier();
            if (Identifier != null)
            {
                if (this.CoreConfig.checkSKBTInstalled(Identifier))
                {
                    // Installed
                    this.frmMainWindowHandle.disableInstall();
                    this.frmMainWindowHandle.enableUninstall();
                    this.frmMainWindowHandle.enableConfigure();

                }
                else
                {
                    // Not Installed
                    this.frmMainWindowHandle.enableInstall();
                    this.frmMainWindowHandle.disableUninstall();
                    this.frmMainWindowHandle.disableConfigure();
                }
            }
            else
            {
                this.frmMainWindowHandle.disableInstall();
                this.frmMainWindowHandle.disableUninstall();
                this.frmMainWindowHandle.disableConfigure();
            }
        }

        /*  getNewID()
         * 
         * Generates a new Unique String
         */
        private String getNewID()
        {
            Guid g = Guid.NewGuid();
            string GuidString = Convert.ToBase64String(g.ToByteArray());
            GuidString = GuidString.Replace("=", "");
            GuidString = GuidString.Replace("+", "");

            return GuidString;
        }

        /*  getAffinityString(String[] ArrayOfCoreIDs)
         * 
         * Returns a comma seperate list of core numbers (for use with PSEXEC)
         * 
         * [ArrayOfCoreIDs] Simple String[] Array of Core Numbers (Can be 0 for all cores)
         */
        public String getAffinityString(String[] cores)
        {
            int procCount = Environment.ProcessorCount;
            if (procCount > 8) { procCount = 8; }
            String aStr = "";
            if (cores.Count() > 0)
            {
                for (int i = 0; i < cores.Count(); i++)
                {
                    int result;
                    if (!Int32.TryParse(cores.GetValue(i).ToString(), out result))
                    {
                        aStr = getAffinityString(new String[] {});
                        break;
                    }
                    aStr += ((aStr.Length >= 1)? "," : "") + cores.GetValue(i).ToString();
                }
            }
            else
            {
                aStr += "0";
                for (int i = 1; i < procCount; i++)
                {
                    aStr += "," + ++i;
                }

            }
            return aStr;
        }
        public static String getDefaultAffinityString()
        {
            int procCount = Environment.ProcessorCount;
            if (procCount > 8) { procCount = 8; }

            UInt16 i = 0;
            String result = "";
            do
            {
                result += result.Length >= 1 ? "," + i.ToString() : i.ToString();
                i++;
            } while (i < procCount);
            return result;
        }

        /*  getSelectedPathIdentifier()
         * 
         * Gets the selected List Box Item and Returns the Associated Identifier (Value)
         */
        public String getSelectedPathIdentifier()
        {
            return this.frmMainWindowHandle.getSelectedPathValue();
        }


        /*  doConfigure()
         * 
         * Handles configuration button mechanics
         */
        public void ShowConfigure(Boolean isInstalling=false)
        {
            // Configure button was clicked

            // load a new configuration form with the selected config object in list box

            this.frmConfigWindowHandle.DisplayConfigWindow(
                this.CoreConfig.getServerMetaObject(this.getSelectedPathIdentifier()), 
                this.CoreConfig.getServerConfigList()[this.getSelectedPathIdentifier()]
            );
        }

        public void doBatchLibFiles(String cfgPath, String batchLibParentFolder)
        {

            // Copy Zip To Temp
            Assembly asm = Assembly.GetExecutingAssembly();
            Stream s = asm.GetManifestResourceStream("skbtInstaller.Resources.batch_lib_template.zip");

            FileStream fs;
            String tempZip = Path.Combine(Path.GetTempPath(), "batch_lib_template.zip");
            if (System.IO.File.Exists(tempZip)) { System.IO.File.Delete(tempZip); }

            fs = System.IO.File.Create(tempZip);
            int b = s.ReadByte();
            while (b != -1) { fs.WriteByte((byte)b); b = s.ReadByte(); }
            fs.Close();

            String blPath = Path.Combine(batchLibParentFolder, "batch_lib");

            // Check and/or delete batch_lib
            if (Directory.Exists(blPath))
            {
                try
                {
                    Directory.Delete(blPath, true);
                }
                catch (Exception e)
                {
                    MessageBox.Show("There was an error deleting the old batch_lib folder. Please locate and manually delete this folder before proceeding.");
                }
            }

            // Extract Zip to Batch Lib Folder
            ZipFile.ExtractToDirectory(tempZip, batchLibParentFolder);

            // Get all .bat and .cmd files for processing
            ArrayList alFiles = new ArrayList();
            foreach (string FileFilter in new String[] { "*.cmd", "*.bat" })
            {
                // add found file names to array list
                alFiles.AddRange(Directory.GetFiles(blPath, FileFilter, SearchOption.AllDirectories));
            }

            string[] files = (string[])alFiles.ToArray(typeof(string));

            String shortPath = cfgPath;
            // Get Short Path (just in case)
            if (shortPath.Contains(' ') && System.IO.File.Exists(shortPath))
            {
                var buffer = new StringBuilder(259);
                int len = GetShortPathName(shortPath, buffer, buffer.Capacity);
                if (len == 0)
                {
                    MessageBox.Show("Could not convert batch settings path to 8.3 short name. (Make sure you have NO SPACES in your batch_settings path!", "Error converting path", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    shortPath = buffer.ToString();
                }
            }

            // Rewrite Strings
            for (int i = 0; i < files.Length; i++)
            {
                String file = files[i].ToString();
                System.IO.File.WriteAllText(
                        file,
                        System.IO.File.ReadAllText(file)
                            .Replace("{PATH_TO_CONFIG}", shortPath)
                            .Replace("{AUTHOR}", skbtCoreConfig.strAuthor)
                            .Replace("{VERSION}", skbtCoreConfig.strVersion)
                            .Replace("{KEEPALIVE_TITLE}", skbtCoreConfig.strKeepaliveTitle)
                            .Replace("{KALAUNCHER_TITLE}", skbtCoreConfig.strLauncherTitle)
                            .Replace("{DISPLAY_HEADER}", skbtCoreConfig.strKeepaliveHead)
                    );
            };
        }

        public void InstallBatchLib(String Identifier, String newConfigName)
        {
            // exit on error/cancel
            if (Identifier == null || newConfigName == null) { return; }
            
            // Set default objServerProc.Path / ExeFile
            String serverPath = Path.GetDirectoryName(this.CoreConfig.getServerMetaObject(Identifier).PathToEXE);
            String serverEXE = Path.GetFileName(this.CoreConfig.getServerMetaObject(Identifier).PathToEXE);

            this.CoreConfig.getServerConfigList()[Identifier].objServerProc.Path = serverPath;
            this.CoreConfig.getServerConfigList()[Identifier].objServerProc.EXEFile = serverEXE;
            this.CoreConfig.getServerMetaObject(Identifier).PathToConfig = newConfigName;

            bool created = false;
            // Create default config file.
            if (!System.IO.File.Exists(newConfigName))
            {
                // Create blank config for shortname
                System.IO.File.WriteAllText(newConfigName, "BLANKFILE. IF YOU SEE THIS FILE. PLEASE REPORT A BUG FOR THE SKBT INSTALLER. (and delete this file)");
                created = true;
            }

            // Copy and Process Batch Lib Files
            this.doBatchLibFiles(newConfigName, serverPath);

            // delete created file
            if (created)
            {
                System.IO.File.Delete(newConfigName);
            }
        }

        public bool configNameInUse(string name)
        {
            foreach (KeyValuePair<string, skbtServerConfig> cfg in CoreConfig.getServerConfigList())
            {
                string thisName = CoreConfig.getServerMetaObject(cfg.Key).textualName;
                if (thisName == name)
                {
                    return true;
                }
            }
            return false;
        }
    }

}
