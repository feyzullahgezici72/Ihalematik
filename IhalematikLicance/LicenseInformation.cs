using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SimpleApplicationBase.Toolkit;
using IhalematikProBL.Provider;

namespace IhalematikLicance
{
    public partial class LicenseInformation : DevExpress.XtraEditors.XtraForm
    {
        public CustomInstall _owner;
        public LicenseInformation(CustomInstall CustomInstall)
        {
            this._owner = CustomInstall;
            InitializeComponent();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLisansla_Click(object sender, EventArgs e)
        {
            //this._owner.IsReadLicenseAggrement = true;
        }

        private void btnLisansla_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            this._owner.AdministratorForm();
        }

        private void LicenseInformation_Load(object sender, EventArgs e)
        {
            this.Width = 844;
            this.Height = 513;
        }
    }
}