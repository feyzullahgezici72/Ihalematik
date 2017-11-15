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
            List<Poz> pozs = PozProvider.Instance.GetItems();
            grdPozList.DataSource = pozs;


            if (cmbAktivePasive.SelectedIndex == 0)
            {
                grdPozList.DataSource = pozs.Where(p => p.IsActive);
                colEdit.Visible = true;
            }
            else if (cmbAktivePasive.SelectedIndex == 1)
            {
                grdPozList.DataSource = pozs.Where(p => !p.IsActive);
                colEdit.Visible = false;
            }
            if (this.FocusedRowHandle != 0)
            {
                gridViewPozList.FocusedRowHandle = this.FocusedRowHandle;
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
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
                this.txtNumber.ResetText();
            }
            else
            {
                model.Save();
                FormClear();
                LoadGrid();
                frm_MesajFormu mf = new frm_MesajFormu();
                mf.lblMesaj.Text = "Kayıt Yapıldı...";
                mf.ShowDialog();
            }
        }
        private void FormClear()
        {
            this.txtNumber.ResetText();
            this.txtDescription.ResetText();
            this.txtUnit.ResetText();
            this.txtUnitPrice.ResetText();
            this.txtNumber.Focus();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtDescription.ResetText();
            txtNumber.ResetText();
            txtUnit.ResetText();
            txtUnitPrice.ResetText();
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

        private void btnSl_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Silmek Istediginzden emin misiniz?", "Sil", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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

        private void frm_PozListesi_Shown(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            LoadGrid();
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            grdPozList.Show();
        }
    }
}