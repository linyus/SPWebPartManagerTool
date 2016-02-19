using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebPartPages;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Globalization;
using System.Xml;
using System.IO;

namespace SPWebPartManagerTool
{
    public partial class Form1 : Form
    {
        string siteUrl = string.Empty;
        string webUrl = string.Empty;
        string pageUrl = string.Empty;

        public Form1()
        {
            InitializeComponent();

            siteUrl = tb_SiteUrl.Text;
            webUrl = tb_WebUrl.Text;
            pageUrl = tb_PageUrl.Text;
        }

        #region Add WebPart in Page
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            using (SPSite site = new SPSite(siteUrl))
            {
                using (SPWeb web = site.OpenWeb(webUrl))
                {
                    SPList webParts = web.GetCatalog(SPListTemplateType.WebPartCatalog);
                    foreach (SPListItem item in webParts.Items)
                    {
                        cBox_WebPart.Items.Add(item["FileLeafRef"].ToString());
                    }
                }
            }
            tb_Message.Text = "Load Success...";
        }

        private void btn_AddToPage_Click(object sender, EventArgs e)
        {
            using (SPSite site = new SPSite(siteUrl))
            {
                using (SPWeb web = site.OpenWeb(webUrl))
                {
                    SPFile thePage = web.GetFile(pageUrl);
                    SPLimitedWebPartManager theWebPartManager = thePage.GetLimitedWebPartManager(System.Web.UI.WebControls.WebParts.PersonalizationScope.Shared);
                    string webPartName = cBox_WebPart.SelectedItem.ToString();
                    SPQuery qry = new SPQuery();
                    qry.Query = String.Format(CultureInfo.CurrentCulture, "<Where><Eq><FieldRef Name=\"FileLeafRef\" /><Value Type=\"Text\">{0}</Value></Eq></Where>", webPartName);
                    SPList webPartGallery = null;
                    if (null == web.ParentWeb)
                    {
                        webPartGallery = web.GetCatalog(SPListTemplateType.WebPartCatalog);
                    }
                    else
                    {
                        webPartGallery = web.Site.RootWeb.GetCatalog(SPListTemplateType.WebPartCatalog);
                    }
                    SPListItemCollection webParts = webPartGallery.GetItems(qry);
                    if (webParts.Count == 0)
                    {
                        tb_Message.Text += "Can't find " + webPartName + "...";
                    }
                    else
                    {
                        XmlReader xmlReader = new XmlTextReader(webParts[0].File.OpenBinaryStream());
                        string errorMsg;
                        System.Web.UI.WebControls.WebParts.WebPart webPart = theWebPartManager.ImportWebPart(xmlReader, out errorMsg);
                        theWebPartManager.AddWebPart(webPart, "Rich Content", 1);
                        tb_Message.Text += "Add " + webPartName + " Success...";
                    }
                }
            }
        }
        #endregion

        #region Delete WebPart in Page
        private void btn_LoadWPinPage_Click(object sender, EventArgs e)
        {
            using (SPSite site = new SPSite(siteUrl))
            {
                using (SPWeb web = site.OpenWeb(webUrl))
                {
                    SPFile thePage = web.GetFile(pageUrl);
                    SPLimitedWebPartManager theWebPartManager = thePage.GetLimitedWebPartManager(System.Web.UI.WebControls.WebParts.PersonalizationScope.Shared);
                    SPLimitedWebPartCollection webParts = theWebPartManager.WebParts;
                    clBox_WebParts.Items.Clear();
                    for (int i = 0; i < webParts.Count; i++)
                    {
                        clBox_WebParts.Items.Add(webParts[i].DisplayTitle);
                    }
                    tb_Message.Text += "Load WebParts in Page Success...";
                }
            }
        }

        private void btn_DeleteWPinPage_Click(object sender, EventArgs e)
        {
            using (SPSite site = new SPSite(siteUrl))
            {
                using (SPWeb web = site.OpenWeb(webUrl))
                {
                    SPFile thePage = web.GetFile(pageUrl);
                    SPLimitedWebPartManager theWebPartManager = thePage.GetLimitedWebPartManager(System.Web.UI.WebControls.WebParts.PersonalizationScope.Shared);
                    SPLimitedWebPartCollection webParts = theWebPartManager.WebParts;
                    int Num = webParts.Count;
                    //foreach( System.Web.UI.WebControls.WebParts.WebPart wp inwebParts
                    for (int i = Num - 1; i >= 0; i--)
                    {
                        System.Web.UI.WebControls.WebParts.WebPart wp = webParts[i];
                        for (int j = 0; j < clBox_WebParts.Items.Count; j++)
                        {
                            if ((clBox_WebParts.GetItemChecked(j)) && (clBox_WebParts.Items[j].ToString() == wp.DisplayTitle))
                            {
                                theWebPartManager.DeleteWebPart(wp);
                                tb_Message.Text += clBox_WebParts.Items[j].ToString() + "Delete in Page Success...";
                            }
                        }
                    }

                    clBox_WebParts.Items.Clear();
                    for (int i = 0; i < webParts.Count; i++)
                    {
                        clBox_WebParts.Items.Add(webParts[i].DisplayTitle);
                    }
                }
            }
        }
        #endregion

        #region Export WebPart in Page
        private void btn_Export_Click(object sender, EventArgs e)
        {
            using (SPSite site = new SPSite(siteUrl))
            {
                using (SPWeb web = site.OpenWeb(webUrl))
                {
                    SPFile thePage = web.GetFile(pageUrl);
                    SPLimitedWebPartManager theWebPartManager = thePage.GetLimitedWebPartManager(System.Web.UI.WebControls.WebParts.PersonalizationScope.Shared);
                    SPLimitedWebPartCollection webParts = theWebPartManager.WebParts;
                    XmlWriter writer = null;
                    for (int i = 0; i < webParts.Count; i++)
                    {
                        try
                        {
                            writer = new XmlTextWriter(tb_ExportPath.Text + webParts[i].Title + ".xml", Encoding.UTF8);
                            theWebPartManager.ExportWebPart(webParts[i], writer);
                            writer.Flush();
                            writer.Close();
                            tb_Message.Text += webParts[i].Title + "Export Success...";
                        }
                        catch
                        {
                            tb_Message.Text += webParts[i].Title + "Export Failed...";
                        }
                    }
                }
            }
        }

        private void tb_ExportPath_MouseClick(object sender, MouseEventArgs e)
        {
            folderBrowserDialogExport.ShowDialog();
            tb_ExportPath.Text = folderBrowserDialogExport.SelectedPath + "\\";
        }
        #endregion

        #region Import WebPart in Page
        private void btn_Import_Click(object sender, EventArgs e)
        {
            using (SPSite site = new SPSite(siteUrl))
            {
                using (SPWeb web = site.OpenWeb(webUrl))
                {
                    SPFile thePage = web.GetFile(pageUrl);
                    SPLimitedWebPartManager theWebPartManager = thePage.GetLimitedWebPartManager(System.Web.UI.WebControls.WebParts.PersonalizationScope.Shared);
                    string[] webParts = Directory.GetFiles(tb_ImportPath.Text);
                    XmlReader xReader = null;
                    System.Web.UI.WebControls.WebParts.WebPart wp = null;
                    for (int i = 0; i < webParts.Length; i++)
                    {
                        string customError = string.Empty;
                        xReader = new XmlTextReader(webParts[i]);
                        wp = theWebPartManager.ImportWebPart(xReader, out customError);
                        theWebPartManager.AddWebPart(wp, "Rich Content", 1);
                        tb_Message.Text += wp.Title + "Import Success...";
                    }
                }
            }
        }

        private void tb_ImportPath_MouseClick(object sender, MouseEventArgs e)
        {
            folderBrowserDialogExport.ShowDialog();
            tb_ImportPath.Text = folderBrowserDialogExport.SelectedPath + "\\";
        }
        #endregion

        private void btn_LoadZone_Click(object sender, EventArgs e)
        {
            //using (SPSite site = new SPSite(siteUrl))
            //{
            //    using (SPWeb web = site.OpenWeb(webUrl))
            //    {
            //        SPFile thePage = web.GetFile(pageUrl);
            //        thePage.getweb
            //        //SPLimitedWebPartManager theWebPartManager = thePage.GetLimitedWebPartManager(System.Web.UI.WebControls.WebParts.PersonalizationScope.Shared);
            //        //System.Web.UI.WebControls.WebParts.WebPartZone zone = theWebPartManager.
            //    }
            //}
        }

        private void linkL_BlogLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.cnblogs.com/jianyus"); 
        }
    }
}
