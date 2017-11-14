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
    public partial class frm_MesajFormu : DevExpress.XtraEditors.XtraForm
    {
        public frm_MesajFormu()
        {
            InitializeComponent();
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            this.Close();
            
        }

        private void frm_MesajFormu_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lblMesaj.Visible == true)
            {
                lblMesaj.Visible = false;
            }
            else
            {
                lblMesaj.Visible = true;
            }
        }
    }
}