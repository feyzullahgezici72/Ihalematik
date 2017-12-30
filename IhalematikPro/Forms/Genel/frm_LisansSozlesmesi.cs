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
    public partial class frm_LisansSozlesmesi : DevExpress.XtraEditors.XtraForm
    {
        public frm_LisansSozlesmesi()
        {
            InitializeComponent();
        }

        private void btnLisansla_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_LisasnKontrolFormu lk = new frm_LisasnKontrolFormu();
            lk.ShowDialog();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}