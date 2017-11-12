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

namespace IhalematikPro.Forms
{
    public partial class frm_FirmaTanimlama : DevExpress.XtraEditors.XtraForm
    {
        public frm_FirmaTanimlama()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_FirmaTanimlama_Load(object sender, EventArgs e)
        {
            Company company = CurrentManager.CurrentCompany;
            if (company == null)
            {
                company = new Company();
            }
            else
            {
                txtName.Text = company.Name;
                txtAddress.Text = company.Address;
                txtBossName.Text = company.BossName;
                txtBossSurName.Text = company.BossSurName;
                txtFax.Text = company.Fax;
                txtGSM.Text = company.GSM;
                txtMailAddress.Text = company.MailAddress;
                txtTelephone1.Text = company.Telephone1;
                txtTelephone2.Text = company.Telephone2;
                txtTitle.Text = company.Title;
                txtWebAddress.Text = company.WebAddress;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Company company = CurrentManager.CurrentCompany;
            if (company == null)
            {
                company = new Company();
            }

            company.Name = txtName.Text;
            company.Address = txtAddress.Text;
            company.BossName = txtBossName.Text;
            company.BossSurName = txtBossSurName.Text;
            company.Fax = txtFax.Text;
            company.GSM = txtGSM.Text;
            company.MailAddress = txtMailAddress.Text;
            company.Telephone1 = txtTelephone1.Text;
            company.Telephone2 = txtTelephone2.Text;
            company.Title = txtTitle.Text;
            company.WebAddress = txtWebAddress.Text;
            CompanyProvider.Instance.Save(company);
            MessageBox.Show("Firma Bilgileri Güncellendi..");
        }

        private void frm_FirmaTanimlama_KeyDown(object sender, KeyEventArgs e)
        {
            Control fControl;
            if (e.KeyCode == Keys.Enter)
            {
                fControl = GetNextControl(ActiveControl, !e.Shift);
                if (fControl == null)
                    fControl = GetNextControl(null, true);
                fControl.Focus();
                e.SuppressKeyPress = true;
            }
        }
    }
}