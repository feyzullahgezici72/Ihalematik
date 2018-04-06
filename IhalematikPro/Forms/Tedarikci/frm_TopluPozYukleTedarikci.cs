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

namespace IhalematikProUI.Forms.Tedarikci
{
    public partial class frm_TopluPozYukleTedarikci : IhalematikBaseForm
    {
        public List<Poz> pozItems = null;
        public frm_TedarikcilereTeklifGonder _owner = null;
        public List<OfferMaterialList> materialListItems = null;

        public frm_TopluPozYukleTedarikci(frm_TedarikcilereTeklifGonder Owner)
        {
            this._owner = Owner;
            InitializeComponent();
        }
        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void getExcel()
        {
            this.materialListItems = new List<OfferMaterialList>();
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Excel Files(*.xls;*.xlsx)|*.xls;*.xlsx";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                DialogResult result = MessageBox.Show("Yüklemek istediğinizden emin misiniz?", "Yükleme Dosya içeriğine göre biraz zaman alabilir", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.Yes))
                {
                    pnlYuke.Visible = false;
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
                                    //LoggingManager.Instance.SaveErrorLog(ex);
                                }
                                string description = excelReader.GetString(1);
                                string unit = excelReader.GetString(2);

                                if (!string.IsNullOrEmpty(pozno) && !string.IsNullOrEmpty(description) && !string.IsNullOrEmpty(unit))
                                {
                                    List<PozModel> existingPozs = UIPozManager.Instance.GetPozs(pozno, description);
                                    if (existingPozs != null && existingPozs.Count != 0)
                                    {
                                        pozId = existingPozs.First().Id.Value;
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
                                        poz.Year = DateTime.Now.Year;
                                        poz.IsActive = true;
                                        PozProvider.Instance.Save(poz);
                                        pozId = poz.Id;

                                        Application.DoEvents();
                                        lblPosSayisi.Text = i.ToString();
                                        listBox1.Items.Add(poz.Number);
                                        listBox1.Items.Add(poz.Description);
                                        listBox1.Items.Add(poz.Unit);
                                        listBox1.Items.Add(poz.UnitPrice);
                                    }
                                    lblPosSayisi.Text = i.ToString();

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
                                    if (pozId != 0)
                                    {
                                        OfferMaterialList materialList = new OfferMaterialList();
                                        materialList.IsPoz = true;
                                        materialList.PozOBFId = pozId;
                                        materialList.Quantity = (float)quantity;
                                        materialList.Offer = CurrentManager.Instance.CurrentOffer;
                                        materialListItems.Add(materialList);
                                    }
                                }
                            }
                            i++;
                        }
                        this.Hide();
                        if (this.materialListItems == null || this.materialListItems.Count == 0)
                        {
                            pnlYuke.Visible = true;
                            MessageBox.Show("Yüklenecek Poz bulunamadı.");
                            this.Close();
                            return;
                        }
                        frm_TopluPozTedarikciTemp pozTemp = new frm_TopluPozTedarikciTemp(this._owner);
                        pozTemp.MaterialList = materialListItems;
                        pozTemp.ShowDialog();
                        frm_MesajFormu mesaj = new frm_MesajFormu();
                        mesaj.lblMesaj.Text = "Pozlar başarıyla yüklendi...";
                        mesaj.Close();
                    }
                    catch (Exception ex)
                    {
                        pnlYuke.Visible = true;
                        MessageBox.Show("Beklenmedik bir sorunla karşılaşıldı..");
                    }
                }
                else
                {
                
                }
            }
        }
        private void btnYukle_Click(object sender, EventArgs e)
        {
            this.getExcel();
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}