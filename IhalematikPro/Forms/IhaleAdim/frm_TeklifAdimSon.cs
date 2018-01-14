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
using IhalematikPro.Manager;
using IhalematikPro.Model;
using IhalematikProBL.Entity;
using IhalematikProUI.Report;
using IhalematikProUI.Model;
using DevExpress.XtraReports.UI;
using System.Threading;
using IhalematikProUI.Forms.Base;
using IhalematikPro.Forms;
using IhalematikProBL.Provider;
//using IhalematikProUI.Report;

namespace IhalematikProUI.Forms
{
    public partial class frm_TeklifAdimSon : IhalematikBaseForm
    {
        public List<MaterialListModel> DataSource { get; set; }

        private double TotalMarkupNonKDV = 0;

        private double OtherTotalAmount = 0;
        public frm_TeklifAdimSon()
        {
            InitializeComponent();
            base.ScreenMethod();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_Anaform af = (frm_Anaform)Application.OpenForms["frm_Anaform"];
            af.RibonAktif();
        }

        private void CalculateFooterInnerValues(List<MaterialListModel> models)
        {
            if (models == null)
            {
                models = grdMaterialList.DataSource as List<MaterialListModel>;
            }
            this.TotalMarkupNonKDV = 0;
            double materialCostAmount = 0; // Malzeme Maliyet fiyat
            double materialkdvTotalAmount = 0; // Malzeme Toplam KDV
            double totalAmount = 0; // Malzeme Toplam Fiyat
            double workerCostAmount = 0; // Malzeme Maliyet fiyat

            //Kar Toplamlari
            double markupMaterialAmount = 0;
            double markupWorkerAmount = 0;

            //KDV haric toplam kar

            if (ddlCalculateWorkerType.SelectedIndex == 0)
            {
                foreach (MaterialListModel item in models)
                {
                    materialCostAmount += item.PozOBF.UnitPrice * item.Quantity;
                    materialkdvTotalAmount += item.KDVAmount;
                    workerCostAmount += item.WorkerUnitPrice * item.Quantity;
                    markupMaterialAmount += item.UnitMarkup * item.Quantity; ;
                    markupWorkerAmount += item.WorkerUnitPrice * item.Quantity * (item.Markup / 100);
                    TotalMarkupNonKDV += item.TotalFare;
                }
            }
            else
            {
                foreach (MaterialListModel item in models)
                {
                    materialCostAmount += item.PozOBF.UnitPrice * item.Quantity;
                    materialkdvTotalAmount += item.KDVAmount;
                    workerCostAmount += item.CustomWorkerUnitPrice * item.Quantity;
                    markupMaterialAmount += item.UnitMarkup * item.Quantity; ;
                    markupWorkerAmount += item.CustomWorkerUnitPrice * item.Quantity * (item.Markup / 100);
                    TotalMarkupNonKDV += item.CustomTotalFare;
                }
            }
            totalAmount = materialCostAmount + materialkdvTotalAmount;
            txtMaterialCostAmount.Text = materialCostAmount.ToString("c2");
            txtMaterialkdvTotalAmount.Text = materialkdvTotalAmount.ToString("c2");
            txtTotalAmount.Text = totalAmount.ToString("c2");
            txtWorkerCostAmount.Text = workerCostAmount.ToString("c2");
            txtWorkerKDVAmount.Text = 0.ToString("c2");
            txtWorkerAmount.Text = workerCostAmount.ToString("c2");
            txtMarkupMaterialTotal.Text = markupMaterialAmount.ToString("c2");
            txtMarkupWorkerAmount.Text = markupWorkerAmount.ToString("c2");
            txtMarkupAmount.Text = (markupWorkerAmount + markupMaterialAmount).ToString("c2");

            lblTotalMarkupNonKDV.Text = this.TotalMarkupNonKDV.ToString("c2");
        }

        private void btnObfKayit_Click(object sender, EventArgs e)
        {
            MainReport ms = new MainReport();


            List<ReportModel> models = new List<ReportModel>();
            List<MaterialList> items = CurrentManager.Instance.CurrentTender.MaterialList;
            List<MaterialListModel> materialModels = grdMaterialList.DataSource as List<MaterialListModel>; //IhalematikModelBase.GetModels<MaterialListModel, MaterialList>(items);
            double totalAmount = 0;
            if (materialModels != null)
            {
                int i = 1;
                foreach (var item in materialModels)
                {
                    ReportModel model = new ReportModel();
                    model.Description = item.PozOBFDescription;
                    model.PozOBFNumber = item.PozOBFNumber;
                    model.ItemNumber = i.ToString();
                    model.Quantity = item.Quantity.ToString();
                    totalAmount += Math.Round((item.MarkupUnitPrice + item.WorkerUnitPrice) * item.Quantity, 2);
                    model.Total = Math.Round(item.OtherTotalFare, 2).ToString("c2");
                    model.Unit = item.PozOBFUnit;
                    model.UnitPrice = item.OtherUnitTotalFare.ToString("C2");
                    models.Add(model);
                    i++;
                }
            }

            WrapperReportModel reportModel = new WrapperReportModel();
            reportModel.Items = models;
            reportModel.TenderNumber = CurrentManager.Instance.CurrentTender.Number.ToString();
            reportModel.TotalAmount = totalAmount.ToString("c2");
            ms.DataSource = reportModel;

            ReportPrintTool tool = new ReportPrintTool(ms);
            ms.ShowPreview();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TenderProvider.Instance.Save(CurrentManager.Instance.CurrentTender);
            
            frm_MesajFormu mf = new frm_MesajFormu();
            mf.lblMesaj.Text = "İhale Kaydedildi...";
            mf.ShowDialog();
        }

        private void frm_TeklifAdimSon_Shown(object sender, EventArgs e)
        {
            Tender currentTender = CurrentManager.Instance.CurrentTender;
            txtCarriage.Text = currentTender.Carriage.ToString("c");
            txtAccountingCosts.Text = currentTender.AccountingCosts.ToString("c");
            chckCompletionBond.Checked = currentTender.CompletionBond;
            chckProvisionalBond.Checked = currentTender.ProvisionalBond;

            lblTenderDescription.Text = CurrentManager.Instance.CurrentTender.Description;
            lblTenderNumber.Text = CurrentManager.Instance.CurrentTender.DisplayNumber;
            List<MaterialList> items = CurrentManager.Instance.CurrentTender.MaterialList;
            this.DataSource = IhalematikModelBase.GetModels<MaterialListModel, MaterialList>(items);
            this.TotalMarkupNonKDV = this.DataSource.Sum(p => p.TotalFare);
            grdMaterialList.DataSource = this.DataSource;

            this.CalculateFooterInnerValues(this.DataSource);
            this.CalculateLeftPanelValues();
            colOtherTotalFare.Visible = false;
            colOtherUnitTotalFare.Visible = false;

            colUnitTotalFare.Visible = true;
            colTotalFare.Visible = true;

        }

        private void CalculateLeftPanelValues()
        {
            Tender tender = CurrentManager.Instance.CurrentTender;
            isciAracGirisPaneli.Visible = true;
            txtTenderNumber.Text = string.Format("{0}", (tender.Number).ToString().PadLeft(8, '0'));
            txtTenderDescription.Text = tender.Description;
            txtTenderLastOfferDate.Text = tender.LastOfferDate.Value.ToShortDateString();
            txtTenderNearlyTotalAmount.Text = tender.NearlyTotalAmount.ToString("c");
            txtMaterialCount.Text = tender.MaterialList.Count().ToString();
            txtMaterialIsNonWorkshipcount.Text = tender.MaterialList.Where(p => !p.IsWorkship).Count().ToString();
            txtMaterialWorksipCount.Text = tender.MaterialList.Where(p => p.IsWorkship).Count().ToString();
            txtMaterialTotalAmount.Text = txtMaterialCostAmount.Text;
            txtWorkerTotalAmount.Text = txtWorkerCostAmount.Text;
            txtTotalMaterialAndWorkerAmount.Text = (double.Parse(txtWorkerCostAmount.Text.Replace("TL", "")) + double.Parse(txtMaterialTotalAmount.Text.Replace("TL", ""))).ToString("c");
            txtGeneralMarkupWorkerAmount.Text = txtMarkupWorkerAmount.Text;
            txtTotalMarkupAmount.Text = txtMarkupAmount.Text;

            txtOfferTotalAmount.Text = (double.Parse(txtTotalMaterialAndWorkerAmount.Text.Replace("TL", "")) + double.Parse(txtGeneralMarkupWorkerAmount.Text.Replace("TL", "")) + double.Parse(txtTotalMarkupAmount.Text.Replace("TL", ""))).ToString("c");

            txtKirim.Text = (tender.NearlyTotalAmount - double.Parse(txtOfferTotalAmount.Text.Replace("TL", ""))).ToString("c");
        }


        private void btnTumuneUygula_Click(object sender, EventArgs e)
        {
            Tender currentTender = CurrentManager.Instance.CurrentTender;
            IhalematikProBL.Entity.Rule provisionalBond = RuleProvider.Instance.GetItems("Code", "ProvisionalBond").FirstOrDefault();
            IhalematikProBL.Entity.Rule completionBond = RuleProvider.Instance.GetItems("Code", "CompletionBond").FirstOrDefault();
            double carriage = double.Parse(string.IsNullOrEmpty(txtCarriage.Text) ? "0" : txtCarriage.Text.Replace("TL", string.Empty));
            double accountingCosts = double.Parse(string.IsNullOrEmpty(txtAccountingCosts.Text) ? "0" : txtAccountingCosts.Text.Replace("TL", string.Empty));

            currentTender.Carriage = carriage;
            currentTender.AccountingCosts = accountingCosts;
            currentTender.CompletionBond = chckCompletionBond.Checked;
            currentTender.ProvisionalBond = chckProvisionalBond.Checked;

            if (!chckCompletionBond.Checked)
            {
                completionBond.Value = "0";
            }
            if (!chckProvisionalBond.Checked)
            {
                provisionalBond.Value = "0";
            }

            this.OtherTotalAmount = (this.TotalMarkupNonKDV * SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(provisionalBond.Value) / 100) + (this.TotalMarkupNonKDV * SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(completionBond.Value) / 100) + carriage + accountingCosts;

            double increaseAmount = Math.Round((this.OtherTotalAmount / this.TotalMarkupNonKDV), 2);
            //birim fiyat unittotalFare
            //Toplam fiyat TotalFare
            foreach (MaterialListModel item in this.DataSource)
            {
                double increaseOtherFare = Math.Round(((increaseAmount * item.TotalFare) / item.Quantity), 2);
                if (ddlCalculateWorkerType.SelectedIndex == 1)
                {
                    item.OtherUnitTotalFare = Math.Round((item.CustomUnitTotalFare + increaseOtherFare), 2);
                }
                else
                {
                    item.OtherUnitTotalFare = Math.Round((item.UnitTotalFare + increaseOtherFare), 2);
                }
            }

            grdMaterialList.DataSource = null;
            grdMaterialList.DataSource = this.DataSource;
            colOtherUnitTotalFare.Visible = true;
            colOtherTotalFare.Visible = true;
            colTotalFare.Visible = false;
            colUnitTotalFare.Visible = false;

            lblTotalMarkupNonKDV.Text = Math.Round((this.TotalMarkupNonKDV + this.OtherTotalAmount), 2).ToString("c2");
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("calc.exe");
            }
            catch (Exception)
            {

                MessageBox.Show("Hesap Makinesi Yüklü değil...");
            }
        }

        private void ddlCalculateWorkerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlCalculateWorkerType.SelectedIndex == 0)
            {
                colUnitTotalFare.VisibleIndex = 4;
                colTotalFare.VisibleIndex = 5;
                colUnitTotalFare.Visible = true;
                colTotalFare.Visible = true;

                colCustomUnitTotalFare.Visible = false;
                colCustomTotalFare.Visible = false;
            }
            else
            {
                colCustomUnitTotalFare.VisibleIndex = 4;
                colCustomTotalFare.VisibleIndex = 5;
                colUnitTotalFare.Visible = false;
                colTotalFare.Visible = false;

                colCustomUnitTotalFare.Visible = true;
                colCustomTotalFare.Visible = true;



            }
            this.CalculateFooterInnerValues(null);
        }

        private void frm_TeklifAdimSon_Load(object sender, EventArgs e)
        {

        }
    }
}