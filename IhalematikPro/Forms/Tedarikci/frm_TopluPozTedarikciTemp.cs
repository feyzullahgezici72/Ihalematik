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
using IhalematikPro.Forms;
using IhalematikProBL.Provider;
using IhalematikProUI.Manager;
using IhalematikProUI.Forms.Base;
using IhalematikPro.Manager;

namespace IhalematikProUI.Forms.Tedarikci
{
    public partial class frm_TopluPozTedarikciTemp : IhalematikBaseForm
    {
        private frm_TedarikcilereTeklifGonder _owner = null;
        public List<OfferMaterialList> MaterialList = null;
        public frm_TopluPozTedarikciTemp(frm_TedarikcilereTeklifGonder Owner)
        {
            this._owner = Owner;
            InitializeComponent();
        }
      
        private void btnHayir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEvet_Click(object sender, EventArgs e)
        {

            this.Enabled = false;
            LoadingManager.Instance.Show(this);
            foreach (var item in this.MaterialList)
            {
                OfferMaterialListProvider.Instance.Save(item);
                if (UICurrentManager.Instance.CurrentOffer.MaterialList.Where(p => p.Id == item.Id).Count() == 0)
                {
                    UICurrentManager.Instance.CurrentOffer.MaterialList.Add(item);
                }
            }
            LoadingManager.Instance.Hide();
            this.Enabled = true;
            UIPopupManager.Instance.ShowPopup();
            this.Close();
            this._owner.LoadMaterialGrid();
        }

        private void frm_TopluPozTedarikciTemp_Load(object sender, EventArgs e)
        {
            grdMaterialList.DataSource = this.MaterialList;
        }
    }
}