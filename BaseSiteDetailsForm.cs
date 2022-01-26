using Microsoft.Online.SharePoint.TenantAdministration;
using Microsoft.SharePoint.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SharePointSiteOwnerTools.MainForm;

namespace SharePointSiteOwnerTools
{
    public partial class BaseSiteDetailsForm : System.Windows.Forms.Form
    {
        private BindingSource spProps = new BindingSource();

        public BaseSiteDetailsForm()
        {
            InitializeComponent();
            displaySiteProps();
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void displaySiteProps()
        {
            var siteProps = new List<SiteProperties>();
            ClientContext ctx = SPAuth.GetWebLoginClientContext(CurrentStatus.currentBaseUrl);
            siteProps = SPOps.Get_SiteProps(ctx);
            spProps.DataSource = siteProps;
            dataGridView_BaseSiteDetails.DataSource = spProps;
                        
        }



        private void dataGridView_BaseSiteDetails_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            return;
        }
    }
}
