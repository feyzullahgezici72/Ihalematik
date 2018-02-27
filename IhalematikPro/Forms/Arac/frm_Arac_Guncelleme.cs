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
using System.Threading;

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
            PanelSirket.Location = new Point(13, 111);
        }

        private void rbAsgariUcret_CheckedChanged(object sender, EventArgs e)
        {
            PanelKira.Visible = true;
            PanelSirket.Visible = false;
            PanelKira.Location = new Point(13, 111);
        }

        private void frm_Arac_Guncelleme_Load(object sender, EventArgs e)
        {
            List<VehicleTitle> models = UIVehicleTitleManager.Instance.GetVehicleTitles();
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
                    txtCompanyFuelOilFare.Text = model.FuelOilFare.ToString("c2");
                    txtCompanyFuelOilDay.Text = model.FuelOilDay.ToString("c2");
                    txtCompanyDriverFare.Text = model.DriverFare.ToString("c2");
                    txtCompanyMaintenanceFare.Text = model.MaintenanceFare.ToString("c2");
                    txtCompanyServiceFare.Text = model.ServiceFare.ToString("c2");
                    txtCompanyGeneralFare.Text = model.GeneralFare.ToString("c2");
                    txtCompanyOtherFare.Text = model.OtherFare.ToString("c2");
                }
                else
                {
                    rbRentVehicle.Checked = true;
                    txtRentFare.Text = model.RentFare.ToString("c2");
                    txtRentFuelOilFare.Text = model.FuelOilFare.ToString("c2");
                    txtRentFuelOilDay.Text = model.FuelOilDay.ToString("c2");
                    txtRentDriverFare.Text = model.DriverFare.ToString("c2");
                    txtRentGeneralFare.Text = model.GeneralFare.ToString("c2");
                    txtRentOtherFare.Text = model.OtherFare.ToString("c2");
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
            IsEmptyKontrol();
            VehicleModel model = new VehicleModel(CurrentVehicle);
            model.TitleId = ((VehicleTitle)ddlVehicleTitle.SelectedItem).Id;
            if (rbCompanyVehicle.Checked)
            {
                model.IsCompanyVehicle = true;
                if (!string.IsNullOrEmpty(txtCompanyFuelOilFare.Text))
                {
                    model.FuelOilFare = double.Parse(txtCompanyFuelOilFare.Text.Replace("TL", string.Empty));
                }
                if (!string.IsNullOrEmpty(txtCompanyFuelOilDay.Text))
                {
                    model.FuelOilDay = float.Parse(txtCompanyFuelOilDay.Text.Replace("TL", string.Empty));
                }
                if (!string.IsNullOrEmpty(txtCompanyDriverFare.Text))
                {
                    model.DriverFare = double.Parse(txtCompanyDriverFare.Text.Replace("TL", string.Empty));
                }
                if (!string.IsNullOrEmpty(txtCompanyMaintenanceFare.Text))
                {
                    model.MaintenanceFare = double.Parse(txtCompanyMaintenanceFare.Text.Replace("TL", string.Empty));
                }
                if (!string.IsNullOrEmpty(txtCompanyServiceFare.Text))
                {
                    model.ServiceFare = double.Parse(txtCompanyServiceFare.Text.Replace("TL", string.Empty));
                }
                if (!string.IsNullOrEmpty(txtCompanyGeneralFare.Text))
                {
                    model.GeneralFare = double.Parse(txtCompanyGeneralFare.Text.Replace("TL", string.Empty));
                }
                if (!string.IsNullOrEmpty(txtCompanyOtherFare.Text))
                {
                    model.OtherFare = double.Parse(txtCompanyOtherFare.Text.Replace("TL", string.Empty));
                }
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
                if (!string.IsNullOrEmpty(txtRentFuelOilFare.Text))
                {
                    model.FuelOilFare = double.Parse(txtRentFuelOilFare.Text.Replace("TL", string.Empty));
                }

                if (!string.IsNullOrEmpty(txtRentFuelOilDay.Text))
                {
                    model.FuelOilDay = float.Parse(txtRentFuelOilDay.Text.Replace("TL", string.Empty));
                }
                if (!string.IsNullOrEmpty(txtRentDriverFare.Text))
                {
                    model.DriverFare = double.Parse(txtRentDriverFare.Text.Replace("TL", string.Empty));
                }
                if (!string.IsNullOrEmpty(txtRentFare.Text))
                {
                    model.RentFare = double.Parse(txtRentFare.Text.Replace("TL", string.Empty));
                }
                if (!string.IsNullOrEmpty(txtRentGeneralFare.Text))
                {
                    model.GeneralFare = double.Parse(txtRentGeneralFare.Text.Replace("TL", string.Empty));
                }
                if (!string.IsNullOrEmpty(txtRentOtherFare.Text))
                {
                    model.OtherFare = double.Parse(txtRentOtherFare.Text.Replace("TL", string.Empty));
                }
            }

            model.Save();
            this._owner.LoadGrid();
            frm_MesajFormu mf = new frm_MesajFormu();
            mf.lblMesaj.Text = "Güncelleme Yapıldı...";
            mf.ShowDialog();
            this.Close();
        }

        public bool IsEmptyKontrol()
        {
            if (ddlVehicleTitle.SelectedIndex < 0)
            {
                dxErrorProvider1.SetError(ddlVehicleTitle, "Araç tipi seçilmelidir", DevExpress.XtraEditors.DXErrorProvider.ErrorType.User3);
                return true;
            }
            else
            {
                dxErrorProvider1.ClearErrors();
            }
            return false;
        }
    }
}