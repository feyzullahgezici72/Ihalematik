namespace IhalematikProUI.Forms.IhaleAdim
{
    partial class frm_Nakliye
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Nakliye));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtCarriage = new DevExpress.XtraEditors.TextEdit();
            this.btnResetValue = new DevExpress.XtraEditors.SimpleButton();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.grdMaterialList = new DevExpress.XtraGrid.GridControl();
            this.gridViewMaterialList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCarriagePercent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNkTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCarriage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMaterialList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMaterialList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Blue;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl1.CaptionLocation = DevExpress.Utils.Locations.Left;
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.txtCarriage);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.LookAndFeel.SkinName = "London Liquid Sky";
            this.groupControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1262, 42);
            this.groupControl1.TabIndex = 97;
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl6.Location = new System.Drawing.Point(33, 10);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(120, 19);
            this.labelControl6.TabIndex = 140;
            this.labelControl6.Text = "Nakliye Toplamı:";
            // 
            // txtCarriage
            // 
            this.txtCarriage.Location = new System.Drawing.Point(160, 7);
            this.txtCarriage.Name = "txtCarriage";
            this.txtCarriage.Properties.DisplayFormat.FormatString = "c2";
            this.txtCarriage.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtCarriage.Properties.EditFormat.FormatString = "c2";
            this.txtCarriage.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtCarriage.Properties.Mask.BeepOnError = true;
            this.txtCarriage.Properties.Mask.EditMask = "c2";
            this.txtCarriage.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCarriage.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtCarriage.Size = new System.Drawing.Size(177, 26);
            this.txtCarriage.TabIndex = 0;
            // 
            // btnResetValue
            // 
            this.btnResetValue.Image = ((System.Drawing.Image)(resources.GetObject("btnResetValue.Image")));
            this.btnResetValue.Location = new System.Drawing.Point(1220, 494);
            this.btnResetValue.Name = "btnResetValue";
            this.btnResetValue.Size = new System.Drawing.Size(33, 41);
            this.btnResetValue.TabIndex = 142;
            this.btnResetValue.ToolTip = "Sıfırla";
            this.btnResetValue.Click += new System.EventHandler(this.btnResetValue_Click);
            // 
            // btnOk
            // 
            this.btnOk.Image = ((System.Drawing.Image)(resources.GetObject("btnOk.Image")));
            this.btnOk.Location = new System.Drawing.Point(1106, 494);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(106, 41);
            this.btnOk.TabIndex = 141;
            this.btnOk.Text = "&Tamam";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.Black;
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl2.Controls.Add(this.simpleButton1);
            this.groupControl2.Controls.Add(this.btnResetValue);
            this.groupControl2.Controls.Add(this.grdMaterialList);
            this.groupControl2.Controls.Add(this.btnOk);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 42);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1262, 578);
            this.groupControl2.TabIndex = 98;
            this.groupControl2.Text = "Ağırlık oranını belirtiniz";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(1220, 1);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(34, 28);
            this.simpleButton1.TabIndex = 143;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // grdMaterialList
            // 
            this.grdMaterialList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.grdMaterialList.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdMaterialList.Location = new System.Drawing.Point(3, 31);
            this.grdMaterialList.MainView = this.gridViewMaterialList;
            this.grdMaterialList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdMaterialList.Name = "grdMaterialList";
            this.grdMaterialList.Size = new System.Drawing.Size(1251, 456);
            this.grdMaterialList.TabIndex = 2;
            this.grdMaterialList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMaterialList});
            this.grdMaterialList.Click += new System.EventHandler(this.grdMaterialList_Click);
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
            this.gridColumn4,
            this.colCarriagePercent,
            this.colNkTutar});
            this.gridViewMaterialList.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridViewMaterialList.GridControl = this.grdMaterialList;
            this.gridViewMaterialList.Name = "gridViewMaterialList";
            this.gridViewMaterialList.OptionsDetail.AllowZoomDetail = false;
            this.gridViewMaterialList.OptionsDetail.EnableMasterViewMode = false;
            this.gridViewMaterialList.OptionsDetail.ShowDetailTabs = false;
            this.gridViewMaterialList.OptionsDetail.SmartDetailExpand = false;
            this.gridViewMaterialList.OptionsMenu.EnableColumnMenu = false;
            this.gridViewMaterialList.OptionsMenu.EnableFooterMenu = false;
            this.gridViewMaterialList.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewMaterialList.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewMaterialList.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewMaterialList.OptionsSelection.CheckBoxSelectorColumnWidth = 60;
            this.gridViewMaterialList.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewMaterialList.OptionsSelection.ShowCheckBoxSelectorInPrintExport = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewMaterialList.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewMaterialList.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewMaterialList.OptionsView.ShowFooter = true;
            this.gridViewMaterialList.OptionsView.ShowGroupPanel = false;
            this.gridViewMaterialList.PaintStyleName = "Web";
            this.gridViewMaterialList.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grdMaterialList2_CellValueChanged);
            this.gridViewMaterialList.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewMaterialList_CellValueChanging);
            this.gridViewMaterialList.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gridViewMaterialList_ValidatingEditor);
            // 
            // colId
            // 
            this.colId.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colId.AppearanceHeader.Options.UseFont = true;
            this.colId.Caption = "Id";
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
            this.gridColumn1.FieldName = "PozOBFNumber";
            this.gridColumn1.MaxWidth = 80;
            this.gridColumn1.MinWidth = 80;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.OptionsFilter.AllowFilter = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 80;
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
            this.gridColumn2.Caption = "İŞ KALEMİNİN ADI VE KISA AÇIKLAMA";
            this.gridColumn2.FieldName = "PozOBFDescription";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.OptionsFilter.AllowFilter = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 535;
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
            this.gridColumn3.FieldName = "PozOBFUnit";
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
            this.gridColumn4.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn4.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gridColumn4.AppearanceHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.gridColumn4.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridColumn4.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridColumn4.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridColumn4.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridColumn4.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn4.AppearanceHeader.Options.UseFont = true;
            this.gridColumn4.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn4.Caption = "MİKTARI";
            this.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn4.FieldName = "Quantity";
            this.gridColumn4.MaxWidth = 60;
            this.gridColumn4.MinWidth = 60;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.AllowFocus = false;
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.OptionsFilter.AllowFilter = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 60;
            // 
            // colCarriagePercent
            // 
            this.colCarriagePercent.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.colCarriagePercent.AppearanceCell.Options.UseBackColor = true;
            this.colCarriagePercent.AppearanceHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.colCarriagePercent.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colCarriagePercent.AppearanceHeader.Options.UseBackColor = true;
            this.colCarriagePercent.AppearanceHeader.Options.UseFont = true;
            this.colCarriagePercent.Caption = "ORAN%";
            this.colCarriagePercent.FieldName = "CarriagePercent";
            this.colCarriagePercent.MaxWidth = 60;
            this.colCarriagePercent.MinWidth = 60;
            this.colCarriagePercent.Name = "colCarriagePercent";
            this.colCarriagePercent.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CarriagePercent", "{0:0.##}")});
            this.colCarriagePercent.Visible = true;
            this.colCarriagePercent.VisibleIndex = 4;
            this.colCarriagePercent.Width = 60;
            // 
            // colNkTutar
            // 
            this.colNkTutar.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.colNkTutar.AppearanceCell.Options.UseBackColor = true;
            this.colNkTutar.AppearanceHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.colNkTutar.AppearanceHeader.Options.UseBackColor = true;
            this.colNkTutar.Caption = "N.TUTARI";
            this.colNkTutar.DisplayFormat.FormatString = "c2";
            this.colNkTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colNkTutar.FieldName = "CarriagePrice";
            this.colNkTutar.MaxWidth = 80;
            this.colNkTutar.MinWidth = 80;
            this.colNkTutar.Name = "colNkTutar";
            this.colNkTutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CarriagePrice", "{0:c2}")});
            this.colNkTutar.Visible = true;
            this.colNkTutar.VisibleIndex = 5;
            this.colNkTutar.Width = 80;
            // 
            // frm_Nakliye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 620);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Nakliye";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NAKLİYE HESAPLAMA";
            this.Load += new System.EventHandler(this.frm_Nakliye_Load);
            this.Shown += new System.EventHandler(this.frm_Nakliye_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCarriage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMaterialList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMaterialList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        public DevExpress.XtraGrid.GridControl grdMaterialList;
        public DevExpress.XtraGrid.Views.Grid.GridView gridViewMaterialList;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn colCarriagePercent;
        private DevExpress.XtraEditors.TextEdit txtCarriage;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraEditors.SimpleButton btnResetValue;
        private DevExpress.XtraGrid.Columns.GridColumn colNkTutar;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}