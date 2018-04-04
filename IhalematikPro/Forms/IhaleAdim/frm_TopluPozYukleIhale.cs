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
                pnlYuke.Visible = false;
                DialogResult result = MessageBox.Show("Yüklemek istediğinizden emin misiniz?", "Yükleme Dosya içeriğine göre biraz zaman alabilir", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.Yes))
                {
                    try
                    {
                        string filename = System.IO.Path.GetFileName(dialog.FileName);
                        FileStream stream = System.IO.File.Open(dialog.FileName, FileMode.Open, FileAccess.Read);
                        IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                        this.pbar1.Properties.Maximum = 265;
                        int i = 0;
                        while (excelReader.Read())
                        {
                            if (i > 0)
                            {
                                Application.DoEvents();
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
                                        //poz = existingPozs.First();
                                        pozId = existingPozs.First().Id.Value;

                                        listBox1.Items.Add(existingPozs.First().Number);
                                        listBox1.Items.Add(existingPozs.First().Description);
                                        listBox1.Items.Add(existingPozs.First().Unit);
                                        lblPosSayisi.Text = i.ToString();
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
                                         
                                        lblPosSayisi.Text = i.ToString();

                                        listBox1.Items.Add(poz.Number);
                                        listBox1.Items.Add(poz.Description);
                                        listBox1.Items.Add(poz.Unit);
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
                            this.pbar1.Position = i;
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
    }
}