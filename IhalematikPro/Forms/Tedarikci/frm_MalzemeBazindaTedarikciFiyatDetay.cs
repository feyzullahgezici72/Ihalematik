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
using IhalematikProUI.Model;

namespace IhalematikProUI.Forms.Tedarikci
{
    public partial class frm_MalzemeBazindaTedarikciFiyatDetay : DevExpress.XtraEditors.XtraForm
    {
        public int SelectedOfferMaterialListId { get; set; }
        public frm_MalzemeBazindaTedarikciFiyatDetay()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_MalzemeBazindaTedarikciFiyatDetay_Shown(object sender, EventArgs e)
        {
            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("OfferId", CurrentManager.Instance.CurrentOffer.Id);
            param.Add("MaterialListId", this.SelectedOfferMaterialListId);

            List<SupplierMaterialList> items = SupplierMaterialListProvider.Instance.GetItems(param);
            List<OfferMaterialListModel> models = new List<OfferMaterialListModel>();

            if (items != null)
            {
                foreach (var item in items)
                {
                    OfferMaterialListModel model = new OfferMaterialListModel(item.MaterialList);
                    model.SupplierName = item.Supplier.CompanyName;
                    model.Price = item.Price;
                    models.Add(model);
                }
            }
            grdMaterialList.DataSource = models;
        }
    }
}