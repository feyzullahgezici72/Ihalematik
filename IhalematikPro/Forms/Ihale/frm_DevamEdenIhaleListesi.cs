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
using IhalematikPro.Manager;
using IhalematikProUI.Forms;
using System.Threading;
using IhalematikProUI.Forms.Base;
using System.Diagnostics;
using IhalematikProUI.Manager;
using IhalematikProBL.Manager;

namespace IhalematikPro.Forms
{
    public partial class frm_DevamEdenIhaleListesi : IhalematikBaseForm
    {
        public frm_DevamEdenIhaleListesi()
        {
            InitializeComponent();
            base.ScreenMethod();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void LoadGrid()
        {
            LoadingManager.Instance.Show(this);

            List<Tender> list = new List<Tender>();
            if (cmbAktivePasive.SelectedIndex == 0)
            {
                list = TenderProvider.Instance.GetItems("IsActive", true);
                colPasive.Visible = true;
                colOpenTender.Visible = true;
                colActive.Visible = false;
            }
            else if (cmbAktivePasive.SelectedIndex == 1)
            {
                list = TenderProvider.Instance.GetItems("IsActive", false);
                colOpenTender.Visible = false;
                colPasive.Visible = false;
                colActive.Visible = true;
            }
            
            lblRecordCount.Text = list.Count.ToString();
            grdActiveTenderList.DataSource = list.OrderByDescending(p => p.InsertTime).ToList();



            LoadingManager.Instance.Hide();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            //aktifler

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //pasifler

        }

        private void btnIhaleAc_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            MessageBox.Show("Hazır Değil...");
        }

        private void grdActiveTenderList_Click(object sender, EventArgs e)
        {

        }
        Forms.frm_Teklif_Adim1 ta1;
        private void btnIhaleAc_Click(object sender, EventArgs e)
        {
            int Id = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewActiveTenderList.GetFocusedRowCellValue("Id"));
            CurrentManager.Instance.CurrentTender = TenderProvider.Instance.GetItem(Id);
            this.Close();
            frm_Anaform af = (frm_Anaform)Application.OpenForms["frm_Anaform"];
            af.ribbonPage7.Ribbon.SelectedPage = af.ribbonPage7;
            af.RibonPasif();
            if (ta1 == null)
            {
                ta1 = new frm_Teklif_Adim1();
                ta1.MdiParent = af;
                ta1.FormClosed += new FormClosedEventHandler(Ta1_FormClosed);
                ta1.Show();
            }
            else
            {
                ta1.Activate();
            }
        }
        private void Ta1_FormClosed(object sender, FormClosedEventArgs e)
        {
            ta1 = null;
            frm_Anaform af = (frm_Anaform)Application.OpenForms["frm_Anaform"];
            af.RibonAktif();
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadGrid();
        }

        private void btnDetay_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frm_IhaleBilgisiDetay ibd = new frm_IhaleBilgisiDetay(this);
            ibd.TenderId = (int)gridViewActiveTenderList.GetFocusedRowCellValue("Id");
            ibd.ShowDialog();
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            string tenderNumber = txtTenderNumber.Text.Trim();
            string tenderDescription = txtTenderDescription.Text.Trim();

            List<Tender> list = new List<Tender>();
            if (cmbAktivePasive.SelectedIndex == 0)
            {
                list = TenderProvider.Instance.GetItems("IsActive", true);
            }
            if (cmbAktivePasive.SelectedIndex == 1)
            {
                list = TenderProvider.Instance.GetItems("IsActive", false);
            }
            if (cmbAktivePasive.SelectedIndex == 2)
            {
                list = TenderProvider.Instance.GetItems();
            }

            if (!string.IsNullOrEmpty(tenderNumber))
            {
                list = list.Where(p => p.Number.ToString().ToLower().Contains(tenderNumber.ToLower())).ToList();
            }

            if (!string.IsNullOrEmpty(tenderDescription))
            {
                list = list.Where(p => p.Description.ToString().ToLower().Contains(tenderDescription.ToLower())).ToList();
            }

            grdActiveTenderList.DataSource = list.OrderByDescending(p => p.InsertTime).ToList();
            lblRecordCount.Text = list.Count.ToString();
            txtTenderDescription.Focus();
        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            string tenderNumber = txtTenderNumber.Text.Trim();
            string tenderDescription = txtTenderDescription.Text.Trim();

            List<Tender> list = new List<Tender>();
            if (cmbAktivePasive.SelectedIndex == 0)
            {
                list = TenderProvider.Instance.GetItems("IsActive", true);
            }
            if (cmbAktivePasive.SelectedIndex == 1)
            {
                list = TenderProvider.Instance.GetItems("IsActive", false);
            }
            if (cmbAktivePasive.SelectedIndex == 2)
            {
                list = TenderProvider.Instance.GetItems();
            }

            if (!string.IsNullOrEmpty(tenderNumber))
            {
                list = list.Where(p => p.Number.ToString().ToLower().Contains(tenderNumber.ToLower())).ToList();
            }

            if (!string.IsNullOrEmpty(tenderDescription))
            {
                list = list.Where(p => p.Description.ToString().ToLower().Contains(tenderDescription.ToLower())).ToList();
            }

            grdActiveTenderList.DataSource = list.OrderByDescending(p => p.InsertTime).ToList();
            lblRecordCount.Text = list.Count.ToString();
            txtTenderNumber.Focus();
        }

        private void txtTenderNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                simpleButton2.PerformClick();
            }
        }

        private void txtTenderDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                simpleButton1.PerformClick();
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                bool isSuccess = UIReportManager.Instance.ExtractExcel(grdActiveTenderList);
                if (!isSuccess)
                {
                    MessageBox.Show("Hay Aksii!! \nProgram beklenmeyen bir hata ile karşılaştı.");
                }
            }
            catch (Exception ex)
            {
                LoggingManager.Instance.SaveErrorLog(ex);
            }
        }

        private void frm_DevamEdenIhaleListesi_Shown(object sender, EventArgs e)
        {
            this.Enabled = false;
            this.LoadGrid();
            this.Enabled = true;
        }

        private void btnPasive_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Pasif yapmak istediginzden emin misiniz?", "Pasif Yap", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                int id = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewActiveTenderList.GetFocusedRowCellValue("Id"));
                Tender selectedTender = TenderProvider.Instance.GetItem(id);
                selectedTender.IsActive = false;
                TenderProvider.Instance.Save(selectedTender);
                this.LoadGrid();
            }
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Aktif yapmak istediğinizden emin misiniz?", "Aktif Yap", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                int id = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewActiveTenderList.GetFocusedRowCellValue("Id"));
                Tender selectedTender = TenderProvider.Instance.GetItem(id);
                selectedTender.IsActive = true;
                TenderProvider.Instance.Save(selectedTender);
                this.LoadGrid();
            }
        }
    }
}
