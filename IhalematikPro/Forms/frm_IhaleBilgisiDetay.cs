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

namespace IhalematikProUI.Forms
{
    public partial class frm_IhaleBilgisiDetay : DevExpress.XtraEditors.XtraForm
    {
        public frm_IhaleBilgisiDetay()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnIhaleOlustur_Click(object sender, EventArgs e)
        {

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}