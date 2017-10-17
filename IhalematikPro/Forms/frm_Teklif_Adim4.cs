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
using IhalematikPro.Model;

namespace IhalematikPro.Forms
{
    public partial class frm_Teklif_Adim4 : DevExpress.XtraEditors.XtraForm
    {

        public frm_Teklif_Adim4()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_Teklif_Adim4_Load(object sender, EventArgs e)
        {
            lblTenderDescription.Text = GlobalVeriablesManager.CurrentTender.Description;
            lblTenderNumber.Text = GlobalVeriablesManager.CurrentTender.DisplayNumber;

            List<MaterialList> items = UIMaterialListManager.Instance.GetMaterialListNonWorkship();
            grdMaterialListNonWorkship.DataSource = null;
            GlobalVeriablesManager.MaterialListNonWorkship = IhalematikModelBase.GetModels<MaterialListModel, MaterialList>(items);
            bindingSource1.DataSource = GlobalVeriablesManager.MaterialListNonWorkship; //typeof(List<MaterialList>);
            grdMaterialListNonWorkship.DataSource = bindingSource1;
            double baseAmount = 0;
            this.CalculateInnerValue(ref baseAmount);
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            //grdMaterialListNonWorkship.DataSource = MaterialListNonWorkship;
        }

        private void btnTumuneUygula_Click(object sender, EventArgs e)
        {
            double markup = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtMarkup.Text);
            GlobalVeriablesManager.MaterialListNonWorkship.ForEach(p => p.Markup = markup);
            grdMaterialListNonWorkship.DataSource = null;
            grdMaterialListNonWorkship.DataSource = GlobalVeriablesManager.MaterialListNonWorkship;
            grdMaterialListNonWorkship.RefreshDataSource();
            double baseAmount = 0;
            this.CalculateInnerValue(ref baseAmount);
            //double baseAmount = GlobalVeriablesManager.MaterialListNonWorkship.Sum(p => p.MarkupUnitPrice * p.Quantity);
            lblTotalMarkup.Text = (baseAmount - GlobalVeriablesManager.MaterialListNonWorkship.Sum(p => p.TotalAmount)).ToString("C2");
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            double baseAmount = 0;
            this.CalculateInnerValue(ref baseAmount);
        }

        private void CalculateInnerValue(ref double BaseAmount)
        {
            BaseAmount = GlobalVeriablesManager.MaterialListNonWorkship.Sum(p => p.MarkupUnitPrice * p.Quantity);
            double baseKDVAmount = GlobalVeriablesManager.MaterialListNonWorkship.Sum(p => p.KDVAmount);

            txtBaseAmount.Text = string.Format("{0:C2}", BaseAmount);
            txtBaseKDVAmount.Text = string.Format("{0:C2}", baseKDVAmount);
            txtTotalAmount.Text = string.Format("{0:C2}", Math.Round((baseKDVAmount + BaseAmount), 2));
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (GlobalVeriablesManager.MaterialListNonWorkship != null)
            {
                foreach (MaterialListModel materialListModel in GlobalVeriablesManager.MaterialListNonWorkship)
                {
                    materialListModel.Save();
                }
            }
        }

        private void grdMaterialListNonWorkship_Click(object sender, EventArgs e)
        {

        }
    }
}