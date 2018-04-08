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
using IhalematikProBL.Entity;
using IhalematikPro.Manager;
using IhalematikProBL.Provider;
using IhalematikPro.Forms;

namespace IhalematikProUI.Forms.Genel
{
    public partial class frm_LoginGuncelle : DevExpress.XtraEditors.XtraForm
    {
        public frm_LoginGuncelle()
        {
            InitializeComponent();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            string password1 = txtPassword1.Text.Trim();
            string password2 = txtPassword2.Text.Trim();

            if (string.IsNullOrEmpty(password1) || string.IsNullOrEmpty(password2) || string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("Lütfen bütün alanları doldurunuz.");
                return;
            }

            if (!password1.Equals(password2))
            {
                MessageBox.Show("Girdiğiniz şifreler uyuşmuyor");
                return;
            }

            string hashPass = SimpleApplicationBase.Toolkit.Helpers.CreateOneWayHash(password1);

            Member member = CurrentManager.Instance.CurrentMember;
            if (member == null)
            {
                member = new Member();
            }
            member.Password = hashPass;
            member.UserName = txtUserName.Text;

            MemberProvider.Instance.Save(member);
            MessageBox.Show("Güncelleme yapıldı...");
            this.Close();
        }

        private void frm_LoginGuncelle_Load(object sender, EventArgs e)
        {
            txtUserName.Text = CurrentManager.Instance.CurrentMember != null ? CurrentManager.Instance.CurrentMember.UserName : string.Empty;
        }

        private void txtPassword2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnTamam.PerformClick();
            }
        }
    }
}