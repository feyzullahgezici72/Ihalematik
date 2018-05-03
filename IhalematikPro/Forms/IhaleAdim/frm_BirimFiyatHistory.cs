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
using System.Diagnostics;
using IhalematikProUI.Manager;
using IhalematikProBL.Manager;

namespace IhalematikProUI.Forms.IhaleAdim
{
    public partial class frm_BirimFiyatHistory : DevExpress.XtraEditors.XtraForm
    {
        public frm_BirimFiyatHistory()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_BirimFiyatHistory_Shown(object sender, EventArgs e)
        {
            if (UICurrentManager.Instance.CurrentTender != null)
            {
                lblTenderDescription.Text = UICurrentManager.Instance.CurrentTender.Description;
                lblTenderNumber.Text = UICurrentManager.Instance.CurrentTender.DisplayNumber;
                List<MaterialList> items = UICurrentManager.Instance.CurrentTender.MaterialList;
                if (items != null)
                {
                    List<MaterialListModel> models = IhalematikModelBase.GetModels<MaterialListModel, MaterialList>(items);

                    grdMaterialListHistory.DataSource = models;
                } 
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                bool isSuccess = UIReportManager.Instance.ExtractExcel(grdMaterialListHistory);
                if (!isSuccess)
                {
                    MessageBox.Show("Program beklenmeyen bir hata ile karşılaştı.");
                }
            }
            catch (Exception ex)
            {
                LoggingManager.Instance.SaveErrorLog(ex);
            }
        }
    }
}