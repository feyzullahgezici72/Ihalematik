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
using IhalematikProUI.Forms.Genel;
using IhalematikProUI.Forms.PozTem;
using IhalematikProUI.Forms.Base;

namespace IhalematikProUI.Forms.Tedarikci
{
    public partial class frm_PozOrObf : IhalematikBaseForm
    {
        public frm_PozOrObf()
        {
            InitializeComponent();
        }

        private void btnPozYukle_Click(object sender, EventArgs e)
        {
            //frm_TopluPozYukleTedarikci topluPoz = new frm_TopluPozYukleTedarikci(this);
            //topluPoz.ShowDialog();

        }

        private void btnObfYukle_Click(object sender, EventArgs e)
        {
            frm_TopluObfEkleTedarikci topluObf = new frm_TopluObfEkleTedarikci();
            topluObf.ShowDialog();
        }

        private void frm_PozOrObf_Load(object sender, EventArgs e)
        {

        }
    }
}