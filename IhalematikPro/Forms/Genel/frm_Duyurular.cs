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

namespace IhalematikProUI.Forms.Genel
{
    public partial class frm_Duyurular : DevExpress.XtraEditors.XtraForm
    {
        public frm_Duyurular()
        {
            InitializeComponent();
        }

        private void frm_Duyurular_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.ihalematikpro.com");
           webBrowser1.DocumentCompleted +=new  WebBrowserDocumentCompletedEventHandler(WebBrowser1_DocumentCompleted);

        }

        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}