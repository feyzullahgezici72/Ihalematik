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
    public partial class frm_SozlesmeKalemleri : DevExpress.XtraEditors.XtraForm
    {
        public frm_SozlesmeKalemleri()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            
        }

        private void btnKapat_Click_1(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("Test");
        }

        private void frm_SozlesmeKalemleri_Load(object sender, EventArgs e)
        {

        }
    }
}