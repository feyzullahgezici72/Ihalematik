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

namespace IhalematikLicance
{
    public partial class LicenseAgreement : DevExpress.XtraEditors.XtraForm
    {
        public CustomInstall _owner;
        public LicenseAgreement(CustomInstall CustomInstall)
        {
            this._owner = CustomInstall;
            InitializeComponent();
        }

        private void btnLisansla_Click(object sender, EventArgs e)
        {
            this.Close();
            License licence = new License(this._owner);
            licence.ShowDialog();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}