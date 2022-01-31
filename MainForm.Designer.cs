namespace SharePointSiteOwnerTools
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblSiteUrl = new System.Windows.Forms.Label();
            this.txtBoxSiteUrl = new System.Windows.Forms.TextBox();
            this.btnTestAccess = new System.Windows.Forms.Button();
            this.btnSetSite = new System.Windows.Forms.Button();
            this.grpBoxCurrentStatus = new System.Windows.Forms.GroupBox();
            this.chkboxIsSiteAdmin = new System.Windows.Forms.CheckBox();
            this.txtBoxCurrentAuthUser = new System.Windows.Forms.TextBox();
            this.lblCurrentAuthUser = new System.Windows.Forms.Label();
            this.txtBoxCurrentStatus_BaseSiteSetAs = new System.Windows.Forms.TextBox();
            this.lblCurrentStatus_CurrentSite = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBaseSiteDetails = new System.Windows.Forms.Button();
            this.btnRetrieveAllSiteLists = new System.Windows.Forms.Button();
            this.btnOpenSiteInDefaultBrowser = new System.Windows.Forms.Button();
            this.btnGetSitePermissions = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnGetSiteStructureTree = new System.Windows.Forms.Button();
            this.toolBoxSiteInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.ToolBoxPermissionsGroupBox = new System.Windows.Forms.GroupBox();
            this.ToolBoxBackupGroupBox = new System.Windows.Forms.GroupBox();
            this.grpBoxCurrentStatus.SuspendLayout();
            this.toolBoxSiteInformationGroupBox.SuspendLayout();
            this.ToolBoxPermissionsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSiteUrl
            // 
            this.lblSiteUrl.AutoSize = true;
            this.lblSiteUrl.Location = new System.Drawing.Point(64, 26);
            this.lblSiteUrl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSiteUrl.Name = "lblSiteUrl";
            this.lblSiteUrl.Size = new System.Drawing.Size(81, 25);
            this.lblSiteUrl.TabIndex = 0;
            this.lblSiteUrl.Text = "Site Url:";
            this.lblSiteUrl.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // txtBoxSiteUrl
            // 
            this.txtBoxSiteUrl.Location = new System.Drawing.Point(156, 13);
            this.txtBoxSiteUrl.Margin = new System.Windows.Forms.Padding(6);
            this.txtBoxSiteUrl.Name = "txtBoxSiteUrl";
            this.txtBoxSiteUrl.Size = new System.Drawing.Size(1088, 29);
            this.txtBoxSiteUrl.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtBoxSiteUrl, "Has to Prefix with https:// - Enter Your SP Base Site URL");
            this.txtBoxSiteUrl.TextChanged += new System.EventHandler(this.txtBoxSiteUrl_TextChanged);
            // 
            // btnTestAccess
            // 
            this.btnTestAccess.Location = new System.Drawing.Point(1406, 9);
            this.btnTestAccess.Margin = new System.Windows.Forms.Padding(6);
            this.btnTestAccess.Name = "btnTestAccess";
            this.btnTestAccess.Size = new System.Drawing.Size(207, 42);
            this.btnTestAccess.TabIndex = 2;
            this.btnTestAccess.Text = "Test Access to Site";
            this.toolTip1.SetToolTip(this.btnTestAccess, "Will open in default browser to complete Auth");
            this.btnTestAccess.UseVisualStyleBackColor = true;
            this.btnTestAccess.Click += new System.EventHandler(this.btnTestAccess_Click);
            // 
            // btnSetSite
            // 
            this.btnSetSite.Location = new System.Drawing.Point(1258, 9);
            this.btnSetSite.Margin = new System.Windows.Forms.Padding(6);
            this.btnSetSite.Name = "btnSetSite";
            this.btnSetSite.Size = new System.Drawing.Size(138, 42);
            this.btnSetSite.TabIndex = 3;
            this.btnSetSite.Text = "Set Site";
            this.toolTip1.SetToolTip(this.btnSetSite, "Save SP Site as Base Site");
            this.btnSetSite.UseVisualStyleBackColor = true;
            this.btnSetSite.Click += new System.EventHandler(this.btnSetSite_Click);
            // 
            // grpBoxCurrentStatus
            // 
            this.grpBoxCurrentStatus.Controls.Add(this.chkboxIsSiteAdmin);
            this.grpBoxCurrentStatus.Controls.Add(this.txtBoxCurrentAuthUser);
            this.grpBoxCurrentStatus.Controls.Add(this.lblCurrentAuthUser);
            this.grpBoxCurrentStatus.Controls.Add(this.txtBoxCurrentStatus_BaseSiteSetAs);
            this.grpBoxCurrentStatus.Controls.Add(this.lblCurrentStatus_CurrentSite);
            this.grpBoxCurrentStatus.Location = new System.Drawing.Point(975, 838);
            this.grpBoxCurrentStatus.Margin = new System.Windows.Forms.Padding(6);
            this.grpBoxCurrentStatus.Name = "grpBoxCurrentStatus";
            this.grpBoxCurrentStatus.Padding = new System.Windows.Forms.Padding(6);
            this.grpBoxCurrentStatus.Size = new System.Drawing.Size(1008, 301);
            this.grpBoxCurrentStatus.TabIndex = 4;
            this.grpBoxCurrentStatus.TabStop = false;
            this.grpBoxCurrentStatus.Text = "Current Status";
            // 
            // chkboxIsSiteAdmin
            // 
            this.chkboxIsSiteAdmin.AutoSize = true;
            this.chkboxIsSiteAdmin.Location = new System.Drawing.Point(838, 150);
            this.chkboxIsSiteAdmin.Margin = new System.Windows.Forms.Padding(6);
            this.chkboxIsSiteAdmin.Name = "chkboxIsSiteAdmin";
            this.chkboxIsSiteAdmin.Size = new System.Drawing.Size(153, 29);
            this.chkboxIsSiteAdmin.TabIndex = 5;
            this.chkboxIsSiteAdmin.Text = "Is Site Admin";
            this.toolTip1.SetToolTip(this.chkboxIsSiteAdmin, "Determined and Saved after \'Test Access To Site\' is performed");
            this.chkboxIsSiteAdmin.UseVisualStyleBackColor = true;
            // 
            // txtBoxCurrentAuthUser
            // 
            this.txtBoxCurrentAuthUser.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SharePointSiteOwnerTools.Properties.Settings.Default, "currentAuthUser", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtBoxCurrentAuthUser.Location = new System.Drawing.Point(18, 181);
            this.txtBoxCurrentAuthUser.Margin = new System.Windows.Forms.Padding(6);
            this.txtBoxCurrentAuthUser.Name = "txtBoxCurrentAuthUser";
            this.txtBoxCurrentAuthUser.ReadOnly = true;
            this.txtBoxCurrentAuthUser.Size = new System.Drawing.Size(976, 29);
            this.txtBoxCurrentAuthUser.TabIndex = 4;
            this.txtBoxCurrentAuthUser.Text = global::SharePointSiteOwnerTools.Properties.Settings.Default.currentAuthUser;
            this.toolTip1.SetToolTip(this.txtBoxCurrentAuthUser, "Determined and Saved after \'Test Access To Site\' is performed");
            // 
            // lblCurrentAuthUser
            // 
            this.lblCurrentAuthUser.AutoSize = true;
            this.lblCurrentAuthUser.Location = new System.Drawing.Point(13, 151);
            this.lblCurrentAuthUser.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCurrentAuthUser.Name = "lblCurrentAuthUser";
            this.lblCurrentAuthUser.Size = new System.Drawing.Size(175, 25);
            this.lblCurrentAuthUser.TabIndex = 3;
            this.lblCurrentAuthUser.Text = "Current Auth User:";
            // 
            // txtBoxCurrentStatus_BaseSiteSetAs
            // 
            this.txtBoxCurrentStatus_BaseSiteSetAs.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SharePointSiteOwnerTools.Properties.Settings.Default, "currentBaseUrl", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtBoxCurrentStatus_BaseSiteSetAs.Location = new System.Drawing.Point(18, 260);
            this.txtBoxCurrentStatus_BaseSiteSetAs.Margin = new System.Windows.Forms.Padding(6);
            this.txtBoxCurrentStatus_BaseSiteSetAs.Name = "txtBoxCurrentStatus_BaseSiteSetAs";
            this.txtBoxCurrentStatus_BaseSiteSetAs.ReadOnly = true;
            this.txtBoxCurrentStatus_BaseSiteSetAs.Size = new System.Drawing.Size(976, 29);
            this.txtBoxCurrentStatus_BaseSiteSetAs.TabIndex = 2;
            this.txtBoxCurrentStatus_BaseSiteSetAs.Text = global::SharePointSiteOwnerTools.Properties.Settings.Default.currentBaseUrl;
            this.toolTip1.SetToolTip(this.txtBoxCurrentStatus_BaseSiteSetAs, "Determined and Saved after \'Test Access To Site\' is performed");
            // 
            // lblCurrentStatus_CurrentSite
            // 
            this.lblCurrentStatus_CurrentSite.AutoSize = true;
            this.lblCurrentStatus_CurrentSite.Location = new System.Drawing.Point(13, 223);
            this.lblCurrentStatus_CurrentSite.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCurrentStatus_CurrentSite.Name = "lblCurrentStatus_CurrentSite";
            this.lblCurrentStatus_CurrentSite.Size = new System.Drawing.Size(159, 25);
            this.lblCurrentStatus_CurrentSite.TabIndex = 0;
            this.lblCurrentStatus_CurrentSite.Text = "Base Site set as:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1995, 1115);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(119, 48);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "EXIT";
            this.toolTip1.SetToolTip(this.btnExit, "Exit SharePoint Site Owner Tools");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBaseSiteDetails
            // 
            this.btnBaseSiteDetails.Location = new System.Drawing.Point(9, 31);
            this.btnBaseSiteDetails.Margin = new System.Windows.Forms.Padding(6);
            this.btnBaseSiteDetails.Name = "btnBaseSiteDetails";
            this.btnBaseSiteDetails.Size = new System.Drawing.Size(271, 42);
            this.btnBaseSiteDetails.TabIndex = 6;
            this.btnBaseSiteDetails.Text = "Get Base Site Details";
            this.toolTip1.SetToolTip(this.btnBaseSiteDetails, "Retrieves all available Base Site perimeters");
            this.btnBaseSiteDetails.UseVisualStyleBackColor = true;
            this.btnBaseSiteDetails.Click += new System.EventHandler(this.btnBaseSiteDetails_Click);
            // 
            // btnRetrieveAllSiteLists
            // 
            this.btnRetrieveAllSiteLists.Location = new System.Drawing.Point(9, 139);
            this.btnRetrieveAllSiteLists.Margin = new System.Windows.Forms.Padding(6);
            this.btnRetrieveAllSiteLists.Name = "btnRetrieveAllSiteLists";
            this.btnRetrieveAllSiteLists.Size = new System.Drawing.Size(271, 42);
            this.btnRetrieveAllSiteLists.TabIndex = 7;
            this.btnRetrieveAllSiteLists.Text = "Retrieve All Site Lists";
            this.toolTip1.SetToolTip(this.btnRetrieveAllSiteLists, "Gathers All Site Lists");
            this.btnRetrieveAllSiteLists.UseVisualStyleBackColor = true;
            this.btnRetrieveAllSiteLists.Click += new System.EventHandler(this.btnRetrieveAllSiteLists_Click);
            // 
            // btnOpenSiteInDefaultBrowser
            // 
            this.btnOpenSiteInDefaultBrowser.Location = new System.Drawing.Point(1624, 9);
            this.btnOpenSiteInDefaultBrowser.Margin = new System.Windows.Forms.Padding(6);
            this.btnOpenSiteInDefaultBrowser.Name = "btnOpenSiteInDefaultBrowser";
            this.btnOpenSiteInDefaultBrowser.Size = new System.Drawing.Size(279, 42);
            this.btnOpenSiteInDefaultBrowser.TabIndex = 8;
            this.btnOpenSiteInDefaultBrowser.Text = "Open site in Default Browser";
            this.toolTip1.SetToolTip(this.btnOpenSiteInDefaultBrowser, "Open SP Base Site in your Default Browser");
            this.btnOpenSiteInDefaultBrowser.UseVisualStyleBackColor = true;
            this.btnOpenSiteInDefaultBrowser.Click += new System.EventHandler(this.btnOpenSiteInDefaultBrowser_Click);
            // 
            // btnGetSitePermissions
            // 
            this.btnGetSitePermissions.Location = new System.Drawing.Point(9, 31);
            this.btnGetSitePermissions.Margin = new System.Windows.Forms.Padding(6);
            this.btnGetSitePermissions.Name = "btnGetSitePermissions";
            this.btnGetSitePermissions.Size = new System.Drawing.Size(271, 42);
            this.btnGetSitePermissions.TabIndex = 11;
            this.btnGetSitePermissions.Text = "Get Base Site Permissions";
            this.toolTip1.SetToolTip(this.btnGetSitePermissions, "Retrieve Base Site Permission Groups and Users");
            this.btnGetSitePermissions.UseVisualStyleBackColor = true;
            this.btnGetSitePermissions.Click += new System.EventHandler(this.btnGetSitePermissions_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // btnGetSiteStructureTree
            // 
            this.btnGetSiteStructureTree.Location = new System.Drawing.Point(9, 85);
            this.btnGetSiteStructureTree.Margin = new System.Windows.Forms.Padding(6);
            this.btnGetSiteStructureTree.Name = "btnGetSiteStructureTree";
            this.btnGetSiteStructureTree.Size = new System.Drawing.Size(271, 42);
            this.btnGetSiteStructureTree.TabIndex = 13;
            this.btnGetSiteStructureTree.Text = "Get Site Structure Tree";
            this.toolTip1.SetToolTip(this.btnGetSiteStructureTree, "Shows Main Site and SubSite in Tree Form");
            this.btnGetSiteStructureTree.UseVisualStyleBackColor = true;
            this.btnGetSiteStructureTree.Click += new System.EventHandler(this.btnGetSiteStructureTree_Click);
            // 
            // toolBoxSiteInformationGroupBox
            // 
            this.toolBoxSiteInformationGroupBox.Controls.Add(this.btnBaseSiteDetails);
            this.toolBoxSiteInformationGroupBox.Controls.Add(this.btnGetSiteStructureTree);
            this.toolBoxSiteInformationGroupBox.Controls.Add(this.btnRetrieveAllSiteLists);
            this.toolBoxSiteInformationGroupBox.Location = new System.Drawing.Point(156, 170);
            this.toolBoxSiteInformationGroupBox.Name = "toolBoxSiteInformationGroupBox";
            this.toolBoxSiteInformationGroupBox.Size = new System.Drawing.Size(664, 197);
            this.toolBoxSiteInformationGroupBox.TabIndex = 14;
            this.toolBoxSiteInformationGroupBox.TabStop = false;
            this.toolBoxSiteInformationGroupBox.Text = "Tool Box - Site Information";
            // 
            // ToolBoxPermissionsGroupBox
            // 
            this.ToolBoxPermissionsGroupBox.Controls.Add(this.btnGetSitePermissions);
            this.ToolBoxPermissionsGroupBox.Location = new System.Drawing.Point(852, 170);
            this.ToolBoxPermissionsGroupBox.Name = "ToolBoxPermissionsGroupBox";
            this.ToolBoxPermissionsGroupBox.Size = new System.Drawing.Size(649, 197);
            this.ToolBoxPermissionsGroupBox.TabIndex = 15;
            this.ToolBoxPermissionsGroupBox.TabStop = false;
            this.ToolBoxPermissionsGroupBox.Text = "Tool Box - Permissions";
            // 
            // ToolBoxBackupGroupBox
            // 
            this.ToolBoxBackupGroupBox.Location = new System.Drawing.Point(156, 406);
            this.ToolBoxBackupGroupBox.Name = "ToolBoxBackupGroupBox";
            this.ToolBoxBackupGroupBox.Size = new System.Drawing.Size(664, 192);
            this.ToolBoxBackupGroupBox.TabIndex = 16;
            this.ToolBoxBackupGroupBox.TabStop = false;
            this.ToolBoxBackupGroupBox.Text = "Tool Box - Backup";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2143, 1169);
            this.Controls.Add(this.ToolBoxBackupGroupBox);
            this.Controls.Add(this.ToolBoxPermissionsGroupBox);
            this.Controls.Add(this.toolBoxSiteInformationGroupBox);
            this.Controls.Add(this.btnOpenSiteInDefaultBrowser);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpBoxCurrentStatus);
            this.Controls.Add(this.btnSetSite);
            this.Controls.Add(this.btnTestAccess);
            this.Controls.Add(this.txtBoxSiteUrl);
            this.Controls.Add(this.lblSiteUrl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.Text = "SharePoint Site Owner Tools";
            this.grpBoxCurrentStatus.ResumeLayout(false);
            this.grpBoxCurrentStatus.PerformLayout();
            this.toolBoxSiteInformationGroupBox.ResumeLayout(false);
            this.ToolBoxPermissionsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSiteUrl;
        private System.Windows.Forms.TextBox txtBoxSiteUrl;
        private System.Windows.Forms.Button btnTestAccess;
        private System.Windows.Forms.Button btnSetSite;
        private System.Windows.Forms.GroupBox grpBoxCurrentStatus;
        private System.Windows.Forms.Label lblCurrentStatus_CurrentSite;
        public System.Windows.Forms.TextBox txtBoxCurrentStatus_BaseSiteSetAs;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBaseSiteDetails;
        private System.Windows.Forms.Button btnRetrieveAllSiteLists;
        public System.Windows.Forms.TextBox txtBoxCurrentAuthUser;
        private System.Windows.Forms.Label lblCurrentAuthUser;
        private System.Windows.Forms.CheckBox chkboxIsSiteAdmin;
        private System.Windows.Forms.Button btnOpenSiteInDefaultBrowser;
        private System.Windows.Forms.Button btnGetSitePermissions;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnGetSiteStructureTree;
        private System.Windows.Forms.GroupBox toolBoxSiteInformationGroupBox;
        private System.Windows.Forms.GroupBox ToolBoxPermissionsGroupBox;
        private System.Windows.Forms.GroupBox ToolBoxBackupGroupBox;
    }
}

