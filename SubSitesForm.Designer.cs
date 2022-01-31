namespace SharePointSiteOwnerTools
{
    partial class SubSitesForm
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
            this.treeViewSubSites = new System.Windows.Forms.TreeView();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeViewSubSites
            // 
            this.treeViewSubSites.Location = new System.Drawing.Point(102, 57);
            this.treeViewSubSites.Name = "treeViewSubSites";
            this.treeViewSubSites.Size = new System.Drawing.Size(1022, 893);
            this.treeViewSubSites.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(2049, 986);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(138, 42);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // SubSitesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2202, 1043);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.treeViewSubSites);
            this.Name = "SubSitesForm";
            this.Text = "SubSitesForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewSubSites;
        private System.Windows.Forms.Button btnClose;
    }
}