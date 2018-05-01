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
using IhalematikProUI.Forms.Base;

namespace IhalematikProUI.Forms.Pozlarlar
{
    public partial class frm_KurumEkle : IhalematikBaseForm
    {
        private frm_PozListesi frm_PozListesi;

        public frm_KurumEkle()
        {
            InitializeComponent();
        }

        public frm_KurumEkle(frm_PozListesi frm_PozListesi)
        {
            this.frm_PozListesi = frm_PozListesi;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_KurumEkle_Load(object sender, EventArgs e)
        {

        }
    }
}