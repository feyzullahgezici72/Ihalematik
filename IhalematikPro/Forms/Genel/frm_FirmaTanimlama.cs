﻿using System;
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
using IhalematikProUI.Forms;

namespace IhalematikPro.Forms
{
    public partial class frm_FirmaTanimlama : DevExpress.XtraEditors.XtraForm
    {
        frm_Anaform _owner = null;
        public frm_FirmaTanimlama(frm_Anaform Owner)
        {
            InitializeComponent();
            this._owner = Owner;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frm_FirmaTanimlama_Load(object sender, EventArgs e)
        {
            Company company = CurrentManager.Instance.CurrentCompany;
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
                txtMailPassword.Text = company.MailPassword;//samet ekledi
                txtTaxOffice.Text = company.TaxOffice;
                txtTaxNumber.Text = company.TaxNumber;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Company company = CurrentManager.Instance.CurrentCompany;
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
            company.TaxNumber = txtTaxNumber.Text;
            company.TaxOffice = txtTaxOffice.Text;
            if (!string.IsNullOrEmpty(txtMailPassword.Text.Trim()))
            {
                company.MailPassword = txtMailPassword.Text.Trim();
            }
            CompanyProvider.Instance.Save(company);

            this._owner.frm_Anaform_Load(null, null);
            frm_MesajFormu mf = new frm_MesajFormu();
            mf.lblMesaj.Text = "Bilgiler Güncellendi";
            mf.ShowDialog();
            this.Close();

        }
    }
}