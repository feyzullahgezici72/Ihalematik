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
    public partial class frm_Teklif_Adim2 : DevExpress.XtraEditors.XtraForm
    {
        private object a3;

        public frm_Teklif_Adim2()
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

        private void frm_Teklif_Adim2_Load(object sender, EventArgs e)
        {
            lblTenderDescription.Text = CurrentManager.CurrentTender.Description;
            lblTenderNumber.Text = CurrentManager.CurrentTender.DisplayNumber;

            List<MaterialList> items = UIMaterialListManager.Instance.GetMaterialLists();
            grdMaterialListNonWorkship.DataSource = null;
            List<MaterialListModel> models = IhalematikModelBase.GetModels<MaterialListModel, MaterialList>(items);
            bindingSource1.DataSource = models; //typeof(List<MaterialList>);
            grdMaterialListNonWorkship.DataSource = bindingSource1;
            double baseAmount = 0;
            this.CalculateInnerValue(ref baseAmount);
            lblTotalMarkup.Text = (models.Sum(p => p.TotalMarkup)).ToString("C2");
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            //grdMaterialListNonWorkship.DataSource = MaterialListNonWorkship;
        }

        private void btnTumuneUygula_Click(object sender, EventArgs e)
        {
            double markup = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtMarkup.Text.Replace("%", ""));
            List<MaterialList> items = UIMaterialListManager.Instance.GetMaterialLists(); ;//.Instance.GetMaterialListNonWorkship();
            foreach (var item in items)
            {
                item.Markup = markup;
                MaterialListProvider.Instance.Save(item);
            }

            this.frm_Teklif_Adim2_Load(null, null);
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            double baseAmount = 0;
            this.CalculateInnerValue(ref baseAmount);
        }

        private void CalculateInnerValue(ref double BaseAmount)
        {
            List<MaterialList> items = CurrentManager.CurrentTender.MaterialList.Where(p => p.IsWorkship == false).ToList();//.Instance.GetMaterialListNonWorkship();
            BaseAmount = items.Sum(p => p.Markup * p.Quantity);
            double baseKDVAmount = items.Sum(p => p.KDVAmount);

            txtBaseAmount.Text = string.Format("{0:C2}", BaseAmount);
            txtBaseKDVAmount.Text = string.Format("{0:C2}", baseKDVAmount);
            txtTotalAmount.Text = string.Format("{0:C2}", Math.Round((baseKDVAmount + BaseAmount), 2));
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            List<MaterialList> items = UIMaterialListManager.Instance.GetMaterialListNonWorkship();
            if (items != null)
            {
                foreach (MaterialList materialList in items)
                {
                    MaterialListProvider.Instance.Save(materialList);// materialListModel.Save();
                }
            }
            frm_ihaleOlustuMesaj frm = new frm_ihaleOlustuMesaj();
            frm.lblMesaj.Text = "Malzemeler Kaydedildi...";
            frm.ShowDialog();
            this.Close();
            frm_Teklif_Adim3 a3= (frm_Teklif_Adim3)Application.OpenForms["frm_Teklif_Adim3"];
            frm_Anaform af = (frm_Anaform)Application.OpenForms["frm_Anaform"];
            if (a3 == null)
            {
                a3 = new frm_Teklif_Adim3();
                a3.MdiParent = (frm_Anaform)Application.OpenForms["frm_Anaform"];
                a3.FormClosed += new FormClosedEventHandler(a3_FormClosed);
                af.MainPanel.Visible = false;
                a3.Show();

            }
            else
            {
                a3.Activate();
            }
        }

        private void a3_FormClosed(object sender, FormClosedEventArgs e)
        {
            a3 = null;
        }

        private void grdMaterialListNonWorkship_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
          
        }
    }
}