using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace skbtInstaller
{

    /*  class skbtCoreConfig()
     *      
     * Manages All Config Objects for Application
     * 
     */
    public class skbtCoreConfig
    {
        // STRINGS
        public const String strAuthor = "Uniflare (AKA) Checmial Bliss";    // {AUTHOR}
        public const String strVersion = "1.0.0rc1";    // {VERSION}
        public const String strKeepaliveTitle = "Server Keepalive Tools v" + strVersion + " by " + strAuthor;  // {KEEPALIVE_TITLE}
        public const String strLauncherTitle = "Keepalive Launcher v1.1";   // {KALAUNCHER_TITLE}
        public const String strKeepaliveHead = "Server Keepalive " + strVersion + " by " + strAuthor; // {DISPLAY_HEADER}



        // Path to Core Config File (Set in Constructor)
        private String skbtXMLConfigPath;

        // List of Server Config Objects
        private Dictionary<String, skbtServerConfig> DictServerConfig = new Dictionary<String, skbtServerConfig>();

        // List of Server Config MetaDeta
        private Dictionary<String, skbtServerMeta> DictServerMeta = new Dictionary<String, skbtServerMeta>();

        /*  skbtCoreConfig()
         * 
         * Initializes all members and attempts to load required config files
         */
        public skbtCoreConfig()
        {
            // Initialize
            this.skbtXMLConfigPath = Path.Combine(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SKBT_Data"), "skbtConfig.xml");

            // Check if folder exists and if not, create it
            if (!Directory.Exists(Path.GetDirectoryName(this.skbtXMLConfigPath)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(this.skbtXMLConfigPath));
            }

            // Load core config
            loadCoreConfig();
        }

        /*  getServerConfigList()
         * 
         * Return the entire Server Config Object List
         */
        public Dictionary<String, skbtServerConfig> getServerConfigList()
        {
            return this.DictServerConfig;
        }
        
        /// <summary>
        /// Check to see if the specified Server Config has been Installed
        /// </summary>
        /// <param name="id">Unique ID of the server/Arma config</param>
        /// <returns>True if SKBT is isntalled for this instance</returns>
        public Boolean checkSKBTInstalled(String id)
        {
            if (this.DictServerMeta.ContainsKey(id))
            {
                return this.DictServerMeta[id].isInstalled;
            }
            return false;
        }

        /*  loadCoreConfig()
         * 
         * Loads core config (creates server config objects) from XML File
         */
        public void loadCoreConfig()
        {

            // see if config exists
            XmlSerializer serializer = new XmlSerializer(typeof(List<KeyValuePairXMLConfigs<String, List<KeyValuePairXMLParameters<String, String>>>>));

            // Initialize Config List
            var paramList = new List<KeyValuePairXMLConfigs<String, List<KeyValuePairXMLParameters<String, String>>>>();

            // If File Exists
            if (File.Exists(this.skbtXMLConfigPath))
            {
                // If Greater than 0 Bytes
                FileInfo cfgInfo = new FileInfo(this.skbtXMLConfigPath);
                if (cfgInfo.Length > 0)
                {
                    // Grab Settings
                    FileStream ReadFileStream = new FileStream(this.skbtXMLConfigPath, FileMode.Open, FileAccess.Read, FileShare.Read);
                    try
                    {
                        paramList = (List<KeyValuePairXMLConfigs<String, List<KeyValuePairXMLParameters<String, String>>>>)serializer.Deserialize(ReadFileStream);

                        // Iterate each server config item
                        foreach (KeyValuePairXMLConfigs<String, List<KeyValuePairXMLParameters<String, String>>> pair in paramList)
                        {
                            // Get Identifier
                            String identifier = pair.Key;

                            // Make sure we have all parameters
                            if (pair.Value.Count == 4)
                            {
                              //  String configPath = innerConfig

                                String configPath = pair.Value.First(kvp => kvp.Key == "configpath").Value;
                                String exePath = pair.Value.First(kvp => kvp.Key == "exepath").Value;
                                String textName = pair.Value.First(kvp => kvp.Key == "textname").Value;
                                Boolean isInstalled = (pair.Value.First(kvp => kvp.Key == "installed").Value == "true")? true : false;

                                // check we have all settings
                                if (exePath == null || textName == null)
                                {
                                    // Incorrect parameters for this server instance.... erroneous.
                                    continue;
                                }
                                else
                                {
                                    // Add new server config
                                    this.addServerConfig(identifier, new skbtServerConfig(configPath));
                                    this.addServerMeta(identifier, new skbtServerMeta(identifier, textName, exePath, configPath, isInstalled));
                                }
                            }
                            else
                            {
                                // No parameters for this server instance.... erroneous.
                                continue;
                            }
                        }
                        ReadFileStream.Close();
                    }
                    catch
                    {
                        // Catch everything, any errors, blank out the config
                        ReadFileStream.Close();
                        MessageBox.Show("Your Config File seems Corrupted. Creating a Backup and cleaning...");
                        this.cleanXMLConfig();
                    }
                }
            }
            else
            {
                // Make Blank XML if file doesn't exist
                this.cleanXMLConfig();
            }
        }

        /*  cleanXMLConfig()
         * 
         * Simply creates a default empty XML config file
         */
        public void cleanXMLConfig()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<KeyValuePairXMLConfigs<String, List<KeyValuePairXMLParameters<String, String>>>>));
            TextWriter WriteFileStream = new StreamWriter(this.skbtXMLConfigPath);
            serializer.Serialize(WriteFileStream, null);
            WriteFileStream.Close();
        }

        /*  addServerMeta(String Identifier, skbtServerMeta ServerMetaObject)
         * 
         * Adds the ServerMetaObject to internal DictServerMeta with Identifier as Key
         */
        public void addServerMeta(String i, skbtServerMeta s)
        {
            if (!this.DictServerMeta.ContainsKey(i))
            {
                this.DictServerMeta.Add(i, s);
            }
        }

        /*  getServerMetaObject(String Identifer)
         * 
         * Gets the ServerMetaObject from internal DictServerMeta using Identifier as Key
         */
        public skbtServerMeta getServerMetaObject(String i)
        {
            if (this.DictServerMeta.ContainsKey(i))
            {
                return this.DictServerMeta[i];
            }
            else
            {
                return null;
            }
        }

        /*  saveCoreConfig()
         * 
         * Saves core config (serializes Server Config Data) to XML File
         */
        public void saveCoreConfig()
        {
            // Initialize Config List
            var xmlNodeMaster = new List<KeyValuePairXMLConfigs<String, List<KeyValuePairXMLParameters<String, String>>>>();

            XmlSerializer serializer = new XmlSerializer(typeof(List<KeyValuePairXMLConfigs<String, List<KeyValuePairXMLParameters<String, String>>>>));
            
            // Loop each Server Config Item
            foreach (KeyValuePair<String, skbtServerConfig> ConfigItem in DictServerConfig)
            {
                skbtServerConfig ServerConfig = ConfigItem.Value;
                
                // XML Tags from Meta
                String Identifier = ConfigItem.Key;

                // Build XML Node
                var xmlNode = new List<KeyValuePairXMLParameters<String, String>>() {
                    
                    new KeyValuePairXMLParameters<String, String>("configpath", this.DictServerMeta[Identifier].PathToConfig),
                    new KeyValuePairXMLParameters<String, String>("exepath", this.DictServerMeta[Identifier].PathToEXE),
                    new KeyValuePairXMLParameters<String, String>("textname", this.DictServerMeta[Identifier].textualName),
                    new KeyValuePairXMLParameters<String, String>("installed",(this.DictServerMeta[Identifier].isInstalled == true) ? "true" : "false")
                };

                // Add to Master Node for Server Config
                xmlNodeMaster.Add(new KeyValuePairXMLConfigs<String, List<KeyValuePairXMLParameters<String, String>>>(Identifier, xmlNode));
            }

            // Write Config List
            TextWriter WriteFileStream = new StreamWriter(this.skbtXMLConfigPath);
            serializer.Serialize(WriteFileStream, xmlNodeMaster);
            WriteFileStream.Close();
        }

        /*  addServerPath(String Identifier, skbtServerConfig ServerConfigObject)
         * 
         * Adds a new path to be controlled/configured
         * 
         * [Identifier]     Unique ID of the server/Arma config
         * [Path]           Path to Arma Server directory
         */
        public void addServerConfig(String n, skbtServerConfig c)
        {
            this.DictServerConfig.Add(n, c);

        }

        /*  getIdentifierOfPath(String PathToEXE)
         * 
         * returns the Identifier of the Server Config Object that contains PathToEXE
         * otherwise will return null
         * 
         * [PathToEXE] Path to Server EXE (used in erver Config Object Meta)
         */
        public String getIdentifierOfPath(String p)
        {
            foreach (KeyValuePair<String, skbtServerMeta> pair in this.DictServerMeta)
            {
                if (Path.GetDirectoryName(pair.Value.PathToEXE) == Path.GetDirectoryName(p))
                {
                    return pair.Value.textualName;
                }
            }
            return null;
        }

        /*  checkServerPath(String ConfigPath)
         * 
         * Adds a new path to be controlled/configured
         * 
         * [ConfigPath]     Complete path to batch settings file
         */
        public bool ServerPathInUse(String p)
        {
            foreach (KeyValuePair<String, skbtServerMeta> pair in this.DictServerMeta)
            {
                if (Path.GetDirectoryName(pair.Value.PathToEXE) == Path.GetDirectoryName(p))
                {
                    return true;
                }
            }
            return false;
        }

        /*  delServerPath(String Identifier)
         * 
         * Removes a path currently configured
         * 
         * [Identifier]     Unique ID of the server/Arma directory
         */
        public bool delServerPath()
        {
            return true;
        }

        public void setServerConfig(String Identifier, skbtServerConfig c)
        {
            this.DictServerConfig[Identifier] = c;
        }

        public void setServerMeta(String Identifier, skbtServerMeta m)
        {
            this.DictServerMeta[Identifier] = m;
        }
    }
}
