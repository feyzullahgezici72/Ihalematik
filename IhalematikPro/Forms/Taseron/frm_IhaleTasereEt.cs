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
using IhalematikProUI.Manager;
using IhalematikProUI.Forms.Base;
using IhalematikProBL.Enum;
using IhalematikPro.Forms;

namespace IhalematikProUI.Forms.Taseron
{
    public partial class frm_IhaleTasereEt : IhalematikBaseForm
    {
        public List<MaterialListModel> DataSource { get; set; }

        private double TotalMarkupNonKDVPreview = 0;

        private double OtherTotalAmount = 0;

        public double OtherCost { get; set; }
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
            LoadingManager.Instance.Show(this);
            List<MaterialList> items = UICurrentManager.Instance.CurrentJobberTender.MaterialList.Select(p => p.MaterialList).ToList();
            Tender currentTender = UICurrentManager.Instance.CurrentJobberTender.Tender;

            this.DataSource = IhalematikModelBase.GetModels<MaterialListModel, MaterialList>(items);
            this.TotalMarkupNonKDVPreview = this.DataSource.Sum(p => p.TotalFare);
            //Tender currentTender = UICurrentManager.Instance.CurrentTender;
            IhalematikProBL.Entity.Rule provisionalBond = RuleProvider.Instance.GetItems("Code", "ProvisionalBond").FirstOrDefault();
            IhalematikProBL.Entity.Rule completionBond = RuleProvider.Instance.GetItems("Code", "CompletionBond").FirstOrDefault();
            IhalematikProBL.Entity.Rule tradingStamps = RuleProvider.Instance.GetItems("Code", "TradingStamps").FirstOrDefault();

            double KDVTefkifat = 0;
            double carriage = currentTender.Carriage; //double.Parse(string.IsNullOrEmpty(txtCarriage.Text) ? "0" : txtCarriage.Text.Replace("TL", string.Empty));
            double accountingCosts = 0;
            if (currentTender.TenderType == TenderTypeEnum.DirectSupply)
            {
                accountingCosts = (this.TotalMarkupNonKDVPreview * SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(completionBond.Value) / 100);
            }
            else
            {
                KDVTefkifat = this.TotalMarkupNonKDVPreview * 0.18 / 10 * 3;
                accountingCosts = (this.TotalMarkupNonKDVPreview * SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(provisionalBond.Value) / 100) + (this.TotalMarkupNonKDVPreview * SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(completionBond.Value) / 100) +
                    (this.TotalMarkupNonKDVPreview * SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(tradingStamps.Value) / 100) + KDVTefkifat;

            }

            List<OtherExpenses> otherExpenses = OtherExpensesProvider.Instance.GetItems("TenderId", currentTender.Id);
            this.OtherCost = otherExpenses.Sum(p => p.Price);

            double otherCosts = this.OtherCost; //double.Parse(string.IsNullOrEmpty(txtOtherCoast.Text) ? "0" : txtOtherCoast.Text.Replace("TL", string.Empty));

            currentTender.Carriage = carriage;
            currentTender.AccountingCosts = accountingCosts;
            this.OtherTotalAmount = accountingCosts + otherCosts;
            double increaseAmount = (this.OtherTotalAmount / this.TotalMarkupNonKDVPreview);
            double totalMarkupZeroCarriage = this.DataSource.Where(p => p.CarriagePercent == 0).Sum(p => p.TotalFare);
            double otherCarriageZeroAmountPercent = this.DataSource.Sum(p => p.CarriagePercent);
            double increaseZeroCarriage = (carriage * (100 - otherCarriageZeroAmountPercent) / 100 / totalMarkupZeroCarriage);
            double increaseCarriageAmount = (carriage / increaseZeroCarriage);

            if (carriage == 0)
            {
                increaseCarriageAmount = 0;
            }

            //birim fiyat unittotalFare
            //Toplam fiyat TotalFare
            this.TotalMarkupNonKDVPreview = 0;


            #region LeftPanelValues
            this.TotalMarkupNonKDVPreview = 0;
            double TotalMarkupNonKDV = 0;
            double materialCostAmount = 0; // Malzeme Maliyet fiyat
            double materialkdvTotalAmount = 0; // Malzeme Toplam KDV
            double totalAmount = 0; // Malzeme Toplam Fiyat
            double workerCostAmount = 0; // Malzeme Maliyet fiyat
            double totalRisk = 0; // RiskToplami;
            //Kar Toplamlari
            double markupMaterialAmount = 0;
            double markupWorkerAmount = 0;
            //Insan saat arac saat toplami
            double totalPersonHour = 0;
            double totalUnitPrice = 0;
            #endregion

            foreach (MaterialListModel item in this.DataSource)
            {
                double increaseOtherFare = 0;
                increaseOtherFare = ((increaseAmount * item.TotalFare) / item.Quantity);
                if (item.CarriagePercent == 0)
                {

                    increaseOtherFare += ((increaseZeroCarriage * item.TotalFare) / item.Quantity);
                    item.UnitTotalFarePreview = (item.UnitTotalFare + increaseOtherFare);
                }
                else
                {
                    increaseOtherFare += (item.CarriagePercent * carriage / 100 / item.Quantity);
                    item.UnitTotalFarePreview = (item.UnitTotalFare + increaseOtherFare);
                }

                this.TotalMarkupNonKDVPreview += item.TotalFarePreview;
                TotalMarkupNonKDV += item.TotalFare;
                materialCostAmount += item.PozOBFUnitPrice * item.Quantity;
                materialkdvTotalAmount += item.KDVAmount;
                workerCostAmount += item.CustomWorkerTotalAmount;
                markupMaterialAmount += item.UnitMarkup * item.Quantity; ;
                markupWorkerAmount += item.TotalCustomWorkerMarkupPrice;// * (item.Markup / 100);
                totalPersonHour += Math.Round(item.TotalWorkerMarkup, 2);
                totalUnitPrice += Math.Round(item.TotalCustomWorkerMarkupPrice, 2);
                totalRisk += Math.Round(item.UnitRisk * item.Quantity, 2);
            }

            LoadingManager.Instance.Hide();
            grdMaterialList.DataSource = null;
            grdMaterialList.DataSource = this.DataSource;

            totalAmount = materialCostAmount + materialkdvTotalAmount;

            txtMaterialCostAmount.Text = materialCostAmount.ToString("c2");
            txtWorkerCostAmount.Text = workerCostAmount.ToString("c2");
            txtAccountingCosts.Text = (accountingCosts - KDVTefkifat).ToString("c2");
            txtKDVTefkifat.Text = KDVTefkifat.ToString("c2");
            txtLeftPanelCarriage.Text = UICurrentManager.Instance.CurrentTender.Carriage.ToString("c2");
            //double otherCost = double.Parse(txtLeftPanelOtherCoast.Text);
            txtTotalAmount.Text = (materialCostAmount + workerCostAmount + accountingCosts + UICurrentManager.Instance.CurrentTender.Carriage + this.OtherCost).ToString("c2");
            double workerMarkupAmount = Math.Round((workerCostAmount * 18 / 100), 2);
            txtMarkupMaterialTotal.Text = markupMaterialAmount.ToString("c2");
            txtMarkupWorkerAmount.Text = markupWorkerAmount.ToString("c2");
            txtTotalRisk.Text = totalRisk.ToString("c2");
            txtTotalMarkupAmount.Text = (markupMaterialAmount + markupWorkerAmount + totalRisk).ToString("c2");

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