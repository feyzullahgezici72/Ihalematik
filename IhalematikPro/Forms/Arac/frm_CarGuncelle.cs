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
using IhalematikPro.Forms;
using IhalematikProBL.Entity;
using IhalematikProBL.Provider;

namespace IhalematikProUI.Forms.Arac
{
    public partial class frm_CarGuncelle : DevExpress.XtraEditors.XtraForm
    {
        public frm_AracEkle _owner = null;

        public int CurrentVehicleTitleId { get; set; }
        public VehicleTitle currentVehicleTitle { get; set; }
        public VehicleTitle CurrentVehicleTitle
        {
            get
            {
                if (this.currentVehicleTitle == null)
                {
                    this.currentVehicleTitle = VehicleTitleProvider.Instance.GetItem(this.CurrentVehicleTitleId);
                }
                return this.currentVehicleTitle;
            }
        }
        public frm_CarGuncelle(frm_AracEkle Owner)
        {
            this._owner = Owner;
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtVehicleTitleName.Text))
            {
                this.CurrentVehicleTitle.Name = txtVehicleTitleName.Text;
                VehicleTitleProvider.Instance.Save(this.CurrentVehicleTitle);
                this._owner.LoadGrid();
                this.Close();
            }
        }

        private void frm_CarGuncelle_Shown(object sender, EventArgs e)
        {
            txtVehicleTitleName.Text = this.CurrentVehicleTitle.Name;
            txtVehicleTitleName.Focus();
        }
    }
}