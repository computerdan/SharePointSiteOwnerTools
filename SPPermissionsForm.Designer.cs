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
            this.btnRetrieveSiteMemberGroups = new System.Windows.Forms.Button();
            this.lstBoxMemberGroups = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRetrieveSiteMemberGroups
            // 
            this.btnRetrieveSiteMemberGroups.Location = new System.Drawing.Point(15, 91);
            this.btnRetrieveSiteMemberGroups.Margin = new System.Windows.Forms.Padding(6);
            this.btnRetrieveSiteMemberGroups.Name = "btnRetrieveSiteMemberGroups";
            this.btnRetrieveSiteMemberGroups.Size = new System.Drawing.Size(295, 42);
            this.btnRetrieveSiteMemberGroups.TabIndex = 12;
            this.btnRetrieveSiteMemberGroups.Text = "Retrieve Site Member Groups";
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
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // SPPermissionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2655, 1280);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRetrieveSiteMemberGroups);
            this.Controls.Add(this.lstBoxMemberGroups);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SPPermissionsForm";
            this.Text = "SPPermissions";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRetrieveSiteMemberGroups;
        private System.Windows.Forms.ListBox lstBoxMemberGroups;
        private System.Windows.Forms.Button btnClose;
    }
}