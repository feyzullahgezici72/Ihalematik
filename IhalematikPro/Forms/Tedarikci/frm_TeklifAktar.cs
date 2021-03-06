﻿using System;
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
using IhalematikPro.Manager;
using IhalematikProBL.Manager;
using IhalematikProUI.Forms.Base;
using IhalematikProUI.Manager;
using IhalematikProBL.Enum;

namespace IhalematikProUI.Forms.Tedarikci
{
    public partial class frm_TeklifAktar : IhalematikBaseForm
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
            dialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                String path = dialog.FileName; // get name of file
                this.ReadExcel(path);
            }
        }

        private void ReadExcel(string path)
        {
            bool isException = false;
            this.SupplierName = string.Empty;
            this.OfferNumber = string.Empty;
            this.OfferDescription = string.Empty;
            this.MaterialLists = new List<OfferMaterialListModel>();
            FileStream stream = null;
            try
            {
                stream = System.IO.File.Open(@"" + path + "", FileMode.Open, FileAccess.Read);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen yüklemek istediğiniz excel dosyasını kapatınız.");
                LoggingManager.Instance.SaveErrorLog(ex);
                return;
            }
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);

            double currentSupplierId = 0;
            //if (CurrentManager.Instance.CurrentOffer == null)
            //{
            //    MessageBox.Show("Lütfen yüklemek istediğiniz teklifi aktif hale getiriniz.");
            //    return;
            //}
            int i = 0;
            while (excelReader.Read())
            {
                if (i >= 6)
                {
                    try
                    {

                        double offerId = 0;
                        try
                        {
                            offerId = excelReader.GetDouble(1);
                        }
                        catch (Exception ex)
                        {
                            LoggingManager.Instance.SaveErrorLog(ex);
                            break;
                        }
                        if (UICurrentManager.Instance.CurrentOffer == null)
                        {
                            Offer offer = OfferProvider.Instance.GetItem((int)offerId);
                            if (offer == null)
                            {
                                MessageBox.Show("Yüklemeye çalıştığınız teklif bulunamadi.");
                                return;
                            }
                            MessageBox.Show("Yüklemeye çalıştığınız teklif aktif teklife ait değildir." + offer.Number + "nolu ve " + offer.Description + "adlı teklifi aktif hale getirip yükleyiniz");
                            stream.Close();
                            return;
                        }

                        if (UICurrentManager.Instance.CurrentOffer != null)
                        {
                            if (UICurrentManager.Instance.CurrentOffer.Id != offerId)
                            {
                                Offer offer = OfferProvider.Instance.GetItem((int)offerId);
                                MessageBox.Show("Yüklemeye çalıştığınız teklif aktif teklife ait değildir." + offer.Number + " nolu ve " + offer.Description + "adlı teklifi aktif hale getirip yükleyiniz");
                                stream.Close();
                                return;
                            }
                        }

                        double supplierId = currentSupplierId = excelReader.GetDouble(2);
                        double materialId = excelReader.GetDouble(3);

                        string description = excelReader.GetString(5);
                        string unit = excelReader.GetString(6);

                        string currencyType = excelReader.GetString(7);

                        double quantity = excelReader.GetDouble(8);
                        double kdv = 0;
                        try
                        {
                            kdv = excelReader.GetDouble(9) * 100;
                        }
                        catch (Exception ex)
                        {
                            LoggingManager.Instance.SaveErrorLog(ex);
                        }

                        double price = 0;
                        try
                        {
                            price = excelReader.GetDouble(10);
                        }
                        catch (Exception ex)
                        {
                            LoggingManager.Instance.SaveErrorLog(ex);
                        }

                        Dictionary<string, object> parameters = new Dictionary<string, object>();
                        parameters.Add("SupplierId", supplierId);
                        parameters.Add("MaterialListId", materialId);
                        parameters.Add("OfferId", offerId);

                        SupplierMaterialList supplierMaterialList = SupplierMaterialListProvider.Instance.GetItems(parameters).FirstOrDefault();
                        if (supplierMaterialList != null)
                        {
                            supplierMaterialList.Price = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(price);
                            supplierMaterialList.KDV = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(kdv);
                            supplierMaterialList.CurrencyType = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<CurrencyTypesEnum>(currencyType);
                            SupplierMaterialListProvider.Instance.Save(supplierMaterialList);

                            OfferMaterialListModel offerMaterialList = new OfferMaterialListModel(supplierMaterialList.MaterialList);
                            offerMaterialList.Price = supplierMaterialList.PriceWithRate;
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
                        LoggingManager.Instance.SaveErrorLog(ex);
                        //MessageBox.Show("Yuklediğiniz excel in formatını kontrol ediniz.");
                        //TODO feyzullahg hata olustu mesaji gostermek lazim.
                        isException = true;
                        break;
                    }
                }
                i++;
            }
            stream.Close();
            if (!isException)
            {
                if (this.MaterialLists == null || this.MaterialLists.Count == 0)
                {
                    MessageBox.Show("Dosyada yüklenecek malzeme bulunamadı.");
                }
                else
                {
                    if (currentSupplierId > 0)
                    {
                        Supplier supplier = SupplierProvider.Instance.GetItem((int)currentSupplierId);
                        if (supplier != null)
                        {
                            double score = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(supplier.Score);
                            score += 10;
                            supplier.Score = score.ToString();
                            SupplierProvider.Instance.Save(supplier);
                        }
                    }
                    //frm_MesajFormu mf = new frm_MesajFormu();
                    //mf.lblMesaj.Text = this.SupplierName + " Firmasının \nTeklif dosyası aktarıldı...";
                    //mf.ShowDialog();
                    UIPopupManager.Instance.ShowPopup();
                }
            }
            grdMaterialList.DataSource = this.MaterialLists;
            lblSupplierName.Text = this.SupplierName;
            lblOfferNumber.Text = this.OfferNumber;
            lblOfferDescription.Text = this.OfferDescription;
        }

        private void frm_TeklifAktar_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}