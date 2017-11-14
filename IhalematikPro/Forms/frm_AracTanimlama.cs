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
using IhalematikProBL.Provider;
using IhalematikProBL.Entity;

namespace IhalematikPro.Forms
{
    public partial class frm_AracTanimlama : DevExpress.XtraEditors.XtraForm
    {
        public int FocusedRowHandle = 0;
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
            ddlVehicleTitle.Properties.Items.Clear();
            List<VehicleTitleModel> models = UIVehicleTitleManager.Instance.GetVehicleTitles();
            ddlVehicleTitle.Properties.Items.AddRange(models);
            //ddlVehicleTitle.SelectedIndex = 0;
        }

        public void LoadGrid()
        {
            List<VehicleModel> models = UIVehicleManager.Instance.GetVehicles();

            if (cmbAktivePasive.SelectedIndex == 0)
            {
                grdVehicle.DataSource = models.Where(p => p.IsActive);
                colEdit.Visible = true;
            }
            else if (cmbAktivePasive.SelectedIndex == 1)
            {
                grdVehicle.DataSource = models.Where(p => !p.IsActive);
                //gridViewVehicle.Columns[colEdit.].Visible = false;
                colEdit.Visible = false;
            }

            if (this.FocusedRowHandle != 0)
            {
                gridViewVehicle.FocusedRowHandle = this.FocusedRowHandle;
            }
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
                frm_AracEkle frm = new frm_AracEkle(this);
                frm.ShowDialog();
            }

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            VehicleModel model = new VehicleModel();
            model.TitleId = ((VehicleTitleModel)ddlVehicleTitle.SelectedItem).Id.Value;
            model.IsActive = true;
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
                model.GeneralFare = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtRentGeneralFare.Text);
                model.OtherFare = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtRentOtherFare.Text);
            }

            model.Save();
            LoadGrid();
            frm_MesajFormu mf = new frm_MesajFormu();
            mf.lblMesaj.Text = "Kayıt Yapıldı...";
            mf.ShowDialog();
        }

        private void yeniAraçEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_AracEkle frm = new frm_AracEkle(this);
            frm.ShowDialog();
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
            PanelKira.Location = PanelSirket.Location;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frm_AracEkle frm = new frm_AracEkle(this);
            frm.ShowDialog();
        }

        private void btnGuncelle_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frm_Arac_Guncelleme frm = new frm_Arac_Guncelleme(this);

            int id = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewVehicle.GetFocusedRowCellValue("Id"));

            this.FocusedRowHandle = gridViewVehicle.FocusedRowHandle;

            frm.CurrentVehicleId = id;
            KayitMenusu.Visible = false;
            this.Opacity = 10;
            this.Enabled = false;
            frm.ShowDialog();
            this.Enabled = true;
            this.Opacity = 100;
            KayitMenusu.Visible = true;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Silmek Istediginzden emin misiniz?", "Sil", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                this.FocusedRowHandle = gridViewVehicle.FocusedRowHandle;
                int id = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewVehicle.GetFocusedRowCellValue("Id"));
                Vehicle selectedVehicle = VehicleProvider.Instance.GetItem(id);
                selectedVehicle.IsActive = false;
                VehicleProvider.Instance.Save(selectedVehicle);
                this.LoadGrid();
            }
            else
            {

            }
        }

        private void cmbAktivePasive_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadGrid();
        }

        private void ddlVehicleTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlVehicleTitle.SelectedItem == null)
            {
                return;
            }
            VehicleTitleModel selectedItem = (VehicleTitleModel)ddlVehicleTitle.SelectedItem;
            List<Vehicle> vehicles = VehicleProvider.Instance.GetItems("TitleId", selectedItem.Id);
            if (vehicles.Count != 0)
            {
                MessageBox.Show("Bu unvanda tanimli arac vardir");
                ddlVehicleTitle.SelectedItem = null;
            }
        }
    }
}