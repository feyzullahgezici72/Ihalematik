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
using SimpleApplicationBase.BL.Base;
using IhalematikProUI.Manager;
using IhalematikProUI.Forms.Base;

namespace IhalematikProUI.Forms.Tedarikci
{
    public partial class frm_TedarikciyeAktarilanMalzemeDetay : IhalematikBaseForm
    {
        protected Task SendMailTask { get; set; }
        public bool IsSendMail { get; set; }
        public bool ShowMailPanel { get; set; }
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

        private Microsoft.Office.Interop.Excel.Application oXL = null;
        private Microsoft.Office.Interop.Excel._Workbook oWB = null;

        public frm_TedarikciyeAktarilanMalzemeDetay()
        {
            InitializeComponent();
            //this._owner = Owner;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_TedarikciyeAktarilanMalzemeDetay_Shown(object sender, EventArgs e)
        {
            pnlMail.Visible = this.ShowMailPanel;
            //Supplier supplier = SupplierProvider.Instance.GetItem(this.SelectedSupplierId);
            if (this.Supplier != null)
            {
                txtCompanyName.Text = this.Supplier.CompanyName;
                txtAuthorNameSurname.Text = this.Supplier.AuthorNameSurname;
                txtEmail.Text = this.Supplier.Email;
                txtScore.Text = this.Supplier.Score;
                if (this.Supplier.Segments != null)
                {
                    foreach (var item in this.Supplier.Segments)
                    {
                        memoEditSupplierSegment.Text += item.Name + Environment.NewLine;
                    }
                }
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("OfferId", UICurrentManager.Instance.CurrentOffer.Id);
                parameters.Add("SupplierId", supplier.Id);

                List<SupplierMaterialList> items = SupplierMaterialListProvider.Instance.GetItems(parameters);

                grdMaterialList.DataSource = items.Select(p => p.MaterialList).ToList();
            }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            List<OfferMaterialList> items = grdMaterialList.DataSource as List<OfferMaterialList>;
            if (items != null && items.Count != 0)
            {
                LoadingManager.Instance.Show(this, "E-mail Gönderiliyor");
                this.IsSendMail = false;
                this.CreateExcel();
                OperationResult result = this.SendMail();
                if (result.Success)
                {
                    this.SendInfoMessage();
                }
                else
                {
                    //emailMesajPanel.Visible = false;
                    if (result.ValidationResults.Count > 0)
                    {
                        if (result.ValidationResults.FirstOrDefault().PropertyName == "NoInternetconnection")
                        {
                            MessageBox.Show("Internet bağlantınızın olduğundan emin olunuz\n veya e-posta gönderdiğiniz firmanın mail adresinin \n doğruluğunu kontrol ediniz");
                            this.Enabled = true;
                        }
                        else if (result.ValidationResults.FirstOrDefault().PropertyName == "GmailLessSecureApps")
                        {
                            MessageBox.Show("Lutfen firma bilgileri bolumunden \n email kullanici adi ve sifrenizi kontrol ediniz \n veya /https://myaccount.google.com/lesssecureapps/ \n mail gonderilebilmesi icin izin verdiginizden emin olun");
                            this.Enabled = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mail gonderirken hata oluştu.Lütfen daha sonra tekrar deneyiniz");
                        this.Enabled = true;
                    }
                }
                LoadingManager.Instance.Hide();
            }
            else
            {
                MessageBox.Show("Gönderilecek malzeme listesi boş olamaz");
                this.Enabled = true;
            }
        }

        private void CreateExcel()
        {
            Application.DoEvents();
            this.oXL = null;
            this.oWB = null;
            Microsoft.Office.Interop.Excel._Worksheet oSheet = null;

            //List<Supplier> suppliers = CurrentManager.Instance.CurrentOffer.Suppliers;
            if (this.Supplier != null)
            {
                Application.DoEvents();
                try
                {
                    string fileName = "Malzeme_Fiyat_Listesi.xlsx";
                    //string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "EmailFile");
                    string sourcePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory.Replace("bin\\Debug\\", string.Empty), "EmailFile");
                    string targetPath = Path.Combine(sourcePath, "SentFile");
                    string sourceFile = Path.Combine(sourcePath, fileName);
                    this.DestinationFile = Path.Combine(targetPath, this.Supplier.CompanyName + "-" + DateTime.Now.ToShortDateString().Replace("/", string.Empty) + "-" + fileName);
                    if (File.Exists(this.DestinationFile))
                    {
                        this.DestinationFile = Path.Combine(targetPath, this.Supplier.CompanyName + "-" + DateTime.Now.ToShortDateString().Replace("/", string.Empty) + "-" + new Random().Next(1, 100000).ToString() + "-" + fileName);
                    }
                    if (!Directory.Exists(targetPath))
                    {
                        Directory.CreateDirectory(targetPath);
                    }
                    File.Copy(sourceFile, this.DestinationFile, true);
                    oXL = new Microsoft.Office.Interop.Excel.Application();
                    oWB = oXL.Workbooks.Open(DestinationFile);
                    oSheet = String.IsNullOrEmpty("Sayfa1") ? (Microsoft.Office.Interop.Excel._Worksheet)oWB.ActiveSheet : (Microsoft.Office.Interop.Excel._Worksheet)oWB.Worksheets["Sayfa1"];
                    if (UICurrentManager.Instance.CurrentOffer != null)
                    {
                        Dictionary<string, object> parameters = new Dictionary<string, object>();
                        parameters.Add("OfferId", UICurrentManager.Instance.CurrentOffer.Id);
                        parameters.Add("SupplierId", this.Supplier.Id);
                        List<SupplierMaterialList> items = SupplierMaterialListProvider.Instance.GetItems(parameters);
                        List<OfferMaterialList> offerMaterialLists = new List<OfferMaterialList>();
                        if (items.Count != 0)
                        {
                            offerMaterialLists.AddRange(items.Select(p => p.MaterialList));
                        }

                        if (offerMaterialLists.Count != 0)
                        {
                            int row = 7;
                            int indexNumber = 1;
                            oSheet.Cells[1, 5] = UICurrentManager.Instance.CurrentCompany.Name;
                            oSheet.Cells[2, 5] = UICurrentManager.Instance.CurrentCompany.Address;
                            oSheet.Cells[2, 11] = DateTime.Now.ToShortDateString();
                            oSheet.Cells[4, 6] = this.Supplier.CompanyName;
                            foreach (OfferMaterialList materialList in offerMaterialLists)
                            {
                                oSheet.Cells[row, 2] = UICurrentManager.Instance.CurrentOffer.Id;
                                oSheet.Cells[row, 3] = this.Supplier.Id;//supplierId
                                oSheet.Cells[row, 4] = materialList.Id;
                                oSheet.Cells[row, 5] = indexNumber;
                                if (!string.IsNullOrEmpty(materialList.PozOBF.DescriptionForSupplier))
                                {
                                    oSheet.Cells[row, 6] = materialList.PozOBF.DescriptionForSupplier;
                                }
                                else
                                {
                                    oSheet.Cells[row, 6] = materialList.PozOBF.Description;
                                }
                                oSheet.Cells[row, 7] = materialList.PozOBF.Unit;
                                oSheet.Cells[row, 9] = materialList.Quantity;
                                row++;
                                indexNumber++;
                            }
                        }
                    }
                    int LogoW = 180;
                    int LogoH = 80;
                    if (!string.IsNullOrEmpty(UICurrentManager.Instance.CurrentCompany.LogoPath))
                    {
                        string path = string.Empty;
                        if (Application.StartupPath.Contains("bin\\Debug"))
                        {
                            path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                        }
                        else
                        {
                            path = Application.StartupPath.Substring(0, (Application.StartupPath.Length));
                        }
                        path = path + "\\EmailFile\\Images\\Logo\\" + UICurrentManager.Instance.CurrentCompany.LogoPath;
                        oSheet.Shapes.AddPicture(path, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, 330, 2, LogoW, LogoH);
                    }
                    oWB.Save();
                }
                catch (Exception ex)
                {
                    if (this.oWB != null)
                        this.oWB.Close();
                    if (this.oXL != null)
                        this.oXL.Quit();
                    LoggingManager.Instance.SaveErrorLog(ex);
                }
                finally
                {
                    if (this.oWB != null)
                        this.oWB.Close();
                    if (this.oXL != null)
                        this.oXL.Quit();
                }
            }
        }



        private void SendInfoMessage()
        {
            if (!this.IsSendMail)
            {
                if (this.SendMailTask == null)
                {
                    //throw new SessionExpiredException();
                }

                else
                {
                    try
                    {
                        this.SendMailTask.Wait();
                        this.SendInfoMessage();
                    }

                    catch (Exception ex)
                    {
                        LoggingManager.Instance.SaveErrorLog(ex);
                    }
                }
            }
            else
            {
                LoadingManager.Instance.Hide(); ;
                this.Enabled = true;
                frm_MesajFormu mesajformu = new frm_MesajFormu();
                mesajformu.lblMesaj.Text = "Mail Gönderildi...";
                mesajformu.ShowDialog();
                this.Close();
            }
        }
        private OperationResult SendMail()
        {
            OperationResult result = new OperationResult();
            try
            {
                if (File.Exists(this.DestinationFile))
                {
                    result = MailingManager.Instance.SendMaterialToSupplier(this.Supplier.Email, txtEmailBody.Text, this.DestinationFile);
                    if (result.Success)
                    {
                        this.IsSendMail = true;
                    }
                }
            }
            catch (Exception ex)
            {
                LoggingManager.Instance.SaveErrorLog(ex);
            }

            return result;
        }

        private void frm_TedarikciyeAktarilanMalzemeDetay_Load(object sender, EventArgs e)
        {

        }
    }
}