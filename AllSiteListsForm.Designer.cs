namespace SharePointSiteOwnerTools
{
    partial class AllSiteListsForm
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lstBoxSiteLists = new System.Windows.Forms.ListBox();
            this.btnRetrieveItems = new System.Windows.Forms.Button();
            this.lstBoxListItems = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1148, 599);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lstBoxSiteLists
            // 
            this.lstBoxSiteLists.FormattingEnabled = true;
            this.lstBoxSiteLists.Location = new System.Drawing.Point(84, 31);
            this.lstBoxSiteLists.Name = "lstBoxSiteLists";
            this.lstBoxSiteLists.Size = new System.Drawing.Size(296, 524);
            this.lstBoxSiteLists.TabIndex = 2;
            this.lstBoxSiteLists.SelectedValueChanged += new System.EventHandler(this.lstBoxSiteLists_SelectedValueChanged);
            // 
            // btnRetrieveItems
            // 
            this.btnRetrieveItems.Location = new System.Drawing.Point(386, 115);
            this.btnRetrieveItems.Name = "btnRetrieveItems";
            this.btnRetrieveItems.Size = new System.Drawing.Size(143, 34);
            this.btnRetrieveItems.TabIndex = 3;
            this.btnRetrieveItems.Text = "Retrieve items from a selected list";
            this.btnRetrieveItems.UseVisualStyleBackColor = true;
            this.btnRetrieveItems.Click += new System.EventHandler(this.btnRetrieveItems_Click);
            // 
            // lstBoxListItems
            // 
            this.lstBoxListItems.FormattingEnabled = true;
            this.lstBoxListItems.Location = new System.Drawing.Point(535, 31);
            this.lstBoxListItems.Name = "lstBoxListItems";
            this.lstBoxListItems.Size = new System.Drawing.Size(296, 524);
            this.lstBoxListItems.TabIndex = 4;
            // 
            // AllSiteListsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 634);
            this.Controls.Add(this.lstBoxListItems);
            this.Controls.Add(this.btnRetrieveItems);
            this.Controls.Add(this.lstBoxSiteLists);
            this.Controls.Add(this.btnClose);
            this.Name = "AllSiteListsForm";
            this.Text = "AllSiteListsForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lstBoxSiteLists;
        private System.Windows.Forms.Button btnRetrieveItems;
        private System.Windows.Forms.ListBox lstBoxListItems;
    }
}