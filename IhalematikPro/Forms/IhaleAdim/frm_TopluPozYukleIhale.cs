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
using IhalematikProBL.Entity;
using System.IO;
using ExcelDataReader;
using IhalematikPro.Manager;
using IhalematikProBL.Provider;
using IhalematikPro.Model;
using IhalematikPro.Forms;

namespace IhalematikProUI.Forms.IhaleAdim
{
    public partial class frm_TopluPozYukleIhale : DevExpress.XtraEditors.XtraForm
    {
        public frm_Teklif_Adim1 _owner { get; set; }
        public int SelectedTenderGroupId { get; set; }

        public List<MaterialList> materialListItems = null;
        public frm_TopluPozYukleIhale(frm_Teklif_Adim1 Owner)
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
            this.getExcel();
        }
        public void getExcel()
        {
            materialListItems = new List<MaterialList>();
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
                                int pozId = 0;
                                string pozno = string.Empty;
                                try
                                {
                                    pozno = excelReader.GetString(0);
                                }
                                catch (Exception ex)
                                {
                                    double poznodouble = excelReader.GetDouble(0);
                                    pozno = poznodouble.ToString();
                                }

                                string description = excelReader.GetString(1);
                                string unit = excelReader.GetString(2);
                                if (!string.IsNullOrEmpty(pozno) && !string.IsNullOrEmpty(description))
                                {
                                    List<PozModel> existingPozs = UIPozManager.Instance.GetPozs(pozno, description);
                                    if (existingPozs != null && existingPozs.Count != 0)
                                    {
                                        pozId = existingPozs.First().Id.Value;
                                    }
                                    else
                                    {
                                        Poz poz = new Poz();
                                        poz.Number = pozno;
                                        poz.Description = description;
                                        poz.Unit = unit;
                                        poz.UnitPrice = 0;
                                        poz.Year = DateTime.Now.Year;
                                        poz.IsActive = true;
                                        PozProvider.Instance.Save(poz);
                                        pozId = poz.Id;
                                        lblPozno.Text = poz.Number;
                                        lblAciklama.Text = poz.Description;
                                        lblBirim.Text = poz.Unit;
                                        lblBirimFiyat.Text = poz.UnitPrice.ToString();
                                        lblPosSayisi.Text = i.ToString();
                                    }

                                    double quantity = 0;
                                    try
                                    {
                                        quantity = excelReader.GetDouble(3);
                                    }
                                    catch (Exception ex)
                                    {

                                    }

                                    if (pozId != 0)
                                    {
                                        MaterialList materialList = new MaterialList();
                                        materialList.IsPoz = true;
                                        materialList.PozOBFId = pozId;
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
                        stream.Close();
                        this.Hide();
                        frm_TopluPozIhaleTemp pozTemp = new frm_TopluPozIhaleTemp(this._owner);
                        pozTemp.MaterialListItems = materialListItems;
                        pozTemp.ShowDialog();
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
    }
}