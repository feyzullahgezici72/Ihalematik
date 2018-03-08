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
using IhalematikPro.Manager;
using IhalematikPro.Model;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace IhalematikProUI.Forms.IhaleAdim
{
    public partial class frm_Nakliye : DevExpress.XtraEditors.XtraForm
    {
        public frm_TeklifAdimSon _owner = null;
        public frm_Nakliye(frm_TeklifAdimSon Owner)
        {
            this._owner = Owner;
            InitializeComponent();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            double carriage = double.Parse(string.IsNullOrEmpty(txtCarriage.Text) ? "0" : txtCarriage.Text.Replace("TL", string.Empty));
            CurrentManager.Instance.CurrentTender.Carriage = carriage;
            this._owner.SetCarriageValue();
            this.Close();
        }

        private void frm_Nakliye_Load(object sender, EventArgs e)
        {
            if (CurrentManager.Instance.CurrentTender != null)
            {
                List<MaterialList> items = CurrentManager.Instance.CurrentTender.MaterialList;
                this.grdMaterialList.DataSource = IhalematikModelBase.GetModels<MaterialListModel, MaterialList>(items);
                txtCarriage.Text = CurrentManager.Instance.CurrentTender.Carriage.ToString("c2");
            }
        }

        private void grdMaterialList2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
           
        }

        private void gridViewMaterialList_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            
        }

        private void gridViewMaterialList_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            ColumnView view = sender as ColumnView;
            GridColumn column = (e as EditFormValidateEditorEventArgs)?.Column ?? view.FocusedColumn;

            if (column == colCarriagePercent)
            {
                double carriagePercent = CurrentManager.Instance.CurrentTender.MaterialList.Sum(p => p.CarriagePercent);
                double currentCarriagePercent = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(e.Value);
                if ((carriagePercent + currentCarriagePercent) > 100)
                {
                    //gridViewMaterialList.SetColumnError(colCarriagePercent, "Ağırlık toplamları %100 ü geçmemelidir!", ErrorType.Critical);
                    MessageBox.Show("Ağırlık toplamları %100 ü geçmemelidir!");
                    e.Valid = false;
                    //    gridViewMaterialList.SetRowCellValue(e.RowHandle, "CarriagePercent", 0);
                }
                else
                {
                    int currenMaterialId = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewMaterialList.GetFocusedRowCellValue("Id"));
                    foreach (var item in CurrentManager.Instance.CurrentTender.MaterialList)
                    {
                        if (item.Id.Equals(currenMaterialId))
                        {
                            item.CarriagePercent = currentCarriagePercent;
                            break;
                        }
                    }
                }
            }
        }

        private void grdMaterialList_Click(object sender, EventArgs e)
        {

        }
    }
}