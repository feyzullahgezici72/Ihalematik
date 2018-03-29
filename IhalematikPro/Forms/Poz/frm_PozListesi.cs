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
using IhalematikPro.Model;
using IhalematikPro.Manager;
using IhalematikProUI.Forms;
using System.Threading;
using IhalematikProBL.Provider;
using System.Diagnostics;
using IhalematikProUI.Forms.Base;
using System.Globalization;
using IhalematikProUI.Forms.Genel;
using IhalematikProUI.Manager;

namespace IhalematikPro.Forms
{
    public partial class frm_PozListesi : IhalematikBaseForm
    {
        //frm_wait frm = new frm_wait(0);
        public int FocusedRowHandle = 0;
        public frm_PozListesi()
        {
            InitializeComponent();
            base.ScreenMethod();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_PozListesi_Load(object sender, EventArgs e)
        {
            grdPozList.Hide();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            IsEmptyKontrol();
            if (!string.IsNullOrEmpty(txtNumber.Text.Trim()))//samet ekledi
            {
                PozModel model = new PozModel();
                model.Description = txtDescription.Text;
                model.Number = txtNumber.Text;
                model.Unit = txtUnit.Text;
                model.IsActive = true;
                model.UnitPrice = double.Parse(txtUnitPrice.Text.Replace("TL", string.Empty), CultureInfo.InvariantCulture);

                List<Poz> existingPozs = UIPozManager.Instance.GetPoz(model.Number);
                if (existingPozs != null && existingPozs.Count != 0)
                {
                    frm_MesajFormu mf = new frm_MesajFormu();
                    mf.lblMesaj.Text = "Bu Poz numarasi ile kayit bulunmaktadir";
                    mf.ShowDialog();
                    this.txtNumber.Text = "";
                }
                else
                {
                    model.Save();
                    FormClear();
                    LoadPozGrid();
                    frm_MesajFormu mf = new frm_MesajFormu();
                    mf.lblMesaj.Text = "Malzeme Kaydedildi...";
                    mf.ShowDialog();
                }
            }
        }
        private void FormClear()
        {
            this.txtNumber.Text = "";
            this.txtDescription.Text = "";
            this.txtUnit.Text = "";
            this.txtUnitPrice.Text = "";
            this.txtNumber.Focus();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtDescription.Text = "";
            txtNumber.Text = "";
            txtUnit.Text = "";
            txtUnitPrice.Text = "";
            txtNumber.Focus();
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            this.FocusedRowHandle = gridViewPozList.FocusedRowHandle;
            frm_pozGuncelle frm = new frm_pozGuncelle(this);
            int id = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewPozList.GetFocusedRowCellValue("Id"));
            frm.CurrentPozId = id;
            pozMenu.Visible = false;
            grdPozList.Enabled = false;
            frm.ShowDialog();
            pozMenu.Visible = true;
            grdPozList.Enabled = true;
            this.LoadPozGrid();
        }

        private void cmbAktivePasive_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadPozGrid();
        }

        private void frm_PozListesi_Shown(object sender, EventArgs e)
        {
            this.Enabled = false;
            LoadingManager.Instance.Show(this);
            LoadPozGrid();
            grdPozList.Show();
            LoadingManager.Instance.frm_wait.Close();
            this.Enabled = true;
        }

        public bool IsEmptyKontrol()
        {
            if (string.IsNullOrEmpty(txtNumber.Text.Trim()))
            {
                dxErrorProvider1.SetError(txtNumber, "Poz no boş bırakılamaz", DevExpress.XtraEditors.DXErrorProvider.ErrorType.User3);
                return true;
            }
            if (string.IsNullOrEmpty(txtDescription.Text.Trim()))
            {
                dxErrorProvider1.SetError(txtNumber, "Açıklama boş bırakılamaz", DevExpress.XtraEditors.DXErrorProvider.ErrorType.User3);
                return true;
            }
            if (string.IsNullOrEmpty(txtUnit.Text.Trim()))
            {
                dxErrorProvider1.SetError(txtUnit, "Birim boş bırakılamaz", DevExpress.XtraEditors.DXErrorProvider.ErrorType.User3);
                return true;
            }
            if (string.IsNullOrEmpty(txtUnitPrice.Text.Trim()))
            {
                dxErrorProvider1.SetError(txtUnitPrice, "Birim fiyat boş bırakılamaz", DevExpress.XtraEditors.DXErrorProvider.ErrorType.User3);
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
            DialogResult result = MessageBox.Show("Aktif yapmak istediğinizden emin misiniz?", "Aktif Yap", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                this.FocusedRowHandle = gridViewPozList.FocusedRowHandle;
                int id = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewPozList.GetFocusedRowCellValue("Id"));
                Poz selectedVehicle = PozProvider.Instance.GetItem(id);
                selectedVehicle.IsActive = true;
                PozProvider.Instance.Save(selectedVehicle);
                this.LoadPozGrid();
            }
            else
            {

            }
        }

        private void btnPasive_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Pasif yapmak istediginzden emin misiniz?", "Pasif Yap", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                this.FocusedRowHandle = gridViewPozList.FocusedRowHandle;
                int id = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewPozList.GetFocusedRowCellValue("Id"));
                Poz selectedVehicle = PozProvider.Instance.GetItem(id);
                selectedVehicle.IsActive = false;
                PozProvider.Instance.Save(selectedVehicle);
                this.LoadPozGrid();
            }
            else
            {

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.LoadPozGrid();
            txtSearchNumber.Focus();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.LoadPozGrid();
        }

        public void LoadPozGrid()
        {

            string pozNo = txtSearchNumber.Text.Trim();
            string pozDesc = txtSearchDescription.Text.Trim();
            List<Poz> items = new List<Poz>();
            int year = DateTime.Now.Year;

            if (ddlPozYear.SelectedIndex == 0 /*2017*/)
            {
                year = 2017;
                lblPozListesi.Text = "POZ LİSTESİ" + "                               " + ddlPozYear.Text;

            }
            if (ddlPozYear.SelectedIndex == 1 /*2018*/)
            {
                year = 2018;
                lblPozListesi.Text = "POZ LİSTESİ" + "                               " + ddlPozYear.Text;

            }

            if (cmbAktivePasive.SelectedIndex == 0)
            {
                items = UIPozManager.Instance.GetPozs(true, year);
                colPasive.Visible = true;
                colEdit.Visible = true;
                colActive.Visible = false;
            }
            else if (cmbAktivePasive.SelectedIndex == 1)
            {
                items = UIPozManager.Instance.GetPozs(false, year);
                colEdit.Visible = false;
                colPasive.Visible = false;
                colActive.Visible = true;
            }

            if (!string.IsNullOrEmpty(pozNo))
            {
                items = items.Where(p => p.Number.Contains(pozNo)).ToList();
            }
            if (!string.IsNullOrEmpty(pozDesc))
            {
                items = items.Where(p => p.Description.Contains(pozDesc)).ToList();
            }

            grdPozList.DataSource = null;
            grdPozList.DataSource = items;
            gridViewPozList.FocusedRowHandle = this.FocusedRowHandle;
            lblRecordCount.Text = items.Count.ToString();
        }

        private void txtSearchNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                simpleButton1.PerformClick();
            }
        }

        private void txtSearchDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                simpleButton2.PerformClick();
            }
        }

        private void ddlPozYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadPozGrid();

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            frm_TopluPozYukle pozyukle = new frm_TopluPozYukle(this);
            pozyukle.ShowDialog(this);
        }
    }
}