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
        public LicenseInformation()
        {
            //this._owner = CustomInstall;
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
            this.Close();
            //string passPhrase = "LifeTreeSoftware!.1";
            //string keyPart1 = txtSerialNumberPart1.Text.Trim();
            //string keyPart2 = txtSerialNumberPart2.Text.Trim();
            //string keyPart3 = txtSerialNumberPart3.Text.Trim();
            //string keyPart4 = txtSerialNumberPart4.Text.Trim();

            //string serialNumber = string.Join("-", new string[] { keyPart1, keyPart2, keyPart3, keyPart4 });
            //Encryption.InitVector = "LifeTreeSoftware";
            //string hashSerialNumber = Encryption.Encrypt(serialNumber, passPhrase);

            //IhalematikProBL.Entity.License existingLicense = LicenseProvider.Instance.GetOne("HashSerialNumber", serialNumber);
            //if (existingLicense != null && existingLicense.Id != 0 && !string.IsNullOrEmpty(existingLicense.HashSerialNumber) && existingLicense.HashSerialNumber.Equals(hashSerialNumber))
            //{
            //    MessageBox.Show(string.Format("Aktivasyon yapildi."));
            //    this._owner.IsActivateSerialNumber = true;
            //}
        }
    }
}