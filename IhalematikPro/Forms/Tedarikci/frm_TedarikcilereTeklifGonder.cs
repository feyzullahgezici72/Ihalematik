using System;
using IhalematikPro.Forms;
using IhalematikProUI.Forms.Base;

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
    }
}