using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using IhalematikPro.Model;
using IhalematikPro.Manager;
using IhalematikProBL.Entity;
using IhalematikProBL.Enum;
using IhalematikProBL.Provider;
using System.IO;
using ExcelDataReader;
using IhalematikProUI.Forms;
using IhalematikProUI.Forms.Base;
using System.Diagnostics;
using IhalematikProUI.Manager;
using IhalematikProUI.Forms.PozTem;
using IhalematikProBL.Manager;
using IhalematikPro.Forms;

namespace IhalematikProUI.Forms.Genel
{
    public partial class frm_TopluPozYukle : IhalematikBaseForm
    {
        public List<Poz> pozItems = null;
        public frm_PozListesi _owner = null;
        public frm_TopluPozYukle(frm_PozListesi Owner)
        {
            this._owner = Owner;
            InitializeComponent();
        }
        public void getExcel()
        {
            pozItems = new List<Poz>();
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Excel Files(*.xls;*.xlsx)|*.xls;*.xlsx";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                
                DialogResult result = MessageBox.Show("Yüklemek istediğinizden emin misiniz?", "Yükleme Dosya içeriğine göre biraz zaman alabilir", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.Yes))
                {
                    try
                    {
                        pnlYuke.Visible = false;
                        string filename = System.IO.Path.GetFileName(dialog.FileName);
                        FileStream stream = System.IO.File.Open(dialog.FileName, FileMode.Open, FileAccess.Read);
                        IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);

                        int i = 0;
                        while (excelReader.Read())
                        {
                            if (i > 0)
                            {
                                string pozno = string.Empty;
                                try
                                {
                                    pozno = excelReader.GetString(0);
                                }
                                catch (Exception ex)
                                {
                                    double poznodouble = excelReader.GetDouble(0);
                                    pozno = poznodouble.ToString();
                                    //LoggingManager.Instance.SaveErrorLog(ex);
                                }
                                string description = excelReader.GetString(1);
                                string unit = excelReader.GetString(2);
                                double unitprice = 0;
                                try
                                {
                                    unitprice = excelReader.GetDouble(3);
                                }
                                catch (Exception ex)
                                {
                                    //LoggingManager.Instance.SaveErrorLog(ex);
                                }

                                if (!string.IsNullOrEmpty(pozno) && !string.IsNullOrEmpty(description) && !string.IsNullOrEmpty(unit))
                                {
                                    List<PozModel> existingPozs = UIPozManager.Instance.GetPozs(pozno, description);
                                    if (existingPozs != null && existingPozs.Count != 0)
                                    {
                                        listBox1.Items.Add(existingPozs.First().Number);
                                        listBox1.Items.Add(existingPozs.First().Description);
                                        listBox1.Items.Add(existingPozs.First().Unit);
                                        listBox1.Items.Add(existingPozs.First().UnitPrice);
                                    }
                                    else
                                    {
                                        Poz poz = new Poz();
                                        poz.Number = pozno;
                                        poz.Description = description;
                                        poz.Unit = unit;
                                        poz.UnitPrice = unitprice;
                                        poz.Year = DateTime.Now.Year;
                                        poz.IsActive = true;
                                        Application.DoEvents();
                                        lblPosSayisi.Text = i.ToString();
                                        pozItems.Add(poz);
                                        listBox1.Items.Add(poz.Number);
                                        listBox1.Items.Add(poz.Description);
                                        listBox1.Items.Add(poz.Unit);
                                        listBox1.Items.Add(poz.UnitPrice);
                                    }

                                    listBox1.Items.Add("-------------------------------------------------------------");
                                    listBox1.TopIndex = listBox1.Items.Count - 1;
                                }
                            }
                            i++;
                        }
                        if (pozItems == null || pozItems.Count == 0)
                        {
                            pnlYuke.Visible = false;
                            MessageBox.Show("Yüklenecek yeni poz bulunamadı.");
                            this.Close();
                            return;
                        }
                        LoadingManager.Instance.Hide();
                        this.Hide();
                        frm_TopluPozTemp pozTemp = new frm_TopluPozTemp(this._owner);
                        pozTemp.pozItems = pozItems;
                        pozTemp.ShowDialog();
                        frm_MesajFormu mesaj = new frm_MesajFormu();
                        mesaj.lblMesaj.Text = "Pozlar başarıyla yüklendi...";
                        mesaj.Close();
                    }
                    catch (Exception ex)
                    {
                        LoadingManager.Instance.Hide();
                        pnlYuke.Visible = true;
                        MessageBox.Show("Beklenmedik bir sorunla karşılaşıldı..");
                    }
                }
                else
                {
                    pnlYuke.Visible = true;
                }
            }
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.getExcel();
        }
    }
}