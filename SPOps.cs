using Microsoft.Online.SharePoint.TenantAdministration;
using Microsoft.SharePoint.Client;
using OfficeDevPnP.Core.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharePointSiteOwnerTools
{
    using SP = Microsoft.SharePoint.Client;
    public class SPOps
    {
        ////https://docs.microsoft.com/en-us/sharepoint/dev/sp-add-ins/complete-basic-operations-using-sharepoint-client-library-code

        /// <summary>
        /// Gathers All SharePoint (only) Site Properties - provide Client Context adminCtx
        /// </summary>
        /// <param name="ctx"></param>
        /// <returns>Microsoft.SharePoint.Client.Web</returns>
        public static Web Get_SiteProps(ClientContext ctx)
        {
            Web web = ctx.Web;
            ctx.Load(web);
            ctx.ExecuteQuery();

            return web;
        }
        public static List<SiteProperties> Get_SiteProps_AdminSite(ClientContext ctx)
        {
            SPOSitePropertiesEnumerable prop = null;
            //ctx = SPAuth.AzureADAppOnlyAuthenticatedContext(MyStrings.adminSharePointURL);
            Tenant tenant = new Tenant(ctx);
            prop = tenant.GetSiteProperties(0, true);
            ctx.Load(prop);
            ctx.ExecuteQuery();
            var allSiteCollection = new ArrayList();
            var siteColl = new List<SiteProperties>();
            //#1 . Getting all site collections
            foreach (SiteProperties sp in prop)
            {
                siteColl.Add(sp);
            }

            return siteColl;
        }


        //private static void GetSubSites(ClientContext siteCtx, WebCollection webs, ref ArrayList allSites)
        //{
        //    if (webs.Count > 0)
        //    {
        //        siteCtx.Load(webs, w => w.Include(a => a.Webs, a => a.Title, a => a.Url));
        //        siteCtx.ExecuteQuery();
        //        foreach (Web web in webs)
        //        {
        //            allSites.Add(web);
        //            GetSubSites(siteCtx, web.Webs, ref allSites);
        //        }
        //        siteCtx.ExecuteQuery();
        //    }
        //}

        //ref: https://morgantechspace.com/2016/02/get-all-sites-and-subsites-in-sharepoint-online-csom.html


        /// <summary>
        /// Retrieves Client Context for SPSite - uses SPSite URL to gather SubWebs Collection
        /// Retrieves additional Client Contexts for each subWeb lookup (using Web subWeb.Url as URL) as it loops through same Method
        /// </summary>
        /// <param name="SPSite"></param>
        /// <returns> ArrayList </returns>
        public static ArrayList GetSPSubSites(string SPSite)
        {
            //var authManager = new OfficeDevPnP.Core.AuthenticationManager();
            //ClientContext ctx = authManager.GetWebLoginClientContext(SPSite);

            //ClientContext ctx = SPAuth.AzureADAppOnlyAuthenticatedContext(SPSite);

            ClientContext ctx = SPAuth.GetWebLoginClientContext(SPSite);

            // The obtained ClientContext object can be used to connect to the SharePoint site.  
            Web web = ctx.Web;
            ctx.Load(web, w => w.Webs, w => w.Title);
            ctx.ExecuteQuery();

            var subSitesArray = new ArrayList();

            //Loop to gather all webs
            foreach (Web subWeb in web.Webs)
            {
                // Check whether it is an app URL or not - If not then get into this block  
                if (subWeb.Url.Contains(SPSite))
                {
                    string newpath = subWeb.Url;
                    GetSPSubSites(newpath);

                    subSitesArray.Add(newpath);

                }

            }
            return subSitesArray;

        }

        /// <summary>
        /// Retrieves Site Lists for a SharePoint Site
        /// </summary>
        /// <param name="clientContext"></param>
        /// <param name="SPSite"></param>
        /// <returns>ArrayList</returns>
        public static ArrayList GetSiteLists(ClientContext clientContext, string SPSite)
        //public static ArrayList GetSitePermissions(string SPSite)
        {

            //ClientContext clientContext = SPAuth(SPSite);

            Web web = clientContext.Web;

            clientContext.Load(web.Lists,
             lists => lists.Include(list => list.Title,
                                    list => list.Id));

            // Execute query.
            clientContext.ExecuteQuery();

            // Enumerate the web.Lists.
            var siteLists = new ArrayList();

            foreach (List list in web.Lists)
            {
                siteLists.Add(list.Title);
                //Console.WriteLine(list.Title);
            }

            return siteLists;

        }

        public static ArrayList GetItemsInList(ClientContext context, string SPSite, string listTitle)
        {
            var itemArrayList = new ArrayList();

            // Starting with ClientContext, the constructor requires a URL to the
            // server running SharePoint.
            //ClientContext context = new ClientContext("https://{site_url}");

            //// Assume the web has a list named "Announcements".
            //List announcementsList = context.Web.Lists.GetByTitle("Announcements");
            List currentList = context.Web.Lists.GetByTitle(listTitle);

            // This creates a CamlQuery that has a RowLimit of 100, and also specifies Scope="RecursiveAll"
            // so that it grabs all list items, regardless of the folder they are in.
            CamlQuery query = CamlQuery.CreateAllItemsQuery(100);
            ListItemCollection items = currentList.GetItems(query);

            // Retrieve all items in the ListItemCollection from List.GetItems(Query).
            context.Load(items);
            context.ExecuteQuery();
            foreach (ListItem listItem in items)
            {

                try
                {
                    itemArrayList.Add(listItem["Title"]);

                }
                catch { MessageBox.Show("No Items for for List"); }
            }

            return itemArrayList;
        }
        public static ArrayList getAllSPMemberGroups(ClientContext context)
        {
            ArrayList memGroups = new ArrayList();
            GroupCollection siteGroups = context.Web.SiteGroups;
            context.Load(siteGroups);
            context.ExecuteQuery();
            foreach (var siteGroup in siteGroups)
            {
                memGroups.Add(siteGroup.Title);
            }

            return memGroups;
        }
        /// <summary>
        /// Retrieves All Sites and SubSite for provide siteURL
        /// ref: https://morgantechspace.com/2016/02/get-all-sites-and-subsites-in-sharepoint-online-csom.html
        /// </summary>
        /// <param name="siteCtx"></param>
        /// <param name="siteUrl"></param>
        public static ArrayList Get_AllSites_and_SubSites_For_Given_Site(string siteUrl)
        {
            ArrayList returnArrayList = new ArrayList();

            ClientContext siteCtx = SPAuth.GetWebLoginClientContext(siteUrl);
            var web = siteCtx.Web;
            ArrayList allSites = new ArrayList();
            siteCtx.Load(web, w => w.Webs, w => w.Title, w => w.Url);
            siteCtx.ExecuteQuery();
            allSites.Add(web);
            //Getting sub sites and all the nested sub sites
            GetSubSites(siteCtx, web.Webs, ref allSites);
            foreach (Web site in allSites)
            {
                returnArrayList.Add(site.Url);
                //Console.WriteLine(site.Title + " => " + site.Url);
                //Console.WriteLine("-------------------");
            }

            return returnArrayList;
        }

        private static void GetSubSites(ClientContext siteCtx, WebCollection webs, ref ArrayList allSites)
        {
            if (webs.Count > 0)
            {
                siteCtx.Load(webs, w => w.Include(a => a.Webs, a => a.Title, a => a.Url));
                siteCtx.ExecuteQuery();
                foreach (Web web in webs)
                {
                    allSites.Add(web);
                    GetSubSites(siteCtx, web.Webs, ref allSites);
                }
                siteCtx.ExecuteQuery();
            }
        }

        /// <summary>
        /// Returns All Fields In a List
        /// Ref: https://docs.microsoft.com/en-us/sharepoint/dev/sp-add-ins/complete-basic-operations-using-sharepoint-client-library-code#retrieve-all-of-the-fields-in-a-list
        /// </summary>
        /// <param name="SPSite"></param>
        /// <param name="ListByTitle"></param>
        /// <returns>ArrayList</returns>
        public static ArrayList GetAllFieldsInAList(string siteURL, string listByTitle)
        {
            ArrayList returnArrayList = new ArrayList();

            // Starting with ClientContext, the constructor requires a URL to the
            // server running SharePoint.
            ClientContext context = SPAuth.GetWebLoginClientContext(siteURL);

            SP.List list = context.Web.Lists.GetByTitle(listByTitle);
            context.Load(list.Fields);

            try
            {
                // We must call ExecuteQuery before enumerate list.Fields.
                context.ExecuteQuery();

                foreach (SP.Field field in list.Fields)
                {
                    returnArrayList.Add(field.InternalName.ToString());
                }

                return returnArrayList;
            }
            catch (System.Net.WebException ex)
            {
                throw new Exception("Server Returned Error: (403) Forbidden");
            }


        }

        /// <summary>
        /// Retrieve Users In a SP Permissions Group by using GroupName
        /// ref: https://docs.microsoft.com/en-us/sharepoint/dev/sp-add-ins/complete-basic-operations-using-sharepoint-client-library-code#retrieve-all-users-in-a-sharepoint-group
        /// </summary>
        /// <param name="siteURL"></param>
        /// <param name="groupName"></param>
        /// <returns>ArrayList</returns>
        public static ArrayList RetrieveAllUsersInASharePointGroup(string siteURL, string groupName)
        {
            ArrayList returnArrayList = new ArrayList();

            ClientContext context = SPAuth.GetWebLoginClientContext(siteURL);
            GroupCollection siteGroups = context.Web.SiteGroups;

            // Assume that there is a "Members" group, and the ID=5.
            Group membersGroup = siteGroups.GetByName(groupName);
            context.Load(membersGroup.Users);
            context.ExecuteQuery();

            foreach (User member in membersGroup.Users)
            {
                // We have all the user info. For example, Title.
                returnArrayList.Add(member.Title);
            }

            return returnArrayList;
        }
    }
}
