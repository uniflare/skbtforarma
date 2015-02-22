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
            CoreConfig = new skbtCoreConfig();

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

            // TODO: Check if path is already in use
            if (this.CoreConfig.ServerPathInUse(PathToEXE))
            {
                // get name 
                MessageBox.Show("This path is already in use as a server config (\"" + this.CoreConfig.getIdentifierOfPath(PathToEXE) + "\"). \nPlease select it from the list and click configure.");
                return;
            }

            String batch_libPath = Path.Combine(FilePath, "batch_lib");
            if (Directory.Exists(batch_libPath) && File.Exists(Path.Combine(batch_libPath, "start_keepalive.bat")))
            {
                // load config path string from file (2nd line).
                Int32 counter = 0;
                String line;
                String configPath;

                var file = new StreamReader(Path.Combine(batch_libPath, "start_keepalive.bat"));
                while ((line = file.ReadLine()) != null)
                {
                    if (counter == 1)
                    {
                        break;
                    }
                    counter++;
                }

                file.Close();

                // Config Path
                configPath = line.Substring(5);

                if (File.Exists(configPath))
                {

                    // No Folder, Not Installed
                    textualName = this.frmMainWindowHandle.getNewServerConfigNameFromUser();
                    if(textualName == null){
                        // User Cancelled
                        return;
                    } else {

                        // Add Server config instance to core config list
                        this.CoreConfig.addServerConfig(newID, new skbtServerConfig(configPath));

                        // Add server meta for Application to keep track
                        this.CoreConfig.addServerMeta(newID, new skbtServerMeta(newID, textualName, PathToEXE, configPath, true));

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

            MessageBox.Show("There was no installation found. Please install.");

            // Add config internally
            this.CoreConfig.addServerConfig(newID, new skbtServerConfig());

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
                for (int i = 1; i < Environment.ProcessorCount; i++)
                {
                    aStr += "," + ++i;
                }

            }
            return aStr;
        }

        /*  getSelectedPathIdentifier()
         * 
         * Gets the selected List Box Item and Returns the Associated Identifier (Value)
         */
        public String getSelectedPathIdentifier()
        {
            return this.frmMainWindowHandle.getSelectedPath();
        }


        /*  doConfigure()
         * 
         * Handles configuration button mechanics
         */
        public void ShowConfigure()
        {
            // Configure button was clicked

            // load a new configuration form with the selected config object in list box

            this.frmConfigWindowHandle.DisplayConfigWindow(
                this.CoreConfig.getServerMetaObject(this.getSelectedPathIdentifier()), 
                this.CoreConfig.getServerConfigList()[this.getSelectedPathIdentifier()]
            );
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

            // Copy Zip To Temp
            Assembly asm = Assembly.GetExecutingAssembly();
            Stream s = asm.GetManifestResourceStream("skbtInstaller.Resources.batch_lib_template.zip");

            FileStream fs;
            String tempZip = Path.Combine(Path.GetTempPath(), "batch_lib_template.zip");
            if (File.Exists(tempZip)) { File.Delete(tempZip); }

            fs = File.Create(tempZip);
            int b = s.ReadByte();
            while (b != -1) { fs.WriteByte((byte)b); b = s.ReadByte(); }
            fs.Close();

            String blPath = Path.Combine(serverPath, "batch_lib");

            // Check and/or delete batch_lib
            if (Directory.Exists(blPath))
            {
                Directory.Delete(blPath, true);
            }

            // Extract Zip to Batch Lib Folder
            ZipFile.ExtractToDirectory(tempZip, this.CoreConfig.getServerConfigList()[Identifier].objServerProc.Path);

            // Get all .bat and .cmd files for processing
            ArrayList alFiles = new ArrayList();
            foreach (string FileFilter in new String[] { "*.cmd", "*.bat" })
            {
                // add found file names to array list
                alFiles.AddRange(Directory.GetFiles(blPath, FileFilter, SearchOption.AllDirectories));
            }

            string[] files = (string[])alFiles.ToArray(typeof(string));

            // Rewrite Strings
            for (int i = 0; i < files.Length; i++)
            {
                String file = files[i].ToString();
                File.WriteAllText(
                        file,
                        File.ReadAllText(file)
                            .Replace("{PATH_TO_CONFIG}", newConfigName)
                            .Replace("{AUTHOR}", skbtCoreConfig.strAuthor)
                            .Replace("{VERSION}", skbtCoreConfig.strVersion)
                            .Replace("{KEEPALIVE_TITLE}", skbtCoreConfig.strKeepaliveTitle)
                            .Replace("{KALAUNCHER_TITLE}", skbtCoreConfig.strLauncherTitle)
                            .Replace("{DISPLAY_HEADER}", skbtCoreConfig.strKeepaliveHead)
                    );
			};

            // install complete (isInstalled true)

            // Display config screen

        }
    }

}
