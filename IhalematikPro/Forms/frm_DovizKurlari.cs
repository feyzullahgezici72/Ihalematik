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

namespace IhalematikPro.Forms
{
    public partial class frm_DovizKurlari : DevExpress.XtraEditors.XtraForm
    {
        public frm_DovizKurlari()
        {
            InitializeComponent();
        }

        private void frm_DovizKurlari_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGizliKapat_Click(object sender, EventArgs e)
        {
             this.Close();
        }
    }
}