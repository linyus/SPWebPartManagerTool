namespace SPWebPartManagerTool
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_SiteUrl = new System.Windows.Forms.Label();
            this.lb_WebUrl = new System.Windows.Forms.Label();
            this.lb_PageUrl = new System.Windows.Forms.Label();
            this.tb_SiteUrl = new System.Windows.Forms.TextBox();
            this.tb_WebUrl = new System.Windows.Forms.TextBox();
            this.tb_PageUrl = new System.Windows.Forms.TextBox();
            this.tc_All = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lb_WebPart = new System.Windows.Forms.Label();
            this.btn_AddToPage = new System.Windows.Forms.Button();
            this.cBox_WebPart = new System.Windows.Forms.ComboBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_DeleteWPinPage = new System.Windows.Forms.Button();
            this.btn_LoadWPinPage = new System.Windows.Forms.Button();
            this.clBox_WebParts = new System.Windows.Forms.CheckedListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_Export = new System.Windows.Forms.Button();
            this.tb_ExportPath = new System.Windows.Forms.TextBox();
            this.lb_ExportPath = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btn_LoadZone = new System.Windows.Forms.Button();
            this.cbBox_Zone = new System.Windows.Forms.ComboBox();
            this.lb_Zone = new System.Windows.Forms.Label();
            this.btn_Import = new System.Windows.Forms.Button();
            this.tb_ImportPath = new System.Windows.Forms.TextBox();
            this.lb_ImportPath = new System.Windows.Forms.Label();
            this.tb_Message = new System.Windows.Forms.TextBox();
            this.lb_Message = new System.Windows.Forms.Label();
            this.folderBrowserDialogExport = new System.Windows.Forms.FolderBrowserDialog();
            this.linkL_BlogLink = new System.Windows.Forms.LinkLabel();
            this.lb_CopyRight = new System.Windows.Forms.Label();
            this.tc_All.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_SiteUrl
            // 
            this.lb_SiteUrl.AutoSize = true;
            this.lb_SiteUrl.Location = new System.Drawing.Point(20, 30);
            this.lb_SiteUrl.Name = "lb_SiteUrl";
            this.lb_SiteUrl.Size = new System.Drawing.Size(44, 13);
            this.lb_SiteUrl.TabIndex = 0;
            this.lb_SiteUrl.Text = "Site Url:";
            // 
            // lb_WebUrl
            // 
            this.lb_WebUrl.AutoSize = true;
            this.lb_WebUrl.Location = new System.Drawing.Point(20, 70);
            this.lb_WebUrl.Name = "lb_WebUrl";
            this.lb_WebUrl.Size = new System.Drawing.Size(49, 13);
            this.lb_WebUrl.TabIndex = 1;
            this.lb_WebUrl.Text = "Web Url:";
            // 
            // lb_PageUrl
            // 
            this.lb_PageUrl.AutoSize = true;
            this.lb_PageUrl.Location = new System.Drawing.Point(20, 110);
            this.lb_PageUrl.Name = "lb_PageUrl";
            this.lb_PageUrl.Size = new System.Drawing.Size(51, 13);
            this.lb_PageUrl.TabIndex = 2;
            this.lb_PageUrl.Text = "Page Url:";
            // 
            // tb_SiteUrl
            // 
            this.tb_SiteUrl.Location = new System.Drawing.Point(80, 30);
            this.tb_SiteUrl.Name = "tb_SiteUrl";
            this.tb_SiteUrl.Size = new System.Drawing.Size(370, 20);
            this.tb_SiteUrl.TabIndex = 3;
            this.tb_SiteUrl.Text = "";
            // 
            // tb_WebUrl
            // 
            this.tb_WebUrl.Location = new System.Drawing.Point(80, 70);
            this.tb_WebUrl.Name = "tb_WebUrl";
            this.tb_WebUrl.Size = new System.Drawing.Size(370, 20);
            this.tb_WebUrl.TabIndex = 4;
            // 
            // tb_PageUrl
            // 
            this.tb_PageUrl.Location = new System.Drawing.Point(80, 110);
            this.tb_PageUrl.Name = "tb_PageUrl";
            this.tb_PageUrl.Size = new System.Drawing.Size(370, 20);
            this.tb_PageUrl.TabIndex = 5;
            this.tb_PageUrl.Text = "";
            // 
            // tc_All
            // 
            this.tc_All.Controls.Add(this.tabPage1);
            this.tc_All.Controls.Add(this.tabPage2);
            this.tc_All.Controls.Add(this.tabPage3);
            this.tc_All.Controls.Add(this.tabPage4);
            this.tc_All.Location = new System.Drawing.Point(23, 145);
            this.tc_All.Name = "tc_All";
            this.tc_All.SelectedIndex = 0;
            this.tc_All.Size = new System.Drawing.Size(427, 158);
            this.tc_All.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lb_WebPart);
            this.tabPage1.Controls.Add(this.btn_AddToPage);
            this.tabPage1.Controls.Add(this.cBox_WebPart);
            this.tabPage1.Controls.Add(this.btn_Submit);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(419, 132);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lb_WebPart
            // 
            this.lb_WebPart.AutoSize = true;
            this.lb_WebPart.Location = new System.Drawing.Point(6, 17);
            this.lb_WebPart.Name = "lb_WebPart";
            this.lb_WebPart.Size = new System.Drawing.Size(52, 13);
            this.lb_WebPart.TabIndex = 9;
            this.lb_WebPart.Text = "WebPart:";
            // 
            // btn_AddToPage
            // 
            this.btn_AddToPage.Location = new System.Drawing.Point(344, 65);
            this.btn_AddToPage.Name = "btn_AddToPage";
            this.btn_AddToPage.Size = new System.Drawing.Size(75, 23);
            this.btn_AddToPage.TabIndex = 11;
            this.btn_AddToPage.Text = "Add to Page";
            this.btn_AddToPage.UseVisualStyleBackColor = true;
            this.btn_AddToPage.Click += new System.EventHandler(this.btn_AddToPage_Click);
            // 
            // cBox_WebPart
            // 
            this.cBox_WebPart.FormattingEnabled = true;
            this.cBox_WebPart.Location = new System.Drawing.Point(74, 17);
            this.cBox_WebPart.Name = "cBox_WebPart";
            this.cBox_WebPart.Size = new System.Drawing.Size(260, 21);
            this.cBox_WebPart.TabIndex = 10;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(343, 17);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 23);
            this.btn_Submit.TabIndex = 6;
            this.btn_Submit.Text = "Load";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_DeleteWPinPage);
            this.tabPage2.Controls.Add(this.btn_LoadWPinPage);
            this.tabPage2.Controls.Add(this.clBox_WebParts);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(419, 132);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Delete";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteWPinPage
            // 
            this.btn_DeleteWPinPage.Location = new System.Drawing.Point(328, 68);
            this.btn_DeleteWPinPage.Name = "btn_DeleteWPinPage";
            this.btn_DeleteWPinPage.Size = new System.Drawing.Size(75, 23);
            this.btn_DeleteWPinPage.TabIndex = 2;
            this.btn_DeleteWPinPage.Text = "Delete";
            this.btn_DeleteWPinPage.UseVisualStyleBackColor = true;
            this.btn_DeleteWPinPage.Click += new System.EventHandler(this.btn_DeleteWPinPage_Click);
            // 
            // btn_LoadWPinPage
            // 
            this.btn_LoadWPinPage.Location = new System.Drawing.Point(328, 20);
            this.btn_LoadWPinPage.Name = "btn_LoadWPinPage";
            this.btn_LoadWPinPage.Size = new System.Drawing.Size(75, 23);
            this.btn_LoadWPinPage.TabIndex = 1;
            this.btn_LoadWPinPage.Text = "Load";
            this.btn_LoadWPinPage.UseVisualStyleBackColor = true;
            this.btn_LoadWPinPage.Click += new System.EventHandler(this.btn_LoadWPinPage_Click);
            // 
            // clBox_WebParts
            // 
            this.clBox_WebParts.FormattingEnabled = true;
            this.clBox_WebParts.Location = new System.Drawing.Point(7, 20);
            this.clBox_WebParts.Name = "clBox_WebParts";
            this.clBox_WebParts.Size = new System.Drawing.Size(303, 94);
            this.clBox_WebParts.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_Export);
            this.tabPage3.Controls.Add(this.tb_ExportPath);
            this.tabPage3.Controls.Add(this.lb_ExportPath);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(419, 132);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Export";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_Export
            // 
            this.btn_Export.Location = new System.Drawing.Point(325, 80);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(75, 23);
            this.btn_Export.TabIndex = 2;
            this.btn_Export.Text = "Export";
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // tb_ExportPath
            // 
            this.tb_ExportPath.Location = new System.Drawing.Point(50, 30);
            this.tb_ExportPath.Name = "tb_ExportPath";
            this.tb_ExportPath.Size = new System.Drawing.Size(350, 20);
            this.tb_ExportPath.TabIndex = 1;
            this.tb_ExportPath.Text = "D:\\SPWPMamagerTool_Export\\";
            this.tb_ExportPath.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_ExportPath_MouseClick);
            // 
            // lb_ExportPath
            // 
            this.lb_ExportPath.AutoSize = true;
            this.lb_ExportPath.Location = new System.Drawing.Point(5, 30);
            this.lb_ExportPath.Name = "lb_ExportPath";
            this.lb_ExportPath.Size = new System.Drawing.Size(32, 13);
            this.lb_ExportPath.TabIndex = 0;
            this.lb_ExportPath.Text = "Path:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btn_LoadZone);
            this.tabPage4.Controls.Add(this.cbBox_Zone);
            this.tabPage4.Controls.Add(this.lb_Zone);
            this.tabPage4.Controls.Add(this.btn_Import);
            this.tabPage4.Controls.Add(this.tb_ImportPath);
            this.tabPage4.Controls.Add(this.lb_ImportPath);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(419, 132);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Import";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btn_LoadZone
            // 
            this.btn_LoadZone.Location = new System.Drawing.Point(240, 72);
            this.btn_LoadZone.Name = "btn_LoadZone";
            this.btn_LoadZone.Size = new System.Drawing.Size(75, 23);
            this.btn_LoadZone.TabIndex = 8;
            this.btn_LoadZone.Text = "Load Zone";
            this.btn_LoadZone.UseVisualStyleBackColor = true;
            this.btn_LoadZone.Visible = false;
            this.btn_LoadZone.Click += new System.EventHandler(this.btn_LoadZone_Click);
            // 
            // cbBox_Zone
            // 
            this.cbBox_Zone.FormattingEnabled = true;
            this.cbBox_Zone.Location = new System.Drawing.Point(50, 75);
            this.cbBox_Zone.Name = "cbBox_Zone";
            this.cbBox_Zone.Size = new System.Drawing.Size(175, 21);
            this.cbBox_Zone.TabIndex = 7;
            this.cbBox_Zone.Visible = false;
            // 
            // lb_Zone
            // 
            this.lb_Zone.AutoSize = true;
            this.lb_Zone.Location = new System.Drawing.Point(5, 75);
            this.lb_Zone.Name = "lb_Zone";
            this.lb_Zone.Size = new System.Drawing.Size(35, 13);
            this.lb_Zone.TabIndex = 6;
            this.lb_Zone.Text = "Zone:";
            this.lb_Zone.Visible = false;
            // 
            // btn_Import
            // 
            this.btn_Import.Location = new System.Drawing.Point(325, 72);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(75, 23);
            this.btn_Import.TabIndex = 5;
            this.btn_Import.Text = "Import";
            this.btn_Import.UseVisualStyleBackColor = true;
            this.btn_Import.Click += new System.EventHandler(this.btn_Import_Click);
            // 
            // tb_ImportPath
            // 
            this.tb_ImportPath.Location = new System.Drawing.Point(50, 30);
            this.tb_ImportPath.Name = "tb_ImportPath";
            this.tb_ImportPath.Size = new System.Drawing.Size(350, 20);
            this.tb_ImportPath.TabIndex = 4;
            this.tb_ImportPath.Text = "D:\\SPWPMamagerTool_Export\\";
            this.tb_ImportPath.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_ImportPath_MouseClick);
            // 
            // lb_ImportPath
            // 
            this.lb_ImportPath.AutoSize = true;
            this.lb_ImportPath.Location = new System.Drawing.Point(5, 30);
            this.lb_ImportPath.Name = "lb_ImportPath";
            this.lb_ImportPath.Size = new System.Drawing.Size(32, 13);
            this.lb_ImportPath.TabIndex = 3;
            this.lb_ImportPath.Text = "Path:";
            // 
            // tb_Message
            // 
            this.tb_Message.Location = new System.Drawing.Point(23, 340);
            this.tb_Message.Multiline = true;
            this.tb_Message.Name = "tb_Message";
            this.tb_Message.Size = new System.Drawing.Size(426, 78);
            this.tb_Message.TabIndex = 7;
            // 
            // lb_Message
            // 
            this.lb_Message.AutoSize = true;
            this.lb_Message.Location = new System.Drawing.Point(20, 320);
            this.lb_Message.Name = "lb_Message";
            this.lb_Message.Size = new System.Drawing.Size(53, 13);
            this.lb_Message.TabIndex = 8;
            this.lb_Message.Text = "Message:";
            // 
            // linkL_BlogLink
            // 
            this.linkL_BlogLink.AutoSize = true;
            this.linkL_BlogLink.Location = new System.Drawing.Point(96, 430);
            this.linkL_BlogLink.Name = "linkL_BlogLink";
            this.linkL_BlogLink.Size = new System.Drawing.Size(163, 13);
            this.linkL_BlogLink.TabIndex = 13;
            this.linkL_BlogLink.Text = "欢迎点击访问我的博客园博客";
            this.linkL_BlogLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkL_BlogLink_LinkClicked);
            // 
            // lb_CopyRight
            // 
            this.lb_CopyRight.AutoSize = true;
            this.lb_CopyRight.Location = new System.Drawing.Point(20, 430);
            this.lb_CopyRight.Name = "lb_CopyRight";
            this.lb_CopyRight.Size = new System.Drawing.Size(70, 13);
            this.lb_CopyRight.TabIndex = 14;
            this.lb_CopyRight.Text = "© 2016 霖雨";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 452);
            this.Controls.Add(this.lb_CopyRight);
            this.Controls.Add(this.linkL_BlogLink);
            this.Controls.Add(this.tc_All);
            this.Controls.Add(this.lb_Message);
            this.Controls.Add(this.tb_Message);
            this.Controls.Add(this.tb_PageUrl);
            this.Controls.Add(this.tb_WebUrl);
            this.Controls.Add(this.tb_SiteUrl);
            this.Controls.Add(this.lb_PageUrl);
            this.Controls.Add(this.lb_WebUrl);
            this.Controls.Add(this.lb_SiteUrl);
            this.Name = "Form1";
            this.Text = "SharePoint WebPart Manager Tool";
            this.tc_All.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_SiteUrl;
        private System.Windows.Forms.Label lb_WebUrl;
        private System.Windows.Forms.Label lb_PageUrl;
        private System.Windows.Forms.TextBox tb_SiteUrl;
        private System.Windows.Forms.TextBox tb_WebUrl;
        private System.Windows.Forms.TextBox tb_PageUrl;
        private System.Windows.Forms.TabControl tc_All;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lb_WebPart;
        private System.Windows.Forms.Button btn_AddToPage;
        private System.Windows.Forms.ComboBox cBox_WebPart;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tb_Message;
        private System.Windows.Forms.Label lb_Message;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.CheckedListBox clBox_WebParts;
        private System.Windows.Forms.Button btn_LoadWPinPage;
        private System.Windows.Forms.Button btn_DeleteWPinPage;
        private System.Windows.Forms.Label lb_ExportPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogExport;
        private System.Windows.Forms.Button btn_Export;
        private System.Windows.Forms.TextBox tb_ExportPath;
        private System.Windows.Forms.Button btn_Import;
        private System.Windows.Forms.TextBox tb_ImportPath;
        private System.Windows.Forms.Label lb_ImportPath;
        private System.Windows.Forms.ComboBox cbBox_Zone;
        private System.Windows.Forms.Label lb_Zone;
        private System.Windows.Forms.Button btn_LoadZone;
        private System.Windows.Forms.LinkLabel linkL_BlogLink;
        private System.Windows.Forms.Label lb_CopyRight;
    }
}

