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
using IhalematikProUI.Model;
using IhalematikProBL.Provider;
using IhalematikPro.Model;
using IhalematikPro.Manager;

namespace IhalematikProUI.Forms
{
    public partial class frm_TedarikcilerdenFiyatAl : IhalematikBaseForm
    {
        public frm_TedarikcilerdenFiyatAl()
        {
            InitializeComponent();
            base.ScreenMethod();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {

        }

        private void btnKapat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_TedarikcilerdenFiyatAl_Shown(object sender, EventArgs e)
        {
            this.LoadSupplierGrid();
        }
        public void LoadSupplierGrid()
        {
            List<Supplier> suppliers = SupplierProvider.Instance.GetItems();
            List<SupplierModel> models = IhalematikModelBase.GetModels<SupplierModel, Supplier>(suppliers);
            grdSupplier.DataSource = models;
        }

        private void gridViewSupplier_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int supplierId = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewSupplier.GetFocusedRowCellValue("Id"));
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("OfferId", CurrentManager.Instance.CurrentOffer.Id);
            parameters.Add("SupplierId", supplierId);
            List<SupplierMaterialList> supplierMaterialList = SupplierMaterialListProvider.Instance.GetItems(parameters);

            grdMaterialList.DataSource = IhalematikModelBase.GetModels<OfferMaterialListModel, OfferMaterialList>(supplierMaterialList.Select(p => p.MaterialList).ToList());
        }
    }
}