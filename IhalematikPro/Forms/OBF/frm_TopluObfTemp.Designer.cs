namespace IhalematikProUI.Forms.OBF
{
    partial class frm_TopluObfTemp
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TopluObfTemp));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.grdOBFTempList = new DevExpress.XtraGrid.GridControl();
            this.gridViewOBFList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnGncelle = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnPasive = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnActive = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnHayir = new DevExpress.XtraEditors.SimpleButton();
            this.btnEvet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOBFTempList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOBFList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGncelle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPasive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.grdOBFTempList);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(309, 0);
            this.groupControl1.LookAndFeel.SkinName = "Visual Studio 2013 Blue";
            this.groupControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(919, 694);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Okunan Öbf Listesi";
            // 
            // grdOBFTempList
            // 
            this.grdOBFTempList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdOBFTempList.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            gridLevelNode1.RelationName = "Level1";
            this.grdOBFTempList.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.grdOBFTempList.Location = new System.Drawing.Point(3, 31);
            this.grdOBFTempList.MainView = this.gridViewOBFList;
            this.grdOBFTempList.Margin = new System.Windows.Forms.Padding(4);
            this.grdOBFTempList.Name = "grdOBFTempList";
            this.grdOBFTempList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnGncelle,
            this.btnPasive,
            this.btnActive});
            this.grdOBFTempList.Size = new System.Drawing.Size(913, 660);
            this.grdOBFTempList.TabIndex = 1;
            this.grdOBFTempList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewOBFList});
            // 
            // gridViewOBFList
            // 
            this.gridViewOBFList.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver;
            this.gridViewOBFList.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewOBFList.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Silver;
            this.gridViewOBFList.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray;
            this.gridViewOBFList.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridViewOBFList.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridViewOBFList.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridViewOBFList.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewOBFList.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gridViewOBFList.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewOBFList.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue;
            this.gridViewOBFList.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridViewOBFList.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridViewOBFList.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridViewOBFList.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gridViewOBFList.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite;
            this.gridViewOBFList.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewOBFList.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewOBFList.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridViewOBFList.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridViewOBFList.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewOBFList.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.gridViewOBFList.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewOBFList.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewOBFList.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewOBFList.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridViewOBFList.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridViewOBFList.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridViewOBFList.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(80)))), ((int)(((byte)(135)))));
            this.gridViewOBFList.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewOBFList.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gridViewOBFList.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewOBFList.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridViewOBFList.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridViewOBFList.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.gridViewOBFList.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridViewOBFList.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.gridViewOBFList.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gridViewOBFList.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridViewOBFList.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridViewOBFList.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewOBFList.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewOBFList.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver;
            this.gridViewOBFList.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver;
            this.gridViewOBFList.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewOBFList.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridViewOBFList.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridViewOBFList.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewOBFList.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.gridViewOBFList.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.gridViewOBFList.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewOBFList.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridViewOBFList.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridViewOBFList.Appearance.GroupButton.Options.UseForeColor = true;
            this.gridViewOBFList.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gridViewOBFList.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gridViewOBFList.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridViewOBFList.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridViewOBFList.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridViewOBFList.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridViewOBFList.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.gridViewOBFList.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gridViewOBFList.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewOBFList.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.gridViewOBFList.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewOBFList.Appearance.GroupPanel.Options.UseFont = true;
            this.gridViewOBFList.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridViewOBFList.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray;
            this.gridViewOBFList.Appearance.GroupRow.ForeColor = System.Drawing.Color.Silver;
            this.gridViewOBFList.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridViewOBFList.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridViewOBFList.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gridViewOBFList.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver;
            this.gridViewOBFList.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewOBFList.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewOBFList.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridViewOBFList.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridViewOBFList.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewOBFList.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewOBFList.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray;
            this.gridViewOBFList.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewOBFList.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewOBFList.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewOBFList.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver;
            this.gridViewOBFList.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridViewOBFList.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridViewOBFList.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
            this.gridViewOBFList.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewOBFList.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gridViewOBFList.Appearance.OddRow.Options.UseBackColor = true;
            this.gridViewOBFList.Appearance.OddRow.Options.UseForeColor = true;
            this.gridViewOBFList.Appearance.Preview.BackColor = System.Drawing.Color.White;
            this.gridViewOBFList.Appearance.Preview.ForeColor = System.Drawing.Color.Navy;
            this.gridViewOBFList.Appearance.Preview.Options.UseBackColor = true;
            this.gridViewOBFList.Appearance.Preview.Options.UseForeColor = true;
            this.gridViewOBFList.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridViewOBFList.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridViewOBFList.Appearance.Row.Options.UseBackColor = true;
            this.gridViewOBFList.Appearance.Row.Options.UseForeColor = true;
            this.gridViewOBFList.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gridViewOBFList.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.gridViewOBFList.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridViewOBFList.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewOBFList.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewOBFList.Appearance.VertLine.BackColor = System.Drawing.Color.Silver;
            this.gridViewOBFList.Appearance.VertLine.Options.UseBackColor = true;
            this.gridViewOBFList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.gridColumn5,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gridViewOBFList.GridControl = this.grdOBFTempList;
            this.gridViewOBFList.Name = "gridViewOBFList";
            this.gridViewOBFList.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gridViewOBFList.OptionsFilter.AllowFilterEditor = false;
            this.gridViewOBFList.OptionsFilter.AllowFilterIncrementalSearch = false;
            this.gridViewOBFList.OptionsFilter.AllowMRUFilterList = false;
            this.gridViewOBFList.OptionsFilter.AllowMultiSelectInCheckedFilterPopup = false;
            this.gridViewOBFList.OptionsFilter.ColumnFilterPopupRowCount = 4;
            this.gridViewOBFList.OptionsFilter.FilterEditorUseMenuForOperandsAndOperators = false;
            this.gridViewOBFList.OptionsFilter.MRUColumnFilterListCount = 0;
            this.gridViewOBFList.OptionsFilter.MRUFilterListCount = 0;
            this.gridViewOBFList.OptionsFilter.MRUFilterListPopupCount = 0;
            this.gridViewOBFList.OptionsFilter.ShowAllTableValuesInCheckedFilterPopup = false;
            this.gridViewOBFList.OptionsFind.AllowFindPanel = false;
            this.gridViewOBFList.OptionsFind.ClearFindOnClose = false;
            this.gridViewOBFList.OptionsFind.HighlightFindResults = false;
            this.gridViewOBFList.OptionsFind.ShowClearButton = false;
            this.gridViewOBFList.OptionsFind.ShowCloseButton = false;
            this.gridViewOBFList.OptionsFind.ShowFindButton = false;
            this.gridViewOBFList.OptionsMenu.EnableColumnMenu = false;
            this.gridViewOBFList.OptionsMenu.EnableFooterMenu = false;
            this.gridViewOBFList.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewOBFList.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewOBFList.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewOBFList.OptionsView.ShowFooter = true;
            this.gridViewOBFList.OptionsView.ShowGroupPanel = false;
            this.gridViewOBFList.PaintStyleName = "Web";
            // 
            // colId
            // 
            this.colId.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colId.AppearanceHeader.Options.UseFont = true;
            this.colId.Caption = "gridColumn7";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.gridColumn5.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridColumn5.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn5.AppearanceHeader.Options.UseFont = true;
            this.gridColumn5.Caption = "ÖBF KODU";
            this.gridColumn5.FieldName = "StokNumber";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.OptionsColumn.AllowFocus = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            this.gridColumn5.Width = 92;
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
            this.gridColumn1.Caption = "ÖBF KODU";
            this.gridColumn1.FieldName = "Number";
            this.gridColumn1.MaxWidth = 100;
            this.gridColumn1.MinWidth = 100;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.OptionsFilter.AllowFilter = false;
            this.gridColumn1.Width = 100;
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
            this.gridColumn2.FieldName = "Description";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.OptionsFilter.AllowFilter = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 529;
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
            this.gridColumn3.FieldName = "Unit";
            this.gridColumn3.MaxWidth = 60;
            this.gridColumn3.MinWidth = 60;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowFocus = false;
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.OptionsFilter.AllowFilter = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 60;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.gridColumn4.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridColumn4.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridColumn4.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridColumn4.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridColumn4.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn4.AppearanceHeader.Options.UseFont = true;
            this.gridColumn4.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn4.Caption = "BİRİM FİYATI";
            this.gridColumn4.DisplayFormat.FormatString = "c2";
            this.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn4.FieldName = "UnitPrice";
            this.gridColumn4.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.gridColumn4.MaxWidth = 100;
            this.gridColumn4.MinWidth = 100;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.AllowFocus = false;
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.OptionsFilter.AllowFilter = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 100;
            // 
            // btnGncelle
            // 
            this.btnGncelle.AutoHeight = false;
            this.btnGncelle.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnGncelle.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::IhalematikProUI.Properties.Resources.edit_icon, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "Güncelle", null, null, true)});
            this.btnGncelle.Name = "btnGncelle";
            this.btnGncelle.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // btnPasive
            // 
            this.btnPasive.AutoHeight = false;
            this.btnPasive.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnPasive.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnPasive.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "Pasif Yap", null, null, true)});
            this.btnPasive.Name = "btnPasive";
            this.btnPasive.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // btnActive
            // 
            this.btnActive.AutoHeight = false;
            this.btnActive.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnActive.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::IhalematikProUI.Properties.Resources.activeData, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "Aktif Yap", null, null, true)});
            this.btnActive.Name = "btnActive";
            this.btnActive.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
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
            this.groupControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(309, 694);
            this.groupControl2.TabIndex = 1;
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
            this.btnEvet.Click += new System.EventHandler(this.btnEvet_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(111, 126);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(110, 19);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Kaydedilsin mi?";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 73);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(181, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tablodaki veriler okundu.";
            // 
            // frm_TopluObfTemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 694);
            this.ControlBox = false;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.SkinName = "McSkin";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frm_TopluObfTemp";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Shown += new System.EventHandler(this.frm_TopluObfTemp_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdOBFTempList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOBFList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGncelle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPasive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl grdOBFTempList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewOBFList;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnGncelle;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnPasive;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnActive;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnHayir;
        private DevExpress.XtraEditors.SimpleButton btnEvet;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}