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
using System.IO;
using ExcelDataReader;
using IhalematikProBL.Provider;
using IhalematikPro.Manager;
using IhalematikProBL.Manager;
using IhalematikProBL.Entity;
using IhalematikPro.Forms;

namespace IhalematikProUI.Forms.IhaleAdim
{
    public partial class frm_TopluObfYukleIhale : DevExpress.XtraEditors.XtraForm
    {
        public frm_Teklif_Adim1 _owner { get; set; }
        public int SelectedTenderGroupId { get; set; }

        public List<MaterialList> materialListItems = null;
        public frm_TopluObfYukleIhale(frm_Teklif_Adim1 Owner)
        {
            this._owner = Owner;
            InitializeComponent();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";

            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                DialogResult result = MessageBox.Show("Yüklemek istediğinizden emin misiniz?", "Yükleme Dosya içeriğine göre biraz zaman alabilir", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.Yes))
                {
                    pnlYukle.Visible = false;
                    String path = dialog.FileName; // get name of file
                    this.ReadExcel(path);
                    this.Hide();
                    //frm_TopluObfTemp obfTemp = new frm_TopluObfTemp(_owner);
                    //obfTemp.obfItems = this.obfItems;
                    //obfTemp.ShowDialog();
                }
            }
        }

        private void ReadExcel(string path)
        {
            materialListItems = new List<MaterialList>();
            // obfItems = new List<IhalematikProBL.Entity.OBF>();
            try
            {
                FileStream stream = System.IO.File.Open(@"" + path + "", FileMode.Open, FileAccess.Read);
                IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                int i = 0;
                while (excelReader.Read())
                {
                    
                    try
                    {
                        if (i > 0)
                        {
                            int obfId = 0;
                            string stokKodu = string.Empty;
                            try
                            {
                                stokKodu = excelReader.GetString(0);
                            }
                            catch (Exception ex)
                            {
                                double stokKodudouble = excelReader.GetDouble(0);
                                stokKodu = stokKodudouble.ToString();
                            }
                            string description = excelReader.GetString(1);
                            if (!string.IsNullOrEmpty(stokKodu) && !string.IsNullOrEmpty(description))
                            {
                                string unit = excelReader.GetString(2);

                                IhalematikProBL.Entity.OBF existingObf = OBFProvider.Instance.GetOne("Description", description);
                                if (existingObf != null)
                                {
                                    obfId = existingObf.Id;
                                    
                                    lblPosSayisi.Text = i.ToString();
                                    listBox1.Items.Add(existingObf.Number);
                                    listBox1.Items.Add(existingObf.Description);
                                    listBox1.Items.Add(existingObf.Unit);
                                    //OBFProvider.Instance.Save(existingObf);
                                }
                                else
                                {
                                    IhalematikProBL.Entity.OBF obf = new IhalematikProBL.Entity.OBF();
                                    int lastTenderNumber = UIOBFManager.Instance.GetLastOBFNumber();
                                    obf.Number = string.Format("{0}", (lastTenderNumber + 1).ToString().PadLeft(8, '0'));
                                    obf.StokNumber = stokKodu;
                                    obf.Description = description;
                                    obf.Unit = unit;
                                    obf.UnitPrice = 0;
                                    obf.IsActive = true;
                                    OBFProvider.Instance.Save(obf);
                                    obfId = obf.Id;
                                    lblPosSayisi.Text = i.ToString();
                                    listBox1.Items.Add(obf.Number);
                                    listBox1.Items.Add(obf.Description);
                                    listBox1.Items.Add(obf.Unit);
                                }

                                double quantity = 0;
                                try
                                {
                                    quantity = excelReader.GetDouble(3);
                                }
                                catch (Exception ex)
                                {

                                }
                                listBox1.Items.Add(quantity.ToString());
                                listBox1.Items.Add("-------------------------------------------------------------");
                                listBox1.TopIndex = listBox1.Items.Count - 1;
                                if (obfId != 0)
                                {
                                    MaterialList materialList = new MaterialList();
                                    materialList.IsPoz = false;
                                    materialList.PozOBFId = obfId;
                                    materialList.Quantity = (float)quantity;
                                    materialList.KDVPercentage = 18;
                                    materialList.Tender = CurrentManager.Instance.CurrentTender;
                                    materialList.TenderGroupId = this._owner.SelectedGroupId;
                                    materialListItems.Add(materialList);
                                }
                            }
                        }
                        i++;
                    }
                    catch (Exception ex)
                    {
                        pnlYukle.Visible = true;
                        MessageBox.Show("Yuklediğiniz excel in formatını kontrol ediniz.");
                        LoggingManager.Instance.SaveErrorLog(ex);
                        this.Close();
                        break;
                    }
                }
                stream.Close();
                this.Hide();

                if (this.materialListItems == null || this.materialListItems.Count == 0)
                {
                    pnlYukle.Visible = false;
                    MessageBox.Show("Yüklenecek OBF bulunamadı.");
                    this.Close();
                    return;
                }

                frm_TopluObfYukleIhaleTemp pozTemp = new frm_TopluObfYukleIhaleTemp(this._owner);
                pozTemp.MaterialListItems = materialListItems;
                pozTemp.ShowDialog();
                frm_MesajFormu mesaj = new frm_MesajFormu();
                mesaj.lblMesaj.Text = "OBFler başarıyla yüklendi...";
                mesaj.Close();
            }
            catch (Exception)
            {
                pnlYukle.Visible = true;
                MessageBox.Show("Yuklediğiniz excel in formatını kontrol ediniz.\n Yuklemeye calistiginiz excel dosyasi en az office 2010 ile olusturulmus olmasi gerekmektedir.\n Excel in kapali oldugundan emin olunuz");
            }
        }
    }
}