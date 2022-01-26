using Microsoft.Online.SharePoint.TenantAdministration;
using Microsoft.SharePoint.Client;
using OfficeDevPnP.Core.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharePointSiteOwnerTools
{
    public class SPOps
    {
        public static List<SiteEntity> GetSiteCollectionsPNP(ClientContext ctx, int startIndex, int endIndex)
        {
            var tenant = new Tenant(ctx);
            //var sites = tenant.GetSiteCollections(0, 5000, true);
            var sites = tenant.GetSiteCollections(startIndex, endIndex, true);
            ctx.ExecuteQuery();
            return (List<SiteEntity>)sites;
        }

        /// <summary>
        /// Gathers All SharePoint (only) Site Properties - provide Client Context adminCtx
        /// </summary>
        /// <param name="ctx"></param>
        /// <returns>List<SiteProperties></returns>
        public static List<SiteProperties> Get_SiteProps(ClientContext ctx)
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
        public static ArrayList Get_AllSites_and_SubSites(ClientContext ctx)
        {
            SPOSitePropertiesEnumerable prop = null;

            //var password = new SecureString();
            //foreach (char c in "MyPassword".ToCharArray()) password.AppendChar(c);
            //var credentials = new SharePointOnlineCredentials("admin@MyTenant.onmicrosoft.com", password);
            //var ctx = new ClientContext("https://MyTenant-admin.sharepoint.com/");
            //ctx.Credentials = credentials;

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
                Console.WriteLine("Site collection: " + sp.Title + " => " + sp.Url);
                Console.WriteLine("------------------------------------------------");
                //var siteCtx = new ClientContext(sp.Url);
                //siteCtx.Credentials = credentials;
                var siteCtx = new ClientContext(sp.Url);
                //siteCtx = SPAuth.AzureADAppOnlyAuthenticatedContext(MyStrings.defaultSharePointURL);
                var web = siteCtx.Web;
                //System.Collections.Generic.
                ArrayList allSites = new ArrayList();
                siteCtx.Load(web, w => w.Webs, w => w.Title, w => w.Url);
                siteCtx.ExecuteQuery();
                //#2 . Adding first level site of the site collection
                allSites.Add(web);
                //#3 . Getting sub sites and all the nested sub sites
                GetSubSites(siteCtx, web.Webs, ref allSites);

                allSiteCollection.Add(allSites);

                //foreach (Web site in allSites)
                //{
                //    Console.WriteLine("Site : " + site.Title + " => " + site.Url);
                //    Console.WriteLine("-------------------");
                //}
            }

            return allSiteCollection;
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

        //ref: https://morgantechspace.com/2016/02/get-all-sites-and-subsites-in-sharepoint-online-csom.html

        public static ArrayList subSiteArrayListCollection;

        /// <summary>
        /// Gathers All Site Collections
        /// REQUIRED: ClientContext against the admin site
        /// </summary>
        /// <param name="ctx"></param>
        /// <param name="adminSite"></param>
        /// <returns>ArrayList of all Site Collections</returns>
        public static List<SiteProperties> GetAllSiteCollections(ClientContext ctx)
        {
            var tenant = new Tenant(ctx);

            var siteColletions = new List<SiteProperties>();

            SPOSitePropertiesEnumerable siteProps = tenant.GetSitePropertiesFromSharePoint("0", true);
            ctx.Load(siteProps);
            ctx.ExecuteQuery();
            Console.WriteLine("Total Site Collections: " + siteProps.Count.ToString());
            foreach (var site in siteProps)
            {
                siteColletions.Add(site);
                Console.WriteLine(site.Title + "\t" + site.Template.ToString());
            }
            Console.ReadLine();

            return siteColletions;

        }
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
        //public static ArrayList GetSPSubSites(string SPSite)
        //{
        //    // obtain ClientContext for Site
        //    ClientContext thisCtx = SPAuth.AzureADAppOnlyAuthenticatedContext(SPSite);

        //    // The obtained ClientContext object can be used to connect to the SharePoint site.  
        //    Web web = thisCtx.Web;
        //    thisCtx.Load(web, w => w.Webs, w => w.Title, w => w.Url);
        //    //thisCtx.Load(web);
        //    thisCtx.ExecuteQuery();

        //    var subSitesList = new ArrayList();

        //    ////Loop to gather all sites
        //    foreach (Web subWeb in web.Webs)
        //    {
        //        // Check whether it is an app URL or not - If not then get into this block  
        //        if (subWeb.Url.Contains(SPSite))
        //        {
        //            string newpath = subWeb.Url;
        //            thisCtx = SPAuth.AzureADAppOnlyAuthenticatedContext(newpath);
        //            GetSPSubSites(newpath);


        //            subSiteArrayListCollection.Add(newpath);

        //        }

        //    }
        //    subSitesList = subSiteArrayListCollection;
        //    return subSitesList;

        //}

        /// <summary>
        /// Gathers All Site Permissions for provided SPSite
        /// </summary>
        /// <param name="SPSite"></param>
        /// <returns>Dictionary<string, string> GetSitePermissions</returns>
        public static Dictionary<string, string> GetSitePermissions(ClientContext clientContext, string SPSite)
        //public static ArrayList GetSitePermissions(string SPSite)
        {

            //ClientContext clientContext = SPAuth(SPSite);

            IQueryable<Microsoft.SharePoint.Client.RoleAssignment> queryForSitePermission = clientContext.Web.RoleAssignments.Include(roleAsg => roleAsg.Member,
                                                                   roleAsg => roleAsg.RoleDefinitionBindings.Include(roleDef => roleDef.Name));
            Dictionary<string, string> sitePermissionCollection = GetPermissionDetails(clientContext, queryForSitePermission);

            Console.WriteLine(sitePermissionCollection);

            return sitePermissionCollection;

        }

        /// ref: https://www.c-sharpcorner.com/article/get-sharepoint-permissions-programmatically-using-csom/
        /// <summary>    
        /// This funtion get the site/list/list item permission details. And return it by a dictonary.    
        /// </summary>    
        /// <param name="clientContext">type ClientContext</param>    
        /// <param name="queryString">type IQueryable<RoleAssignment></param>    
        /// <returns>return type is Dictionary<string, string></returns>    
        private static Dictionary<string, string> GetPermissionDetails(ClientContext clientContext, IQueryable<Microsoft.SharePoint.Client.RoleAssignment> queryString)
        {
            IEnumerable roles = clientContext.LoadQuery(queryString);
            clientContext.ExecuteQuery();

            Dictionary<string, string> permisionDetails = new Dictionary<string, string>();
            foreach (Microsoft.SharePoint.Client.RoleAssignment ra in roles)
            {
                var rdc = ra.RoleDefinitionBindings;
                string permission = string.Empty;
                foreach (var rdbc in rdc)
                {
                    permission += rdbc.Name.ToString() + ", ";
                }
                permisionDetails.Add(ra.Member.Title, permission);
            }
            return permisionDetails;
        }

        /// <summary>    
        /// This funtion get the site permission details. And return it by a dictonary.    
        /// </summary>    
        /// <param name="clientContext"></param>    
        /// <returns>Dictionary<string, string></returns>    
        private Dictionary<string, string> GetSitePermissionDetails(ClientContext clientContext)
        {
            IEnumerable roles = clientContext.LoadQuery(clientContext.Web.RoleAssignments.Include(roleAsg => roleAsg.Member,
                                                                              roleAsg => roleAsg.RoleDefinitionBindings.Include(roleDef => roleDef.Name)));
            clientContext.ExecuteQuery();

            Dictionary<string, string> permisionDetails = new Dictionary<string, string>();
            foreach (Microsoft.SharePoint.Client.RoleAssignment ra in roles)
            {
                var rdc = ra.RoleDefinitionBindings;
                string permission = string.Empty;
                foreach (var rdbc in rdc)
                {
                    permission += rdbc.Name.ToString() + ", ";
                }
                permisionDetails.Add(ra.Member.Title, permission);
            }
            return permisionDetails;
        }

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
                Console.WriteLine(list.Title);
            }

            return siteLists;

        }

        public static Dictionary<string, string> GetListPermissions(ClientContext clientContext, string ListTitle)
        {

            //var clientContext = SPAuth(SPSite);

            List list = clientContext.Web.Lists.GetByTitle(ListTitle);
            clientContext.Load(list);
            clientContext.ExecuteQuery();

            IQueryable<Microsoft.SharePoint.Client.RoleAssignment> queryForList = list.RoleAssignments.Include(roleAsg => roleAsg.Member,
                                                                                   roleAsg => roleAsg.RoleDefinitionBindings.Include(roleDef => roleDef.Name));
            Dictionary<string, string> permission = GetPermissionDetails(clientContext, queryForList);

            return permission;
        }

    }
}
