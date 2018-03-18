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
            if (!string.IsNullOrEmpty(ddlVehicleTitle.Text.Trim()))//samet ekledi
            {

                VehicleModel model = new VehicleModel();
                model.TitleId = ((VehicleTitle)ddlVehicleTitle.SelectedItem).Id;
                model.IsActive = true;
                if (rbCompanyVehicle.Checked)
                {
                    model.IsCompanyVehicle = true;
                    if (txtFuelOilFare.Text != "")
                    {
                        model.FuelOilFare = double.Parse(txtFuelOilFare.Text.Replace("TL", string.Empty));
                    }
                    else
                    {
                        model.FuelOilFare = 0;
                    }
                    if (txtFuelOilDay.Text != "")
                    {
                        model.FuelOilDay = float.Parse(txtFuelOilDay.Text.Replace("TL", string.Empty));
                    }
                    else
                    {
                        model.FuelOilDay = 0;
                    }
                    if (txtDriverFare.Text != "")
                    {
                        model.DriverFare = double.Parse(txtDriverFare.Text.Replace("TL", string.Empty));
                    }
                    else
                    {
                        model.DriverFare = 0;
                    }

                    if (txtMaintenanceFare.Text != "")
                    {
                        model.MaintenanceFare = double.Parse(txtMaintenanceFare.Text.Replace("TL", string.Empty));
                    }
                    else
                    {
                        model.MaintenanceFare = 0;
                    }
                    if (txtServiceFare.Text != "")
                    {
                        model.ServiceFare = double.Parse(txtServiceFare.Text.Replace("TL", string.Empty));
                    }
                    else
                    {
                        model.ServiceFare = 0;
                    }
                    if (txtGeneralFare.Text != "")
                    {
                        model.GeneralFare = double.Parse(txtGeneralFare.Text.Replace("TL", string.Empty));
                    }
                    else
                    {
                        model.GeneralFare = 0;
                    }
                    if (txtOtherFare.Text != "")
                    {
                        model.OtherFare = double.Parse(txtOtherFare.Text.Replace("TL", string.Empty));
                    }
                    else
                    {
                        model.OtherFare = 0;
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
                    if (txtRentFuelOilFare.Text != "")
                    {
                        model.FuelOilFare = double.Parse(txtRentFuelOilFare.Text.Replace("TL", string.Empty));
                    }
                    else
                    {
                        model.FuelOilFare = 0;
                    }
                    if (txtRentFuelOilDay.Text != "")
                    {
                        model.FuelOilDay = float.Parse(txtRentFuelOilDay.Text.Replace("TL", string.Empty));
                    }
                    else
                    {
                        model.FuelOilDay = 0;
                    }
                    if (txtRentDriverFare.Text != "")
                    {
                        model.DriverFare = double.Parse(txtRentDriverFare.Text.Replace("TL", string.Empty));
                    }
                    else
                    {
                        model.DriverFare = 0;
                    }
                    if (txtRentFare.Text != "")
                    {
                        model.RentFare = double.Parse(txtRentFare.Text.Replace("TL", string.Empty));
                    }
                    else
                    {
                        model.RentFare = 0;
                    }
                    if (txtRentGeneralFare.Text != "")
                    {
                        model.GeneralFare = double.Parse(txtRentGeneralFare.Text.Replace("TL", string.Empty));
                    }
                    else
                    {
                        model.GeneralFare = 0;
                    }
                    if (txtRentOtherFare.Text != "")
                    {
                        model.OtherFare = double.Parse(txtRentOtherFare.Text.Replace("TL", string.Empty));
                    }
                    else
                    {
                        model.OtherFare = 0;
                    }
                }

                model.Save();
                LoadGrid();
                btnTemizle.PerformClick();
                frm_MesajFormu mf = new frm_MesajFormu();
                mf.lblMesaj.Text = "Araç kaydedildi...";
                mf.ShowDialog();
            }
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
            txtFuelOilDay.Focus();
        }

        private void rbAsgariUcret_CheckedChanged(object sender, EventArgs e)
        {
            PanelKira.Visible = true;
            PanelSirket.Visible = false;
            PanelKira.Location = PanelSirket.Location;
            txtRentFare.Focus();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (rbCompanyVehicle.Checked == true)
            {
                txtFuelOilDay.Focus();
            }
            if (rbAsgariUcret.Checked == true)
            {
                txtRentFare.Focus();
            }
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
            DialogResult result = MessageBox.Show("Pasif yapmak istediğinizden emin misiniz?", "Pasif", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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
            Vehicle vehicle = VehicleProvider.Instance.GetItems("TitleId", selectedItem.Id).FirstOrDefault();
            if (vehicle != null)
            {
                if (!vehicle.IsActive)
                {
                    DialogResult result = MessageBox.Show("Tanımlamaya çalıştığınız ünvan pasif'e ayırmışsınız. Aktifleştirmek istermisiniz?", "Pasif", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result.Equals(DialogResult.OK))
                    {
                        vehicle.IsActive = true;
                        VehicleProvider.Instance.Save(vehicle);
                        this.LoadGrid();
                    }
                    ddlVehicleTitle.SelectedItem = null;
                }
                else
                {
                    MessageBox.Show("Bu tipte tanimli arac vardir");
                }
                ddlVehicleTitle.SelectedItem = null;
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            ddlVehicleTitle.SelectedIndex = -1;
            rbAsgariUcret.Checked = false;
            rbCompanyVehicle.Checked = true;
            rdDay.Checked = true;
            rdHour.Checked = false;
            rdMonth.Checked = false;
            txtDriverFare.Text = "";
            txtFuelOilDay.Text = "";
            txtFuelOilFare.Text = "";
            txtGeneralFare.Text = "";
            txtMaintenanceFare.Text = "";
            txtOtherFare.Text = "";
            txtRentDriverFare.Text = "";
            txtRentFare.Text = "";
            txtRentFuelOilDay.Text = "";
            txtRentFuelOilFare.Text = "";
            txtRentGeneralFare.Text = "";
            txtRentOtherFare.Text = "";
            txtServiceFare.Text = "";

        }

        private void frm_AracTanimlama_Shown(object sender, EventArgs e)
        {
            this.LoadVehicleGrid();
            this.LoadVehicleTitle();
            grdVehicle.Show();
        }

        protected internal void LoadVehicleTitle()
        {
            ddlVehicleTitle.Properties.Items.Clear();
            List<VehicleTitle> modelVehicleTitles = UIVehicleTitleManager.Instance.GetVehicleTitles();
            ddlVehicleTitle.Properties.Items.AddRange(modelVehicleTitles);
            if (this.SelectedTitleId != 0)
            {
                VehicleTitle selectedTite = modelVehicleTitles.Where(p => p.Id == this.SelectedTitleId).FirstOrDefault();
                int selectedIndex = modelVehicleTitles.IndexOf(selectedTite);
                ddlVehicleTitle.SelectedIndex = selectedIndex;
            }
        }

        private void LoadVehicleGrid()
        {
            List<Vehicle> items = UIVehicleManager.Instance.GetVehicles();
            List<VehicleModel> models = IhalematikModelBase.GetModels<VehicleModel, Vehicle>(items);
            if (!string.IsNullOrEmpty(txtVehicleTitle.Text.Trim()))
            {
                models = models.Where(p => p.Title.Name.Contains(txtVehicleTitle.Text.Trim())).ToList();
            }
            if (cmbAktivePasive.SelectedIndex == 0)
            {
                models = models.Where(p => p.IsActive).ToList();
                grdVehicle.DataSource = models;
                colPasive.Visible = true;
                colEdit.Visible = true;
                colActive.Visible = false;
            }
            else if (cmbAktivePasive.SelectedIndex == 1)
            {
                models = models.Where(p => !p.IsActive).ToList();
                grdVehicle.DataSource = models;
                colEdit.Visible = false;
                colActive.Visible = true;
                colPasive.Visible = false;
            }

            lblRecordCount.Text = models.Count.ToString();
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

        private void txtOtherFare_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnKaydet.PerformClick();
            }
        }

        private void txtRentOtherFare_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnKaydet.PerformClick();
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.LoadVehicleGrid();
            txtVehicleTitle.Focus();
        }

        private void txtVehicleTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                simpleButton3.PerformClick();
            }
        }
    }
}