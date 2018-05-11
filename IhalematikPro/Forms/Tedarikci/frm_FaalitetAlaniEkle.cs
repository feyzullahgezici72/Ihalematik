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
using IhalematikProUI.Forms.Tedarikci;

namespace IhalematikProUI.Forms
{
    public partial class frm_FaalitetAlaniEkle : DevExpress.XtraEditors.XtraForm
    {
        frm_TedarikciTanimlama _owner = null;
        public int FocusedRowHandle = 0;
        public frm_FaalitetAlaniEkle(frm_TedarikciTanimlama Owner)
        {
            this._owner = Owner;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            IsEmptyKontrol();
            if (!string.IsNullOrEmpty(txtUnvan.Text.Trim()))
            {
                SupplierSegment supplierSegment = new SupplierSegment();
                supplierSegment.Name = txtUnvan.Text.Trim();
                List<SupplierSegment> existingItem = SupplierSegmentProvider.Instance.GetItems("Name", supplierSegment.Name);

                if (existingItem.Count == 0)
                {
                    SupplierSegmentProvider.Instance.Save(supplierSegment);
                    this.LoadGrid();
                    frm_MesajFormu mf = new frm_MesajFormu();
                    mf.lblMesaj.Text = "Faaliyet alanı eklendi...";
                    mf.ShowDialog();
                    //this._owner.LoadSupplierSegments();
                    //this.Close();
                    txtUnvan.ResetText();
                    txtUnvan.Focus();
                }
                else
                {
                    MessageBox.Show("Ayni kayit vardir");
                }
            }
        }

        public bool IsEmptyKontrol()
        {
            if (string.IsNullOrEmpty(txtUnvan.Text.Trim()))
            {
                dxErrorProvider1.SetError(txtUnvan, "Faaliyet alanı boş bırakılamaz", DevExpress.XtraEditors.DXErrorProvider.ErrorType.User3);
                return true;
            }
            else
            {
                dxErrorProvider1.ClearErrors();
            }
            return false;
        }

        private void btnGuncelle_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int id = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewSupplierSegment.GetFocusedRowCellValue("Id"));
            frm_activityGuncelle ag = new frm_activityGuncelle(this);
            this.FocusedRowHandle = gridViewSupplierSegment.FocusedRowHandle;
            ag.CurrentSupplierSegmentId = id;
            ag.ShowDialog();

        }

        private void frm_FaalitetAlaniEkle_Shown(object sender, EventArgs e)
        {
            this.LoadGrid();
            txtUnvan.Focus();
        }

        public void LoadGrid()
        {
            List<SupplierSegment> supplierSegments = SupplierSegmentProvider.Instance.GetItems();
            grdSupplierSegment.DataSource = supplierSegments;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
            this._owner.LoadGrid();
            this._owner.LoadSupplierSegments();
        }

        private void txtUnvan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                btnSave.PerformClick();
            }
        }
    }
}