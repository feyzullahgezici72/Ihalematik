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
            this.SupplierName = string.Empty;
            this.OfferNumber = string.Empty;
            this.OfferDescription = string.Empty;
            this.MaterialLists = new List<OfferMaterialListModel>();
            FileStream stream = System.IO.File.Open(@"" + path + "", FileMode.Open, FileAccess.Read);

            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);

            int i = 1;
            while (excelReader.Read())
            {
                if (i >= 8)
                {
                    try
                    {
                        double offerId = excelReader.GetDouble(1);

                        double supplierId = excelReader.GetDouble(2);
                        double materialId = excelReader.GetDouble(3);

                        string description = excelReader.GetString(5);
                        string unit = excelReader.GetString(6);

                        double quantity = excelReader.GetDouble(7);
                        double kdv = excelReader.GetDouble(8);
                        double price = excelReader.GetDouble(9);

                        Dictionary<string, object> parameters = new Dictionary<string, object>();
                        parameters.Add("SupplierId", supplierId);
                        parameters.Add("MaterialListId", materialId);
                        parameters.Add("OfferId", offerId);

                        SupplierMaterialList supplierMaterialList = SupplierMaterialListProvider.Instance.GetItems(parameters).FirstOrDefault();
                        if (supplierMaterialList != null)
                        {
                            supplierMaterialList.Price = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(price);
                            supplierMaterialList.KDV = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(kdv);
                            SupplierMaterialListProvider.Instance.Save(supplierMaterialList);

                            OfferMaterialListModel offerMaterialList = new OfferMaterialListModel(supplierMaterialList.MaterialList);
                            offerMaterialList.Price = supplierMaterialList.Price;
                            offerMaterialList.KDV = supplierMaterialList.KDV;
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
                    catch (Exception ex)
                    {
                        //TODO feyzullahg hata olustu mesaji gostermek lazim.
                        break;
                    }
                }
                i++;
            }
            grdMaterialList.DataSource = this.MaterialLists;
            lblSupplierName.Text = this.SupplierName; 
            lblOfferNumber.Text = this.OfferNumber; 
            lblOfferDescription.Text = this.OfferDescription; 
            frm_MesajFormu mf = new frm_MesajFormu();
            mf.lblMesaj.Text = this.SupplierName + " Firmasının \nTeklif dosyası aktarıldı...";
            mf.ShowDialog();
        }
    }
}