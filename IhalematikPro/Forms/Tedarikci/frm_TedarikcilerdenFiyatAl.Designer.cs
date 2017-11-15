namespace IhalematikProUI.Forms
{
    partial class frm_TedarikcilerdenFiyatAl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TedarikcilerdenFiyatAl));
            this.btnObfKayit = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panelControl6 = new DevExpress.XtraEditors.PanelControl();
            this.grdMaterialList = new DevExpress.XtraGrid.GridControl();
            this.grdMaterialList2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pcWorld = new System.Windows.Forms.PictureBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.txtAdimAciklama = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).BeginInit();
            this.panelControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMaterialList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMaterialList2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcWorld)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObfKayit
            // 
            this.btnObfKayit.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnObfKayit.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.btnObfKayit.Appearance.Options.UseFont = true;
            this.btnObfKayit.Appearance.Options.UseForeColor = true;
            this.btnObfKayit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnObfKayit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnObfKayit.Image = global::IhalematikProUI.Properties.Resources.Actions_view_refresh_icon__1_;
            this.btnObfKayit.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnObfKayit.Location = new System.Drawing.Point(1351, 0);
            this.btnObfKayit.Margin = new System.Windows.Forms.Padding(4);
            this.btnObfKayit.Name = "btnObfKayit";
            this.btnObfKayit.Size = new System.Drawing.Size(226, 88);
            this.btnObfKayit.TabIndex = 7;
            this.btnObfKayit.Text = "Teklifleri Aktar";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.Appearance.Options.UseForeColor = true;
            this.btnKaydet.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKaydet.Image = global::IhalematikProUI.Properties.Resources.Save_as_icon__1_;
            this.btnKaydet.Location = new System.Drawing.Point(6, 0);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(136, 83);
            this.btnKaydet.TabIndex = 19;
            this.btnKaydet.Text = "Kaydet";
            // 
            // panelControl6
            // 
            this.panelControl6.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl6.Appearance.Options.UseBackColor = true;
            this.panelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl6.Controls.Add(this.grdMaterialList);
            this.panelControl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl6.Location = new System.Drawing.Point(0, 88);
            this.panelControl6.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl6.Name = "panelControl6";
            this.panelControl6.Size = new System.Drawing.Size(1641, 633);
            this.panelControl6.TabIndex = 31;
            // 
            // grdMaterialList
            // 
            this.grdMaterialList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMaterialList.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.grdMaterialList.Location = new System.Drawing.Point(0, 0);
            this.grdMaterialList.MainView = this.grdMaterialList2;
            this.grdMaterialList.Margin = new System.Windows.Forms.Padding(4);
            this.grdMaterialList.Name = "grdMaterialList";
            this.grdMaterialList.Size = new System.Drawing.Size(1641, 633);
            this.grdMaterialList.TabIndex = 0;
            this.grdMaterialList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdMaterialList2});
            // 
            // grdMaterialList2
            // 
            this.grdMaterialList2.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver;
            this.grdMaterialList2.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.grdMaterialList2.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Silver;
            this.grdMaterialList2.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray;
            this.grdMaterialList2.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.grdMaterialList2.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.grdMaterialList2.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.grdMaterialList2.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.grdMaterialList2.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.grdMaterialList2.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.grdMaterialList2.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue;
            this.grdMaterialList2.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.grdMaterialList2.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.grdMaterialList2.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.grdMaterialList2.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.grdMaterialList2.Appearance.Empty.Options.UseBackColor = true;
            this.grdMaterialList2.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.grdMaterialList2.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite;
            this.grdMaterialList2.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.grdMaterialList2.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.grdMaterialList2.Appearance.EvenRow.Options.UseBackColor = true;
            this.grdMaterialList2.Appearance.EvenRow.Options.UseForeColor = true;
            this.grdMaterialList2.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.grdMaterialList2.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.grdMaterialList2.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.grdMaterialList2.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.grdMaterialList2.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.grdMaterialList2.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.grdMaterialList2.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.grdMaterialList2.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.grdMaterialList2.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(80)))), ((int)(((byte)(135)))));
            this.grdMaterialList2.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.grdMaterialList2.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.grdMaterialList2.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.grdMaterialList2.Appearance.FilterPanel.Options.UseBackColor = true;
            this.grdMaterialList2.Appearance.FilterPanel.Options.UseForeColor = true;
            this.grdMaterialList2.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.grdMaterialList2.Appearance.FixedLine.Options.UseBackColor = true;
            this.grdMaterialList2.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.grdMaterialList2.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.grdMaterialList2.Appearance.FocusedCell.Options.UseBackColor = true;
            this.grdMaterialList2.Appearance.FocusedCell.Options.UseForeColor = true;
            this.grdMaterialList2.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.grdMaterialList2.Appearance.FocusedRow.Options.UseForeColor = true;
            this.grdMaterialList2.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver;
            this.grdMaterialList2.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver;
            this.grdMaterialList2.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.grdMaterialList2.Appearance.FooterPanel.Options.UseBackColor = true;
            this.grdMaterialList2.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.grdMaterialList2.Appearance.FooterPanel.Options.UseForeColor = true;
            this.grdMaterialList2.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.grdMaterialList2.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.grdMaterialList2.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.grdMaterialList2.Appearance.GroupButton.Options.UseBackColor = true;
            this.grdMaterialList2.Appearance.GroupButton.Options.UseBorderColor = true;
            this.grdMaterialList2.Appearance.GroupButton.Options.UseForeColor = true;
            this.grdMaterialList2.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.grdMaterialList2.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.grdMaterialList2.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.grdMaterialList2.Appearance.GroupFooter.Options.UseBackColor = true;
            this.grdMaterialList2.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.grdMaterialList2.Appearance.GroupFooter.Options.UseForeColor = true;
            this.grdMaterialList2.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.grdMaterialList2.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.grdMaterialList2.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.grdMaterialList2.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.grdMaterialList2.Appearance.GroupPanel.Options.UseBackColor = true;
            this.grdMaterialList2.Appearance.GroupPanel.Options.UseFont = true;
            this.grdMaterialList2.Appearance.GroupPanel.Options.UseForeColor = true;
            this.grdMaterialList2.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray;
            this.grdMaterialList2.Appearance.GroupRow.ForeColor = System.Drawing.Color.Silver;
            this.grdMaterialList2.Appearance.GroupRow.Options.UseBackColor = true;
            this.grdMaterialList2.Appearance.GroupRow.Options.UseForeColor = true;
            this.grdMaterialList2.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.grdMaterialList2.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver;
            this.grdMaterialList2.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.grdMaterialList2.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.grdMaterialList2.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.grdMaterialList2.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.grdMaterialList2.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdMaterialList2.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.grdMaterialList2.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray;
            this.grdMaterialList2.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.grdMaterialList2.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.grdMaterialList2.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.grdMaterialList2.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver;
            this.grdMaterialList2.Appearance.HorzLine.Options.UseBackColor = true;
            this.grdMaterialList2.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.grdMaterialList2.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
            this.grdMaterialList2.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.grdMaterialList2.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.grdMaterialList2.Appearance.OddRow.Options.UseBackColor = true;
            this.grdMaterialList2.Appearance.OddRow.Options.UseForeColor = true;
            this.grdMaterialList2.Appearance.Preview.BackColor = System.Drawing.Color.White;
            this.grdMaterialList2.Appearance.Preview.ForeColor = System.Drawing.Color.Navy;
            this.grdMaterialList2.Appearance.Preview.Options.UseBackColor = true;
            this.grdMaterialList2.Appearance.Preview.Options.UseForeColor = true;
            this.grdMaterialList2.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.grdMaterialList2.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.grdMaterialList2.Appearance.Row.Options.UseBackColor = true;
            this.grdMaterialList2.Appearance.Row.Options.UseForeColor = true;
            this.grdMaterialList2.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.grdMaterialList2.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.grdMaterialList2.Appearance.RowSeparator.Options.UseBackColor = true;
            this.grdMaterialList2.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.grdMaterialList2.Appearance.SelectedRow.Options.UseForeColor = true;
            this.grdMaterialList2.Appearance.VertLine.BackColor = System.Drawing.Color.Silver;
            this.grdMaterialList2.Appearance.VertLine.Options.UseBackColor = true;
            this.grdMaterialList2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.grdMaterialList2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn7,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn8});
            this.grdMaterialList2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.grdMaterialList2.GridControl = this.grdMaterialList;
            this.grdMaterialList2.Name = "grdMaterialList2";
            this.grdMaterialList2.OptionsDetail.AllowExpandEmptyDetails = true;
            this.grdMaterialList2.OptionsNavigation.AutoFocusNewRow = true;
            this.grdMaterialList2.OptionsNavigation.EnterMoveNextColumn = true;
            this.grdMaterialList2.OptionsSelection.CheckBoxSelectorColumnWidth = 60;
            this.grdMaterialList2.OptionsSelection.MultiSelect = true;
            this.grdMaterialList2.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.grdMaterialList2.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.False;
            this.grdMaterialList2.OptionsSelection.ShowCheckBoxSelectorInPrintExport = DevExpress.Utils.DefaultBoolean.False;
            this.grdMaterialList2.OptionsView.EnableAppearanceEvenRow = true;
            this.grdMaterialList2.OptionsView.EnableAppearanceOddRow = true;
            this.grdMaterialList2.OptionsView.ShowGroupPanel = false;
            this.grdMaterialList2.PaintStyleName = "Web";
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
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
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 128;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
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
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 644;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridColumn3.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridColumn3.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridColumn3.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridColumn3.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            this.gridColumn3.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn3.Caption = "BİRİMİ";
            this.gridColumn3.FieldName = "PozOBF.Unit";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowFocus = false;
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 126;
            // 
            // gridColumn7
            // 
            this.gridColumn7.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn7.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gridColumn7.AppearanceHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.gridColumn7.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridColumn7.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridColumn7.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridColumn7.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridColumn7.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn7.AppearanceHeader.Options.UseFont = true;
            this.gridColumn7.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn7.Caption = "KDV %";
            this.gridColumn7.DisplayFormat.FormatString = "{0:f0} %";
            this.gridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.gridColumn7.FieldName = "KDVPercentage";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 4;
            this.gridColumn7.Width = 107;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn4.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.gridColumn4.AppearanceHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.gridColumn4.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridColumn4.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridColumn4.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridColumn4.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridColumn4.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn4.AppearanceHeader.Options.UseFont = true;
            this.gridColumn4.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn4.Caption = "MİKTARI";
            this.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn4.FieldName = "Quantity";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 5;
            this.gridColumn4.Width = 115;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.gridColumn5.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridColumn5.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridColumn5.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridColumn5.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridColumn5.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn5.AppearanceHeader.Options.UseFont = true;
            this.gridColumn5.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn5.Caption = "BİRİM FİYATI";
            this.gridColumn5.DisplayFormat.FormatString = "c2";
            this.gridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn5.FieldName = "PozOBF.UnitPrice";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.OptionsColumn.AllowFocus = false;
            this.gridColumn5.OptionsColumn.ReadOnly = true;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 6;
            this.gridColumn5.Width = 155;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.gridColumn6.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridColumn6.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridColumn6.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridColumn6.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridColumn6.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn6.AppearanceHeader.Options.UseFont = true;
            this.gridColumn6.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn6.Caption = "KDV TUTARI";
            this.gridColumn6.DisplayFormat.FormatString = "c2";
            this.gridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn6.FieldName = "KDVAmount";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.OptionsColumn.AllowFocus = false;
            this.gridColumn6.OptionsColumn.ReadOnly = true;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 7;
            this.gridColumn6.Width = 135;
            // 
            // gridColumn8
            // 
            this.gridColumn8.AppearanceHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.gridColumn8.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridColumn8.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridColumn8.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridColumn8.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridColumn8.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn8.AppearanceHeader.Options.UseFont = true;
            this.gridColumn8.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn8.Caption = "TOPLAM TUTAR";
            this.gridColumn8.DisplayFormat.FormatString = "c2";
            this.gridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn8.FieldName = "TotalAmount";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.OptionsColumn.AllowFocus = false;
            this.gridColumn8.OptionsColumn.ReadOnly = true;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 8;
            this.gridColumn8.Width = 150;
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.SteelBlue;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.ContentImageAlignment = System.Drawing.ContentAlignment.BottomLeft;
            this.panelControl1.Controls.Add(this.pcWorld);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.btnObfKayit);
            this.panelControl1.Controls.Add(this.btnKapat);
            this.panelControl1.Controls.Add(this.txtAdimAciklama);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1641, 88);
            this.panelControl1.TabIndex = 29;
            // 
            // pcWorld
            // 
            this.pcWorld.Image = ((System.Drawing.Image)(resources.GetObject("pcWorld.Image")));
            this.pcWorld.Location = new System.Drawing.Point(0, 0);
            this.pcWorld.Name = "pcWorld";
            this.pcWorld.Size = new System.Drawing.Size(70, 50);
            this.pcWorld.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcWorld.TabIndex = 16;
            this.pcWorld.TabStop = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelControl2.Location = new System.Drawing.Point(330, 53);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(209, 34);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Teklif Açıklama";
            // 
            // btnKapat
            // 
            this.btnKapat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnKapat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKapat.Image = global::IhalematikProUI.Properties.Resources.Actions_dialog_close_icon;
            this.btnKapat.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnKapat.Location = new System.Drawing.Point(1577, 0);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(4);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(64, 88);
            this.btnKapat.TabIndex = 3;
            this.btnKapat.TabStop = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // txtAdimAciklama
            // 
            this.txtAdimAciklama.Appearance.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdimAciklama.Appearance.ForeColor = System.Drawing.Color.AliceBlue;
            this.txtAdimAciklama.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.txtAdimAciklama.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtAdimAciklama.LineColor = System.Drawing.Color.Red;
            this.txtAdimAciklama.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.txtAdimAciklama.Location = new System.Drawing.Point(77, 2);
            this.txtAdimAciklama.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdimAciklama.Name = "txtAdimAciklama";
            this.txtAdimAciklama.ShowLineShadow = false;
            this.txtAdimAciklama.Size = new System.Drawing.Size(773, 37);
            this.txtAdimAciklama.TabIndex = 0;
            this.txtAdimAciklama.Text = "TEDARİKÇİLERDEN ALINAN FİYATLARI BİRLEŞTİR";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.labelControl1.Location = new System.Drawing.Point(18, 52);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(133, 34);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Teklif No:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnKaydet);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1499, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(142, 83);
            this.panel2.TabIndex = 10;
            // 
            // panelControl3
            // 
            this.panelControl3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl3.Appearance.Options.UseBackColor = true;
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl3.Controls.Add(this.radioGroup1);
            this.panelControl3.Controls.Add(this.panel2);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(0, 721);
            this.panelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1641, 83);
            this.panelControl3.TabIndex = 30;
            // 
            // radioGroup1
            // 
            this.radioGroup1.Dock = System.Windows.Forms.DockStyle.Right;
            this.radioGroup1.Location = new System.Drawing.Point(1193, 0);
            this.radioGroup1.Margin = new System.Windows.Forms.Padding(4);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioGroup1.Properties.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.radioGroup1.Properties.Appearance.Options.UseFont = true;
            this.radioGroup1.Properties.Appearance.Options.UseForeColor = true;
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "En Düşük Fiyata Göre"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Fiyat Ortalamasına Göre")});
            this.radioGroup1.Size = new System.Drawing.Size(306, 83);
            this.radioGroup1.TabIndex = 11;
            // 
            // frm_TedarikcilerdenFiyatAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnKapat;
            this.ClientSize = new System.Drawing.Size(1641, 804);
            this.ControlBox = false;
            this.Controls.Add(this.panelControl6);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_TedarikcilerdenFiyatAl";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_TedarikcilerdenFiyatAl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).EndInit();
            this.panelControl6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMaterialList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMaterialList2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcWorld)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnObfKayit;
        public DevExpress.XtraEditors.SimpleButton btnKaydet;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraEditors.PanelControl panelControl6;
        public DevExpress.XtraGrid.GridControl grdMaterialList;
        public DevExpress.XtraGrid.Views.Grid.GridView grdMaterialList2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.LabelControl txtAdimAciklama;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private System.Windows.Forms.PictureBox pcWorld;
    }
}