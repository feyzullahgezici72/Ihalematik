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
        public frm_DigerGiderler()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frm_DigerGiderler_Shown(object sender, EventArgs e)
        {
            List<OtherExpenses> items = OtherExpensesProvider.Instance.GetItems("TenderId", CurrentManager.Instance.CurrentTender.Id);
            grdOtherExpenses.DataSource = items;
        }

        private void gridViewOtherExpenses_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            int id = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewOtherExpenses.GetFocusedRowCellValue("Id"));

            OtherExpenses currentItem = null;

            if (id > 0)
            {
                currentItem = OtherExpensesProvider.Instance.GetItem(id);

            }
            else
            {
                currentItem = new OtherExpenses(CurrentManager.Instance.CurrentTender.Id);

            }


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
    }
}