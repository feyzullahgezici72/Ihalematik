namespace IhalematikProUI.Forms.IhaleAdim
{
    partial class frm_TopluPozIhaleTemp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TopluPozIhaleTemp));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem3 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem3 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SuperToolTip superToolTip4 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem4 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem4 = new DevExpress.Utils.ToolTipItem();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btnHayir = new DevExpress.XtraEditors.SimpleButton();
            this.btnEvet = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.bindingSourceMaterialList = new System.Windows.Forms.BindingSource(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pcWorld = new System.Windows.Forms.PictureBox();
            this.txtAdimAciklama = new DevExpress.XtraEditors.LabelControl();
            this.grdMaterialList = new DevExpress.XtraGrid.GridControl();
            this.gridViewMaterialList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaterialListPozOBFId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaterialListQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnChangeMeterialName = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnResetMeterialName = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMaterialList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcWorld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMaterialList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMaterialList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChangeMeterialName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnResetMeterialName)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.groupControl3);
            this.groupControl2.Controls.Add(this.groupControl4);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl2.Location = new System.Drawing.Point(0, 35);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(309, 639);
            this.groupControl2.TabIndex = 7;
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
            this.groupControl3.TabIndex = 4;
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
            this.groupControl4.TabIndex = 3;
            this.groupControl4.Text = "Tablodaki veriler okundu!";
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelControl1.Appearance.BackColor2 = System.Drawing.Color.SpringGreen;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.ContentImageAlignment = System.Drawing.ContentAlignment.BottomLeft;
            this.panelControl1.Controls.Add(this.pcWorld);
            this.panelControl1.Controls.Add(this.txtAdimAciklama);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1328, 35);
            this.panelControl1.TabIndex = 24;
            // 
            // pcWorld
            // 
            this.pcWorld.BackColor = System.Drawing.Color.Transparent;
            this.pcWorld.Dock = System.Windows.Forms.DockStyle.Left;
            this.pcWorld.Image = ((System.Drawing.Image)(resources.GetObject("pcWorld.Image")));
            this.pcWorld.Location = new System.Drawing.Point(0, 0);
            this.pcWorld.Name = "pcWorld";
            this.pcWorld.Size = new System.Drawing.Size(50, 35);
            this.pcWorld.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcWorld.TabIndex = 16;
            this.pcWorld.TabStop = false;
            // 
            // txtAdimAciklama
            // 
            this.txtAdimAciklama.Appearance.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdimAciklama.Appearance.ForeColor = System.Drawing.Color.AliceBlue;
            this.txtAdimAciklama.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.txtAdimAciklama.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtAdimAciklama.LineColor = System.Drawing.Color.Red;
            this.txtAdimAciklama.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.txtAdimAciklama.Location = new System.Drawing.Point(57, 0);
            this.txtAdimAciklama.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdimAciklama.Name = "txtAdimAciklama";
            this.txtAdimAciklama.ShowLineShadow = false;
            this.txtAdimAciklama.Size = new System.Drawing.Size(244, 35);
            this.txtAdimAciklama.TabIndex = 0;
            this.txtAdimAciklama.Text = "OKUNAN POZ LİSTESİ";
            // 
            // grdMaterialList
            // 
            this.grdMaterialList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMaterialList.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.grdMaterialList.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grdMaterialList.Location = new System.Drawing.Point(309, 35);
            this.grdMaterialList.MainView = this.gridViewMaterialList;
            this.grdMaterialList.Margin = new System.Windows.Forms.Padding(4);
            this.grdMaterialList.Name = "grdMaterialList";
            this.grdMaterialList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnChangeMeterialName,
            this.btnResetMeterialName});
            this.grdMaterialList.Size = new System.Drawing.Size(1019, 639);
            this.grdMaterialList.TabIndex = 23;
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
            this.colMaterialListPozOBFId,
            this.colId,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.colMaterialListQuantity,
            this.colUnitPrice});
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
            this.gridColumn1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "PozOBF.Number", "Okunan :{0}")});
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
            this.gridColumn2.FieldName = "PozOBF.Description";
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
            this.colMaterialListQuantity.OptionsColumn.AllowEdit = false;
            this.colMaterialListQuantity.OptionsColumn.AllowFocus = false;
            this.colMaterialListQuantity.OptionsFilter.AllowAutoFilter = false;
            this.colMaterialListQuantity.OptionsFilter.AllowFilter = false;
            this.colMaterialListQuantity.Visible = true;
            this.colMaterialListQuantity.VisibleIndex = 3;
            this.colMaterialListQuantity.Width = 80;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.AppearanceHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.colUnitPrice.AppearanceHeader.Options.UseBackColor = true;
            this.colUnitPrice.Caption = "BiRiM FiYAT";
            this.colUnitPrice.DisplayFormat.FormatString = "c2";
            this.colUnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colUnitPrice.FieldName = "PozOBFUnitePrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Visible = true;
            this.colUnitPrice.VisibleIndex = 4;
            // 
            // btnChangeMeterialName
            // 
            this.btnChangeMeterialName.AutoHeight = false;
            toolTipTitleItem3.Text = "YENİDEN ADLANDIR";
            toolTipItem3.Appearance.Options.UseImage = true;
            toolTipItem3.LeftIndent = 6;
            toolTipItem3.Text = "Tedarikçiye gönderilecek Malzemenin adını değiştirmek isterseniz kullanınız..";
            superToolTip3.Items.Add(toolTipTitleItem3);
            superToolTip3.Items.Add(toolTipItem3);
            this.btnChangeMeterialName.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnChangeMeterialName.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, superToolTip3, true)});
            this.btnChangeMeterialName.LookAndFeel.SkinName = "Sharp Plus";
            this.btnChangeMeterialName.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnChangeMeterialName.Name = "btnChangeMeterialName";
            this.btnChangeMeterialName.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // btnResetMeterialName
            // 
            this.btnResetMeterialName.AutoHeight = false;
            toolTipTitleItem4.Text = "GERİAL YENİDEN ADLANDIR";
            toolTipItem4.Appearance.Options.UseImage = true;
            toolTipItem4.LeftIndent = 6;
            toolTipItem4.Text = "Tedarikçiye gönderilecek Malzemenin adını değiştirmişseniz geri almak için kullan" +
    "ınız...";
            superToolTip4.Items.Add(toolTipTitleItem4);
            superToolTip4.Items.Add(toolTipItem4);
            this.btnResetMeterialName.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnResetMeterialName.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "", null, superToolTip4, true)});
            this.btnResetMeterialName.LookAndFeel.SkinName = "Sharp Plus";
            this.btnResetMeterialName.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnResetMeterialName.Name = "btnResetMeterialName";
            this.btnResetMeterialName.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // frm_TopluPozIhaleTemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 674);
            this.ControlBox = false;
            this.Controls.Add(this.grdMaterialList);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_TopluPozIhaleTemp";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POZ";
            this.Shown += new System.EventHandler(this.frm_TopluPozIhaleTemp_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMaterialList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcWorld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMaterialList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMaterialList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChangeMeterialName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnResetMeterialName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton btnHayir;
        private DevExpress.XtraEditors.SimpleButton btnEvet;
        private System.Windows.Forms.BindingSource bindingSourceMaterialList;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.PictureBox pcWorld;
        private DevExpress.XtraEditors.LabelControl txtAdimAciklama;
        public DevExpress.XtraGrid.GridControl grdMaterialList;
        public DevExpress.XtraGrid.Views.Grid.GridView gridViewMaterialList;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterialListPozOBFId;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn colMaterialListQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnChangeMeterialName;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnResetMeterialName;
    }
}