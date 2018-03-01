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
using IhalematikPro.Forms;
using System.Net;
using IhalematikProBL.Provider;
using IhalematikProBL.Entity;
using IhalematikPro.Manager;

namespace IhalematikProUI.Forms.Genel
{
    public partial class frm_Login : DevExpress.XtraEditors.XtraForm
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            string bilgisayarAdi = Dns.GetHostName();
            lblPcName.Text = bilgisayarAdi;
            string ipAdresi = Dns.GetHostByName(bilgisayarAdi).AddressList[0].ToString();
            lblIpNumber.Text = ipAdresi;
            Thread.Sleep(1500);
        }



        private void btnIptal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text.Trim();
            string userName = txtUserName.Text.Trim();

            string hashPass = SimpleApplicationBase.Toolkit.Helpers.CreateOneWayHash(password);

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("Password", hashPass);
            parameters.Add("UserName", userName);

            Member member = MemberProvider.Instance.GetOne(parameters);

            if (member != null)
            {
                CurrentManager.Instance.CurrentMember = member;
                frm_Anaform af = new frm_Anaform();
                this.Hide();
                af.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı");
                return;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnTamam.PerformClick();
            }
        }
    }
}