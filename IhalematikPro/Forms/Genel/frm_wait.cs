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

namespace IhalematikProUI.Forms
{
    public partial class frm_wait : DevExpress.XtraEditors.XtraForm
    {
        public string LoadingString = string.Empty;
        public frm_wait()
        {
            InitializeComponent();
        }

        private void frm_wait_Load(object sender, EventArgs e)
        {

        }

        private void frm_wait_Shown(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.LoadingString))
            {
                lblYukleniyor.Text = LoadingString;
            }
        }

        private void progressPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}