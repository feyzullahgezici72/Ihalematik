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

namespace IhalematikProUI.Forms.Genel
{
    public partial class frm_TopluPozYukle : DevExpress.XtraEditors.XtraForm
    {
        public frm_TopluPozYukle()
        {
            InitializeComponent();
        }
        public void getExcel()
        {
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
                        //excelReader.IsFirstRowAsColumnNames = true;
                        //DataSet result = excelReader.AsDataSet();
                        int i = 0;
                        while (excelReader.Read())
                        {
                            if (i > 1)
                            {
                                string pozno = excelReader.GetString(1);
                                string description = excelReader.GetString(2);
                                if (description == "El ile her derinlikte geniş derin batak ve balçık kazılması")
                                {

                                }
                                string unit = excelReader.GetString(3);
                                double unitprice = excelReader.GetDouble(4);

                                if (!string.IsNullOrEmpty(pozno) && !string.IsNullOrEmpty(description) && !string.IsNullOrEmpty(unit))
                                {
                                    Poz poz = new Poz();
                                    poz.Number = pozno;
                                    poz.Description = description;
                                    poz.Unit = unit;
                                    poz.UnitPrice = unitprice;
                                    poz.Year = 2018;
                                    poz.IsActive = true;
                                    Application.DoEvents();
                                    lblPozno.Text = poz.Number;
                                    lblAciklama.Text = poz.Description;
                                    lblBirim.Text = poz.Unit;
                                    lblBirimFiyat.Text = poz.UnitPrice.ToString();
                                    lblPosSayisi.Text = i.ToString();
                                    PozProvider.Instance.Save(poz);
                                }
                            }
                            i++;
                        }
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