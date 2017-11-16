using System;
using IhalematikPro.Forms;
using IhalematikProUI.Forms.Base;
using IhalematikPro.Manager;

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
            frm_PozluKayit pk = new frm_PozluKayit(this);
            pk.ShowDialog();
            
        }

        private void frm_TedarikcilereTeklifGonder_Shown(object sender, EventArgs e)
        {
            grdMaterialList.DataSource = CurrentManager.Instance.CurrentTender.MaterialList;
            grdMaterialList.RefreshDataSource();
        }
    }
}