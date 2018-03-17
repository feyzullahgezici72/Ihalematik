﻿using System;
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
using IhalematikProUI.Forms.IhaleAdim;
using IhalematikProUI.Forms.Genel;
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


            double totalPersonHour = 0;
            double totalUnitPrice = 0;

            if (models != null)
            {
                foreach (MaterialListModel item in models)
                {
                    materialCostAmount += item.PozOBFUnitPrice * item.Quantity;
                    materialkdvTotalAmount += item.KDVAmount;
                    workerCostAmount += item.CustomWorkerTotalAmount;
                    markupMaterialAmount += item.UnitMarkup * item.Quantity; ;
                    markupWorkerAmount += item.TotalCustomWorkerMarkupPrice;// * (item.Markup / 100);
                    TotalMarkupNonKDV += item.TotalFarePreview;
                    totalPersonHour += Math.Round(item.TotalWorkerMarkup, 2);
                    totalUnitPrice += Math.Round(item.TotalCustomWorkerMarkupPrice, 2);
                }
            }

            totalAmount = materialCostAmount + materialkdvTotalAmount;
            txtMaterialCostAmount.Text = materialCostAmount.ToString("c2");
            txtMaterialkdvTotalAmount.Text = materialkdvTotalAmount.ToString("c2");
            txtTotalAmount.Text = totalAmount.ToString("c2");
            txtWorkerCostAmount.Text = workerCostAmount.ToString("c2");
            double workerMarkupAmount = Math.Round((workerCostAmount * 18 / 100), 2);
            txtWorkerKDVAmount.Text = workerMarkupAmount.ToString("c2");
            txtWorkerAmount.Text = (workerMarkupAmount + workerCostAmount).ToString("c2");
            txtMarkupMaterialTotal.Text = markupMaterialAmount.ToString("c2");
            txtMarkupWorkerAmount.Text = markupWorkerAmount.ToString("c2");
            txtMarkupAmount.Text = (markupWorkerAmount + markupMaterialAmount).ToString("c2");
            txtTotalPersonHour.Text = totalPersonHour.ToString("c2");
            txtTotalUnitPrice.Text = totalUnitPrice.ToString("c2");
            txtDifference.Text = Math.Round((totalPersonHour - totalUnitPrice), 2).ToString("c2");
            lblTotalMarkupNonKDV.Text = this.TotalMarkupNonKDV.ToString("c2");
            txtPanelMarkupMaterialTotal.Text = txtMarkupMaterialTotal.Text; // a.samet ekledi
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
                    totalAmount += Math.Round(item.TotalFarePreview, 2);
                    model.Total = Math.Round(item.TotalFarePreview, 2).ToString("c2");
                    model.Unit = item.PozOBFUnit;
                    model.UnitPrice = item.UnitTotalFarePreview.ToString("C2");
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
            if (ddlCalculateWorkerType.SelectedIndex == 0)
            {
                CurrentManager.Instance.CurrentTender.PersonHour = true;
            }
            else
            {
                CurrentManager.Instance.CurrentTender.PersonHour = false;
            }

            foreach (var item in CurrentManager.Instance.CurrentTender.MaterialList)
            {
                MaterialListProvider.Instance.Save(item);
            }

            TenderProvider.Instance.Save(CurrentManager.Instance.CurrentTender);

            frm_MesajFormu mf = new frm_MesajFormu();
            mf.lblMesaj.Text = "İhale Kaydedildi...";
            mf.ShowDialog();
        }

        private void frm_TeklifAdimSon_Shown(object sender, EventArgs e)
        {
            frm_yukleniyor yukle = new frm_yukleniyor();
            yukle.ShowDialog();

            if (CurrentManager.Instance.CurrentTender != null)
            {
                Tender currentTender = CurrentManager.Instance.CurrentTender;
                txtCarriage.Text = currentTender.Carriage.ToString("c2");
                txtAccountingCosts.Text = currentTender.AccountingCosts.ToString("c2");
                chckCompletionBond.Checked = currentTender.CompletionBond;
                chckProvisionalBond.Checked = currentTender.ProvisionalBond;

                if (currentTender.PersonHour)
                {
                    ddlCalculateWorkerType.SelectedIndex = 0;
                }
                else
                {
                    ddlCalculateWorkerType.SelectedIndex = 1;
                }

                lblTenderDescription.Text = CurrentManager.Instance.CurrentTender.Description;
                lblTenderNumber.Text = CurrentManager.Instance.CurrentTender.DisplayNumber;

                this.OtherExpenses();
                this.LoadGrid();
                //this.CalculateFooterInnerValues(null);
                //this.CalculateLeftPanelValues();

                colUnitTotalFare.Visible = true;
                colTotalFare.Visible = true;
            }
        }

        public void OtherExpenses()
        {
            List<OtherExpenses> otherExpenses = OtherExpensesProvider.Instance.GetItems("TenderId", CurrentManager.Instance.CurrentTender.Id);
            //if (otherExpenses.Count != 0)
            //{
            txtOtherCoast.Text = otherExpenses.Sum(p => p.Price).ToString("c2");
            //}
        }

        private void CalculateLeftPanelValues()
        {
            Tender tender = CurrentManager.Instance.CurrentTender;
            isciAracGirisPaneli.Visible = true;
            txtTenderNumber.Text = string.Format("{0}", (tender.Number).ToString().PadLeft(8, '0'));
            txtTenderDescription.Text = tender.Description;
            txtTenderLastOfferDate.Text = tender.LastOfferDate.Value.ToShortDateString();
            txtTenderNearlyTotalAmount.Text = tender.NearlyTotalAmount.ToString("c2");
            txtMaterialCount.Text = tender.MaterialList.Count().ToString();
            txtMaterialIsNonWorkshipcount.Text = tender.MaterialList.Where(p => !p.IsWorkship).Count().ToString();
            txtMaterialWorksipCount.Text = tender.MaterialList.Where(p => p.IsWorkship).Count().ToString();
            txtMaterialTotalAmount.Text = txtMaterialCostAmount.Text;
            txtWorkerTotalAmount.Text = txtWorkerCostAmount.Text;
            //txtTotalMaterialAndWorkerAmount.Text = (double.Parse(txtWorkerCostAmount.Text.Replace("TL", "")) + double.Parse(txtMaterialTotalAmount.Text.Replace("TL", ""))).ToString("c2");
            txtGeneralMarkupWorkerAmount.Text = txtMarkupWorkerAmount.Text;
            txtTotalMarkupAmount.Text = txtMarkupAmount.Text;

            //txtOfferTotalAmount.Text = (double.Parse(txtTotalMaterialAndWorkerAmount.Text.Replace("TL", "")) + double.Parse(txtGeneralMarkupWorkerAmount.Text.Replace("TL", "")) + double.Parse(txtTotalMarkupAmount.Text.Replace("TL", ""))).ToString("c2");

            //txtKirim.Text = (tender.NearlyTotalAmount - double.Parse(txtOfferTotalAmount.Text.Replace("TL", ""))).ToString("c2");
        }


        private void btnTumuneUygula_Click(object sender, EventArgs e)
        {
            this.LoadGrid();
        }

        private void LoadGrid()
        {
            List<MaterialList> items = CurrentManager.Instance.CurrentTender.MaterialList;

            this.DataSource = IhalematikModelBase.GetModels<MaterialListModel, MaterialList>(items);
            this.CalculateFooterInnerValues(this.DataSource);
            this.TotalMarkupNonKDV = this.DataSource.Sum(p => p.TotalFare);
            Tender currentTender = CurrentManager.Instance.CurrentTender;
            IhalematikProBL.Entity.Rule provisionalBond = RuleProvider.Instance.GetItems("Code", "ProvisionalBond").FirstOrDefault();
            IhalematikProBL.Entity.Rule completionBond = RuleProvider.Instance.GetItems("Code", "CompletionBond").FirstOrDefault();
            IhalematikProBL.Entity.Rule tradingStamps = RuleProvider.Instance.GetItems("Code", "TradingStamps").FirstOrDefault();

            double carriage = double.Parse(string.IsNullOrEmpty(txtCarriage.Text) ? "0" : txtCarriage.Text.Replace("TL", string.Empty));
            double accountingCosts = (this.TotalMarkupNonKDV * SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(provisionalBond.Value) / 1000) + (this.TotalMarkupNonKDV * SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(completionBond.Value) / 1000) +
                (this.TotalMarkupNonKDV * SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(tradingStamps.Value) / 1000);

            txtAccountingCosts.Text = accountingCosts.ToString("c2");

            double otherCosts = double.Parse(string.IsNullOrEmpty(txtOtherCoast.Text) ? "0" : txtOtherCoast.Text.Replace("TL", string.Empty));

            currentTender.Carriage = carriage;
            currentTender.AccountingCosts = accountingCosts;
            //currentTender.CompletionBond = chckCompletionBond.Checked;
            //currentTender.ProvisionalBond = chckProvisionalBond.Checked;
            //currentTender.PersonHour = ddlCalculateWorkerType.SelectedIndex == 0 ? true : false;


            this.OtherTotalAmount = accountingCosts + otherCosts;

            double increaseAmount = (this.OtherTotalAmount / this.TotalMarkupNonKDV);


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
            this.TotalMarkupNonKDV = 0;
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
                this.TotalMarkupNonKDV += item.TotalFarePreview;
            }

            grdMaterialList.DataSource = null;
            grdMaterialList.DataSource = this.DataSource;

            lblTotalMarkupNonKDV.Text = this.TotalMarkupNonKDV.ToString("c2");

            TenderProvider.Instance.Save(currentTender);
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
            //this.LoadGrid();
           // this.CalculateFooterInnerValues(null);
        }

        private void frm_TeklifAdimSon_Load(object sender, EventArgs e)
        {
            btnPrev.Left = groupControl1.Left - btnPrev.Width - 5;
        }

        private void txtCarriage_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frm_Nakliye nakliye = new frm_Nakliye(this);
            nakliye.ShowDialog();
        }
        public void SetCarriageValue()
        {
            txtCarriage.Text = CurrentManager.Instance.CurrentTender.Carriage.ToString("c2");
        }

        private void groupControl5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtOtherCoast_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frm_DigerGiderler digergiderler = new frm_DigerGiderler(this);
            digergiderler.ShowDialog();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_Anaform af = (frm_Anaform)Application.OpenForms["frm_Anaform"];
            af.RibonPasif();
            af.btnAdimx3.PerformClick();
        }

        private void grdMaterialList_Click(object sender, EventArgs e)
        {

        }
    }
}