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
    public partial class LicenseActivate : DevExpress.XtraEditors.XtraForm
    {
        public CustomInstall _owner = null;
        public LicenseActivate(CustomInstall Owner)
        {
            if (Owner != null)
            {
                this._owner = Owner;
            }
            InitializeComponent();
        }
     
        private void btnTamam_Click(object sender, EventArgs e)
        {
            string passPhrase = "LifeTreeSoftware!.1";
            string keyPart1 = txtSerialNumberPart1.Text.Trim();
            string keyPart2 = txtSerialNumberPart2.Text.Trim();
            string keyPart3 = txtSerialNumberPart3.Text.Trim();
            string keyPart4 = txtSerialNumberPart4.Text.Trim();

            string serialNumber = string.Join("-", new string[] { keyPart1, keyPart2, keyPart3, keyPart4 });
            Encryption.InitVector = "LifeTreeSoftware";
            string hashSerialNumber = Encryption.Encrypt(serialNumber, passPhrase);

            IhalematikProBL.Entity.License license = LicenseProvider.Instance.GetOne("HashSerialNumber", hashSerialNumber);
            if (license != null && license.Id != 0 && !string.IsNullOrEmpty(license.HashSerialNumber) && license.HashSerialNumber.Equals(hashSerialNumber))
            {
                MessageBox.Show(string.Format("Aktivasyon yapildi."));
                this._owner.IsActivateSerialNumber = true;
                this._owner.License = license;
            }
            else
            {
                MessageBox.Show("Urun anahtari hatali.");
                this._owner.IsActivateSerialNumber = false;
            }
        }
    }
}