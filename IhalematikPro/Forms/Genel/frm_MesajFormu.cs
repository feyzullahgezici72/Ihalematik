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
using System.Threading;

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
           // timer1.Enabled = true;
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

        private void frm_MesajFormu_Shown(object sender, EventArgs e)
        {
            //pbControl.Visible = true;
            //for (int i = 0; i < 101; i++)
            //{
            //    Thread.Sleep(0);
            //    pbControl.Position = i;
            //}
            //timer1.Enabled = false;
            //this.Close();
        }
    }
}