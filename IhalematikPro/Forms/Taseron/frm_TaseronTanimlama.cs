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
using SimpleApplicationBase.BL.Base;
using IhalematikProBL.Provider;

namespace IhalematikProUI.Forms.Taseron
{
    public partial class frm_TaseronTanimlama : DevExpress.XtraEditors.XtraForm
    {
        public int FocusedRowHandle = 0;
        public frm_TaseronTanimlama()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // IsEmptyKontrol();//samet ekledi

            Jobber jobber = new Jobber();
            jobber.Address = txtAddress.Text.Trim();
            jobber.AuthorNameSurname = txtAuthorNameSurname.Text.Trim();
            jobber.CompanyName = txtCompanyName.Text.Trim();
            jobber.Email = txtEmail.Text.Trim();
            jobber.GSM = txtGSM.Text.Trim();
            jobber.IsActive = true;
            jobber.Score = txtScore.Text.Trim();
            jobber.Telephone = txtTelephone.Text.Trim();
            jobber.City = txtCountry.Text.Trim();
            jobber.TaxNumber = txtTaxNumber.Text.Trim();
            jobber.TaxOffice = txtTaxOffice.Text.Trim();

            OperationResult result = JobberProvider.Instance.Save(jobber);
            if (result.Success)
            {
                btnTemizle.PerformClick();
                this.LoadGrid();
                frm_MesajFormu mf = new frm_MesajFormu();
                mf.lblMesaj.Text = "Tedarikçi Kaydedildi...";
                mf.ShowDialog();

            }
            else
            {
                frm_MesajFormu mf = new frm_MesajFormu();
                mf.lblMesaj.Text = "Kayıt Sırasında Bir Hata Oluştu...";
                mf.ShowDialog();
            }

        }

        public void LoadGrid()
        {
            List<Jobber> jobber = JobberProvider.Instance.GetItems();
            
            if (!string.IsNullOrEmpty(txtSearchCompanyName.Text.Trim()))
            {
                jobber = jobber.Where(p => p.CompanyName.Contains(txtSearchCompanyName.Text.Trim())).ToList();
            }
            
            if (jobber != null && jobber.Count > 0)
            {
                foreach (var item in jobber)
                {
                    if (string.IsNullOrEmpty(item.Score))
                    {
                        item.Score = "0";
                    }
                }
                jobber = jobber.OrderByDescending(p => double.Parse(p.Score)).ToList();
            }
            if (cmbAktivePasive.SelectedIndex == 0)
            {
                jobber = jobber.Where(p => p.IsActive).ToList();
                grdJobber.DataSource = jobber;
                colPasive.Visible = true;
                colEdit.Visible = true;
                colActive.Visible = false;
            }
            else if (cmbAktivePasive.SelectedIndex == 1)
            {
                jobber = jobber.Where(p => !p.IsActive).ToList();
                grdJobber.DataSource = jobber;
                colEdit.Visible = false;
                colActive.Visible = true;
                colPasive.Visible = false;
            }
            lblRecordCount.Text = jobber.Count.ToString();
        }

        private void cmbAktivePasive_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadGrid();
        }

        private void frm_TaseronTanimlama_Shown(object sender, EventArgs e)
        {
            this.LoadGrid();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewSupplier.GetFocusedRowCellValue("Id"));

            this.FocusedRowHandle = gridViewSupplier.FocusedRowHandle;

            this.pnlKayit.Visible = false;
            this.Enabled = false;
            frm_TaseronGuncelle tg = new frm_TaseronGuncelle(this);

            tg.CurrentJobberId = id;

            tg.ShowDialog();
            pnlKayit.Visible = true;
            this.Enabled = true;
        }

        private void btnPasive_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Pasif yapmak istediğinz emin misiniz?", "Pasif", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.Yes))
            {
                this.FocusedRowHandle = gridViewSupplier.FocusedRowHandle;
                int id = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewSupplier.GetFocusedRowCellValue("Id"));
                Jobber selectedJobber = JobberProvider.Instance.GetItem(id);
                selectedJobber.IsActive = false;
                JobberProvider.Instance.Save(selectedJobber);
                this.LoadGrid();
            }
            else
            {

            }
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Aktif yapmak istediğinz emin misiniz?", "Aktif", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.Yes))
            {
                this.FocusedRowHandle = gridViewSupplier.FocusedRowHandle;
                int id = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewSupplier.GetFocusedRowCellValue("Id"));
                Jobber selectedJobber = JobberProvider.Instance.GetItem(id);
                selectedJobber.IsActive = true;
                JobberProvider.Instance.Save(selectedJobber);
                this.LoadGrid();
            }
            else
            {

            }
        }
    }
}