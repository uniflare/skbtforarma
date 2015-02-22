using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace skbtInstaller
{
    /*  class frmMainWindow : Form
     * 
     * Controls all User Interaction Components
     * Handles Dialogs and User Input
     * Uses ServerControl Object manipulate user actions
     */
    public partial class frmMainWindow : Form
    {
        // Control Object
        public skbtServerControl sc;

        /*  frmMainWindow()
         * 
         * Form Constructor, Initializes Components & Server Control Object
         */
        public frmMainWindow()
        {
            // init Window
            InitializeComponent();

            // Initialize Members
            sc = new skbtServerControl(this);

        }

        /*  btnNewServer_Click(object sender, EventArgs e)
         * 
         * USER ACTION: Add New Server Config Path (Installed or Uninstalled)
         */
        private void btnNewServer_Click(object sender, EventArgs e)
        {
            // USer Backend Control Object for User Interaction Management
            this.sc.AddNewServerConfig();
        }

        private void btnInstall_Click(object sender, EventArgs e)
        {
            /* On Install Click ->
             *      // Show Config Save Dialog (For new Config Name/Location)
             *      // Show Configuration Screen (Complete Window), Same as Clicking Configure
             * 
                    // UnZip Batch Lib Resource Folder
                    // Copy All Files to Batch Lib
                    // Modify Each File to the new Settings Location
              
             */

            // Get a new config name
            this.sc.InstallBatchLib(this.sc.getSelectedPathIdentifier(), this.getNewFilePathFromUser());
        }

        private void btnUninstall_Click(object sender, EventArgs e)
        {
        }

        /*  btnConfig_Click(object sender, EventArgs e)
         * 
         * Shows configure window for selected config object in list box
         */
        private void btnConfig_Click(object sender, EventArgs e)
        {
            this.sc.ShowConfigure();
        }

        /*  getNewServerEXEPathFromUser()
         * 
         * Creates a new File Select Dialog (Looking for Arma Server Executable)
         * 
         * Returns Path Selected
         */
        public String getNewServerEXEPathFromUser()
        {
            // Launch Folder Browser Dialog
            ofdFindFile.CheckFileExists = true;
            ofdFindFile.Filter = "Arma Server Executable|*.exe";
            DialogResult result = ofdFindFile.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Return Full Path to File

                return ofdFindFile.FileName;
            }
            else
            {
                // Canceled
                return null;
            }
        }

        /*  getNewServerConfigNameFromUser()
         * 
         * Show Input Text Dialog to get a new String from User
         * to use as the Server Config Textual Name
         * 
         * Returns User String or null on cancel
         */
        public String getNewServerConfigNameFromUser()
        {
            // Input Validation delegate
            InputBoxValidation validation = delegate(String val)
            {
                if (val == "")
                    return "Value cannot be empty.";
                if (!(new Regex(@"^[a-zA-Z0-9_ -]+$")).IsMatch(val))
                    return "Must use standard alphanumeric characters";
                return "";
            };

            // Default Value
            string value = "My New Server Config";

            // Try to show dialog
            if (InputBox.Show("Enter a name to represent your new server config", "Server Config Name::", ref value, validation) == DialogResult.OK)
            {

                // Return User Input String
                return value;
            }
            else
            {
                // User Canceled
                return null;
            }
        }

        /*  getNewFilePathFromUser()
         * 
         * Presents a Save File Dialog to choose a location 
         * to save a new batch_settings file for this SKBT Config
         * 
         * Returns Full Path Chosen or null on cancel
         */
        public String getNewFilePathFromUser()
        {
            // Set Dialog Properties
            sfdNewConfig.Title = "Select new settings location";
            sfdNewConfig.Filter = "Batch Tools Settings |*.cmd";
            sfdNewConfig.DefaultExt = "cmd";
            sfdNewConfig.CheckFileExists = false;
            sfdNewConfig.CheckPathExists = true;
            sfdNewConfig.CreatePrompt = false;
            sfdNewConfig.AddExtension = true;

            // Show Dialog
            DialogResult result = sfdNewConfig.ShowDialog();

            char[] blPath = sfdNewConfig.FileName.ToCharArray();
            String blPath2 = "";
            foreach (var item in blPath)
            {
                if (Path.GetInvalidPathChars().Contains(item))
                {
                    MessageBox.Show("INVALID BYTE DETECTED:" + item);
                }
                else
                {
                    blPath2 += item.ToString();
                }
            }


            // Check if user Canceled
            if (result == DialogResult.OK)
            {
                // Return Chosen Path/Filename
                return sfdNewConfig.FileName;
            }
            else
            {
                // User Cancelled
                return null;
            }
        }

        /*  setServerPathDatasource(List<KeyValuePair<String, String>> DataSource)
         * 
         * Sets the current datasource for the ListBox
         * 
         * [Datasource] List of KeyValuePairs to display in ListBox
         */
        public void setServerPathDatasource(List<KeyValuePair<String, String>> source)
        {
            // Need to keep setting this when we change Datasource
            this.setListBoxMembers("Key", "Value");

            // Set the Datasource directly
            this.cBoxArmaPath.DataSource = new BindingSource(source, null);
        }

        /*  setSelectedIndexOnList(string Identifier)
         * 
         * Sets the selected ListBox item to the item with the ValueMember "Identifier"
         * 
         * [Identifier] Unique String ID of ListBox Item (ValueMember)
         */
        public void setSelectedIndexOnList(string Identifier)
        {
            this.cBoxArmaPath.SelectedValue = Identifier;
        }

        /*  getSelectedPath()
         * 
         * Grabs the MemberValue of the selected listbox item
         * 
         * Returns String or null if the SelectedValue is null
         */
        public String getSelectedPath()
        {
            // Check if Value is null
            if (this.cBoxArmaPath.SelectedValue == null)
            {
                // return null
                return null;
            }
            else
            {  
                // Return Value as String
                return this.cBoxArmaPath.SelectedValue.ToString();
            }
        }

        /*  clearPathBox()
         * 
         * Clears the ListBox entirely (empties)
         */
        public void clearPathBox()
        {
            // We need to check if we are using a datasource
            if (this.cBoxArmaPath.DataSource == null)
            {
                // no datasource, clear the items directly
                this.cBoxArmaPath.Items.Clear();
            }
            else
            {
                // Datasource used, clear the datasource
                this.cBoxArmaPath.DataSource = null;
            }
        }

        /*  setListBoxMembers(String Key, String Value)
         * 
         * Sets the ValueMember and DisplayMember Properties of the ListBox
         * so we can directly use KeyValuePair objects
         */
        public void setListBoxMembers(String Key, String Value)
        {
            this.cBoxArmaPath.ValueMember = Key;
            this.cBoxArmaPath.DisplayMember = Value;
        }

        /* disableUninstall()
         * 
         * Disables User Interaction of the Uninstall Button
         */
        public void disableUninstall()
        {
            btnUninstall.Enabled = false;
        }

        /* enableUninstall()
         * 
         * Enables User Interaction of the Uninstall Button
         */
        public void enableUninstall()
        {
            btnUninstall.Enabled = true;
        }

        /* disableConfigure()
         * 
         * Disables User Interaction of the Configure Button
         */
        public void disableConfigure()
        {
            this.btnConfig.Enabled = false;
        }

        /* enableConfigure()
         * 
         * Enables User Interaction of the Configure Button
         */
        public void enableConfigure()
        {
            this.btnConfig.Enabled = true;
        }

        /* disableInstall()
         * 
         * Disables User Interaction of the Install Button
         */
        public void disableInstall()
        {
            this.btnInstall.Enabled = false;
        }

        /* enableInstall()
         * 
         * Enables User Interaction of the Install Button
         */
        public void enableInstall()
        {
            this.btnInstall.Enabled = true;
        }

        /*  cBoxArmaPath_SelectedIndexChanged(object sender, EventArgs e)
         * 
         * Triggers button refresh
         */
        private void cBoxArmaPath_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.sc != null)
            {
                this.sc.refreshButtons();
            }
            else
            {
                // disable all
                this.disableConfigure();
                this.disableUninstall();
                this.disableInstall();
            }
        }
    }
}