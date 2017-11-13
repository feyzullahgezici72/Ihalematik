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
using IhalematikProBL.Provider;
using IhalematikProBL.Entity;
using IhalematikPro.Forms;
using IhalematikPro.Model;
using IhalematikPro.Manager;

namespace IhalematikProUI.Forms
{
    public partial class frm_Arac_Guncelleme : DevExpress.XtraEditors.XtraForm
    {
        frm_AracTanimlama _owner = null;
        public int CurrentVehicleId { get; set; }
        public Vehicle currentVehicle { get; set; }
        public Vehicle CurrentVehicle
        {
            get
            {
                if (this.currentVehicle == null)
                {
                    this.currentVehicle = VehicleProvider.Instance.GetItem(this.CurrentVehicleId);
                }
                return this.currentVehicle;
            }
        }
        public frm_Arac_Guncelleme(frm_AracTanimlama Owner)
        {
            InitializeComponent();
            this._owner = Owner;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbCompanyVehicle_CheckedChanged(object sender, EventArgs e)
        {
            PanelSirket.Visible = true;
            PanelKira.Visible = false;
            PanelSirket.Location = new Point(13, 72);
        }

        private void rbAsgariUcret_CheckedChanged(object sender, EventArgs e)
        {
            PanelKira.Visible = true;
            PanelSirket.Visible = false;
            PanelKira.Location = new Point(13, 72);
        }

        private void frm_Arac_Guncelleme_Load(object sender, EventArgs e)
        {
            List<VehicleTitleModel> models = UIVehicleTitleManager.Instance.GetVehicleTitles();
            ddlVehicleTitle.Properties.Items.AddRange(models);
            ddlVehicleTitle.ReadOnly = true;
            if (CurrentVehicle != null)
            {
                VehicleModel model = new VehicleModel(currentVehicle);
                int index = models.FindIndex(p => p.Id == CurrentVehicle.Title.Id);
                ddlVehicleTitle.SelectedIndex = index;//selectedTitle;

                if (model.IsCompanyVehicle)
                {
                    rbCompanyVehicle.Checked = true;
                    txtCompanyFuelOilFare.Text = model.FuelOilFare.ToString();// = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>();
                    txtCompanyFuelOilDay.Text = model.FuelOilDay.ToString(); //= SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<float>();
                    txtCompanyDriverFare.Text = model.DriverFare.ToString(); //SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>();
                    txtCompanyMaintenanceFare.Text = model.MaintenanceFare.ToString(); //= SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>();
                    txtCompanyServiceFare.Text = model.ServiceFare.ToString();// = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>();
                    txtCompanyGeneralFare.Text = model.GeneralFare.ToString(); //= SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>();
                    txtCompanyOtherFare.Text = model.OtherFare.ToString(); //= SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>();
                }
                else
                {
                    rbRentVehicle.Checked = true;
                    txtRentFare.Text = model.RentFare.ToString();
                    txtRentFuelOilFare.Text = model.FuelOilFare.ToString();// = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>();
                    txtRentFuelOilDay.Text = model.FuelOilDay.ToString(); //= SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<float>();
                    txtRentDriverFare.Text = model.DriverFare.ToString(); //SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>();
                    //txtCompanyMaintenanceFare.Text = model.MaintenanceFare.ToString(); //= SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>();
                    //txtCompanyServiceFare.Text = model.ServiceFare.ToString();// = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>();
                    txtRentGeneralFare.Text = model.GeneralFare.ToString(); //= SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>();
                    txtRentOtherFare.Text = model.OtherFare.ToString(); //= SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>();
                    if (CurrentVehicle.RentType == IhalematikProBL.Enum.RentTypesEnum.Day)
                    {
                        rdDay.Checked = true;
                    }
                    else if (CurrentVehicle.RentType == IhalematikProBL.Enum.RentTypesEnum.Hour)
                    {
                        rdHour.Checked = true;
                    }
                    else
                    {
                        rdMonth.Checked = true;
                    }
                }
                //model.Save();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            VehicleModel model = new VehicleModel(CurrentVehicle);
            model.TitleId = ((VehicleTitleModel)ddlVehicleTitle.SelectedItem).Id.Value;
            if (rbCompanyVehicle.Checked)
            {
                model.IsCompanyVehicle = true;
                model.FuelOilFare = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtCompanyFuelOilFare.Text);
                model.FuelOilDay = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<float>(txtCompanyFuelOilDay.Text);
                model.DriverFare = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtCompanyDriverFare.Text);
                model.MaintenanceFare = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtCompanyMaintenanceFare.Text);
                model.ServiceFare = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtCompanyServiceFare.Text);
                model.GeneralFare = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtCompanyGeneralFare.Text);
                model.OtherFare = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtCompanyOtherFare.Text);
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
            
           model.Save();
           this._owner.LoadGrid();
            frm_MesajFormu mf = new frm_MesajFormu();
            mf.lblMesaj.Text = "Güncelleme Yapıldı...";
            mf.ShowDialog();
        }
    }
}