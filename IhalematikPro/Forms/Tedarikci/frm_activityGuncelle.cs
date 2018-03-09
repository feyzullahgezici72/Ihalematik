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
    public partial class frm_activityGuncelle : DevExpress.XtraEditors.XtraForm
    {
        public frm_FaalitetAlaniEkle _owner = null;

        public int CurrentSupplierSegmentId { get; set; }
        public SupplierSegment currentSupplierSegment { get; set; }
        public SupplierSegment CurrentSupplierSegment
        {
            get
            {
                if (this.currentSupplierSegment == null)
                {
                    this.currentSupplierSegment = SupplierSegmentProvider.Instance.GetItem(this.CurrentSupplierSegmentId);
                }
                return this.currentSupplierSegment;
            }
        }
        public frm_activityGuncelle(frm_FaalitetAlaniEkle Owner)
        {
            this._owner = Owner;
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_activityGuncelle_Shown(object sender, EventArgs e)
        {
            txtSupplierSegment.Text = this.CurrentSupplierSegment.Name;
            txtSupplierSegment.Focus();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSupplierSegment.Text))
            {
                this.CurrentSupplierSegment.Name = txtSupplierSegment.Text;
                SupplierSegmentProvider.Instance.Save(this.CurrentSupplierSegment);
                this.Close();
                this._owner.LoadGrid();
            }
        }
    }
}