using Microsoft.SharePoint.Client;
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
    using SP = Microsoft.SharePoint.Client;
    public partial class SPPermissionsForm : System.Windows.Forms.Form
    {
        public SPPermissionsForm()
        {
            InitializeComponent();
        }

        private void btnRetrieveSiteMemberGroups_Click(object sender, EventArgs e)
        {
            ArrayList memGroupList = new ArrayList();
            ClientContext ctx = SPAuth.GetWebLoginClientContext(MainForm.CurrentStatus.currentBaseUrl);
            memGroupList = SPOps.getAllSPMemberGroups(ctx);

            foreach (var memGroup in memGroupList)
            {
                lstBoxMemberGroups.Items.Add(memGroup);
            }

            this.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRetrieveGroupMembers_Click(object sender, EventArgs e)
        {
            //string nothingSelected = "Nothing Selected";
            if (lstBoxMemberGroups.SelectedIndex == -1)
            {
                MessageBox.Show("Nothing Selected!");
            }
            else
            {
                string groupSelected = lstBoxMemberGroups.SelectedItem.ToString();
                ArrayList memUserList = new ArrayList();

                memUserList = SPOps.RetrieveAllUsersInASharePointGroup(MainForm.CurrentStatus.currentBaseUrl, groupSelected);

                foreach (var memUser in memUserList)
                {
                    lstBoxGroupMemberList.Items.Add(memUser.ToString());
                }

            }
        }
    }
}
