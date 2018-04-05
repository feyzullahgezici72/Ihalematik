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
using IhalematikProUI.Manager;
using IhalematikProBL.Provider;
using IhalematikPro.Manager;
using IhalematikProUI.Forms.Base;

namespace IhalematikProUI.Forms.Tedarikci
{
    public partial class frm_TopluObfTedarikciTemp : IhalematikBaseForm
    {
        private frm_TedarikcilereTeklifGonder _owner = null;

        public List<OfferMaterialList> MaterialList = null;

        public frm_TopluObfTedarikciTemp(frm_TedarikcilereTeklifGonder Owner)
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
                CurrentManager.Instance.CurrentOffer.MaterialList.Add(item);
            }
            LoadingManager.Instance.Hide();
            this.Enabled = true;
            this.Close();
            this._owner.LoadMaterialGrid();
        }

        private void frm_TopluObfTedarikciTemp_Load(object sender, EventArgs e)
        {
            grdMaterialList.DataSource = this.MaterialList;
        }
    }
}