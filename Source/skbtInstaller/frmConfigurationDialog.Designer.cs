namespace skbtInstaller
{
    partial class frmConfigWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnCancelConfig = new System.Windows.Forms.Button();
            this.btnSaveconfig = new System.Windows.Forms.Button();
            this.btnTabSelectServer = new System.Windows.Forms.Button();
            this.btnTabSelectDatabase = new System.Windows.Forms.Button();
            this.btnTabSelectBEC = new System.Windows.Forms.Button();
            this.btnTabSelectHC = new System.Windows.Forms.Button();
            this.btnTabSelectTS = new System.Windows.Forms.Button();
            this.btnTabSelectASM = new System.Windows.Forms.Button();
            this.btnFortxtArmaExePath = new System.Windows.Forms.Button();
            this.btnFortxtBatchSettingsPath = new System.Windows.Forms.Button();
            this.lblMainConfig = new System.Windows.Forms.Label();
            this.lblMetaConfigName = new System.Windows.Forms.Label();
            this.lblMetaExePath = new System.Windows.Forms.Label();
            this.lblMetaBatchSettingsPath = new System.Windows.Forms.Label();
            this.txtConfigName = new System.Windows.Forms.TextBox();
            this.txtArmaExePath = new System.Windows.Forms.TextBox();
            this.txtBatchSettingsPath = new System.Windows.Forms.TextBox();
            this.folderBrowseDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnTabSelectCustom = new System.Windows.Forms.Button();
            this.pbActive = new System.Windows.Forms.PictureBox();
            this.pbConfigServer = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mStripConfig = new System.Windows.Forms.MenuStrip();
            this.tsmItemConfigControl = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmItemConfigControlStart = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConfigControlStop = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmItemConfigControlRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConfigKeepalive = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConfigKeepaliveStart = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConfigKeepaliveStop = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConfigKeepaliveLog = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConfigKeepaliveOpenLib = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConfigKeepaliveOpenSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConfigKeepaliveClean = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConfigAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.viewReadmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlMainConfig = new skbtInstaller.TablessControl();
            this.tabPageProcessServer = new System.Windows.Forms.TabPage();
            this.grpConfigServerBackup = new System.Windows.Forms.GroupBox();
            this.chkUseZipLogs = new System.Windows.Forms.CheckBox();
            this.btnFortxtPathToBackupLog = new System.Windows.Forms.Button();
            this.lblServerPathToLogBackup = new System.Windows.Forms.Label();
            this.txtPathToBackupLog = new System.Windows.Forms.TextBox();
            this.btnFortxtPathToServerLog = new System.Windows.Forms.Button();
            this.lblServerPathToLog = new System.Windows.Forms.Label();
            this.txtPathToServerLog = new System.Windows.Forms.TextBox();
            this.flpServer = new System.Windows.Forms.FlowLayoutPanel();
            this.grpKeepaliveOptions = new System.Windows.Forms.GroupBox();
            this.numStartTimeout = new System.Windows.Forms.NumericUpDown();
            this.numManualTimeout = new System.Windows.Forms.NumericUpDown();
            this.numAutoTimeout = new System.Windows.Forms.NumericUpDown();
            this.numAutoDelay = new System.Windows.Forms.NumericUpDown();
            this.cBoxDebugLevel = new System.Windows.Forms.ComboBox();
            this.lblStartTimeout = new System.Windows.Forms.Label();
            this.chkCleanWERs = new System.Windows.Forms.CheckBox();
            this.lblManualTimeout = new System.Windows.Forms.Label();
            this.lblAutoTimeout = new System.Windows.Forms.Label();
            this.lblAutoDelay = new System.Windows.Forms.Label();
            this.lblDebugLevel = new System.Windows.Forms.Label();
            this.grpConfigServerLaunch = new System.Windows.Forms.GroupBox();
            this.chkServerBindToIP = new System.Windows.Forms.CheckBox();
            this.numServerIP4 = new System.Windows.Forms.NumericUpDown();
            this.numServerIP3 = new System.Windows.Forms.NumericUpDown();
            this.numServerIP2 = new System.Windows.Forms.NumericUpDown();
            this.numServerIP1 = new System.Windows.Forms.NumericUpDown();
            this.lvlServerIP = new System.Windows.Forms.Label();
            this.numServerPort = new System.Windows.Forms.NumericUpDown();
            this.txtProfileName = new System.Windows.Forms.TextBox();
            this.lblServerProfileName = new System.Windows.Forms.Label();
            this.btnFortxtPathToProfile = new System.Windows.Forms.Button();
            this.lblPathToProfile = new System.Windows.Forms.Label();
            this.txtPathToProfile = new System.Windows.Forms.TextBox();
            this.btnFortxtPathToBasicCFG = new System.Windows.Forms.Button();
            this.lblServerPathToBasic = new System.Windows.Forms.Label();
            this.txtPathToBasicCFG = new System.Windows.Forms.TextBox();
            this.btnFortxtPathToConfigCFG = new System.Windows.Forms.Button();
            this.lblServerPathToConfig = new System.Windows.Forms.Label();
            this.txtPathToConfigCFG = new System.Windows.Forms.TextBox();
            this.txtServerModline = new System.Windows.Forms.TextBox();
            this.lblServerModline = new System.Windows.Forms.Label();
            this.txtServerCommand = new System.Windows.Forms.TextBox();
            this.lblServerCommand = new System.Windows.Forms.Label();
            this.lblServerPort = new System.Windows.Forms.Label();
            this.lblServerAffinity = new System.Windows.Forms.Label();
            this.lblerverPriority = new System.Windows.Forms.Label();
            this.cBoxPriorityServer = new System.Windows.Forms.ComboBox();
            this.btnProcessKeepaliveServer = new System.Windows.Forms.Button();
            this.btnFortxtPathToEXEServer = new System.Windows.Forms.Button();
            this.lblServerPathToEXE = new System.Windows.Forms.Label();
            this.txtPathToEXEServer = new System.Windows.Forms.TextBox();
            this.tabPageProcessDatabase = new System.Windows.Forms.TabPage();
            this.grpConfigDatabaseBackup = new System.Windows.Forms.GroupBox();
            this.numBackupInterval = new System.Windows.Forms.NumericUpDown();
            this.lblDatabaseBackupInterval = new System.Windows.Forms.Label();
            this.chkUseZipBackups = new System.Windows.Forms.CheckBox();
            this.btnFortxtPathToBackupFolder = new System.Windows.Forms.Button();
            this.lblDatabaseBackupFolder = new System.Windows.Forms.Label();
            this.txtPathToBackupFolder = new System.Windows.Forms.TextBox();
            this.btnFortxtPathToDBFile = new System.Windows.Forms.Button();
            this.lblDatabaseDumpFile = new System.Windows.Forms.Label();
            this.txtPathToDBFile = new System.Windows.Forms.TextBox();
            this.flpDatabase = new System.Windows.Forms.FlowLayoutPanel();
            this.lvlDatabaseAffinity = new System.Windows.Forms.Label();
            this.lblDatabasePriority = new System.Windows.Forms.Label();
            this.cBoxPriorityDatabase = new System.Windows.Forms.ComboBox();
            this.btnProcessKeepaliveDatabase = new System.Windows.Forms.Button();
            this.btnFortxtPathToEXEDB = new System.Windows.Forms.Button();
            this.lblDatabasePathToExe = new System.Windows.Forms.Label();
            this.txtPathToEXEDB = new System.Windows.Forms.TextBox();
            this.tabPageProcessBEC = new System.Windows.Forms.TabPage();
            this.grpConfigBECBackup = new System.Windows.Forms.GroupBox();
            this.chkBecUseDsc = new System.Windows.Forms.CheckBox();
            this.txtPathToBattleye = new System.Windows.Forms.TextBox();
            this.btnFortxtPathToBattleye = new System.Windows.Forms.Button();
            this.lblBECBEPath = new System.Windows.Forms.Label();
            this.flpBEC = new System.Windows.Forms.FlowLayoutPanel();
            this.lblBECAffinity = new System.Windows.Forms.Label();
            this.lblBECPriority = new System.Windows.Forms.Label();
            this.cBoxPriorityBEC = new System.Windows.Forms.ComboBox();
            this.btnProcessKeepaliveBEC = new System.Windows.Forms.Button();
            this.btnFortxtPathToEXEBEC = new System.Windows.Forms.Button();
            this.lblBECPathToExe = new System.Windows.Forms.Label();
            this.txtPathToEXEBEC = new System.Windows.Forms.TextBox();
            this.tabPageProcessHC = new System.Windows.Forms.TabPage();
            this.grpConfigHCLaunch = new System.Windows.Forms.GroupBox();
            this.lblHCLaunchArgs = new System.Windows.Forms.Label();
            this.txtHeadlessClientLaunchArgs = new System.Windows.Forms.TextBox();
            this.flpHeadlessClient = new System.Windows.Forms.FlowLayoutPanel();
            this.lblHCAffinity = new System.Windows.Forms.Label();
            this.lblHCPriority = new System.Windows.Forms.Label();
            this.cBoxPriorityHeadlessClient = new System.Windows.Forms.ComboBox();
            this.btnProcessKeepaliveHC = new System.Windows.Forms.Button();
            this.btnFortxtPathToEXEHC = new System.Windows.Forms.Button();
            this.lblHCPathToExe = new System.Windows.Forms.Label();
            this.txtPathToEXEHC = new System.Windows.Forms.TextBox();
            this.tabPageProcessTS = new System.Windows.Forms.TabPage();
            this.grpconfigTeamspeakLaunch = new System.Windows.Forms.GroupBox();
            this.numTeamspeakPortNumber = new System.Windows.Forms.NumericUpDown();
            this.lblTSPort = new System.Windows.Forms.Label();
            this.flpTeamspeak = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTSAffinity = new System.Windows.Forms.Label();
            this.lblTSPriority = new System.Windows.Forms.Label();
            this.cBoxPriorityTeamspeak = new System.Windows.Forms.ComboBox();
            this.btnProcessKeepaliveTS = new System.Windows.Forms.Button();
            this.btnFortxtPathToEXETS = new System.Windows.Forms.Button();
            this.lblTSPathToExe = new System.Windows.Forms.Label();
            this.txtPathToEXETS = new System.Windows.Forms.TextBox();
            this.tabPageProcessASM = new System.Windows.Forms.TabPage();
            this.grpConfigASMLaunch = new System.Windows.Forms.GroupBox();
            this.numASMLogInterval = new System.Windows.Forms.NumericUpDown();
            this.btnFortxtASMLogName = new System.Windows.Forms.Button();
            this.lblASMLoggingInterval = new System.Windows.Forms.Label();
            this.txtASMLogName = new System.Windows.Forms.TextBox();
            this.lblASMLogName = new System.Windows.Forms.Label();
            this.flpASM = new System.Windows.Forms.FlowLayoutPanel();
            this.lblASMAffinity = new System.Windows.Forms.Label();
            this.lblASMPriority = new System.Windows.Forms.Label();
            this.cBoxPriorityASM = new System.Windows.Forms.ComboBox();
            this.btnProcessKeepaliveASM = new System.Windows.Forms.Button();
            this.btnFortxtPathToEXEASM = new System.Windows.Forms.Button();
            this.lblASMPathToExe = new System.Windows.Forms.Label();
            this.txtPathToEXEASM = new System.Windows.Forms.TextBox();
            this.tabPageProcessCustom = new System.Windows.Forms.TabPage();
            this.btnCustomProcessDelete = new System.Windows.Forms.Button();
            this.btnCustomProcessAdd = new System.Windows.Forms.Button();
            this.cBoxCustomProcessSelector = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flpCustom = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCustomProcessLaunchParams = new System.Windows.Forms.Label();
            this.txtCustomProcessLaunchParams = new System.Windows.Forms.TextBox();
            this.lblCustomProcessName = new System.Windows.Forms.Label();
            this.txtCustomProcessName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cBoxPriorityCustom = new System.Windows.Forms.ComboBox();
            this.btnProcessKeepaliveCustom = new System.Windows.Forms.Button();
            this.btnCustomProcessBrowseEXE = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPathToEXECustom = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConfigServer)).BeginInit();
            this.panel1.SuspendLayout();
            this.mStripConfig.SuspendLayout();
            this.tabControlMainConfig.SuspendLayout();
            this.tabPageProcessServer.SuspendLayout();
            this.grpConfigServerBackup.SuspendLayout();
            this.grpKeepaliveOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStartTimeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numManualTimeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAutoTimeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAutoDelay)).BeginInit();
            this.grpConfigServerLaunch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numServerIP4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numServerIP3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numServerIP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numServerIP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numServerPort)).BeginInit();
            this.tabPageProcessDatabase.SuspendLayout();
            this.grpConfigDatabaseBackup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBackupInterval)).BeginInit();
            this.tabPageProcessBEC.SuspendLayout();
            this.grpConfigBECBackup.SuspendLayout();
            this.tabPageProcessHC.SuspendLayout();
            this.grpConfigHCLaunch.SuspendLayout();
            this.tabPageProcessTS.SuspendLayout();
            this.grpconfigTeamspeakLaunch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTeamspeakPortNumber)).BeginInit();
            this.tabPageProcessASM.SuspendLayout();
            this.grpConfigASMLaunch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numASMLogInterval)).BeginInit();
            this.tabPageProcessCustom.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelConfig
            // 
            this.btnCancelConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnCancelConfig.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelConfig.FlatAppearance.BorderSize = 2;
            this.btnCancelConfig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancelConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancelConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelConfig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelConfig.Location = new System.Drawing.Point(468, 488);
            this.btnCancelConfig.Name = "btnCancelConfig";
            this.btnCancelConfig.Size = new System.Drawing.Size(150, 75);
            this.btnCancelConfig.TabIndex = 0;
            this.btnCancelConfig.Text = "Cancel";
            this.btnCancelConfig.UseVisualStyleBackColor = false;
            this.btnCancelConfig.Click += new System.EventHandler(this.actionCancelConfig);
            // 
            // btnSaveconfig
            // 
            this.btnSaveconfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveconfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnSaveconfig.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnSaveconfig.FlatAppearance.BorderSize = 2;
            this.btnSaveconfig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSaveconfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSaveconfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveconfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveconfig.ForeColor = System.Drawing.Color.Green;
            this.btnSaveconfig.Location = new System.Drawing.Point(12, 488);
            this.btnSaveconfig.Name = "btnSaveconfig";
            this.btnSaveconfig.Size = new System.Drawing.Size(150, 75);
            this.btnSaveconfig.TabIndex = 3;
            this.btnSaveconfig.Text = "Save";
            this.btnSaveconfig.UseVisualStyleBackColor = false;
            this.btnSaveconfig.Click += new System.EventHandler(this.actionSaveConfig);
            // 
            // btnTabSelectServer
            // 
            this.btnTabSelectServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTabSelectServer.BackColor = System.Drawing.Color.Gray;
            this.btnTabSelectServer.FlatAppearance.BorderSize = 0;
            this.btnTabSelectServer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnTabSelectServer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTabSelectServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabSelectServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTabSelectServer.ForeColor = System.Drawing.Color.Black;
            this.btnTabSelectServer.Location = new System.Drawing.Point(16, 162);
            this.btnTabSelectServer.Margin = new System.Windows.Forms.Padding(0);
            this.btnTabSelectServer.Name = "btnTabSelectServer";
            this.btnTabSelectServer.Size = new System.Drawing.Size(102, 22);
            this.btnTabSelectServer.TabIndex = 27;
            this.btnTabSelectServer.Text = "Arma Server";
            this.btnTabSelectServer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolTip1.SetToolTip(this.btnTabSelectServer, "Arma Server Settings Tab");
            this.btnTabSelectServer.UseVisualStyleBackColor = false;
            this.btnTabSelectServer.Click += new System.EventHandler(this.actionSelectTabButton);
            // 
            // btnTabSelectDatabase
            // 
            this.btnTabSelectDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTabSelectDatabase.BackColor = System.Drawing.Color.Gray;
            this.btnTabSelectDatabase.FlatAppearance.BorderSize = 0;
            this.btnTabSelectDatabase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnTabSelectDatabase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTabSelectDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabSelectDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnTabSelectDatabase.ForeColor = System.Drawing.Color.Black;
            this.btnTabSelectDatabase.Location = new System.Drawing.Point(121, 162);
            this.btnTabSelectDatabase.Margin = new System.Windows.Forms.Padding(0);
            this.btnTabSelectDatabase.Name = "btnTabSelectDatabase";
            this.btnTabSelectDatabase.Size = new System.Drawing.Size(84, 22);
            this.btnTabSelectDatabase.TabIndex = 28;
            this.btnTabSelectDatabase.Text = "Database";
            this.btnTabSelectDatabase.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolTip1.SetToolTip(this.btnTabSelectDatabase, "Database Settings Tab");
            this.btnTabSelectDatabase.UseVisualStyleBackColor = false;
            this.btnTabSelectDatabase.Click += new System.EventHandler(this.actionSelectTabButton);
            // 
            // btnTabSelectBEC
            // 
            this.btnTabSelectBEC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTabSelectBEC.BackColor = System.Drawing.Color.Gray;
            this.btnTabSelectBEC.FlatAppearance.BorderSize = 0;
            this.btnTabSelectBEC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnTabSelectBEC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTabSelectBEC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabSelectBEC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnTabSelectBEC.ForeColor = System.Drawing.Color.Black;
            this.btnTabSelectBEC.Location = new System.Drawing.Point(208, 162);
            this.btnTabSelectBEC.Margin = new System.Windows.Forms.Padding(0);
            this.btnTabSelectBEC.Name = "btnTabSelectBEC";
            this.btnTabSelectBEC.Size = new System.Drawing.Size(46, 22);
            this.btnTabSelectBEC.TabIndex = 29;
            this.btnTabSelectBEC.Text = "BEC";
            this.btnTabSelectBEC.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolTip1.SetToolTip(this.btnTabSelectBEC, "BEC Settings Tab");
            this.btnTabSelectBEC.UseVisualStyleBackColor = false;
            this.btnTabSelectBEC.Click += new System.EventHandler(this.actionSelectTabButton);
            // 
            // btnTabSelectHC
            // 
            this.btnTabSelectHC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTabSelectHC.BackColor = System.Drawing.Color.Gray;
            this.btnTabSelectHC.FlatAppearance.BorderSize = 0;
            this.btnTabSelectHC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnTabSelectHC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTabSelectHC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabSelectHC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnTabSelectHC.ForeColor = System.Drawing.Color.Black;
            this.btnTabSelectHC.Location = new System.Drawing.Point(257, 162);
            this.btnTabSelectHC.Margin = new System.Windows.Forms.Padding(0);
            this.btnTabSelectHC.Name = "btnTabSelectHC";
            this.btnTabSelectHC.Size = new System.Drawing.Size(126, 22);
            this.btnTabSelectHC.TabIndex = 30;
            this.btnTabSelectHC.Text = "Headless Client";
            this.btnTabSelectHC.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolTip1.SetToolTip(this.btnTabSelectHC, "Headless Client Settings Tab");
            this.btnTabSelectHC.UseVisualStyleBackColor = false;
            this.btnTabSelectHC.Click += new System.EventHandler(this.actionSelectTabButton);
            // 
            // btnTabSelectTS
            // 
            this.btnTabSelectTS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTabSelectTS.BackColor = System.Drawing.Color.Gray;
            this.btnTabSelectTS.FlatAppearance.BorderSize = 0;
            this.btnTabSelectTS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnTabSelectTS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTabSelectTS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabSelectTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnTabSelectTS.ForeColor = System.Drawing.Color.Black;
            this.btnTabSelectTS.Location = new System.Drawing.Point(386, 162);
            this.btnTabSelectTS.Margin = new System.Windows.Forms.Padding(0);
            this.btnTabSelectTS.Name = "btnTabSelectTS";
            this.btnTabSelectTS.Size = new System.Drawing.Size(102, 22);
            this.btnTabSelectTS.TabIndex = 31;
            this.btnTabSelectTS.Text = "Teamspeak";
            this.btnTabSelectTS.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolTip1.SetToolTip(this.btnTabSelectTS, "Teamspeak Settings Tab");
            this.btnTabSelectTS.UseVisualStyleBackColor = false;
            this.btnTabSelectTS.Click += new System.EventHandler(this.actionSelectTabButton);
            // 
            // btnTabSelectASM
            // 
            this.btnTabSelectASM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTabSelectASM.BackColor = System.Drawing.Color.Gray;
            this.btnTabSelectASM.FlatAppearance.BorderSize = 0;
            this.btnTabSelectASM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnTabSelectASM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTabSelectASM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabSelectASM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnTabSelectASM.ForeColor = System.Drawing.Color.Black;
            this.btnTabSelectASM.Location = new System.Drawing.Point(491, 162);
            this.btnTabSelectASM.Margin = new System.Windows.Forms.Padding(0);
            this.btnTabSelectASM.Name = "btnTabSelectASM";
            this.btnTabSelectASM.Size = new System.Drawing.Size(49, 22);
            this.btnTabSelectASM.TabIndex = 32;
            this.btnTabSelectASM.Text = "ASM";
            this.btnTabSelectASM.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolTip1.SetToolTip(this.btnTabSelectASM, "Arma Server Monitor Settings Tab");
            this.btnTabSelectASM.UseVisualStyleBackColor = false;
            this.btnTabSelectASM.Click += new System.EventHandler(this.actionSelectTabButton);
            // 
            // btnFortxtArmaExePath
            // 
            this.btnFortxtArmaExePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFortxtArmaExePath.Enabled = false;
            this.btnFortxtArmaExePath.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnFortxtArmaExePath.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnFortxtArmaExePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFortxtArmaExePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFortxtArmaExePath.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnFortxtArmaExePath.Location = new System.Drawing.Point(538, 91);
            this.btnFortxtArmaExePath.Name = "btnFortxtArmaExePath";
            this.btnFortxtArmaExePath.Size = new System.Drawing.Size(74, 26);
            this.btnFortxtArmaExePath.TabIndex = 9;
            this.btnFortxtArmaExePath.Text = "Browse";
            this.btnFortxtArmaExePath.UseVisualStyleBackColor = true;
            this.btnFortxtArmaExePath.Click += new System.EventHandler(this.actionBrowseButtonForFilePath);
            // 
            // btnFortxtBatchSettingsPath
            // 
            this.btnFortxtBatchSettingsPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFortxtBatchSettingsPath.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnFortxtBatchSettingsPath.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnFortxtBatchSettingsPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFortxtBatchSettingsPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFortxtBatchSettingsPath.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnFortxtBatchSettingsPath.Location = new System.Drawing.Point(538, 125);
            this.btnFortxtBatchSettingsPath.Name = "btnFortxtBatchSettingsPath";
            this.btnFortxtBatchSettingsPath.Size = new System.Drawing.Size(74, 26);
            this.btnFortxtBatchSettingsPath.TabIndex = 10;
            this.btnFortxtBatchSettingsPath.Text = "Browse";
            this.btnFortxtBatchSettingsPath.UseVisualStyleBackColor = true;
            this.btnFortxtBatchSettingsPath.Click += new System.EventHandler(this.actionBrowseButtonForFilePath);
            // 
            // lblMainConfig
            // 
            this.lblMainConfig.AutoSize = true;
            this.lblMainConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainConfig.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMainConfig.Location = new System.Drawing.Point(12, 9);
            this.lblMainConfig.Name = "lblMainConfig";
            this.lblMainConfig.Size = new System.Drawing.Size(272, 24);
            this.lblMainConfig.TabIndex = 1;
            this.lblMainConfig.Text = "SKBT Configuration Settings";
            // 
            // lblMetaConfigName
            // 
            this.lblMetaConfigName.AutoSize = true;
            this.lblMetaConfigName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetaConfigName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMetaConfigName.Location = new System.Drawing.Point(12, 63);
            this.lblMetaConfigName.Name = "lblMetaConfigName";
            this.lblMetaConfigName.Size = new System.Drawing.Size(168, 20);
            this.lblMetaConfigName.TabIndex = 4;
            this.lblMetaConfigName.Text = "Name of Configuration";
            this.toolTip1.SetToolTip(this.lblMetaConfigName, "Just a simple name used to display this config in the SKBT Main Window.");
            // 
            // lblMetaExePath
            // 
            this.lblMetaExePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMetaExePath.AutoSize = true;
            this.lblMetaExePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetaExePath.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMetaExePath.Location = new System.Drawing.Point(12, 97);
            this.lblMetaExePath.Name = "lblMetaExePath";
            this.lblMetaExePath.Size = new System.Drawing.Size(167, 20);
            this.lblMetaExePath.TabIndex = 5;
            this.lblMetaExePath.Text = "Arma Executable Path";
            this.toolTip1.SetToolTip(this.lblMetaExePath, "Unchangeable. Set when first creating the config. This config is tied to this arm" +
        "a EXE.");
            // 
            // lblMetaBatchSettingsPath
            // 
            this.lblMetaBatchSettingsPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMetaBatchSettingsPath.AutoSize = true;
            this.lblMetaBatchSettingsPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetaBatchSettingsPath.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMetaBatchSettingsPath.Location = new System.Drawing.Point(12, 131);
            this.lblMetaBatchSettingsPath.Name = "lblMetaBatchSettingsPath";
            this.lblMetaBatchSettingsPath.Size = new System.Drawing.Size(151, 20);
            this.lblMetaBatchSettingsPath.TabIndex = 7;
            this.lblMetaBatchSettingsPath.Text = "Batch Settings Path";
            this.toolTip1.SetToolTip(this.lblMetaBatchSettingsPath, "Path to this config batch_settings file. Can be anywhere and named anything.");
            // 
            // txtConfigName
            // 
            this.txtConfigName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfigName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtConfigName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfigName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfigName.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtConfigName.Location = new System.Drawing.Point(186, 57);
            this.txtConfigName.Name = "txtConfigName";
            this.txtConfigName.Size = new System.Drawing.Size(426, 26);
            this.txtConfigName.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtConfigName, "Just a simple name used to display this config in the SKBT Main Window.");
            this.txtConfigName.Leave += new System.EventHandler(this.actionConfigNameTouched);
            // 
            // txtArmaExePath
            // 
            this.txtArmaExePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArmaExePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtArmaExePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArmaExePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArmaExePath.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtArmaExePath.Location = new System.Drawing.Point(186, 91);
            this.txtArmaExePath.Name = "txtArmaExePath";
            this.txtArmaExePath.ReadOnly = true;
            this.txtArmaExePath.Size = new System.Drawing.Size(346, 26);
            this.txtArmaExePath.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txtArmaExePath, "Unchangeable. Set when first creating the config. This config is tied to this arm" +
        "a EXE.");
            // 
            // txtBatchSettingsPath
            // 
            this.txtBatchSettingsPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBatchSettingsPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBatchSettingsPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBatchSettingsPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatchSettingsPath.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBatchSettingsPath.Location = new System.Drawing.Point(186, 125);
            this.txtBatchSettingsPath.Name = "txtBatchSettingsPath";
            this.txtBatchSettingsPath.ReadOnly = true;
            this.txtBatchSettingsPath.Size = new System.Drawing.Size(346, 26);
            this.txtBatchSettingsPath.TabIndex = 8;
            this.toolTip1.SetToolTip(this.txtBatchSettingsPath, "Path to this config batch_settings file. Can be anywhere and named anything.");
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // btnTabSelectCustom
            // 
            this.btnTabSelectCustom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTabSelectCustom.BackColor = System.Drawing.Color.Gray;
            this.btnTabSelectCustom.FlatAppearance.BorderSize = 0;
            this.btnTabSelectCustom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnTabSelectCustom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTabSelectCustom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabSelectCustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnTabSelectCustom.ForeColor = System.Drawing.Color.Black;
            this.btnTabSelectCustom.Location = new System.Drawing.Point(543, 162);
            this.btnTabSelectCustom.Margin = new System.Windows.Forms.Padding(0);
            this.btnTabSelectCustom.Name = "btnTabSelectCustom";
            this.btnTabSelectCustom.Size = new System.Drawing.Size(69, 22);
            this.btnTabSelectCustom.TabIndex = 33;
            this.btnTabSelectCustom.Text = "Custom";
            this.btnTabSelectCustom.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolTip1.SetToolTip(this.btnTabSelectCustom, "Custom Process Manager Tab");
            this.btnTabSelectCustom.UseVisualStyleBackColor = false;
            this.btnTabSelectCustom.Click += new System.EventHandler(this.actionSelectTabButton);
            // 
            // pbActive
            // 
            this.pbActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pbActive.Location = new System.Drawing.Point(597, 9);
            this.pbActive.Name = "pbActive";
            this.pbActive.Size = new System.Drawing.Size(15, 15);
            this.pbActive.TabIndex = 34;
            this.pbActive.TabStop = false;
            this.toolTip1.SetToolTip(this.pbActive, "Keepalive Heartbeat Not Detected.");
            // 
            // pbConfigServer
            // 
            this.pbConfigServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pbConfigServer.Location = new System.Drawing.Point(597, 30);
            this.pbConfigServer.Name = "pbConfigServer";
            this.pbConfigServer.Size = new System.Drawing.Size(15, 15);
            this.pbConfigServer.TabIndex = 36;
            this.pbConfigServer.TabStop = false;
            this.toolTip1.SetToolTip(this.pbConfigServer, "Server Process Activity Not Detected");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mStripConfig);
            this.panel1.Location = new System.Drawing.Point(340, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 24);
            this.panel1.TabIndex = 35;
            // 
            // mStripConfig
            // 
            this.mStripConfig.BackColor = System.Drawing.Color.Transparent;
            this.mStripConfig.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmItemConfigControl,
            this.tsmConfigKeepalive,
            this.tsmConfigAbout});
            this.mStripConfig.Location = new System.Drawing.Point(0, 0);
            this.mStripConfig.Name = "mStripConfig";
            this.mStripConfig.Size = new System.Drawing.Size(199, 24);
            this.mStripConfig.TabIndex = 0;
            // 
            // tsmItemConfigControl
            // 
            this.tsmItemConfigControl.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmItemConfigControlStart,
            this.tsmConfigControlStop,
            this.tsmItemConfigControlRestart});
            this.tsmItemConfigControl.ForeColor = System.Drawing.Color.GreenYellow;
            this.tsmItemConfigControl.Name = "tsmItemConfigControl";
            this.tsmItemConfigControl.Size = new System.Drawing.Size(59, 20);
            this.tsmItemConfigControl.Text = "Control";
            // 
            // tsmItemConfigControlStart
            // 
            this.tsmItemConfigControlStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.tsmItemConfigControlStart.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tsmItemConfigControlStart.Name = "tsmItemConfigControlStart";
            this.tsmItemConfigControlStart.Size = new System.Drawing.Size(153, 22);
            this.tsmItemConfigControlStart.Text = "Manual Start";
            this.tsmItemConfigControlStart.Click += new System.EventHandler(this.tsmItemConfigControlStart_Click);
            // 
            // tsmConfigControlStop
            // 
            this.tsmConfigControlStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.tsmConfigControlStop.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tsmConfigControlStop.Name = "tsmConfigControlStop";
            this.tsmConfigControlStop.Size = new System.Drawing.Size(153, 22);
            this.tsmConfigControlStop.Text = "Manual Stop";
            this.tsmConfigControlStop.Click += new System.EventHandler(this.tsmConfigControlStop_Click);
            // 
            // tsmItemConfigControlRestart
            // 
            this.tsmItemConfigControlRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.tsmItemConfigControlRestart.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tsmItemConfigControlRestart.Name = "tsmItemConfigControlRestart";
            this.tsmItemConfigControlRestart.Size = new System.Drawing.Size(153, 22);
            this.tsmItemConfigControlRestart.Text = "Manual Restart";
            this.tsmItemConfigControlRestart.Click += new System.EventHandler(this.tsmItemConfigControlRestart_Click);
            // 
            // tsmConfigKeepalive
            // 
            this.tsmConfigKeepalive.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmConfigKeepaliveStart,
            this.tsmConfigKeepaliveStop,
            this.tsmConfigKeepaliveLog,
            this.tsmConfigKeepaliveOpenLib,
            this.tsmConfigKeepaliveOpenSettings,
            this.tsmConfigKeepaliveClean,
            this.viewReadmeToolStripMenuItem});
            this.tsmConfigKeepalive.ForeColor = System.Drawing.Color.GreenYellow;
            this.tsmConfigKeepalive.Name = "tsmConfigKeepalive";
            this.tsmConfigKeepalive.Size = new System.Drawing.Size(69, 20);
            this.tsmConfigKeepalive.Text = "Keepalive";
            // 
            // tsmConfigKeepaliveStart
            // 
            this.tsmConfigKeepaliveStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.tsmConfigKeepaliveStart.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tsmConfigKeepaliveStart.Name = "tsmConfigKeepaliveStart";
            this.tsmConfigKeepaliveStart.Size = new System.Drawing.Size(173, 22);
            this.tsmConfigKeepaliveStart.Text = "Start Keepalive";
            this.tsmConfigKeepaliveStart.Click += new System.EventHandler(this.tsmConfigKeepaliveStart_Click);
            // 
            // tsmConfigKeepaliveStop
            // 
            this.tsmConfigKeepaliveStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.tsmConfigKeepaliveStop.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tsmConfigKeepaliveStop.Name = "tsmConfigKeepaliveStop";
            this.tsmConfigKeepaliveStop.Size = new System.Drawing.Size(173, 22);
            this.tsmConfigKeepaliveStop.Text = "Stop Keepalive";
            this.tsmConfigKeepaliveStop.Click += new System.EventHandler(this.tsmConfigKeepaliveStop_Click);
            // 
            // tsmConfigKeepaliveLog
            // 
            this.tsmConfigKeepaliveLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.tsmConfigKeepaliveLog.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tsmConfigKeepaliveLog.Name = "tsmConfigKeepaliveLog";
            this.tsmConfigKeepaliveLog.Size = new System.Drawing.Size(173, 22);
            this.tsmConfigKeepaliveLog.Text = "View Log";
            this.tsmConfigKeepaliveLog.Click += new System.EventHandler(this.tsmConfigKeepaliveLog_Click);
            // 
            // tsmConfigKeepaliveOpenLib
            // 
            this.tsmConfigKeepaliveOpenLib.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.tsmConfigKeepaliveOpenLib.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tsmConfigKeepaliveOpenLib.Name = "tsmConfigKeepaliveOpenLib";
            this.tsmConfigKeepaliveOpenLib.Size = new System.Drawing.Size(173, 22);
            this.tsmConfigKeepaliveOpenLib.Text = "Open Batch Lib";
            this.tsmConfigKeepaliveOpenLib.Click += new System.EventHandler(this.tsmConfigKeepaliveOpenLib_Click);
            // 
            // tsmConfigKeepaliveOpenSettings
            // 
            this.tsmConfigKeepaliveOpenSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.tsmConfigKeepaliveOpenSettings.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tsmConfigKeepaliveOpenSettings.Name = "tsmConfigKeepaliveOpenSettings";
            this.tsmConfigKeepaliveOpenSettings.Size = new System.Drawing.Size(173, 22);
            this.tsmConfigKeepaliveOpenSettings.Text = "Open Settings Raw";
            this.tsmConfigKeepaliveOpenSettings.Click += new System.EventHandler(this.tsmConfigKeepaliveOpenSettings_Click);
            // 
            // tsmConfigKeepaliveClean
            // 
            this.tsmConfigKeepaliveClean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.tsmConfigKeepaliveClean.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tsmConfigKeepaliveClean.Name = "tsmConfigKeepaliveClean";
            this.tsmConfigKeepaliveClean.Size = new System.Drawing.Size(173, 22);
            this.tsmConfigKeepaliveClean.Text = "Clean Batch Lib";
            this.tsmConfigKeepaliveClean.Click += new System.EventHandler(this.tsmConfigKeepaliveClean_Click);
            // 
            // tsmConfigAbout
            // 
            this.tsmConfigAbout.ForeColor = System.Drawing.Color.GreenYellow;
            this.tsmConfigAbout.Name = "tsmConfigAbout";
            this.tsmConfigAbout.Size = new System.Drawing.Size(52, 20);
            this.tsmConfigAbout.Text = "About";
            this.tsmConfigAbout.Click += new System.EventHandler(this.tsmConfigAbout_Click);
            // 
            // viewReadmeToolStripMenuItem
            // 
            this.viewReadmeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.viewReadmeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.viewReadmeToolStripMenuItem.Name = "viewReadmeToolStripMenuItem";
            this.viewReadmeToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.viewReadmeToolStripMenuItem.Text = "View Readme";
            this.viewReadmeToolStripMenuItem.Click += new System.EventHandler(this.viewReadmeToolStripMenuItem_Click);
            // 
            // tabControlMainConfig
            // 
            this.tabControlMainConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMainConfig.Controls.Add(this.tabPageProcessServer);
            this.tabControlMainConfig.Controls.Add(this.tabPageProcessDatabase);
            this.tabControlMainConfig.Controls.Add(this.tabPageProcessBEC);
            this.tabControlMainConfig.Controls.Add(this.tabPageProcessHC);
            this.tabControlMainConfig.Controls.Add(this.tabPageProcessTS);
            this.tabControlMainConfig.Controls.Add(this.tabPageProcessASM);
            this.tabControlMainConfig.Controls.Add(this.tabPageProcessCustom);
            this.tabControlMainConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlMainConfig.ItemSize = new System.Drawing.Size(125, 21);
            this.tabControlMainConfig.Location = new System.Drawing.Point(16, 187);
            this.tabControlMainConfig.Name = "tabControlMainConfig";
            this.tabControlMainConfig.SelectedIndex = 0;
            this.tabControlMainConfig.Size = new System.Drawing.Size(596, 295);
            this.tabControlMainConfig.TabIndex = 11;
            this.tabControlMainConfig.TabStop = false;
            // 
            // tabPageProcessServer
            // 
            this.tabPageProcessServer.AutoScroll = true;
            this.tabPageProcessServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.tabPageProcessServer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageProcessServer.Controls.Add(this.grpConfigServerBackup);
            this.tabPageProcessServer.Controls.Add(this.flpServer);
            this.tabPageProcessServer.Controls.Add(this.grpKeepaliveOptions);
            this.tabPageProcessServer.Controls.Add(this.grpConfigServerLaunch);
            this.tabPageProcessServer.Controls.Add(this.lblServerAffinity);
            this.tabPageProcessServer.Controls.Add(this.lblerverPriority);
            this.tabPageProcessServer.Controls.Add(this.cBoxPriorityServer);
            this.tabPageProcessServer.Controls.Add(this.btnProcessKeepaliveServer);
            this.tabPageProcessServer.Controls.Add(this.btnFortxtPathToEXEServer);
            this.tabPageProcessServer.Controls.Add(this.lblServerPathToEXE);
            this.tabPageProcessServer.Controls.Add(this.txtPathToEXEServer);
            this.tabPageProcessServer.Location = new System.Drawing.Point(4, 25);
            this.tabPageProcessServer.Name = "tabPageProcessServer";
            this.tabPageProcessServer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProcessServer.Size = new System.Drawing.Size(588, 266);
            this.tabPageProcessServer.TabIndex = 0;
            this.tabPageProcessServer.Text = "Arma Server";
            // 
            // grpConfigServerBackup
            // 
            this.grpConfigServerBackup.Controls.Add(this.chkUseZipLogs);
            this.grpConfigServerBackup.Controls.Add(this.btnFortxtPathToBackupLog);
            this.grpConfigServerBackup.Controls.Add(this.lblServerPathToLogBackup);
            this.grpConfigServerBackup.Controls.Add(this.txtPathToBackupLog);
            this.grpConfigServerBackup.Controls.Add(this.btnFortxtPathToServerLog);
            this.grpConfigServerBackup.Controls.Add(this.lblServerPathToLog);
            this.grpConfigServerBackup.Controls.Add(this.txtPathToServerLog);
            this.grpConfigServerBackup.ForeColor = System.Drawing.Color.White;
            this.grpConfigServerBackup.Location = new System.Drawing.Point(6, 109);
            this.grpConfigServerBackup.Name = "grpConfigServerBackup";
            this.grpConfigServerBackup.Size = new System.Drawing.Size(555, 135);
            this.grpConfigServerBackup.TabIndex = 31;
            this.grpConfigServerBackup.TabStop = false;
            this.grpConfigServerBackup.Text = "Backup/Logging Settings";
            // 
            // chkUseZipLogs
            // 
            this.chkUseZipLogs.AutoSize = true;
            this.chkUseZipLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUseZipLogs.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.chkUseZipLogs.Location = new System.Drawing.Point(436, 21);
            this.chkUseZipLogs.Name = "chkUseZipLogs";
            this.chkUseZipLogs.Size = new System.Drawing.Size(87, 17);
            this.chkUseZipLogs.TabIndex = 42;
            this.chkUseZipLogs.Text = "Use ZIP logs";
            this.toolTip1.SetToolTip(this.chkUseZipLogs, "Toggle the use of compression when archiving server logs.");
            this.chkUseZipLogs.UseVisualStyleBackColor = true;
            this.chkUseZipLogs.CheckedChanged += new System.EventHandler(this.actionUseZipLogs);
            // 
            // btnFortxtPathToBackupLog
            // 
            this.btnFortxtPathToBackupLog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnFortxtPathToBackupLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnFortxtPathToBackupLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFortxtPathToBackupLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFortxtPathToBackupLog.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnFortxtPathToBackupLog.Location = new System.Drawing.Point(475, 100);
            this.btnFortxtPathToBackupLog.Margin = new System.Windows.Forms.Padding(0);
            this.btnFortxtPathToBackupLog.Name = "btnFortxtPathToBackupLog";
            this.btnFortxtPathToBackupLog.Size = new System.Drawing.Size(64, 22);
            this.btnFortxtPathToBackupLog.TabIndex = 41;
            this.btnFortxtPathToBackupLog.Text = "Browse";
            this.btnFortxtPathToBackupLog.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnFortxtPathToBackupLog.UseVisualStyleBackColor = true;
            // 
            // lblServerPathToLogBackup
            // 
            this.lblServerPathToLogBackup.AutoSize = true;
            this.lblServerPathToLogBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerPathToLogBackup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblServerPathToLogBackup.Location = new System.Drawing.Point(6, 80);
            this.lblServerPathToLogBackup.Name = "lblServerPathToLogBackup";
            this.lblServerPathToLogBackup.Size = new System.Drawing.Size(191, 16);
            this.lblServerPathToLogBackup.TabIndex = 40;
            this.lblServerPathToLogBackup.Text = "Path to Log File Backup Folder";
            this.toolTip1.SetToolTip(this.lblServerPathToLogBackup, "Path to the folder which contains all server log archives");
            // 
            // txtPathToBackupLog
            // 
            this.txtPathToBackupLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPathToBackupLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPathToBackupLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPathToBackupLog.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPathToBackupLog.Location = new System.Drawing.Point(9, 100);
            this.txtPathToBackupLog.Name = "txtPathToBackupLog";
            this.txtPathToBackupLog.ReadOnly = true;
            this.txtPathToBackupLog.Size = new System.Drawing.Size(463, 22);
            this.txtPathToBackupLog.TabIndex = 39;
            this.toolTip1.SetToolTip(this.txtPathToBackupLog, "Path to the folder which contains all server log archives");
            // 
            // btnFortxtPathToServerLog
            // 
            this.btnFortxtPathToServerLog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnFortxtPathToServerLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnFortxtPathToServerLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFortxtPathToServerLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFortxtPathToServerLog.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnFortxtPathToServerLog.Location = new System.Drawing.Point(475, 50);
            this.btnFortxtPathToServerLog.Margin = new System.Windows.Forms.Padding(0);
            this.btnFortxtPathToServerLog.Name = "btnFortxtPathToServerLog";
            this.btnFortxtPathToServerLog.Size = new System.Drawing.Size(64, 22);
            this.btnFortxtPathToServerLog.TabIndex = 38;
            this.btnFortxtPathToServerLog.Text = "Browse";
            this.btnFortxtPathToServerLog.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnFortxtPathToServerLog.UseVisualStyleBackColor = true;
            this.btnFortxtPathToServerLog.Click += new System.EventHandler(this.actionBrowseButtonForFilePath);
            // 
            // lblServerPathToLog
            // 
            this.lblServerPathToLog.AutoSize = true;
            this.lblServerPathToLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerPathToLog.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblServerPathToLog.Location = new System.Drawing.Point(6, 30);
            this.lblServerPathToLog.Name = "lblServerPathToLog";
            this.lblServerPathToLog.Size = new System.Drawing.Size(143, 16);
            this.lblServerPathToLog.TabIndex = 37;
            this.lblServerPathToLog.Text = "Path to Server Log File";
            this.toolTip1.SetToolTip(this.lblServerPathToLog, "Path to the folder which contains the live server logs");
            // 
            // txtPathToServerLog
            // 
            this.txtPathToServerLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPathToServerLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPathToServerLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPathToServerLog.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPathToServerLog.Location = new System.Drawing.Point(9, 50);
            this.txtPathToServerLog.Name = "txtPathToServerLog";
            this.txtPathToServerLog.ReadOnly = true;
            this.txtPathToServerLog.Size = new System.Drawing.Size(463, 22);
            this.txtPathToServerLog.TabIndex = 36;
            this.toolTip1.SetToolTip(this.txtPathToServerLog, "Path to the folder which contains the live server logs");
            // 
            // flpServer
            // 
            this.flpServer.AutoScroll = true;
            this.flpServer.Location = new System.Drawing.Point(207, 69);
            this.flpServer.Name = "flpServer";
            this.flpServer.Size = new System.Drawing.Size(354, 49);
            this.flpServer.TabIndex = 30;
            this.flpServer.WrapContents = false;
            // 
            // grpKeepaliveOptions
            // 
            this.grpKeepaliveOptions.Controls.Add(this.numStartTimeout);
            this.grpKeepaliveOptions.Controls.Add(this.numManualTimeout);
            this.grpKeepaliveOptions.Controls.Add(this.numAutoTimeout);
            this.grpKeepaliveOptions.Controls.Add(this.numAutoDelay);
            this.grpKeepaliveOptions.Controls.Add(this.cBoxDebugLevel);
            this.grpKeepaliveOptions.Controls.Add(this.lblStartTimeout);
            this.grpKeepaliveOptions.Controls.Add(this.chkCleanWERs);
            this.grpKeepaliveOptions.Controls.Add(this.lblManualTimeout);
            this.grpKeepaliveOptions.Controls.Add(this.lblAutoTimeout);
            this.grpKeepaliveOptions.Controls.Add(this.lblAutoDelay);
            this.grpKeepaliveOptions.Controls.Add(this.lblDebugLevel);
            this.grpKeepaliveOptions.ForeColor = System.Drawing.Color.White;
            this.grpKeepaliveOptions.Location = new System.Drawing.Point(6, 250);
            this.grpKeepaliveOptions.Name = "grpKeepaliveOptions";
            this.grpKeepaliveOptions.Size = new System.Drawing.Size(555, 147);
            this.grpKeepaliveOptions.TabIndex = 29;
            this.grpKeepaliveOptions.TabStop = false;
            this.grpKeepaliveOptions.Text = "Restart / Keepalive Settings";
            // 
            // numStartTimeout
            // 
            this.numStartTimeout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.numStartTimeout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numStartTimeout.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.numStartTimeout.Location = new System.Drawing.Point(441, 116);
            this.numStartTimeout.Maximum = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            this.numStartTimeout.Name = "numStartTimeout";
            this.numStartTimeout.Size = new System.Drawing.Size(72, 16);
            this.numStartTimeout.TabIndex = 56;
            this.toolTip1.SetToolTip(this.numStartTimeout, "Number of secodns to wait before assuming the server has crashed on startup. (Mak" +
        "e sure to set this long than it takes your server to start! 60 should be safe)");
            this.numStartTimeout.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numStartTimeout.ValueChanged += new System.EventHandler(this.actionStartTimeoutChanged);
            // 
            // numManualTimeout
            // 
            this.numManualTimeout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.numManualTimeout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numManualTimeout.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.numManualTimeout.Location = new System.Drawing.Point(165, 116);
            this.numManualTimeout.Maximum = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            this.numManualTimeout.Name = "numManualTimeout";
            this.numManualTimeout.Size = new System.Drawing.Size(67, 16);
            this.numManualTimeout.TabIndex = 55;
            this.toolTip1.SetToolTip(this.numManualTimeout, "Number of seconds ti wait before assuming the server has crashed after trying to " +
        "stop services during a Manual event");
            this.numManualTimeout.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numManualTimeout.ValueChanged += new System.EventHandler(this.actionManualTimeoutChanged);
            // 
            // numAutoTimeout
            // 
            this.numAutoTimeout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.numAutoTimeout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numAutoTimeout.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.numAutoTimeout.Location = new System.Drawing.Point(441, 81);
            this.numAutoTimeout.Maximum = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            this.numAutoTimeout.Name = "numAutoTimeout";
            this.numAutoTimeout.Size = new System.Drawing.Size(72, 16);
            this.numAutoTimeout.TabIndex = 54;
            this.toolTip1.SetToolTip(this.numAutoTimeout, "Number of seconds to wait before assuming the server has crashed after trying to " +
        "stop services during an automatic event");
            this.numAutoTimeout.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numAutoTimeout.ValueChanged += new System.EventHandler(this.actionAutoTimeoutChanged);
            // 
            // numAutoDelay
            // 
            this.numAutoDelay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.numAutoDelay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numAutoDelay.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.numAutoDelay.Location = new System.Drawing.Point(165, 81);
            this.numAutoDelay.Maximum = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            this.numAutoDelay.Name = "numAutoDelay";
            this.numAutoDelay.Size = new System.Drawing.Size(67, 16);
            this.numAutoDelay.TabIndex = 53;
            this.toolTip1.SetToolTip(this.numAutoDelay, "Time in seconds to delay the restarting of services after a shutdown from an auto" +
        "matic event");
            this.numAutoDelay.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numAutoDelay.ValueChanged += new System.EventHandler(this.actionAutoDelayChanged);
            // 
            // cBoxDebugLevel
            // 
            this.cBoxDebugLevel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.cBoxDebugLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cBoxDebugLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxDebugLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxDebugLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxDebugLevel.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.cBoxDebugLevel.FormattingEnabled = true;
            this.cBoxDebugLevel.Items.AddRange(new object[] {
            "0. Do not log anything",
            "1. Log only events",
            "2. Log events and Errors",
            "3. Log Everything (For debug info)"});
            this.cBoxDebugLevel.Location = new System.Drawing.Point(9, 49);
            this.cBoxDebugLevel.Name = "cBoxDebugLevel";
            this.cBoxDebugLevel.Size = new System.Drawing.Size(530, 24);
            this.cBoxDebugLevel.TabIndex = 52;
            this.toolTip1.SetToolTip(this.cBoxDebugLevel, "Batchrun.log Debug Level.\r\n0= NO LOGS\r\n1= Only Events\r\n2= Events + Errors\r\n3= Eve" +
        "rything (Verbose)\r\n");
            this.cBoxDebugLevel.SelectedIndexChanged += new System.EventHandler(this.actionDebugChanged);
            // 
            // lblStartTimeout
            // 
            this.lblStartTimeout.AutoSize = true;
            this.lblStartTimeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartTimeout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStartTimeout.Location = new System.Drawing.Point(297, 118);
            this.lblStartTimeout.Name = "lblStartTimeout";
            this.lblStartTimeout.Size = new System.Drawing.Size(130, 16);
            this.lblStartTimeout.TabIndex = 49;
            this.lblStartTimeout.Text = "Server Start Timeout";
            this.toolTip1.SetToolTip(this.lblStartTimeout, "Number of secodns to wait before assuming the server has crashed on startup. (Mak" +
        "e sure to set this long than it takes your server to start! 60 should be safe)");
            // 
            // chkCleanWERs
            // 
            this.chkCleanWERs.AutoSize = true;
            this.chkCleanWERs.BackColor = System.Drawing.Color.Transparent;
            this.chkCleanWERs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCleanWERs.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.chkCleanWERs.Location = new System.Drawing.Point(436, 21);
            this.chkCleanWERs.Name = "chkCleanWERs";
            this.chkCleanWERs.Size = new System.Drawing.Size(120, 17);
            this.chkCleanWERs.TabIndex = 43;
            this.chkCleanWERs.Text = "Clean WER Dialogs";
            this.toolTip1.SetToolTip(this.chkCleanWERs, "Toggle the feature that auto-closes any error/crash/WER dialogs found so batch ca" +
        "n proceed.");
            this.chkCleanWERs.UseVisualStyleBackColor = false;
            this.chkCleanWERs.CheckedChanged += new System.EventHandler(this.actionCleanWER);
            // 
            // lblManualTimeout
            // 
            this.lblManualTimeout.AutoSize = true;
            this.lblManualTimeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManualTimeout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblManualTimeout.Location = new System.Drawing.Point(6, 118);
            this.lblManualTimeout.Name = "lblManualTimeout";
            this.lblManualTimeout.Size = new System.Drawing.Size(150, 16);
            this.lblManualTimeout.TabIndex = 46;
            this.lblManualTimeout.Text = "Manual Restart Timeout";
            this.toolTip1.SetToolTip(this.lblManualTimeout, "Number of seconds ti wait before assuming the server has crashed after trying to " +
        "stop services during a Manual event");
            // 
            // lblAutoTimeout
            // 
            this.lblAutoTimeout.AutoSize = true;
            this.lblAutoTimeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutoTimeout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAutoTimeout.Location = new System.Drawing.Point(294, 83);
            this.lblAutoTimeout.Name = "lblAutoTimeout";
            this.lblAutoTimeout.Size = new System.Drawing.Size(133, 16);
            this.lblAutoTimeout.TabIndex = 43;
            this.lblAutoTimeout.Text = "Auto Restart Timeout";
            this.toolTip1.SetToolTip(this.lblAutoTimeout, "Number of seconds to wait before assuming the server has crashed after trying to " +
        "stop services during an automatic event");
            // 
            // lblAutoDelay
            // 
            this.lblAutoDelay.AutoSize = true;
            this.lblAutoDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutoDelay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAutoDelay.Location = new System.Drawing.Point(36, 83);
            this.lblAutoDelay.Name = "lblAutoDelay";
            this.lblAutoDelay.Size = new System.Drawing.Size(120, 16);
            this.lblAutoDelay.TabIndex = 40;
            this.lblAutoDelay.Text = "Auto Restart Delay";
            this.toolTip1.SetToolTip(this.lblAutoDelay, "Time in seconds to delay the restarting of services after a shutdown from an auto" +
        "matic event");
            // 
            // lblDebugLevel
            // 
            this.lblDebugLevel.AutoSize = true;
            this.lblDebugLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebugLevel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDebugLevel.Location = new System.Drawing.Point(6, 30);
            this.lblDebugLevel.Name = "lblDebugLevel";
            this.lblDebugLevel.Size = new System.Drawing.Size(85, 16);
            this.lblDebugLevel.TabIndex = 37;
            this.lblDebugLevel.Text = "Debug Level";
            this.toolTip1.SetToolTip(this.lblDebugLevel, "Batchrun.log Debug Level.\r\n0= NO LOGS\r\n1= Only Events\r\n2= Events + Errors\r\n3= Eve" +
        "rything (Verbose)");
            // 
            // grpConfigServerLaunch
            // 
            this.grpConfigServerLaunch.Controls.Add(this.chkServerBindToIP);
            this.grpConfigServerLaunch.Controls.Add(this.numServerIP4);
            this.grpConfigServerLaunch.Controls.Add(this.numServerIP3);
            this.grpConfigServerLaunch.Controls.Add(this.numServerIP2);
            this.grpConfigServerLaunch.Controls.Add(this.numServerIP1);
            this.grpConfigServerLaunch.Controls.Add(this.lvlServerIP);
            this.grpConfigServerLaunch.Controls.Add(this.numServerPort);
            this.grpConfigServerLaunch.Controls.Add(this.txtProfileName);
            this.grpConfigServerLaunch.Controls.Add(this.lblServerProfileName);
            this.grpConfigServerLaunch.Controls.Add(this.btnFortxtPathToProfile);
            this.grpConfigServerLaunch.Controls.Add(this.lblPathToProfile);
            this.grpConfigServerLaunch.Controls.Add(this.txtPathToProfile);
            this.grpConfigServerLaunch.Controls.Add(this.btnFortxtPathToBasicCFG);
            this.grpConfigServerLaunch.Controls.Add(this.lblServerPathToBasic);
            this.grpConfigServerLaunch.Controls.Add(this.txtPathToBasicCFG);
            this.grpConfigServerLaunch.Controls.Add(this.btnFortxtPathToConfigCFG);
            this.grpConfigServerLaunch.Controls.Add(this.lblServerPathToConfig);
            this.grpConfigServerLaunch.Controls.Add(this.txtPathToConfigCFG);
            this.grpConfigServerLaunch.Controls.Add(this.txtServerModline);
            this.grpConfigServerLaunch.Controls.Add(this.lblServerModline);
            this.grpConfigServerLaunch.Controls.Add(this.txtServerCommand);
            this.grpConfigServerLaunch.Controls.Add(this.lblServerCommand);
            this.grpConfigServerLaunch.Controls.Add(this.lblServerPort);
            this.grpConfigServerLaunch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpConfigServerLaunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpConfigServerLaunch.ForeColor = System.Drawing.Color.White;
            this.grpConfigServerLaunch.Location = new System.Drawing.Point(6, 403);
            this.grpConfigServerLaunch.Name = "grpConfigServerLaunch";
            this.grpConfigServerLaunch.Size = new System.Drawing.Size(555, 400);
            this.grpConfigServerLaunch.TabIndex = 27;
            this.grpConfigServerLaunch.TabStop = false;
            this.grpConfigServerLaunch.Text = "Process Launch Settings";
            // 
            // chkServerBindToIP
            // 
            this.chkServerBindToIP.AutoSize = true;
            this.chkServerBindToIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkServerBindToIP.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.chkServerBindToIP.Location = new System.Drawing.Point(436, 25);
            this.chkServerBindToIP.Name = "chkServerBindToIP";
            this.chkServerBindToIP.Size = new System.Drawing.Size(76, 17);
            this.chkServerBindToIP.TabIndex = 50;
            this.chkServerBindToIP.Text = "Bind To IP";
            this.toolTip1.SetToolTip(this.chkServerBindToIP, "Enable binding to IP (Mostly unneeded)");
            this.chkServerBindToIP.UseVisualStyleBackColor = true;
            this.chkServerBindToIP.Click += new System.EventHandler(this.actionBindToIpChanged);
            // 
            // numServerIP4
            // 
            this.numServerIP4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.numServerIP4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numServerIP4.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.numServerIP4.Location = new System.Drawing.Point(165, 50);
            this.numServerIP4.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numServerIP4.Name = "numServerIP4";
            this.numServerIP4.Size = new System.Drawing.Size(46, 22);
            this.numServerIP4.TabIndex = 49;
            this.toolTip1.SetToolTip(this.numServerIP4, "The Public IP address to bind to");
            this.numServerIP4.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numServerIP4.ValueChanged += new System.EventHandler(this.actionServerIPChanged);
            // 
            // numServerIP3
            // 
            this.numServerIP3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.numServerIP3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numServerIP3.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.numServerIP3.Location = new System.Drawing.Point(113, 50);
            this.numServerIP3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numServerIP3.Name = "numServerIP3";
            this.numServerIP3.Size = new System.Drawing.Size(46, 22);
            this.numServerIP3.TabIndex = 48;
            this.toolTip1.SetToolTip(this.numServerIP3, "The Public IP address to bind to");
            this.numServerIP3.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numServerIP3.ValueChanged += new System.EventHandler(this.actionServerIPChanged);
            // 
            // numServerIP2
            // 
            this.numServerIP2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.numServerIP2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numServerIP2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.numServerIP2.Location = new System.Drawing.Point(61, 50);
            this.numServerIP2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numServerIP2.Name = "numServerIP2";
            this.numServerIP2.Size = new System.Drawing.Size(46, 22);
            this.numServerIP2.TabIndex = 47;
            this.toolTip1.SetToolTip(this.numServerIP2, "The Public IP address to bind to");
            this.numServerIP2.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numServerIP2.ValueChanged += new System.EventHandler(this.actionServerIPChanged);
            // 
            // numServerIP1
            // 
            this.numServerIP1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.numServerIP1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numServerIP1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.numServerIP1.Location = new System.Drawing.Point(9, 50);
            this.numServerIP1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numServerIP1.Name = "numServerIP1";
            this.numServerIP1.Size = new System.Drawing.Size(46, 22);
            this.numServerIP1.TabIndex = 46;
            this.toolTip1.SetToolTip(this.numServerIP1, "The Public IP address to bind to");
            this.numServerIP1.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numServerIP1.ValueChanged += new System.EventHandler(this.actionServerIPChanged);
            // 
            // lvlServerIP
            // 
            this.lvlServerIP.AutoSize = true;
            this.lvlServerIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlServerIP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lvlServerIP.Location = new System.Drawing.Point(6, 30);
            this.lvlServerIP.Name = "lvlServerIP";
            this.lvlServerIP.Size = new System.Drawing.Size(74, 16);
            this.lvlServerIP.TabIndex = 45;
            this.lvlServerIP.Text = "IP Address";
            this.toolTip1.SetToolTip(this.lvlServerIP, "The Public IP address to bind to");
            // 
            // numServerPort
            // 
            this.numServerPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.numServerPort.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numServerPort.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.numServerPort.Location = new System.Drawing.Point(245, 50);
            this.numServerPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numServerPort.Minimum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.numServerPort.Name = "numServerPort";
            this.numServerPort.Size = new System.Drawing.Size(88, 22);
            this.numServerPort.TabIndex = 44;
            this.toolTip1.SetToolTip(this.numServerPort, "The Public Port Number to bind to");
            this.numServerPort.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.numServerPort.ValueChanged += new System.EventHandler(this.actionServerPortChanged);
            // 
            // txtProfileName
            // 
            this.txtProfileName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProfileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProfileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfileName.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtProfileName.Location = new System.Drawing.Point(9, 370);
            this.txtProfileName.Name = "txtProfileName";
            this.txtProfileName.ReadOnly = true;
            this.txtProfileName.Size = new System.Drawing.Size(162, 22);
            this.txtProfileName.TabIndex = 43;
            this.toolTip1.SetToolTip(this.txtProfileName, "Profile Name/Filename, This is set only by choosing the path to your profile. It " +
        "is automatic. Just here for reference.");
            // 
            // lblServerProfileName
            // 
            this.lblServerProfileName.AutoSize = true;
            this.lblServerProfileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerProfileName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblServerProfileName.Location = new System.Drawing.Point(6, 351);
            this.lblServerProfileName.Name = "lblServerProfileName";
            this.lblServerProfileName.Size = new System.Drawing.Size(86, 16);
            this.lblServerProfileName.TabIndex = 42;
            this.lblServerProfileName.Text = "Profile Name";
            this.toolTip1.SetToolTip(this.lblServerProfileName, "Profile Name/Filename, This is set only by choosing the path to your profile. It " +
        "is automatic. Just here for reference.");
            // 
            // btnFortxtPathToProfile
            // 
            this.btnFortxtPathToProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnFortxtPathToProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnFortxtPathToProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFortxtPathToProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFortxtPathToProfile.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnFortxtPathToProfile.Location = new System.Drawing.Point(475, 318);
            this.btnFortxtPathToProfile.Margin = new System.Windows.Forms.Padding(0);
            this.btnFortxtPathToProfile.Name = "btnFortxtPathToProfile";
            this.btnFortxtPathToProfile.Size = new System.Drawing.Size(64, 22);
            this.btnFortxtPathToProfile.TabIndex = 41;
            this.btnFortxtPathToProfile.Text = "Browse";
            this.btnFortxtPathToProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnFortxtPathToProfile.UseVisualStyleBackColor = true;
            this.btnFortxtPathToProfile.Click += new System.EventHandler(this.actionBrowseButtonForFilePath);
            // 
            // lblPathToProfile
            // 
            this.lblPathToProfile.AutoSize = true;
            this.lblPathToProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPathToProfile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPathToProfile.Location = new System.Drawing.Point(6, 299);
            this.lblPathToProfile.Name = "lblPathToProfile";
            this.lblPathToProfile.Size = new System.Drawing.Size(97, 16);
            this.lblPathToProfile.TabIndex = 40;
            this.lblPathToProfile.Text = "Path to Profiles";
            this.toolTip1.SetToolTip(this.lblPathToProfile, "Path to Profiles (This line will be modified according to the location of your pr" +
        "ofiles, it may be shortened. This is normal)");
            // 
            // txtPathToProfile
            // 
            this.txtPathToProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPathToProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPathToProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPathToProfile.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPathToProfile.Location = new System.Drawing.Point(9, 318);
            this.txtPathToProfile.Name = "txtPathToProfile";
            this.txtPathToProfile.ReadOnly = true;
            this.txtPathToProfile.Size = new System.Drawing.Size(463, 22);
            this.txtPathToProfile.TabIndex = 39;
            this.toolTip1.SetToolTip(this.txtPathToProfile, "Path to Profiles (This line will be modified according to the location of your pr" +
        "ofiles, it may be shortened. This is normal)");
            // 
            // btnFortxtPathToBasicCFG
            // 
            this.btnFortxtPathToBasicCFG.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnFortxtPathToBasicCFG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnFortxtPathToBasicCFG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFortxtPathToBasicCFG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFortxtPathToBasicCFG.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnFortxtPathToBasicCFG.Location = new System.Drawing.Point(475, 264);
            this.btnFortxtPathToBasicCFG.Margin = new System.Windows.Forms.Padding(0);
            this.btnFortxtPathToBasicCFG.Name = "btnFortxtPathToBasicCFG";
            this.btnFortxtPathToBasicCFG.Size = new System.Drawing.Size(64, 22);
            this.btnFortxtPathToBasicCFG.TabIndex = 38;
            this.btnFortxtPathToBasicCFG.Text = "Browse";
            this.btnFortxtPathToBasicCFG.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnFortxtPathToBasicCFG.UseVisualStyleBackColor = true;
            this.btnFortxtPathToBasicCFG.Click += new System.EventHandler(this.actionBrowseButtonForFilePath);
            // 
            // lblServerPathToBasic
            // 
            this.lblServerPathToBasic.AutoSize = true;
            this.lblServerPathToBasic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerPathToBasic.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblServerPathToBasic.Location = new System.Drawing.Point(6, 245);
            this.lblServerPathToBasic.Name = "lblServerPathToBasic";
            this.lblServerPathToBasic.Size = new System.Drawing.Size(106, 16);
            this.lblServerPathToBasic.TabIndex = 37;
            this.lblServerPathToBasic.Text = "Path to basic.cfg";
            // 
            // txtPathToBasicCFG
            // 
            this.txtPathToBasicCFG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPathToBasicCFG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPathToBasicCFG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPathToBasicCFG.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPathToBasicCFG.Location = new System.Drawing.Point(9, 264);
            this.txtPathToBasicCFG.Name = "txtPathToBasicCFG";
            this.txtPathToBasicCFG.ReadOnly = true;
            this.txtPathToBasicCFG.Size = new System.Drawing.Size(463, 22);
            this.txtPathToBasicCFG.TabIndex = 36;
            this.toolTip1.SetToolTip(this.txtPathToBasicCFG, "Path to Server Config \"Basic.CFG\"");
            // 
            // btnFortxtPathToConfigCFG
            // 
            this.btnFortxtPathToConfigCFG.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnFortxtPathToConfigCFG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnFortxtPathToConfigCFG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFortxtPathToConfigCFG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFortxtPathToConfigCFG.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnFortxtPathToConfigCFG.Location = new System.Drawing.Point(475, 210);
            this.btnFortxtPathToConfigCFG.Margin = new System.Windows.Forms.Padding(0);
            this.btnFortxtPathToConfigCFG.Name = "btnFortxtPathToConfigCFG";
            this.btnFortxtPathToConfigCFG.Size = new System.Drawing.Size(64, 22);
            this.btnFortxtPathToConfigCFG.TabIndex = 35;
            this.btnFortxtPathToConfigCFG.Text = "Browse";
            this.btnFortxtPathToConfigCFG.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnFortxtPathToConfigCFG.UseVisualStyleBackColor = true;
            this.btnFortxtPathToConfigCFG.Click += new System.EventHandler(this.actionBrowseButtonForFilePath);
            // 
            // lblServerPathToConfig
            // 
            this.lblServerPathToConfig.AutoSize = true;
            this.lblServerPathToConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerPathToConfig.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblServerPathToConfig.Location = new System.Drawing.Point(6, 191);
            this.lblServerPathToConfig.Name = "lblServerPathToConfig";
            this.lblServerPathToConfig.Size = new System.Drawing.Size(179, 16);
            this.lblServerPathToConfig.TabIndex = 34;
            this.lblServerPathToConfig.Text = "Path to config.cfg (server.cfg)";
            this.toolTip1.SetToolTip(this.lblServerPathToConfig, "Path the server config \"Server.CFG\"");
            // 
            // txtPathToConfigCFG
            // 
            this.txtPathToConfigCFG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPathToConfigCFG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPathToConfigCFG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPathToConfigCFG.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPathToConfigCFG.Location = new System.Drawing.Point(9, 210);
            this.txtPathToConfigCFG.Name = "txtPathToConfigCFG";
            this.txtPathToConfigCFG.ReadOnly = true;
            this.txtPathToConfigCFG.Size = new System.Drawing.Size(463, 22);
            this.txtPathToConfigCFG.TabIndex = 33;
            this.toolTip1.SetToolTip(this.txtPathToConfigCFG, "Path the server config \"Server.CFG\"");
            // 
            // txtServerModline
            // 
            this.txtServerModline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtServerModline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtServerModline.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServerModline.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtServerModline.Location = new System.Drawing.Point(9, 104);
            this.txtServerModline.Name = "txtServerModline";
            this.txtServerModline.Size = new System.Drawing.Size(530, 22);
            this.txtServerModline.TabIndex = 32;
            this.toolTip1.SetToolTip(this.txtServerModline, "Arma Serer ModLine parameter - Use this to add mods to load (these must be instal" +
        "led with keys ofc)");
            this.txtServerModline.Leave += new System.EventHandler(this.actionServerModLineTouched);
            // 
            // lblServerModline
            // 
            this.lblServerModline.AutoSize = true;
            this.lblServerModline.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerModline.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblServerModline.Location = new System.Drawing.Point(6, 85);
            this.lblServerModline.Name = "lblServerModline";
            this.lblServerModline.Size = new System.Drawing.Size(63, 16);
            this.lblServerModline.TabIndex = 31;
            this.lblServerModline.Text = "Mod Line";
            this.toolTip1.SetToolTip(this.lblServerModline, "Arma Serer ModLine parameter - Use this to add mods to load (these must be instal" +
        "led with keys ofc)");
            // 
            // txtServerCommand
            // 
            this.txtServerCommand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtServerCommand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtServerCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServerCommand.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtServerCommand.Location = new System.Drawing.Point(9, 157);
            this.txtServerCommand.Name = "txtServerCommand";
            this.txtServerCommand.Size = new System.Drawing.Size(530, 22);
            this.txtServerCommand.TabIndex = 30;
            this.toolTip1.SetToolTip(this.txtServerCommand, "Complete Server Launch Command. Should not need to edit. Be careful when editing " +
        "as this incorporates other variables such as the modline and profiles. Change th" +
        "is line with CAUTION.");
            this.txtServerCommand.Leave += new System.EventHandler(this.actionServerCmdLineTouched);
            // 
            // lblServerCommand
            // 
            this.lblServerCommand.AutoSize = true;
            this.lblServerCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerCommand.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblServerCommand.Location = new System.Drawing.Point(6, 138);
            this.lblServerCommand.Name = "lblServerCommand";
            this.lblServerCommand.Size = new System.Drawing.Size(141, 16);
            this.lblServerCommand.TabIndex = 29;
            this.lblServerCommand.Text = "Server Command Line";
            this.toolTip1.SetToolTip(this.lblServerCommand, "Complete Server Launch Command. Should not need to edit. Be careful when editing " +
        "as this incorporates other variables such as the modline and profiles. Change th" +
        "is line with CAUTION.");
            // 
            // lblServerPort
            // 
            this.lblServerPort.AutoSize = true;
            this.lblServerPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerPort.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblServerPort.Location = new System.Drawing.Point(242, 30);
            this.lblServerPort.Name = "lblServerPort";
            this.lblServerPort.Size = new System.Drawing.Size(75, 16);
            this.lblServerPort.TabIndex = 28;
            this.lblServerPort.Text = "Server Port";
            this.toolTip1.SetToolTip(this.lblServerPort, "The Public Port Number to bind to");
            // 
            // lblServerAffinity
            // 
            this.lblServerAffinity.AutoSize = true;
            this.lblServerAffinity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerAffinity.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblServerAffinity.Location = new System.Drawing.Point(204, 50);
            this.lblServerAffinity.Name = "lblServerAffinity";
            this.lblServerAffinity.Size = new System.Drawing.Size(144, 16);
            this.lblServerAffinity.TabIndex = 17;
            this.lblServerAffinity.Text = "Process Affinity (cores)";
            this.toolTip1.SetToolTip(this.lblServerAffinity, "Process EXE Affinity. The cores with which this process can utilize.");
            // 
            // lblerverPriority
            // 
            this.lblerverPriority.AutoSize = true;
            this.lblerverPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerverPriority.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblerverPriority.Location = new System.Drawing.Point(3, 58);
            this.lblerverPriority.Name = "lblerverPriority";
            this.lblerverPriority.Size = new System.Drawing.Size(102, 16);
            this.lblerverPriority.TabIndex = 16;
            this.lblerverPriority.Text = "Process Priority";
            // 
            // cBoxPriorityServer
            // 
            this.cBoxPriorityServer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.cBoxPriorityServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cBoxPriorityServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxPriorityServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxPriorityServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxPriorityServer.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.cBoxPriorityServer.FormattingEnabled = true;
            this.cBoxPriorityServer.Items.AddRange(new object[] {
            "Realtime",
            "High",
            "AboveNormal",
            "Normal",
            "BelowNormal",
            "Low"});
            this.cBoxPriorityServer.Location = new System.Drawing.Point(6, 77);
            this.cBoxPriorityServer.Name = "cBoxPriorityServer";
            this.cBoxPriorityServer.Size = new System.Drawing.Size(184, 24);
            this.cBoxPriorityServer.TabIndex = 15;
            this.toolTip1.SetToolTip(this.cBoxPriorityServer, "Process EXE Priority, don\'t change unless you noticed a performance change by doi" +
        "ng so");
            this.cBoxPriorityServer.SelectedIndexChanged += new System.EventHandler(this.actionPriorityChanged);
            // 
            // btnProcessKeepaliveServer
            // 
            this.btnProcessKeepaliveServer.Enabled = false;
            this.btnProcessKeepaliveServer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnProcessKeepaliveServer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnProcessKeepaliveServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessKeepaliveServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessKeepaliveServer.ForeColor = System.Drawing.Color.Green;
            this.btnProcessKeepaliveServer.Location = new System.Drawing.Point(6, 6);
            this.btnProcessKeepaliveServer.Name = "btnProcessKeepaliveServer";
            this.btnProcessKeepaliveServer.Size = new System.Drawing.Size(184, 41);
            this.btnProcessKeepaliveServer.TabIndex = 11;
            this.btnProcessKeepaliveServer.Text = "Keep Process Alive";
            this.toolTip1.SetToolTip(this.btnProcessKeepaliveServer, "Toggle the keepalive for this process. (FORCED for Arma Server)");
            this.btnProcessKeepaliveServer.UseVisualStyleBackColor = true;
            this.btnProcessKeepaliveServer.Click += new System.EventHandler(this.actionProcessKeepaliveToggle);
            this.btnProcessKeepaliveServer.Leave += new System.EventHandler(this.evntKeepProcessAlive_Leave);
            this.btnProcessKeepaliveServer.MouseLeave += new System.EventHandler(this.evntKeepProcessAlive_MouseLeave);
            this.btnProcessKeepaliveServer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.evntKeepProcessAlive_MouseMove);
            // 
            // btnFortxtPathToEXEServer
            // 
            this.btnFortxtPathToEXEServer.Enabled = false;
            this.btnFortxtPathToEXEServer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnFortxtPathToEXEServer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnFortxtPathToEXEServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFortxtPathToEXEServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFortxtPathToEXEServer.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnFortxtPathToEXEServer.Location = new System.Drawing.Point(497, 25);
            this.btnFortxtPathToEXEServer.Margin = new System.Windows.Forms.Padding(0);
            this.btnFortxtPathToEXEServer.Name = "btnFortxtPathToEXEServer";
            this.btnFortxtPathToEXEServer.Size = new System.Drawing.Size(64, 22);
            this.btnFortxtPathToEXEServer.TabIndex = 10;
            this.btnFortxtPathToEXEServer.Text = "Browse";
            this.btnFortxtPathToEXEServer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnFortxtPathToEXEServer.UseVisualStyleBackColor = true;
            this.btnFortxtPathToEXEServer.Click += new System.EventHandler(this.actionBrowseButtonForFilePath);
            // 
            // lblServerPathToEXE
            // 
            this.lblServerPathToEXE.AutoSize = true;
            this.lblServerPathToEXE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerPathToEXE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblServerPathToEXE.Location = new System.Drawing.Point(204, 6);
            this.lblServerPathToEXE.Name = "lblServerPathToEXE";
            this.lblServerPathToEXE.Size = new System.Drawing.Size(119, 16);
            this.lblServerPathToEXE.TabIndex = 5;
            this.lblServerPathToEXE.Text = "Path to Executable";
            this.toolTip1.SetToolTip(this.lblServerPathToEXE, "Path to the process executable (Arma EXE linked to above path. Unchangeable)");
            // 
            // txtPathToEXEServer
            // 
            this.txtPathToEXEServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPathToEXEServer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPathToEXEServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPathToEXEServer.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPathToEXEServer.Location = new System.Drawing.Point(207, 25);
            this.txtPathToEXEServer.Name = "txtPathToEXEServer";
            this.txtPathToEXEServer.ReadOnly = true;
            this.txtPathToEXEServer.Size = new System.Drawing.Size(287, 22);
            this.txtPathToEXEServer.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtPathToEXEServer, "Path to the process executable (Arma EXE linked to above path. Unchangeable)");
            // 
            // tabPageProcessDatabase
            // 
            this.tabPageProcessDatabase.AutoScroll = true;
            this.tabPageProcessDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.tabPageProcessDatabase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageProcessDatabase.Controls.Add(this.grpConfigDatabaseBackup);
            this.tabPageProcessDatabase.Controls.Add(this.flpDatabase);
            this.tabPageProcessDatabase.Controls.Add(this.lvlDatabaseAffinity);
            this.tabPageProcessDatabase.Controls.Add(this.lblDatabasePriority);
            this.tabPageProcessDatabase.Controls.Add(this.cBoxPriorityDatabase);
            this.tabPageProcessDatabase.Controls.Add(this.btnProcessKeepaliveDatabase);
            this.tabPageProcessDatabase.Controls.Add(this.btnFortxtPathToEXEDB);
            this.tabPageProcessDatabase.Controls.Add(this.lblDatabasePathToExe);
            this.tabPageProcessDatabase.Controls.Add(this.txtPathToEXEDB);
            this.tabPageProcessDatabase.Location = new System.Drawing.Point(4, 25);
            this.tabPageProcessDatabase.Name = "tabPageProcessDatabase";
            this.tabPageProcessDatabase.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProcessDatabase.Size = new System.Drawing.Size(588, 266);
            this.tabPageProcessDatabase.TabIndex = 1;
            this.tabPageProcessDatabase.Text = "Database";
            // 
            // grpConfigDatabaseBackup
            // 
            this.grpConfigDatabaseBackup.Controls.Add(this.numBackupInterval);
            this.grpConfigDatabaseBackup.Controls.Add(this.lblDatabaseBackupInterval);
            this.grpConfigDatabaseBackup.Controls.Add(this.chkUseZipBackups);
            this.grpConfigDatabaseBackup.Controls.Add(this.btnFortxtPathToBackupFolder);
            this.grpConfigDatabaseBackup.Controls.Add(this.lblDatabaseBackupFolder);
            this.grpConfigDatabaseBackup.Controls.Add(this.txtPathToBackupFolder);
            this.grpConfigDatabaseBackup.Controls.Add(this.btnFortxtPathToDBFile);
            this.grpConfigDatabaseBackup.Controls.Add(this.lblDatabaseDumpFile);
            this.grpConfigDatabaseBackup.Controls.Add(this.txtPathToDBFile);
            this.grpConfigDatabaseBackup.ForeColor = System.Drawing.Color.White;
            this.grpConfigDatabaseBackup.Location = new System.Drawing.Point(6, 109);
            this.grpConfigDatabaseBackup.Name = "grpConfigDatabaseBackup";
            this.grpConfigDatabaseBackup.Size = new System.Drawing.Size(555, 182);
            this.grpConfigDatabaseBackup.TabIndex = 42;
            this.grpConfigDatabaseBackup.TabStop = false;
            this.grpConfigDatabaseBackup.Text = "Backup/Logging Settings";
            // 
            // numBackupInterval
            // 
            this.numBackupInterval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numBackupInterval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numBackupInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.numBackupInterval.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.numBackupInterval.Location = new System.Drawing.Point(9, 50);
            this.numBackupInterval.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numBackupInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBackupInterval.Name = "numBackupInterval";
            this.numBackupInterval.Size = new System.Drawing.Size(90, 22);
            this.numBackupInterval.TabIndex = 46;
            this.toolTip1.SetToolTip(this.numBackupInterval, "Time in Minutes to wait between database backups");
            this.numBackupInterval.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblDatabaseBackupInterval
            // 
            this.lblDatabaseBackupInterval.AutoSize = true;
            this.lblDatabaseBackupInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatabaseBackupInterval.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDatabaseBackupInterval.Location = new System.Drawing.Point(6, 30);
            this.lblDatabaseBackupInterval.Name = "lblDatabaseBackupInterval";
            this.lblDatabaseBackupInterval.Size = new System.Drawing.Size(233, 16);
            this.lblDatabaseBackupInterval.TabIndex = 44;
            this.lblDatabaseBackupInterval.Text = "Database Backup Interval (in minutes)";
            this.toolTip1.SetToolTip(this.lblDatabaseBackupInterval, "Time in Minutes to wait between database backups");
            // 
            // chkUseZipBackups
            // 
            this.chkUseZipBackups.AutoSize = true;
            this.chkUseZipBackups.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUseZipBackups.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.chkUseZipBackups.Location = new System.Drawing.Point(436, 21);
            this.chkUseZipBackups.Name = "chkUseZipBackups";
            this.chkUseZipBackups.Size = new System.Drawing.Size(110, 17);
            this.chkUseZipBackups.TabIndex = 42;
            this.chkUseZipBackups.Text = "Use ZIP Backups";
            this.toolTip1.SetToolTip(this.chkUseZipBackups, "Toggles the use of compression when archiving database backups");
            this.chkUseZipBackups.UseVisualStyleBackColor = true;
            // 
            // btnFortxtPathToBackupFolder
            // 
            this.btnFortxtPathToBackupFolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnFortxtPathToBackupFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnFortxtPathToBackupFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFortxtPathToBackupFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFortxtPathToBackupFolder.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnFortxtPathToBackupFolder.Location = new System.Drawing.Point(475, 150);
            this.btnFortxtPathToBackupFolder.Margin = new System.Windows.Forms.Padding(0);
            this.btnFortxtPathToBackupFolder.Name = "btnFortxtPathToBackupFolder";
            this.btnFortxtPathToBackupFolder.Size = new System.Drawing.Size(64, 22);
            this.btnFortxtPathToBackupFolder.TabIndex = 41;
            this.btnFortxtPathToBackupFolder.Text = "Browse";
            this.btnFortxtPathToBackupFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnFortxtPathToBackupFolder.UseVisualStyleBackColor = true;
            // 
            // lblDatabaseBackupFolder
            // 
            this.lblDatabaseBackupFolder.AutoSize = true;
            this.lblDatabaseBackupFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatabaseBackupFolder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDatabaseBackupFolder.Location = new System.Drawing.Point(6, 130);
            this.lblDatabaseBackupFolder.Name = "lblDatabaseBackupFolder";
            this.lblDatabaseBackupFolder.Size = new System.Drawing.Size(203, 16);
            this.lblDatabaseBackupFolder.TabIndex = 40;
            this.lblDatabaseBackupFolder.Text = "Path to Database Backup Folder";
            this.toolTip1.SetToolTip(this.lblDatabaseBackupFolder, "Path to archive folder where database will be backed up to");
            // 
            // txtPathToBackupFolder
            // 
            this.txtPathToBackupFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPathToBackupFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPathToBackupFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPathToBackupFolder.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPathToBackupFolder.Location = new System.Drawing.Point(9, 150);
            this.txtPathToBackupFolder.Name = "txtPathToBackupFolder";
            this.txtPathToBackupFolder.ReadOnly = true;
            this.txtPathToBackupFolder.Size = new System.Drawing.Size(463, 22);
            this.txtPathToBackupFolder.TabIndex = 39;
            this.toolTip1.SetToolTip(this.txtPathToBackupFolder, "Path to archive folder where database will be backed up to");
            // 
            // btnFortxtPathToDBFile
            // 
            this.btnFortxtPathToDBFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnFortxtPathToDBFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnFortxtPathToDBFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFortxtPathToDBFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFortxtPathToDBFile.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnFortxtPathToDBFile.Location = new System.Drawing.Point(475, 100);
            this.btnFortxtPathToDBFile.Margin = new System.Windows.Forms.Padding(0);
            this.btnFortxtPathToDBFile.Name = "btnFortxtPathToDBFile";
            this.btnFortxtPathToDBFile.Size = new System.Drawing.Size(64, 22);
            this.btnFortxtPathToDBFile.TabIndex = 38;
            this.btnFortxtPathToDBFile.Text = "Browse";
            this.btnFortxtPathToDBFile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnFortxtPathToDBFile.UseVisualStyleBackColor = true;
            // 
            // lblDatabaseDumpFile
            // 
            this.lblDatabaseDumpFile.AutoSize = true;
            this.lblDatabaseDumpFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatabaseDumpFile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDatabaseDumpFile.Location = new System.Drawing.Point(6, 80);
            this.lblDatabaseDumpFile.Name = "lblDatabaseDumpFile";
            this.lblDatabaseDumpFile.Size = new System.Drawing.Size(176, 16);
            this.lblDatabaseDumpFile.TabIndex = 37;
            this.lblDatabaseDumpFile.Text = "Path to Database Dump File";
            this.toolTip1.SetToolTip(this.lblDatabaseDumpFile, "Path to databse file to backup (Dump/Table file)");
            // 
            // txtPathToDBFile
            // 
            this.txtPathToDBFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPathToDBFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPathToDBFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPathToDBFile.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPathToDBFile.Location = new System.Drawing.Point(9, 100);
            this.txtPathToDBFile.Name = "txtPathToDBFile";
            this.txtPathToDBFile.ReadOnly = true;
            this.txtPathToDBFile.Size = new System.Drawing.Size(463, 22);
            this.txtPathToDBFile.TabIndex = 36;
            this.toolTip1.SetToolTip(this.txtPathToDBFile, "Path to databse file to backup (Dump/Table file)");
            // 
            // flpDatabase
            // 
            this.flpDatabase.AutoScroll = true;
            this.flpDatabase.Location = new System.Drawing.Point(207, 69);
            this.flpDatabase.Name = "flpDatabase";
            this.flpDatabase.Size = new System.Drawing.Size(354, 49);
            this.flpDatabase.TabIndex = 42;
            this.flpDatabase.WrapContents = false;
            // 
            // lvlDatabaseAffinity
            // 
            this.lvlDatabaseAffinity.AutoSize = true;
            this.lvlDatabaseAffinity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlDatabaseAffinity.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lvlDatabaseAffinity.Location = new System.Drawing.Point(204, 50);
            this.lvlDatabaseAffinity.Name = "lvlDatabaseAffinity";
            this.lvlDatabaseAffinity.Size = new System.Drawing.Size(144, 16);
            this.lvlDatabaseAffinity.TabIndex = 32;
            this.lvlDatabaseAffinity.Text = "Process Affinity (cores)";
            this.toolTip1.SetToolTip(this.lvlDatabaseAffinity, "Process EXE Affinity. The cores with which this process can utilize.");
            // 
            // lblDatabasePriority
            // 
            this.lblDatabasePriority.AutoSize = true;
            this.lblDatabasePriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatabasePriority.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDatabasePriority.Location = new System.Drawing.Point(3, 58);
            this.lblDatabasePriority.Name = "lblDatabasePriority";
            this.lblDatabasePriority.Size = new System.Drawing.Size(102, 16);
            this.lblDatabasePriority.TabIndex = 31;
            this.lblDatabasePriority.Text = "Process Priority";
            this.toolTip1.SetToolTip(this.lblDatabasePriority, "Process Priority (Only change if you notice a performance change when doing so)");
            // 
            // cBoxPriorityDatabase
            // 
            this.cBoxPriorityDatabase.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.cBoxPriorityDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cBoxPriorityDatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxPriorityDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxPriorityDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxPriorityDatabase.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.cBoxPriorityDatabase.FormattingEnabled = true;
            this.cBoxPriorityDatabase.Items.AddRange(new object[] {
            "Realtime",
            "High",
            "AboveNormal",
            "Normal",
            "BelowNormal",
            "Low"});
            this.cBoxPriorityDatabase.Location = new System.Drawing.Point(6, 77);
            this.cBoxPriorityDatabase.Name = "cBoxPriorityDatabase";
            this.cBoxPriorityDatabase.Size = new System.Drawing.Size(184, 24);
            this.cBoxPriorityDatabase.TabIndex = 30;
            this.toolTip1.SetToolTip(this.cBoxPriorityDatabase, "Process Priority (Only change if you notice a performance change when doing so)");
            this.cBoxPriorityDatabase.SelectedIndexChanged += new System.EventHandler(this.actionPriorityChanged);
            // 
            // btnProcessKeepaliveDatabase
            // 
            this.btnProcessKeepaliveDatabase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnProcessKeepaliveDatabase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnProcessKeepaliveDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessKeepaliveDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessKeepaliveDatabase.ForeColor = System.Drawing.Color.Green;
            this.btnProcessKeepaliveDatabase.Location = new System.Drawing.Point(6, 6);
            this.btnProcessKeepaliveDatabase.Name = "btnProcessKeepaliveDatabase";
            this.btnProcessKeepaliveDatabase.Size = new System.Drawing.Size(184, 41);
            this.btnProcessKeepaliveDatabase.TabIndex = 29;
            this.btnProcessKeepaliveDatabase.Text = "Keep Process Alive";
            this.toolTip1.SetToolTip(this.btnProcessKeepaliveDatabase, "Toggle the keepalive for this process.");
            this.btnProcessKeepaliveDatabase.UseVisualStyleBackColor = true;
            this.btnProcessKeepaliveDatabase.Click += new System.EventHandler(this.actionProcessKeepaliveToggle);
            this.btnProcessKeepaliveDatabase.Leave += new System.EventHandler(this.evntKeepProcessAlive_Leave);
            this.btnProcessKeepaliveDatabase.MouseLeave += new System.EventHandler(this.evntKeepProcessAlive_MouseLeave);
            this.btnProcessKeepaliveDatabase.MouseMove += new System.Windows.Forms.MouseEventHandler(this.evntKeepProcessAlive_MouseMove);
            // 
            // btnFortxtPathToEXEDB
            // 
            this.btnFortxtPathToEXEDB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnFortxtPathToEXEDB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnFortxtPathToEXEDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFortxtPathToEXEDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFortxtPathToEXEDB.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnFortxtPathToEXEDB.Location = new System.Drawing.Point(497, 25);
            this.btnFortxtPathToEXEDB.Margin = new System.Windows.Forms.Padding(0);
            this.btnFortxtPathToEXEDB.Name = "btnFortxtPathToEXEDB";
            this.btnFortxtPathToEXEDB.Size = new System.Drawing.Size(64, 22);
            this.btnFortxtPathToEXEDB.TabIndex = 28;
            this.btnFortxtPathToEXEDB.Text = "Browse";
            this.btnFortxtPathToEXEDB.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnFortxtPathToEXEDB.UseVisualStyleBackColor = true;
            this.btnFortxtPathToEXEDB.Click += new System.EventHandler(this.actionBrowseButtonForFilePath);
            // 
            // lblDatabasePathToExe
            // 
            this.lblDatabasePathToExe.AutoSize = true;
            this.lblDatabasePathToExe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatabasePathToExe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDatabasePathToExe.Location = new System.Drawing.Point(204, 6);
            this.lblDatabasePathToExe.Name = "lblDatabasePathToExe";
            this.lblDatabasePathToExe.Size = new System.Drawing.Size(119, 16);
            this.lblDatabasePathToExe.TabIndex = 27;
            this.lblDatabasePathToExe.Text = "Path to Executable";
            this.toolTip1.SetToolTip(this.lblDatabasePathToExe, "Full path to process executable");
            // 
            // txtPathToEXEDB
            // 
            this.txtPathToEXEDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPathToEXEDB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPathToEXEDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPathToEXEDB.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPathToEXEDB.Location = new System.Drawing.Point(207, 25);
            this.txtPathToEXEDB.Name = "txtPathToEXEDB";
            this.txtPathToEXEDB.ReadOnly = true;
            this.txtPathToEXEDB.Size = new System.Drawing.Size(287, 22);
            this.txtPathToEXEDB.TabIndex = 26;
            this.toolTip1.SetToolTip(this.txtPathToEXEDB, "Full path to process executable");
            // 
            // tabPageProcessBEC
            // 
            this.tabPageProcessBEC.AutoScroll = true;
            this.tabPageProcessBEC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.tabPageProcessBEC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageProcessBEC.Controls.Add(this.grpConfigBECBackup);
            this.tabPageProcessBEC.Controls.Add(this.flpBEC);
            this.tabPageProcessBEC.Controls.Add(this.lblBECAffinity);
            this.tabPageProcessBEC.Controls.Add(this.lblBECPriority);
            this.tabPageProcessBEC.Controls.Add(this.cBoxPriorityBEC);
            this.tabPageProcessBEC.Controls.Add(this.btnProcessKeepaliveBEC);
            this.tabPageProcessBEC.Controls.Add(this.btnFortxtPathToEXEBEC);
            this.tabPageProcessBEC.Controls.Add(this.lblBECPathToExe);
            this.tabPageProcessBEC.Controls.Add(this.txtPathToEXEBEC);
            this.tabPageProcessBEC.Location = new System.Drawing.Point(4, 25);
            this.tabPageProcessBEC.Name = "tabPageProcessBEC";
            this.tabPageProcessBEC.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProcessBEC.Size = new System.Drawing.Size(588, 266);
            this.tabPageProcessBEC.TabIndex = 2;
            this.tabPageProcessBEC.Text = "BEC Process";
            // 
            // grpConfigBECBackup
            // 
            this.grpConfigBECBackup.Controls.Add(this.chkBecUseDsc);
            this.grpConfigBECBackup.Controls.Add(this.txtPathToBattleye);
            this.grpConfigBECBackup.Controls.Add(this.btnFortxtPathToBattleye);
            this.grpConfigBECBackup.Controls.Add(this.lblBECBEPath);
            this.grpConfigBECBackup.ForeColor = System.Drawing.Color.White;
            this.grpConfigBECBackup.Location = new System.Drawing.Point(6, 109);
            this.grpConfigBECBackup.Name = "grpConfigBECBackup";
            this.grpConfigBECBackup.Size = new System.Drawing.Size(555, 80);
            this.grpConfigBECBackup.TabIndex = 46;
            this.grpConfigBECBackup.TabStop = false;
            this.grpConfigBECBackup.Text = "Backup/Logging Settings";
            // 
            // chkBecUseDsc
            // 
            this.chkBecUseDsc.AutoSize = true;
            this.chkBecUseDsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBecUseDsc.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.chkBecUseDsc.Location = new System.Drawing.Point(436, 21);
            this.chkBecUseDsc.Name = "chkBecUseDsc";
            this.chkBecUseDsc.Size = new System.Drawing.Size(104, 17);
            this.chkBecUseDsc.TabIndex = 45;
            this.chkBecUseDsc.Text = "Use DSC Option";
            this.toolTip1.SetToolTip(this.chkBecUseDsc, "Enables to --DSC flag when launching BEC to prevent auto-closing too soon");
            this.chkBecUseDsc.UseVisualStyleBackColor = true;
            // 
            // txtPathToBattleye
            // 
            this.txtPathToBattleye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPathToBattleye.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPathToBattleye.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPathToBattleye.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPathToBattleye.Location = new System.Drawing.Point(9, 50);
            this.txtPathToBattleye.Name = "txtPathToBattleye";
            this.txtPathToBattleye.ReadOnly = true;
            this.txtPathToBattleye.Size = new System.Drawing.Size(463, 22);
            this.txtPathToBattleye.TabIndex = 42;
            this.toolTip1.SetToolTip(this.txtPathToBattleye, "Full path to the folder containing the battleye logs and filters");
            // 
            // btnFortxtPathToBattleye
            // 
            this.btnFortxtPathToBattleye.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnFortxtPathToBattleye.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnFortxtPathToBattleye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFortxtPathToBattleye.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFortxtPathToBattleye.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnFortxtPathToBattleye.Location = new System.Drawing.Point(475, 50);
            this.btnFortxtPathToBattleye.Margin = new System.Windows.Forms.Padding(0);
            this.btnFortxtPathToBattleye.Name = "btnFortxtPathToBattleye";
            this.btnFortxtPathToBattleye.Size = new System.Drawing.Size(64, 22);
            this.btnFortxtPathToBattleye.TabIndex = 44;
            this.btnFortxtPathToBattleye.Text = "Browse";
            this.btnFortxtPathToBattleye.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnFortxtPathToBattleye.UseVisualStyleBackColor = true;
            // 
            // lblBECBEPath
            // 
            this.lblBECBEPath.AutoSize = true;
            this.lblBECBEPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBECBEPath.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBECBEPath.Location = new System.Drawing.Point(6, 30);
            this.lblBECBEPath.Name = "lblBECBEPath";
            this.lblBECBEPath.Size = new System.Drawing.Size(214, 16);
            this.lblBECBEPath.TabIndex = 43;
            this.lblBECBEPath.Text = "Path to Battleye Scripts/Log Folder";
            this.toolTip1.SetToolTip(this.lblBECBEPath, "Full path to the folder containing the battleye logs and filters");
            // 
            // flpBEC
            // 
            this.flpBEC.AutoScroll = true;
            this.flpBEC.Location = new System.Drawing.Point(207, 69);
            this.flpBEC.Name = "flpBEC";
            this.flpBEC.Size = new System.Drawing.Size(354, 49);
            this.flpBEC.TabIndex = 46;
            this.flpBEC.WrapContents = false;
            // 
            // lblBECAffinity
            // 
            this.lblBECAffinity.AutoSize = true;
            this.lblBECAffinity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBECAffinity.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBECAffinity.Location = new System.Drawing.Point(204, 50);
            this.lblBECAffinity.Name = "lblBECAffinity";
            this.lblBECAffinity.Size = new System.Drawing.Size(144, 16);
            this.lblBECAffinity.TabIndex = 32;
            this.lblBECAffinity.Text = "Process Affinity (cores)";
            this.toolTip1.SetToolTip(this.lblBECAffinity, "Process EXE Affinity. The cores with which this process can utilize.");
            // 
            // lblBECPriority
            // 
            this.lblBECPriority.AutoSize = true;
            this.lblBECPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBECPriority.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBECPriority.Location = new System.Drawing.Point(3, 58);
            this.lblBECPriority.Name = "lblBECPriority";
            this.lblBECPriority.Size = new System.Drawing.Size(102, 16);
            this.lblBECPriority.TabIndex = 31;
            this.lblBECPriority.Text = "Process Priority";
            this.toolTip1.SetToolTip(this.lblBECPriority, "Process Priority (Only change if you notice a performance change when doing so)");
            // 
            // cBoxPriorityBEC
            // 
            this.cBoxPriorityBEC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.cBoxPriorityBEC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cBoxPriorityBEC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxPriorityBEC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxPriorityBEC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxPriorityBEC.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.cBoxPriorityBEC.FormattingEnabled = true;
            this.cBoxPriorityBEC.Items.AddRange(new object[] {
            "Realtime",
            "High",
            "AboveNormal",
            "Normal",
            "BelowNormal",
            "Low"});
            this.cBoxPriorityBEC.Location = new System.Drawing.Point(6, 77);
            this.cBoxPriorityBEC.Name = "cBoxPriorityBEC";
            this.cBoxPriorityBEC.Size = new System.Drawing.Size(184, 24);
            this.cBoxPriorityBEC.TabIndex = 30;
            this.toolTip1.SetToolTip(this.cBoxPriorityBEC, "Process Priority (Only change if you notice a performance change when doing so)");
            this.cBoxPriorityBEC.SelectedIndexChanged += new System.EventHandler(this.actionPriorityChanged);
            // 
            // btnProcessKeepaliveBEC
            // 
            this.btnProcessKeepaliveBEC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnProcessKeepaliveBEC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnProcessKeepaliveBEC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessKeepaliveBEC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessKeepaliveBEC.ForeColor = System.Drawing.Color.Green;
            this.btnProcessKeepaliveBEC.Location = new System.Drawing.Point(6, 6);
            this.btnProcessKeepaliveBEC.Name = "btnProcessKeepaliveBEC";
            this.btnProcessKeepaliveBEC.Size = new System.Drawing.Size(184, 41);
            this.btnProcessKeepaliveBEC.TabIndex = 29;
            this.btnProcessKeepaliveBEC.Text = "Keep Process Alive";
            this.toolTip1.SetToolTip(this.btnProcessKeepaliveBEC, "Toggle the keepalive for this process.");
            this.btnProcessKeepaliveBEC.UseVisualStyleBackColor = true;
            this.btnProcessKeepaliveBEC.Click += new System.EventHandler(this.actionProcessKeepaliveToggle);
            this.btnProcessKeepaliveBEC.Leave += new System.EventHandler(this.evntKeepProcessAlive_Leave);
            this.btnProcessKeepaliveBEC.MouseLeave += new System.EventHandler(this.evntKeepProcessAlive_MouseLeave);
            this.btnProcessKeepaliveBEC.MouseMove += new System.Windows.Forms.MouseEventHandler(this.evntKeepProcessAlive_MouseMove);
            // 
            // btnFortxtPathToEXEBEC
            // 
            this.btnFortxtPathToEXEBEC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnFortxtPathToEXEBEC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnFortxtPathToEXEBEC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFortxtPathToEXEBEC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFortxtPathToEXEBEC.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnFortxtPathToEXEBEC.Location = new System.Drawing.Point(497, 25);
            this.btnFortxtPathToEXEBEC.Margin = new System.Windows.Forms.Padding(0);
            this.btnFortxtPathToEXEBEC.Name = "btnFortxtPathToEXEBEC";
            this.btnFortxtPathToEXEBEC.Size = new System.Drawing.Size(64, 22);
            this.btnFortxtPathToEXEBEC.TabIndex = 28;
            this.btnFortxtPathToEXEBEC.Text = "Browse";
            this.btnFortxtPathToEXEBEC.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnFortxtPathToEXEBEC.UseVisualStyleBackColor = true;
            this.btnFortxtPathToEXEBEC.Click += new System.EventHandler(this.actionBrowseButtonForFilePath);
            // 
            // lblBECPathToExe
            // 
            this.lblBECPathToExe.AutoSize = true;
            this.lblBECPathToExe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBECPathToExe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBECPathToExe.Location = new System.Drawing.Point(204, 6);
            this.lblBECPathToExe.Name = "lblBECPathToExe";
            this.lblBECPathToExe.Size = new System.Drawing.Size(119, 16);
            this.lblBECPathToExe.TabIndex = 27;
            this.lblBECPathToExe.Text = "Path to Executable";
            this.toolTip1.SetToolTip(this.lblBECPathToExe, "Full path to process executable");
            // 
            // txtPathToEXEBEC
            // 
            this.txtPathToEXEBEC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPathToEXEBEC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPathToEXEBEC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPathToEXEBEC.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPathToEXEBEC.Location = new System.Drawing.Point(207, 25);
            this.txtPathToEXEBEC.Name = "txtPathToEXEBEC";
            this.txtPathToEXEBEC.ReadOnly = true;
            this.txtPathToEXEBEC.Size = new System.Drawing.Size(287, 22);
            this.txtPathToEXEBEC.TabIndex = 26;
            this.toolTip1.SetToolTip(this.txtPathToEXEBEC, "Full path to process executable");
            // 
            // tabPageProcessHC
            // 
            this.tabPageProcessHC.AutoScroll = true;
            this.tabPageProcessHC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.tabPageProcessHC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageProcessHC.Controls.Add(this.grpConfigHCLaunch);
            this.tabPageProcessHC.Controls.Add(this.flpHeadlessClient);
            this.tabPageProcessHC.Controls.Add(this.lblHCAffinity);
            this.tabPageProcessHC.Controls.Add(this.lblHCPriority);
            this.tabPageProcessHC.Controls.Add(this.cBoxPriorityHeadlessClient);
            this.tabPageProcessHC.Controls.Add(this.btnProcessKeepaliveHC);
            this.tabPageProcessHC.Controls.Add(this.btnFortxtPathToEXEHC);
            this.tabPageProcessHC.Controls.Add(this.lblHCPathToExe);
            this.tabPageProcessHC.Controls.Add(this.txtPathToEXEHC);
            this.tabPageProcessHC.Location = new System.Drawing.Point(4, 25);
            this.tabPageProcessHC.Name = "tabPageProcessHC";
            this.tabPageProcessHC.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProcessHC.Size = new System.Drawing.Size(588, 266);
            this.tabPageProcessHC.TabIndex = 3;
            this.tabPageProcessHC.Text = "Headless Client";
            // 
            // grpConfigHCLaunch
            // 
            this.grpConfigHCLaunch.Controls.Add(this.lblHCLaunchArgs);
            this.grpConfigHCLaunch.Controls.Add(this.txtHeadlessClientLaunchArgs);
            this.grpConfigHCLaunch.ForeColor = System.Drawing.Color.White;
            this.grpConfigHCLaunch.Location = new System.Drawing.Point(6, 109);
            this.grpConfigHCLaunch.Name = "grpConfigHCLaunch";
            this.grpConfigHCLaunch.Size = new System.Drawing.Size(555, 80);
            this.grpConfigHCLaunch.TabIndex = 47;
            this.grpConfigHCLaunch.TabStop = false;
            this.grpConfigHCLaunch.Text = "Launch Parameters";
            // 
            // lblHCLaunchArgs
            // 
            this.lblHCLaunchArgs.AutoSize = true;
            this.lblHCLaunchArgs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHCLaunchArgs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHCLaunchArgs.Location = new System.Drawing.Point(6, 30);
            this.lblHCLaunchArgs.Name = "lblHCLaunchArgs";
            this.lblHCLaunchArgs.Size = new System.Drawing.Size(216, 16);
            this.lblHCLaunchArgs.TabIndex = 41;
            this.lblHCLaunchArgs.Text = "Headless Client Launch Arguments";
            this.toolTip1.SetToolTip(this.lblHCLaunchArgs, "Custom launch parameters for the Headless Client");
            // 
            // txtHeadlessClientLaunchArgs
            // 
            this.txtHeadlessClientLaunchArgs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHeadlessClientLaunchArgs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHeadlessClientLaunchArgs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeadlessClientLaunchArgs.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtHeadlessClientLaunchArgs.Location = new System.Drawing.Point(9, 50);
            this.txtHeadlessClientLaunchArgs.Name = "txtHeadlessClientLaunchArgs";
            this.txtHeadlessClientLaunchArgs.Size = new System.Drawing.Size(530, 22);
            this.txtHeadlessClientLaunchArgs.TabIndex = 42;
            this.toolTip1.SetToolTip(this.txtHeadlessClientLaunchArgs, "Custom launch parameters for the Headless Client");
            // 
            // flpHeadlessClient
            // 
            this.flpHeadlessClient.AutoScroll = true;
            this.flpHeadlessClient.Location = new System.Drawing.Point(207, 69);
            this.flpHeadlessClient.Name = "flpHeadlessClient";
            this.flpHeadlessClient.Size = new System.Drawing.Size(354, 49);
            this.flpHeadlessClient.TabIndex = 47;
            this.flpHeadlessClient.WrapContents = false;
            // 
            // lblHCAffinity
            // 
            this.lblHCAffinity.AutoSize = true;
            this.lblHCAffinity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHCAffinity.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHCAffinity.Location = new System.Drawing.Point(204, 50);
            this.lblHCAffinity.Name = "lblHCAffinity";
            this.lblHCAffinity.Size = new System.Drawing.Size(144, 16);
            this.lblHCAffinity.TabIndex = 32;
            this.lblHCAffinity.Text = "Process Affinity (cores)";
            this.toolTip1.SetToolTip(this.lblHCAffinity, "Process EXE Affinity. The cores with which this process can utilize.");
            // 
            // lblHCPriority
            // 
            this.lblHCPriority.AutoSize = true;
            this.lblHCPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHCPriority.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHCPriority.Location = new System.Drawing.Point(3, 58);
            this.lblHCPriority.Name = "lblHCPriority";
            this.lblHCPriority.Size = new System.Drawing.Size(102, 16);
            this.lblHCPriority.TabIndex = 31;
            this.lblHCPriority.Text = "Process Priority";
            this.toolTip1.SetToolTip(this.lblHCPriority, "Process Priority (Only change if you notice a performance change when doing so)");
            // 
            // cBoxPriorityHeadlessClient
            // 
            this.cBoxPriorityHeadlessClient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.cBoxPriorityHeadlessClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cBoxPriorityHeadlessClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxPriorityHeadlessClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxPriorityHeadlessClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxPriorityHeadlessClient.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.cBoxPriorityHeadlessClient.FormattingEnabled = true;
            this.cBoxPriorityHeadlessClient.Items.AddRange(new object[] {
            "Realtime",
            "High",
            "AboveNormal",
            "Normal",
            "BelowNormal",
            "Low"});
            this.cBoxPriorityHeadlessClient.Location = new System.Drawing.Point(6, 77);
            this.cBoxPriorityHeadlessClient.Name = "cBoxPriorityHeadlessClient";
            this.cBoxPriorityHeadlessClient.Size = new System.Drawing.Size(184, 24);
            this.cBoxPriorityHeadlessClient.TabIndex = 30;
            this.toolTip1.SetToolTip(this.cBoxPriorityHeadlessClient, "Process Priority (Only change if you notice a performance change when doing so)");
            this.cBoxPriorityHeadlessClient.SelectedIndexChanged += new System.EventHandler(this.actionPriorityChanged);
            // 
            // btnProcessKeepaliveHC
            // 
            this.btnProcessKeepaliveHC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnProcessKeepaliveHC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnProcessKeepaliveHC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessKeepaliveHC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessKeepaliveHC.ForeColor = System.Drawing.Color.Green;
            this.btnProcessKeepaliveHC.Location = new System.Drawing.Point(6, 6);
            this.btnProcessKeepaliveHC.Name = "btnProcessKeepaliveHC";
            this.btnProcessKeepaliveHC.Size = new System.Drawing.Size(184, 41);
            this.btnProcessKeepaliveHC.TabIndex = 29;
            this.btnProcessKeepaliveHC.Text = "Keep Process Alive";
            this.toolTip1.SetToolTip(this.btnProcessKeepaliveHC, "Toggle the keepalive for this process.");
            this.btnProcessKeepaliveHC.UseVisualStyleBackColor = true;
            this.btnProcessKeepaliveHC.Click += new System.EventHandler(this.actionProcessKeepaliveToggle);
            this.btnProcessKeepaliveHC.Leave += new System.EventHandler(this.evntKeepProcessAlive_Leave);
            this.btnProcessKeepaliveHC.MouseLeave += new System.EventHandler(this.evntKeepProcessAlive_MouseLeave);
            this.btnProcessKeepaliveHC.MouseMove += new System.Windows.Forms.MouseEventHandler(this.evntKeepProcessAlive_MouseMove);
            // 
            // btnFortxtPathToEXEHC
            // 
            this.btnFortxtPathToEXEHC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnFortxtPathToEXEHC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnFortxtPathToEXEHC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFortxtPathToEXEHC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFortxtPathToEXEHC.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnFortxtPathToEXEHC.Location = new System.Drawing.Point(497, 25);
            this.btnFortxtPathToEXEHC.Margin = new System.Windows.Forms.Padding(0);
            this.btnFortxtPathToEXEHC.Name = "btnFortxtPathToEXEHC";
            this.btnFortxtPathToEXEHC.Size = new System.Drawing.Size(64, 22);
            this.btnFortxtPathToEXEHC.TabIndex = 28;
            this.btnFortxtPathToEXEHC.Text = "Browse";
            this.btnFortxtPathToEXEHC.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnFortxtPathToEXEHC.UseVisualStyleBackColor = true;
            this.btnFortxtPathToEXEHC.Click += new System.EventHandler(this.actionBrowseButtonForFilePath);
            // 
            // lblHCPathToExe
            // 
            this.lblHCPathToExe.AutoSize = true;
            this.lblHCPathToExe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHCPathToExe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHCPathToExe.Location = new System.Drawing.Point(204, 6);
            this.lblHCPathToExe.Name = "lblHCPathToExe";
            this.lblHCPathToExe.Size = new System.Drawing.Size(119, 16);
            this.lblHCPathToExe.TabIndex = 27;
            this.lblHCPathToExe.Text = "Path to Executable";
            this.toolTip1.SetToolTip(this.lblHCPathToExe, "Full path to process executable");
            // 
            // txtPathToEXEHC
            // 
            this.txtPathToEXEHC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPathToEXEHC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPathToEXEHC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPathToEXEHC.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPathToEXEHC.Location = new System.Drawing.Point(207, 25);
            this.txtPathToEXEHC.Name = "txtPathToEXEHC";
            this.txtPathToEXEHC.ReadOnly = true;
            this.txtPathToEXEHC.Size = new System.Drawing.Size(287, 22);
            this.txtPathToEXEHC.TabIndex = 26;
            this.toolTip1.SetToolTip(this.txtPathToEXEHC, "Full path to process executable");
            // 
            // tabPageProcessTS
            // 
            this.tabPageProcessTS.AutoScroll = true;
            this.tabPageProcessTS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.tabPageProcessTS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageProcessTS.Controls.Add(this.grpconfigTeamspeakLaunch);
            this.tabPageProcessTS.Controls.Add(this.flpTeamspeak);
            this.tabPageProcessTS.Controls.Add(this.lblTSAffinity);
            this.tabPageProcessTS.Controls.Add(this.lblTSPriority);
            this.tabPageProcessTS.Controls.Add(this.cBoxPriorityTeamspeak);
            this.tabPageProcessTS.Controls.Add(this.btnProcessKeepaliveTS);
            this.tabPageProcessTS.Controls.Add(this.btnFortxtPathToEXETS);
            this.tabPageProcessTS.Controls.Add(this.lblTSPathToExe);
            this.tabPageProcessTS.Controls.Add(this.txtPathToEXETS);
            this.tabPageProcessTS.Location = new System.Drawing.Point(4, 25);
            this.tabPageProcessTS.Name = "tabPageProcessTS";
            this.tabPageProcessTS.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProcessTS.Size = new System.Drawing.Size(588, 266);
            this.tabPageProcessTS.TabIndex = 4;
            this.tabPageProcessTS.Text = "Teamspeak";
            // 
            // grpconfigTeamspeakLaunch
            // 
            this.grpconfigTeamspeakLaunch.Controls.Add(this.numTeamspeakPortNumber);
            this.grpconfigTeamspeakLaunch.Controls.Add(this.lblTSPort);
            this.grpconfigTeamspeakLaunch.ForeColor = System.Drawing.Color.White;
            this.grpconfigTeamspeakLaunch.Location = new System.Drawing.Point(6, 109);
            this.grpconfigTeamspeakLaunch.Name = "grpconfigTeamspeakLaunch";
            this.grpconfigTeamspeakLaunch.Size = new System.Drawing.Size(555, 80);
            this.grpconfigTeamspeakLaunch.TabIndex = 46;
            this.grpconfigTeamspeakLaunch.TabStop = false;
            this.grpconfigTeamspeakLaunch.Text = "Launch Parameters";
            // 
            // numTeamspeakPortNumber
            // 
            this.numTeamspeakPortNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numTeamspeakPortNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numTeamspeakPortNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.numTeamspeakPortNumber.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.numTeamspeakPortNumber.Location = new System.Drawing.Point(9, 50);
            this.numTeamspeakPortNumber.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numTeamspeakPortNumber.Minimum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.numTeamspeakPortNumber.Name = "numTeamspeakPortNumber";
            this.numTeamspeakPortNumber.Size = new System.Drawing.Size(102, 22);
            this.numTeamspeakPortNumber.TabIndex = 45;
            this.toolTip1.SetToolTip(this.numTeamspeakPortNumber, "Port number for use with teamspeak server");
            this.numTeamspeakPortNumber.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            // 
            // lblTSPort
            // 
            this.lblTSPort.AutoSize = true;
            this.lblTSPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTSPort.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTSPort.Location = new System.Drawing.Point(6, 30);
            this.lblTSPort.Name = "lblTSPort";
            this.lblTSPort.Size = new System.Drawing.Size(160, 16);
            this.lblTSPort.TabIndex = 43;
            this.lblTSPort.Text = "Teamspeak Port Number";
            this.toolTip1.SetToolTip(this.lblTSPort, "Port number for use with teamspeak server");
            // 
            // flpTeamspeak
            // 
            this.flpTeamspeak.AutoScroll = true;
            this.flpTeamspeak.Location = new System.Drawing.Point(207, 69);
            this.flpTeamspeak.Name = "flpTeamspeak";
            this.flpTeamspeak.Size = new System.Drawing.Size(354, 49);
            this.flpTeamspeak.TabIndex = 46;
            this.flpTeamspeak.WrapContents = false;
            // 
            // lblTSAffinity
            // 
            this.lblTSAffinity.AutoSize = true;
            this.lblTSAffinity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTSAffinity.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTSAffinity.Location = new System.Drawing.Point(204, 50);
            this.lblTSAffinity.Name = "lblTSAffinity";
            this.lblTSAffinity.Size = new System.Drawing.Size(144, 16);
            this.lblTSAffinity.TabIndex = 32;
            this.lblTSAffinity.Text = "Process Affinity (cores)";
            this.toolTip1.SetToolTip(this.lblTSAffinity, "Process EXE Affinity. The cores with which this process can utilize.");
            // 
            // lblTSPriority
            // 
            this.lblTSPriority.AutoSize = true;
            this.lblTSPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTSPriority.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTSPriority.Location = new System.Drawing.Point(3, 58);
            this.lblTSPriority.Name = "lblTSPriority";
            this.lblTSPriority.Size = new System.Drawing.Size(102, 16);
            this.lblTSPriority.TabIndex = 31;
            this.lblTSPriority.Text = "Process Priority";
            this.toolTip1.SetToolTip(this.lblTSPriority, "Process Priority (Only change if you notice a performance change when doing so)");
            // 
            // cBoxPriorityTeamspeak
            // 
            this.cBoxPriorityTeamspeak.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.cBoxPriorityTeamspeak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cBoxPriorityTeamspeak.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxPriorityTeamspeak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxPriorityTeamspeak.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxPriorityTeamspeak.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.cBoxPriorityTeamspeak.FormattingEnabled = true;
            this.cBoxPriorityTeamspeak.Items.AddRange(new object[] {
            "Realtime",
            "High",
            "AboveNormal",
            "Normal",
            "BelowNormal",
            "Low"});
            this.cBoxPriorityTeamspeak.Location = new System.Drawing.Point(6, 77);
            this.cBoxPriorityTeamspeak.Name = "cBoxPriorityTeamspeak";
            this.cBoxPriorityTeamspeak.Size = new System.Drawing.Size(184, 24);
            this.cBoxPriorityTeamspeak.TabIndex = 30;
            this.toolTip1.SetToolTip(this.cBoxPriorityTeamspeak, "Process Priority (Only change if you notice a performance change when doing so)");
            this.cBoxPriorityTeamspeak.SelectedIndexChanged += new System.EventHandler(this.actionPriorityChanged);
            // 
            // btnProcessKeepaliveTS
            // 
            this.btnProcessKeepaliveTS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnProcessKeepaliveTS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnProcessKeepaliveTS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessKeepaliveTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessKeepaliveTS.ForeColor = System.Drawing.Color.Green;
            this.btnProcessKeepaliveTS.Location = new System.Drawing.Point(6, 6);
            this.btnProcessKeepaliveTS.Name = "btnProcessKeepaliveTS";
            this.btnProcessKeepaliveTS.Size = new System.Drawing.Size(184, 41);
            this.btnProcessKeepaliveTS.TabIndex = 29;
            this.btnProcessKeepaliveTS.Text = "Keep Process Alive";
            this.toolTip1.SetToolTip(this.btnProcessKeepaliveTS, "Toggle the keepalive for this process.");
            this.btnProcessKeepaliveTS.UseVisualStyleBackColor = true;
            this.btnProcessKeepaliveTS.Click += new System.EventHandler(this.actionProcessKeepaliveToggle);
            this.btnProcessKeepaliveTS.Leave += new System.EventHandler(this.evntKeepProcessAlive_Leave);
            this.btnProcessKeepaliveTS.MouseLeave += new System.EventHandler(this.evntKeepProcessAlive_MouseLeave);
            this.btnProcessKeepaliveTS.MouseMove += new System.Windows.Forms.MouseEventHandler(this.evntKeepProcessAlive_MouseMove);
            // 
            // btnFortxtPathToEXETS
            // 
            this.btnFortxtPathToEXETS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnFortxtPathToEXETS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnFortxtPathToEXETS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFortxtPathToEXETS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFortxtPathToEXETS.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnFortxtPathToEXETS.Location = new System.Drawing.Point(497, 25);
            this.btnFortxtPathToEXETS.Margin = new System.Windows.Forms.Padding(0);
            this.btnFortxtPathToEXETS.Name = "btnFortxtPathToEXETS";
            this.btnFortxtPathToEXETS.Size = new System.Drawing.Size(64, 22);
            this.btnFortxtPathToEXETS.TabIndex = 28;
            this.btnFortxtPathToEXETS.Text = "Browse";
            this.btnFortxtPathToEXETS.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnFortxtPathToEXETS.UseVisualStyleBackColor = true;
            this.btnFortxtPathToEXETS.Click += new System.EventHandler(this.actionBrowseButtonForFilePath);
            // 
            // lblTSPathToExe
            // 
            this.lblTSPathToExe.AutoSize = true;
            this.lblTSPathToExe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTSPathToExe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTSPathToExe.Location = new System.Drawing.Point(204, 6);
            this.lblTSPathToExe.Name = "lblTSPathToExe";
            this.lblTSPathToExe.Size = new System.Drawing.Size(119, 16);
            this.lblTSPathToExe.TabIndex = 27;
            this.lblTSPathToExe.Text = "Path to Executable";
            this.toolTip1.SetToolTip(this.lblTSPathToExe, "Full path to process executable");
            // 
            // txtPathToEXETS
            // 
            this.txtPathToEXETS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPathToEXETS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPathToEXETS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPathToEXETS.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPathToEXETS.Location = new System.Drawing.Point(207, 25);
            this.txtPathToEXETS.Name = "txtPathToEXETS";
            this.txtPathToEXETS.ReadOnly = true;
            this.txtPathToEXETS.Size = new System.Drawing.Size(287, 22);
            this.txtPathToEXETS.TabIndex = 26;
            this.toolTip1.SetToolTip(this.txtPathToEXETS, "Full path to process executable");
            // 
            // tabPageProcessASM
            // 
            this.tabPageProcessASM.AutoScroll = true;
            this.tabPageProcessASM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.tabPageProcessASM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageProcessASM.Controls.Add(this.grpConfigASMLaunch);
            this.tabPageProcessASM.Controls.Add(this.flpASM);
            this.tabPageProcessASM.Controls.Add(this.lblASMAffinity);
            this.tabPageProcessASM.Controls.Add(this.lblASMPriority);
            this.tabPageProcessASM.Controls.Add(this.cBoxPriorityASM);
            this.tabPageProcessASM.Controls.Add(this.btnProcessKeepaliveASM);
            this.tabPageProcessASM.Controls.Add(this.btnFortxtPathToEXEASM);
            this.tabPageProcessASM.Controls.Add(this.lblASMPathToExe);
            this.tabPageProcessASM.Controls.Add(this.txtPathToEXEASM);
            this.tabPageProcessASM.Location = new System.Drawing.Point(4, 25);
            this.tabPageProcessASM.Name = "tabPageProcessASM";
            this.tabPageProcessASM.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProcessASM.Size = new System.Drawing.Size(588, 266);
            this.tabPageProcessASM.TabIndex = 5;
            this.tabPageProcessASM.Text = "ASM";
            // 
            // grpConfigASMLaunch
            // 
            this.grpConfigASMLaunch.Controls.Add(this.numASMLogInterval);
            this.grpConfigASMLaunch.Controls.Add(this.btnFortxtASMLogName);
            this.grpConfigASMLaunch.Controls.Add(this.lblASMLoggingInterval);
            this.grpConfigASMLaunch.Controls.Add(this.txtASMLogName);
            this.grpConfigASMLaunch.Controls.Add(this.lblASMLogName);
            this.grpConfigASMLaunch.ForeColor = System.Drawing.Color.White;
            this.grpConfigASMLaunch.Location = new System.Drawing.Point(6, 109);
            this.grpConfigASMLaunch.Name = "grpConfigASMLaunch";
            this.grpConfigASMLaunch.Size = new System.Drawing.Size(555, 135);
            this.grpConfigASMLaunch.TabIndex = 50;
            this.grpConfigASMLaunch.TabStop = false;
            this.grpConfigASMLaunch.Text = "Launch Parameters";
            // 
            // numASMLogInterval
            // 
            this.numASMLogInterval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numASMLogInterval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numASMLogInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.numASMLogInterval.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.numASMLogInterval.Location = new System.Drawing.Point(9, 50);
            this.numASMLogInterval.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numASMLogInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numASMLogInterval.Name = "numASMLogInterval";
            this.numASMLogInterval.Size = new System.Drawing.Size(90, 22);
            this.numASMLogInterval.TabIndex = 50;
            this.toolTip1.SetToolTip(this.numASMLogInterval, "Time in seconds between saving a performance log line from ASM");
            this.numASMLogInterval.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnFortxtASMLogName
            // 
            this.btnFortxtASMLogName.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnFortxtASMLogName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnFortxtASMLogName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFortxtASMLogName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFortxtASMLogName.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnFortxtASMLogName.Location = new System.Drawing.Point(468, 100);
            this.btnFortxtASMLogName.Margin = new System.Windows.Forms.Padding(0);
            this.btnFortxtASMLogName.Name = "btnFortxtASMLogName";
            this.btnFortxtASMLogName.Size = new System.Drawing.Size(64, 22);
            this.btnFortxtASMLogName.TabIndex = 49;
            this.btnFortxtASMLogName.Text = "Change";
            this.btnFortxtASMLogName.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnFortxtASMLogName.UseVisualStyleBackColor = true;
            // 
            // lblASMLoggingInterval
            // 
            this.lblASMLoggingInterval.AutoSize = true;
            this.lblASMLoggingInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblASMLoggingInterval.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblASMLoggingInterval.Location = new System.Drawing.Point(6, 30);
            this.lblASMLoggingInterval.Name = "lblASMLoggingInterval";
            this.lblASMLoggingInterval.Size = new System.Drawing.Size(211, 16);
            this.lblASMLoggingInterval.TabIndex = 45;
            this.lblASMLoggingInterval.Text = "ASM Logging Interval (in seconds)";
            this.toolTip1.SetToolTip(this.lblASMLoggingInterval, "Time in seconds between saving a performance log line from ASM");
            // 
            // txtASMLogName
            // 
            this.txtASMLogName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtASMLogName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtASMLogName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtASMLogName.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtASMLogName.Location = new System.Drawing.Point(9, 100);
            this.txtASMLogName.Name = "txtASMLogName";
            this.txtASMLogName.ReadOnly = true;
            this.txtASMLogName.Size = new System.Drawing.Size(456, 22);
            this.txtASMLogName.TabIndex = 48;
            this.toolTip1.SetToolTip(this.txtASMLogName, "Name of the performance log that ASM creates");
            // 
            // lblASMLogName
            // 
            this.lblASMLogName.AutoSize = true;
            this.lblASMLogName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblASMLogName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblASMLogName.Location = new System.Drawing.Point(6, 80);
            this.lblASMLogName.Name = "lblASMLogName";
            this.lblASMLogName.Size = new System.Drawing.Size(128, 16);
            this.lblASMLogName.TabIndex = 47;
            this.lblASMLogName.Text = "ASM Log File Name";
            this.toolTip1.SetToolTip(this.lblASMLogName, "Name of the performance log that ASM creates");
            // 
            // flpASM
            // 
            this.flpASM.AutoScroll = true;
            this.flpASM.Location = new System.Drawing.Point(207, 69);
            this.flpASM.Name = "flpASM";
            this.flpASM.Size = new System.Drawing.Size(354, 49);
            this.flpASM.TabIndex = 50;
            this.flpASM.WrapContents = false;
            // 
            // lblASMAffinity
            // 
            this.lblASMAffinity.AutoSize = true;
            this.lblASMAffinity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblASMAffinity.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblASMAffinity.Location = new System.Drawing.Point(204, 50);
            this.lblASMAffinity.Name = "lblASMAffinity";
            this.lblASMAffinity.Size = new System.Drawing.Size(144, 16);
            this.lblASMAffinity.TabIndex = 32;
            this.lblASMAffinity.Text = "Process Affinity (cores)";
            this.toolTip1.SetToolTip(this.lblASMAffinity, "Process EXE Affinity. The cores with which this process can utilize.");
            // 
            // lblASMPriority
            // 
            this.lblASMPriority.AutoSize = true;
            this.lblASMPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblASMPriority.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblASMPriority.Location = new System.Drawing.Point(3, 58);
            this.lblASMPriority.Name = "lblASMPriority";
            this.lblASMPriority.Size = new System.Drawing.Size(102, 16);
            this.lblASMPriority.TabIndex = 31;
            this.lblASMPriority.Text = "Process Priority";
            this.toolTip1.SetToolTip(this.lblASMPriority, "Process Priority (Only change if you notice a performance change when doing so)");
            // 
            // cBoxPriorityASM
            // 
            this.cBoxPriorityASM.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.cBoxPriorityASM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cBoxPriorityASM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxPriorityASM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxPriorityASM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxPriorityASM.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.cBoxPriorityASM.FormattingEnabled = true;
            this.cBoxPriorityASM.Items.AddRange(new object[] {
            "Realtime",
            "High",
            "AboveNormal",
            "Normal",
            "BelowNormal",
            "Low"});
            this.cBoxPriorityASM.Location = new System.Drawing.Point(6, 77);
            this.cBoxPriorityASM.Name = "cBoxPriorityASM";
            this.cBoxPriorityASM.Size = new System.Drawing.Size(184, 24);
            this.cBoxPriorityASM.TabIndex = 30;
            this.toolTip1.SetToolTip(this.cBoxPriorityASM, "Process Priority (Only change if you notice a performance change when doing so)");
            this.cBoxPriorityASM.SelectedIndexChanged += new System.EventHandler(this.actionPriorityChanged);
            // 
            // btnProcessKeepaliveASM
            // 
            this.btnProcessKeepaliveASM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnProcessKeepaliveASM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnProcessKeepaliveASM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessKeepaliveASM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessKeepaliveASM.ForeColor = System.Drawing.Color.Green;
            this.btnProcessKeepaliveASM.Location = new System.Drawing.Point(6, 6);
            this.btnProcessKeepaliveASM.Name = "btnProcessKeepaliveASM";
            this.btnProcessKeepaliveASM.Size = new System.Drawing.Size(184, 41);
            this.btnProcessKeepaliveASM.TabIndex = 29;
            this.btnProcessKeepaliveASM.Text = "Keep Process Alive";
            this.toolTip1.SetToolTip(this.btnProcessKeepaliveASM, "Toggle the keepalive for this process.");
            this.btnProcessKeepaliveASM.UseVisualStyleBackColor = true;
            this.btnProcessKeepaliveASM.Click += new System.EventHandler(this.actionProcessKeepaliveToggle);
            this.btnProcessKeepaliveASM.Leave += new System.EventHandler(this.evntKeepProcessAlive_Leave);
            this.btnProcessKeepaliveASM.MouseLeave += new System.EventHandler(this.evntKeepProcessAlive_MouseLeave);
            this.btnProcessKeepaliveASM.MouseMove += new System.Windows.Forms.MouseEventHandler(this.evntKeepProcessAlive_MouseMove);
            // 
            // btnFortxtPathToEXEASM
            // 
            this.btnFortxtPathToEXEASM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnFortxtPathToEXEASM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnFortxtPathToEXEASM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFortxtPathToEXEASM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFortxtPathToEXEASM.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnFortxtPathToEXEASM.Location = new System.Drawing.Point(497, 25);
            this.btnFortxtPathToEXEASM.Margin = new System.Windows.Forms.Padding(0);
            this.btnFortxtPathToEXEASM.Name = "btnFortxtPathToEXEASM";
            this.btnFortxtPathToEXEASM.Size = new System.Drawing.Size(64, 22);
            this.btnFortxtPathToEXEASM.TabIndex = 28;
            this.btnFortxtPathToEXEASM.Text = "Browse";
            this.btnFortxtPathToEXEASM.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnFortxtPathToEXEASM.UseVisualStyleBackColor = true;
            this.btnFortxtPathToEXEASM.Click += new System.EventHandler(this.actionBrowseButtonForFilePath);
            // 
            // lblASMPathToExe
            // 
            this.lblASMPathToExe.AutoSize = true;
            this.lblASMPathToExe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblASMPathToExe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblASMPathToExe.Location = new System.Drawing.Point(204, 6);
            this.lblASMPathToExe.Name = "lblASMPathToExe";
            this.lblASMPathToExe.Size = new System.Drawing.Size(119, 16);
            this.lblASMPathToExe.TabIndex = 27;
            this.lblASMPathToExe.Text = "Path to Executable";
            this.toolTip1.SetToolTip(this.lblASMPathToExe, "Full path to process executable");
            // 
            // txtPathToEXEASM
            // 
            this.txtPathToEXEASM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPathToEXEASM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPathToEXEASM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPathToEXEASM.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPathToEXEASM.Location = new System.Drawing.Point(207, 25);
            this.txtPathToEXEASM.Name = "txtPathToEXEASM";
            this.txtPathToEXEASM.ReadOnly = true;
            this.txtPathToEXEASM.Size = new System.Drawing.Size(287, 22);
            this.txtPathToEXEASM.TabIndex = 26;
            this.toolTip1.SetToolTip(this.txtPathToEXEASM, "Full path to process executable");
            // 
            // tabPageProcessCustom
            // 
            this.tabPageProcessCustom.AutoScroll = true;
            this.tabPageProcessCustom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.tabPageProcessCustom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageProcessCustom.Controls.Add(this.btnCustomProcessDelete);
            this.tabPageProcessCustom.Controls.Add(this.btnCustomProcessAdd);
            this.tabPageProcessCustom.Controls.Add(this.cBoxCustomProcessSelector);
            this.tabPageProcessCustom.Controls.Add(this.groupBox2);
            this.tabPageProcessCustom.Location = new System.Drawing.Point(4, 25);
            this.tabPageProcessCustom.Name = "tabPageProcessCustom";
            this.tabPageProcessCustom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProcessCustom.Size = new System.Drawing.Size(588, 266);
            this.tabPageProcessCustom.TabIndex = 6;
            this.tabPageProcessCustom.Text = "Custom";
            // 
            // btnCustomProcessDelete
            // 
            this.btnCustomProcessDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCustomProcessDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCustomProcessDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomProcessDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomProcessDelete.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnCustomProcessDelete.Location = new System.Drawing.Point(469, 30);
            this.btnCustomProcessDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btnCustomProcessDelete.Name = "btnCustomProcessDelete";
            this.btnCustomProcessDelete.Size = new System.Drawing.Size(97, 22);
            this.btnCustomProcessDelete.TabIndex = 63;
            this.btnCustomProcessDelete.Text = "Delete/Remove";
            this.btnCustomProcessDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolTip1.SetToolTip(this.btnCustomProcessDelete, "Delete the currently selected custom process config");
            this.btnCustomProcessDelete.UseVisualStyleBackColor = true;
            this.btnCustomProcessDelete.Click += new System.EventHandler(this.actionCustomProcDel);
            // 
            // btnCustomProcessAdd
            // 
            this.btnCustomProcessAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCustomProcessAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCustomProcessAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomProcessAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomProcessAdd.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnCustomProcessAdd.Location = new System.Drawing.Point(3, 30);
            this.btnCustomProcessAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnCustomProcessAdd.Name = "btnCustomProcessAdd";
            this.btnCustomProcessAdd.Size = new System.Drawing.Size(64, 22);
            this.btnCustomProcessAdd.TabIndex = 62;
            this.btnCustomProcessAdd.Text = "Add New";
            this.btnCustomProcessAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolTip1.SetToolTip(this.btnCustomProcessAdd, "Add a new custom process");
            this.btnCustomProcessAdd.UseVisualStyleBackColor = true;
            this.btnCustomProcessAdd.Click += new System.EventHandler(this.actionCustomProcAdd);
            // 
            // cBoxCustomProcessSelector
            // 
            this.cBoxCustomProcessSelector.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.cBoxCustomProcessSelector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cBoxCustomProcessSelector.Dock = System.Windows.Forms.DockStyle.Top;
            this.cBoxCustomProcessSelector.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cBoxCustomProcessSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxCustomProcessSelector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxCustomProcessSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxCustomProcessSelector.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.cBoxCustomProcessSelector.FormattingEnabled = true;
            this.cBoxCustomProcessSelector.Location = new System.Drawing.Point(3, 3);
            this.cBoxCustomProcessSelector.Name = "cBoxCustomProcessSelector";
            this.cBoxCustomProcessSelector.Size = new System.Drawing.Size(563, 24);
            this.cBoxCustomProcessSelector.TabIndex = 59;
            this.toolTip1.SetToolTip(this.cBoxCustomProcessSelector, "Custom Process Selection List, Choose from one of the items to edit. \r\n(Max 100 C" +
        "ustom Entries)");
            this.cBoxCustomProcessSelector.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.customProcessListDrawItem);
            this.cBoxCustomProcessSelector.SelectedIndexChanged += new System.EventHandler(this.actionCustomProcSelector);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flpCustom);
            this.groupBox2.Controls.Add(this.lblCustomProcessLaunchParams);
            this.groupBox2.Controls.Add(this.txtCustomProcessLaunchParams);
            this.groupBox2.Controls.Add(this.lblCustomProcessName);
            this.groupBox2.Controls.Add(this.txtCustomProcessName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cBoxPriorityCustom);
            this.groupBox2.Controls.Add(this.btnProcessKeepaliveCustom);
            this.groupBox2.Controls.Add(this.btnCustomProcessBrowseEXE);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtPathToEXECustom);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(6, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(555, 230);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "(Process EXE Name)";
            // 
            // flpCustom
            // 
            this.flpCustom.AutoScroll = true;
            this.flpCustom.Location = new System.Drawing.Point(211, 92);
            this.flpCustom.Name = "flpCustom";
            this.flpCustom.Size = new System.Drawing.Size(337, 49);
            this.flpCustom.TabIndex = 75;
            this.flpCustom.WrapContents = false;
            // 
            // lblCustomProcessLaunchParams
            // 
            this.lblCustomProcessLaunchParams.AutoSize = true;
            this.lblCustomProcessLaunchParams.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomProcessLaunchParams.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCustomProcessLaunchParams.Location = new System.Drawing.Point(7, 181);
            this.lblCustomProcessLaunchParams.Name = "lblCustomProcessLaunchParams";
            this.lblCustomProcessLaunchParams.Size = new System.Drawing.Size(124, 16);
            this.lblCustomProcessLaunchParams.TabIndex = 74;
            this.lblCustomProcessLaunchParams.Text = "Launch Parameters";
            this.toolTip1.SetToolTip(this.lblCustomProcessLaunchParams, "Full path to process executable");
            // 
            // txtCustomProcessLaunchParams
            // 
            this.txtCustomProcessLaunchParams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCustomProcessLaunchParams.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomProcessLaunchParams.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomProcessLaunchParams.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCustomProcessLaunchParams.HideSelection = false;
            this.txtCustomProcessLaunchParams.Location = new System.Drawing.Point(10, 200);
            this.txtCustomProcessLaunchParams.Name = "txtCustomProcessLaunchParams";
            this.txtCustomProcessLaunchParams.Size = new System.Drawing.Size(538, 22);
            this.txtCustomProcessLaunchParams.TabIndex = 73;
            this.toolTip1.SetToolTip(this.txtCustomProcessLaunchParams, "Launch parameters assiciated with the execution of this process");
            this.txtCustomProcessLaunchParams.Leave += new System.EventHandler(this.actionCustomProcessLPTouched);
            // 
            // lblCustomProcessName
            // 
            this.lblCustomProcessName.AutoSize = true;
            this.lblCustomProcessName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomProcessName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCustomProcessName.Location = new System.Drawing.Point(7, 128);
            this.lblCustomProcessName.Name = "lblCustomProcessName";
            this.lblCustomProcessName.Size = new System.Drawing.Size(95, 16);
            this.lblCustomProcessName.TabIndex = 72;
            this.lblCustomProcessName.Text = "Process Label";
            this.toolTip1.SetToolTip(this.lblCustomProcessName, "Full path to process executable");
            // 
            // txtCustomProcessName
            // 
            this.txtCustomProcessName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCustomProcessName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomProcessName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomProcessName.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCustomProcessName.HideSelection = false;
            this.txtCustomProcessName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtCustomProcessName.Location = new System.Drawing.Point(10, 147);
            this.txtCustomProcessName.Name = "txtCustomProcessName";
            this.txtCustomProcessName.Size = new System.Drawing.Size(538, 22);
            this.txtCustomProcessName.TabIndex = 71;
            this.toolTip1.SetToolTip(this.txtCustomProcessName, "A name given as a label o the seelcted custom process");
            this.txtCustomProcessName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.actionCustomProcessNameTouched);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(208, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 62;
            this.label1.Text = "Process Affinity (cores)";
            this.toolTip1.SetToolTip(this.label1, "Process EXE Affinity. The cores with which this process can utilize.");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(7, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 61;
            this.label2.Text = "Process Priority";
            this.toolTip1.SetToolTip(this.label2, "Process Priority (Only change if you notice a performance change when doing so)");
            // 
            // cBoxPriorityCustom
            // 
            this.cBoxPriorityCustom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.cBoxPriorityCustom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cBoxPriorityCustom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxPriorityCustom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxPriorityCustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxPriorityCustom.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.cBoxPriorityCustom.FormattingEnabled = true;
            this.cBoxPriorityCustom.Items.AddRange(new object[] {
            "Realtime",
            "High",
            "AboveNormal",
            "Normal",
            "BelowNormal",
            "Low"});
            this.cBoxPriorityCustom.Location = new System.Drawing.Point(10, 92);
            this.cBoxPriorityCustom.Name = "cBoxPriorityCustom";
            this.cBoxPriorityCustom.Size = new System.Drawing.Size(184, 24);
            this.cBoxPriorityCustom.TabIndex = 60;
            this.toolTip1.SetToolTip(this.cBoxPriorityCustom, "Process Priority (Only change if you notice a performance change when doing so)");
            this.cBoxPriorityCustom.SelectedIndexChanged += new System.EventHandler(this.actionPriorityChanged);
            // 
            // btnProcessKeepaliveCustom
            // 
            this.btnProcessKeepaliveCustom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnProcessKeepaliveCustom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnProcessKeepaliveCustom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessKeepaliveCustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessKeepaliveCustom.ForeColor = System.Drawing.Color.Green;
            this.btnProcessKeepaliveCustom.Location = new System.Drawing.Point(10, 21);
            this.btnProcessKeepaliveCustom.Name = "btnProcessKeepaliveCustom";
            this.btnProcessKeepaliveCustom.Size = new System.Drawing.Size(184, 41);
            this.btnProcessKeepaliveCustom.TabIndex = 59;
            this.btnProcessKeepaliveCustom.Text = "Keep Process Alive";
            this.toolTip1.SetToolTip(this.btnProcessKeepaliveCustom, "Toggle the keepalive for this process.");
            this.btnProcessKeepaliveCustom.UseVisualStyleBackColor = true;
            this.btnProcessKeepaliveCustom.Click += new System.EventHandler(this.actionProcessKeepaliveToggle);
            this.btnProcessKeepaliveCustom.Leave += new System.EventHandler(this.evntKeepProcessAlive_Leave);
            this.btnProcessKeepaliveCustom.MouseLeave += new System.EventHandler(this.evntKeepProcessAlive_MouseLeave);
            this.btnProcessKeepaliveCustom.MouseMove += new System.Windows.Forms.MouseEventHandler(this.evntKeepProcessAlive_MouseMove);
            // 
            // btnCustomProcessBrowseEXE
            // 
            this.btnCustomProcessBrowseEXE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCustomProcessBrowseEXE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCustomProcessBrowseEXE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomProcessBrowseEXE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomProcessBrowseEXE.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnCustomProcessBrowseEXE.Location = new System.Drawing.Point(484, 40);
            this.btnCustomProcessBrowseEXE.Margin = new System.Windows.Forms.Padding(0);
            this.btnCustomProcessBrowseEXE.Name = "btnCustomProcessBrowseEXE";
            this.btnCustomProcessBrowseEXE.Size = new System.Drawing.Size(64, 22);
            this.btnCustomProcessBrowseEXE.TabIndex = 58;
            this.btnCustomProcessBrowseEXE.Text = "Browse";
            this.btnCustomProcessBrowseEXE.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnCustomProcessBrowseEXE.UseVisualStyleBackColor = true;
            this.btnCustomProcessBrowseEXE.Click += new System.EventHandler(this.actionBrowseButtonForFilePath);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(208, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 57;
            this.label3.Text = "Path to Executable";
            this.toolTip1.SetToolTip(this.label3, "Full path to process executable");
            // 
            // txtPathToEXECustom
            // 
            this.txtPathToEXECustom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPathToEXECustom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPathToEXECustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPathToEXECustom.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPathToEXECustom.Location = new System.Drawing.Point(211, 40);
            this.txtPathToEXECustom.Name = "txtPathToEXECustom";
            this.txtPathToEXECustom.ReadOnly = true;
            this.txtPathToEXECustom.Size = new System.Drawing.Size(270, 22);
            this.txtPathToEXECustom.TabIndex = 56;
            this.toolTip1.SetToolTip(this.txtPathToEXECustom, "Full path to process executable");
            // 
            // frmConfigWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(630, 572);
            this.ControlBox = false;
            this.Controls.Add(this.pbConfigServer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbActive);
            this.Controls.Add(this.btnTabSelectCustom);
            this.Controls.Add(this.btnTabSelectASM);
            this.Controls.Add(this.btnTabSelectTS);
            this.Controls.Add(this.btnTabSelectHC);
            this.Controls.Add(this.btnTabSelectBEC);
            this.Controls.Add(this.btnTabSelectDatabase);
            this.Controls.Add(this.btnTabSelectServer);
            this.Controls.Add(this.tabControlMainConfig);
            this.Controls.Add(this.btnFortxtBatchSettingsPath);
            this.Controls.Add(this.btnFortxtArmaExePath);
            this.Controls.Add(this.txtBatchSettingsPath);
            this.Controls.Add(this.lblMetaBatchSettingsPath);
            this.Controls.Add(this.txtArmaExePath);
            this.Controls.Add(this.lblMetaExePath);
            this.Controls.Add(this.lblMetaConfigName);
            this.Controls.Add(this.btnSaveconfig);
            this.Controls.Add(this.txtConfigName);
            this.Controls.Add(this.lblMainConfig);
            this.Controls.Add(this.btnCancelConfig);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(646, 1000);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(646, 610);
            this.Name = "frmConfigWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configure your SKBT installation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.configFormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.configFormClosed);
            this.Load += new System.EventHandler(this.frmConfigWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConfigServer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mStripConfig.ResumeLayout(false);
            this.mStripConfig.PerformLayout();
            this.tabControlMainConfig.ResumeLayout(false);
            this.tabPageProcessServer.ResumeLayout(false);
            this.tabPageProcessServer.PerformLayout();
            this.grpConfigServerBackup.ResumeLayout(false);
            this.grpConfigServerBackup.PerformLayout();
            this.grpKeepaliveOptions.ResumeLayout(false);
            this.grpKeepaliveOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStartTimeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numManualTimeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAutoTimeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAutoDelay)).EndInit();
            this.grpConfigServerLaunch.ResumeLayout(false);
            this.grpConfigServerLaunch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numServerIP4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numServerIP3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numServerIP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numServerIP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numServerPort)).EndInit();
            this.tabPageProcessDatabase.ResumeLayout(false);
            this.tabPageProcessDatabase.PerformLayout();
            this.grpConfigDatabaseBackup.ResumeLayout(false);
            this.grpConfigDatabaseBackup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBackupInterval)).EndInit();
            this.tabPageProcessBEC.ResumeLayout(false);
            this.tabPageProcessBEC.PerformLayout();
            this.grpConfigBECBackup.ResumeLayout(false);
            this.grpConfigBECBackup.PerformLayout();
            this.tabPageProcessHC.ResumeLayout(false);
            this.tabPageProcessHC.PerformLayout();
            this.grpConfigHCLaunch.ResumeLayout(false);
            this.grpConfigHCLaunch.PerformLayout();
            this.tabPageProcessTS.ResumeLayout(false);
            this.tabPageProcessTS.PerformLayout();
            this.grpconfigTeamspeakLaunch.ResumeLayout(false);
            this.grpconfigTeamspeakLaunch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTeamspeakPortNumber)).EndInit();
            this.tabPageProcessASM.ResumeLayout(false);
            this.tabPageProcessASM.PerformLayout();
            this.grpConfigASMLaunch.ResumeLayout(false);
            this.grpConfigASMLaunch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numASMLogInterval)).EndInit();
            this.tabPageProcessCustom.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelConfig;
        private System.Windows.Forms.Label lblMainConfig;
        private System.Windows.Forms.TextBox txtConfigName;
        private System.Windows.Forms.Button btnSaveconfig;
        private System.Windows.Forms.Label lblMetaConfigName;
        private System.Windows.Forms.Label lblMetaExePath;
        private System.Windows.Forms.TextBox txtArmaExePath;
        private System.Windows.Forms.Label lblMetaBatchSettingsPath;
        private System.Windows.Forms.TextBox txtBatchSettingsPath;
        private System.Windows.Forms.Button btnFortxtArmaExePath;
        private System.Windows.Forms.Button btnFortxtBatchSettingsPath;
        private TablessControl tabControlMainConfig;
        private System.Windows.Forms.TabPage tabPageProcessDatabase;
        private System.Windows.Forms.TabPage tabPageProcessServer;
        private System.Windows.Forms.TabPage tabPageProcessBEC;
        private System.Windows.Forms.Button btnFortxtPathToEXEServer;
        private System.Windows.Forms.Label lblServerPathToEXE;
        private System.Windows.Forms.TextBox txtPathToEXEServer;
        private System.Windows.Forms.Button btnProcessKeepaliveServer;
        private System.Windows.Forms.Label lblServerAffinity;
        private System.Windows.Forms.Label lblerverPriority;
        private System.Windows.Forms.ComboBox cBoxPriorityServer;
        private System.Windows.Forms.Label lvlDatabaseAffinity;
        private System.Windows.Forms.Label lblDatabasePriority;
        private System.Windows.Forms.ComboBox cBoxPriorityDatabase;
        private System.Windows.Forms.Button btnProcessKeepaliveDatabase;
        private System.Windows.Forms.Button btnFortxtPathToEXEDB;
        private System.Windows.Forms.Label lblDatabasePathToExe;
        private System.Windows.Forms.TextBox txtPathToEXEDB;
        private System.Windows.Forms.Label lblBECAffinity;
        private System.Windows.Forms.Label lblBECPriority;
        private System.Windows.Forms.ComboBox cBoxPriorityBEC;
        private System.Windows.Forms.Button btnProcessKeepaliveBEC;
        private System.Windows.Forms.Button btnFortxtPathToEXEBEC;
        private System.Windows.Forms.Label lblBECPathToExe;
        private System.Windows.Forms.TextBox txtPathToEXEBEC;
        private System.Windows.Forms.Button btnTabSelectServer;
        private System.Windows.Forms.Button btnTabSelectDatabase;
        private System.Windows.Forms.Button btnTabSelectBEC;
        private System.Windows.Forms.Button btnTabSelectHC;
        private System.Windows.Forms.Button btnTabSelectTS;
        private System.Windows.Forms.Button btnTabSelectASM;
        private System.Windows.Forms.TabPage tabPageProcessHC;
        private System.Windows.Forms.Label lblHCAffinity;
        private System.Windows.Forms.Label lblHCPriority;
        private System.Windows.Forms.ComboBox cBoxPriorityHeadlessClient;
        private System.Windows.Forms.Button btnProcessKeepaliveHC;
        private System.Windows.Forms.Button btnFortxtPathToEXEHC;
        private System.Windows.Forms.Label lblHCPathToExe;
        private System.Windows.Forms.TextBox txtPathToEXEHC;
        private System.Windows.Forms.TabPage tabPageProcessTS;
        private System.Windows.Forms.Label lblTSAffinity;
        private System.Windows.Forms.Label lblTSPriority;
        private System.Windows.Forms.ComboBox cBoxPriorityTeamspeak;
        private System.Windows.Forms.Button btnProcessKeepaliveTS;
        private System.Windows.Forms.Button btnFortxtPathToEXETS;
        private System.Windows.Forms.Label lblTSPathToExe;
        private System.Windows.Forms.TextBox txtPathToEXETS;
        private System.Windows.Forms.TabPage tabPageProcessASM;
        private System.Windows.Forms.Label lblASMAffinity;
        private System.Windows.Forms.Label lblASMPriority;
        private System.Windows.Forms.Button btnProcessKeepaliveASM;
        private System.Windows.Forms.Button btnFortxtPathToEXEASM;
        private System.Windows.Forms.Label lblASMPathToExe;
        private System.Windows.Forms.TextBox txtPathToEXEASM;
        private System.Windows.Forms.GroupBox grpConfigServerLaunch;
        private System.Windows.Forms.TextBox txtProfileName;
        private System.Windows.Forms.Label lblServerProfileName;
        private System.Windows.Forms.Button btnFortxtPathToProfile;
        private System.Windows.Forms.Label lblPathToProfile;
        private System.Windows.Forms.TextBox txtPathToProfile;
        private System.Windows.Forms.Button btnFortxtPathToBasicCFG;
        private System.Windows.Forms.Label lblServerPathToBasic;
        private System.Windows.Forms.TextBox txtPathToBasicCFG;
        private System.Windows.Forms.Button btnFortxtPathToConfigCFG;
        private System.Windows.Forms.Label lblServerPathToConfig;
        private System.Windows.Forms.TextBox txtPathToConfigCFG;
        private System.Windows.Forms.TextBox txtServerModline;
        private System.Windows.Forms.Label lblServerModline;
        private System.Windows.Forms.TextBox txtServerCommand;
        private System.Windows.Forms.Label lblServerCommand;
        private System.Windows.Forms.Label lblServerPort;
        private System.Windows.Forms.FolderBrowserDialog folderBrowseDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.NumericUpDown numServerPort;
        private System.Windows.Forms.CheckBox chkServerBindToIP;
        private System.Windows.Forms.NumericUpDown numServerIP4;
        private System.Windows.Forms.NumericUpDown numServerIP3;
        private System.Windows.Forms.NumericUpDown numServerIP2;
        private System.Windows.Forms.NumericUpDown numServerIP1;
        private System.Windows.Forms.Label lvlServerIP;
        private System.Windows.Forms.GroupBox grpKeepaliveOptions;
        private System.Windows.Forms.Label lblStartTimeout;
        private System.Windows.Forms.CheckBox chkCleanWERs;
        private System.Windows.Forms.Label lblManualTimeout;
        private System.Windows.Forms.Label lblAutoTimeout;
        private System.Windows.Forms.Label lblAutoDelay;
        private System.Windows.Forms.Label lblDebugLevel;
        private System.Windows.Forms.ComboBox cBoxDebugLevel;
        private System.Windows.Forms.NumericUpDown numStartTimeout;
        private System.Windows.Forms.NumericUpDown numManualTimeout;
        private System.Windows.Forms.NumericUpDown numAutoTimeout;
        private System.Windows.Forms.NumericUpDown numAutoDelay;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabPage tabPageProcessCustom;
        private System.Windows.Forms.Button btnTabSelectCustom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCustomProcessName;
        private System.Windows.Forms.TextBox txtCustomProcessName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBoxPriorityCustom;
        private System.Windows.Forms.Button btnProcessKeepaliveCustom;
        private System.Windows.Forms.Button btnCustomProcessBrowseEXE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPathToEXECustom;
        private System.Windows.Forms.Label lblCustomProcessLaunchParams;
        private System.Windows.Forms.TextBox txtCustomProcessLaunchParams;
        private System.Windows.Forms.ComboBox cBoxCustomProcessSelector;
        private System.Windows.Forms.Button btnCustomProcessDelete;
        private System.Windows.Forms.Button btnCustomProcessAdd;
        private System.Windows.Forms.ComboBox cBoxPriorityASM;
        private System.Windows.Forms.FlowLayoutPanel flpServer;
        private System.Windows.Forms.FlowLayoutPanel flpDatabase;
        private System.Windows.Forms.FlowLayoutPanel flpBEC;
        private System.Windows.Forms.FlowLayoutPanel flpHeadlessClient;
        private System.Windows.Forms.FlowLayoutPanel flpTeamspeak;
        private System.Windows.Forms.FlowLayoutPanel flpASM;
        private System.Windows.Forms.FlowLayoutPanel flpCustom;
        private System.Windows.Forms.GroupBox grpConfigServerBackup;
        private System.Windows.Forms.CheckBox chkUseZipLogs;
        private System.Windows.Forms.Button btnFortxtPathToBackupLog;
        private System.Windows.Forms.Label lblServerPathToLogBackup;
        private System.Windows.Forms.TextBox txtPathToBackupLog;
        private System.Windows.Forms.Button btnFortxtPathToServerLog;
        private System.Windows.Forms.Label lblServerPathToLog;
        private System.Windows.Forms.TextBox txtPathToServerLog;
        private System.Windows.Forms.GroupBox grpConfigDatabaseBackup;
        private System.Windows.Forms.NumericUpDown numBackupInterval;
        private System.Windows.Forms.Label lblDatabaseBackupInterval;
        private System.Windows.Forms.CheckBox chkUseZipBackups;
        private System.Windows.Forms.Button btnFortxtPathToBackupFolder;
        private System.Windows.Forms.Label lblDatabaseBackupFolder;
        private System.Windows.Forms.TextBox txtPathToBackupFolder;
        private System.Windows.Forms.Button btnFortxtPathToDBFile;
        private System.Windows.Forms.Label lblDatabaseDumpFile;
        private System.Windows.Forms.TextBox txtPathToDBFile;
        private System.Windows.Forms.GroupBox grpConfigBECBackup;
        private System.Windows.Forms.CheckBox chkBecUseDsc;
        private System.Windows.Forms.TextBox txtPathToBattleye;
        private System.Windows.Forms.Button btnFortxtPathToBattleye;
        private System.Windows.Forms.Label lblBECBEPath;
        private System.Windows.Forms.GroupBox grpConfigHCLaunch;
        private System.Windows.Forms.Label lblHCLaunchArgs;
        private System.Windows.Forms.TextBox txtHeadlessClientLaunchArgs;
        private System.Windows.Forms.GroupBox grpconfigTeamspeakLaunch;
        private System.Windows.Forms.NumericUpDown numTeamspeakPortNumber;
        private System.Windows.Forms.Label lblTSPort;
        private System.Windows.Forms.GroupBox grpConfigASMLaunch;
        private System.Windows.Forms.NumericUpDown numASMLogInterval;
        private System.Windows.Forms.Button btnFortxtASMLogName;
        private System.Windows.Forms.Label lblASMLoggingInterval;
        private System.Windows.Forms.TextBox txtASMLogName;
        private System.Windows.Forms.Label lblASMLogName;
        private System.Windows.Forms.PictureBox pbActive;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip mStripConfig;
        private System.Windows.Forms.ToolStripMenuItem tsmItemConfigControl;
        private System.Windows.Forms.ToolStripMenuItem tsmItemConfigControlStart;
        private System.Windows.Forms.ToolStripMenuItem tsmConfigControlStop;
        private System.Windows.Forms.ToolStripMenuItem tsmItemConfigControlRestart;
        private System.Windows.Forms.ToolStripMenuItem tsmConfigKeepalive;
        private System.Windows.Forms.ToolStripMenuItem tsmConfigKeepaliveLog;
        private System.Windows.Forms.ToolStripMenuItem tsmConfigKeepaliveClean;
        private System.Windows.Forms.ToolStripMenuItem tsmConfigKeepaliveOpenLib;
        private System.Windows.Forms.ToolStripMenuItem tsmConfigKeepaliveOpenSettings;
        private System.Windows.Forms.ToolStripMenuItem tsmConfigKeepaliveStart;
        private System.Windows.Forms.ToolStripMenuItem tsmConfigKeepaliveStop;
        private System.Windows.Forms.ToolStripMenuItem tsmConfigAbout;
        private System.Windows.Forms.PictureBox pbConfigServer;
        private System.Windows.Forms.ToolStripMenuItem viewReadmeToolStripMenuItem;
    }
}