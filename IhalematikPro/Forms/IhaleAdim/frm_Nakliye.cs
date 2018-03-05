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
            List<MaterialList> items = CurrentManager.Instance.CurrentTender.MaterialList;
            this.grdMaterialList.DataSource = IhalematikModelBase.GetModels<MaterialListModel, MaterialList>(items);
        }

        private void grdMaterialList2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == colCarriagePercent)
            {
                int currenMaterialId = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewMaterialList.GetFocusedRowCellValue("Id"));
                foreach (var item in CurrentManager.Instance.CurrentTender.MaterialList)
                {
                    if (item.Id.Equals(currenMaterialId))
                    {
                        item.CarriagePercent = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(e.Value);
                        break;
                    }
                }
            }
        }
    }
}