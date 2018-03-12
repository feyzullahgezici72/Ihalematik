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

namespace IhalematikProUI.Forms.Tedarikci
{
    public partial class frm_TeklifDetayFirma : DevExpress.XtraEditors.XtraForm
    {
        public int CurrentOfferId { get; set; }
        public Offer currentOffer { get; set; }
        public Offer CurrentOffer
        {
            get
            {
                if (this.currentOffer == null)
                {
                    this.currentOffer = OfferProvider.Instance.GetItem(this.CurrentOfferId);
                }
                return this.currentOffer;
            }
        }
        public frm_TeklifDetayFirma()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_TeklifDetayFirma_Shown(object sender, EventArgs e)
        {
            txtTeklifNo.Text = this.CurrentOffer.Number;
            txtAciklama.Text = this.CurrentOffer.Description;
            txtDate.Text = this.CurrentOffer.DateTime.ToShortDateString();

            List<Supplier> supplierReplay = new List<Supplier>();
            List<Supplier> supplierNonReplay = new List<Supplier>();

            List<SupplierMaterialList> items = SupplierMaterialListProvider.Instance.GetItems("OfferId", this.CurrentOfferId);
            if (items != null)
            {
                var groupedSupliers = items.GroupBy(p => p.Supplier.Id).
                                            Where(k => k.Where(p => p.Price != 0).Count() > 0);
                foreach (var item in groupedSupliers)
                {
                    supplierReplay.Add(item.FirstOrDefault().Supplier);
                }

                grdSupplierReplayed.DataSource = supplierReplay;

                var groupedNonReplaySupliers = items.GroupBy(p => p.Supplier.Id).
                                            Where(k => k.Where(p => p.Price == 0).Count() > 0);
                foreach (var item in groupedNonReplaySupliers)
                {
                    supplierNonReplay.Add(item.FirstOrDefault().Supplier);
                }

                grdSupplierNonReplayed.DataSource = supplierNonReplay;
            }

        }

        private void rpstSupplierDetail1_Click(object sender, EventArgs e)
        {
            frm_TedarikciyeAktarilanMalzemeDetay md = new frm_TedarikciyeAktarilanMalzemeDetay();
            md.ShowMailPanel = false;
            int selectedSupplierId = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridView2.GetFocusedRowCellValue("Id"));
            md.SelectedSupplierId = selectedSupplierId;
            md.ShowDialog();
        }

        private void rpstSupplierDetail1_Click_1(object sender, EventArgs e)
        {
            frm_TedarikciyeAktarilanMalzemeDetay md = new frm_TedarikciyeAktarilanMalzemeDetay();
            md.ShowMailPanel = false;
            int selectedSupplierId = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewSupplier.GetFocusedRowCellValue("Id"));
            md.SelectedSupplierId = selectedSupplierId;
            md.ShowDialog();
        }
    }
}