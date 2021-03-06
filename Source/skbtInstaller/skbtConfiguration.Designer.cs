﻿namespace skbtInstaller
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
            this.chkAffinityServer7 = new System.Windows.Forms.CheckBox();
            this.chkAffinityServer6 = new System.Windows.Forms.CheckBox();
            this.chkAffinityServer5 = new System.Windows.Forms.CheckBox();
            this.chkAffinityServer4 = new System.Windows.Forms.CheckBox();
            this.chkAffinityServer3 = new System.Windows.Forms.CheckBox();
            this.chkAffinityServer2 = new System.Windows.Forms.CheckBox();
            this.chkAffinityServer1 = new System.Windows.Forms.CheckBox();
            this.chkAffinityServer0 = new System.Windows.Forms.CheckBox();
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
            this.chkAffinityDatabase7 = new System.Windows.Forms.CheckBox();
            this.chkAffinityDatabase6 = new System.Windows.Forms.CheckBox();
            this.chkAffinityDatabase5 = new System.Windows.Forms.CheckBox();
            this.chkAffinityDatabase4 = new System.Windows.Forms.CheckBox();
            this.chkAffinityDatabase3 = new System.Windows.Forms.CheckBox();
            this.chkAffinityDatabase2 = new System.Windows.Forms.CheckBox();
            this.chkAffinityDatabase1 = new System.Windows.Forms.CheckBox();
            this.chkAffinityDatabase0 = new System.Windows.Forms.CheckBox();
            this.lvlDatabaseAffinity = new System.Windows.Forms.Label();
            this.lblDatabasePriority = new System.Windows.Forms.Label();
            this.cBoxPriorityDatabase = new System.Windows.Forms.ComboBox();
            this.btnProcessKeepaliveDatabase = new System.Windows.Forms.Button();
            this.btnFortxtPathToEXEDB = new System.Windows.Forms.Button();
            this.lblDatabasePathToExe = new System.Windows.Forms.Label();
            this.txtPathToEXEDB = new System.Windows.Forms.TextBox();
            this.tabPageProcessBEC = new System.Windows.Forms.TabPage();
            this.grpConfigBECBackup = new System.Windows.Forms.GroupBox();
            this.txtPathToBattleye = new System.Windows.Forms.TextBox();
            this.btnFortxtPathToBattleye = new System.Windows.Forms.Button();
            this.lblBECBEPath = new System.Windows.Forms.Label();
            this.chkAffinityBEC7 = new System.Windows.Forms.CheckBox();
            this.chkAffinityBEC6 = new System.Windows.Forms.CheckBox();
            this.chkAffinityBEC5 = new System.Windows.Forms.CheckBox();
            this.chkAffinityBEC4 = new System.Windows.Forms.CheckBox();
            this.chkAffinityBEC3 = new System.Windows.Forms.CheckBox();
            this.chkAffinityBEC2 = new System.Windows.Forms.CheckBox();
            this.chkAffinityBEC1 = new System.Windows.Forms.CheckBox();
            this.chkAffinityBEC0 = new System.Windows.Forms.CheckBox();
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
            this.chkAffinityHeadlessClient7 = new System.Windows.Forms.CheckBox();
            this.chkAffinityHeadlessClient6 = new System.Windows.Forms.CheckBox();
            this.chkAffinityHeadlessClient5 = new System.Windows.Forms.CheckBox();
            this.chkAffinityHeadlessClient4 = new System.Windows.Forms.CheckBox();
            this.chkAffinityHeadlessClient3 = new System.Windows.Forms.CheckBox();
            this.chkAffinityHeadlessClient2 = new System.Windows.Forms.CheckBox();
            this.chkAffinityHeadlessClient1 = new System.Windows.Forms.CheckBox();
            this.chkAffinityHeadlessClient0 = new System.Windows.Forms.CheckBox();
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
            this.chkAffinityTeamspeak7 = new System.Windows.Forms.CheckBox();
            this.chkAffinityTeamspeak6 = new System.Windows.Forms.CheckBox();
            this.chkAffinityTeamspeak5 = new System.Windows.Forms.CheckBox();
            this.chkAffinityTeamspeak4 = new System.Windows.Forms.CheckBox();
            this.chkAffinityTeamspeak3 = new System.Windows.Forms.CheckBox();
            this.chkAffinityTeamspeak2 = new System.Windows.Forms.CheckBox();
            this.chkAffinityTeamspeak1 = new System.Windows.Forms.CheckBox();
            this.chkAffinityTeamspeak0 = new System.Windows.Forms.CheckBox();
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
            this.chkAffinityASM7 = new System.Windows.Forms.CheckBox();
            this.chkAffinityASM6 = new System.Windows.Forms.CheckBox();
            this.chkAffinityASM5 = new System.Windows.Forms.CheckBox();
            this.chkAffinityASM4 = new System.Windows.Forms.CheckBox();
            this.chkAffinityASM3 = new System.Windows.Forms.CheckBox();
            this.chkAffinityASM2 = new System.Windows.Forms.CheckBox();
            this.chkAffinityASM1 = new System.Windows.Forms.CheckBox();
            this.chkAffinityASM0 = new System.Windows.Forms.CheckBox();
            this.lblASMAffinity = new System.Windows.Forms.Label();
            this.lblASMPriority = new System.Windows.Forms.Label();
            this.cBoxPriorityASM = new System.Windows.Forms.ComboBox();
            this.btnProcessKeepaliveASM = new System.Windows.Forms.Button();
            this.btnFortxtPathToEXEASM = new System.Windows.Forms.Button();
            this.lblASMPathToExe = new System.Windows.Forms.Label();
            this.txtPathToEXEASM = new System.Windows.Forms.TextBox();
            this.tabControlMainConfig.SuspendLayout();
            this.tabPageProcessServer.SuspendLayout();
            this.grpConfigServerBackup.SuspendLayout();
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
            this.btnTabSelectServer.Size = new System.Drawing.Size(110, 22);
            this.btnTabSelectServer.TabIndex = 27;
            this.btnTabSelectServer.Text = "Arma Server";
            this.btnTabSelectServer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
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
            this.btnTabSelectDatabase.Location = new System.Drawing.Point(140, 162);
            this.btnTabSelectDatabase.Margin = new System.Windows.Forms.Padding(0);
            this.btnTabSelectDatabase.Name = "btnTabSelectDatabase";
            this.btnTabSelectDatabase.Size = new System.Drawing.Size(86, 22);
            this.btnTabSelectDatabase.TabIndex = 28;
            this.btnTabSelectDatabase.Text = "Database";
            this.btnTabSelectDatabase.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
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
            this.btnTabSelectBEC.Location = new System.Drawing.Point(240, 162);
            this.btnTabSelectBEC.Margin = new System.Windows.Forms.Padding(0);
            this.btnTabSelectBEC.Name = "btnTabSelectBEC";
            this.btnTabSelectBEC.Size = new System.Drawing.Size(51, 22);
            this.btnTabSelectBEC.TabIndex = 29;
            this.btnTabSelectBEC.Text = "BEC";
            this.btnTabSelectBEC.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
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
            this.btnTabSelectHC.Location = new System.Drawing.Point(305, 162);
            this.btnTabSelectHC.Margin = new System.Windows.Forms.Padding(0);
            this.btnTabSelectHC.Name = "btnTabSelectHC";
            this.btnTabSelectHC.Size = new System.Drawing.Size(126, 22);
            this.btnTabSelectHC.TabIndex = 30;
            this.btnTabSelectHC.Text = "Headless Client";
            this.btnTabSelectHC.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
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
            this.btnTabSelectTS.Location = new System.Drawing.Point(445, 162);
            this.btnTabSelectTS.Margin = new System.Windows.Forms.Padding(0);
            this.btnTabSelectTS.Name = "btnTabSelectTS";
            this.btnTabSelectTS.Size = new System.Drawing.Size(102, 22);
            this.btnTabSelectTS.TabIndex = 31;
            this.btnTabSelectTS.Text = "Teamspeak";
            this.btnTabSelectTS.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
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
            this.btnTabSelectASM.Location = new System.Drawing.Point(561, 162);
            this.btnTabSelectASM.Margin = new System.Windows.Forms.Padding(0);
            this.btnTabSelectASM.Name = "btnTabSelectASM";
            this.btnTabSelectASM.Size = new System.Drawing.Size(50, 22);
            this.btnTabSelectASM.TabIndex = 32;
            this.btnTabSelectASM.Text = "ASM";
            this.btnTabSelectASM.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
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
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
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
            this.tabControlMainConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.tabPageProcessServer.Controls.Add(this.grpConfigServerLaunch);
            this.tabPageProcessServer.Controls.Add(this.chkAffinityServer7);
            this.tabPageProcessServer.Controls.Add(this.chkAffinityServer6);
            this.tabPageProcessServer.Controls.Add(this.chkAffinityServer5);
            this.tabPageProcessServer.Controls.Add(this.chkAffinityServer4);
            this.tabPageProcessServer.Controls.Add(this.chkAffinityServer3);
            this.tabPageProcessServer.Controls.Add(this.chkAffinityServer2);
            this.tabPageProcessServer.Controls.Add(this.chkAffinityServer1);
            this.tabPageProcessServer.Controls.Add(this.chkAffinityServer0);
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
            this.grpConfigServerBackup.TabIndex = 28;
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
            this.btnFortxtPathToBackupLog.Click += new System.EventHandler(this.actionBrowseButtonForFilePath);
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
            this.grpConfigServerLaunch.Location = new System.Drawing.Point(6, 261);
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
            // 
            // chkAffinityServer7
            // 
            this.chkAffinityServer7.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAffinityServer7.AutoSize = true;
            this.chkAffinityServer7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkAffinityServer7.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkAffinityServer7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.chkAffinityServer7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAffinityServer7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAffinityServer7.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.chkAffinityServer7.Location = new System.Drawing.Point(522, 80);
            this.chkAffinityServer7.Name = "chkAffinityServer7";
            this.chkAffinityServer7.Size = new System.Drawing.Size(30, 23);
            this.chkAffinityServer7.TabIndex = 25;
            this.chkAffinityServer7.Text = "#7";
            this.chkAffinityServer7.UseVisualStyleBackColor = true;
            this.chkAffinityServer7.CheckedChanged += new System.EventHandler(this.evntChkAffinityChange);
            // 
            // chkAffinityServer6
            // 
            this.chkAffinityServer6.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAffinityServer6.AutoSize = true;
            this.chkAffinityServer6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkAffinityServer6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkAffinityServer6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.chkAffinityServer6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAffinityServer6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAffinityServer6.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.chkAffinityServer6.Location = new System.Drawing.Point(477, 80);
            this.chkAffinityServer6.Name = "chkAffinityServer6";
            this.chkAffinityServer6.Size = new System.Drawing.Size(30, 23);
            this.chkAffinityServer6.TabIndex = 24;
            this.chkAffinityServer6.Text = "#6";
            this.chkAffinityServer6.UseVisualStyleBackColor = true;
            this.chkAffinityServer6.CheckedChanged += new System.EventHandler(this.evntChkAffinityChange);
            // 
            // chkAffinityServer5
            // 
            this.chkAffinityServer5.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAffinityServer5.AutoSize = true;
            this.chkAffinityServer5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkAffinityServer5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkAffinityServer5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.chkAffinityServer5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAffinityServer5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAffinityServer5.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.chkAffinityServer5.Location = new System.Drawing.Point(432, 80);
            this.chkAffinityServer5.Name = "chkAffinityServer5";
            this.chkAffinityServer5.Size = new System.Drawing.Size(30, 23);
            this.chkAffinityServer5.TabIndex = 23;
            this.chkAffinityServer5.Text = "#5";
            this.chkAffinityServer5.UseVisualStyleBackColor = true;
            this.chkAffinityServer5.CheckedChanged += new System.EventHandler(this.evntChkAffinityChange);
            // 
            // chkAffinityServer4
            // 
            this.chkAffinityServer4.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAffinityServer4.AutoSize = true;
            this.chkAffinityServer4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkAffinityServer4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkAffinityServer4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.chkAffinityServer4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAffinityServer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAffinityServer4.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.chkAffinityServer4.Location = new System.Drawing.Point(387, 80);
            this.chkAffinityServer4.Name = "chkAffinityServer4";
            this.chkAffinityServer4.Size = new System.Drawing.Size(30, 23);
            this.chkAffinityServer4.TabIndex = 22;
            this.chkAffinityServer4.Text = "#4";
            this.chkAffinityServer4.UseVisualStyleBackColor = true;
            // 
            // chkAffinityServer3
            // 
            this.chkAffinityServer3.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAffinityServer3.AutoSize = true;
            this.chkAffinityServer3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkAffinityServer3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkAffinityServer3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.chkAffinityServer3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAffinityServer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAffinityServer3.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.chkAffinityServer3.Location = new System.Drawing.Point(342, 80);
            this.chkAffinityServer3.Name = "chkAffinityServer3";
            this.chkAffinityServer3.Size = new System.Drawing.Size(30, 23);
            this.chkAffinityServer3.TabIndex = 21;
            this.chkAffinityServer3.Text = "#3";
            this.chkAffinityServer3.UseVisualStyleBackColor = true;
            this.chkAffinityServer3.CheckedChanged += new System.EventHandler(this.evntChkAffinityChange);
            // 
            // chkAffinityServer2
            // 
            this.chkAffinityServer2.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAffinityServer2.AutoSize = true;
            this.chkAffinityServer2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkAffinityServer2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkAffinityServer2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.chkAffinityServer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAffinityServer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAffinityServer2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.chkAffinityServer2.Location = new System.Drawing.Point(297, 80);
            this.chkAffinityServer2.Name = "chkAffinityServer2";
            this.chkAffinityServer2.Size = new System.Drawing.Size(30, 23);
            this.chkAffinityServer2.TabIndex = 20;
            this.chkAffinityServer2.Text = "#2";
            this.chkAffinityServer2.UseVisualStyleBackColor = true;
            this.chkAffinityServer2.CheckedChanged += new System.EventHandler(this.evntChkAffinityChange);
            // 
            // chkAffinityServer1
            // 
            this.chkAffinityServer1.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAffinityServer1.AutoSize = true;
            this.chkAffinityServer1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkAffinityServer1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkAffinityServer1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.chkAffinityServer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAffinityServer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAffinityServer1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.chkAffinityServer1.Location = new System.Drawing.Point(252, 80);
            this.chkAffinityServer1.Name = "chkAffinityServer1";
            this.chkAffinityServer1.Size = new System.Drawing.Size(30, 23);
            this.chkAffinityServer1.TabIndex = 19;
            this.chkAffinityServer1.Text = "#1";
            this.chkAffinityServer1.UseVisualStyleBackColor = true;
            this.chkAffinityServer1.CheckedChanged += new System.EventHandler(this.evntChkAffinityChange);
            // 
            // chkAffinityServer0
            // 
            this.chkAffinityServer0.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAffinityServer0.AutoSize = true;
            this.chkAffinityServer0.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkAffinityServer0.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkAffinityServer0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.chkAffinityServer0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAffinityServer0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAffinityServer0.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.chkAffinityServer0.Location = new System.Drawing.Point(207, 80);
            this.chkAffinityServer0.Name = "chkAffinityServer0";
            this.chkAffinityServer0.Size = new System.Drawing.Size(30, 23);
            this.chkAffinityServer0.TabIndex = 18;
            this.chkAffinityServer0.Text = "#0";
            this.chkAffinityServer0.UseVisualStyleBackColor = true;
            this.chkAffinityServer0.CheckedChanged += new System.EventHandler(this.evntChkAffinityChange);
            // 
            // lblServerAffinity
            // 
            this.lblServerAffinity.AutoSize = true;
            this.lblServerAffinity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerAffinity.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblServerAffinity.Location = new System.Drawing.Point(204, 58);
            this.lblServerAffinity.Name = "lblServerAffinity";
            this.lblServerAffinity.Size = new System.Drawing.Size(144, 16);
            this.lblServerAffinity.TabIndex = 17;
            this.lblServerAffinity.Text = "Process Affinity (cores)";
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
            // 
            // tabPageProcessDatabase
            // 
            this.tabPageProcessDatabase.AutoScroll = true;
            this.tabPageProcessDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.tabPageProcessDatabase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageProcessDatabase.Controls.Add(this.grpConfigDatabaseBackup);
            this.tabPageProcessDatabase.Controls.Add(this.chkAffinityDatabase7);
            this.tabPageProcessDatabase.Controls.Add(this.chkAffinityDatabase6);
            this.tabPageProcessDatabase.Controls.Add(this.chkAffinityDatabase5);
            this.tabPageProcessDatabase.Controls.Add(this.chkAffinityDatabase4);
            this.tabPageProcessDatabase.Controls.Add(this.chkAffinityDatabase3);
            this.tabPageProcessDatabase.Controls.Add(this.chkAffinityDatabase2);
            this.tabPageProcessDatabase.Controls.Add(this.chkAffinityDatabase1);
            this.tabPageProcessDatabase.Controls.Add(this.chkAffinityDatabase0);
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
            this.grpConfigDatabaseBackup.TabIndex = 41;
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
            this.numBackupInterval.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numBackupInterval.ValueChanged += new System.EventHandler(this.actionBackupIntervalChanged);
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
            this.chkUseZipBackups.UseVisualStyleBackColor = true;
            this.chkUseZipBackups.Click += new System.EventHandler(this.actionUseZipBackups);
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
            this.btnFortxtPathToBackupFolder.Click += new System.EventHandler(this.actionBrowseButtonForFilePath);
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
            this.btnFortxtPathToDBFile.Click += new System.EventHandler(this.actionBrowseButtonForFilePath);
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
            // 
            // chkAffinityDatabase7
            // 
            this.chkAffinityDatabase7.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAffinityDatabase7.AutoSize = true;
            this.chkAffinityDatabase7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkAffinityDatabase7.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkAffinityDatabase7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAffinityDatabase7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAffinityDatabase7.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.chkAffinityDatabase7.Location = new System.Drawing.Point(522, 80);
            this.chkAffinityDatabase7.Name = "chkAffinityDatabase7";
            this.chkAffinityDatabase7.Size = new System.Drawing.Size(30, 23);
            this.chkAffinityDatabase7.TabIndex = 40;
            this.chkAffinityDatabase7.Text = "#7";
            this.chkAffinityDatabase7.UseVisualStyleBackColor = true;
            this.chkAffinityDatabase7.CheckedChanged += new System.EventHandler(this.evntChkAffinityChange);
            // 
            // chkAffinityDatabase6
            // 
            this.chkAffinityDatabase6.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAffinityDatabase6.AutoSize = true;
            this.chkAffinityDatabase6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkAffinityDatabase6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkAffinityDatabase6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAffinityDatabase6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAffinityDatabase6.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.chkAffinityDatabase6.Location = new System.Drawing.Point(477, 80);
            this.chkAffinityDatabase6.Name = "chkAffinityDatabase6";
            this.chkAffinityDatabase6.Size = new System.Drawing.Size(30, 23);
            this.chkAffinityDatabase6.TabIndex = 39;
            this.chkAffinityDatabase6.Text = "#6";
            this.chkAffinityDatabase6.UseVisualStyleBackColor = true;
            this.chkAffinityDatabase6.CheckedChanged += new System.EventHandler(this.evntChkAffinityChange);
            // 
            // chkAffinityDatabase5
            // 
            this.chkAffinityDatabase5.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAffinityDatabase5.AutoSize = true;
            this.chkAffinityDatabase5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkAffinityDatabase5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkAffinityDatabase5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAffinityDatabase5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAffinityDatabase5.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.chkAffinityDatabase5.Location = new System.Drawing.Point(432, 80);
            this.chkAffinityDatabase5.Name = "chkAffinityDatabase5";
            this.chkAffinityDatabase5.Size = new System.Drawing.Size(30, 23);
            this.chkAffinityDatabase5.TabIndex = 38;
            this.chkAffinityDatabase5.Text = "#5";
            this.chkAffinityDatabase5.UseVisualStyleBackColor = true;
            this.chkAffinityDatabase5.CheckedChanged += new System.EventHandler(this.evntChkAffinityChange);
            // 
            // chkAffinityDatabase4
            // 
            this.chkAffinityDatabase4.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAffinityDatabase4.AutoSize = true;
            this.chkAffinityDatabase4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkAffinityDatabase4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkAffinityDatabase4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAffinityDatabase4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAffinityDatabase4.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.chkAffinityDatabase4.Location = new System.Drawing.Point(387, 80);
            this.chkAffinityDatabase4.Name = "chkAffinityDatabase4";
            this.chkAffinityDatabase4.Size = new System.Drawing.Size(30, 23);
            this.chkAffinityDatabase4.TabIndex = 37;
            this.chkAffinityDatabase4.Text = "#4";
            this.chkAffinityDatabase4.UseVisualStyleBackColor = true;
            this.chkAffinityDatabase4.CheckedChanged += new System.EventHandler(this.evntChkAffinityChange);
            // 
            // chkAffinityDatabase3
            // 
            this.chkAffinityDatabase3.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAffinityDatabase3.AutoSize = true;
            this.chkAffinityDatabase3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkAffinityDatabase3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkAffinityDatabase3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAffinityDatabase3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAffinityDatabase3.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.chkAffinityDatabase3.Location = new System.Drawing.Point(342, 80);
            this.chkAffinityDatabase3.Name = "chkAffinityDatabase3";
            this.chkAffinityDatabase3.Size = new System.Drawing.Size(30, 23);
            this.chkAffinityDatabase3.TabIndex = 36;
            this.chkAffinityDatabase3.Text = "#3";
            this.chkAffinityDatabase3.UseVisualStyleBackColor = true;
            this.chkAffinityDatabase3.CheckedChanged += new System.EventHandler(this.evntChkAffinityChange);
            // 
            // chkAffinityDatabase2
            // 
            this.chkAffinityDatabase2.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAffinityDatabase2.AutoSize = true;
            this.chkAffinityDatabase2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkAffinityDatabase2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkAffinityDatabase2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAffinityDatabase2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAffinityDatabase2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.chkAffinityDatabase2.Location = new System.Drawing.Point(297, 80);
            this.chkAffinityDatabase2.Name = "chkAffinityDatabase2";
            this.chkAffinityDatabase2.Size = new System.Drawing.Size(30, 23);
            this.chkAffinityDatabase2.TabIndex = 35;
            this.chkAffinityDatabase2.Text = "#2";
            this.chkAffinityDatabase2.UseVisualStyleBackColor = true;
            this.chkAffinityDatabase2.CheckedChanged += new System.EventHandler(this.evntChkAffinityChange);
            // 
            // chkAffinityDatabase1
            // 
            this.chkAffinityDatabase1.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAffinityDatabase1.AutoSize = true;
            this.chkAffinityDatabase1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkAffinityDatabase1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkAffinityDatabase1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAffinityDatabase1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAffinityDatabase1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.chkAffinityDatabase1.Location = new System.Drawing.Point(252, 80);
            this.chkAffinityDatabase1.Name = "chkAffinityDatabase1";
            this.chkAffinityDatabase1.Size = new System.Drawing.Size(30, 23);
            this.chkAffinityDatabase1.TabIndex = 34;
            this.chkAffinityDatabase1.Text = "#1";
            this.chkAffinityDatabase1.UseVisualStyleBackColor = true;
            this.chkAffinityDatabase1.CheckedChanged += new System.EventHandler(this.evntChkAffinityChange);
            // 
            // chkAffinityDatabase0
            // 
            this.chkAffinityDatabase0.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAffinityDatabase0.AutoSize = true;
            this.chkAffinityDatabase0.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkAffinityDatabase0.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkAffinityDatabase0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAffinityDatabase0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAffinityDatabase0.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.chkAffinityDatabase0.Location = new System.Drawing.Point(207, 80);
            this.chkAffinityDatabase0.Name = "chkAffinityDatabase0";
            this.chkAffinityDatabase0.Size = new System.Drawing.Size(30, 23);
            this.chkAffinityDatabase0.TabIndex = 33;
            this.chkAffinityDatabase0.Text = "#0";
            this.chkAffinityDatabase0.UseVisualStyleBackColor = true;
            this.chkAffinityDatabase0.CheckedChanged += new System.EventHandler(this.evntChkAffinityChange);
            // 
            // lvlDatabaseAffinity
            // 
            this.lvlDatabaseAffinity.AutoSize = true;
            this.lvlDatabaseAffinity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlDatabaseAffinity.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lvlDatabaseAffinity.Location = new System.Drawing.Point(204, 58);
            this.lvlDatabaseAffinity.Name = "lvlDatabaseAffinity";
            this.lvlDatabaseAffinity.Size = new System.Drawing.Size(144, 16);
            this.lvlDatabaseAffinity.TabIndex = 32;
            this.lvlDatabaseAffinity.Text = "Process Affinity (cores)";
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
            // 
            // tabPageProcessBEC
            // 
            this.tabPageProcessBEC.AutoScroll = true;
            this.tabPageProcessBEC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.tabPageProcessBEC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageProcessBEC.Controls.Add(this.grpConfigBECBackup);
            this.tabPageProcessBEC.Controls.Add(this.chkAffinityBEC7);
            this.tabPageProcessBEC.Controls.Add(this.chkAffinityBEC6);
            this.tabPageProcessBEC.Controls.Add(this.chkAffinityBEC5);
            this.tabPageProcessBEC.Controls.Add(this.chkAffinityBEC4);
            this.tabPageProcessBEC.Controls.Add(this.chkAffinityBEC3);
            this.tabPageProcessBEC.Controls.Add(this.chkAffinityBEC2);
            this.tabPageProcessBEC.Controls.Add(this.chkAffinityBEC1);
            this.tabPageProcessBEC.Controls.Add(this.chkAffinityBEC0);
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
            this.grpConfigBECBackup.Controls.Add(this.txtPathToBattleye);
            this.grpConfigBECBackup.Controls.Add(this.btnFortxtPathToBattleye);
            this.grpConfigBECBackup.Controls.Add(this.lblBECBEPath);
            this.grpConfigBECBackup.ForeColor = System.Drawing.Color.White;
            this.grpConfigBECBackup.Location = new System.Drawing.Point(6, 109);
            this.grpConfigBECBackup.Name = "grpConfigBECBackup";
            this.grpConfigBECBackup.Size = new System.Drawing.Size(555, 80);
            this.grpConfigBECBackup.TabIndex = 45;
            this.grpConfigBECBackup.TabStop = false;
            this.grpConfigBECBackup.Text = "Backup/Logging Settings";
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
            // 
            // btnFortxtPathToBattleye
            // 
            this.btnFortxtPathToBattleye.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnFortxtPathToBattleye.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnFortxtPathToBattleye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFortxtPathToBattleye.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFortxtPathToBattleye.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnFortxtPathToBattleye.Location = new System.Drawing.Point(475, 47);
            this.btnFortxtPathToBattleye.Margin = new System.Windows.Forms.Padding(0);
            this.btnFortxtPathToBattleye.Name = "btnFortxtPathToBattleye";
            this.btnFortxtPathToBattleye.Size = new System.Drawing.Size(64, 22);
            this.btnFortxtPathToBattleye.TabIndex = 44;
            this.btnFortxtPathToBattleye.Text = "Browse";
            this.btnFortxtPathToBattleye.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnFortxtPathToBattleye.UseVisualStyleBackColor = true;
            this.btnFortxtPathToBattleye.Click += new System.EventHandler(this.actionBrowseButtonForFilePath);
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
            // 
            // chkAffinityBEC7
            // 
            this.chkAffinityBEC7.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAffinityBEC7.AutoSize = true;
            this.chkAffinityBEC7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkAffinityBEC7.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkAffinityBEC7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAffinityBEC7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAffinityBEC7.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.chkAffinityBEC7.Location = new System.Drawing.Point(522, 80);
            this.chkAffinityBEC7.Name = "chkAffinityBEC7";
            this.chkAffinityBEC7.Size = new System.Drawing.Size(30, 23);
            this.chkAffinityBEC7.TabIndex = 40;
            this.chkAffinityBEC7.Text = "#7";
            this.chkAffinityBEC7.UseVisualStyleBackColor = true;
            this.chkAffinityBEC7.CheckedChanged += new System.EventHandler(this.evntChkAffinityChange);
            // 
            // chkAffinityBEC6
            // 
            this.chkAffinityBEC6.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAffinityBEC6.AutoSize = true;
            this.chkAffinityBEC6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkAffinityBEC6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkAffinityBEC6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAffinityBEC6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAffinityBEC6.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.chkAffinityBEC6.Location = new System.Drawing.Point(477, 80);
            this.chkAffinityBEC6.Name = "chkAffinityBEC6";
            this.chkAffinityBEC6.Size = new System.Drawing.Size(30, 23);
            this.chkAffinityBEC6.TabIndex = 39;
            this.chkAffinityBEC6.Text = "#6";
            this.chkAffinityBEC6.UseVisualStyleBackColor = true;
            this.chkAffinityBEC6.CheckedChanged += new System.EventHandler(this.evntChkAffinityChange);
            // 
            // chkAffinityBEC5
            // 
            this.chkAffinityBEC5.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAffinityBEC5.AutoSize = true;
            this.chkAffinityBEC5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkAffinityBEC5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkAffinityBEC5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAffinityBEC5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAffinityBEC5.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.chkAffinityBEC5.Location = new System.Drawing.Point(432, 80);
            this.chkAffinityBEC5.Name = "chkAffinityBEC5";
            this.chkAffinityBEC5.Size = new System.Drawing.Size(30, 23);
            this.chkAffinityBEC5.TabIndex = 38;
            this.chkAffinityBEC5.Text = "#5";
            this.chkAffinityBEC5.UseVisualStyleBackColor = true;
            this.chkAffinityBEC5.CheckedChanged += new System.EventHandler(this.evntChkAffinityChange);
            // 
            // chkAffinityBEC4
            // 
            this.chkAffinityBEC4.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAffinityBEC4.AutoSize = true;
            this.chkAffinityBEC4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkAffinityBEC4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkAffinityBEC4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAffinityBEC4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAffinityBEC4.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.chkAffinityBEC4.Location = new System.Drawing.Point(387, 80);
            this.chkAffinityBEC4.Name = "chkAffinityBEC4";
            this.chkAffinityBEC4.Size = new System.Drawing.Size(30, 23);
            this.chkAffinityBEC4.TabIndex = 37;
            this.chkAffinityBEC4.Text = "#4";
            this.chkAffinityBEC4.UseVisualStyleBackColor = true;
            this.chkAffinityBEC4.CheckedChanged += new System.EventHandler(this.evntChkAffinityChange);
            // 
            // chkAffinityBEC3
            // 
            this.chkAffinityBEC3.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAffinityBEC3.AutoSize = true;
            this.chkAffinityBEC3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkAffinityBEC3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkAffinityBEC3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAffinityBEC3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAffinityBEC3.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.chkAffinityBEC3.Location = new System.Drawing.Point(342, 80);
            this.chkAffinityBEC3.Name = "chkAffinityBEC3";
            this.chkAffinityBEC3.Size = new System.Drawing.Size(30, 23);
            this.chkAffinityBEC3.TabIndex = 36;
            this.chkAffinityBEC3.Text = "#3";
            this.chkAffinityBEC3.UseVisualStyleBackColor = true;
            this.chkAffinityBEC3.CheckedChanged += new System.EventHandler(this.evntChkAffinityChange);
            // 
            // chkAffinityBEC2
            // 
            this.chkAffinityBEC2.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAffinityBEC2.AutoSize = true;
            this.chkAffinityBEC2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkAffinityBEC2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkAffinityBEC2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAffinityBEC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAffinityBEC2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.chkAffinityBEC2.Location = new System.Drawing.Point(297, 80);
            this.chkAffinityBEC2.Name = "chkAffinityBEC2";
            this.chkAffinityBEC2.Size = new System.Drawing.Size(30, 23);
            this.chkAffinityBEC2.TabIndex = 35;
            this.chkAffinityBEC2.Text = "#2";
            this.chkAffinityBEC2.UseVisualStyleBackColor = true;
            this.chkAffinityBEC2.CheckedChanged += new System.EventHandler(this.evntChkAffinityChange);
            // 
            // chkAffinityBEC1
            // 
            this.chkAffinityBEC1.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAffinityBEC1.AutoSize = true;
            this.chkAffinityBEC1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkAffinityBEC1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkAffinityBEC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAffinityBEC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAffinityBEC1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.chkAffinityBEC1.Location = new System.Drawing.Point(252, 80);
            this.chkAffinityBEC1.Name = "chkAffinityBEC1";
            this.chkAffinityBEC1.Size = new System.Drawing.Size(30, 23);
            this.chkAffinityBEC1.TabIndex = 34;
            this.chkAffinityBEC1.Text = "#1";
            this.chkAffinityBEC1.UseVisualStyleBackColor = true;
            this.chkAffinityBEC1.CheckedChanged += new System.EventHandler(this.evntChkAffinityChange);
            // 
            // chkAffinityBEC0
            // 
            this.chkAffinityBEC0.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAffinityBEC0.AutoSize = true;
            this.chkAffinityBEC0.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkAffinityBEC0.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkAffinityBEC0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAffinityBEC0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAffinityBEC0.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.chkAffinityBEC0.Location = new System.Drawing.Point(207, 80);
            this.chkAffinityBEC0.Name = "chkAffinityBEC0";
            this.chkAffinityBEC0.Size = new System.Drawing.Size(30, 23);
            this.chkAffinityBEC0.TabIndex = 33;
            this.chkAffinityBEC0.Text = "#0";
            this.chkAffinityBEC0.UseVisualStyleBackColor = true;
            this.chkAffinityBEC0.CheckedChanged += new System.EventHandler(this.evntChkAffinityChange);
            // 
            // lblBECAffinity
            // 
            this.lblBECAffinity.AutoSize = true;
            this.lblBECAffinity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBECAffinity.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBECAffinity.Location = new System.Drawing.Point(204, 58);
            this.lblBECAffinity.Name = "lblBECAffinity";
            this.lblBECAffinity.Size = new System.Drawing.Size(144, 16);
            this.lblBECAffinity.TabIndex = 32;
            this.lblBECAffinity.Text = "Process Affinity (cores)";
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
            // 
            // tabPageProcessHC
            // 
            this.tabPageProcessHC.AutoScroll = true;
            this.tabPageProcessHC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.tabPageProcessHC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageProcessHC.Controls.Add(this.grpConfigHCLaunch);
            this.tabPageProcessHC.Controls.Add(this.chkAffinityHeadlessClient7);
            this.tabPageProcessHC.Controls.Add(this.chkAffinityHeadlessClient6);
            this.tabPageProcessHC.Controls.Add(this.chkAffinityHeadlessClient5);
            this.tabPageProcessHC.Controls.Add(this.chkAffinityHeadlessClient4);
            this.tabPageProcessHC.Controls.Add(this.chkAffinityHeadlessClient3);
            this.tabPageProcessHC.Controls.Add(this.chkAffinityHeadlessClient2);
            this.tabPageProcessHC.Controls.Add(this.chkAffinityHeadlessClient1);
            this.tabPageProcessHC.Controls.Add(this.chkAffinityHeadlessClient0);
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
            this.grpConfigHCLaunch.TabIndex = 46;
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
            this.txtHeadlessClientLaunchArgs.Leave += new System.EventHandler(this.actionHeadlessClientParamsTouched);
            // 
            // chkAffinityHeadlessClient7
            // 
            this.chkAffinityHeadlessClient7.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAffinityHeadlessClient7.AutoSize = true;
            this.chkAffinityHeadlessClient7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkAffinityHeadlessClient7.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkAffinityHeadlessClient7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAffinityHeadlessClient7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAffinityHeadlessClient7.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.chkAffinityHeadlessClient7.Location = new System.Drawing.Point(522, 80);
            this.chkAffinityHeadlessClient7.Name = "chkAffinityHeadlessClient7";
            this.chkAffinityHeadlessClient7.Size = new System.Drawing.Size(30, 23);
            this.chkAffinityHeadlessClient7.TabIndex = 40;
            this.chkAffinityHeadlessClient7.Text = "#7";
            this.chkAffinityHeadlessClient7.UseVisualStyleBackColor = true;
            this.chkAffinityHeadlessClient7.CheckedChanged += new System.EventHandler(this.evntChkAffinityChange);
            // 
            // chkAffinityHeadlessClient6
            // 
            this.chkAffinityHeadlessClient6.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAffinityHeadlessClient6.AutoSize = true;
            this.chkAffinityHeadlessClient6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkAffinityHeadlessClient6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkAffinityHeadlessClient6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAffinityHeadlessClient6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAffinityHeadlessClient6.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.chkAffinityHeadlessClient6.Location = new System.Drawing.Point(477, 80);
            this.chkAffinityHeadlessClient6.Name = "chkAffinityHeadlessClient6";
            this.chkAffinityHeadlessClient6.Size = new System.Drawing.Size(30, 23);
            this.chkAffinityHeadlessClient6.TabIndex = 39;
            this.chkAffinityHeadlessClient6.Text = "#6";
            this.chkAffinityHeadlessClient6.UseVisualStyleBackColor = true;
            this.chkAffinityHeadlessClient6.CheckedChanged += new System.EventHandler(this.evntChkAffinityChange);
            // 
            // chkAffinityHeadlessClient5
            // 
            this.chkAffinityHeadlessClient5.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAffinityHeadlessClient5.AutoSize = true;
            this.chkAffinityHeadlessClient5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkAffinityHeadlessClient5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkAffinityHeadlessClient5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAffinityHeadlessClient5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAffinityHeadlessClient5.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.chkAffinityHeadlessClient5.Location = new System.Drawing.Point(432, 80);
            this.chkAffinityHeadlessClient5.Name = "chkAffinityHeadlessClient5";
            this.chkAffinityHeadlessClient5.Size = new System.Drawing.Size(30, 23);
            this.chkAffinityHeadlessClient5.TabIndex = 38;
            this.chkAffinityHeadlessClient5.Text = "#5";
            this.chkAffinityHeadlessClient5.UseVisualStyleBackColor = true;
            this.chkAffinityHeadlessClient5.CheckedChanged += new System.EventHandler(this.evntChkAffinityChange);
            // 
            // chkAffinityHeadlessClient4
            // 
            this.chkAffinityHeadlessClient4.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAffinityHeadlessClient4.AutoSize = true;
            this.chkAffinityHeadlessClient4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkAffinityHeadlessClient4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkAffinityHeadlessClient4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAffinityHeadlessClient4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAffinityHeadlessClient4.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.chkAffinityHeadlessClient4.Location = new System.Drawing.Point(387, 80);
            this.chkAffinityHeadlessClient4.Name = "chkAffinityHeadlessClient4";
            this.chkAffinityHeadlessClient4.Size = new System.Drawing.Size(30, 23);
            this.chkAffinityHeadlessClient4.TabIndex = 37;
            this.chkAffinityHeadlessClient4.Text = "#4";
            this.chkAffinityHeadlessClient4.UseVisualStyleBackColor = true;
            this.chkAffinityHeadlessClient4.CheckedChanged += new System.EventHandler(this.evntChkAffinityChange);
            // 
            // chkAffinityHeadlessClient3
            // 
            this.chkAffinityHeadlessClient3.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAffinityHeadlessClient3.AutoSize = true;
            this.chkAffinityHeadlessClient3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkAffinityHeadlessClient3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkAffinityHeadlessClient3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAffinityHeadlessClient3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAffinityHeadlessClient3.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.chkAffinityHeadlessClient3.Location = new System.Drawing.Point(342, 80);
            this.chkAffinityHeadlessClient3.Name = "chkAffinityHeadlessClient3";
            this.chkAffinityHeadlessClient3.Size = new System.Drawing.Size(30, 23);
            this.chkAffinityHeadlessClient3.TabIndex = 36;
            this.chkAffinityHeadlessClient3.Text = "#3";
            this.chkAffinityHeadlessClient3.UseVisualStyleBackColor = true;
            this.chkAffinityHeadlessClient3.CheckedChanged += new System.EventHandler(this.evntChkAffinityChange);
            // 
            // chkAffinityHeadlessClient2
            // 
            this.chkAffinityHeadlessClient2.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAffinityHeadlessClient2.AutoSize = true;
            this.chkAffinityHeadlessClient2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkAffinityHeadlessClient2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkAffinityHeadlessClient2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAffinityHeadlessClient2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAffinityHeadlessClient2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.chkAffinityHeadlessClient2.Location = new System.Drawing.Point(297, 80);
            this.chkAffinityHeadlessClient2.Name = "chkAffinityHeadlessClient2";
            this.chkAffinityHeadlessClient2.Size = new System.Drawing.Size(30, 23);
            this.chkAffinityHeadlessClient2.TabIndex = 35;
            this.chkAffinityHeadlessClient2.Text = "#2";
            this.chkAffinityHeadlessClient2.UseVisualStyleBackColor = true;
            this.chkAffinityHeadlessClient2.CheckedChanged += new System.EventHandler(this.evntChkAffinityChange);
            // 
            // chkAffinityHeadlessClient1
            // 
            this.chkAffinityHeadlessClient1.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAffinityHeadlessClient1.AutoSize = true;
            this.chkAffinityHeadlessClient1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkAffinityHeadlessClient1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkAffinityHeadlessClient1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAffinityHeadlessClient1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAffinityHeadlessClient1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.chkAffinityHeadlessClient1.Location = new System.Drawing.Point(252, 80);
            this.chkAffinityHeadlessClient1.Name = "chkAffinityHeadlessClient1";
            this.chkAffinityHeadlessClient1.Size = new System.Drawing.Size(30, 23);
            this.chkAffinityHeadlessClient1.TabIndex = 34;
            this.chkAffinityHeadlessClient1.Text = "#1";
            this.chkAffinityHeadlessClient1.UseVisualStyleBackColor = true;
            this.chkAffinityHeadlessClient1.CheckedChanged += new System.EventHandler(this.evntChkAffinityChange);
            // 
            // chkAffinityHeadlessClient0
            // 
            this.chkAffinityHeadlessClient0.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAffinityHeadlessClient0.AutoSize = true;
            this.chkAffinityHeadlessClient0.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkAffinityHeadlessClient0.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkAffinityHeadlessClient0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAffinityHeadlessClient0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAffinityHeadlessClient0.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.chkAffinityHeadlessClient0.Location = new System.Drawing.Point(207, 80);
            this.chkAffinityHeadlessClient0.Name = "chkAffinityHeadlessClient0";
            this.chkAffinityHeadlessClient0.Size = new System.Drawing.Size(30, 23);
            this.chkAffinityHeadlessClient0.TabIndex = 33;
            this.chkAffinityHeadlessClient0.Text = "#0";
            this.chkAffinityHeadlessClient0.UseVisualStyleBackColor = true;
            this.chkAffinityHeadlessClient0.CheckedChanged += new System.EventHandler(this.evntChkAffinityChange);
            // 
            // lblHCAffinity
            // 
            this.lblHCAffinity.AutoSize = true;
            this.lblHCAffinity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHCAffinity.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHCAffinity.Location = new System.Drawing.Point(204, 58);
            this.lblHCAffinity.Name = "lblHCAffinity";
            this.lblHCAffinity.Size = new System.Drawing.Size(144, 16);
            this.lblHCAffinity.TabIndex = 32;
            this.lblHCAffinity.Text = "Process Affinity (cores)";
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
            // 
            // tabPageProcessTS
            // 
            this.tabPageProcessTS.AutoScroll = true;
            this.tabPageProcessTS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.tabPageProcessTS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageProcessTS.Controls.Add(this.grpconfigTeamspeakLaunch);
            this.tabPageProcessTS.Controls.Add(this.chkAffinityTeamspeak7);
            this.tabPageProcessTS.Controls.Add(this.chkAffinityTeamspeak6);
            this.tabPageProcessTS.Controls.Add(this.chkAffinityTeamspeak5);
            this.tabPageProcessTS.Controls.Add(this.chkAffinityTeamspeak4);
            this.tabPageProcessTS.Controls.Add(this.chkAffinityTeamspeak3);
            this.tabPageProcessTS.Controls.Add(this.chkAffinityTeamspeak2);
            this.tabPageProcessTS.Controls.Add(this.chkAffinityTeamspeak1);
            this.tabPageProcessTS.Controls.Add(this.chkAffinityTeamspeak0);
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
            this.grpconfigTeamspeakLaunch.TabIndex = 45;
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
            this.numTeamspeakPortNumber.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.numTeamspeakPortNumber.ValueChanged += new System.EventHandler(this.actionTeamspeakPortChanged);
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
            // 
            // chkAffinityTeamspeak7
            // 
            this.chkAffinityTeamspeak7.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAffinityTeamspeak7.AutoSize = true;
            this.chkAffinityTeamspeak7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkAffinityTeamspeak7.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkAffinityTeamspeak7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAffinityTeamspeak7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAffinityTeamspeak7.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.chkAffinityTeamspeak7.Location = new System.Drawing.Point(522, 80);
            this.chkAffinityTeamspeak7.Name = "chkAffinityTeamspeak7";
            this.chkAffinityTeamspeak7.Size = new System.Drawing.Size(30, 23);
            this.chkAffinityTeamspeak7.TabIndex = 40;
            this.chkAffinityTeamspeak7.Text = "#7";
            this.chkAffinityTeamspeak7.UseVisualStyleBackColor = true;
            this.chkAffinityTeamspeak7.CheckedChanged += new System.EventHandler(this.evntChkAffinityChange);
            // 
            // chkAffinityTeamspeak6
            // 
            this.chkAffinityTeamspeak6.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAffinityTeamspeak6.AutoSize = true;
            this.chkAffinityTeamspeak6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkAffinityTeamspeak6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkAffinityTeamspeak6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAffinityTeamspeak6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAffinityTeamspeak6.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.chkAffinityTeamspeak6.Location = new System.Drawing.Point(477, 80);
            this.chkAffinityTeamspeak6.Name = "chkAffinityTeamspeak6";
            this.chkAffinityTeamspeak6.Size = new System.Drawing.Size(30, 23);
            this.chkAffinityTeamspeak6.TabIndex = 39;
            this.chkAffinityTeamspeak6.Text = "#6";
            this.chkAffinityTeamspeak6.UseVisualStyleBackColor = true;
            this.chkAffinityTeamspeak6.CheckedChanged += new System.EventHandler(this.evntChkAffinityChange);
            // 
            // chkAffinityTeamspeak5
            // 
            this.chkAffinityTeamspeak5.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAffinityTeamspeak5.AutoSize = true;
            this.chkAffinityTeamspeak5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkAffinityTeamspeak5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkAffinityTeamspeak5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAffinityTeamspeak5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAffinityTeamspeak5.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.chkAffinityTeamspeak5.Location = new System.Drawing.Point(432, 80);
            this.chkAffinityTeamspeak5.Name = "chkAffinityTeamspeak5";
            this.chkAffinityTeamspeak5.Size = new System.Drawing.Size(30, 23);
            this.chkAffinityTeamspeak5.TabIndex = 38;
            this.chkAffinityTeamspeak5.Text = "#5";
            this.chkAffinityTeamspeak5.UseVisualStyleBackColor = true;
            this.chkAffinityTeamspeak5.CheckedChanged += new System.EventHandler(this.evntChkAffinityChange);
            // 
            // chkAffinityTeamspeak4
            // 
            this.chkAffinityTeamspeak4.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAffinityTeamspeak4.AutoSize = true;
            this.chkAffinityTeamspeak4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkAffinityTeamspeak4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkAffinityTeamspeak4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAffinityTeamspeak4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAffinityTeamspeak4.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.chkAffinityTeamspeak4.Location = new System.Drawing.Point(387, 80);
            this.chkAffinityTeamspeak4.Name = "chkAffinityTeamspeak4";
            this.chkAffinityTeamspeak4.Size = new System.Drawing.Size(30, 23);
            this.chkAffinityTeamspeak4.TabIndex = 37;
            this.chkAffinityTeamspeak4.Text = "#4";
            this.chkAffinityTeamspeak4.UseVisualStyleBackColor = true;
            this.chkAffinityTeamspeak4.CheckedChanged += new System.EventHandler(this.evntChkAffinityChange);
            // 
            // chkAffinityTeamspeak3
            // 
            this.chkAffinityTeamspeak3.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAffinityTeamspeak3.AutoSize = true;
            this.chkAffinityTeamspeak3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkAffinityTeamspeak3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkAffinityTeamspeak3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAffinityTeamspeak3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAffinityTeamspeak3.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.chkAffinityTeamspeak3.Location = new System.Drawing.Point(342, 80);
            this.chkAffinityTeamspeak3.Name = "chkAffinityTeamspeak3";
            this.chkAffinityTeamspeak3.Size = new System.Drawing.Size(30, 23);
            this.chkAffinityTeamspeak3.TabIndex = 36;
            this.chkAffinityTeamspeak3.Text = "#3";
            this.chkAffinityTeamspeak3.UseVisualStyleBackColor = true;
            this.chkAffinityTeamspeak3.CheckedChanged += new System.EventHandler(this.evntChkAffinityChange);
            // 
            // chkAffinityTeamspeak2
            // 
            this.chkAffinityTeamspeak2.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAffinityTeamspeak2.AutoSize = true;
            this.chkAffinityTeamspeak2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkAffinityTeamspeak2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkAffinityTeamspeak2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAffinityTeamspeak2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAffinityTeamspeak2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.chkAffinityTeamspeak2.Location = new System.Drawing.Point(297, 80);
            this.chkAffinityTeamspeak2.Name = "chkAffinityTeamspeak2";
            this.chkAffinityTeamspeak2.Size = new System.Drawing.Size(30, 23);
            this.chkAffinityTeamspeak2.TabIndex = 35;
            this.chkAffinityTeamspeak2.Text = "#2";
            this.chkAffinityTeamspeak2.UseVisualStyleBackColor = true;
            this.chkAffinityTeamspeak2.CheckedChanged += new System.EventHandler(this.evntChkAffinityChange);
            // 
            // chkAffinityTeamspeak1
            // 
            this.chkAffinityTeamspeak1.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAffinityTeamspeak1.AutoSize = true;
            this.chkAffinityTeamspeak1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkAffinityTeamspeak1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkAffinityTeamspeak1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAffinityTeamspeak1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAffinityTeamspeak1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.chkAffinityTeamspeak1.Location = new System.Drawing.Point(252, 80);
            this.chkAffinityTeamspeak1.Name = "chkAffinityTeamspeak1";
            this.chkAffinityTeamspeak1.Size = new System.Drawing.Size(30, 23);
            this.chkAffinityTeamspeak1.TabIndex = 34;
            this.chkAffinityTeamspeak1.Text = "#1";
            this.chkAffinityTeamspeak1.UseVisualStyleBackColor = true;
            this.chkAffinityTeamspeak1.CheckedChanged += new System.EventHandler(this.evntChkAffinityChange);
            // 
            // chkAffinityTeamspeak0
            // 
            this.chkAffinityTeamspeak0.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAffinityTeamspeak0.AutoSize = true;
            this.chkAffinityTeamspeak0.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkAffinityTeamspeak0.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkAffinityTeamspeak0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAffinityTeamspeak0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAffinityTeamspeak0.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.chkAffinityTeamspeak0.Location = new System.Drawing.Point(207, 80);
            this.chkAffinityTeamspeak0.Name = "chkAffinityTeamspeak0";
            this.chkAffinityTeamspeak0.Size = new System.Drawing.Size(30, 23);
            this.chkAffinityTeamspeak0.TabIndex = 33;
            this.chkAffinityTeamspeak0.Text = "#0";
            this.chkAffinityTeamspeak0.UseVisualStyleBackColor = true;
            this.chkAffinityTeamspeak0.CheckedChanged += new System.EventHandler(this.evntChkAffinityChange);
            // 
            // lblTSAffinity
            // 
            this.lblTSAffinity.AutoSize = true;
            this.lblTSAffinity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTSAffinity.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTSAffinity.Location = new System.Drawing.Point(204, 58);
            this.lblTSAffinity.Name = "lblTSAffinity";
            this.lblTSAffinity.Size = new System.Drawing.Size(144, 16);
            this.lblTSAffinity.TabIndex = 32;
            this.lblTSAffinity.Text = "Process Affinity (cores)";
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
            // 
            // tabPageProcessASM
            // 
            this.tabPageProcessASM.AutoScroll = true;
            this.tabPageProcessASM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.tabPageProcessASM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageProcessASM.Controls.Add(this.grpConfigASMLaunch);
            this.tabPageProcessASM.Controls.Add(this.chkAffinityASM7);
            this.tabPageProcessASM.Controls.Add(this.chkAffinityASM6);
            this.tabPageProcessASM.Controls.Add(this.chkAffinityASM5);
            this.tabPageProcessASM.Controls.Add(this.chkAffinityASM4);
            this.tabPageProcessASM.Controls.Add(this.chkAffinityASM3);
            this.tabPageProcessASM.Controls.Add(this.chkAffinityASM2);
            this.tabPageProcessASM.Controls.Add(this.chkAffinityASM1);
            this.tabPageProcessASM.Controls.Add(this.chkAffinityASM0);
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
            this.grpConfigASMLaunch.TabIndex = 49;
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
            this.numASMLogInterval.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numASMLogInterval.ValueChanged += new System.EventHandler(this.actionASMLogIntervalChanged);
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
            this.btnFortxtASMLogName.Click += new System.EventHandler(this.actionBrowseButtonForFilePath);
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
            // 
            // chkAffinityASM7
            // 
            this.chkAffinityASM7.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAffinityASM7.AutoSize = true;
            this.chkAffinityASM7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkAffinityASM7.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkAffinityASM7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAffinityASM7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAffinityASM7.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.chkAffinityASM7.Location = new System.Drawing.Point(522, 80);
            this.chkAffinityASM7.Name = "chkAffinityASM7";
            this.chkAffinityASM7.Size = new System.Drawing.Size(30, 23);
            this.chkAffinityASM7.TabIndex = 40;
            this.chkAffinityASM7.Text = "#7";
            this.chkAffinityASM7.UseVisualStyleBackColor = true;
            this.chkAffinityASM7.CheckedChanged += new System.EventHandler(this.evntChkAffinityChange);
            // 
            // chkAffinityASM6
            // 
            this.chkAffinityASM6.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAffinityASM6.AutoSize = true;
            this.chkAffinityASM6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkAffinityASM6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkAffinityASM6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAffinityASM6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAffinityASM6.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.chkAffinityASM6.Location = new System.Drawing.Point(477, 80);
            this.chkAffinityASM6.Name = "chkAffinityASM6";
            this.chkAffinityASM6.Size = new System.Drawing.Size(30, 23);
            this.chkAffinityASM6.TabIndex = 39;
            this.chkAffinityASM6.Text = "#6";
            this.chkAffinityASM6.UseVisualStyleBackColor = true;
            this.chkAffinityASM6.CheckedChanged += new System.EventHandler(this.evntChkAffinityChange);
            // 
            // chkAffinityASM5
            // 
            this.chkAffinityASM5.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAffinityASM5.AutoSize = true;
            this.chkAffinityASM5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkAffinityASM5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkAffinityASM5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAffinityASM5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAffinityASM5.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.chkAffinityASM5.Location = new System.Drawing.Point(432, 80);
            this.chkAffinityASM5.Name = "chkAffinityASM5";
            this.chkAffinityASM5.Size = new System.Drawing.Size(30, 23);
            this.chkAffinityASM5.TabIndex = 38;
            this.chkAffinityASM5.Text = "#5";
            this.chkAffinityASM5.UseVisualStyleBackColor = true;
            this.chkAffinityASM5.CheckedChanged += new System.EventHandler(this.evntChkAffinityChange);
            // 
            // chkAffinityASM4
            // 
            this.chkAffinityASM4.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAffinityASM4.AutoSize = true;
            this.chkAffinityASM4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkAffinityASM4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkAffinityASM4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAffinityASM4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAffinityASM4.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.chkAffinityASM4.Location = new System.Drawing.Point(387, 80);
            this.chkAffinityASM4.Name = "chkAffinityASM4";
            this.chkAffinityASM4.Size = new System.Drawing.Size(30, 23);
            this.chkAffinityASM4.TabIndex = 37;
            this.chkAffinityASM4.Text = "#4";
            this.chkAffinityASM4.UseVisualStyleBackColor = true;
            this.chkAffinityASM4.CheckedChanged += new System.EventHandler(this.evntChkAffinityChange);
            // 
            // chkAffinityASM3
            // 
            this.chkAffinityASM3.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAffinityASM3.AutoSize = true;
            this.chkAffinityASM3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkAffinityASM3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkAffinityASM3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAffinityASM3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAffinityASM3.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.chkAffinityASM3.Location = new System.Drawing.Point(342, 80);
            this.chkAffinityASM3.Name = "chkAffinityASM3";
            this.chkAffinityASM3.Size = new System.Drawing.Size(30, 23);
            this.chkAffinityASM3.TabIndex = 36;
            this.chkAffinityASM3.Text = "#3";
            this.chkAffinityASM3.UseVisualStyleBackColor = true;
            this.chkAffinityASM3.CheckedChanged += new System.EventHandler(this.evntChkAffinityChange);
            // 
            // chkAffinityASM2
            // 
            this.chkAffinityASM2.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAffinityASM2.AutoSize = true;
            this.chkAffinityASM2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkAffinityASM2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkAffinityASM2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAffinityASM2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAffinityASM2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.chkAffinityASM2.Location = new System.Drawing.Point(297, 80);
            this.chkAffinityASM2.Name = "chkAffinityASM2";
            this.chkAffinityASM2.Size = new System.Drawing.Size(30, 23);
            this.chkAffinityASM2.TabIndex = 35;
            this.chkAffinityASM2.Text = "#2";
            this.chkAffinityASM2.UseVisualStyleBackColor = true;
            this.chkAffinityASM2.CheckedChanged += new System.EventHandler(this.evntChkAffinityChange);
            // 
            // chkAffinityASM1
            // 
            this.chkAffinityASM1.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAffinityASM1.AutoSize = true;
            this.chkAffinityASM1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkAffinityASM1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkAffinityASM1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAffinityASM1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAffinityASM1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.chkAffinityASM1.Location = new System.Drawing.Point(252, 80);
            this.chkAffinityASM1.Name = "chkAffinityASM1";
            this.chkAffinityASM1.Size = new System.Drawing.Size(30, 23);
            this.chkAffinityASM1.TabIndex = 34;
            this.chkAffinityASM1.Text = "#1";
            this.chkAffinityASM1.UseVisualStyleBackColor = true;
            this.chkAffinityASM1.CheckedChanged += new System.EventHandler(this.evntChkAffinityChange);
            // 
            // chkAffinityASM0
            // 
            this.chkAffinityASM0.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAffinityASM0.AutoSize = true;
            this.chkAffinityASM0.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkAffinityASM0.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkAffinityASM0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAffinityASM0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAffinityASM0.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.chkAffinityASM0.Location = new System.Drawing.Point(207, 80);
            this.chkAffinityASM0.Name = "chkAffinityASM0";
            this.chkAffinityASM0.Size = new System.Drawing.Size(30, 23);
            this.chkAffinityASM0.TabIndex = 33;
            this.chkAffinityASM0.Text = "#0";
            this.chkAffinityASM0.UseVisualStyleBackColor = true;
            this.chkAffinityASM0.CheckedChanged += new System.EventHandler(this.evntChkAffinityChange);
            // 
            // lblASMAffinity
            // 
            this.lblASMAffinity.AutoSize = true;
            this.lblASMAffinity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblASMAffinity.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblASMAffinity.Location = new System.Drawing.Point(204, 58);
            this.lblASMAffinity.Name = "lblASMAffinity";
            this.lblASMAffinity.Size = new System.Drawing.Size(144, 16);
            this.lblASMAffinity.TabIndex = 32;
            this.lblASMAffinity.Text = "Process Affinity (cores)";
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
            // 
            // frmConfigWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(630, 572);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configure your SKBT installation";
            this.tabControlMainConfig.ResumeLayout(false);
            this.tabPageProcessServer.ResumeLayout(false);
            this.tabPageProcessServer.PerformLayout();
            this.grpConfigServerBackup.ResumeLayout(false);
            this.grpConfigServerBackup.PerformLayout();
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
        private System.Windows.Forms.CheckBox chkAffinityServer7;
        private System.Windows.Forms.CheckBox chkAffinityServer6;
        private System.Windows.Forms.CheckBox chkAffinityServer5;
        private System.Windows.Forms.CheckBox chkAffinityServer4;
        private System.Windows.Forms.CheckBox chkAffinityServer3;
        private System.Windows.Forms.CheckBox chkAffinityServer2;
        private System.Windows.Forms.CheckBox chkAffinityServer1;
        private System.Windows.Forms.CheckBox chkAffinityServer0;
        private System.Windows.Forms.Label lblServerAffinity;
        private System.Windows.Forms.Label lblerverPriority;
        private System.Windows.Forms.ComboBox cBoxPriorityServer;
        private System.Windows.Forms.CheckBox chkAffinityDatabase7;
        private System.Windows.Forms.CheckBox chkAffinityDatabase6;
        private System.Windows.Forms.CheckBox chkAffinityDatabase5;
        private System.Windows.Forms.CheckBox chkAffinityDatabase4;
        private System.Windows.Forms.CheckBox chkAffinityDatabase3;
        private System.Windows.Forms.CheckBox chkAffinityDatabase2;
        private System.Windows.Forms.CheckBox chkAffinityDatabase1;
        private System.Windows.Forms.CheckBox chkAffinityDatabase0;
        private System.Windows.Forms.Label lvlDatabaseAffinity;
        private System.Windows.Forms.Label lblDatabasePriority;
        private System.Windows.Forms.ComboBox cBoxPriorityDatabase;
        private System.Windows.Forms.Button btnProcessKeepaliveDatabase;
        private System.Windows.Forms.Button btnFortxtPathToEXEDB;
        private System.Windows.Forms.Label lblDatabasePathToExe;
        private System.Windows.Forms.TextBox txtPathToEXEDB;
        private System.Windows.Forms.CheckBox chkAffinityBEC7;
        private System.Windows.Forms.CheckBox chkAffinityBEC6;
        private System.Windows.Forms.CheckBox chkAffinityBEC5;
        private System.Windows.Forms.CheckBox chkAffinityBEC4;
        private System.Windows.Forms.CheckBox chkAffinityBEC3;
        private System.Windows.Forms.CheckBox chkAffinityBEC2;
        private System.Windows.Forms.CheckBox chkAffinityBEC1;
        private System.Windows.Forms.CheckBox chkAffinityBEC0;
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
        private System.Windows.Forms.CheckBox chkAffinityHeadlessClient7;
        private System.Windows.Forms.CheckBox chkAffinityHeadlessClient6;
        private System.Windows.Forms.CheckBox chkAffinityHeadlessClient5;
        private System.Windows.Forms.CheckBox chkAffinityHeadlessClient4;
        private System.Windows.Forms.CheckBox chkAffinityHeadlessClient3;
        private System.Windows.Forms.CheckBox chkAffinityHeadlessClient2;
        private System.Windows.Forms.CheckBox chkAffinityHeadlessClient1;
        private System.Windows.Forms.CheckBox chkAffinityHeadlessClient0;
        private System.Windows.Forms.Label lblHCAffinity;
        private System.Windows.Forms.Label lblHCPriority;
        private System.Windows.Forms.ComboBox cBoxPriorityHeadlessClient;
        private System.Windows.Forms.Button btnProcessKeepaliveHC;
        private System.Windows.Forms.Button btnFortxtPathToEXEHC;
        private System.Windows.Forms.Label lblHCPathToExe;
        private System.Windows.Forms.TextBox txtPathToEXEHC;
        private System.Windows.Forms.TabPage tabPageProcessTS;
        private System.Windows.Forms.CheckBox chkAffinityTeamspeak7;
        private System.Windows.Forms.CheckBox chkAffinityTeamspeak6;
        private System.Windows.Forms.CheckBox chkAffinityTeamspeak5;
        private System.Windows.Forms.CheckBox chkAffinityTeamspeak4;
        private System.Windows.Forms.CheckBox chkAffinityTeamspeak3;
        private System.Windows.Forms.CheckBox chkAffinityTeamspeak2;
        private System.Windows.Forms.CheckBox chkAffinityTeamspeak1;
        private System.Windows.Forms.CheckBox chkAffinityTeamspeak0;
        private System.Windows.Forms.Label lblTSAffinity;
        private System.Windows.Forms.Label lblTSPriority;
        private System.Windows.Forms.ComboBox cBoxPriorityTeamspeak;
        private System.Windows.Forms.Button btnProcessKeepaliveTS;
        private System.Windows.Forms.Button btnFortxtPathToEXETS;
        private System.Windows.Forms.Label lblTSPathToExe;
        private System.Windows.Forms.TextBox txtPathToEXETS;
        private System.Windows.Forms.TabPage tabPageProcessASM;
        private System.Windows.Forms.CheckBox chkAffinityASM7;
        private System.Windows.Forms.CheckBox chkAffinityASM6;
        private System.Windows.Forms.CheckBox chkAffinityASM5;
        private System.Windows.Forms.CheckBox chkAffinityASM4;
        private System.Windows.Forms.CheckBox chkAffinityASM3;
        private System.Windows.Forms.CheckBox chkAffinityASM2;
        private System.Windows.Forms.CheckBox chkAffinityASM1;
        private System.Windows.Forms.CheckBox chkAffinityASM0;
        private System.Windows.Forms.Label lblASMAffinity;
        private System.Windows.Forms.Label lblASMPriority;
        private System.Windows.Forms.ComboBox cBoxPriorityASM;
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
        private System.Windows.Forms.GroupBox grpConfigServerBackup;
        private System.Windows.Forms.CheckBox chkUseZipLogs;
        private System.Windows.Forms.Button btnFortxtPathToBackupLog;
        private System.Windows.Forms.Label lblServerPathToLogBackup;
        private System.Windows.Forms.TextBox txtPathToBackupLog;
        private System.Windows.Forms.Button btnFortxtPathToServerLog;
        private System.Windows.Forms.Label lblServerPathToLog;
        private System.Windows.Forms.TextBox txtPathToServerLog;
        private System.Windows.Forms.GroupBox grpConfigDatabaseBackup;
        private System.Windows.Forms.CheckBox chkUseZipBackups;
        private System.Windows.Forms.Button btnFortxtPathToBackupFolder;
        private System.Windows.Forms.Label lblDatabaseBackupFolder;
        private System.Windows.Forms.TextBox txtPathToBackupFolder;
        private System.Windows.Forms.Button btnFortxtPathToDBFile;
        private System.Windows.Forms.Label lblDatabaseDumpFile;
        private System.Windows.Forms.TextBox txtPathToDBFile;
        private System.Windows.Forms.Label lblDatabaseBackupInterval;
        private System.Windows.Forms.Button btnFortxtPathToBattleye;
        private System.Windows.Forms.Label lblBECBEPath;
        private System.Windows.Forms.TextBox txtPathToBattleye;
        private System.Windows.Forms.TextBox txtHeadlessClientLaunchArgs;
        private System.Windows.Forms.Label lblHCLaunchArgs;
        private System.Windows.Forms.Label lblTSPort;
        private System.Windows.Forms.TextBox txtASMLogName;
        private System.Windows.Forms.Label lblASMLogName;
        private System.Windows.Forms.Label lblASMLoggingInterval;
        private System.Windows.Forms.GroupBox grpConfigBECBackup;
        private System.Windows.Forms.GroupBox grpConfigHCLaunch;
        private System.Windows.Forms.GroupBox grpconfigTeamspeakLaunch;
        private System.Windows.Forms.GroupBox grpConfigASMLaunch;
        private System.Windows.Forms.FolderBrowserDialog folderBrowseDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnFortxtASMLogName;
        private System.Windows.Forms.NumericUpDown numTeamspeakPortNumber;
        private System.Windows.Forms.NumericUpDown numServerPort;
        private System.Windows.Forms.NumericUpDown numBackupInterval;
        private System.Windows.Forms.NumericUpDown numASMLogInterval;
        private System.Windows.Forms.CheckBox chkServerBindToIP;
        private System.Windows.Forms.NumericUpDown numServerIP4;
        private System.Windows.Forms.NumericUpDown numServerIP3;
        private System.Windows.Forms.NumericUpDown numServerIP2;
        private System.Windows.Forms.NumericUpDown numServerIP1;
        private System.Windows.Forms.Label lvlServerIP;
    }
}