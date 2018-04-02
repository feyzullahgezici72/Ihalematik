namespace IhalematikProUI.Forms.IhaleAdim
{
    partial class frm_TopluObfYukleIhaleTemp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TopluObfYukleIhaleTemp));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.grdMaterialList = new DevExpress.XtraGrid.GridControl();
            this.gridViewMaterialList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaterialListIsPoz = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaterialListPozOBFId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaterialListQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnChangeMeterialName = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnResetMeterialName = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnHayir = new DevExpress.XtraEditors.SimpleButton();
            this.btnEvet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMaterialList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMaterialList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChangeMeterialName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnResetMeterialName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.grdMaterialList);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(309, 0);
            this.groupControl1.LookAndFeel.SkinName = "Visual Studio 2013 Blue";
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(919, 694);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "Okunan Öbf Listesi";
            // 
            // grdMaterialList
            // 
            this.grdMaterialList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMaterialList.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.grdMaterialList.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grdMaterialList.Location = new System.Drawing.Point(3, 30);
            this.grdMaterialList.MainView = this.gridViewMaterialList;
            this.grdMaterialList.Margin = new System.Windows.Forms.Padding(4);
            this.grdMaterialList.Name = "grdMaterialList";
            this.grdMaterialList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnChangeMeterialName,
            this.btnResetMeterialName});
            this.grdMaterialList.Size = new System.Drawing.Size(913, 661);
            this.grdMaterialList.TabIndex = 1;
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
            this.colMaterialListIsPoz,
            this.colMaterialListPozOBFId,
            this.colId,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.colMaterialListQuantity});
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
            // colMaterialListIsPoz
            // 
            this.colMaterialListIsPoz.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colMaterialListIsPoz.AppearanceHeader.Options.UseFont = true;
            this.colMaterialListIsPoz.Caption = "gridColumn4";
            this.colMaterialListIsPoz.FieldName = "IsPoz";
            this.colMaterialListIsPoz.Name = "colMaterialListIsPoz";
            // 
            // colMaterialListPozOBFId
            // 
            this.colMaterialListPozOBFId.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colMaterialListPozOBFId.AppearanceHeader.Options.UseFont = true;
            this.colMaterialListPozOBFId.Caption = "gridColumn4";
            this.colMaterialListPozOBFId.FieldName = "PozOBFId";
            this.colMaterialListPozOBFId.Name = "colMaterialListPozOBFId";
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
            this.gridColumn1.Caption = "POZ NO";
            this.gridColumn1.FieldName = "PozOBF.Number";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn1.OptionsFilter.AllowFilter = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 73;
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
            this.gridColumn2.FieldName = "PozOBFDescription";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn2.OptionsFilter.AllowFilter = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 345;
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
            this.gridColumn3.MaxWidth = 60;
            this.gridColumn3.MinWidth = 60;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowFocus = false;
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn3.OptionsFilter.AllowFilter = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 60;
            // 
            // colMaterialListQuantity
            // 
            this.colMaterialListQuantity.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.colMaterialListQuantity.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colMaterialListQuantity.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.colMaterialListQuantity.AppearanceCell.Options.UseBackColor = true;
            this.colMaterialListQuantity.AppearanceCell.Options.UseFont = true;
            this.colMaterialListQuantity.AppearanceCell.Options.UseForeColor = true;
            this.colMaterialListQuantity.AppearanceHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.colMaterialListQuantity.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colMaterialListQuantity.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colMaterialListQuantity.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colMaterialListQuantity.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.colMaterialListQuantity.AppearanceHeader.Options.UseBackColor = true;
            this.colMaterialListQuantity.AppearanceHeader.Options.UseFont = true;
            this.colMaterialListQuantity.AppearanceHeader.Options.UseForeColor = true;
            this.colMaterialListQuantity.Caption = "MİKTARI";
            this.colMaterialListQuantity.DisplayFormat.FormatString = "0";
            this.colMaterialListQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMaterialListQuantity.FieldName = "Quantity";
            this.colMaterialListQuantity.MaxWidth = 80;
            this.colMaterialListQuantity.MinWidth = 80;
            this.colMaterialListQuantity.Name = "colMaterialListQuantity";
            this.colMaterialListQuantity.OptionsFilter.AllowAutoFilter = false;
            this.colMaterialListQuantity.OptionsFilter.AllowFilter = false;
            this.colMaterialListQuantity.Visible = true;
            this.colMaterialListQuantity.VisibleIndex = 3;
            this.colMaterialListQuantity.Width = 80;
            // 
            // btnChangeMeterialName
            // 
            this.btnChangeMeterialName.AutoHeight = false;
            toolTipTitleItem1.Text = "YENİDEN ADLANDIR";
            toolTipItem1.Appearance.Options.UseImage = true;
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "Tedarikçiye gönderilecek Malzemenin adını değiştirmek isterseniz kullanınız..";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.btnChangeMeterialName.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnChangeMeterialName.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, superToolTip1, true)});
            this.btnChangeMeterialName.LookAndFeel.SkinName = "Sharp Plus";
            this.btnChangeMeterialName.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnChangeMeterialName.Name = "btnChangeMeterialName";
            this.btnChangeMeterialName.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // btnResetMeterialName
            // 
            this.btnResetMeterialName.AutoHeight = false;
            toolTipTitleItem2.Text = "GERİAL YENİDEN ADLANDIR";
            toolTipItem2.Appearance.Options.UseImage = true;
            toolTipItem2.LeftIndent = 6;
            toolTipItem2.Text = "Tedarikçiye gönderilecek Malzemenin adını değiştirmişseniz geri almak için kullan" +
    "ınız...";
            superToolTip2.Items.Add(toolTipTitleItem2);
            superToolTip2.Items.Add(toolTipItem2);
            this.btnResetMeterialName.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnResetMeterialName.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, superToolTip2, true)});
            this.btnResetMeterialName.LookAndFeel.SkinName = "Sharp Plus";
            this.btnResetMeterialName.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnResetMeterialName.Name = "btnResetMeterialName";
            this.btnResetMeterialName.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(110, 126);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(110, 19);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Kaydedilsin mi?";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnHayir);
            this.groupControl2.Controls.Add(this.btnEvet);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.LookAndFeel.SkinName = "Visual Studio 2013 Blue";
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(309, 694);
            this.groupControl2.TabIndex = 9;
            // 
            // btnHayir
            // 
            this.btnHayir.Image = ((System.Drawing.Image)(resources.GetObject("btnHayir.Image")));
            this.btnHayir.Location = new System.Drawing.Point(172, 151);
            this.btnHayir.Name = "btnHayir";
            this.btnHayir.Size = new System.Drawing.Size(120, 44);
            this.btnHayir.TabIndex = 1;
            this.btnHayir.Text = "&Hayır";
            this.btnHayir.Click += new System.EventHandler(this.btnHayir_Click);
            // 
            // btnEvet
            // 
            this.btnEvet.Image = ((System.Drawing.Image)(resources.GetObject("btnEvet.Image")));
            this.btnEvet.Location = new System.Drawing.Point(46, 151);
            this.btnEvet.Name = "btnEvet";
            this.btnEvet.Size = new System.Drawing.Size(120, 44);
            this.btnEvet.TabIndex = 1;
            this.btnEvet.Text = "&Evet";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 73);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(181, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tablodaki veriler okundu.";
            // 
            // frm_TopluObfYukleIhaleTemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 694);
            this.ControlBox = false;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.SkinName = "Stardust";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_TopluObfYukleIhaleTemp";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÖBF";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMaterialList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMaterialList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChangeMeterialName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnResetMeterialName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        public DevExpress.XtraGrid.GridControl grdMaterialList;
        public DevExpress.XtraGrid.Views.Grid.GridView gridViewMaterialList;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterialListIsPoz;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterialListPozOBFId;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterialListQuantity;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnChangeMeterialName;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnResetMeterialName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnHayir;
        private DevExpress.XtraEditors.SimpleButton btnEvet;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}