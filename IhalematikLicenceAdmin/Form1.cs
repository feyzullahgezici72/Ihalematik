using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using SimpleApplicationBase.Toolkit;
using IhalematikProBL.Provider;
using SimpleApplicationBase.BL.Base;

namespace IhalematikLicenceAdmin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAuthorNameSurname.Text.Trim()) || string.IsNullOrEmpty(txtCompanyName.Text.Trim()))
            {
                MessageBox.Show("Firma Adi ve kullanici adi bos birakilamaz"); // Validasyon eklenmesi lazim
                return;
            }
            string passPhrase = "LifeTreeSoftware!.1";
            string keyPart1 = this.RandomString(5);
            string keyPart2 = this.RandomString(5);
            string keyPart3 = this.RandomString(5);
            string keyPart4 = this.RandomString(5);

            string serialNumber = string.Join("-", new string[] { keyPart1, keyPart2, keyPart3, keyPart4 });
            txtSerialNumber.Text = serialNumber;

            Encryption.InitVector = "LifeTreeSoftware";

            string hashSerialNumber = Encryption.Encrypt(serialNumber, passPhrase);

            IhalematikProBL.Entity.License existingLicense = LicenseProvider.Instance.GetOne("HashSerialNumber", serialNumber);

            if (existingLicense != null && existingLicense.Id != 0 && !string.IsNullOrEmpty(existingLicense.HashSerialNumber))
            {
                MessageBox.Show(string.Format("{0} Bu seri numarasinda daha once lisans uretilmis lutfen tekrar olusturununuz.", hashSerialNumber));
                return;
            }

            IhalematikProBL.Entity.License license = new IhalematikProBL.Entity.License();
            license.AuthorNameSurname = txtAuthorNameSurname.Text;
            license.CompanyName = txtCompanyName.Text;
            license.HashSerialNumber = hashSerialNumber;

            OperationResult result = LicenseProvider.Instance.Save(license);
            if (result.Success)
            {
                MessageBox.Show("Lisans Key Oluşturuldu");
            }
        }

        private Random random = new Random();
        public string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
