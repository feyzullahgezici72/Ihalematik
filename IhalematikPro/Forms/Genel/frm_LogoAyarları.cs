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
using IhalematikPro.Manager;
using IhalematikPro.Forms;
using IhalematikProBL.Entity;
using IhalematikProBL.Provider;
using IhalematikProUI.Manager;

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
                Company company = UICurrentManager.Instance.CurrentCompany;
                company.LogoHeight = height;
                company.LogoWidth = width;
                CompanyProvider.Instance.Save(company);
            }
            this._owner.logoOrtala();
            UIPopupManager.Instance.ShowPopup();
            this.Close();
        }

        private void frm_LogoAyarları_Load(object sender, EventArgs e)
        {
            if (UICurrentManager.Instance.CurrentCompany != null)
            {
                if (!string.IsNullOrEmpty(UICurrentManager.Instance.CurrentCompany.LogoPath))
                {
                    string path = string.Empty;
                    if (Application.StartupPath.Contains("bin\\Debug"))
                    {
                        path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                    }
                    else
                    {
                        path = Application.StartupPath.Substring(0, (Application.StartupPath.Length));
                    }

                    //string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                    picLogo.Image = Image.FromFile(path + "\\EmailFile\\Images\\Logo\\" + UICurrentManager.Instance.CurrentCompany.LogoPath);
                }
                if (UICurrentManager.Instance.CurrentCompany.LogoWidth != 0)
                {
                    txtWidth.Text = UICurrentManager.Instance.CurrentCompany.LogoWidth.ToString();
                }
                if (UICurrentManager.Instance.CurrentCompany.LogoHeight != 0)
                {
                    txtHeight.Text = UICurrentManager.Instance.CurrentCompany.LogoHeight.ToString();
                }
            }
        }

        private void frm_LogoAyarları_Shown(object sender, EventArgs e)
        {
            txtWidth.Focus();
        }
    }
}