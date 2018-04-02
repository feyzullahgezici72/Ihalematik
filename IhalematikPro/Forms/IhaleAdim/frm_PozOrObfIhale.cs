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
    public partial class frm_PozOrObfIhale : DevExpress.XtraEditors.XtraForm
    {
        public frm_PozOrObfIhale()
        {
            InitializeComponent();
        }

        private void btnPozYukle_Click(object sender, EventArgs e)
        {
            frm_TopluPozYukleIhale pozY = new frm_TopluPozYukleIhale();
            pozY.ShowDialog();
        }

        private void btnObfYukle_Click(object sender, EventArgs e)
        {
            frm_TopluObfYukleIhale obfY = new frm_TopluObfYukleIhale();
            obfY.ShowDialog();
        }
    }
}