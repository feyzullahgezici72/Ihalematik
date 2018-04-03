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
using IhalematikPro.Forms;

namespace IhalematikProUI.Forms.IhaleAdim
{
    public partial class frm_PozOrObfIhale : DevExpress.XtraEditors.XtraForm
    {
        public frm_Teklif_Adim1 _owner { get; set; }
        public frm_PozOrObfIhale(frm_Teklif_Adim1 Owner)
        {
            this._owner = Owner;
            InitializeComponent();
        }

        private void btnPozYukle_Click(object sender, EventArgs e)
        {
            frm_TopluPozYukleIhale pozY = new frm_TopluPozYukleIhale(this._owner);
            pozY.ShowDialog();
        }

        private void btnObfYukle_Click(object sender, EventArgs e)
        {
            frm_TopluObfYukleIhale obfY = new frm_TopluObfYukleIhale();
            obfY.ShowDialog();
        }
    }
}