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
    public partial class SubSitesForm : Form
    {
        public static TreeView primaryTreeView;
        public static TreeView secondaryTreeView;

        TreeNode mainNode = new TreeNode();
        TreeNode primaryMainNode = new TreeNode();
        TreeNode secondaryMainNode = new TreeNode();
        TreeNode subSiteNode = new TreeNode();
        public SubSitesForm()
        {
            InitializeComponent();
            ArrayList subSitesArrayList = new ArrayList();
            subSitesArrayList = SPOps.Get_AllSites_and_SubSites_For_Given_Site(MainForm.CurrentStatus.currentBaseUrl);
            BuildTreeWithArrayList(subSitesArrayList);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BuildTreeWithArrayList(ArrayList arraylist)
        {
            treeViewSubSites.Nodes.Clear();
            //TreeNode mainNode = new TreeNode();
            this.mainNode.Name = "MainSite";
            this.mainNode.Text = MainForm.CurrentStatus.currentBaseUrl;
            this.treeViewSubSites.Nodes.Add(mainNode);

            foreach (var item in arraylist)
            {
                string url = item.ToString();
                TreeNode mainSitesNode = new TreeNode();
                mainSitesNode.Name = url;
                mainSitesNode.Text = url;
                mainSitesNode.Tag = url;
                mainNode.Nodes.Add(mainSitesNode);
            }

            //primaryTreeView = new TreeView();
            //CopyTreeNodes(treeViewMain, primaryTreeView);
            treeViewSubSites.Sort();
            treeViewSubSites.ExpandAll();

        }
    }
}
