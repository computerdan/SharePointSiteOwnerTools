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
            this.dataGridView_BaseSiteDetails.Name = "dataGridView_BaseSiteDetails";
            this.dataGridView_BaseSiteDetails.Size = new System.Drawing.Size(800, 393);
            this.dataGridView_BaseSiteDetails.TabIndex = 0;
            this.dataGridView_BaseSiteDetails.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView_BaseSiteDetails_DataError);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(723, 421);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(64, 25);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // BaseSiteDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGridView_BaseSiteDetails);
            this.Name = "BaseSiteDetailsForm";
            this.Text = "BaseSiteDetailsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BaseSiteDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_BaseSiteDetails;
        private System.Windows.Forms.Button btnClose;
    }
}