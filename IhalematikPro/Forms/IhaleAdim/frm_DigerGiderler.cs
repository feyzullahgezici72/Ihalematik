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

namespace IhalematikProUI.Forms.IhaleAdim
{
    public partial class frm_DigerGiderler : DevExpress.XtraEditors.XtraForm
    {
        private frm_TeklifAdimSon _owner = null;
        public frm_DigerGiderler(frm_TeklifAdimSon Owner)
        {
            this._owner = Owner;
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this._owner.OtherExpenses();
            this.Close();
        }

        private void frm_DigerGiderler_Shown(object sender, EventArgs e)
        {
            this.LoadGrid();
        }

        private void LoadGrid()
        {
            List<OtherExpenses> items = OtherExpensesProvider.Instance.GetItems("TenderId", CurrentManager.Instance.CurrentTender.Id);
            bindingSourceOtherExpenses.DataSource = items;
            grdOtherExpenses.DataSource = bindingSourceOtherExpenses;
        }

        private void gridViewOtherExpenses_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            int id = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewOtherExpenses.GetFocusedRowCellValue("Id"));

            OtherExpenses currentItem = null;

            if (id > 0)
            {
                currentItem = OtherExpensesProvider.Instance.GetItem(id);
                if (e.Column == colDescription)
                {

                    currentItem.Description = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<string>(e.Value);
                }
                else if (e.Column == colPrice)
                {
                    currentItem.Price = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(e.Value);
                }
                OtherExpensesProvider.Instance.Save(currentItem);
            }
            else
            {
                currentItem = new OtherExpenses(CurrentManager.Instance.CurrentTender.Id);
                if (e.Column == colDescription)
                {
                    currentItem.Description = (string)gridViewOtherExpenses.ActiveEditor.EditValue;
                }
                else if (e.Column == colPrice)
                {
                    object price = gridViewOtherExpenses.ActiveEditor.EditValue;
                    currentItem.Price = double.Parse((string)price);
                }
                OtherExpensesProvider.Instance.Save(currentItem);
                gridViewOtherExpenses.SetFocusedRowCellValue(colId, currentItem.Id);
            }
            grdOtherExpenses.Refresh();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Silmek istediğinizden emin misiniz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.Yes))
            {
                int id = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewOtherExpenses.GetFocusedRowCellValue("Id"));
                OtherExpenses selectedVehicle = OtherExpensesProvider.Instance.GetItem(id);
                selectedVehicle.IsMarkedForDeletion = true;
                OtherExpensesProvider.Instance.Save(selectedVehicle);
                this.LoadGrid();
            }
            else
            {

            }
        }

        private void frm_DigerGiderler_Load(object sender, EventArgs e)
        {

        }
    }
}