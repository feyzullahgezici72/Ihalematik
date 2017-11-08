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
    public partial class frm_OzelStokListesi : DevExpress.XtraEditors.XtraForm
    {
        public frm_OzelStokListesi()
        {
            InitializeComponent();
            LoadGrid();
        }
        public void bekleyiniz()
        {
            Thread.Sleep(1000);
        }
        public void MesajVer()
        {
            using (frm_wait frm = new frm_wait(bekleyiniz))
            {
                frm.ShowDialog();
            }
        }
        private void LoadGrid()
        {
            List<OBFModel> items = UIOBFManager.Instance.GetOBFs();
            grdOBFList.DataSource = items;
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            OBFModel model = new OBFModel();
            model.Description = txtDescription.Text;
            model.Number = txtNumber.Text;
            model.Unit = txtUnit.Text;
            model.UnitPrice = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtUnitPrice.Text);
            model.Save();
            FormClear();
            LoadGrid();
        }
        private void FormClear()
        {
            this.txtNumber.ResetText();
            this.txtDescription.ResetText();
            this.txtUnit.ResetText();
            this.txtUnitPrice.ResetText();
            this.txtNumber.Focus();
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmOzelStokListesi_Load(object sender, EventArgs e)
        {
            MesajVer();
            LoadGrid();
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            FormClear();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void groupControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
          MesajVer();
          LoadGrid();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtDescription.ResetText();
            txtNumber.ResetText();
            txtUnit.ResetText();
            txtUnitPrice.ResetText();
            txtNumber.Focus();
        }

        private void btnGncelle_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            pnlObfKayit.Visible = false;
            grdOBFList.Enabled = false;
            frm_obfGuncelle obfg = new frm_obfGuncelle();
            obfg.ShowDialog();
            pnlObfKayit.Visible = true;
            grdOBFList.Enabled = true;
        }
    }
}