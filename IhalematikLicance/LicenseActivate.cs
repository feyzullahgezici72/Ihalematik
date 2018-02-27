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
using System.Data.SqlClient;

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

            string serialNumber = string.Join("", new string[] { keyPart1, keyPart2, keyPart3, keyPart4 });
            Encryption.InitVector = "LifeTreeSoftware";
            string hashSerialNumber = Encryption.Encrypt(serialNumber, passPhrase);

            IhalematikProBL.Entity.License license = this.CehckExistingLicense(hashSerialNumber);//LicenseProvider.Instance.GetOne("HashSerialNumber", hashSerialNumber);
            if (license != null && license.Id != 0 && !string.IsNullOrEmpty(license.HashSerialNumber) && license.HashSerialNumber.Equals(hashSerialNumber))
            {
                MessageBox.Show(string.Format("Aktivasyon yapildi."));
                this._owner.IsActivateSerialNumber = true;
                this._owner.License = license;
                this.Hide();
                this._owner.LicenseInformationForm();
            }
            else
            {
                MessageBox.Show("Urun anahtari hatali.");
                this._owner.IsActivateSerialNumber = false;
            }
        }

        private IhalematikProBL.Entity.License CehckExistingLicense(string HashSerialNumber)
        {
            IhalematikProBL.Entity.License license = new IhalematikProBL.Entity.License();

           // using (SqlConnection conn = new SqlConnection(@"server=L0720014;user id=sa;password=Stonefish1;initial catalog=IhalematikDB"))

            using (SqlConnection conn = new SqlConnection(@"server=.\MSSQLSErVER2014;user id=sa;password=Stonefish1;initial catalog=IhalematikDB"))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("License_Select", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@HashSerialNumber", HashSerialNumber));

                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        license.AuthorNameSurname = rdr["AuthorNameSurname"].ToString();
                        license.CompanyName = rdr["CompanyName"].ToString();
                        license.HashSerialNumber = rdr["HashSerialNumber"].ToString();
                        license.Address = rdr["Address"].ToString();
                        license.TaxNumber = rdr["TaxNumber"].ToString();
                        license.TaxOffice = rdr["TaxOffice"].ToString();
                        license.Telephone = rdr["Telephone"].ToString();
                        license.Id = (int)rdr["Id"];
                        //Console.WriteLine("Product: {0,-35} Total: {1,2}", rdr["ProductName"], rdr["Total"]);
                    }
                }
            }


            return license;
        }

        private void txtSerialNumberPart1_EditValueChanged(object sender, EventArgs e)
        {
            if (txtSerialNumberPart1.Text.Length==5)
            {
                txtSerialNumberPart2.Focus();
            }
        }

        private void txtSerialNumberPart2_EditValueChanged(object sender, EventArgs e)
        {
            if (txtSerialNumberPart2.Text.Length == 5)
            {
                txtSerialNumberPart3.Focus();
            }
        }

        private void txtSerialNumberPart3_EditValueChanged(object sender, EventArgs e)
        {
            if (txtSerialNumberPart3.Text.Length == 5)
            {
                txtSerialNumberPart4.Focus();
            }
        }

        private void txtSerialNumberPart4_EditValueChanged(object sender, EventArgs e)
        {
            if (txtSerialNumberPart4.Text.Length == 5)
            {
                btnTamam.Focus();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this._owner.IsActivateSerialNumber = false;
            this._owner.LicenseInformationForm();
        }
    }
}