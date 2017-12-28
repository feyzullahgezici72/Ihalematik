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

namespace IhalematikProUI.Forms.IhaleAdim
{
    public partial class frm_Iscilik : DevExpress.XtraEditors.XtraForm
    {
        public frm_Iscilik()
        {
            InitializeComponent();
        }

        private void btnPanelKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Iscilik_Load(object sender, EventArgs e)
        {

        }
    }
}