using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CefSharp;
using CefSharp.WinForms;

namespace IhalematikProUI.Forms.Genel
{
    public partial class frm_Mybrowser : DevExpress.XtraEditors.XtraForm
    {
        public frm_Mybrowser()
        {
            InitializeComponent();
            //InitBrowser();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public ChromiumWebBrowser browser;
        private void frm_Mybrowser_Load(object sender, EventArgs e)
        {
            Cef.Initialize(new CefSettings());
            browser = new ChromiumWebBrowser("ekap.kik.gov.tr/EKAP/Ortak/IhaleArama/index.html") {
                Dock = DockStyle.Fill,
                Size = new Size(600, 600),
                Location = new Point(200, 200)
            };
            this.panel.Controls.Add(browser);
            //browser.Dock = DockStyle.Fill;

            // this.WindowState = FormWindowState.Maximized;
            //
        }
        public void InitBrowser()
        {
           
        }
    }
}