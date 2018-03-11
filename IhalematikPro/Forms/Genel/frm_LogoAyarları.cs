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

namespace IhalematikProUI.Forms.Genel
{
    public partial class frm_LogoAyarları : DevExpress.XtraEditors.XtraForm
    {
        public frm_LogoAyarları()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frm_Anaform af = new frm_Anaform();
            af.picLogo.Width = int.Parse(this.txtWidth.Text);
            af.picLogo.Height = int.Parse(this.txtHeight.Text);
            af.logoOrtala();
            this.Close();
        }

        private void frm_LogoAyarları_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CurrentManager.Instance.CurrentCompany.LogoPath))
            {
                string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                picLogo.Image = Image.FromFile(path + "\\EmailFile\\Images\\Logo\\" + CurrentManager.Instance.CurrentCompany.LogoPath);
            }
        }

        private void frm_LogoAyarları_Shown(object sender, EventArgs e)
        {
            txtWidth.Focus();
        }
    }
}