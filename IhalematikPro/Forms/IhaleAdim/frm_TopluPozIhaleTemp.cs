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
using IhalematikPro.Model;
using IhalematikPro.Manager;
using IhalematikProBL.Provider;
using IhalematikPro.Forms;

namespace IhalematikProUI.Forms.IhaleAdim
{
    public partial class frm_TopluPozIhaleTemp : DevExpress.XtraEditors.XtraForm
    {
        public frm_Teklif_Adim1 _owner { get; set; }
        public List<MaterialList> MaterialListItems = null;
        public frm_TopluPozIhaleTemp(frm_Teklif_Adim1 Owner)
        {
            this._owner = Owner;
            InitializeComponent();
        }

        private void btnHayir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_TopluPozIhaleTemp_Shown(object sender, EventArgs e)
        {
            List<MaterialList> items = this.MaterialListItems;
            grdMaterialList.DataSource = this.MaterialListItems;
        }

        private void btnEvet_Click(object sender, EventArgs e)
        {
            foreach (var item in this.MaterialListItems)
            {
                MaterialListProvider.Instance.Save(item);
                CurrentManager.Instance.CurrentTender.MaterialList.Add(item);
            }
            this.Close();
            this._owner.LoadTenderGroupGrid();
        }
    }
}