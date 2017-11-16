using System;
using IhalematikPro.Forms;
using IhalematikProUI.Forms.Base;
using IhalematikPro.Manager;
using IhalematikProUI.Forms.Tedarikci;

namespace IhalematikProUI.Forms.Tedarikci
{
    public partial class frm_TedarikcilereTeklifGonder : IhalematikBaseForm
    {
        public frm_TedarikcilereTeklifGonder()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPozKayit_Click(object sender, EventArgs e)
        {
            frm_TedarikciPozluKayit poz = new frm_TedarikciPozluKayit();
            poz.ShowDialog();
            
        }

        private void frm_TedarikcilereTeklifGonder_Shown(object sender, EventArgs e)
        {
            grdMaterialList.DataSource = CurrentManager.Instance.CurrentTender.MaterialList;
            grdMaterialList.RefreshDataSource();
        }

        private void btnObfKayit_Click(object sender, EventArgs e)
        {
            frm_TedarikciOfbKayit obf = new frm_TedarikciOfbKayit();
           obf.ShowDialog();

        }
    }
}