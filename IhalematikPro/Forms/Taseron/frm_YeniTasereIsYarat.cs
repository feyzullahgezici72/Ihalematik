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
    public partial class frm_YeniTasereIsYarat : DevExpress.XtraEditors.XtraForm
    {
        public frm_YeniTasereIsYarat()
        {
            InitializeComponent();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIhaleOlustur_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_TaseronSec tSec = new frm_TaseronSec();
            tSec.ShowDialog();
            
        }
    }
}