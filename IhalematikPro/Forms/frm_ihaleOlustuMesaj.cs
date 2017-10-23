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

namespace IhalematikPro.Forms
{
    public partial class frm_BelgeKontrol : DevExpress.XtraEditors.XtraForm
    {
        public frm_BelgeKontrol()
        {
            InitializeComponent();
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lblMesaj.Visible==true)
            {
                lblMesaj.Visible = false;
            }
            else
            {
                lblMesaj.Visible = true;
            }
        }

        private void frm_BelgeKontrol_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void frm_BelgeKontrol_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}