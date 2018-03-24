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
using IhalematikPro.Manager;
using IhalematikProBL.Entity;

namespace IhalematikProUI.Forms.Tedarikci
{
    public partial class frm_KarsilastirmadaSecilenFirmaUrunListesi : DevExpress.XtraEditors.XtraForm
    {
        public frm_KarsilastirmadaSecilenFirmaUrunListesi()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_KarsilastirmadaSecilenFirmaUrunListesi_Load(object sender, EventArgs e)
        {

        }

        private void frm_KarsilastirmadaSecilenFirmaUrunListesi_Shown(object sender, EventArgs e)
        {
            if (CurrentManager.Instance.CurrentOffer != null)
            {
                if (CurrentManager.Instance.CurrentOffer.SelectedSupplierMaterialList != null)
                {
                    grdSupplier.DataSource = CurrentManager.Instance.CurrentOffer.SelectedSupplierMaterialList.GroupBy(p => p.SupplierId).Select(p => p.FirstOrDefault().Supplier).ToList();
                }
            }
        }

        private void gridViewSupplier_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int supplierId = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewSupplier.GetFocusedRowCellValue("Id"));
            List<SupplierMaterialList> items = CurrentManager.Instance.CurrentOffer.SelectedSupplierMaterialList.Where(p => p.SupplierId == supplierId).ToList();

            grdMaterialList.DataSource = null;
            grdMaterialList.DataSource = items;//.Select(p => p.MaterialList).ToList();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            List<SupplierMaterialList> items = CurrentManager.Instance.CurrentOffer.SelectedSupplierMaterialList;

            grdMaterialList.DataSource = null;
            grdMaterialList.DataSource = items;
        }
    }
}