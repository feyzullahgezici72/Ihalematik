using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using ExcelDataReader;
using IhalematikProBL.Provider;
using IhalematikPro.Manager;
using IhalematikPro.Forms;
using System.Globalization;

namespace IhalematikProUI.Forms.OBF
{
    public partial class frm_TopluOBFekle : DevExpress.XtraEditors.XtraForm
    {
        private frm_OzelStokListesi _owner;
        public frm_TopluOBFekle(frm_OzelStokListesi Owner)
        {
            this._owner = Owner;
            InitializeComponent();
        }

        private void btnTopluOFBekle_Click(object sender, EventArgs e)
        {
            

        }

        private void ReadExcel(string path)
        {

            try
            {
                FileStream stream = System.IO.File.Open(@"" + path + "", FileMode.Open, FileAccess.Read);
                IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);

                int i = 0;
                while (excelReader.Read())
                {
                    Application.DoEvents();
                    try
                    {
                        if (i >= 1)
                        {
                            try
                            {
                                excelReader.GetString(0);
                            }
                            catch (Exception)
                            {

                                lblobfno.Text = "";
                                lblAciklama.Text = "";
                                lblBirim.Text = "";
                                lblBirimFiyat.Text = "";
                                frm_MesajFormu mesaj = new frm_MesajFormu();
                                mesaj.lblMesaj.Text = "Malzemeler başarıyla yüklendi...";
                                mesaj.Close();
                                break;
                            }
                            string stokKodu = excelReader.GetString(0);
                            string description = excelReader.GetString(1);
                            string unit = excelReader.GetString(2);
                            double unitPrice = 0;
                            try
                            {
                                unitPrice = excelReader.GetDouble(3);
                            }
                            catch (Exception)
                            {
                                unitPrice = double.Parse(excelReader.GetString(3), CultureInfo.InvariantCulture);
                            }

                            IhalematikProBL.Entity.OBF existingObf = OBFProvider.Instance.GetOne("Description", description);
                            if (existingObf != null)
                            {
                                existingObf.UnitPrice = unitPrice;
                                OBFProvider.Instance.Save(existingObf);
                            }
                            else
                            {
                                IhalematikProBL.Entity.OBF newOBF = new IhalematikProBL.Entity.OBF();
                                int lastTenderNumber = UIOBFManager.Instance.GetLastOBFNumber();
                                newOBF.Number = string.Format("{0}", (lastTenderNumber + 1).ToString().PadLeft(8, '0'));
                                newOBF.IsActive = true;
                                newOBF.StokNumber = stokKodu;
                                newOBF.Description = description;
                                newOBF.Unit = unit;
                                newOBF.UnitPrice = unitPrice;
                                Application.DoEvents();
                                lblobfno.Text = newOBF.StokNumber;
                                lblAciklama.Text = newOBF.Description;
                                lblBirim.Text = newOBF.Unit;
                                lblBirimFiyat.Text = newOBF.UnitPrice.ToString();
                                lblPosSayisi.Text = i.ToString();
                                OBFProvider.Instance.Save(newOBF);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Yuklediğiniz excel in formatını kontrol ediniz.");
                        //MesajPanel.Visible = false;
                        //TODO feyzullahg hata olustu mesaji gostermek lazim.
                        break;
                    }

                    i++;
                }
                stream.Close();
                //MesajPanel.Visible = false;

            }
            catch (Exception)
            {
                MessageBox.Show("Yuklediğiniz excel in formatını kontrol ediniz.\n Yuklemeye calistiginiz excel dosyasi en az office 2010 ile olusturulmus olmasi gerekmektedir.\n Excel in kapali oldugundan emin olunuz");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";

            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                //MesajPanel.Visible = true;
                // MessageBox.Show("Yükleme Malzeme sayısına göre biraz zaman alabilir...");
                String path = dialog.FileName; // get name of file
                this.ReadExcel(path);
                this.Close();
                this._owner.LoadGrid();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}