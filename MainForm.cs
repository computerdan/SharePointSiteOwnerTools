using Microsoft.SharePoint.Client;
using System;
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
                    //txtBoxCurrentStatus_BaseSiteSetAs.Text=value;
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
                ctx.Load(web, w => w.Title);
                ctx.ExecuteQuery();
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
    }
}
