namespace IhalematikProUI.Forms.Taseron
{
    partial class frm_IsMalzemeEkle
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
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddedOBFPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdAddedJobberMaterialList = new DevExpress.XtraGrid.GridControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.grdMaterialList = new DevExpress.XtraGrid.GridControl();
            this.gridViewMaterialList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryTaseronTipi = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitTotalFare = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalFare = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.txtDescription = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtNumber = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnBul = new DevExpress.XtraEditors.SimpleButton();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAddedJobberMaterialList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMaterialList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMaterialList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTaseronTipi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // popupMenu1
            // 
            this.popupMenu1.Name = "popupMenu1";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.simpleButton3);
            this.panelControl3.Controls.Add(this.simpleButton2);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl3.Location = new System.Drawing.Point(0, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(80, 242);
            this.panelControl3.TabIndex = 0;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.simpleButton3.Image = global::IhalematikProUI.Properties.Resources.ok_icon__1_;
            this.simpleButton3.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButton3.Location = new System.Drawing.Point(2, 57);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(76, 55);
            this.simpleButton3.TabIndex = 1;
            this.simpleButton3.Text = "&Tamam";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.simpleButton2.Image = global::IhalematikProUI.Properties.Resources.Actions_trash_empty_icon__1_;
            this.simpleButton2.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButton2.Location = new System.Drawing.Point(2, 2);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(76, 55);
            this.simpleButton2.TabIndex = 0;
            this.simpleButton2.Text = "Çı&kar";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // gridView2
            // 
            this.gridView2.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver;
            this.gridView2.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridView2.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Silver;
            this.gridView2.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray;
            this.gridView2.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView2.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView2.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView2.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridView2.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gridView2.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridView2.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue;
            this.gridView2.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridView2.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridView2.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridView2.Appearance.EvenRow.BackColor = System.Drawing.Color.Silver;
            this.gridView2.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite;
            this.gridView2.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridView2.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView2.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridView2.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridView2.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.gridView2.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridView2.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridView2.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridView2.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridView2.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridView2.Appearance.FilterPanel.BackColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridView2.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gridView2.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridView2.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridView2.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridView2.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.gridView2.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView2.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gridView2.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView2.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridView2.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView2.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver;
            this.gridView2.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver;
            this.gridView2.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridView2.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridView2.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridView2.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.gridView2.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.gridView2.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridView2.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridView2.Appearance.GroupButton.Options.UseForeColor = true;
            this.gridView2.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gridView2.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gridView2.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridView2.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridView2.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridView2.Appearance.GroupPanel.BackColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gridView2.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridView2.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.gridView2.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView2.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView2.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView2.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray;
            this.gridView2.Appearance.GroupRow.ForeColor = System.Drawing.Color.Silver;
            this.gridView2.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridView2.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridView2.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gridView2.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver;
            this.gridView2.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridView2.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView2.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView2.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView2.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView2.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray;
            this.gridView2.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridView2.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView2.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridView2.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver;
            this.gridView2.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridView2.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridView2.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
            this.gridView2.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gridView2.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView2.Appearance.OddRow.Options.UseForeColor = true;
            this.gridView2.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.gridView2.Appearance.Preview.BackColor2 = System.Drawing.Color.White;
            this.gridView2.Appearance.Preview.ForeColor = System.Drawing.Color.Purple;
            this.gridView2.Appearance.Preview.Options.UseBackColor = true;
            this.gridView2.Appearance.Preview.Options.UseForeColor = true;
            this.gridView2.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridView2.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.Row.Options.UseBackColor = true;
            this.gridView2.Appearance.Row.Options.UseForeColor = true;
            this.gridView2.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gridView2.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridView2.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridView2.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridView2.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView2.Appearance.VertLine.BackColor = System.Drawing.Color.Silver;
            this.gridView2.Appearance.VertLine.Options.UseBackColor = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.colAddedOBFPrice});
            this.gridView2.GridControl = this.grdAddedJobberMaterialList;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsFind.AllowFindPanel = false;
            this.gridView2.OptionsFind.ClearFindOnClose = false;
            this.gridView2.OptionsFind.FindFilterColumns = "";
            this.gridView2.OptionsFind.HighlightFindResults = false;
            this.gridView2.OptionsFind.ShowClearButton = false;
            this.gridView2.OptionsFind.ShowCloseButton = false;
            this.gridView2.OptionsFind.ShowFindButton = false;
            this.gridView2.OptionsMenu.EnableColumnMenu = false;
            this.gridView2.OptionsMenu.EnableFooterMenu = false;
            this.gridView2.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridView2.OptionsSelection.CheckBoxSelectorColumnWidth = 30;
            this.gridView2.OptionsSelection.MultiSelect = true;
            this.gridView2.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView2.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView2.OptionsView.EnableAppearanceOddRow = true;
            this.gridView2.OptionsView.ShowDetailButtons = false;
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.PaintStyleName = "Web";
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.gridColumn5.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridColumn5.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridColumn5.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridColumn5.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn5.AppearanceHeader.Options.UseFont = true;
            this.gridColumn5.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn5.Caption = "KODU";
            this.gridColumn5.FieldName = "MaterialList";
            this.gridColumn5.MinWidth = 80;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.OptionsColumn.AllowFocus = false;
            this.gridColumn5.OptionsColumn.ReadOnly = true;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            this.gridColumn5.Width = 122;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.gridColumn6.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridColumn6.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridColumn6.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridColumn6.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn6.AppearanceHeader.Options.UseFont = true;
            this.gridColumn6.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn6.Caption = "İŞİN AÇIKLAMASI";
            this.gridColumn6.FieldName = "PozOBFDescription";
            this.gridColumn6.MinWidth = 80;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.OptionsColumn.AllowFocus = false;
            this.gridColumn6.OptionsColumn.ReadOnly = true;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            this.gridColumn6.Width = 656;
            // 
            // gridColumn7
            // 
            this.gridColumn7.AppearanceHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.gridColumn7.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridColumn7.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridColumn7.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridColumn7.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn7.AppearanceHeader.Options.UseFont = true;
            this.gridColumn7.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn7.Caption = "BİRİMİ";
            this.gridColumn7.FieldName = "PozOBFUnit";
            this.gridColumn7.MaxWidth = 60;
            this.gridColumn7.MinWidth = 60;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.OptionsColumn.AllowFocus = false;
            this.gridColumn7.OptionsColumn.ReadOnly = true;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 3;
            this.gridColumn7.Width = 60;
            // 
            // colAddedOBFPrice
            // 
            this.colAddedOBFPrice.AppearanceHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.colAddedOBFPrice.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colAddedOBFPrice.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colAddedOBFPrice.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.colAddedOBFPrice.AppearanceHeader.Options.UseBackColor = true;
            this.colAddedOBFPrice.AppearanceHeader.Options.UseFont = true;
            this.colAddedOBFPrice.AppearanceHeader.Options.UseForeColor = true;
            this.colAddedOBFPrice.Caption = "BİRİM FİYATI";
            this.colAddedOBFPrice.DisplayFormat.FormatString = "c";
            this.colAddedOBFPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAddedOBFPrice.FieldName = "PozOBFUnitPrice";
            this.colAddedOBFPrice.MaxWidth = 100;
            this.colAddedOBFPrice.MinWidth = 100;
            this.colAddedOBFPrice.Name = "colAddedOBFPrice";
            this.colAddedOBFPrice.OptionsColumn.AllowEdit = false;
            this.colAddedOBFPrice.OptionsColumn.AllowFocus = false;
            this.colAddedOBFPrice.OptionsColumn.ReadOnly = true;
            this.colAddedOBFPrice.Visible = true;
            this.colAddedOBFPrice.VisibleIndex = 4;
            this.colAddedOBFPrice.Width = 100;
            // 
            // grdAddedJobberMaterialList
            // 
            this.grdAddedJobberMaterialList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdAddedJobberMaterialList.Location = new System.Drawing.Point(80, 0);
            this.grdAddedJobberMaterialList.MainView = this.gridView2;
            this.grdAddedJobberMaterialList.Name = "grdAddedJobberMaterialList";
            this.grdAddedJobberMaterialList.Size = new System.Drawing.Size(700, 242);
            this.grdAddedJobberMaterialList.TabIndex = 0;
            this.grdAddedJobberMaterialList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // groupControl3
            // 
            this.groupControl3.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl3.AppearanceCaption.Options.UseFont = true;
            this.groupControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl3.Controls.Add(this.grdAddedJobberMaterialList);
            this.groupControl3.Controls.Add(this.panelControl3);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 234);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(780, 242);
            this.groupControl3.TabIndex = 37;
            this.groupControl3.Text = "Eklenen Malzemeler";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl1.Controls.Add(this.grdMaterialList);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 34);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(780, 200);
            this.groupControl1.TabIndex = 36;
            this.groupControl1.Text = "ÖBF Malzeme Listesi";
            // 
            // grdMaterialList
            // 
            this.grdMaterialList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.grdMaterialList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMaterialList.Location = new System.Drawing.Point(0, 0);
            this.grdMaterialList.MainView = this.gridViewMaterialList;
            this.grdMaterialList.Name = "grdMaterialList";
            this.grdMaterialList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryTaseronTipi,
            this.repositoryItemCheckEdit1});
            this.grdMaterialList.Size = new System.Drawing.Size(780, 200);
            this.grdMaterialList.TabIndex = 2;
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
            this.gridColumn8,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.colUnitTotalFare,
            this.colTotalFare});
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
            this.gridViewMaterialList.OptionsSelection.MultiSelect = true;
            this.gridViewMaterialList.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewMaterialList.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewMaterialList.OptionsSelection.ShowCheckBoxSelectorInPrintExport = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewMaterialList.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewMaterialList.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewMaterialList.OptionsView.ShowFooter = true;
            this.gridViewMaterialList.OptionsView.ShowGroupPanel = false;
            this.gridViewMaterialList.PaintStyleName = "Web";
            // 
            // gridColumn8
            // 
            this.gridColumn8.AppearanceHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.gridColumn8.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridColumn8.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn8.AppearanceHeader.Options.UseFont = true;
            this.gridColumn8.Caption = "TSR.TİPİ";
            this.gridColumn8.ColumnEdit = this.repositoryTaseronTipi;
            this.gridColumn8.FieldName = "JobberTypeValue";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 1;
            // 
            // repositoryTaseronTipi
            // 
            this.repositoryTaseronTipi.AutoHeight = false;
            this.repositoryTaseronTipi.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryTaseronTipi.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Meterial", "Malzeme"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Work", "İşçilik"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MeterialAndWork", "Malzeme+İşçilik")});
            this.repositoryTaseronTipi.Name = "repositoryTaseronTipi";
            this.repositoryTaseronTipi.NullText = "Taşeron Tipi Seçin";
            this.repositoryTaseronTipi.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.repositoryTaseronTipi_CustomDisplayText);
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridColumn1.AppearanceCell.Options.UseFont = true;
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
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 80;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridColumn2.AppearanceCell.Options.UseFont = true;
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
            this.gridColumn2.VisibleIndex = 3;
            this.gridColumn2.Width = 535;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridColumn3.AppearanceCell.Options.UseFont = true;
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
            this.gridColumn3.VisibleIndex = 4;
            this.gridColumn3.Width = 60;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridColumn4.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gridColumn4.AppearanceCell.Options.UseFont = true;
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
            this.gridColumn4.VisibleIndex = 5;
            this.gridColumn4.Width = 60;
            // 
            // colUnitTotalFare
            // 
            this.colUnitTotalFare.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.colUnitTotalFare.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colUnitTotalFare.AppearanceCell.Options.UseBackColor = true;
            this.colUnitTotalFare.AppearanceCell.Options.UseFont = true;
            this.colUnitTotalFare.AppearanceHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.colUnitTotalFare.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colUnitTotalFare.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colUnitTotalFare.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colUnitTotalFare.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.colUnitTotalFare.AppearanceHeader.Options.UseBackColor = true;
            this.colUnitTotalFare.AppearanceHeader.Options.UseFont = true;
            this.colUnitTotalFare.AppearanceHeader.Options.UseForeColor = true;
            this.colUnitTotalFare.Caption = "B. FİYATI";
            this.colUnitTotalFare.DisplayFormat.FormatString = "c2";
            this.colUnitTotalFare.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colUnitTotalFare.FieldName = "UnitTotalFarePreview";
            this.colUnitTotalFare.MaxWidth = 90;
            this.colUnitTotalFare.MinWidth = 90;
            this.colUnitTotalFare.Name = "colUnitTotalFare";
            this.colUnitTotalFare.OptionsColumn.AllowEdit = false;
            this.colUnitTotalFare.OptionsColumn.AllowFocus = false;
            this.colUnitTotalFare.OptionsColumn.ReadOnly = true;
            this.colUnitTotalFare.OptionsFilter.AllowFilter = false;
            this.colUnitTotalFare.Visible = true;
            this.colUnitTotalFare.VisibleIndex = 6;
            this.colUnitTotalFare.Width = 90;
            // 
            // colTotalFare
            // 
            this.colTotalFare.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colTotalFare.AppearanceCell.Options.UseFont = true;
            this.colTotalFare.AppearanceHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.colTotalFare.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colTotalFare.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colTotalFare.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colTotalFare.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.colTotalFare.AppearanceHeader.Options.UseBackColor = true;
            this.colTotalFare.AppearanceHeader.Options.UseFont = true;
            this.colTotalFare.AppearanceHeader.Options.UseForeColor = true;
            this.colTotalFare.Caption = "TUTARI";
            this.colTotalFare.DisplayFormat.FormatString = "c2";
            this.colTotalFare.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalFare.FieldName = "TotalFarePreview";
            this.colTotalFare.MaxWidth = 100;
            this.colTotalFare.MinWidth = 100;
            this.colTotalFare.Name = "colTotalFare";
            this.colTotalFare.OptionsColumn.AllowEdit = false;
            this.colTotalFare.OptionsColumn.AllowFocus = false;
            this.colTotalFare.OptionsColumn.ReadOnly = true;
            this.colTotalFare.OptionsFilter.AllowFilter = false;
            this.colTotalFare.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalFarePreview", "{0:c2}")});
            this.colTotalFare.Visible = true;
            this.colTotalFare.VisibleIndex = 7;
            this.colTotalFare.Width = 100;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(287, 5);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtDescription.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDescription.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtDescription.Properties.Appearance.Options.UseBackColor = true;
            this.txtDescription.Properties.Appearance.Options.UseFont = true;
            this.txtDescription.Properties.Appearance.Options.UseForeColor = true;
            this.txtDescription.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtDescription.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtDescription.Size = new System.Drawing.Size(331, 22);
            this.txtDescription.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.labelControl3.Location = new System.Drawing.Point(227, 9);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(55, 13);
            this.labelControl3.TabIndex = 97;
            this.labelControl3.Text = "Açıklama:";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(49, 5);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtNumber.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNumber.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtNumber.Properties.Appearance.Options.UseBackColor = true;
            this.txtNumber.Properties.Appearance.Options.UseFont = true;
            this.txtNumber.Properties.Appearance.Options.UseForeColor = true;
            this.txtNumber.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtNumber.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtNumber.Size = new System.Drawing.Size(167, 22);
            this.txtNumber.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.labelControl2.Location = new System.Drawing.Point(9, 10);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(31, 13);
            this.labelControl2.TabIndex = 97;
            this.labelControl2.Text = "Kodu:";
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.Navy;
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl2.Controls.Add(this.btnBul);
            this.groupControl2.Controls.Add(this.btnEkle);
            this.groupControl2.Controls.Add(this.txtDescription);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.txtNumber);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(780, 34);
            this.groupControl2.TabIndex = 35;
            this.groupControl2.Text = "Malzeme Bilgileri";
            // 
            // btnBul
            // 
            this.btnBul.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBul.Appearance.Options.UseFont = true;
            this.btnBul.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBul.Image = global::IhalematikProUI.Properties.Resources.search_icon__4_;
            this.btnBul.Location = new System.Drawing.Point(623, 0);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(77, 34);
            this.btnBul.TabIndex = 2;
            this.btnBul.Text = "&Bul";
            // 
            // btnEkle
            // 
            this.btnEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkle.Appearance.Options.UseFont = true;
            this.btnEkle.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEkle.Image = global::IhalematikProUI.Properties.Resources.Button_Add_icon__1_;
            this.btnEkle.Location = new System.Drawing.Point(700, 0);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(80, 34);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "&Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // frm_IsMalzemeEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 476);
            this.ControlBox = false;
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_IsMalzemeEkle";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İŞ/MALZEME EKLE";
            this.Shown += new System.EventHandler(this.frm_IsMalzemeEkle_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAddedJobberMaterialList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMaterialList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMaterialList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryTaseronTipi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraGrid.Columns.GridColumn colAddedOBFPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl grdAddedJobberMaterialList;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnBul;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.TextEdit txtDescription;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtNumber;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        public DevExpress.XtraGrid.GridControl grdMaterialList;
        public DevExpress.XtraGrid.Views.Grid.GridView gridViewMaterialList;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitTotalFare;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalFare;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryTaseronTipi;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
    }
}