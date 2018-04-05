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
using IhalematikProUI.Manager;
using IhalematikProUI.Forms.Base;

namespace IhalematikProUI.Forms.IhaleAdim
{
    public partial class frm_TopluPozIhaleTemp : IhalematikBaseForm
    {
        public frm_Teklif_Adim1 _owner { get; set; }
        public List<MaterialList> MaterialListItems = null;
        public frm_TopluPozIhaleTemp(frm_Teklif_Adim1 Owner)
        {
            this._owner = Owner;
            InitializeComponent();
            bindingSourceMaterialList.DataSource = typeof(List<MaterialList>);
            grdMaterialList.DataSource = bindingSourceMaterialList;
        }

        private void btnHayir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_TopluPozIhaleTemp_Shown(object sender, EventArgs e)
        {
            LoadingManager.Instance.Show(this);
            if (this.MaterialListItems != null)
            {
                foreach (var item in this.MaterialListItems)
                {
                    item.PozOBFUnitePrice = item.PozOBF.UnitPrice;
                }
            }
            grdMaterialList.DataSource = this.MaterialListItems;
            LoadingManager.Instance.Hide();
        }

        private void btnEvet_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            LoadingManager.Instance.Show(this);
            foreach (var item in this.MaterialListItems)
            {
                MaterialListProvider.Instance.Save(item);

                if (CurrentManager.Instance.CurrentTender.MaterialList.Where(p => p.Id == item.Id).Count() == 0)
                {
                    CurrentManager.Instance.CurrentTender.MaterialList.Add(item);
                }

                Poz currentPoz = PozProvider.Instance.GetItem(item.PozOBFId);
                if (currentPoz != null)
                {
                    currentPoz.UnitPrice = item.PozOBFUnitePrice;
                    PozProvider.Instance.Save(currentPoz);
                }
            }
            LoadingManager.Instance.Hide();
            this.Enabled = true;
            this.Close();
            this._owner.LoadTenderGroupGrid();
        }

        private void gridViewMaterialList_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == colUnitPrice)
            {
                int id = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewMaterialList.GetFocusedRowCellValue("PozOBFId"));

                Poz currentPoz = PozProvider.Instance.GetItem(id);

                if (currentPoz != null)
                {
                    double unitPrice = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(e.Value);
                    currentPoz.UnitPrice = unitPrice;
                    //
                }
            }
        }
    }
}