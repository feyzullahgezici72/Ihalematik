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
using ExcelDataReader;
using System.IO;
using IhalematikProBL.Entity;
using IhalematikProBL.Provider;
using IhalematikProUI.Model;

namespace IhalematikProUI.Forms.Tedarikci
{
    public partial class frm_TeklifAktar : DevExpress.XtraEditors.XtraForm
    {
        public List<OfferMaterialListModel> MaterialLists = new List<OfferMaterialListModel>();
        public string SupplierName { get; set; }
        public string OfferNumber { get; set; }
        public string OfferDescription { get; set; }

        public frm_TeklifAktar()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                String path = dialog.FileName; // get name of file
                this.ReadExcel(path);
            }
        }

        private void ReadExcel(string path)
        {
            this.MaterialLists = new List<OfferMaterialListModel>();
            FileStream stream = System.IO.File.Open(@"" + path + "", FileMode.Open, FileAccess.Read);

            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);

            int i = 0;
            while (excelReader.Read())
            {
                if (i >= 1)
                {
                    double indexNumber = excelReader.GetDouble(0);
                    double offerId = excelReader.GetDouble(1);
                    double supplierId = excelReader.GetDouble(2);
                    double materialId = excelReader.GetDouble(3);

                    string description = excelReader.GetString(4);
                    double quantity = excelReader.GetDouble(5);
                    double price = excelReader.GetDouble(6);

                    Dictionary<string, object> parameters = new Dictionary<string, object>();
                    parameters.Add("SupplierId", supplierId);
                    parameters.Add("MaterialListId", materialId);
                    parameters.Add("OfferId", offerId);

                    SupplierMaterialList supplierMaterialList = SupplierMaterialListProvider.Instance.GetItems(parameters).FirstOrDefault();
                    if (supplierMaterialList != null)
                    {
                        supplierMaterialList.Price = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(price);
                        SupplierMaterialListProvider.Instance.Save(supplierMaterialList);

                        OfferMaterialListModel offerMaterialList = new OfferMaterialListModel(supplierMaterialList.MaterialList);
                        offerMaterialList.Price = supplierMaterialList.Price;
                        this.MaterialLists.Add(offerMaterialList);

                        if (string.IsNullOrEmpty(this.SupplierName))
                        {
                            this.SupplierName = supplierMaterialList.Supplier.CompanyName;
                        }
                        if (string.IsNullOrEmpty(this.OfferNumber))
                        {
                            this.OfferNumber = supplierMaterialList.Offer.Number;
                        }
                        if (string.IsNullOrEmpty(this.OfferDescription))
                        {
                            this.OfferDescription = supplierMaterialList.Offer.Description;
                        }
                    }
                }
                i++;
            }
            grdMaterialList.DataSource = this.MaterialLists;
            lblOfferDescription.Text = this.OfferDescription;
            lblOfferNumber.Text = this.OfferNumber;
            lblSupplierName.Text = this.SupplierName;
        }
    }
}