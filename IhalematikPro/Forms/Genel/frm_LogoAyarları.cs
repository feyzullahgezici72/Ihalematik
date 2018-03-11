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
using IhalematikPro.Manager;
using IhalematikPro.Forms;
using IhalematikProBL.Entity;
using IhalematikProBL.Provider;

namespace IhalematikProUI.Forms.Genel
{
    public partial class frm_LogoAyarları : DevExpress.XtraEditors.XtraForm
    {
        private frm_Anaform _owner = null;
        public frm_LogoAyarları(frm_Anaform Owner)
        {
            this._owner = Owner;
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int height = int.Parse(txtHeight.Text);
            int width = int.Parse(txtWidth.Text);

            if (height != 0 && width != 0)
            {
                Company company = CurrentManager.Instance.CurrentCompany;
                company.LogoHeight = height;
                company.LogoWidth = width;
                CompanyProvider.Instance.Save(company);
            }
            this._owner.logoOrtala();
            this.Close();
        }

        private void frm_LogoAyarları_Load(object sender, EventArgs e)
        {
            if (CurrentManager.Instance.CurrentCompany != null)
            {
                if (!string.IsNullOrEmpty(CurrentManager.Instance.CurrentCompany.LogoPath))
                {
                    string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                    picLogo.Image = Image.FromFile(path + "\\EmailFile\\Images\\Logo\\" + CurrentManager.Instance.CurrentCompany.LogoPath);
                }
                if (CurrentManager.Instance.CurrentCompany.LogoWidth != 0)
                {
                    txtWidth.Text = CurrentManager.Instance.CurrentCompany.LogoWidth.ToString();
                }
                if (CurrentManager.Instance.CurrentCompany.LogoHeight != 0)
                {
                    txtHeight.Text = CurrentManager.Instance.CurrentCompany.LogoHeight.ToString();
                }
            }
        }

        private void frm_LogoAyarları_Shown(object sender, EventArgs e)
        {
            txtWidth.Focus();
        }
    }
}