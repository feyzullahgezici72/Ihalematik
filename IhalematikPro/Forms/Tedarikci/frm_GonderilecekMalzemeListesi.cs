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
using IhalematikProBL.Provider;

namespace IhalematikProUI.Forms.Tedarikci
{
    public partial class frm_GonderilecekMalzemeListesi : DevExpress.XtraEditors.XtraForm
    {
        public frm_TedarikcilereTeklifGonder _owner = null;
        public frm_GonderilecekMalzemeListesi(frm_TedarikcilereTeklifGonder Owner)
        {
            InitializeComponent();
            this._owner = Owner;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_GonderilecekMalzemeListesi_Shown(object sender, EventArgs e)
        {
            this.LoadAddedMateriallistGrid();
        }
        private void LoadAddedMateriallistGrid()
        {
            grdAddedOfferMaterialList.DataSource = CurrentManager.Instance.CurrentOffer.MaterialList.Where(p => p.IsSelected);
        }

        private void rpstRemove_Click(object sender, EventArgs e)
        {
            int materialId = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewAddedOfferMaterialList.GetFocusedRowCellValue("Id"));
            OfferMaterialList selectedOfferMaterialList = CurrentManager.Instance.CurrentOffer.MaterialList.Where(p => p.Id == materialId).FirstOrDefault();
            selectedOfferMaterialList.IsSelected = false;

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("OfferId", CurrentManager.Instance.CurrentOffer.Id);
            parameters.Add("MaterialListId", materialId);

            List<SupplierMaterialList> items = SupplierMaterialListProvider.Instance.GetItems(parameters);

            foreach (var item in items)
            {
                item.IsMarkedForDeletion = true;
                SupplierMaterialListProvider.Instance.Save(item);
            }

            this._owner.LoadMaterialGrid();
            this.LoadAddedMateriallistGrid();
        }
    }
}