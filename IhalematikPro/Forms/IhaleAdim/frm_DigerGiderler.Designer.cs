namespace IhalematikProUI.Forms.IhaleAdim
{
    partial class frm_DigerGiderler
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DigerGiderler));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.grdOtherExpenses = new DevExpress.XtraGrid.GridControl();
            this.gridViewOtherExpenses = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSil = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.bindingSourceOtherExpenses = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOtherExpenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOtherExpenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOtherExpenses)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKapat
            // 
            this.btnKapat.AutoSize = true;
            this.btnKapat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKapat.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.Image")));
            this.btnKapat.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnKapat.Location = new System.Drawing.Point(507, 0);
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
            this.labelControl1.Location = new System.Drawing.Point(7, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.ShowLineShadow = false;
            this.labelControl1.Size = new System.Drawing.Size(130, 23);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "DİĞER GİDERLER";
            this.labelControl1.UseMnemonic = false;
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelControl2.Appearance.BackColor2 = System.Drawing.Color.DodgerBlue;
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.btnKapat);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(533, 24);
            this.panelControl2.TabIndex = 99;
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.Red;
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl2.Controls.Add(this.grdOtherExpenses);
            this.groupControl2.Controls.Add(this.groupControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 24);
            this.groupControl2.LookAndFeel.SkinName = "London Liquid Sky";
            this.groupControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl2.LookAndFeel.UseWindowsXPTheme = true;
            this.groupControl2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(533, 338);
            this.groupControl2.TabIndex = 101;
            // 
            // grdOtherExpenses
            // 
            this.grdOtherExpenses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.grdOtherExpenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdOtherExpenses.Location = new System.Drawing.Point(2, 2);
            this.grdOtherExpenses.MainView = this.gridViewOtherExpenses;
            this.grdOtherExpenses.Name = "grdOtherExpenses";
            this.grdOtherExpenses.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnSil});
            this.grdOtherExpenses.Size = new System.Drawing.Size(529, 297);
            this.grdOtherExpenses.TabIndex = 2;
            this.grdOtherExpenses.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewOtherExpenses});
            // 
            // gridViewOtherExpenses
            // 
            this.gridViewOtherExpenses.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver;
            this.gridViewOtherExpenses.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewOtherExpenses.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Silver;
            this.gridViewOtherExpenses.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray;
            this.gridViewOtherExpenses.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridViewOtherExpenses.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridViewOtherExpenses.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridViewOtherExpenses.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewOtherExpenses.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gridViewOtherExpenses.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewOtherExpenses.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue;
            this.gridViewOtherExpenses.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridViewOtherExpenses.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridViewOtherExpenses.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridViewOtherExpenses.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gridViewOtherExpenses.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite;
            this.gridViewOtherExpenses.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewOtherExpenses.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewOtherExpenses.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridViewOtherExpenses.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridViewOtherExpenses.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewOtherExpenses.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.gridViewOtherExpenses.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewOtherExpenses.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewOtherExpenses.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewOtherExpenses.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridViewOtherExpenses.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridViewOtherExpenses.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridViewOtherExpenses.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(80)))), ((int)(((byte)(135)))));
            this.gridViewOtherExpenses.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewOtherExpenses.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gridViewOtherExpenses.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewOtherExpenses.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridViewOtherExpenses.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridViewOtherExpenses.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.gridViewOtherExpenses.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridViewOtherExpenses.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.gridViewOtherExpenses.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gridViewOtherExpenses.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridViewOtherExpenses.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridViewOtherExpenses.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewOtherExpenses.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewOtherExpenses.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver;
            this.gridViewOtherExpenses.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver;
            this.gridViewOtherExpenses.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewOtherExpenses.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridViewOtherExpenses.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridViewOtherExpenses.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewOtherExpenses.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.gridViewOtherExpenses.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.gridViewOtherExpenses.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewOtherExpenses.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridViewOtherExpenses.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridViewOtherExpenses.Appearance.GroupButton.Options.UseForeColor = true;
            this.gridViewOtherExpenses.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gridViewOtherExpenses.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gridViewOtherExpenses.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridViewOtherExpenses.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridViewOtherExpenses.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridViewOtherExpenses.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridViewOtherExpenses.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.gridViewOtherExpenses.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gridViewOtherExpenses.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewOtherExpenses.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.gridViewOtherExpenses.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewOtherExpenses.Appearance.GroupPanel.Options.UseFont = true;
            this.gridViewOtherExpenses.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridViewOtherExpenses.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray;
            this.gridViewOtherExpenses.Appearance.GroupRow.ForeColor = System.Drawing.Color.Silver;
            this.gridViewOtherExpenses.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridViewOtherExpenses.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridViewOtherExpenses.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gridViewOtherExpenses.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver;
            this.gridViewOtherExpenses.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewOtherExpenses.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewOtherExpenses.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridViewOtherExpenses.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridViewOtherExpenses.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewOtherExpenses.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewOtherExpenses.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray;
            this.gridViewOtherExpenses.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewOtherExpenses.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewOtherExpenses.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewOtherExpenses.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver;
            this.gridViewOtherExpenses.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridViewOtherExpenses.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridViewOtherExpenses.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
            this.gridViewOtherExpenses.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewOtherExpenses.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gridViewOtherExpenses.Appearance.OddRow.Options.UseBackColor = true;
            this.gridViewOtherExpenses.Appearance.OddRow.Options.UseForeColor = true;
            this.gridViewOtherExpenses.Appearance.Preview.BackColor = System.Drawing.Color.White;
            this.gridViewOtherExpenses.Appearance.Preview.ForeColor = System.Drawing.Color.Navy;
            this.gridViewOtherExpenses.Appearance.Preview.Options.UseBackColor = true;
            this.gridViewOtherExpenses.Appearance.Preview.Options.UseForeColor = true;
            this.gridViewOtherExpenses.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridViewOtherExpenses.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridViewOtherExpenses.Appearance.Row.Options.UseBackColor = true;
            this.gridViewOtherExpenses.Appearance.Row.Options.UseForeColor = true;
            this.gridViewOtherExpenses.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gridViewOtherExpenses.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.gridViewOtherExpenses.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridViewOtherExpenses.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewOtherExpenses.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewOtherExpenses.Appearance.VertLine.BackColor = System.Drawing.Color.Silver;
            this.gridViewOtherExpenses.Appearance.VertLine.Options.UseBackColor = true;
            this.gridViewOtherExpenses.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridViewOtherExpenses.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colDescription,
            this.colPrice,
            this.colDelete});
            this.gridViewOtherExpenses.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridViewOtherExpenses.GridControl = this.grdOtherExpenses;
            this.gridViewOtherExpenses.Name = "gridViewOtherExpenses";
            this.gridViewOtherExpenses.OptionsDetail.AllowExpandEmptyDetails = true;
            this.gridViewOtherExpenses.OptionsDetail.ShowDetailTabs = false;
            this.gridViewOtherExpenses.OptionsMenu.EnableColumnMenu = false;
            this.gridViewOtherExpenses.OptionsMenu.EnableFooterMenu = false;
            this.gridViewOtherExpenses.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewOtherExpenses.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewOtherExpenses.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewOtherExpenses.OptionsSelection.CheckBoxSelectorColumnWidth = 60;
            this.gridViewOtherExpenses.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewOtherExpenses.OptionsSelection.ShowCheckBoxSelectorInPrintExport = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewOtherExpenses.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewOtherExpenses.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewOtherExpenses.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridViewOtherExpenses.OptionsView.ShowFooter = true;
            this.gridViewOtherExpenses.OptionsView.ShowGroupPanel = false;
            this.gridViewOtherExpenses.PaintStyleName = "Web";
            this.gridViewOtherExpenses.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewOtherExpenses_CellValueChanged);
            // 
            // colId
            // 
            this.colId.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colId.AppearanceHeader.Options.UseFont = true;
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colDescription
            // 
            this.colDescription.AppearanceHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.colDescription.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colDescription.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colDescription.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colDescription.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.colDescription.AppearanceHeader.Options.UseBackColor = true;
            this.colDescription.AppearanceHeader.Options.UseFont = true;
            this.colDescription.AppearanceHeader.Options.UseForeColor = true;
            this.colDescription.Caption = "GİDER AÇIKLAMASI";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsFilter.AllowFilter = false;
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 0;
            this.colDescription.Width = 535;
            // 
            // colPrice
            // 
            this.colPrice.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPrice.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.colPrice.AppearanceHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.colPrice.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colPrice.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colPrice.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colPrice.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.colPrice.AppearanceHeader.Options.UseBackColor = true;
            this.colPrice.AppearanceHeader.Options.UseFont = true;
            this.colPrice.AppearanceHeader.Options.UseForeColor = true;
            this.colPrice.Caption = "TUTARI";
            this.colPrice.DisplayFormat.FormatString = "c2";
            this.colPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrice.FieldName = "Price";
            this.colPrice.GroupFormat.FormatString = "c2";
            this.colPrice.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrice.MaxWidth = 90;
            this.colPrice.MinWidth = 90;
            this.colPrice.Name = "colPrice";
            this.colPrice.OptionsFilter.AllowFilter = false;
            this.colPrice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Price", "{0:c2}")});
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 1;
            this.colPrice.Width = 90;
            // 
            // colDelete
            // 
            this.colDelete.AppearanceHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.colDelete.AppearanceHeader.Options.UseBackColor = true;
            this.colDelete.ColumnEdit = this.btnSil;
            this.colDelete.MaxWidth = 20;
            this.colDelete.Name = "colDelete";
            this.colDelete.Visible = true;
            this.colDelete.VisibleIndex = 2;
            this.colDelete.Width = 20;
            // 
            // btnSil
            // 
            this.btnSil.AutoHeight = false;
            this.btnSil.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnSil.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::IhalematikProUI.Properties.Resources.erase_icon, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btnSil.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnSil.LookAndFeel.SkinName = "London Liquid Sky";
            this.btnSil.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnSil.Name = "btnSil";
            this.btnSil.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Blue;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl1.CaptionLocation = DevExpress.Utils.Locations.Left;
            this.groupControl1.Controls.Add(this.btnOk);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(2, 299);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(529, 37);
            this.groupControl1.TabIndex = 101;
            // 
            // btnOk
            // 
            this.btnOk.Image = ((System.Drawing.Image)(resources.GetObject("btnOk.Image")));
            this.btnOk.Location = new System.Drawing.Point(453, 5);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(71, 28);
            this.btnOk.TabIndex = 141;
            this.btnOk.Text = "Tamam";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frm_DigerGiderler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnKapat;
            this.ClientSize = new System.Drawing.Size(533, 362);
            this.ControlBox = false;
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.panelControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_DigerGiderler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Shown += new System.EventHandler(this.frm_DigerGiderler_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdOtherExpenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOtherExpenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOtherExpenses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        public DevExpress.XtraGrid.GridControl grdOtherExpenses;
        public DevExpress.XtraGrid.Views.Grid.GridView gridViewOtherExpenses;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private System.Windows.Forms.BindingSource bindingSourceOtherExpenses;
        private DevExpress.XtraGrid.Columns.GridColumn colDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnSil;
    }
}