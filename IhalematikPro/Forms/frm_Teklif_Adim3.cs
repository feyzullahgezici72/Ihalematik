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
using IhalematikProBL.Entity;
using IhalematikPro.Manager;
using IhalematikPro.Model;
using DevExpress.XtraEditors.Repository;
using System.Reflection;
using System.Dynamic;
using System.Threading;
using System.Reflection.Emit;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.BandedGrid;
using IhalematikProUI.Model;
using IhalematikProBL.Enum;
using IhalematikProBL.Provider;
using IhalematikProUI.Forms;

namespace IhalematikPro.Forms
{
    public partial class frm_Teklif_Adim3 : DevExpress.XtraEditors.XtraForm
    {
        public frm_Teklif_Adim3()
        {
            InitializeComponent();

            grdMaterialListIsWorkship.AutoGenerateColumns = false;

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "PozOBFDescription";
            column.Name = "AÇIKLAMA";
            column.ReadOnly = true;
            column.Width = 340;
            grdMaterialListIsWorkship.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Quantity";
            column.Name = "MİKTAR";
            column.ReadOnly = true;
            grdMaterialListIsWorkship.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "UnitTime";
            column.Name = "UnitTime";
            column.HeaderText = "BIRIM SURE";
            column.ReadOnly = false;
            grdMaterialListIsWorkship.Columns.Add(column);

            column = new DataGridViewComboBoxColumn { DataSource = GetUnitTimes(), ValueMember = "Self", DisplayMember = "DisplayText" };
            column.DataPropertyName = "UnitTimeType";
            column.Name = "UnitTimeType";
            column.HeaderText = "Zaman Tipi";
            column.ReadOnly = false;
            column.ValueType = typeof(UnitTimeTypesModel);
            grdMaterialListIsWorkship.Columns.Add(column);


            if (CurrentManager.CurrentTender.Equipments != null)
            {
                List<TenderEquipment> equipmentItems = CurrentManager.CurrentTender.Equipments.OrderBy(p => !p.IsWorker).ToList();

                foreach (TenderEquipment item in equipmentItems)
                {
                    column = new DataGridViewTextBoxColumn();
                    //column.DataPropertyName = "TenderMaterialListEquipment.Quantity";

                    if (item.IsWorker)
                    {
                        //column.DataPropertyName = "item.Worker.Title.Name";
                        column.Name = item.Worker.Title.Name;
                        column.HeaderText = item.Worker.Title.Name;
                    }
                    else
                    {
                        //column = new DataGridViewTextBoxColumn();
                        column.Name = item.Vehicle.Title.Name;
                        column.HeaderText = item.Vehicle.Title.Name;
                    }
                    grdMaterialListIsWorkship.Columns.Add(column);
                }
            }
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "WorkerUnitPrice";
            column.Name = "WorkerUnitPrice";
            column.HeaderText = "ISCILIK(MALZEME) BIRIM FIYAT";
            column.DefaultCellStyle.Format = "c2";
            column.ReadOnly = false;
            grdMaterialListIsWorkship.Columns.Add(column);

            grdMaterialListIsWorkship.CellValueChanged += GrdMaterialListIsWorkship_CellValueChanged;

            //grdMaterialListIsWorkship.CellFormatting += GrdMaterialListIsWorkship_CellFormatting;
            grdMaterialListIsWorkship.DataBindingComplete += GrdMaterialListIsWorkship_DataBindingComplete;
        }

        private void GrdMaterialListIsWorkship_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            InitializeTenderMaterialListEquipment();
        }

        private void InitializeTenderMaterialListEquipment()
        {
            MaterialListModel[] items = CurrentManager.MaterialListIsWorkship.ToArray();

            foreach (DataGridViewRow CurrentRow in grdMaterialListIsWorkship.Rows)
            {
                MaterialListModel item = items[CurrentRow.Index];

                if (item.TenderMaterialListEquipment != null)
                {
                    foreach (TenderMaterialListEquipment tenderMaterialListEquipment in item.TenderMaterialListEquipment)
                    {
                        if (tenderMaterialListEquipment != null)
                        {
                            string columnName = string.Empty;
                            if (tenderMaterialListEquipment.Equipment.IsWorker)
                            {
                                columnName = tenderMaterialListEquipment.Equipment.Worker.Title.Name;
                            }
                            else
                            {
                                columnName = tenderMaterialListEquipment.Equipment.Vehicle.Title.Name;
                            }
                            grdMaterialListIsWorkship.Rows[CurrentRow.Index].Cells[columnName].Value = tenderMaterialListEquipment.Quantity;
                        }
                    }
                }
            }
        }

        private void frm_Teklif_Adim3_Load(object sender, EventArgs e)
        {
            lblTenderDescription.Text = CurrentManager.CurrentTender.Description;
            lblTenderNumber.Text = CurrentManager.CurrentTender.DisplayNumber;
            List<MaterialList> items = UIMaterialListManager.Instance.GetMaterialListIsWorkship();
            CurrentManager.MaterialListIsWorkship = IhalematikModelBase.GetModels<MaterialListModel, MaterialList>(items);
            grdMaterialListIsWorkship.DataSource = CurrentManager.MaterialListIsWorkship;
        }

        private void GrdMaterialListIsWorkship_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string currentColumnName = grdMaterialListIsWorkship.Columns[e.ColumnIndex].Name;
            List<MaterialListModel> items = CurrentManager.MaterialListIsWorkship;
            MaterialListModel materialListModel = CurrentManager.MaterialListIsWorkship.ToArray()[e.RowIndex];
            if (currentColumnName.Equals("WorkerMarkup"))
            {
                double value = Convert.ToDouble(grdMaterialListIsWorkship["WorkerMarkup", grdMaterialListIsWorkship.CurrentRow.Index].Value);
                materialListModel.WorkerMarkup = value;
            }
            else if (currentColumnName.Equals("UnitTime"))
            {

            }
            else if (currentColumnName.Equals("UnitTimeType"))
            {
                UnitTimeTypesModel value = (UnitTimeTypesModel)grdMaterialListIsWorkship["UnitTimeType", grdMaterialListIsWorkship.CurrentRow.Index].Value;
                materialListModel.UnitTimeType = value;
            }
            else if (materialListModel.TenderEquipments != null)
            {
                foreach (TenderMaterialListEquipment equipmentItem in materialListModel.TenderMaterialListEquipment)
                {
                    string columnName = string.Empty;
                    if (equipmentItem.Equipment.IsWorker)
                    {
                        columnName = equipmentItem.Equipment.Worker.Title.Name;
                    }
                    else
                    {
                        columnName = equipmentItem.Equipment.Vehicle.Title.Name;
                    }
                    if (columnName.Equals(currentColumnName))
                    {
                        int value = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(grdMaterialListIsWorkship[columnName, grdMaterialListIsWorkship.CurrentRow.Index].Value);
                        equipmentItem.Quantity = value;
                    }
                }
            }

            grdMaterialListIsWorkship.Refresh();
        }

        private void btnTumuneUygulaIscilik_Click(object sender, EventArgs e)
        {
            double markup = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtWorkerMarkup.Text);
            CurrentManager.MaterialListIsWorkship.ForEach(p => p.WorkerMarkup = markup);
            grdMaterialListIsWorkship.DataSource = CurrentManager.MaterialListIsWorkship;
            grdMaterialListIsWorkship.Refresh();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            List<MaterialListModel> items = CurrentManager.MaterialListIsWorkship;
            foreach (MaterialListModel materialListModel in items)
            {
                materialListModel.Save();

                foreach (TenderMaterialListEquipment tenderMaterialListEquipment in materialListModel.TenderMaterialListEquipment)
                {
                    //TenderMaterialListEquipment tenderMaterialListEquipment = new TenderMaterialListEquipment();
                    //tenderMaterialListEquipment.EquipmentId = tenderEquipment.Id;
                    //tenderMaterialListEquipment.TenderId = CurrentManager.CurrentTender.Id;
                    //tenderMaterialListEquipment.MaterialListId = materialListModel.Id.Value;
                    //tenderMaterialListEquipment.Quantity = tenderEquipment.Quantity;
                    TenderMaterialListEquipmentProvider.Instance.Save(tenderMaterialListEquipment);
                }
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private List<UnitTimeTypesModel> GetUnitTimes()
        {
            List<UnitTimeTypesModel> models = new List<UnitTimeTypesModel>();

            foreach (UnitTimeTypesEnum unitTimeType in Enum.GetValues(typeof(UnitTimeTypesEnum)))
            {
                UnitTimeTypesModel model = new UnitTimeTypesModel().Create(unitTimeType);
                models.Add(model);
            }

            return models;
        }

        private void grdMaterialListIsWorkship_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frm_IscilikIslemKayit frm = new frm_IscilikIslemKayit();
            frm.ShowDialog();
        }
    }
}