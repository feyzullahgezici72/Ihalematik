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

namespace IhalematikProUI.Forms.Genel
{
    public partial class frm_IsTakvimi : DevExpress.XtraEditors.XtraForm
    {
        public frm_IsTakvimi()
        {
            InitializeComponent();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_IsTakvimi_Load(object sender, EventArgs e)
        {

        }
    }
}