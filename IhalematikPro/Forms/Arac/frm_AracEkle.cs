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
using IhalematikProBL.Provider;
using IhalematikPro.Model;
using IhalematikProUI.Forms.Base;
using IhalematikProUI.Forms;
using System.Threading;
using IhalematikProUI.Forms.Arac;

namespace IhalematikPro.Forms
{
    public partial class frm_AracEkle : IhalematikBaseForm
    {
        frm_AracTanimlama _owner = null;
        public int FocusedRowHandle = 0;
        public frm_AracEkle(frm_AracTanimlama Owner)
        {
            InitializeComponent();
            this._owner = Owner;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_AracTanimlama frm = new frm_AracTanimlama();
            this._owner.LoadGrid();
            this._owner.LoadVehicleTitle();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            IsEmptyKontrol();
            bool IsEmpty = IsEmptyKontrol();
            if (!IsEmpty)
            {
                VehicleTitle model = new VehicleTitle();
                model.Name = txtName.Text;
                VehicleTitle existingItem = VehicleTitleProvider.Instance.GetItems("Name", model.Name.Trim()).FirstOrDefault();
                //Vehicle vehicle = VehicleProvider.Instance.GetItems("TitleId", existingItem.Id).FirstOrDefault();
                if (existingItem == null)
                {
                    VehicleTitleProvider.Instance.Save(model);
                    this._owner.SelectedTitleId = model.Id;
                    this.LoadGrid();
                    frm_MesajFormu mf = new frm_MesajFormu();
                    mf.lblMesaj.Text = "Arac Kaydedildi...";
                    mf.ShowDialog();

                    //this._owner.LoadVehicleTitle();
                    //this.Close();
                    txtName.Text = "";
                    txtName.Focus();
                }
                else
                {
                    //if (existingItem.)
                    //{

                    //}
                    MessageBox.Show("Bu arac zaten mevcut");
                    txtName.Text="";
                    txtName.Focus();
                }
                //model.Save();

            }
        }
        public bool IsEmptyKontrol()
        {
            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                dxErrorProvider1.SetError(txtName, "Araç tipi boş bırakılamaz", DevExpress.XtraEditors.DXErrorProvider.ErrorType.User3);
                return true;
            }
            else
            {
                dxErrorProvider1.ClearErrors();
            }
            return false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void btnGuncelle_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int id = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewVehicleTitle.GetFocusedRowCellValue("Id"));
            frm_CarGuncelle wg = new frm_CarGuncelle(this);
            this.FocusedRowHandle = gridViewVehicleTitle.FocusedRowHandle;
            wg.CurrentVehicleTitleId = id;
            wg.ShowDialog();
            //this.Show();
        }

        private void frm_AracEkle_Shown(object sender, EventArgs e)
        {
            this.LoadGrid();
            txtName.Focus();
        }

        public void LoadGrid()
        {
            List<VehicleTitle> vehicleTitles = VehicleTitleProvider.Instance.GetItems();
            grdVehicleTitle.DataSource = vehicleTitles;
        }
    }
}