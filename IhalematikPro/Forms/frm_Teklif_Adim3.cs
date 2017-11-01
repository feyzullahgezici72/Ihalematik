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
using SimpleApplicationBase.BL.Base;

namespace IhalematikPro.Forms
{
    public partial class frm_Teklif_Adim3 : DevExpress.XtraEditors.XtraForm
    {
        public bool IsInitializeTenderMaterialListEquipment = false;
        public bool isDataGridFormatted = false;
        private object a1;
        private object a4;

        public frm_Teklif_Adim3()
        {
            InitializeComponent();

            //grdMaterialListIsWorkship.AutoGenerateColumns = false;

            //DataGridViewColumn column = new DataGridViewTextBoxColumn();
            //column = new DataGridViewTextBoxColumn();
            //column.DataPropertyName = "PozOBFDescription";
            //column.Name = "AÇIKLAMA";
            //column.ReadOnly = true;
            //column.Width = 340;
            //grdMaterialListIsWorkship.Columns.Add(column);

            //column = new DataGridViewTextBoxColumn();
            //column.DataPropertyName = "Quantity";
            //column.Name = "MİKTAR";
            //column.ReadOnly = true;
            //grdMaterialListIsWorkship.Columns.Add(column);

            //column = new DataGridViewTextBoxColumn();
            //column.DataPropertyName = "WorkerPercentageMarkup";
            //column.Name = "WorkerPercentageMarkup";
            //column.Name = "Kar %";
            //column.ReadOnly = false;
            //grdMaterialListIsWorkship.Columns.Add(column);

            //column = new DataGridViewTextBoxColumn();
            //column.DataPropertyName = "UnitTime";
            //column.Name = "UnitTime";
            //column.HeaderText = "BIRIM SURE";
            //column.ReadOnly = false;
            //grdMaterialListIsWorkship.Columns.Add(column);

            //column = new DataGridViewComboBoxColumn { DataSource = GetUnitTimes(), ValueMember = "Self", DisplayMember = "DisplayText" };
            //column.DataPropertyName = "UnitTimeType";
            //column.Name = "UnitTimeType";
            //column.HeaderText = "Zaman Tipi";
            //column.ReadOnly = false;
            //column.ValueType = typeof(UnitTimeTypesModel);
            //grdMaterialListIsWorkship.Columns.Add(column);


            //if (CurrentManager.CurrentTender.Equipments != null)
            //{
            //    List<TenderEquipment> equipmentItems = CurrentManager.CurrentTender.Equipments.OrderBy(p => !p.IsWorker).ToList();

            //    foreach (TenderEquipment item in equipmentItems)
            //    {
            //        column = new DataGridViewTextBoxColumn();
            //        //column.DataPropertyName = "TenderMaterialListEquipment.Quantity";

            //        if (item.IsWorker)
            //        {
            //            //column.DataPropertyName = "item.Worker.Title.Name";
            //            column.Name = item.Worker.Title.Name;
            //            column.HeaderText = item.Worker.Title.Name;
            //        }
            //        else
            //        {
            //            //column = new DataGridViewTextBoxColumn();
            //            column.Name = item.Vehicle.Title.Name;
            //            column.HeaderText = item.Vehicle.Title.Name;
            //        }
            //        grdMaterialListIsWorkship.Columns.Add(column);
            //    }
            //}
            //column = new DataGridViewTextBoxColumn();
            //column.DataPropertyName = "WorkerUnitPrice";
            //column.Name = "WorkerUnitPrice";
            //column.HeaderText = "BİRİM FİYAT";
            //column.DefaultCellStyle.Format = "c2";
            //column.ReadOnly = false;
            //grdMaterialListIsWorkship.Columns.Add(column);

            //column = new DataGridViewTextBoxColumn();
            //column.DataPropertyName = "WorkerMarkup";
            //column.Name = "WorkerMarkup";
            //column.HeaderText = "KARLI BİRİM FİYAT";
            //column.DefaultCellStyle.Format = "c2";
            //column.ReadOnly = false;
            //grdMaterialListIsWorkship.Columns.Add(column);

            //grdMaterialListIsWorkship.CellValueChanged += GrdMaterialListIsWorkship_CellValueChanged;

            ////grdMaterialListIsWorkship.CellFormatting += GrdMaterialListIsWorkship_CellFormatting;
            //grdMaterialListIsWorkship.DataBindingComplete += GrdMaterialListIsWorkship_DataBindingComplete;
            //grdMaterialListIsWorkship.EditingControlShowing += GrdMaterialListIsWorkship_EditingControlShowing;
        }

        //private void GrdMaterialListIsWorkship_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        //{
        //    if (grdMaterialListIsWorkship.CurrentCell.ColumnIndex == 4 && e.Control is System.Windows.Forms.ComboBox)
        //    {
        //        System.Windows.Forms.ComboBox comboBox = e.Control as System.Windows.Forms.ComboBox;
        //        comboBox.SelectedIndexChanged -= LastColumnComboSelectionChanged;
        //        comboBox.SelectedIndexChanged += LastColumnComboSelectionChanged;
        //    }
        //}

        //private void LastColumnComboSelectionChanged(object sender, EventArgs e)
        //{
        //    List<MaterialListModel> models = (List<MaterialListModel>)grdMaterialListIsWorkship.DataSource; //IhalematikModelBase.GetModels<MaterialListModel, MaterialList>(items);
        //    MaterialListModel materialListModel = models.ToArray()[grdMaterialListIsWorkship.CurrentRow.Index];
        //    var sendingCB = sender as DataGridViewComboBoxEditingControl;

        //    UnitTimeTypesModel value = (UnitTimeTypesModel)sendingCB.SelectedValue;//grdMaterialListIsWorkship["UnitTimeType", grdMaterialListIsWorkship.CurrentRow.Index].Value;
        //    if (value != null)
        //    {
        //        materialListModel.UnitTimeType = value;

        //        MaterialList materialList = CurrentManager.CurrentTender.MaterialList.Where(p => p.Id == materialListModel.Id).First();
        //        if (materialList != null)
        //        {
        //            materialList.UnitTimeType = materialListModel.UnitTimeType.UnitTimeType;
        //            OperationResult result = MaterialListProvider.Instance.Save(materialList);
        //            if (!result.Success)
        //            {
        //                //TODO feyzullahg
        //            }
        //        }
        //        grdMaterialListIsWorkship.Refresh(); 
        //    }
        //    //var currentcell = grdMaterialListIsWorkship.CurrentRow.Index;
        //    //var sendingCB = sender as DataGridViewComboBoxEditingControl;
        //    //DataGridViewTextBoxCell cel = (DataGridViewTextBoxCell)grdMaterialListIsWorkship.Rows[currentcell.Y].Cells[0];
        //    //cel.Value = sendingCB.EditingControlFormattedValue.ToString();
        //}

        private void GrdMaterialListIsWorkship_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //if (!this.isDataGridFormatted)
            //    return;
            //InitializeTenderMaterialListEquipment();
            //this.isDataGridFormatted = false;
        }

        //private void InitializeTenderMaterialListEquipment()
        //{
        //    if (IsInitializeTenderMaterialListEquipment)
        //    {
        //        //return;
        //    }

        //    List<MaterialList> items = UIMaterialListManager.Instance.GetMaterialListIsWorkship();
        //    List<MaterialListModel> models = IhalematikModelBase.GetModels<MaterialListModel, MaterialList>(items);

        //    foreach (DataGridViewRow CurrentRow in grdMaterialListIsWorkship.Rows)
        //    {
        //        MaterialListModel item = models.ToArray()[CurrentRow.Index];

        //        if (item.TenderMaterialListEquipment != null)
        //        {
        //            foreach (TenderMaterialListEquipment tenderMaterialListEquipment in item.TenderMaterialListEquipment)
        //            {
        //                if (tenderMaterialListEquipment != null)
        //                {
        //                    string columnName = string.Empty;
        //                    if (tenderMaterialListEquipment.Equipment.IsWorker)
        //                    {
        //                        columnName = tenderMaterialListEquipment.Equipment.Worker.Title.Name;
        //                    }
        //                    else
        //                    {
        //                        columnName = tenderMaterialListEquipment.Equipment.Vehicle.Title.Name;
        //                    }
        //                    grdMaterialListIsWorkship.Rows[CurrentRow.Index].Cells[columnName].Value = tenderMaterialListEquipment.Quantity;
        //                }
        //            }
        //        }
        //    }

        //    //grdMaterialListIsWorkship.Refresh();
        //    IsInitializeTenderMaterialListEquipment = true;
        //}

        private void frm_Teklif_Adim3_Load(object sender, EventArgs e)
        {
            lblTenderDescription.Text = CurrentManager.CurrentTender.Description;
            lblTenderNumber.Text = CurrentManager.CurrentTender.DisplayNumber;
            List<MaterialList> items = UIMaterialListManager.Instance.GetMaterialListIsWorkship();
            List<MaterialListModel> models = IhalematikModelBase.GetModels<MaterialListModel, MaterialList>(items);
            grdMaterialListIsWorkship.DataSource = models;
            //InitializeTenderMaterialListEquipment();
            txtBaseAmount.Text = models.Sum(p => p.Quantity * p.WorkerUnitPrice).ToString("c2");
            txtMarkupAmount.Text = models.Sum(p => p.MarkupUnitPrice).ToString("c2");
            txtTotalAmount.Text = models.Sum(p => (p.Quantity * p.WorkerUnitPrice) + p.MarkupUnitPrice).ToString("c2");
        }

        //private void GrdMaterialListIsWorkship_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (!IsInitializeTenderMaterialListEquipment)
        //        return;

        //    string currentColumnName = grdMaterialListIsWorkship.Columns[e.ColumnIndex].Name;
        //    //List<MaterialList> items = UIMaterialListManager.Instance.GetMaterialListIsWorkship();
        //    List<MaterialListModel> models = (List<MaterialListModel>)grdMaterialListIsWorkship.DataSource; //IhalematikModelBase.GetModels<MaterialListModel, MaterialList>(items);
        //    MaterialListModel materialListModel = models.ToArray()[e.RowIndex];
        //    if (currentColumnName.Equals("WorkerPercentageMarkup"))
        //    {
        //        double value = Convert.ToDouble(grdMaterialListIsWorkship["WorkerMarkup", grdMaterialListIsWorkship.CurrentRow.Index].Value);
        //        materialListModel.WorkerPercentageMarkup = value;
        //        MaterialList materialList = CurrentManager.CurrentTender.MaterialList.Where(p => p.Id == materialListModel.Id).First();
        //        if (materialList != null)
        //        {
        //            materialList.WorkerMarkup = value;
        //            OperationResult result = MaterialListProvider.Instance.Save(materialList);
        //            if (!result.Success)
        //            {
        //                //TODO feyzullahg
        //            }
        //        }
        //    }
        //    else if (currentColumnName.Equals("UnitTime"))
        //    {
        //        int value = Convert.ToInt32(grdMaterialListIsWorkship["UnitTime", grdMaterialListIsWorkship.CurrentRow.Index].Value);
        //        MaterialList materialList = CurrentManager.CurrentTender.MaterialList.Where(p => p.Id == materialListModel.Id).First();
        //        if (materialList != null)
        //        {
        //            materialList.UnitTime = value;
        //            OperationResult result = MaterialListProvider.Instance.Save(materialList);
        //            if (!result.Success)
        //            {
        //                //TODO feyzullahg
        //            }
        //        }
        //    }
        //    else if (currentColumnName.Equals("UnitTimeType"))
        //    {
        //        //UnitTimeTypesModel value = (UnitTimeTypesModel)grdMaterialListIsWorkship["UnitTimeType", grdMaterialListIsWorkship.CurrentRow.Index].Value;
        //        //materialListModel.UnitTimeType = value;
        //    }
        //    else if (materialListModel.TenderMaterialListEquipment != null)
        //    {
        //        foreach (TenderMaterialListEquipment equipmentItem in materialListModel.TenderMaterialListEquipment)
        //        {
        //            string columnName = string.Empty;
        //            if (equipmentItem.Equipment.IsWorker)
        //            {
        //                columnName = equipmentItem.Equipment.Worker.Title.Name;
        //            }
        //            else
        //            {
        //                columnName = equipmentItem.Equipment.Vehicle.Title.Name;
        //            }
        //            if (columnName.Equals(currentColumnName))
        //            {
        //                int value = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(grdMaterialListIsWorkship[columnName, grdMaterialListIsWorkship.CurrentRow.Index].Value);
        //                equipmentItem.Quantity = value;

        //                MaterialList materialList = CurrentManager.CurrentTender.MaterialList.Where(p => p.Id == materialListModel.Id).First();
        //                if (materialList != null)
        //                {
        //                    TenderMaterialListEquipment tenderMaterialListEquipment = materialList.TenderMaterialListEquipment.Where(k => k.Id == equipmentItem.Id).FirstOrDefault();
        //                    if (tenderMaterialListEquipment != null)
        //                    {
        //                        tenderMaterialListEquipment.Quantity = value;
        //                        OperationResult result = TenderMaterialListEquipmentProvider.Instance.Save(tenderMaterialListEquipment);
        //                        if (!result.Success)
        //                        {
        //                            //TODO feyzullahg
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //    }

        //    txtBaseAmount.Text = models.Sum(p => p.Quantity * p.WorkerUnitPrice).ToString("c2");
        //    txtMarkupAmount.Text = models.Sum(p => p.MarkupUnitPrice).ToString("c2");
        //    txtTotalAmount.Text = models.Sum(p => (p.Quantity * p.WorkerUnitPrice) + p.MarkupUnitPrice).ToString("c2");

        //    grdMaterialListIsWorkship.Refresh();
        //}

        private void btnTumuneUygulaIscilik_Click(object sender, EventArgs e)
        {
            //double markup = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtWorkerMarkup.Text);
            //List<MaterialList> items = UIMaterialListManager.Instance.GetMaterialListIsWorkship();
            //List<MaterialListModel> models = IhalematikModelBase.GetModels<MaterialListModel, MaterialList>(items);
            //models.ForEach(p => p.Markup = markup);
            //foreach (var item in items)
            //{
            //    item.Markup = markup;
            //    OperationResult result = MaterialListProvider.Instance.Save(item);
            //    if (!result.Success)
            //    {
            //        //TODO feyzullahg
            //    }
            //}
            //grdMaterialListIsWorkship.DataSource = models;
            //grdMaterialListIsWorkship.Refresh();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            List<MaterialList> items = UIMaterialListManager.Instance.GetMaterialListIsWorkship();
            List<MaterialListModel> models = IhalematikModelBase.GetModels<MaterialListModel, MaterialList>(items);
            foreach (MaterialListModel materialListModel in models)
            {
                materialListModel.Save();

                foreach (TenderMaterialListEquipment tenderMaterialListEquipment in materialListModel.TenderMaterialListEquipment)
                {
                    TenderMaterialListEquipmentProvider.Instance.Save(tenderMaterialListEquipment);
                }
            }
            frm_ihaleOlustuMesaj msj = new frm_ihaleOlustuMesaj();
            msj.lblMesaj.Text = "Kaydedildi...";
            msj.ShowDialog();
            this.Close();


            frm_TeklifAdimSon a4 = (frm_TeklifAdimSon)Application.OpenForms[" frm_TeklifSonAdim"];

            if (a4 == null)
            {
                a4 = new frm_TeklifAdimSon();
                a4.MdiParent = (frm_Anaform)Application.OpenForms["frm_Anaform"];
                a4.FormClosed += new FormClosedEventHandler(a4_FormClosed);
                a4.Show();

            }
            else
            {
                a4.Activate();
            }


        }

        private void a4_FormClosed(object sender, FormClosedEventArgs e)
        {
            a4 = null;
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
        }

        private void btnTumuneUygula_Click(object sender, EventArgs e)
        {
            double markup = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtWorkerMarkup.Text.Replace("%", ""));
            List<MaterialList> items = UIMaterialListManager.Instance.GetMaterialListIsWorkship();
            List<MaterialListModel> models = IhalematikModelBase.GetModels<MaterialListModel, MaterialList>(items);
            models.ForEach(p => p.Markup = markup);
            foreach (var item in items)
            {
                item.WorkerMarkup = markup;
                OperationResult result = MaterialListProvider.Instance.Save(item);
                if (!result.Success)
                {
                    //TODO feyzullahg
                }
            }
            this.frm_Teklif_Adim3_Load(null, null);
        }

        private void detaylarToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            
        }

        private void btnIscilikveAracGirisi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
         
        }

        private void btnCalisanlarveAraclar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frm_IscilikAracDetay frm = new frm_IscilikAracDetay();
            frm.ShowDialog();
        }
    }
}