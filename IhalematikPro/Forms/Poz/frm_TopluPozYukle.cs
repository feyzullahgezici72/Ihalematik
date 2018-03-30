﻿using System;
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
    public partial class frm_TopluPozYukle : DevExpress.XtraEditors.XtraForm
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
                                    Poz poz = new Poz();
                                    poz.Number = pozno;
                                    poz.Description = description;
                                    poz.Unit = unit;
                                    poz.UnitPrice = unitprice;
                                    poz.Year = DateTime.Now.Year;
                                    poz.IsActive = true;
                                    Application.DoEvents();
                                    lblPozno.Text = poz.Number;
                                    lblAciklama.Text = poz.Description;
                                    lblBirim.Text = poz.Unit;
                                    lblBirimFiyat.Text = poz.UnitPrice.ToString();
                                    lblPosSayisi.Text = i.ToString();
                                    pozItems.Add(poz);
                                }
                            }
                            i++;
                        }
                        this.Hide();
                        frm_TopluPozTemp pozTemp = new frm_TopluPozTemp(this._owner);
                        pozTemp.pozItems = pozItems;
                        pozTemp.ShowDialog();
                        lblPozno.Text = "";
                        lblAciklama.Text = "";
                        lblBirim.Text = "";
                        lblBirimFiyat.Text = "";
                        frm_MesajFormu mesaj = new frm_MesajFormu();
                        mesaj.lblMesaj.Text = "Pozlar başarıyla yüklendi...";
                        mesaj.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Beklenmedik bir sorunla karşılaşıldı..");
                    }
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.getExcel();
        }
    }
}