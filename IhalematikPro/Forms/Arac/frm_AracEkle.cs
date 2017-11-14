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

namespace IhalematikPro.Forms
{
    public partial class frm_AracEkle : DevExpress.XtraEditors.XtraForm
    {
        frm_AracTanimlama _owner = null;

        public frm_AracEkle(frm_AracTanimlama Owner)
        {
            InitializeComponent();
            this._owner = Owner;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_AracTanimlama frm = new frm_AracTanimlama();
            frm.Refresh();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Kontrol();
            VehicleTitleModel model = new VehicleTitleModel();
            model.Name = txtName.Text;
            model.Save();
            MessageBox.Show("Araç Kaydedildi...");
            txtName.ResetText();
            txtName.Focus();
            this._owner.InitilalizeForm();
            this.Close();
        }
        void Kontrol()
        {
            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                dxErrorProvider1.SetError(txtName, "Boş bırakılamaz", DevExpress.XtraEditors.DXErrorProvider.ErrorType.User3);
                return;
            }
            else
            {
                dxErrorProvider1.ClearErrors();
            }
        }
    }
}