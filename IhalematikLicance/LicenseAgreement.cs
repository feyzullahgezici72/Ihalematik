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
        public LicenseAgreement()
        {
            InitializeComponent();
        }

        private void btnLisansla_Click(object sender, EventArgs e)
        {
            this.Hide();
            License license = new License();
            license.ShowDialog();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}