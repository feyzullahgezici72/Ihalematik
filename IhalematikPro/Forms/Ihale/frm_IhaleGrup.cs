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
using IhalematikProUI.Model;
using IhalematikProBL.Entity;
using IhalematikProBL.Provider;
using IhalematikPro.Model;
using IhalematikPro.Manager;

namespace IhalematikProUI.Forms
{
    public partial class frm_IhaleGrup : DevExpress.XtraEditors.XtraForm
    {
        public frm_IhaleGrup()
        {
            InitializeComponent();
            bindingSourceTenderGroup.DataSource = typeof(List<TenderGroupModel>);
            grdTenderGroup.DataSource = bindingSourceTenderGroup;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {

            if (CurrentManager.Instance.CurrentTender.Groups == null || CurrentManager.Instance.CurrentTender.Groups.Count == 0)
            {
                TenderGroup item = new TenderGroup();
                item.Description = "Genel Grup";
                item.Tender = CurrentManager.Instance.CurrentTender;
                TenderGroupProvider.Instance.Save(item);
            }

            this.Close();
        }

        private void btnGuncelle_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frm_IhaleGrupGuncelle ig = new frm_IhaleGrupGuncelle();
            ig.ShowDialog();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTenderGroupDescription.Text))
            {
                TenderGroup item = new TenderGroup();
                item.Description = txtTenderGroupDescription.Text;

                if (CurrentManager.Instance.CurrentTender.Groups != null)
                {
                    List<TenderGroup> existingItems = CurrentManager.Instance.CurrentTender.Groups.Where(p => p.Description.Trim() == item.Description.Trim()).ToList();
                    if (existingItems != null && existingItems.Count != 0)
                    {
                        frm_MesajFormu message = new frm_MesajFormu();
                        message.lblMesaj.Text = "Bu grup adi zaten var.";
                        message.ShowDialog();
                    }
                    else
                    {
                        item.Tender = CurrentManager.Instance.CurrentTender;
                        TenderGroupProvider.Instance.Save(item);
                        this.LoadGrid();
                        txtTenderGroupDescription.ResetText();
                        txtTenderGroupDescription.Focus();
                    }
                }
            }
        }

        private void frm_IhaleGrup_Load(object sender, EventArgs e)
        {
            txtTenderNumber.Text = CurrentManager.Instance.CurrentTender.DisplayNumber;
            txtTenderDescription.Text = CurrentManager.Instance.CurrentTender.Description;
            txtTenderCompanyName.Text = CurrentManager.Instance.CurrentTender.CompanyName;
            this.LoadGrid();
        }

        public void LoadGrid()
        {
            List<TenderGroup> items = TenderGroupProvider.Instance.GetItems("TenderId", CurrentManager.Instance.CurrentTender.Id);
            List<TenderGroupModel> models = IhalematikModelBase.GetModels<TenderGroupModel, TenderGroup>(items);
            int i = 1;
            foreach (var item in models)
            {
                item.ItemNumber = i;
                i++;
            }
            grdTenderGroup.DataSource = models;
        }
    }
}