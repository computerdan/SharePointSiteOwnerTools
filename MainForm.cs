using Microsoft.Online.SharePoint.TenantAdministration;
using Microsoft.SharePoint.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharePointSiteOwnerTools
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        private static string currentBaseSiteStatus;

        
        

        public MainForm()
        {
            InitializeComponent();
            currentBaseSiteStatus = Properties.Settings.Default.currentBaseUrl;
            txtBoxCurrentStatus_BaseSiteSetAs.Text = currentBaseSiteStatus;
            txtBoxSiteUrl.Text = currentBaseSiteStatus;
            chkboxIsSiteAdmin.Checked = Properties.Settings.Default.currentAuthUserIsSiteAdmin;
        }

        public static class CurrentStatus
        {
            public static string currentBaseUrl
            {
                get { return Properties.Settings.Default.currentBaseUrl; }
                set
                {
                    Properties.Settings.Default.currentBaseUrl = value;
                    Properties.Settings.Default.Save();
                }
            }
            public static string currentAuthUser
            {
                get { return Properties.Settings.Default.currentAuthUser; }
                set
                {
                    Properties.Settings.Default.currentAuthUser = value;
                    Properties.Settings.Default.Save();
                }
            }
            public static bool currentAuthUserIsAdmin
            {
                get { return Properties.Settings.Default.currentAuthUserIsSiteAdmin; }
                set
                {
                    Properties.Settings.Default.currentAuthUserIsSiteAdmin = value;
                    Properties.Settings.Default.Save();
                  
                }
            }

        }

        private void btnSetSite_Click(object sender, EventArgs e)
        {
            Regex httpRegex = new Regex("^(http|https)://");
            string strTargetString = @txtBoxSiteUrl.Text; // put here value from text box
            if (httpRegex.IsMatch(strTargetString))
            {
                //MessageBox.Show("Correct");
                CurrentStatus.currentBaseUrl = txtBoxSiteUrl.Text;
                txtBoxCurrentStatus_BaseSiteSetAs.Text = CurrentStatus.currentBaseUrl;
            }
            else
            {
                MessageBox.Show("Incorrect input - Site Url must start with http:// or https://");
            }

            //Properties.Settings.Default.currentBaseUrl = txtBoxSiteUrl.Text;


        }

        private void txtBoxSiteUrl_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnTestAccess_Click(object sender, EventArgs e)
        {
            Regex httpRegex = new Regex("^(http|https)://");
            string strTargetString = txtBoxSiteUrl.Text;
            if (httpRegex.IsMatch(strTargetString))
            {
                ClientContext ctx = SPAuth.GetWebLoginClientContext(strTargetString);
                Web web = ctx.Web;
                ctx.Load(web, w => w.Title, w => w.CurrentUser);
                ctx.ExecuteQuery();
                //currentAuthUser
                CurrentStatus.currentAuthUser = web.CurrentUser.Email.ToString();
                CurrentStatus.currentAuthUserIsAdmin = web.CurrentUser.IsSiteAdmin;
                chkboxIsSiteAdmin.Checked = CurrentStatus.currentAuthUserIsAdmin;
                string confirmWebText = "You have connected to site: " + web.Title + " using Interactive Web Login!";
                Console.WriteLine("You have connected to {0} site, using Interactive Web Login!", web.Title);
                System.Windows.Forms.MessageBox.Show(confirmWebText);
            }
            else
            {
                MessageBox.Show("Incorrect input - Site Url must start with http:// or https://");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBaseSiteDetails_Click(object sender, EventArgs e)
        {
            BaseSiteDetailsForm frm = new BaseSiteDetailsForm();
            frm.Show();
        }

        private void btnRetrieveAllSiteLists_Click(object sender, EventArgs e)
        {
            AllSiteListsForm frm = new AllSiteListsForm();
            frm.Show();
        }

        private void btnOpenSiteInDefaultBrowser_Click(object sender, EventArgs e)
        {
            openInDefaultBrowser(CurrentStatus.currentBaseUrl);
        }
        private void openInDefaultBrowser(string targetUrl)
        {

            try
            {
                System.Diagnostics.Process.Start(targetUrl);
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }

        //private void btnRetrieveSiteMemberGroups_Click(object sender, EventArgs e)
        //{
        //    ArrayList memGroupList = new ArrayList();
        //    ClientContext ctx = SPAuth.GetWebLoginClientContext(CurrentStatus.currentBaseUrl);
        //    memGroupList = SPOps.getAllSPMemberGroups(ctx);

        //    foreach(var memGroup in memGroupList)
        //    {
        //        lstBoxMemberGroups.Items.Add(memGroup);
        //    }
        //}

        private void btnGetSitePermissions_Click(object sender, EventArgs e)
        {
            SPPermissionsForm sPPermissions = new SPPermissionsForm();
            sPPermissions.Show();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void btnGetSiteStructureTree_Click(object sender, EventArgs e)
        {
            SubSitesForm sPSubSitesForm = new SubSitesForm();
            sPSubSitesForm.Show();
        }
    }
}
