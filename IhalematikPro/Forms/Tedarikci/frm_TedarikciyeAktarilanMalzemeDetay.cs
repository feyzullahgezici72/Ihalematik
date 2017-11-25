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
using IhalematikProBL.Entity;
using IhalematikProBL.Provider;
using IhalematikPro.Manager;
using IhalematikProBL.Manager;
using System.IO;

namespace IhalematikProUI.Forms.Tedarikci
{
    public partial class frm_TedarikciyeAktarilanMalzemeDetay : DevExpress.XtraEditors.XtraForm
    {
        frm_TedarikcilereTeklifGonder _owner;
        public int SelectedSupplierId { get; set; }
        private Supplier supplier { get; set; }
        public Supplier Supplier
        {
            get
            {
                if (this.supplier == null)
                {
                    this.supplier = SupplierProvider.Instance.GetItem(this.SelectedSupplierId);
                }

                return this.supplier;
            }
        }

        string DestinationFile = string.Empty;

        public frm_TedarikciyeAktarilanMalzemeDetay(frm_TedarikcilereTeklifGonder Owner)
        {
            InitializeComponent();
            this._owner = Owner;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_TedarikciyeAktarilanMalzemeDetay_Shown(object sender, EventArgs e)
        {
            //Supplier supplier = SupplierProvider.Instance.GetItem(this.SelectedSupplierId);
            if (this.Supplier != null)
            {
                txtCompanyName.Text = this.Supplier.CompanyName;
                txtAuthorNameSurname.Text = this.Supplier.AuthorNameSurname;
                txtEmail.Text = this.Supplier.Email;
                txtScore.Text = this.Supplier.Score;
                if (this.Supplier.Segments != null)
                {
                    memoEditSegment.Lines = this.Supplier.Segments.Select(p => p.Name) as string[];
                }
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("OfferId", CurrentManager.Instance.CurrentOffer.Id);
                parameters.Add("SupplierId", supplier.Id);

                List<SupplierMaterialList> items = SupplierMaterialListProvider.Instance.GetItems(parameters);

                grdMaterialList.DataSource = items.Select(p => p.MaterialList).ToList();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            List<OfferMaterialList> items = grdMaterialList.DataSource as List<OfferMaterialList>;
            if (items != null && items.Count != 0)
            {
                this.SendMail();
            }
            else
            {
                MessageBox.Show("Gonderilecek malzeme listesi bos olamaz");
            }
        }

        private void CreateExcel()
        {
            Microsoft.Office.Interop.Excel.Application oXL = null;
            Microsoft.Office.Interop.Excel._Workbook oWB = null;
            Microsoft.Office.Interop.Excel._Worksheet oSheet = null;

            //List<Supplier> suppliers = CurrentManager.Instance.CurrentOffer.Suppliers;
            if (this.Supplier != null)
            {
                try
                {
                    string fileName = "Malzeme_Fiyat_Listesi.xlsx";
                    string sourcePath = @"E:\Development\Clone\IhalematikPro\EmailFile";
                    string targetPath = @"E:\Development\Clone\IhalematikPro\EmailFile\SentFile";
                    string sourceFile = Path.Combine(sourcePath, fileName);
                    this.DestinationFile = Path.Combine(targetPath, DateTime.Now.ToShortDateString().Replace("/", string.Empty) + Guid.NewGuid().ToString() + "-" + this.Supplier.CompanyName + "-" + fileName);

                    if (!Directory.Exists(targetPath))
                    {
                        Directory.CreateDirectory(targetPath);
                    }

                    File.Copy(sourceFile, this.DestinationFile, true);

                    oXL = new Microsoft.Office.Interop.Excel.Application();
                    oWB = oXL.Workbooks.Open(DestinationFile);
                    oSheet = String.IsNullOrEmpty("Sayfa1") ? (Microsoft.Office.Interop.Excel._Worksheet)oWB.ActiveSheet : (Microsoft.Office.Interop.Excel._Worksheet)oWB.Worksheets["Sayfa1"];

                    if (CurrentManager.Instance.CurrentOffer != null)
                    {
                        Dictionary<string, object> parameters = new Dictionary<string, object>();
                        parameters.Add("OfferId", CurrentManager.Instance.CurrentOffer.Id);
                        parameters.Add("SupplierId", this.Supplier.Id);

                        List<SupplierMaterialList> items = SupplierMaterialListProvider.Instance.GetItems(parameters);
                        List<OfferMaterialList> offerMaterialLists = new List<OfferMaterialList>();
                        if (items.Count != 0)
                        {
                            offerMaterialLists.AddRange(items.Select(p => p.MaterialList));
                        }

                        if (offerMaterialLists.Count != 0)
                        {
                            int row = 2;
                            int indexNumber = 1;

                            foreach (OfferMaterialList materialList in offerMaterialLists)
                            {
                                oSheet.Cells[row, 1] = indexNumber;
                                oSheet.Cells[row, 2] = CurrentManager.Instance.CurrentOffer.Id;
                                oSheet.Cells[row, 3] = this.Supplier.Id;//supplierId
                                oSheet.Cells[row, 4] = materialList.Id;
                                oSheet.Cells[row, 5] = materialList.PozOBF.Description;
                                oSheet.Cells[row, 6] = materialList.Quantity;
                                row++;
                                indexNumber++;
                            }
                        }
                    }

                    oWB.Save();
                }
                catch (Exception ex)
                {
                    // MessageBox.Show(ex.ToString());
                }
                finally
                {
                    if (oWB != null)
                        oWB.Close();
                }
            }
        }

        private void SendMail()
        {
            this.CreateExcel();
            if (File.Exists(this.DestinationFile))
            {
                MailingManager.Instance.SendMaterialToSupplier(this.Supplier.Email,txtEmailBody.Text ,this.DestinationFile);
            }
        }
    }
}