using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharePointSiteOwnerTools
{
    using static SharePointSiteOwnerTools.MainForm;
    using SP = Microsoft.SharePoint.Client;


    public partial class AllSiteListsForm : Form
    {

        public AllSiteListsForm()
        {
            InitializeComponent();
            displaySiteLists();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void displaySiteLists()
        {
            var siteListsAL = new ArrayList();
            SP.ClientContext ctx = SPAuth.GetWebLoginClientContext(CurrentStatus.currentBaseUrl);
            siteListsAL = SPOps.GetSiteLists(ctx, CurrentStatus.currentBaseUrl);

            foreach (var site in siteListsAL)
            {
                lstBoxSiteLists.Items.Add(site);
            }
            ////var siteProps = new Web();
            //SP.ClientContext ctx = SPAuth.GetWebLoginClientContext(CurrentStatus.currentBaseUrl);
            //List<System.Collections.IEnumerable> siteProps = SPOps.GetSiteLists(ctx, CurrentStatus.currentBaseUrl);
            //siteLists.DataSource = siteProps;
            //dataGridView_AllSiteLists.DataSource = siteProps;

        }

        private void dataGridView_AllSiteLists_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            return;
        }

        private void btnRetrieveItems_Click(object sender, EventArgs e)
        {
            lstBoxListItems.Items.Clear();

            string listSelected = lstBoxSiteLists.SelectedItems[0].ToString();
            var listItems = new ArrayList();
            SP.ClientContext ctx = SPAuth.GetWebLoginClientContext(CurrentStatus.currentBaseUrl);
            listItems = SPOps.GetItemsInList(ctx, CurrentStatus.currentBaseUrl, listSelected);

            foreach (var item in listItems)
            {
                if (item != null)
                {
                    item.ToString();

                    lstBoxListItems.Items.Add(item);
                }
            }

            this.Focus();
        }
    }
}
