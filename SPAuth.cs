using Microsoft.SharePoint.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharePointSiteOwnerTools
{
    internal class SPAuth
    {
        /// <summary>
        /// Returns Client Context auth login using Web Login
        /// </summary>
        /// <param name="SPSite"></param>
        /// <returns>ClientContext SPAuth</returns>
        public static ClientContext GetWebLoginClientContext(string SPSite)
        {
            var authManager = new OfficeDevPnP.Core.AuthenticationManager();

            try
            {
                ClientContext ctx = authManager.GetWebLoginClientContext(SPSite);
                return ctx;
            }
            catch (System.UriFormatException ex)
            {
                throw new Exception("No Base Site Provided!");
               
            }
            //The obtained ClientContext object can be used to connect to the SharePoint site.  

            //DEBUG
            //Web web = ctx.Web;
            //ctx.Load(web, w => w.Title);
            //ctx.ExecuteQuery();
            //string confirmWebText = "You have connected to site: " + web.Title + " using Interactive Web Login!";
            //Console.WriteLine("You have connected to {0} site, using Interactive Web Login!", web.Title);
            //System.Windows.Forms.MessageBox.Show(confirmWebText);

            

        }
    }
}
