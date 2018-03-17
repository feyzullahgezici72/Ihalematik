namespace IhalematikLicenceAdmin
{
    partial class AdminAnaform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAnaform));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnBayi = new DevExpress.XtraBars.BarButtonItem();
            this.btnMusteri = new DevExpress.XtraBars.BarButtonItem();
            this.btnBayiListesi = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationIcon = ((System.Drawing.Bitmap)(resources.GetObject("ribbon.ApplicationIcon")));
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnBayi,
            this.btnMusteri,
            this.btnBayiListesi});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 4;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.True;
            this.ribbon.Size = new System.Drawing.Size(1574, 202);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnBayi
            // 
            this.btnBayi.Caption = "Bayi Tanımlama";
            this.btnBayi.Id = 1;
            this.btnBayi.LargeGlyph = global::IhalematikLicenceAdmin.Properties.Resources.Link_icon;
            this.btnBayi.LargeWidth = 100;
            this.btnBayi.Name = "btnBayi";
            // 
            // btnMusteri
            // 
            this.btnMusteri.Caption = "Müşteri Tanımlama";
            this.btnMusteri.Id = 2;
            this.btnMusteri.LargeGlyph = global::IhalematikLicenceAdmin.Properties.Resources.Actions_user_group_new_icon;
            this.btnMusteri.LargeWidth = 100;
            this.btnMusteri.Name = "btnMusteri";
            this.btnMusteri.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMusteri_ItemClick);
            // 
            // btnBayiListesi
            // 
            this.btnBayiListesi.Caption = "Bayi Listesi";
            this.btnBayiListesi.Glyph = ((System.Drawing.Image)(resources.GetObject("btnBayiListesi.Glyph")));
            this.btnBayiListesi.Id = 3;
            this.btnBayiListesi.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnBayiListesi.LargeGlyph")));
            this.btnBayiListesi.LargeWidth = 100;
            this.btnBayiListesi.Name = "btnBayiListesi";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Tanımlamalar";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnBayi);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnMusteri);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnBayiListesi);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 683);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1574, 43);
            // 
            // AdminAnaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1574, 726);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "AdminAnaform";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "LifeTree Software Ltd.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminAnaform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnBayi;
        private DevExpress.XtraBars.BarButtonItem btnMusteri;
        private DevExpress.XtraBars.BarButtonItem btnBayiListesi;
    }
}