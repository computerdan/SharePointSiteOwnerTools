namespace SharePointSiteOwnerTools
{
    partial class BaseSiteDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseSiteDetailsForm));
            this.dataGridView_BaseSiteDetails = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BaseSiteDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_BaseSiteDetails
            // 
            this.dataGridView_BaseSiteDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView_BaseSiteDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView_BaseSiteDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_BaseSiteDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView_BaseSiteDetails.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_BaseSiteDetails.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridView_BaseSiteDetails.Name = "dataGridView_BaseSiteDetails";
            this.dataGridView_BaseSiteDetails.RowHeadersWidth = 72;
            this.dataGridView_BaseSiteDetails.Size = new System.Drawing.Size(1467, 726);
            this.dataGridView_BaseSiteDetails.TabIndex = 0;
            this.dataGridView_BaseSiteDetails.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView_BaseSiteDetails_DataError);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1326, 777);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(117, 46);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // BaseSiteDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 831);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGridView_BaseSiteDetails);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "BaseSiteDetailsForm";
            this.Text = "Base Site Details";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BaseSiteDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_BaseSiteDetails;
        private System.Windows.Forms.Button btnClose;
    }
}