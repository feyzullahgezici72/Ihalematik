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
using IhalematikProUI.Forms;
using System.IO;
using IhalematikProBL.Manager;
using IhalematikProUI.Manager;

namespace IhalematikPro.Forms
{
    public partial class frm_FirmaTanimlama : DevExpress.XtraEditors.XtraForm
    {
        frm_Anaform _owner = null;
        private string logoName = string.Empty;

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
            Company company = UICurrentManager.Instance.CurrentCompany;
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
                if (!string.IsNullOrEmpty(company.LogoPath))
                {
                    if (!string.IsNullOrEmpty(UICurrentManager.Instance.CurrentCompany.LogoPath))
                    {
                        //string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                        //picLogo.Image = Image.FromFile(path + "\\ihalematik\\EmailFile\\Images\\Logo\\" + CurrentManager.Instance.CurrentCompany.LogoPath);
                        string path = string.Empty;
                        if (Application.StartupPath.Contains("bin\\Debug"))
                        {
                            path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                        }
                        else
                        {
                            path = Application.StartupPath.Substring(0, (Application.StartupPath.Length));
                        }
                        picLogo.Image = Image.FromFile(path + "\\EmailFile\\Images\\Logo\\" + UICurrentManager.Instance.CurrentCompany.LogoPath);
                        this.logoName = UICurrentManager.Instance.CurrentCompany.LogoPath;
                    }
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Company company = UICurrentManager.Instance.CurrentCompany;
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
            company.LogoPath = this.logoName;
            if (!string.IsNullOrEmpty(txtMailPassword.Text.Trim()))
            {
                company.MailPassword = txtMailPassword.Text.Trim();
            }
            CompanyProvider.Instance.Save(company);
            UICurrentManager.Instance.CurrentCompany = company;
            //this._owner.frm_Anaform_Load(null, null);
            this._owner.LoadLogo();
            //frm_MesajFormu mf = new frm_MesajFormu();
            //mf.lblMesaj.Text = "Bilgiler Güncellendi";
            //mf.ShowDialog();
            UIPopupManager.Instance.ShowPopup();
            this.Close();

        }

        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string filename = System.IO.Path.GetFileName(dialog.FileName);

                string path = string.Empty;
                if (Application.StartupPath.Contains("bin\\Debug"))
                {
                    path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                }
                else
                {
                    path = Application.StartupPath.Substring(0, (Application.StartupPath.Length));
                    //MessageBox.Show(path);
                }

                //string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));

                try
                {
                    this.logoName = Guid.NewGuid().ToString() + filename;
                    System.IO.File.Copy(dialog.FileName, path + "\\EmailFile\\Images\\Logo\\" + this.logoName);
                    picLogo.Image = Image.FromFile(path + "\\EmailFile\\Images\\Logo\\" + this.logoName);
                    UICurrentManager.Instance.CurrentCompany.LogoPath = this.logoName;
                    //picLogo.Image.
                    //this.logoName = Guid.NewGuid().ToString() + filename;
                }
                catch (Exception ex)
                {
                    LoggingManager.Instance.SaveErrorLog(ex);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.logoName = string.Empty;
            picLogo.Image = null;
            //CompanyProvider.Instance.Save(company);
        }
    }
}