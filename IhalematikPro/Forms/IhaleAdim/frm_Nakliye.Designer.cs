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
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.grdMaterialList = new DevExpress.XtraGrid.GridControl();
            this.grdMaterialList2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMaterialList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMaterialList2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
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
            this.panelControl2.Size = new System.Drawing.Size(880, 35);
            this.panelControl2.TabIndex = 96;
            // 
            // btnKapat
            // 
            this.btnKapat.AutoSize = true;
            this.btnKapat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKapat.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.Image")));
            this.btnKapat.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnKapat.Location = new System.Drawing.Point(852, 0);
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
            this.labelControl1.Location = new System.Drawing.Point(10, 0);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.ShowLineShadow = false;
            this.labelControl1.Size = new System.Drawing.Size(251, 35);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "NAKLİYE HESAPLAMA";
            this.labelControl1.UseMnemonic = false;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Blue;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Controls.Add(this.btnOk);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.textEdit1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 35);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(880, 100);
            this.groupControl1.TabIndex = 97;
            this.groupControl1.Text = "Nakliye";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.Red;
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl2.Controls.Add(this.grdMaterialList);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 135);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(880, 556);
            this.groupControl2.TabIndex = 98;
            this.groupControl2.Text = "Ağırlık oranını belirtiniz";
            // 
            // grdMaterialList
            // 
            this.grdMaterialList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.grdMaterialList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMaterialList.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.grdMaterialList.Location = new System.Drawing.Point(3, 30);
            this.grdMaterialList.MainView = this.grdMaterialList2;
            this.grdMaterialList.Margin = new System.Windows.Forms.Padding(4);
            this.grdMaterialList.Name = "grdMaterialList";
            this.grdMaterialList.Size = new System.Drawing.Size(874, 523);
            this.grdMaterialList.TabIndex = 2;
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
            this.gridColumn4,
            this.gridColumn5});
            this.grdMaterialList2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.grdMaterialList2.GridControl = this.grdMaterialList;
            this.grdMaterialList2.Name = "grdMaterialList2";
            this.grdMaterialList2.OptionsDetail.AllowExpandEmptyDetails = true;
            this.grdMaterialList2.OptionsMenu.EnableColumnMenu = false;
            this.grdMaterialList2.OptionsMenu.EnableFooterMenu = false;
            this.grdMaterialList2.OptionsMenu.EnableGroupPanelMenu = false;
            this.grdMaterialList2.OptionsNavigation.AutoFocusNewRow = true;
            this.grdMaterialList2.OptionsNavigation.EnterMoveNextColumn = true;
            this.grdMaterialList2.OptionsSelection.CheckBoxSelectorColumnWidth = 60;
            this.grdMaterialList2.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.False;
            this.grdMaterialList2.OptionsSelection.ShowCheckBoxSelectorInPrintExport = DevExpress.Utils.DefaultBoolean.False;
            this.grdMaterialList2.OptionsView.EnableAppearanceEvenRow = true;
            this.grdMaterialList2.OptionsView.EnableAppearanceOddRow = true;
            this.grdMaterialList2.OptionsView.ShowFooter = true;
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
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
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
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
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
            // gridColumn5
            // 
            this.gridColumn5.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridColumn5.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn5.AppearanceHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.gridColumn5.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn5.Caption = "ORAN%";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", "{0:0.##}")});
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(186, 52);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(235, 26);
            this.textEdit1.TabIndex = 0;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl6.Location = new System.Drawing.Point(73, 55);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(104, 19);
            this.labelControl6.TabIndex = 140;
            this.labelControl6.Text = "Nakliye Gideri:";
            // 
            // btnOk
            // 
            this.btnOk.Image = ((System.Drawing.Image)(resources.GetObject("btnOk.Image")));
            this.btnOk.Location = new System.Drawing.Point(443, 44);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(107, 41);
            this.btnOk.TabIndex = 141;
            this.btnOk.Text = "Tamam";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frm_Nakliye
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 691);
            this.ControlBox = false;
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Nakliye";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMaterialList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMaterialList2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        public DevExpress.XtraGrid.GridControl grdMaterialList;
        public DevExpress.XtraGrid.Views.Grid.GridView grdMaterialList2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.LabelControl labelControl6;
    }
}