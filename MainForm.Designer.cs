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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblSiteUrl = new System.Windows.Forms.Label();
            this.txtBoxSiteUrl = new System.Windows.Forms.TextBox();
            this.btnTestAccess = new System.Windows.Forms.Button();
            this.btnSetSite = new System.Windows.Forms.Button();
            this.grpBoxCurrentStatus = new System.Windows.Forms.GroupBox();
            this.lblCurrentStatus_CurrentSite = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBaseSiteDetails = new System.Windows.Forms.Button();
            this.btnRetrieveAllSiteLists = new System.Windows.Forms.Button();
            this.lblCurrentAuthUser = new System.Windows.Forms.Label();
            this.chkboxIsSiteAdmin = new System.Windows.Forms.CheckBox();
            this.btnOpenSiteInDefaultBrowser = new System.Windows.Forms.Button();
            this.txtBoxCurrentAuthUser = new System.Windows.Forms.TextBox();
            this.txtBoxCurrentStatus_BaseSiteSetAs = new System.Windows.Forms.TextBox();
            this.lstBoxMemberGroups = new System.Windows.Forms.ListBox();
            this.btnRetrieveSiteMemberGroups = new System.Windows.Forms.Button();
            this.grpBoxCurrentStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSiteUrl
            // 
            this.lblSiteUrl.AutoSize = true;
            this.lblSiteUrl.Location = new System.Drawing.Point(35, 14);
            this.lblSiteUrl.Name = "lblSiteUrl";
            this.lblSiteUrl.Size = new System.Drawing.Size(44, 13);
            this.lblSiteUrl.TabIndex = 0;
            this.lblSiteUrl.Text = "Site Url:";
            this.lblSiteUrl.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // txtBoxSiteUrl
            // 
            this.txtBoxSiteUrl.Location = new System.Drawing.Point(85, 7);
            this.txtBoxSiteUrl.Name = "txtBoxSiteUrl";
            this.txtBoxSiteUrl.Size = new System.Drawing.Size(595, 20);
            this.txtBoxSiteUrl.TabIndex = 1;
            this.txtBoxSiteUrl.TextChanged += new System.EventHandler(this.txtBoxSiteUrl_TextChanged);
            // 
            // btnTestAccess
            // 
            this.btnTestAccess.Location = new System.Drawing.Point(767, 5);
            this.btnTestAccess.Name = "btnTestAccess";
            this.btnTestAccess.Size = new System.Drawing.Size(113, 23);
            this.btnTestAccess.TabIndex = 2;
            this.btnTestAccess.Text = "Test Access to Site";
            this.btnTestAccess.UseVisualStyleBackColor = true;
            this.btnTestAccess.Click += new System.EventHandler(this.btnTestAccess_Click);
            // 
            // btnSetSite
            // 
            this.btnSetSite.Location = new System.Drawing.Point(686, 5);
            this.btnSetSite.Name = "btnSetSite";
            this.btnSetSite.Size = new System.Drawing.Size(75, 23);
            this.btnSetSite.TabIndex = 3;
            this.btnSetSite.Text = "Set Site";
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
            this.grpBoxCurrentStatus.Location = new System.Drawing.Point(532, 454);
            this.grpBoxCurrentStatus.Name = "grpBoxCurrentStatus";
            this.grpBoxCurrentStatus.Size = new System.Drawing.Size(550, 163);
            this.grpBoxCurrentStatus.TabIndex = 4;
            this.grpBoxCurrentStatus.TabStop = false;
            this.grpBoxCurrentStatus.Text = "Current Status";
            // 
            // lblCurrentStatus_CurrentSite
            // 
            this.lblCurrentStatus_CurrentSite.AutoSize = true;
            this.lblCurrentStatus_CurrentSite.Location = new System.Drawing.Point(7, 121);
            this.lblCurrentStatus_CurrentSite.Name = "lblCurrentStatus_CurrentSite";
            this.lblCurrentStatus_CurrentSite.Size = new System.Drawing.Size(86, 13);
            this.lblCurrentStatus_CurrentSite.TabIndex = 0;
            this.lblCurrentStatus_CurrentSite.Text = "Base Site set as:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1088, 604);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(65, 26);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBaseSiteDetails
            // 
            this.btnBaseSiteDetails.Location = new System.Drawing.Point(532, 34);
            this.btnBaseSiteDetails.Name = "btnBaseSiteDetails";
            this.btnBaseSiteDetails.Size = new System.Drawing.Size(148, 23);
            this.btnBaseSiteDetails.TabIndex = 6;
            this.btnBaseSiteDetails.Text = "Get Base Site Details";
            this.btnBaseSiteDetails.UseVisualStyleBackColor = true;
            this.btnBaseSiteDetails.Click += new System.EventHandler(this.btnBaseSiteDetails_Click);
            // 
            // btnRetrieveAllSiteLists
            // 
            this.btnRetrieveAllSiteLists.Location = new System.Drawing.Point(532, 63);
            this.btnRetrieveAllSiteLists.Name = "btnRetrieveAllSiteLists";
            this.btnRetrieveAllSiteLists.Size = new System.Drawing.Size(148, 23);
            this.btnRetrieveAllSiteLists.TabIndex = 7;
            this.btnRetrieveAllSiteLists.Text = "Retrieve All Site Lists";
            this.btnRetrieveAllSiteLists.UseVisualStyleBackColor = true;
            this.btnRetrieveAllSiteLists.Click += new System.EventHandler(this.btnRetrieveAllSiteLists_Click);
            // 
            // lblCurrentAuthUser
            // 
            this.lblCurrentAuthUser.AutoSize = true;
            this.lblCurrentAuthUser.Location = new System.Drawing.Point(7, 82);
            this.lblCurrentAuthUser.Name = "lblCurrentAuthUser";
            this.lblCurrentAuthUser.Size = new System.Drawing.Size(94, 13);
            this.lblCurrentAuthUser.TabIndex = 3;
            this.lblCurrentAuthUser.Text = "Current Auth User:";
            // 
            // chkboxIsSiteAdmin
            // 
            this.chkboxIsSiteAdmin.AutoSize = true;
            this.chkboxIsSiteAdmin.Location = new System.Drawing.Point(457, 81);
            this.chkboxIsSiteAdmin.Name = "chkboxIsSiteAdmin";
            this.chkboxIsSiteAdmin.Size = new System.Drawing.Size(87, 17);
            this.chkboxIsSiteAdmin.TabIndex = 5;
            this.chkboxIsSiteAdmin.Text = "Is Site Admin";
            this.chkboxIsSiteAdmin.UseVisualStyleBackColor = true;
            // 
            // btnOpenSiteInDefaultBrowser
            // 
            this.btnOpenSiteInDefaultBrowser.Location = new System.Drawing.Point(886, 5);
            this.btnOpenSiteInDefaultBrowser.Name = "btnOpenSiteInDefaultBrowser";
            this.btnOpenSiteInDefaultBrowser.Size = new System.Drawing.Size(152, 23);
            this.btnOpenSiteInDefaultBrowser.TabIndex = 8;
            this.btnOpenSiteInDefaultBrowser.Text = "Open site in Default Browser";
            this.btnOpenSiteInDefaultBrowser.UseVisualStyleBackColor = true;
            this.btnOpenSiteInDefaultBrowser.Click += new System.EventHandler(this.btnOpenSiteInDefaultBrowser_Click);
            // 
            // txtBoxCurrentAuthUser
            // 
            this.txtBoxCurrentAuthUser.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SharePointSiteOwnerTools.Properties.Settings.Default, "currentAuthUser", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtBoxCurrentAuthUser.Location = new System.Drawing.Point(10, 98);
            this.txtBoxCurrentAuthUser.Name = "txtBoxCurrentAuthUser";
            this.txtBoxCurrentAuthUser.ReadOnly = true;
            this.txtBoxCurrentAuthUser.Size = new System.Drawing.Size(534, 20);
            this.txtBoxCurrentAuthUser.TabIndex = 4;
            this.txtBoxCurrentAuthUser.Text = global::SharePointSiteOwnerTools.Properties.Settings.Default.currentAuthUser;
            // 
            // txtBoxCurrentStatus_BaseSiteSetAs
            // 
            this.txtBoxCurrentStatus_BaseSiteSetAs.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SharePointSiteOwnerTools.Properties.Settings.Default, "currentBaseUrl", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtBoxCurrentStatus_BaseSiteSetAs.Location = new System.Drawing.Point(10, 137);
            this.txtBoxCurrentStatus_BaseSiteSetAs.Name = "txtBoxCurrentStatus_BaseSiteSetAs";
            this.txtBoxCurrentStatus_BaseSiteSetAs.ReadOnly = true;
            this.txtBoxCurrentStatus_BaseSiteSetAs.Size = new System.Drawing.Size(534, 20);
            this.txtBoxCurrentStatus_BaseSiteSetAs.TabIndex = 2;
            this.txtBoxCurrentStatus_BaseSiteSetAs.Text = global::SharePointSiteOwnerTools.Properties.Settings.Default.currentBaseUrl;
            // 
            // lstBoxMemberGroups
            // 
            this.lstBoxMemberGroups.FormattingEnabled = true;
            this.lstBoxMemberGroups.Location = new System.Drawing.Point(85, 129);
            this.lstBoxMemberGroups.Name = "lstBoxMemberGroups";
            this.lstBoxMemberGroups.Size = new System.Drawing.Size(440, 95);
            this.lstBoxMemberGroups.TabIndex = 9;
            // 
            // btnRetrieveSiteMemberGroups
            // 
            this.btnRetrieveSiteMemberGroups.Location = new System.Drawing.Point(531, 129);
            this.btnRetrieveSiteMemberGroups.Name = "btnRetrieveSiteMemberGroups";
            this.btnRetrieveSiteMemberGroups.Size = new System.Drawing.Size(161, 23);
            this.btnRetrieveSiteMemberGroups.TabIndex = 10;
            this.btnRetrieveSiteMemberGroups.Text = "Retrieve Site Member Groups";
            this.btnRetrieveSiteMemberGroups.UseVisualStyleBackColor = true;
            this.btnRetrieveSiteMemberGroups.Click += new System.EventHandler(this.btnRetrieveSiteMemberGroups_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 633);
            this.Controls.Add(this.btnRetrieveSiteMemberGroups);
            this.Controls.Add(this.lstBoxMemberGroups);
            this.Controls.Add(this.btnOpenSiteInDefaultBrowser);
            this.Controls.Add(this.btnRetrieveAllSiteLists);
            this.Controls.Add(this.btnBaseSiteDetails);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpBoxCurrentStatus);
            this.Controls.Add(this.btnSetSite);
            this.Controls.Add(this.btnTestAccess);
            this.Controls.Add(this.txtBoxSiteUrl);
            this.Controls.Add(this.lblSiteUrl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "SharePoint Site Owner Tools";
            this.grpBoxCurrentStatus.ResumeLayout(false);
            this.grpBoxCurrentStatus.PerformLayout();
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
        private System.Windows.Forms.ListBox lstBoxMemberGroups;
        private System.Windows.Forms.Button btnRetrieveSiteMemberGroups;
    }
}

