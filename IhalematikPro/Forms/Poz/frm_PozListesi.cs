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

        public void LoadGrid()
        {
            List<Poz> pozs = new List<Poz>();

            if (cmbAktivePasive.SelectedIndex == 0)
            {
                pozs = UIPozManager.Instance.GetPozs(true);
                colPasive.Visible = true;
                colEdit.Visible = true;
                colActive.Visible = false;
            }
            else if (cmbAktivePasive.SelectedIndex == 1)
            {
                pozs = UIPozManager.Instance.GetPozs(false);
                colEdit.Visible = false;
                colPasive.Visible = false;
                colActive.Visible = true;
            }
            //if (this.FocusedRowHandle != 0)
            //{
            //    pozs = UIPozManager.Instance.GetPozs();
            //}
            grdPozList.DataSource = pozs;
            gridViewPozList.FocusedRowHandle = this.FocusedRowHandle;
            lblRecordCount.Text = pozs.Count.ToString();
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
                model.UnitPrice = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtUnitPrice.Text);

                List<Poz> existingPozs = UIPozManager.Instance.GetPoz(model.Number);
                if (existingPozs != null && existingPozs.Count != 0)
                {
                    frm_MesajFormu mf = new frm_MesajFormu();
                    mf.lblMesaj.Text = "Bu Poz numarasi ile kayit bulunmaktadir";
                    mf.ShowDialog();
                    this.txtNumber.Text="";
                }
                else
                {
                    model.Save();
                    FormClear();
                    LoadGrid();
                    frm_MesajFormu mf = new frm_MesajFormu();
                    mf.lblMesaj.Text = "Malzeme Kaydedildi...";
                    mf.ShowDialog();
                }
            }
        }
        private void FormClear()
        {
            this.txtNumber.Text="";
            this.txtDescription.Text="";
            this.txtUnit.Text="";
            this.txtUnitPrice.Text="";
            this.txtNumber.Focus();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtDescription.Text="";
            txtNumber.Text="";
            txtUnit.Text="";
            txtUnitPrice.Text="";
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
            this.LoadGrid();
        }

        private void cmbAktivePasive_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadGrid();
        }

        private void frm_PozListesi_Shown(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            LoadGrid();
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            grdPozList.Show();
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
                this.LoadGrid();
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
                this.LoadGrid();
            }
            else
            {

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string pozNo = txtSearchNumber.Text.Trim();
            string pozDesc = txtSearchDescription.Text.Trim();
            List<Poz> items = new List<Poz>();

            if (cmbAktivePasive.SelectedIndex == 0)
            {
                items = UIPozManager.Instance.GetPozs(true);
            }
            else if (cmbAktivePasive.SelectedIndex == 1)
            {
                items = UIPozManager.Instance.GetPozs(false);
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
            lblRecordCount.Text = items.Count.ToString();
        }
    }
}