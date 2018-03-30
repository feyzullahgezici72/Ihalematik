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
using IhalematikProUI.Forms.Base;
using IhalematikProBL.Entity;
using IhalematikProBL.Provider;
using IhalematikProUI.Forms.Tedarikci;
using IhalematikPro.Forms;
using IhalematikPro.Manager;
using IhalematikProUI.Manager;

namespace IhalematikProUI.Forms
{
    public partial class frm_TeklifListesi : IhalematikBaseForm
    {
        public int FocusedRowHandle { get; private set; }
        public frm_TeklifListesi()
        {
            InitializeComponent();
            base.ScreenMethod();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_TeklifListesi_Load(object sender, EventArgs e)
        {
            groupControl1.Width = groupControl2.Width;
        }
        frm_TedarikcilereTeklifGonder teklifGonder;

        private void btnOpen_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int id = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewOffer.GetFocusedRowCellValue("Id"));

            CurrentManager.Instance.CurrentOffer = OfferProvider.Instance.GetItem(id);

            this.Close();
            frm_Anaform af = (frm_Anaform)Application.OpenForms["frm_Anaform"];
            af.ribbonPage8.Ribbon.SelectedPage = af.ribbonPage8;
            // af.barButtonItem14.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            af.RibonPasif();
            if (teklifGonder == null)
            {
                teklifGonder = new frm_TedarikcilereTeklifGonder();
                teklifGonder.MdiParent = (frm_Anaform)Application.OpenForms["frm_Anaform"];
                teklifGonder.FormClosed += new FormClosedEventHandler(TeklifGonder_FormClosed);
                af.MainPanel.Visible = false;
                teklifGonder.Show();
            }
            else
            {
                teklifGonder.Activate();
            }
        }

        private void TeklifGonder_FormClosed(object sender, FormClosedEventArgs e)
        {
            teklifGonder = null;
            frm_Anaform af = (frm_Anaform)Application.OpenForms["frm_Anaform"];
            af.RibonAktif();

        }

        private void frm_TeklifListesi_Shown(object sender, EventArgs e)
        {
            this.Enabled = false;
            LoadingManager.Instance.Show(this);
            this.LoadOfferGrid();
            LoadingManager.Instance.Hide();;
            this.Enabled = true;

        }

        private void LoadOfferGrid()
        {
            List<Offer> items = OfferProvider.Instance.GetItems();
            grdOfferNoCompleated.DataSource = items.Where(p => !p.IsCompleated).ToList();
            // grdOffer.DataSource = items;

            if (cmbAktivePasive.SelectedIndex == 0)
            {
                grdOffer.DataSource = items.Where(p => p.IsActive && p.IsCompleated);
                colPasive.Visible = true;
                colActive.Visible = false;
                colOpen.Visible = true;
            }
            else if (cmbAktivePasive.SelectedIndex == 1)
            {
                grdOffer.DataSource = items.Where(p => !p.IsActive && p.IsCompleated);
                colActive.Visible = true;
                colOpen.Visible = false;
                colPasive.Visible = false;
            }
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Aktif yapmak istediğinz emin misiniz?", "Aktif", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.Yes))
            {
                this.FocusedRowHandle = gridViewOffer.FocusedRowHandle;
                int id = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewOffer.GetFocusedRowCellValue("Id"));
                Offer selectedOffer = OfferProvider.Instance.GetItem(id);
                selectedOffer.IsActive = true;
                OfferProvider.Instance.Save(selectedOffer);
                this.LoadOfferGrid();
            }
            else
            {

            }
        }

        private void btnPasive_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Pasif yapmak istediğinz emin misiniz?", "Pasif", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.Yes))
            {
                this.FocusedRowHandle = gridViewOffer.FocusedRowHandle;
                int id = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewOffer.GetFocusedRowCellValue("Id"));
                Offer selectedOffer = OfferProvider.Instance.GetItem(id);
                selectedOffer.IsActive = false;
                OfferProvider.Instance.Save(selectedOffer);
                this.LoadOfferGrid();
            }
            else
            {

            }
        }

        private void cmbAktivePasive_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadOfferGrid();
        }

        private void btnDetail_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int id = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewOffer.GetFocusedRowCellValue("Id"));
            frm_TeklifDetayFirma detay = new frm_TeklifDetayFirma();
            detay.CurrentOfferId = id;
            detay.ShowDialog();
        }

        private void btnDetail_ButtonClick_1(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int id = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridView1.GetFocusedRowCellValue("Id"));
            frm_TeklifDetayFirma detay = new frm_TeklifDetayFirma();
            detay.CurrentOfferId = id;
            detay.ShowDialog();
        }

        private void btnAc_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int id = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridView1.GetFocusedRowCellValue("Id"));

            CurrentManager.Instance.CurrentOffer = OfferProvider.Instance.GetItem(id);

            this.Close();
            frm_Anaform af = (frm_Anaform)Application.OpenForms["frm_Anaform"];
            af.ribbonPage8.Ribbon.SelectedPage = af.ribbonPage8;
            // af.barButtonItem14.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            af.RibonPasif();
            if (teklifGonder == null)
            {
                teklifGonder = new frm_TedarikcilereTeklifGonder();
                teklifGonder.MdiParent = (frm_Anaform)Application.OpenForms["frm_Anaform"];
                teklifGonder.FormClosed += new FormClosedEventHandler(TeklifGonder_FormClosed);
                af.MainPanel.Visible = false;
                teklifGonder.Show();
            }
            else
            {
                teklifGonder.Activate();
            }
        }
    }
}