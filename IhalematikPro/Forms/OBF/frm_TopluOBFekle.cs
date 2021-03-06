﻿using System;
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
using IhalematikProBL.Manager;
using IhalematikProUI.Manager;
using IhalematikProUI.Forms.Base;

namespace IhalematikProUI.Forms.OBF
{
    public partial class frm_TopluOBFekle :IhalematikBaseForm
    {
        private frm_OzelStokListesi _owner;
        List<IhalematikProBL.Entity.OBF> obfItems = null;// new List<IhalematikProBL.Entity.OBF>();
        public frm_TopluOBFekle(frm_OzelStokListesi Owner)
        {
            this._owner = Owner;
            InitializeComponent();
        }

        private void ReadExcel(string path)
        {
            obfItems = new List<IhalematikProBL.Entity.OBF>();
            try
            {
                pnlYuke.Visible = false;
                FileStream stream = System.IO.File.Open(@"" + path + "", FileMode.Open, FileAccess.Read);
                IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);

                int i = 0;
                while (excelReader.Read())
                {
                    Application.DoEvents();
                    try
                    {
                        if (i > 0)
                        {
                            string stokKodu = string.Empty;
                            try
                            {
                                stokKodu = excelReader.GetString(0);
                            }
                            catch (Exception ex)
                            {
                                double stokKodudouble = excelReader.GetDouble(0);
                                stokKodu = stokKodudouble.ToString();
                                //LoggingManager.Instance.SaveErrorLog(ex);
                            }
                            string description = excelReader.GetString(1);
                            string unit = excelReader.GetString(2);
                            double unitPrice = 0;
                            try
                            {
                                unitPrice = excelReader.GetDouble(3);
                            }
                            catch (Exception)
                            {
                                //unitPrice = double.Parse(excelReader.GetString(2), CultureInfo.InvariantCulture);
                            }

                            //IhalematikProBL.Entity.OBF existingObf = OBFProvider.Instance.GetOne("Description", description);
                            //if (existingObf != null)
                            //{
                            //    existingObf.UnitPrice = unitPrice;
                            //    OBFProvider.Instance.Save(existingObf);
                            //}
                            //else
                            //{
                            if (!string.IsNullOrEmpty(stokKodu) && !string.IsNullOrEmpty(description) && !string.IsNullOrEmpty(unit))
                            {
                                IhalematikProBL.Entity.OBF existingObf = OBFProvider.Instance.GetOne("Description", description);
                                if (existingObf != null)
                                {
                                    listBox1.Items.Add(existingObf.Number);
                                    listBox1.Items.Add(existingObf.Description);
                                    listBox1.Items.Add(existingObf.Unit);
                                    listBox1.Items.Add(existingObf.UnitPrice);
                                    //OBFProvider.Instance.Save(existingObf);
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
                                    lblPosSayisi.Text = i.ToString();
                                    obfItems.Add(newOBF);
                                    listBox1.Items.Add(newOBF.Number);
                                    listBox1.Items.Add(newOBF.Description);
                                    listBox1.Items.Add(newOBF.Unit);
                                    listBox1.Items.Add(newOBF.UnitPrice);
                                }

                                listBox1.Items.Add("-------------------------------------------------------------");
                                listBox1.TopIndex = listBox1.Items.Count - 1;
                            }
                            //OBFProvider.Instance.Save(newOBF);
                            //}
                        }
                    }
                    catch (Exception ex)
                    {
                        pnlYuke.Visible = true;
                        MessageBox.Show("Yuklediğiniz excel in formatını kontrol ediniz.");
                        LoggingManager.Instance.SaveErrorLog(ex);
                        this.Close();
                        break;
                    }

                    i++;
                }

                if (this.obfItems == null || this.obfItems.Count == 0)
                {
                    pnlYuke.Visible = false;
                    MessageBox.Show("Yüklemeye çalıştığınız tüm malzemelerin sitemde yüklü oldukları tespit edildi.\nDoğru dosyayı seçtiğinize dikkat ediniz.");
                    return;
                    this.Close();
                    
                }
                stream.Close();
                frm_MesajFormu mesaj = new frm_MesajFormu();
                mesaj.lblMesaj.Text = "Malzemeler başarıyla yüklendi...";
                mesaj.Close();
            }
            catch (Exception)
            {
                pnlYuke.Visible = true;
                MessageBox.Show("Yuklediğiniz excel in formatını kontrol ediniz.\n Yuklemeye calistiginiz excel dosyasi en az office 2010 ile olusturulmus olmasi gerekmektedir.\n Excel in kapali oldugundan emin olunuz");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";

            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                DialogResult result = MessageBox.Show("Yüklemek istediğinizden emin misiniz?", "Yükleme Dosya içeriğine göre biraz zaman alabilir", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.Yes))
                {
                    String path = dialog.FileName; // get name of file
                    this.ReadExcel(path);
                    this.Hide();
                    frm_TopluObfTemp obfTemp = new frm_TopluObfTemp(_owner);
                    obfTemp.obfItems = this.obfItems;
                    obfTemp.ShowDialog();
                }
                else
                {

                }

            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

        }

        private void frm_TopluOBFekle_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (labelControl2.Visible == true)
            {
                labelControl2.Visible = false;
            }
            else
            {
                labelControl2.Visible = true;
            }
        }
    }
}