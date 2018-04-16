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
using IhalematikProUI.Forms.IhaleAdim;
using IhalematikProUI.Forms.Genel;
using IhalematikProBL.Enum;
using IhalematikProUI.Manager;
using System.Diagnostics;
using IhalematikProBL.Manager;
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
            this.Enabled = false;
            LoadingManager.Instance.Show(this);
            if (CurrentManager.Instance.CurrentTender != null)
            {
                Tender currentTender = CurrentManager.Instance.CurrentTender;
                txtCarriage.Text = currentTender.Carriage.ToString("c2");
                txtAccountingCosts.Text = currentTender.AccountingCosts.ToString("c2");
                //chckCompletionBond.Checked = currentTender.CompletionBond;
                //chckProvisionalBond.Checked = currentTender.ProvisionalBond;

                lblTenderDescription.Text = CurrentManager.Instance.CurrentTender.Description;
                lblTenderNumber.Text = CurrentManager.Instance.CurrentTender.DisplayNumber;

                this.OtherExpenses();
                this.LoadGrid();
                this.CalculateMaterialListEquipment();
                colUnitTotalFare.Visible = true;
                colTotalFare.Visible = true;
            }
            LoadingManager.Instance.Hide(); ;
            this.Enabled = true;
        }

        private void CalculateMaterialListEquipment()
        {
            List<TenderMaterialListEquipment> items = TenderMaterialListEquipmentProvider.Instance.GetItems("TenderId", CurrentManager.Instance.CurrentTender.Id);

            double totalWorkerHour = 0;
            double totalVehicleHour = 0;
            double totalHour = 0;

            double dayPerMonthValue = UIRuleManager.Instance.DayPerMonthValue;
            double hourPerDayValue = UIRuleManager.Instance.HourPerDayValue;

            if (items != null && items.Count != 0)
            {
                foreach (var item in items)
                {
                    totalHour = 0;
                    switch (item.UnitTimeType)
                    {
                        case UnitTimeTypesEnum.Minute:
                            totalHour += Math.Round(item.UnitTime / 60 * item.Quantity * item.MaterialList.Quantity, 3);
                            break;
                        case UnitTimeTypesEnum.Hour:
                            totalHour += item.UnitTime * item.Quantity * item.MaterialList.Quantity;
                            break;
                        case UnitTimeTypesEnum.Day:
                            totalHour += Math.Round(item.UnitTime * hourPerDayValue * item.Quantity * item.MaterialList.Quantity, 3);
                            break;
                        case UnitTimeTypesEnum.Week:
                            totalHour += Math.Round(item.UnitTime * hourPerDayValue * 7 * item.Quantity * item.MaterialList.Quantity, 3);
                            break;
                        case UnitTimeTypesEnum.Month:
                            totalHour += Math.Round(item.UnitTime * hourPerDayValue * dayPerMonthValue * item.Quantity * item.MaterialList.Quantity, 3);
                            break;
                        case UnitTimeTypesEnum.Year:
                            totalHour += Math.Round(item.UnitTime * hourPerDayValue * dayPerMonthValue * 12 * item.Quantity * item.MaterialList.Quantity, 3);
                            break;
                        default:
                            break;
                    }
                    if (item.Equipment.IsWorker)
                    {
                        totalWorkerHour += totalHour;
                    }
                    else
                    {
                        totalVehicleHour += totalHour;
                    }
                }
                txtToplamAdamSaat.Text = Math.Round(totalWorkerHour, 2).ToString();
                txtToplamAracSaat.Text = Math.Round(totalVehicleHour, 2).ToString();
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
            //txtTenderNumber.Text = string.Format("{0}", (tender.Number).ToString().PadLeft(8, '0'));
            //txtTenderDescription.Text = tender.Description;
            //txtTenderLastOfferDate.Text = tender.LastOfferDate.Value.ToShortDateString();
            //txtTenderNearlyTotalAmount.Text = tender.NearlyTotalAmount.ToString("c2");
            //txtMaterialCount.Text = tender.MaterialList.Count().ToString();
            //txtMaterialIsNonWorkshipcount.Text = tender.MaterialList.Where(p => !p.IsWorkship).Count().ToString();
            //txtMaterialWorksipCount.Text = tender.MaterialList.Where(p => p.IsWorkship).Count().ToString();
            //txtMaterialTotalAmount.Text = txtMaterialCostAmount.Text;
            //txtWorkerTotalAmount.Text = txtWorkerCostAmount.Text;
            //txtTotalMaterialAndWorkerAmount.Text = (double.Parse(txtWorkerCostAmount.Text.Replace("TL", "")) + double.Parse(txtMaterialTotalAmount.Text.Replace("TL", ""))).ToString("c2");
            //txtGeneralMarkupWorkerAmount.Text = txtMarkupWorkerAmount.Text;
            //txtTotalMarkupAmount.Text = txtMarkupAmount.Text;

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


            #region LeftPanelValues
            this.TotalMarkupNonKDV = 0;
            double materialCostAmount = 0; // Malzeme Maliyet fiyat
            double materialkdvTotalAmount = 0; // Malzeme Toplam KDV
            double totalAmount = 0; // Malzeme Toplam Fiyat
            double workerCostAmount = 0; // Malzeme Maliyet fiyat
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

                this.TotalMarkupNonKDV += item.TotalFarePreview;
                materialCostAmount += item.PozOBFUnitPrice * item.Quantity;
                materialkdvTotalAmount += item.KDVAmount;
                workerCostAmount += item.CustomWorkerTotalAmount;
                markupMaterialAmount += item.UnitMarkup * item.Quantity; ;
                markupWorkerAmount += item.TotalCustomWorkerMarkupPrice;// * (item.Markup / 100);
                totalPersonHour += Math.Round(item.TotalWorkerMarkup, 2);
                totalUnitPrice += Math.Round(item.TotalCustomWorkerMarkupPrice, 2);
            }

            #region LeftPanelValues
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
            //txtMarkupAmount.Text = (markupWorkerAmount + markupMaterialAmount).ToString("c2");
            txtTotalPersonHour.Text = totalPersonHour.ToString("c2");
            txtTotalUnitPrice.Text = totalUnitPrice.ToString("c2");
            txtDifference.Text = Math.Round((totalPersonHour - totalUnitPrice), 2).ToString("c2");
            lblTotalMarkupNonKDV.Text = this.TotalMarkupNonKDV.ToString("c2");
            //txtPanelMarkupMaterialTotal.Text = txtMarkupMaterialTotal.Text; // a.samet ekledi

            #endregion
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

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                bool isSuccess = UIReportManager.Instance.ExtractExcel(grdMaterialList);
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

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}