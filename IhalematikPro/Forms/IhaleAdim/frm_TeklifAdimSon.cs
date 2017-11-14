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
//using IhalematikProUI.Report;

namespace IhalematikProUI.Forms
{
    public partial class frm_TeklifAdimSon : DevExpress.XtraEditors.XtraForm
    {
        public frm_TeklifAdimSon()
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

        private void frm_TeklifSonAdim_Load(object sender, EventArgs e)
        {
            lblTenderDescription.Text = CurrentManager.Instance.CurrentTender.Description;
            lblTenderNumber.Text = CurrentManager.Instance.CurrentTender.DisplayNumber;
            List<MaterialList> items = UIMaterialListManager.Instance.GetMaterialListIsWorkship();
            List<MaterialListModel> models = IhalematikModelBase.GetModels<MaterialListModel, MaterialList>(items);

            grdMaterialList.DataSource = models;

            double materialCostAmount = 0; // Malzeme Maliyet fiyat
            double materialkdvTotalAmount = 0; // Malzeme Toplam KDV
            double totalAmount = 0; // Malzeme Toplam Fiyat
            double workerCostAmount = 0; // Malzeme Maliyet fiyat

            //Kar Toplamlari
            double markupMaterialAmount = 0;
            double markupWorkerAmount = 0;

            //KDV haric toplam kar
            double totalMarkupNonKDV = 0;

            foreach (MaterialListModel item in models)
            {
                materialCostAmount += item.PozOBF.UnitPrice * item.Quantity;
                materialkdvTotalAmount += item.KDVAmount;
                workerCostAmount += item.WorkerUnitPrice * item.Quantity;
                markupMaterialAmount += item.MarkupUnitPrice * item.Quantity; ;
                markupWorkerAmount += item.WorkerUnitPrice * item.Quantity * (item.Markup / 100);
                totalMarkupNonKDV += item.TotalFare;
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

            lblTotalMarkupNonKDV.Text = totalMarkupNonKDV.ToString("c2");
        }

        private void btnObfKayit_Click(object sender, EventArgs e)
        {
            MainReport ms = new MainReport();

            List<ReportModel> models = new List<ReportModel>();
            List<MaterialList> items = CurrentManager.Instance.CurrentTender.MaterialList;
            List<MaterialListModel> materialModels = IhalematikModelBase.GetModels<MaterialListModel, MaterialList>(items);
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
                    model.Total = Math.Round((item.MarkupUnitPrice + item.WorkerUnitPrice) * item.Quantity, 2).ToString("c2");
                    model.Unit = item.PozOBFUnit;
                    model.UnitPrice = item.PozOBFUnitPrice.ToString("C2");
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

        //private void Rapor_Click(object sender, EventArgs e)
        //{
        //    //MainReportcs.
        //}
    }
}