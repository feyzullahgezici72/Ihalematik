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

namespace IhalematikProUI.Forms.Taseron
{
    public partial class frm_IhaleTasereEt : DevExpress.XtraEditors.XtraForm
    {
        public frm_IhaleTasereEt()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void barTumIsMalzemeEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
        }

        private void btnIsMalzemeEkle_Click(object sender, EventArgs e)
        {
            frm_IsMalzemeEkle ImEkle = new frm_IsMalzemeEkle();
            ImEkle.ShowDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frm_IsMalzemeEkle ime = new frm_IsMalzemeEkle();
            ime.ShowDialog();
        }
    }
}