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

namespace IhalematikProUI.Forms.Tedarikci
{
    public partial class frm_MalzemeAdlandir : DevExpress.XtraEditors.XtraForm
    {
        public frm_MalzemeAdlandir()
        {
            InitializeComponent();
        }

        private void btnChangeName_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_MalzemeAdlandir_Load(object sender, EventArgs e)
        {
            trcBar.MaximumSize = txtNewMeterialName.MaximumSize;
        }
    }
}