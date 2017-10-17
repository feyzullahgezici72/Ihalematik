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
    public partial class frm_Teklif_Adim2 : DevExpress.XtraEditors.XtraForm
    {
        public frm_Teklif_Adim2()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAyir_Click(object sender, EventArgs e)
        {
            
        }

        private void frm_Teklif_Adim2_Load(object sender, EventArgs e)
        {
            lblAciklama.Visible = false;
        }

        private void btnMalzemeleriAyir_Click(object sender, EventArgs e)
        {
            lblAciklama.Visible = true;
        }
    }
}