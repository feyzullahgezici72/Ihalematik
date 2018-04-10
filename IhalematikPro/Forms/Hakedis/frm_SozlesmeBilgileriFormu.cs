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

namespace IhalematikProUI.Hakedis
{
    public partial class frm_SozlesmeBilgileriFormu : DevExpress.XtraEditors.XtraForm
    {
        public frm_SozlesmeBilgileriFormu()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void yeniSözleşmeYaratToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_YeniSozlesmeYarat ysy = new frm_YeniSozlesmeYarat();
            ysy.ShowDialog();
        }
    }
}