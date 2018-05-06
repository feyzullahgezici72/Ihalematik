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

namespace IhalematikProUI.Forms.Taseron
{
    public partial class frm_TaseronSec : DevExpress.XtraEditors.XtraForm
    {
        public frm_TaseronSec()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void btnTamam_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_Anaform af = (frm_Anaform)Application.OpenForms["frm_Anaform"];
            af.barButtonItem53.PerformClick();
        }
    }
}