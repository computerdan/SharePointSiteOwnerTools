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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllSiteListsForm));
            this.btnClose = new System.Windows.Forms.Button();
            this.lstBoxSiteLists = new System.Windows.Forms.ListBox();
            this.btnRetrieveItems = new System.Windows.Forms.Button();
            this.lstBoxListItems = new System.Windows.Forms.ListBox();
            this.lstBoxReturnAllFieldsInList = new System.Windows.Forms.ListBox();
            this.btnReturnAllFieldsInAList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(2105, 1106);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(138, 42);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lstBoxSiteLists
            // 
            this.lstBoxSiteLists.FormattingEnabled = true;
            this.lstBoxSiteLists.ItemHeight = 24;
            this.lstBoxSiteLists.Location = new System.Drawing.Point(154, 57);
            this.lstBoxSiteLists.Margin = new System.Windows.Forms.Padding(6);
            this.lstBoxSiteLists.Name = "lstBoxSiteLists";
            this.lstBoxSiteLists.Size = new System.Drawing.Size(539, 964);
            this.lstBoxSiteLists.TabIndex = 2;
            this.lstBoxSiteLists.SelectedValueChanged += new System.EventHandler(this.lstBoxSiteLists_SelectedValueChanged);
            // 
            // btnRetrieveItems
            // 
            this.btnRetrieveItems.Location = new System.Drawing.Point(708, 212);
            this.btnRetrieveItems.Margin = new System.Windows.Forms.Padding(6);
            this.btnRetrieveItems.Name = "btnRetrieveItems";
            this.btnRetrieveItems.Size = new System.Drawing.Size(262, 63);
            this.btnRetrieveItems.TabIndex = 3;
            this.btnRetrieveItems.Text = "Retrieve items from a selected list";
            this.btnRetrieveItems.UseVisualStyleBackColor = true;
            this.btnRetrieveItems.Click += new System.EventHandler(this.btnRetrieveItems_Click);
            // 
            // lstBoxListItems
            // 
            this.lstBoxListItems.FormattingEnabled = true;
            this.lstBoxListItems.ItemHeight = 24;
            this.lstBoxListItems.Location = new System.Drawing.Point(981, 57);
            this.lstBoxListItems.Margin = new System.Windows.Forms.Padding(6);
            this.lstBoxListItems.Name = "lstBoxListItems";
            this.lstBoxListItems.Size = new System.Drawing.Size(539, 436);
            this.lstBoxListItems.TabIndex = 4;
            // 
            // lstBoxReturnAllFieldsInList
            // 
            this.lstBoxReturnAllFieldsInList.FormattingEnabled = true;
            this.lstBoxReturnAllFieldsInList.ItemHeight = 24;
            this.lstBoxReturnAllFieldsInList.Location = new System.Drawing.Point(981, 585);
            this.lstBoxReturnAllFieldsInList.Margin = new System.Windows.Forms.Padding(6);
            this.lstBoxReturnAllFieldsInList.Name = "lstBoxReturnAllFieldsInList";
            this.lstBoxReturnAllFieldsInList.Size = new System.Drawing.Size(539, 436);
            this.lstBoxReturnAllFieldsInList.TabIndex = 5;
            // 
            // btnReturnAllFieldsInAList
            // 
            this.btnReturnAllFieldsInAList.Location = new System.Drawing.Point(705, 772);
            this.btnReturnAllFieldsInAList.Margin = new System.Windows.Forms.Padding(6);
            this.btnReturnAllFieldsInAList.Name = "btnReturnAllFieldsInAList";
            this.btnReturnAllFieldsInAList.Size = new System.Drawing.Size(262, 63);
            this.btnReturnAllFieldsInAList.TabIndex = 6;
            this.btnReturnAllFieldsInAList.Text = "Retrieve all fields in selected list";
            this.btnReturnAllFieldsInAList.UseVisualStyleBackColor = true;
            this.btnReturnAllFieldsInAList.Click += new System.EventHandler(this.btnReturnAllFieldsInAList_Click);
            // 
            // AllSiteListsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2264, 1170);
            this.Controls.Add(this.btnReturnAllFieldsInAList);
            this.Controls.Add(this.lstBoxReturnAllFieldsInList);
            this.Controls.Add(this.lstBoxListItems);
            this.Controls.Add(this.btnRetrieveItems);
            this.Controls.Add(this.lstBoxSiteLists);
            this.Controls.Add(this.btnClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AllSiteListsForm";
            this.Text = "SharePoint Lists and List Items";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lstBoxSiteLists;
        private System.Windows.Forms.Button btnRetrieveItems;
        private System.Windows.Forms.ListBox lstBoxListItems;
        private System.Windows.Forms.ListBox lstBoxReturnAllFieldsInList;
        private System.Windows.Forms.Button btnReturnAllFieldsInAList;
    }
}