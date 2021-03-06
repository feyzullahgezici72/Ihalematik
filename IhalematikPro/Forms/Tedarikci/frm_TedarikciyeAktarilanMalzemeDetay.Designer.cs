﻿namespace IhalematikProUI.Forms.Tedarikci
{
    partial class frm_TedarikciyeAktarilanMalzemeDetay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TedarikciyeAktarilanMalzemeDetay));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.grdMaterialList = new DevExpress.XtraGrid.GridControl();
            this.gridViewMaterialList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpstIsSelectedOfferMaterial = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.txtAuthorNameSurname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtScore = new DevExpress.XtraEditors.TextEdit();
            this.label99 = new DevExpress.XtraEditors.LabelControl();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtCompanyName = new DevExpress.XtraEditors.TextEdit();
            this.memoEditSupplierSegment = new DevExpress.XtraEditors.MemoEdit();
            this.pnlMail = new DevExpress.XtraEditors.PanelControl();
            this.txtEmailBody = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMaterialList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMaterialList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpstIsSelectedOfferMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthorNameSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtScore.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditSupplierSegment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMail)).BeginInit();
            this.pnlMail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmailBody.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.grdMaterialList);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 156);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1041, 423);
            this.panelControl1.TabIndex = 0;
            // 
            // grdMaterialList
            // 
            this.grdMaterialList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMaterialList.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.grdMaterialList.Location = new System.Drawing.Point(3, 3);
            this.grdMaterialList.MainView = this.gridViewMaterialList;
            this.grdMaterialList.Margin = new System.Windows.Forms.Padding(4);
            this.grdMaterialList.Name = "grdMaterialList";
            this.grdMaterialList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rpstIsSelectedOfferMaterial});
            this.grdMaterialList.Size = new System.Drawing.Size(1035, 417);
            this.grdMaterialList.TabIndex = 0;
            this.grdMaterialList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMaterialList});
            // 
            // gridViewMaterialList
            // 
            this.gridViewMaterialList.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver;
            this.gridViewMaterialList.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewMaterialList.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Silver;
            this.gridViewMaterialList.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray;
            this.gridViewMaterialList.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridViewMaterialList.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridViewMaterialList.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridViewMaterialList.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewMaterialList.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gridViewMaterialList.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewMaterialList.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue;
            this.gridViewMaterialList.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridViewMaterialList.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridViewMaterialList.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridViewMaterialList.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gridViewMaterialList.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite;
            this.gridViewMaterialList.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewMaterialList.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewMaterialList.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridViewMaterialList.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridViewMaterialList.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewMaterialList.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.gridViewMaterialList.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewMaterialList.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewMaterialList.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewMaterialList.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridViewMaterialList.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridViewMaterialList.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridViewMaterialList.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(80)))), ((int)(((byte)(135)))));
            this.gridViewMaterialList.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewMaterialList.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gridViewMaterialList.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewMaterialList.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridViewMaterialList.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridViewMaterialList.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.gridViewMaterialList.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridViewMaterialList.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.gridViewMaterialList.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gridViewMaterialList.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridViewMaterialList.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridViewMaterialList.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewMaterialList.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewMaterialList.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver;
            this.gridViewMaterialList.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver;
            this.gridViewMaterialList.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewMaterialList.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridViewMaterialList.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridViewMaterialList.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewMaterialList.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.gridViewMaterialList.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.gridViewMaterialList.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewMaterialList.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridViewMaterialList.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridViewMaterialList.Appearance.GroupButton.Options.UseForeColor = true;
            this.gridViewMaterialList.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gridViewMaterialList.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gridViewMaterialList.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridViewMaterialList.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridViewMaterialList.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridViewMaterialList.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridViewMaterialList.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.gridViewMaterialList.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gridViewMaterialList.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewMaterialList.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.gridViewMaterialList.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewMaterialList.Appearance.GroupPanel.Options.UseFont = true;
            this.gridViewMaterialList.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridViewMaterialList.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray;
            this.gridViewMaterialList.Appearance.GroupRow.ForeColor = System.Drawing.Color.Silver;
            this.gridViewMaterialList.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridViewMaterialList.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridViewMaterialList.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gridViewMaterialList.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver;
            this.gridViewMaterialList.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewMaterialList.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewMaterialList.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridViewMaterialList.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridViewMaterialList.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewMaterialList.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewMaterialList.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray;
            this.gridViewMaterialList.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewMaterialList.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewMaterialList.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewMaterialList.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver;
            this.gridViewMaterialList.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridViewMaterialList.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridViewMaterialList.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
            this.gridViewMaterialList.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewMaterialList.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gridViewMaterialList.Appearance.OddRow.Options.UseBackColor = true;
            this.gridViewMaterialList.Appearance.OddRow.Options.UseForeColor = true;
            this.gridViewMaterialList.Appearance.Preview.BackColor = System.Drawing.Color.White;
            this.gridViewMaterialList.Appearance.Preview.ForeColor = System.Drawing.Color.Navy;
            this.gridViewMaterialList.Appearance.Preview.Options.UseBackColor = true;
            this.gridViewMaterialList.Appearance.Preview.Options.UseForeColor = true;
            this.gridViewMaterialList.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridViewMaterialList.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridViewMaterialList.Appearance.Row.Options.UseBackColor = true;
            this.gridViewMaterialList.Appearance.Row.Options.UseForeColor = true;
            this.gridViewMaterialList.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gridViewMaterialList.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.gridViewMaterialList.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridViewMaterialList.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewMaterialList.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewMaterialList.Appearance.VertLine.BackColor = System.Drawing.Color.Silver;
            this.gridViewMaterialList.Appearance.VertLine.Options.UseBackColor = true;
            this.gridViewMaterialList.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridViewMaterialList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.colQuantity});
            this.gridViewMaterialList.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridViewMaterialList.GridControl = this.grdMaterialList;
            this.gridViewMaterialList.Name = "gridViewMaterialList";
            this.gridViewMaterialList.OptionsDetail.AllowExpandEmptyDetails = true;
            this.gridViewMaterialList.OptionsMenu.EnableColumnMenu = false;
            this.gridViewMaterialList.OptionsMenu.EnableFooterMenu = false;
            this.gridViewMaterialList.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewMaterialList.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewMaterialList.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewMaterialList.OptionsSelection.CheckBoxSelectorColumnWidth = 60;
            this.gridViewMaterialList.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewMaterialList.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewMaterialList.OptionsSelection.ShowCheckBoxSelectorInPrintExport = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewMaterialList.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewMaterialList.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewMaterialList.OptionsView.ShowDetailButtons = false;
            this.gridViewMaterialList.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridViewMaterialList.OptionsView.ShowFooter = true;
            this.gridViewMaterialList.OptionsView.ShowGroupPanel = false;
            this.gridViewMaterialList.PaintStyleName = "Web";
            // 
            // colId
            // 
            this.colId.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colId.AppearanceHeader.Options.UseFont = true;
            this.colId.Caption = "gridColumn4";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridColumn1.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridColumn1.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridColumn1.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridColumn1.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn1.Caption = "ÖBF/POZ NO";
            this.gridColumn1.FieldName = "PozOBF.Number";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn1.OptionsFilter.AllowFilter = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 121;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridColumn2.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridColumn2.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridColumn2.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridColumn2.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn2.Caption = "AÇIKLAMA";
            this.gridColumn2.FieldName = "PozOBF.Description";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn2.OptionsFilter.AllowFilter = false;
            this.gridColumn2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "PozOBF.Description", "Toplam :{0}")});
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 698;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridColumn3.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridColumn3.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridColumn3.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridColumn3.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            this.gridColumn3.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn3.Caption = "BİRİMİ";
            this.gridColumn3.FieldName = "PozOBF.Unit";
            this.gridColumn3.MaxWidth = 80;
            this.gridColumn3.MinWidth = 80;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowFocus = false;
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn3.OptionsFilter.AllowFilter = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 80;
            // 
            // colQuantity
            // 
            this.colQuantity.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colQuantity.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.colQuantity.AppearanceCell.Options.UseFont = true;
            this.colQuantity.AppearanceCell.Options.UseForeColor = true;
            this.colQuantity.AppearanceHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.colQuantity.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colQuantity.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colQuantity.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colQuantity.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.colQuantity.AppearanceHeader.Options.UseBackColor = true;
            this.colQuantity.AppearanceHeader.Options.UseFont = true;
            this.colQuantity.AppearanceHeader.Options.UseForeColor = true;
            this.colQuantity.Caption = "MİKTARI";
            this.colQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.MaxWidth = 80;
            this.colQuantity.MinWidth = 80;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.OptionsColumn.AllowEdit = false;
            this.colQuantity.OptionsColumn.AllowFocus = false;
            this.colQuantity.OptionsFilter.AllowAutoFilter = false;
            this.colQuantity.OptionsFilter.AllowFilter = false;
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 3;
            this.colQuantity.Width = 80;
            // 
            // rpstIsSelectedOfferMaterial
            // 
            this.rpstIsSelectedOfferMaterial.AutoHeight = false;
            this.rpstIsSelectedOfferMaterial.Name = "rpstIsSelectedOfferMaterial";
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.txtAuthorNameSurname);
            this.panelControl4.Controls.Add(this.labelControl6);
            this.panelControl4.Controls.Add(this.txtScore);
            this.panelControl4.Controls.Add(this.label99);
            this.panelControl4.Controls.Add(this.txtEmail);
            this.panelControl4.Controls.Add(this.labelControl9);
            this.panelControl4.Controls.Add(this.labelControl3);
            this.panelControl4.Controls.Add(this.labelControl4);
            this.panelControl4.Controls.Add(this.txtCompanyName);
            this.panelControl4.Controls.Add(this.memoEditSupplierSegment);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl4.Enabled = false;
            this.panelControl4.Location = new System.Drawing.Point(0, 0);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(1041, 156);
            this.panelControl4.TabIndex = 36;
            // 
            // txtAuthorNameSurname
            // 
            this.txtAuthorNameSurname.Location = new System.Drawing.Point(150, 47);
            this.txtAuthorNameSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtAuthorNameSurname.Name = "txtAuthorNameSurname";
            this.txtAuthorNameSurname.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtAuthorNameSurname.Properties.Appearance.Options.UseBackColor = true;
            this.txtAuthorNameSurname.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtAuthorNameSurname.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtAuthorNameSurname.Properties.DisplayFormat.FormatString = "N2";
            this.txtAuthorNameSurname.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtAuthorNameSurname.Properties.EditFormat.FormatString = "N2";
            this.txtAuthorNameSurname.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtAuthorNameSurname.Size = new System.Drawing.Size(370, 26);
            this.txtAuthorNameSurname.TabIndex = 87;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl6.Location = new System.Drawing.Point(12, 50);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(130, 19);
            this.labelControl6.TabIndex = 90;
            this.labelControl6.Text = "Yetkili Adı Soyadı:";
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(150, 115);
            this.txtScore.Margin = new System.Windows.Forms.Padding(4);
            this.txtScore.Name = "txtScore";
            this.txtScore.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtScore.Properties.Appearance.Options.UseBackColor = true;
            this.txtScore.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtScore.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtScore.Properties.DisplayFormat.FormatString = "N2";
            this.txtScore.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtScore.Properties.EditFormat.FormatString = "N2";
            this.txtScore.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtScore.Size = new System.Drawing.Size(82, 26);
            this.txtScore.TabIndex = 89;
            // 
            // label99
            // 
            this.label99.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label99.Appearance.ForeColor = System.Drawing.Color.Black;
            this.label99.Location = new System.Drawing.Point(15, 118);
            this.label99.Margin = new System.Windows.Forms.Padding(4);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(126, 19);
            this.label99.TabIndex = 91;
            this.label99.Text = "Değerleme Puanı:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(150, 80);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtEmail.Properties.Appearance.Options.UseBackColor = true;
            this.txtEmail.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtEmail.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtEmail.Properties.DisplayFormat.FormatString = "N2";
            this.txtEmail.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtEmail.Properties.EditFormat.FormatString = "N2";
            this.txtEmail.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtEmail.Size = new System.Drawing.Size(370, 26);
            this.txtEmail.TabIndex = 88;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl9.Location = new System.Drawing.Point(57, 83);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(84, 19);
            this.labelControl9.TabIndex = 92;
            this.labelControl9.Text = "Mail Adresi:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl3.Location = new System.Drawing.Point(556, 16);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(100, 19);
            this.labelControl3.TabIndex = 84;
            this.labelControl3.Text = "Faaliyet Alanı:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl4.Location = new System.Drawing.Point(68, 16);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(75, 19);
            this.labelControl4.TabIndex = 82;
            this.labelControl4.Text = "Firma Adı:";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(150, 13);
            this.txtCompanyName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtCompanyName.Properties.Appearance.Options.UseBackColor = true;
            this.txtCompanyName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtCompanyName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtCompanyName.Properties.DisplayFormat.FormatString = "N2";
            this.txtCompanyName.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtCompanyName.Properties.EditFormat.FormatString = "N2";
            this.txtCompanyName.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtCompanyName.Size = new System.Drawing.Size(370, 26);
            this.txtCompanyName.TabIndex = 81;
            // 
            // memoEditSupplierSegment
            // 
            this.memoEditSupplierSegment.Location = new System.Drawing.Point(664, 15);
            this.memoEditSupplierSegment.Margin = new System.Windows.Forms.Padding(4);
            this.memoEditSupplierSegment.Name = "memoEditSupplierSegment";
            this.memoEditSupplierSegment.Properties.AccessibleDescription = "Name";
            this.memoEditSupplierSegment.Properties.AccessibleName = "Id";
            this.memoEditSupplierSegment.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.memoEditSupplierSegment.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.memoEditSupplierSegment.Size = new System.Drawing.Size(370, 127);
            this.memoEditSupplierSegment.TabIndex = 83;
            // 
            // pnlMail
            // 
            this.pnlMail.Controls.Add(this.txtEmailBody);
            this.pnlMail.Controls.Add(this.labelControl2);
            this.pnlMail.Controls.Add(this.simpleButton1);
            this.pnlMail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMail.Location = new System.Drawing.Point(0, 579);
            this.pnlMail.Name = "pnlMail";
            this.pnlMail.Size = new System.Drawing.Size(1041, 80);
            this.pnlMail.TabIndex = 37;
            // 
            // txtEmailBody
            // 
            this.txtEmailBody.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtEmailBody.EditValue = "Selamlar\r\nUygun fiyatlarınızı bekler.\r\nİyi çalışmalar dileriz.\r\n";
            this.txtEmailBody.Location = new System.Drawing.Point(159, 3);
            this.txtEmailBody.Name = "txtEmailBody";
            this.txtEmailBody.Size = new System.Drawing.Size(696, 74);
            this.txtEmailBody.TabIndex = 8;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.labelControl2.Location = new System.Drawing.Point(20, 31);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(133, 19);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Mail Açıklaması:";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.simpleButton1.Location = new System.Drawing.Point(855, 3);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(6);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(183, 74);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "&Mail Gönder";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // frm_TedarikciyeAktarilanMalzemeDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 659);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.pnlMail);
            this.Controls.Add(this.panelControl4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_TedarikciyeAktarilanMalzemeDetay";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TEDARİKÇİLERE GÖNDERİLECEK MALZEME DETAYI";
            this.Load += new System.EventHandler(this.frm_TedarikciyeAktarilanMalzemeDetay_Load);
            this.Shown += new System.EventHandler(this.frm_TedarikciyeAktarilanMalzemeDetay_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMaterialList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMaterialList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpstIsSelectedOfferMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthorNameSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtScore.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditSupplierSegment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMail)).EndInit();
            this.pnlMail.ResumeLayout(false);
            this.pnlMail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmailBody.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        public DevExpress.XtraGrid.GridControl grdMaterialList;
        public DevExpress.XtraGrid.Views.Grid.GridView gridViewMaterialList;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit rpstIsSelectedOfferMaterial;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtCompanyName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.MemoEdit memoEditSupplierSegment;
        private DevExpress.XtraEditors.TextEdit txtAuthorNameSurname;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtScore;
        private DevExpress.XtraEditors.LabelControl label99;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.PanelControl pnlMail;
        private DevExpress.XtraEditors.MemoEdit txtEmailBody;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        public DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}