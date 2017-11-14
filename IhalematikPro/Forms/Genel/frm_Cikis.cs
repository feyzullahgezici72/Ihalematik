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
    public partial class frm_Cikis : DevExpress.XtraEditors.XtraForm
    {
        public frm_Cikis()
        {
            InitializeComponent();
        }

        private void btnEvet_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHayir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}