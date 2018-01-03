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
using System.Net;

namespace IhalematikProUI.Forms.Genel
{
    public partial class frm_SQLserverName : DevExpress.XtraEditors.XtraForm
    {
        public frm_SQLserverName()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void frm_SQLserverName_Load(object sender, EventArgs e)
        {
            string bilgisayarAdi = Dns.GetHostName();
            txtServerName.Text = bilgisayarAdi;
            string ipAdresi = Dns.GetHostByName(bilgisayarAdi).AddressList[0].ToString();
            txtIpAdres.Text = ipAdresi;
        }
    }
}