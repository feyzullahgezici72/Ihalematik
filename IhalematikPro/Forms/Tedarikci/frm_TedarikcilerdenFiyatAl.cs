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
using IhalematikProUI.Forms.Base;
using IhalematikProBL.Entity;
using IhalematikProUI.Model;
using IhalematikProBL.Provider;
using IhalematikPro.Model;
using IhalematikPro.Manager;
using IhalematikPro.Forms;
using System.IO;
using ExcelDataReader;

namespace IhalematikProUI.Forms
{
    public partial class frm_TedarikcilerdenFiyatAl : IhalematikBaseForm
    {
        public frm_TedarikcilerdenFiyatAl()
        {
            InitializeComponent();
            base.ScreenMethod();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {

        }

        private void btnKapat_Click_1(object sender, EventArgs e)
        {
            this.Close();
            frm_Anaform af = (frm_Anaform)Application.OpenForms["frm_Anaform"];
            af.RibonAktif();
        }

        private void frm_TedarikcilerdenFiyatAl_Shown(object sender, EventArgs e)
        {
            this.LoadSupplierGrid();
        }
        public void LoadSupplierGrid()
        {
            List<Supplier> suppliers = SupplierProvider.Instance.GetItems();
            List<SupplierModel> models = IhalematikModelBase.GetModels<SupplierModel, Supplier>(suppliers);
            grdSupplier.DataSource = models;
        }

        private void gridViewSupplier_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int supplierId = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewSupplier.GetFocusedRowCellValue("Id"));
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("OfferId", CurrentManager.Instance.CurrentOffer.Id);
            parameters.Add("SupplierId", supplierId);
            List<SupplierMaterialList> supplierMaterialList = SupplierMaterialListProvider.Instance.GetItems(parameters);

            grdMaterialList.DataSource = IhalematikModelBase.GetModels<OfferMaterialListModel, OfferMaterialList>(supplierMaterialList.Select(p => p.MaterialList).ToList());
        }

        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            //dialog.Filter = "Text files | *.xlxs"; // file types, that will be allowed to upload
            //dialog.Multiselect = false; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                String path = dialog.FileName; // get name of file
                this.ReadExcel(path);
                //using (StreamReader reader = new StreamReader(new FileStream(path, FileMode.Open), new UTF8Encoding())) // do anything you want, e.g. read it
                //{
                //    // ...
                //}
            }
        }

        private void ReadExcel(string path)
        {
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
                    }
                }
                i++;
            }
        }
    }
}