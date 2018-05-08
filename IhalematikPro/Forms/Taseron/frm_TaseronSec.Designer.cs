namespace IhalematikProUI.Forms.Taseron
{
    partial class frm_TaseronSec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TaseronSec));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnTamam = new DevExpress.XtraEditors.SimpleButton();
            this.grdJobber = new DevExpress.XtraGrid.GridControl();
            this.gridViewTender = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIsSelected = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpstSelected = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpstColId = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdJobber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpstSelected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpstColId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelControl2.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.btnKapat);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(440, 24);
            this.panelControl2.TabIndex = 103;
            // 
            // btnKapat
            // 
            this.btnKapat.AutoSize = true;
            this.btnKapat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKapat.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.Image")));
            this.btnKapat.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnKapat.Location = new System.Drawing.Point(414, 0);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(26, 24);
            this.btnKapat.TabIndex = 21;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl1.LineColor = System.Drawing.Color.Red;
            this.labelControl1.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.labelControl1.Location = new System.Drawing.Point(5, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.ShowLineShadow = false;
            this.labelControl1.Size = new System.Drawing.Size(108, 23);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "TAŞERON SEÇ";
            this.labelControl1.UseMnemonic = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnTamam);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 384);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(440, 49);
            this.panelControl1.TabIndex = 105;
            // 
            // btnTamam
            // 
            this.btnTamam.Appearance.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTamam.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.btnTamam.Appearance.Options.UseFont = true;
            this.btnTamam.Appearance.Options.UseForeColor = true;
            this.btnTamam.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTamam.Image = ((System.Drawing.Image)(resources.GetObject("btnTamam.Image")));
            this.btnTamam.Location = new System.Drawing.Point(349, 5);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(87, 38);
            this.btnTamam.TabIndex = 10;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // grdJobber
            // 
            this.grdJobber.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.grdJobber.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.grdJobber.Location = new System.Drawing.Point(0, 24);
            this.grdJobber.MainView = this.gridViewTender;
            this.grdJobber.Name = "grdJobber";
            this.grdJobber.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rpstColId,
            this.rpstSelected});
            this.grdJobber.Size = new System.Drawing.Size(440, 360);
            this.grdJobber.TabIndex = 106;
            this.grdJobber.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTender,
            this.gridView1});
            // 
            // gridViewTender
            // 
            this.gridViewTender.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridViewTender.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gridViewTender.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridViewTender.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewTender.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridViewTender.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridViewTender.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridViewTender.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridViewTender.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.gridViewTender.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(215)))));
            this.gridViewTender.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White;
            this.gridViewTender.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gridViewTender.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridViewTender.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridViewTender.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridViewTender.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridViewTender.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gridViewTender.Appearance.Empty.Options.UseBackColor = true;
            this.gridViewTender.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridViewTender.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewTender.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridViewTender.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridViewTender.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridViewTender.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gridViewTender.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridViewTender.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridViewTender.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridViewTender.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridViewTender.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gridViewTender.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gridViewTender.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridViewTender.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridViewTender.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(148)))));
            this.gridViewTender.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridViewTender.Appearance.FocusedRow.BackColor = System.Drawing.Color.DodgerBlue;
            this.gridViewTender.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewTender.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewTender.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewTender.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridViewTender.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gridViewTender.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridViewTender.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridViewTender.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridViewTender.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridViewTender.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridViewTender.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridViewTender.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewTender.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridViewTender.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridViewTender.Appearance.GroupButton.Options.UseForeColor = true;
            this.gridViewTender.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridViewTender.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridViewTender.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridViewTender.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridViewTender.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridViewTender.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridViewTender.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gridViewTender.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridViewTender.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewTender.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridViewTender.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridViewTender.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridViewTender.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewTender.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewTender.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridViewTender.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gridViewTender.Appearance.GroupRow.Options.UseFont = true;
            this.gridViewTender.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridViewTender.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridViewTender.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gridViewTender.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridViewTender.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewTender.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridViewTender.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridViewTender.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridViewTender.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewTender.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.gridViewTender.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gridViewTender.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewTender.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewTender.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.gridViewTender.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridViewTender.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridViewTender.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewTender.Appearance.OddRow.Options.UseBackColor = true;
            this.gridViewTender.Appearance.OddRow.Options.UseForeColor = true;
            this.gridViewTender.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.gridViewTender.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.gridViewTender.Appearance.Preview.Options.UseBackColor = true;
            this.gridViewTender.Appearance.Preview.Options.UseForeColor = true;
            this.gridViewTender.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridViewTender.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridViewTender.Appearance.Row.Options.UseBackColor = true;
            this.gridViewTender.Appearance.Row.Options.UseForeColor = true;
            this.gridViewTender.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gridViewTender.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridViewTender.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(197)))), ((int)(((byte)(205)))));
            this.gridViewTender.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewTender.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewTender.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewTender.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.gridViewTender.Appearance.VertLine.Options.UseBackColor = true;
            this.gridViewTender.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIsSelected,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn10});
            this.gridViewTender.GridControl = this.grdJobber;
            this.gridViewTender.Name = "gridViewTender";
            this.gridViewTender.OptionsDetail.AllowZoomDetail = false;
            this.gridViewTender.OptionsDetail.EnableMasterViewMode = false;
            this.gridViewTender.OptionsDetail.ShowDetailTabs = false;
            this.gridViewTender.OptionsDetail.SmartDetailExpand = false;
            this.gridViewTender.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gridViewTender.OptionsFilter.AllowFilterEditor = false;
            this.gridViewTender.OptionsFilter.AllowFilterIncrementalSearch = false;
            this.gridViewTender.OptionsFilter.AllowMRUFilterList = false;
            this.gridViewTender.OptionsFilter.AllowMultiSelectInCheckedFilterPopup = false;
            this.gridViewTender.OptionsFilter.ShowAllTableValuesInCheckedFilterPopup = false;
            this.gridViewTender.OptionsFind.AllowFindPanel = false;
            this.gridViewTender.OptionsFind.ClearFindOnClose = false;
            this.gridViewTender.OptionsFind.HighlightFindResults = false;
            this.gridViewTender.OptionsFind.ShowCloseButton = false;
            this.gridViewTender.OptionsFind.ShowFindButton = false;
            this.gridViewTender.OptionsMenu.EnableColumnMenu = false;
            this.gridViewTender.OptionsMenu.EnableFooterMenu = false;
            this.gridViewTender.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewTender.OptionsMenu.ShowAutoFilterRowItem = false;
            this.gridViewTender.OptionsMenu.ShowSplitItem = false;
            this.gridViewTender.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewTender.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewTender.OptionsView.ShowDetailButtons = false;
            this.gridViewTender.OptionsView.ShowFooter = true;
            this.gridViewTender.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.gridViewTender.OptionsView.ShowGroupPanel = false;
            this.gridViewTender.OptionsView.ShowIndicator = false;
            this.gridViewTender.PaintStyleName = "Web";
            // 
            // colIsSelected
            // 
            this.colIsSelected.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colIsSelected.AppearanceHeader.Options.UseFont = true;
            this.colIsSelected.Caption = " ";
            this.colIsSelected.ColumnEdit = this.rpstSelected;
            this.colIsSelected.FieldName = "IsSelected";
            this.colIsSelected.Name = "colIsSelected";
            this.colIsSelected.OptionsFilter.AllowFilter = false;
            this.colIsSelected.Visible = true;
            this.colIsSelected.VisibleIndex = 0;
            this.colIsSelected.Width = 41;
            // 
            // rpstSelected
            // 
            this.rpstSelected.AutoHeight = false;
            this.rpstSelected.LookAndFeel.SkinName = "McSkin";
            this.rpstSelected.LookAndFeel.UseDefaultLookAndFeel = false;
            this.rpstSelected.Name = "rpstSelected";
            this.rpstSelected.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.rpstSelected.CheckedChanged += new System.EventHandler(this.rpstSelected_CheckedChanged);
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.FieldName = "Id";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            this.gridColumn3.Caption = "Taşeron Adı";
            this.gridColumn3.FieldName = "CompanyName";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowFocus = false;
            this.gridColumn3.OptionsFilter.AllowFilter = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 88;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridColumn4.AppearanceHeader.Options.UseFont = true;
            this.gridColumn4.Caption = "Şehir";
            this.gridColumn4.FieldName = "City";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.AllowFocus = false;
            this.gridColumn4.OptionsFilter.AllowFilter = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 102;
            // 
            // gridColumn10
            // 
            this.gridColumn10.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridColumn10.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridColumn10.AppearanceHeader.Options.UseBorderColor = true;
            this.gridColumn10.AppearanceHeader.Options.UseFont = true;
            this.gridColumn10.Caption = "Puan";
            this.gridColumn10.FieldName = "Score";
            this.gridColumn10.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Value;
            this.gridColumn10.MinWidth = 80;
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            this.gridColumn10.OptionsColumn.AllowFocus = false;
            this.gridColumn10.OptionsColumn.ReadOnly = true;
            this.gridColumn10.OptionsFilter.AllowFilter = false;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 2;
            this.gridColumn10.Width = 246;
            // 
            // rpstColId
            // 
            this.rpstColId.AutoHeight = false;
            this.rpstColId.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.rpstColId.Name = "rpstColId";
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdJobber;
            this.gridView1.Name = "gridView1";
            // 
            // frm_TaseronSec
            // 
            this.AcceptButton = this.btnTamam;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 433);
            this.ControlBox = false;
            this.Controls.Add(this.grdJobber);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_TaseronSec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Shown += new System.EventHandler(this.frm_TaseronSec_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdJobber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpstSelected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpstColId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnTamam;
        private DevExpress.XtraGrid.GridControl grdJobber;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTender;
        private DevExpress.XtraGrid.Columns.GridColumn colIsSelected;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit rpstSelected;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit rpstColId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}