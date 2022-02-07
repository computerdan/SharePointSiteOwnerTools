namespace SharePointSiteOwnerTools
{
    partial class SPPermissionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SPPermissionsForm));
            this.btnRetrieveSiteMemberGroups = new System.Windows.Forms.Button();
            this.lstBoxMemberGroups = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lstBoxGroupMemberList = new System.Windows.Forms.ListBox();
            this.btnRetrieveGroupMembers = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnRetrieveSiteMemberGroups
            // 
            this.btnRetrieveSiteMemberGroups.Location = new System.Drawing.Point(15, 29);
            this.btnRetrieveSiteMemberGroups.Margin = new System.Windows.Forms.Padding(6);
            this.btnRetrieveSiteMemberGroups.Name = "btnRetrieveSiteMemberGroups";
            this.btnRetrieveSiteMemberGroups.Size = new System.Drawing.Size(295, 42);
            this.btnRetrieveSiteMemberGroups.TabIndex = 12;
            this.btnRetrieveSiteMemberGroups.Text = "Retrieve Site Member Groups";
            this.toolTip1.SetToolTip(this.btnRetrieveSiteMemberGroups, "Gather Base Site Permission Groups");
            this.btnRetrieveSiteMemberGroups.UseVisualStyleBackColor = true;
            this.btnRetrieveSiteMemberGroups.Click += new System.EventHandler(this.btnRetrieveSiteMemberGroups_Click);
            // 
            // lstBoxMemberGroups
            // 
            this.lstBoxMemberGroups.FormattingEnabled = true;
            this.lstBoxMemberGroups.ItemHeight = 24;
            this.lstBoxMemberGroups.Location = new System.Drawing.Point(322, 29);
            this.lstBoxMemberGroups.Margin = new System.Windows.Forms.Padding(6);
            this.lstBoxMemberGroups.Name = "lstBoxMemberGroups";
            this.lstBoxMemberGroups.Size = new System.Drawing.Size(803, 172);
            this.lstBoxMemberGroups.TabIndex = 11;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(2502, 1223);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(138, 42);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.toolTip1.SetToolTip(this.btnClose, "Close this Window");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lstBoxGroupMemberList
            // 
            this.lstBoxGroupMemberList.FormattingEnabled = true;
            this.lstBoxGroupMemberList.ItemHeight = 24;
            this.lstBoxGroupMemberList.Location = new System.Drawing.Point(322, 281);
            this.lstBoxGroupMemberList.Margin = new System.Windows.Forms.Padding(6);
            this.lstBoxGroupMemberList.Name = "lstBoxGroupMemberList";
            this.lstBoxGroupMemberList.Size = new System.Drawing.Size(803, 292);
            this.lstBoxGroupMemberList.TabIndex = 14;
            // 
            // btnRetrieveGroupMembers
            // 
            this.btnRetrieveGroupMembers.Location = new System.Drawing.Point(830, 213);
            this.btnRetrieveGroupMembers.Margin = new System.Windows.Forms.Padding(6);
            this.btnRetrieveGroupMembers.Name = "btnRetrieveGroupMembers";
            this.btnRetrieveGroupMembers.Size = new System.Drawing.Size(295, 42);
            this.btnRetrieveGroupMembers.TabIndex = 15;
            this.btnRetrieveGroupMembers.Text = "Retrieve Group Members";
            this.toolTip1.SetToolTip(this.btnRetrieveGroupMembers, "Show Members of Selected Group");
            this.btnRetrieveGroupMembers.UseVisualStyleBackColor = true;
            this.btnRetrieveGroupMembers.Click += new System.EventHandler(this.btnRetrieveGroupMembers_Click);
            // 
            // SPPermissionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2655, 1280);
            this.Controls.Add(this.btnRetrieveGroupMembers);
            this.Controls.Add(this.lstBoxGroupMemberList);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRetrieveSiteMemberGroups);
            this.Controls.Add(this.lstBoxMemberGroups);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SPPermissionsForm";
            this.Text = "SharePoint Permissions";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRetrieveSiteMemberGroups;
        private System.Windows.Forms.ListBox lstBoxMemberGroups;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lstBoxGroupMemberList;
        private System.Windows.Forms.Button btnRetrieveGroupMembers;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}