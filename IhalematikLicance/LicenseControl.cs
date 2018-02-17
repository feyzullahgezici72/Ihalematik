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
    public partial class LicenseControl : DevExpress.XtraEditors.XtraForm
    {
        public CustomInstall _owner;
        public LicenseControl(CustomInstall CustomInstall)
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
            this._owner.IsLicenceAktivated = true;
        }
    }
}