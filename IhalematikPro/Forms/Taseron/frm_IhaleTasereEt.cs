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

namespace IhalematikProUI.Forms.Taseron
{
    public partial class frm_IhaleTasereEt : DevExpress.XtraEditors.XtraForm
    {
        public frm_IhaleTasereEt()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void barTumIsMalzemeEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnIsMalzemeEkle_Click(object sender, EventArgs e)
        {
            frm_IsMalzemeEkle ImEkle = new frm_IsMalzemeEkle(this);
            ImEkle.ShowDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frm_IsMalzemeEkle ime = new frm_IsMalzemeEkle(this);
            ime.ShowDialog();
        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            JobberTender jobberTender = UICurrentManager.Instance.CurrentJobberTender;
            jobberTender.JobName = txtJobName.Text;
            jobberTender.JobDescription = memoEditJobDescription.Text;
            double contractPrice = double.Parse(txtContractPrice.Text.Replace("TL", string.Empty));
            jobberTender.ContractPrice = contractPrice;
            jobberTender.ContractDate = dateTimeContractDate.DateTime;
            jobberTender.StartJobDate = dateTimeStartDate.DateTime;
            jobberTender.EndJobDate = dateTimeEndDate.DateTime;

            JobberTenderProvider.Instance.Save(jobberTender);
        }

        public void LoadTenderMaterialList()
        {
            List<JobberMaterialList> items = UICurrentManager.Instance.CurrentJobberTender.MaterialList;
            List<MaterialListModel> dataSource = IhalematikModelBase.GetModels<MaterialListModel, MaterialList>(items.Select(p => p.MaterialList).ToList()).ToList();
            //  grdAddedJobberMaterialList.DataSource = dataSource;
            grdMaterialList.DataSource = dataSource;
        }

        private void frm_IhaleTasereEt_Shown(object sender, EventArgs e)
        {
            this.LoadTenderMaterialList();

            JobberTender jobberTender = UICurrentManager.Instance.CurrentJobberTender;
            txtJobName.Text = jobberTender.JobName;
            memoEditJobDescription.Text = jobberTender.JobDescription;
            //double contractPrice = double.Parse(txtContractPrice.Text.Replace("TL", string.Empty));
            txtContractPrice.Text = jobberTender.ContractPrice.ToString();
            if (jobberTender.ContractDate.HasValue)
            {
                dateTimeContractDate.DateTime = jobberTender.ContractDate.Value;
            }
            if (jobberTender.StartJobDate.HasValue)
            {
                dateTimeStartDate.DateTime = jobberTender.StartJobDate.Value;
            }
            if (jobberTender.EndJobDate.HasValue)
            {
                dateTimeEndDate.DateTime = jobberTender.EndJobDate.Value;
            }
        }
    }
}