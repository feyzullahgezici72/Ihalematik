namespace IhalematikProUI.Forms.Tedarikci
{
    partial class frm_GonderilecekMalzemeListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_GonderilecekMalzemeListesi));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grdAddedOfferMaterialList = new DevExpress.XtraGrid.GridControl();
            this.gridViewAddedOfferMaterialList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemoveAddEdMaterialList = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpstRemove = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAddedOfferMaterialList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAddedOfferMaterialList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpstRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
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
            this.panelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1215, 35);
            this.panelControl2.TabIndex = 111;
            // 
            // btnKapat
            // 
            this.btnKapat.AutoSize = true;
            this.btnKapat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKapat.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.Image")));
            this.btnKapat.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnKapat.Location = new System.Drawing.Point(1187, 0);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(4);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(28, 35);
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
            this.labelControl1.Location = new System.Drawing.Point(4, 1);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.ShowLineShadow = false;
            this.labelControl1.Size = new System.Drawing.Size(575, 35);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "TEDARİKÇİLERE GÖNDERİLECEK MALZEME LİSTESİ";
            this.labelControl1.UseMnemonic = false;
            // 
            // grdAddedOfferMaterialList
            // 
            this.grdAddedOfferMaterialList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdAddedOfferMaterialList.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6);
            this.grdAddedOfferMaterialList.Location = new System.Drawing.Point(0, 35);
            this.grdAddedOfferMaterialList.LookAndFeel.SkinName = "Money Twins";
            this.grdAddedOfferMaterialList.MainView = this.gridViewAddedOfferMaterialList;
            this.grdAddedOfferMaterialList.Margin = new System.Windows.Forms.Padding(6);
            this.grdAddedOfferMaterialList.Name = "grdAddedOfferMaterialList";
            this.grdAddedOfferMaterialList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.rpstRemove});
            this.grdAddedOfferMaterialList.Size = new System.Drawing.Size(1215, 615);
            this.grdAddedOfferMaterialList.TabIndex = 0;
            this.grdAddedOfferMaterialList.UseDisabledStatePainter = false;
            this.grdAddedOfferMaterialList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAddedOfferMaterialList});
            // 
            // gridViewAddedOfferMaterialList
            // 
            this.gridViewAddedOfferMaterialList.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver;
            this.gridViewAddedOfferMaterialList.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewAddedOfferMaterialList.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Silver;
            this.gridViewAddedOfferMaterialList.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray;
            this.gridViewAddedOfferMaterialList.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridViewAddedOfferMaterialList.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridViewAddedOfferMaterialList.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridViewAddedOfferMaterialList.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewAddedOfferMaterialList.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gridViewAddedOfferMaterialList.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewAddedOfferMaterialList.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue;
            this.gridViewAddedOfferMaterialList.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridViewAddedOfferMaterialList.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridViewAddedOfferMaterialList.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridViewAddedOfferMaterialList.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gridViewAddedOfferMaterialList.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite;
            this.gridViewAddedOfferMaterialList.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewAddedOfferMaterialList.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewAddedOfferMaterialList.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridViewAddedOfferMaterialList.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridViewAddedOfferMaterialList.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewAddedOfferMaterialList.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.gridViewAddedOfferMaterialList.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewAddedOfferMaterialList.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewAddedOfferMaterialList.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewAddedOfferMaterialList.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridViewAddedOfferMaterialList.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridViewAddedOfferMaterialList.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridViewAddedOfferMaterialList.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(80)))), ((int)(((byte)(135)))));
            this.gridViewAddedOfferMaterialList.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewAddedOfferMaterialList.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gridViewAddedOfferMaterialList.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewAddedOfferMaterialList.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridViewAddedOfferMaterialList.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridViewAddedOfferMaterialList.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.gridViewAddedOfferMaterialList.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridViewAddedOfferMaterialList.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.gridViewAddedOfferMaterialList.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gridViewAddedOfferMaterialList.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridViewAddedOfferMaterialList.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridViewAddedOfferMaterialList.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewAddedOfferMaterialList.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewAddedOfferMaterialList.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver;
            this.gridViewAddedOfferMaterialList.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver;
            this.gridViewAddedOfferMaterialList.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewAddedOfferMaterialList.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridViewAddedOfferMaterialList.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridViewAddedOfferMaterialList.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewAddedOfferMaterialList.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.gridViewAddedOfferMaterialList.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.gridViewAddedOfferMaterialList.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewAddedOfferMaterialList.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridViewAddedOfferMaterialList.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridViewAddedOfferMaterialList.Appearance.GroupButton.Options.UseForeColor = true;
            this.gridViewAddedOfferMaterialList.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gridViewAddedOfferMaterialList.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gridViewAddedOfferMaterialList.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridViewAddedOfferMaterialList.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridViewAddedOfferMaterialList.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridViewAddedOfferMaterialList.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridViewAddedOfferMaterialList.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.gridViewAddedOfferMaterialList.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gridViewAddedOfferMaterialList.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewAddedOfferMaterialList.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.gridViewAddedOfferMaterialList.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewAddedOfferMaterialList.Appearance.GroupPanel.Options.UseFont = true;
            this.gridViewAddedOfferMaterialList.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridViewAddedOfferMaterialList.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray;
            this.gridViewAddedOfferMaterialList.Appearance.GroupRow.ForeColor = System.Drawing.Color.Silver;
            this.gridViewAddedOfferMaterialList.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridViewAddedOfferMaterialList.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridViewAddedOfferMaterialList.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gridViewAddedOfferMaterialList.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver;
            this.gridViewAddedOfferMaterialList.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewAddedOfferMaterialList.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewAddedOfferMaterialList.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridViewAddedOfferMaterialList.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridViewAddedOfferMaterialList.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewAddedOfferMaterialList.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewAddedOfferMaterialList.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray;
            this.gridViewAddedOfferMaterialList.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewAddedOfferMaterialList.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewAddedOfferMaterialList.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewAddedOfferMaterialList.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver;
            this.gridViewAddedOfferMaterialList.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridViewAddedOfferMaterialList.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridViewAddedOfferMaterialList.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
            this.gridViewAddedOfferMaterialList.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewAddedOfferMaterialList.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gridViewAddedOfferMaterialList.Appearance.OddRow.Options.UseBackColor = true;
            this.gridViewAddedOfferMaterialList.Appearance.OddRow.Options.UseForeColor = true;
            this.gridViewAddedOfferMaterialList.Appearance.Preview.BackColor = System.Drawing.Color.White;
            this.gridViewAddedOfferMaterialList.Appearance.Preview.ForeColor = System.Drawing.Color.Navy;
            this.gridViewAddedOfferMaterialList.Appearance.Preview.Options.UseBackColor = true;
            this.gridViewAddedOfferMaterialList.Appearance.Preview.Options.UseForeColor = true;
            this.gridViewAddedOfferMaterialList.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridViewAddedOfferMaterialList.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridViewAddedOfferMaterialList.Appearance.Row.Options.UseBackColor = true;
            this.gridViewAddedOfferMaterialList.Appearance.Row.Options.UseForeColor = true;
            this.gridViewAddedOfferMaterialList.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gridViewAddedOfferMaterialList.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.gridViewAddedOfferMaterialList.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridViewAddedOfferMaterialList.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewAddedOfferMaterialList.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewAddedOfferMaterialList.Appearance.VertLine.BackColor = System.Drawing.Color.Silver;
            this.gridViewAddedOfferMaterialList.Appearance.VertLine.Options.UseBackColor = true;
            this.gridViewAddedOfferMaterialList.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridViewAddedOfferMaterialList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.colRemoveAddEdMaterialList});
            this.gridViewAddedOfferMaterialList.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridViewAddedOfferMaterialList.GridControl = this.grdAddedOfferMaterialList;
            this.gridViewAddedOfferMaterialList.Name = "gridViewAddedOfferMaterialList";
            this.gridViewAddedOfferMaterialList.OptionsDetail.AllowExpandEmptyDetails = true;
            this.gridViewAddedOfferMaterialList.OptionsMenu.EnableColumnMenu = false;
            this.gridViewAddedOfferMaterialList.OptionsMenu.EnableFooterMenu = false;
            this.gridViewAddedOfferMaterialList.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewAddedOfferMaterialList.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewAddedOfferMaterialList.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewAddedOfferMaterialList.OptionsSelection.CheckBoxSelectorColumnWidth = 60;
            this.gridViewAddedOfferMaterialList.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewAddedOfferMaterialList.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewAddedOfferMaterialList.OptionsSelection.ShowCheckBoxSelectorInPrintExport = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewAddedOfferMaterialList.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewAddedOfferMaterialList.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewAddedOfferMaterialList.OptionsView.ShowDetailButtons = false;
            this.gridViewAddedOfferMaterialList.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridViewAddedOfferMaterialList.OptionsView.ShowGroupPanel = false;
            this.gridViewAddedOfferMaterialList.PaintStyleName = "Web";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "gridColumn4";
            this.gridColumn4.FieldName = "Id";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // gridColumn9
            // 
            this.gridColumn9.AppearanceHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.gridColumn9.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridColumn9.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridColumn9.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridColumn9.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridColumn9.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn9.AppearanceHeader.Options.UseFont = true;
            this.gridColumn9.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn9.Caption = "ÖBF/POZ NO";
            this.gridColumn9.FieldName = "PozOBF.Number";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.OptionsColumn.AllowFocus = false;
            this.gridColumn9.OptionsColumn.ReadOnly = true;
            this.gridColumn9.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn9.OptionsFilter.AllowFilter = false;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 0;
            this.gridColumn9.Width = 117;
            // 
            // gridColumn10
            // 
            this.gridColumn10.AppearanceHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.gridColumn10.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridColumn10.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridColumn10.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridColumn10.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridColumn10.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn10.AppearanceHeader.Options.UseFont = true;
            this.gridColumn10.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn10.Caption = "AÇIKLAMA";
            this.gridColumn10.FieldName = "PozOBF.Description";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            this.gridColumn10.OptionsColumn.AllowFocus = false;
            this.gridColumn10.OptionsColumn.ReadOnly = true;
            this.gridColumn10.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn10.OptionsFilter.AllowFilter = false;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 1;
            this.gridColumn10.Width = 915;
            // 
            // gridColumn11
            // 
            this.gridColumn11.AppearanceHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.gridColumn11.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridColumn11.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridColumn11.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridColumn11.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridColumn11.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn11.AppearanceHeader.Options.UseFont = true;
            this.gridColumn11.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn11.Caption = "BİRİMİ";
            this.gridColumn11.FieldName = "PozOBF.Unit";
            this.gridColumn11.MaxWidth = 60;
            this.gridColumn11.MinWidth = 60;
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.OptionsColumn.AllowEdit = false;
            this.gridColumn11.OptionsColumn.AllowFocus = false;
            this.gridColumn11.OptionsColumn.ReadOnly = true;
            this.gridColumn11.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn11.OptionsFilter.AllowFilter = false;
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 2;
            this.gridColumn11.Width = 60;
            // 
            // gridColumn12
            // 
            this.gridColumn12.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridColumn12.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gridColumn12.AppearanceCell.Options.UseFont = true;
            this.gridColumn12.AppearanceCell.Options.UseForeColor = true;
            this.gridColumn12.AppearanceHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.gridColumn12.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridColumn12.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridColumn12.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridColumn12.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridColumn12.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn12.AppearanceHeader.Options.UseFont = true;
            this.gridColumn12.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn12.Caption = "MİKTARI";
            this.gridColumn12.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn12.FieldName = "Quantity";
            this.gridColumn12.MaxWidth = 80;
            this.gridColumn12.MinWidth = 80;
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.OptionsColumn.AllowEdit = false;
            this.gridColumn12.OptionsColumn.AllowFocus = false;
            this.gridColumn12.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn12.OptionsFilter.AllowFilter = false;
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 3;
            this.gridColumn12.Width = 80;
            // 
            // colRemoveAddEdMaterialList
            // 
            this.colRemoveAddEdMaterialList.AppearanceHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.colRemoveAddEdMaterialList.AppearanceHeader.Options.UseBackColor = true;
            this.colRemoveAddEdMaterialList.Caption = " ";
            this.colRemoveAddEdMaterialList.ColumnEdit = this.rpstRemove;
            this.colRemoveAddEdMaterialList.MaxWidth = 20;
            this.colRemoveAddEdMaterialList.Name = "colRemoveAddEdMaterialList";
            this.colRemoveAddEdMaterialList.OptionsFilter.AllowFilter = false;
            this.colRemoveAddEdMaterialList.ToolTip = "Çıkar";
            this.colRemoveAddEdMaterialList.Visible = true;
            this.colRemoveAddEdMaterialList.VisibleIndex = 4;
            this.colRemoveAddEdMaterialList.Width = 20;
            // 
            // rpstRemove
            // 
            this.rpstRemove.AutoHeight = false;
            this.rpstRemove.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("rpstRemove.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "Çıkar", null, null, true)});
            this.rpstRemove.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.rpstRemove.Name = "rpstRemove";
            this.rpstRemove.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.rpstRemove.Click += new System.EventHandler(this.rpstRemove_Click);
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // frm_GonderilecekMalzemeListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 650);
            this.ControlBox = false;
            this.Controls.Add(this.grdAddedOfferMaterialList);
            this.Controls.Add(this.panelControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.LookAndFeel.SkinName = "London Liquid Sky";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_GonderilecekMalzemeListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " ";
            this.Shown += new System.EventHandler(this.frm_GonderilecekMalzemeListesi_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAddedOfferMaterialList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAddedOfferMaterialList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpstRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraGrid.GridControl grdAddedOfferMaterialList;
        public DevExpress.XtraGrid.Views.Grid.GridView gridViewAddedOfferMaterialList;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn colRemoveAddEdMaterialList;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit rpstRemove;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
    }
}