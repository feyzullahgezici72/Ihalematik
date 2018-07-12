namespace IhalematikProUI.Forms.PozTem
{
    partial class frm_TopluPozTemp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TopluPozTemp));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btnHayir = new DevExpress.XtraEditors.SimpleButton();
            this.btnEvet = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.grdPozTempList = new DevExpress.XtraGrid.GridControl();
            this.gridViewPozList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnGncelle = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnPasive = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnActive = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPozTempList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPozList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGncelle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPasive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnActive)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.groupControl3);
            this.groupControl2.Controls.Add(this.groupControl4);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(309, 694);
            this.groupControl2.TabIndex = 3;
            // 
            // groupControl3
            // 
            this.groupControl3.AppearanceCaption.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl3.AppearanceCaption.ForeColor = System.Drawing.Color.Red;
            this.groupControl3.AppearanceCaption.Options.UseFont = true;
            this.groupControl3.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl3.Controls.Add(this.btnHayir);
            this.groupControl3.Controls.Add(this.btnEvet);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl3.Location = new System.Drawing.Point(3, 72);
            this.groupControl3.LookAndFeel.SkinName = "Seven Classic";
            this.groupControl3.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(303, 105);
            this.groupControl3.TabIndex = 6;
            this.groupControl3.Text = "Kaydedilsin mi?";
            // 
            // btnHayir
            // 
            this.btnHayir.Image = ((System.Drawing.Image)(resources.GetObject("btnHayir.Image")));
            this.btnHayir.Location = new System.Drawing.Point(154, 42);
            this.btnHayir.Name = "btnHayir";
            this.btnHayir.Size = new System.Drawing.Size(142, 57);
            this.btnHayir.TabIndex = 1;
            this.btnHayir.Text = "&Hayır";
            this.btnHayir.Click += new System.EventHandler(this.btnHayir_Click);
            // 
            // btnEvet
            // 
            this.btnEvet.Image = ((System.Drawing.Image)(resources.GetObject("btnEvet.Image")));
            this.btnEvet.Location = new System.Drawing.Point(9, 42);
            this.btnEvet.Name = "btnEvet";
            this.btnEvet.Size = new System.Drawing.Size(140, 57);
            this.btnEvet.TabIndex = 1;
            this.btnEvet.Text = "&Evet";
            this.btnEvet.Click += new System.EventHandler(this.btnEvet_Click);
            // 
            // groupControl4
            // 
            this.groupControl4.AppearanceCaption.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl4.AppearanceCaption.Options.UseFont = true;
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl4.Location = new System.Drawing.Point(3, 30);
            this.groupControl4.LookAndFeel.SkinName = "Seven Classic";
            this.groupControl4.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(303, 42);
            this.groupControl4.TabIndex = 5;
            this.groupControl4.Text = "Tablodaki veriler okundu!";
            // 
            // grdPozTempList
            // 
            this.grdPozTempList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdPozTempList.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.grdPozTempList.Location = new System.Drawing.Point(309, 0);
            this.grdPozTempList.MainView = this.gridViewPozList;
            this.grdPozTempList.Margin = new System.Windows.Forms.Padding(4);
            this.grdPozTempList.Name = "grdPozTempList";
            this.grdPozTempList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnGncelle,
            this.btnPasive,
            this.btnActive});
            this.grdPozTempList.Size = new System.Drawing.Size(919, 694);
            this.grdPozTempList.TabIndex = 25;
            this.grdPozTempList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPozList});
            // 
            // gridViewPozList
            // 
            this.gridViewPozList.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver;
            this.gridViewPozList.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewPozList.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Silver;
            this.gridViewPozList.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray;
            this.gridViewPozList.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridViewPozList.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridViewPozList.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridViewPozList.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewPozList.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gridViewPozList.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewPozList.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue;
            this.gridViewPozList.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridViewPozList.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridViewPozList.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridViewPozList.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gridViewPozList.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite;
            this.gridViewPozList.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewPozList.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewPozList.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridViewPozList.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridViewPozList.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewPozList.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.gridViewPozList.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewPozList.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewPozList.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewPozList.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridViewPozList.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridViewPozList.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridViewPozList.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(80)))), ((int)(((byte)(135)))));
            this.gridViewPozList.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewPozList.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gridViewPozList.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewPozList.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridViewPozList.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridViewPozList.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.gridViewPozList.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridViewPozList.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.gridViewPozList.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gridViewPozList.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridViewPozList.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridViewPozList.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewPozList.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewPozList.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver;
            this.gridViewPozList.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver;
            this.gridViewPozList.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewPozList.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridViewPozList.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridViewPozList.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewPozList.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.gridViewPozList.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.gridViewPozList.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewPozList.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridViewPozList.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridViewPozList.Appearance.GroupButton.Options.UseForeColor = true;
            this.gridViewPozList.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gridViewPozList.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gridViewPozList.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridViewPozList.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridViewPozList.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridViewPozList.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridViewPozList.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.gridViewPozList.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gridViewPozList.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewPozList.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.gridViewPozList.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewPozList.Appearance.GroupPanel.Options.UseFont = true;
            this.gridViewPozList.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridViewPozList.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray;
            this.gridViewPozList.Appearance.GroupRow.ForeColor = System.Drawing.Color.Silver;
            this.gridViewPozList.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridViewPozList.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridViewPozList.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gridViewPozList.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver;
            this.gridViewPozList.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewPozList.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewPozList.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridViewPozList.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridViewPozList.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewPozList.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewPozList.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray;
            this.gridViewPozList.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewPozList.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewPozList.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewPozList.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver;
            this.gridViewPozList.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridViewPozList.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridViewPozList.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
            this.gridViewPozList.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewPozList.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gridViewPozList.Appearance.OddRow.Options.UseBackColor = true;
            this.gridViewPozList.Appearance.OddRow.Options.UseForeColor = true;
            this.gridViewPozList.Appearance.Preview.BackColor = System.Drawing.Color.White;
            this.gridViewPozList.Appearance.Preview.ForeColor = System.Drawing.Color.Navy;
            this.gridViewPozList.Appearance.Preview.Options.UseBackColor = true;
            this.gridViewPozList.Appearance.Preview.Options.UseForeColor = true;
            this.gridViewPozList.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridViewPozList.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridViewPozList.Appearance.Row.Options.UseBackColor = true;
            this.gridViewPozList.Appearance.Row.Options.UseForeColor = true;
            this.gridViewPozList.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gridViewPozList.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.gridViewPozList.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridViewPozList.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewPozList.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewPozList.Appearance.VertLine.BackColor = System.Drawing.Color.Silver;
            this.gridViewPozList.Appearance.VertLine.Options.UseBackColor = true;
            this.gridViewPozList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gridViewPozList.GridControl = this.grdPozTempList;
            this.gridViewPozList.Name = "gridViewPozList";
            this.gridViewPozList.OptionsDetail.EnableDetailToolTip = true;
            this.gridViewPozList.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gridViewPozList.OptionsFilter.ColumnFilterPopupRowCount = 4;
            this.gridViewPozList.OptionsFilter.MRUColumnFilterListCount = 0;
            this.gridViewPozList.OptionsFilter.MRUFilterListCount = 0;
            this.gridViewPozList.OptionsFilter.MRUFilterListPopupCount = 0;
            this.gridViewPozList.OptionsFind.FindFilterColumns = "";
            this.gridViewPozList.OptionsFind.FindNullPrompt = "Poz No giriniz...";
            this.gridViewPozList.OptionsFind.SearchInPreview = true;
            this.gridViewPozList.OptionsMenu.EnableColumnMenu = false;
            this.gridViewPozList.OptionsMenu.EnableFooterMenu = false;
            this.gridViewPozList.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewPozList.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewPozList.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewPozList.OptionsView.ShowFooter = true;
            this.gridViewPozList.OptionsView.ShowGroupPanel = false;
            this.gridViewPozList.PaintStyleName = "Web";
            // 
            // colId
            // 
            this.colId.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colId.AppearanceHeader.Options.UseFont = true;
            this.colId.Caption = "gridColumn7";
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
            this.gridColumn1.FieldName = "Number";
            this.gridColumn1.MaxWidth = 100;
            this.gridColumn1.MinWidth = 100;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.OptionsFilter.AllowFilter = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
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
            this.gridColumn2.MinWidth = 80;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.OptionsFilter.AllowFilter = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 585;
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
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::IhalematikProUI.Properties.Resources.PasiveData, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "Pasif Yap", null, null, true)});
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
            // frm_TopluPozTemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 694);
            this.ControlBox = false;
            this.Controls.Add(this.grdPozTempList);
            this.Controls.Add(this.groupControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_TopluPozTemp";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OKUNAN POZ LİSTESİ";
            this.Shown += new System.EventHandler(this.frm_TopluPozTemp_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPozTempList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPozList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGncelle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPasive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnActive)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton btnHayir;
        private DevExpress.XtraEditors.SimpleButton btnEvet;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraGrid.GridControl grdPozTempList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPozList;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnGncelle;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnPasive;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnActive;
    }
}