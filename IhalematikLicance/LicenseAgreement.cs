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
        public LicenseAgreement(CustomInstall Owner)
        {
            this._owner = Owner;
            InitializeComponent();
        }

        private void btnLisansla_Click(object sender, EventArgs e)
        {
            this.Hide();
            License license = new License(this._owner);
            license.ShowDialog();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}