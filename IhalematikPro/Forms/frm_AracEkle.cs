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
        public frm_AracEkle()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_AracTanimlama frm = new frm_AracTanimlama();
            frm.Refresh();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            VehicleTitleModel model = new VehicleTitleModel();
            model.Name = txtName.Text;
            model.Save();
            MessageBox.Show("Araç Kaydedildi...");
            txtName.ResetText();
            txtName.Focus();

        }
    }
}