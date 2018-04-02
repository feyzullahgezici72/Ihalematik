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

namespace IhalematikProUI.Forms.IhaleAdim
{
    public partial class frm_TopluObfYukleIhaleTemp : DevExpress.XtraEditors.XtraForm
    {
        public frm_TopluObfYukleIhaleTemp()
        {
            InitializeComponent();
        }

        private void btnHayir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}