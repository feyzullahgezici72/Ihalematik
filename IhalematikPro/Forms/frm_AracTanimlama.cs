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
using IhalematikProUI.Forms;
using System.Threading;

namespace IhalematikPro.Forms
{
    public partial class frm_AracTanimlama : DevExpress.XtraEditors.XtraForm
    {
        public frm_AracTanimlama()
        {
            InitializeComponent();
            InitilalizeForm();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void InitilalizeForm()
        {

            List<VehicleTitleModel> models = UIVehicleTitleManager.Instance.GetVehicleTitles();
            ddlVehicleTitle.Properties.Items.AddRange(models);
            ddlVehicleTitle.SelectedIndex = 0;
        }

        public void LoadGrid()
        {
            List<VehicleModel> models = UIVehicleManager.Instance.GetVehicles();
            grdVehicle.DataSource = models;
        }
        private void frm_AracTanimlama_Load(object sender, EventArgs e)
        {
            LoadGrid();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Frm_AracTanimlama_KeyDown);
        
             
        }

        private void Frm_AracTanimlama_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                frm_AracEkle frm = new frm_AracEkle();
                frm.ShowDialog();
            }

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            VehicleModel model = new VehicleModel();
            model.TitleId = ((VehicleTitleModel)ddlVehicleTitle.SelectedItem).Id.Value;
            if (rbCompanyVehicle.Checked)
            {
                model.IsCompanyVehicle = true;
                model.FuelOilFare = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtFuelOilFare.Text);
                model.FuelOilDay = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<float>(txtFuelOilDay.Text);
                model.DriverFare = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtDriverFare.Text);
                model.MaintenanceFare = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtMaintenanceFare.Text);
                model.ServiceFare = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtServiceFare.Text);
                model.GeneralFare = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtGeneralFare.Text);
                model.OtherFare = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtOtherFare.Text);
            }
            else
            {
                model.IsCompanyVehicle = false;

                if (rdHour.Checked)
                {
                    model.RentType = IhalematikProBL.Enum.RentTypesEnum.Hour;
                }
                else if (rdDay.Checked)
                {
                    model.RentType = IhalematikProBL.Enum.RentTypesEnum.Day;
                }
                else if (rdMonth.Checked)
                {
                    model.RentType = IhalematikProBL.Enum.RentTypesEnum.Month;
                }
                model.FuelOilFare = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtRentFuelOilFare.Text);
                model.FuelOilDay = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<float>(txtRentFuelOilDay.Text);
                model.DriverFare = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtRentDriverFare.Text);
                model.RentFare = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtRentFare.Text);
                //model.MaintenanceFare = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtMaintenanceFare.Text);
                //model.ServiceFare = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtServiceFare.Text);
                model.GeneralFare = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtRentGeneralFare.Text);
                model.OtherFare = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtRentOtherFare.Text);
            }

           
            //model.FuelOilFare = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtFuelOilFare.Text);
            //model.FuelOilDay = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<float>(txtFuelOilDay.Text);
            //model.DriverFare = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtDriverFare.Text);
            //model.MaintenanceFare = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtMaintenanceFare.Text);
            //model.ServiceFare = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtServiceFare.Text);
            //model.GeneralFare = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtGeneralFare.Text);
            //model.OtherFare = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtOtherFare.Text);
            model.Save();
            LoadGrid();
        }

        private void yeniAraçEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_AracEkle frm = new frm_AracEkle();
            frm.ShowDialog();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void rbCompanyVehicle_CheckedChanged(object sender, EventArgs e)
        {
            PanelSirket.Visible = true;
            PanelKira.Visible = false;
          
        }

        private void rbAsgariUcret_CheckedChanged(object sender, EventArgs e)
        {
            PanelKira.Visible = true;
            PanelSirket.Visible = false;
            PanelKira.Location =  new Point(12,52); //1347; 73


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frm_AracEkle frm = new frm_AracEkle();
            frm.ShowDialog();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        
        }

        private void panelControl2_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void btnGuncelle_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            frm_Arac_Guncelleme frm = new frm_Arac_Guncelleme(this);

            int id = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewVehicle.GetFocusedRowCellValue("Id"));
            frm.CurrentVehicleId = id;

            // frm.Location = new Point(5, 215);
            KayitMenusu.Visible = false;
            this.Opacity = 10;
            this.Enabled = false;
            frm.ShowDialog();
            this.Enabled = true;
            this.Opacity = 100;
            KayitMenusu.Visible = true;
        }

        private void grdVehicle_Load(object sender, EventArgs e)
        {

        }
    }
}