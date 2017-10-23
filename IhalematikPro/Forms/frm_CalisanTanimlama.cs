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
using IhalematikPro.Model;
using IhalematikPro.Manager;
using IhalematikProBL.Entity;
using IhalematikProBL.Enum;
using IhalematikProBL.Provider;
using System.IO;
using ExcelDataReader;

namespace IhalematikPro.Forms
{
    public partial class frm_CalisanTanimlama : DevExpress.XtraEditors.XtraForm
    {
        List<Worker> workers = new List<Worker>();
        public frm_CalisanTanimlama()
        {
            InitializeComponent();
            InitilalizeForm();
            //getExcel();
        }

        public void getExcel()
        {
            FileStream stream = System.IO.File.Open(@"E:\2017BirimFiyat.xlsx", FileMode.Open, FileAccess.Read);

            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            //excelReader.IsFirstRowAsColumnNames = true;
            //DataSet result = excelReader.AsDataSet();
            int i = 0;
            while (excelReader.Read())
            {
                if (i > 1)
                {
                    string pozno = excelReader.GetString(0);
                    string description = excelReader.GetString(1);
                    string unit = excelReader.GetString(2);
                    double unitprice = excelReader.GetDouble(3);

                    if (!string.IsNullOrEmpty(pozno) && !string.IsNullOrEmpty(description) && !string.IsNullOrEmpty(unit))
                    {

                        Poz poz = new Poz();
                        poz.Number = pozno;
                        poz.Description = description;
                        poz.Unit = unit;
                        poz.UnitPrice = unitprice;


                        PozProvider.Instance.Save(poz);
                    }

                    //List<Country> countries = CountryProvider.Instance.GetItems("Code", code);

                    //foreach (Country country in countries)
                    //{

                    //    string PhoneAreacode = excelReader.GetString(1);
                    //    string PassaportMandotry = excelReader.GetString(2);

                    //    string turkce = excelReader.GetString(3);
                    //    string ingilizce = excelReader.GetString(4);
                    //    string hirvatca = excelReader.GetString(5);

                    //    CountryProvider.Instance.Save(country);
                    //}

                }
                i++;
            }

        }
        public void InitilalizeForm()
        {
            List<TitleModel> models = UITitleManager.Instance.GetTitles();
            ddlTitles.Properties.Items.AddRange(models);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_CalisanTanimlama_Load(object sender, EventArgs e)
        {
            LoadGrid();
            this.KeyPreview = true;
            this.KeyDown +=new KeyEventHandler( Frm_CalisanTanimlama_KeyDown);
        }

        private void Frm_CalisanTanimlama_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                frm_CalisanEkle frm = new frm_CalisanEkle();
                frm.ShowDialog();
            }

        }

        private void LoadGrid()
        {
            List<WorkerModel> models = UIWorkerManager.Instance.GetWorkers();
            grdWorker.DataSource = models;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            WorkerModel model = new WorkerModel();
            //model.Code = txtCode.Text;
            model.TitleId = ((TitleModel)ddlTitles.SelectedItem).Id.Value;
            model.IsNormal = rbNormal.Checked;
            model.BaseFare = new Fare(double.Parse(txtBaseFare.Text));
            model.SGKPrimFare = new Fare(SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtSGKPrimFare.Text));

            model.WorklesFonFare = new Fare(SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtWorklesFonFare.Text));
            model.IncomeTaxFare = new Fare(SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtIncomeTaxFare.Text));
            model.SeveranceFare = new Fare(SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtSeveranceFare.Text));

            model.StampTaxFare = new Fare(SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtStampTaxFare.Text));
            model.AGIFare = new Fare(SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtAGI.Text));
            model.FoodFare = new Fare(SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtFoodFare.Text));
            model.TravelFare = new Fare(SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtTravelFare.Text));
            model.HotelFare = new Fare(SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtHotelFare.Text));
            model.ISGFare = new Fare(SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtISGFare.Text));
            model.ExtraFare = new Fare(SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtExtraFare.Text));

            model.Save();
            LoadGrid();
        }

        private void txtBaseFare_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void rbAsgariUcret_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.rbNormal.Checked)
            {
                double asgariUcret = 1404;
                txtBaseFare.Text = asgariUcret.ToString();
                txtSGKPrimFare.Text = Math.Round((asgariUcret / 100 * 13), 2).ToString();
            }

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void çalışanEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void txtBaseFare_EditValueChanged_1(object sender, EventArgs e)
        {
            //double NetUcretUcret = double.Parse(txtBaseFare.Text);
            //txtSGKPrimFare.Text = Math.Round((NetUcretUcret / 100 * 14), 2).ToString();
            //txtWorklesFonFare.Text = Math.Round((NetUcretUcret / 100 * 1), 2).ToString();
            //txtIncomeTaxFare.Text = Math.Round((NetUcretUcret / 100 * 15), 2).ToString();
            //txtStampTaxFare.Text = Math.Round((NetUcretUcret / 1000 * 759), 2).ToString();
            //Net Maaş    4.000,00 TL
            //SGK Primi İşçi Payı(% 14)    560,00 TL
            //İşsizlik Sig.Fonu(% 1)  40,00 TL
            //Gelir Vergisi(% 15)  600,00 TL
            //Damga Vergisi(% 0, 759)   30,36 TL
            //Asgari Geçim İndirimi    123,53 TL
            //Toplam Maliyet   5.353,89 TL

        }

        private void rbNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.rbAsgariUcret.Checked)
            {
                double NetUcretUcret = double.Parse(txtBaseFare.Text);
                txtSGKPrimFare.Text = Math.Round((NetUcretUcret / 100 * 14), 2).ToString();
                txtWorklesFonFare.Text = Math.Round((NetUcretUcret / 100 * 1), 2).ToString();
                txtIncomeTaxFare.Text = Math.Round((NetUcretUcret / 100 * 15), 2).ToString();
                txtStampTaxFare.Text = Math.Round((NetUcretUcret / 1000 *  759), 2).ToString();




            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
           
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frm_CalisanEkle frm = new frm_CalisanEkle();
            frm.ShowDialog();
        }
    }
}