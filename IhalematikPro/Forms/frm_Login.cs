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
using IhalematikPro.Manager;
using IhalematikProBL.Provider;

namespace IhalematikPro.Forms
{
    public partial class frm_Login : DevExpress.XtraEditors.XtraForm
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            //Thread.Sleep(1500);
        }

      
        private void btnIptal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Forms.frm_Anaform frm = new frm_Anaform();
            this.Hide();
            frm.Show();
            //GlobalVeriablesManager.CurrentTender = TenderProvider.Instance.GetItem(160);

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void cmbInputType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbInputType.SelectedIndex==1)
            {
                btnSetting.Visible = true;
            }
            else
            {
                btnSetting.Visible = false;
            }
        }
    }
}