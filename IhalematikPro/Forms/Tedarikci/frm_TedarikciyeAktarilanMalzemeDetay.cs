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

namespace IhalematikProUI.Forms.Tedarikci
{
    public partial class frm_TedarikciyeAktarilanMalzemeDetay : DevExpress.XtraEditors.XtraForm
    {
        frm_TedarikcilereTeklifGonder _owner;
        public int SelectedSupplierId { get; set; }

        public frm_TedarikciyeAktarilanMalzemeDetay(frm_TedarikcilereTeklifGonder Owner)
        {
            InitializeComponent();
            this._owner = Owner;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_TedarikciyeAktarilanMalzemeDetay_Shown(object sender, EventArgs e)
        {
            Supplier supplier = SupplierProvider.Instance.GetItem(this.SelectedSupplierId);
            if (supplier != null)
            {
                txtCompanyName.Text = supplier.CompanyName;
                txtAuthorNameSurname.Text = supplier.AuthorNameSurname;
                txtEmail.Text = supplier.Email;
                txtScore.Text = supplier.Score;
                if (supplier.Segments != null)
                {
                    memoEditSegment.Lines = supplier.Segments.Select(p => p.Name) as string[];
                }
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("OfferId", CurrentManager.Instance.CurrentOffer.Id);
                parameters.Add("SupplierId", supplier.Id);

                List<SupplierMaterialList> items = SupplierMaterialListProvider.Instance.GetItems(parameters);

                grdMaterialList.DataSource = items.Select(p => p.MaterialList);
            }
        }
    }
}