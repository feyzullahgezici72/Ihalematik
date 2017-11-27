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
using IhalematikProUI.Forms.Base;
using IhalematikProBL.Manager;

namespace IhalematikPro.Forms
{
    public partial class frm_AracTanimlama : IhalematikBaseForm
    {
        public int FocusedRowHandle = 0;
        public int SelectedTitleId = 0;
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
            //ddlVehicleTitle.SelectedIndex = 0;
        }

        public void LoadGrid()
        {
            //grdVehicle.Hide();
            LoadVehicleGrid();
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
            IsEmptyKontrol();
            VehicleModel model = new VehicleModel();
            model.TitleId = ((VehicleTitle)ddlVehicleTitle.SelectedItem).Id;
            model.IsActive = true;
            if (rbCompanyVehicle.Checked)
            {
                model.IsCompanyVehicle = true;
                model.FuelOilFare = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtFuelOilFare.Text.Replace("TL", string.Empty));
                model.FuelOilDay = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<float>(txtFuelOilDay.Text.Replace("TL", string.Empty));
                model.DriverFare = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtDriverFare.Text.Replace("TL", string.Empty));
                model.MaintenanceFare = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtMaintenanceFare.Text.Replace("TL", string.Empty));
                model.ServiceFare = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtServiceFare.Text.Replace("TL", string.Empty));
                model.GeneralFare = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtGeneralFare.Text.Replace("TL", string.Empty));
                model.OtherFare = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtOtherFare.Text.Replace("TL", string.Empty));
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
                model.FuelOilFare = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtRentFuelOilFare.Text.Replace("TL", string.Empty));
                model.FuelOilDay = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<float>(txtRentFuelOilDay.Text.Replace("TL", string.Empty));
                model.DriverFare = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtRentDriverFare.Text.Replace("TL", string.Empty));
                model.RentFare = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtRentFare.Text.Replace("TL", string.Empty));
                model.GeneralFare = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtRentGeneralFare.Text.Replace("TL", string.Empty));
                model.OtherFare = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtRentOtherFare.Text.Replace("TL", string.Empty));
            }

            model.Save();
            LoadGrid();
            frm_MesajFormu mf = new frm_MesajFormu();
            mf.lblMesaj.Text = "Araç kaydedildi...";
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
            DialogResult result = MessageBox.Show("Pasif yapmak istediğinz emin misiniz?", "Pasif", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.Yes))
            {
                this.FocusedRowHandle = gridViewVehicle.FocusedRowHandle;
                int id = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewVehicle.GetFocusedRowCellValue("Id"));
                Vehicle selectedVehicle = VehicleProvider.Instance.GetItem(id);
                selectedVehicle.IsActive = false;
                VehicleProvider.Instance.Save(selectedVehicle);
                this.LoadVehicleGrid();
            }
            else
            {

            }
        }

        private void cmbAktivePasive_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadVehicleGrid();
        }

        private void ddlVehicleTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlVehicleTitle.SelectedItem == null)
            {
                return;
            }
            VehicleTitle selectedItem = (VehicleTitle)ddlVehicleTitle.SelectedItem;
            List<Vehicle> vehicles = VehicleProvider.Instance.GetItems("TitleId", selectedItem.Id);
            if (vehicles.Count != 0)
            {
                MessageBox.Show("Bu tipte tanimli arac vardir");
                ddlVehicleTitle.SelectedItem = null;
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            ddlVehicleTitle.SelectedIndex = -1;
            rbAsgariUcret.Checked = false;
            rbCompanyVehicle.Checked = false;
            rdDay.Checked = false;
            rdHour.Checked = false;
            rdMonth.Checked = false;
            txtDriverFare.ResetText();
            txtFuelOilDay.ResetText();
            txtFuelOilFare.ResetText();
            txtGeneralFare.ResetText();
            txtMaintenanceFare.ResetText();
            txtOtherFare.ResetText();
            txtRentDriverFare.ResetText();
            txtRentFare.ResetText();
            txtRentFuelOilDay.ResetText();
            txtRentFuelOilFare.ResetText();
            txtRentGeneralFare.ResetText();
            txtRentOtherFare.ResetText();
            txtServiceFare.ResetText();
        }

        private void frm_AracTanimlama_Shown(object sender, EventArgs e)
        {
            LoadVehicleGrid();
            ddlVehicleTitle.Properties.Items.Clear();
            List<VehicleTitle> modelVehicleTitles = UIVehicleTitleManager.Instance.GetVehicleTitles();
            ddlVehicleTitle.Properties.Items.AddRange(modelVehicleTitles);
            if (this.SelectedTitleId != 0)
            {
                VehicleTitle selectedTite = modelVehicleTitles.Where(p => p.Id == this.SelectedTitleId).FirstOrDefault();
                int selectedIndex = modelVehicleTitles.IndexOf(selectedTite);
                ddlVehicleTitle.SelectedIndex = selectedIndex;
            }
            grdVehicle.Show();
        }

        private void LoadVehicleGrid()
        {
            List<Vehicle> models = UIVehicleManager.Instance.GetVehicles();

            if (cmbAktivePasive.SelectedIndex == 0)
            {
                grdVehicle.DataSource = models.Where(p => p.IsActive);
                colPasive.Visible = true;
                colEdit.Visible = true;
                colActive.Visible = false;
            }
            else if (cmbAktivePasive.SelectedIndex == 1)
            {
                grdVehicle.DataSource = models.Where(p => !p.IsActive);
                colEdit.Visible = false;
                colActive.Visible = true;
                colPasive.Visible = false;
            }

            //if (this.FocusedRowHandle != 0)
            //{
            //    gridViewVehicle.FocusedRowHandle = this.FocusedRowHandle;
            //    colActive.Visible =false;
            //    colPasive.Visible = false;
            //}
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

        private void btnActive_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Aktif yapmak istediğinz emin misiniz?", "Aktif", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.Yes))
            {
                this.FocusedRowHandle = gridViewVehicle.FocusedRowHandle;
                int id = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewVehicle.GetFocusedRowCellValue("Id"));
                Vehicle selectedVehicle = VehicleProvider.Instance.GetItem(id);
                selectedVehicle.IsActive = true;
                VehicleProvider.Instance.Save(selectedVehicle);
                this.LoadVehicleGrid();
            }
            else
            {

            }
        }
    }
}