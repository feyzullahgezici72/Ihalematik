namespace IhalematikProUI.Hakedis
{
    partial class frm_SozlesmeKalemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_SozlesmeKalemleri));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.pcWorld = new System.Windows.Forms.PictureBox();
            this.txtAdimAciklama = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.grdMaterialListNonWorkship = new DevExpress.XtraGrid.GridControl();
            this.gridViewMaterialListNonWorkship = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdTenderGroup = new DevExpress.XtraGrid.GridControl();
            this.gridViewTenderGroup = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIsSelected = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpstColIsSelected = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnGuncelle = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnSil = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtSozlesmeBedeli = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcWorld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMaterialListNonWorkship)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMaterialListNonWorkship)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTenderGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTenderGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpstColIsSelected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuncelle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSozlesmeBedeli.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelControl1.Appearance.BackColor2 = System.Drawing.Color.Plum;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.ContentImageAlignment = System.Drawing.ContentAlignment.BottomLeft;
            this.panelControl1.Controls.Add(this.txtSozlesmeBedeli);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.btnKapat);
            this.panelControl1.Controls.Add(this.pcWorld);
            this.panelControl1.Controls.Add(this.txtAdimAciklama);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1330, 35);
            this.panelControl1.TabIndex = 31;
            // 
            // btnKapat
            // 
            this.btnKapat.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKapat.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.btnKapat.Appearance.Options.UseFont = true;
            this.btnKapat.Appearance.Options.UseForeColor = true;
            this.btnKapat.AutoSize = true;
            this.btnKapat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKapat.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.Image")));
            this.btnKapat.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnKapat.Location = new System.Drawing.Point(1302, 0);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(4);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(28, 35);
            this.btnKapat.TabIndex = 17;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
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
            this.txtAdimAciklama.Size = new System.Drawing.Size(259, 35);
            this.txtAdimAciklama.TabIndex = 0;
            this.txtAdimAciklama.Text = "SÖZLEŞME KALEMLERİ";
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.Gray;
            this.panelControl2.Appearance.BackColor2 = System.Drawing.Color.White;
            this.panelControl2.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 35);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1330, 17);
            this.panelControl2.TabIndex = 32;
            // 
            // grdMaterialListNonWorkship
            // 
            this.grdMaterialListNonWorkship.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMaterialListNonWorkship.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grdMaterialListNonWorkship.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.grdMaterialListNonWorkship.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.grdMaterialListNonWorkship.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grdMaterialListNonWorkship.Location = new System.Drawing.Point(294, 52);
            this.grdMaterialListNonWorkship.MainView = this.gridViewMaterialListNonWorkship;
            this.grdMaterialListNonWorkship.Margin = new System.Windows.Forms.Padding(4);
            this.grdMaterialListNonWorkship.Name = "grdMaterialListNonWorkship";
            this.grdMaterialListNonWorkship.Size = new System.Drawing.Size(1036, 639);
            this.grdMaterialListNonWorkship.TabIndex = 33;
            this.grdMaterialListNonWorkship.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMaterialListNonWorkship});
            // 
            // gridViewMaterialListNonWorkship
            // 
            this.gridViewMaterialListNonWorkship.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver;
            this.gridViewMaterialListNonWorkship.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewMaterialListNonWorkship.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Silver;
            this.gridViewMaterialListNonWorkship.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray;
            this.gridViewMaterialListNonWorkship.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridViewMaterialListNonWorkship.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridViewMaterialListNonWorkship.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridViewMaterialListNonWorkship.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewMaterialListNonWorkship.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gridViewMaterialListNonWorkship.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewMaterialListNonWorkship.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue;
            this.gridViewMaterialListNonWorkship.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridViewMaterialListNonWorkship.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridViewMaterialListNonWorkship.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridViewMaterialListNonWorkship.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gridViewMaterialListNonWorkship.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite;
            this.gridViewMaterialListNonWorkship.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewMaterialListNonWorkship.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewMaterialListNonWorkship.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridViewMaterialListNonWorkship.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridViewMaterialListNonWorkship.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewMaterialListNonWorkship.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.gridViewMaterialListNonWorkship.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewMaterialListNonWorkship.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewMaterialListNonWorkship.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewMaterialListNonWorkship.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridViewMaterialListNonWorkship.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridViewMaterialListNonWorkship.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridViewMaterialListNonWorkship.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(80)))), ((int)(((byte)(135)))));
            this.gridViewMaterialListNonWorkship.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewMaterialListNonWorkship.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gridViewMaterialListNonWorkship.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewMaterialListNonWorkship.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridViewMaterialListNonWorkship.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridViewMaterialListNonWorkship.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.gridViewMaterialListNonWorkship.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridViewMaterialListNonWorkship.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.gridViewMaterialListNonWorkship.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gridViewMaterialListNonWorkship.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridViewMaterialListNonWorkship.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridViewMaterialListNonWorkship.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewMaterialListNonWorkship.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewMaterialListNonWorkship.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver;
            this.gridViewMaterialListNonWorkship.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver;
            this.gridViewMaterialListNonWorkship.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewMaterialListNonWorkship.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridViewMaterialListNonWorkship.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridViewMaterialListNonWorkship.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewMaterialListNonWorkship.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.gridViewMaterialListNonWorkship.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.gridViewMaterialListNonWorkship.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewMaterialListNonWorkship.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridViewMaterialListNonWorkship.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridViewMaterialListNonWorkship.Appearance.GroupButton.Options.UseForeColor = true;
            this.gridViewMaterialListNonWorkship.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gridViewMaterialListNonWorkship.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gridViewMaterialListNonWorkship.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridViewMaterialListNonWorkship.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridViewMaterialListNonWorkship.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridViewMaterialListNonWorkship.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridViewMaterialListNonWorkship.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.gridViewMaterialListNonWorkship.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gridViewMaterialListNonWorkship.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewMaterialListNonWorkship.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.gridViewMaterialListNonWorkship.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewMaterialListNonWorkship.Appearance.GroupPanel.Options.UseFont = true;
            this.gridViewMaterialListNonWorkship.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridViewMaterialListNonWorkship.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray;
            this.gridViewMaterialListNonWorkship.Appearance.GroupRow.ForeColor = System.Drawing.Color.Silver;
            this.gridViewMaterialListNonWorkship.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridViewMaterialListNonWorkship.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridViewMaterialListNonWorkship.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gridViewMaterialListNonWorkship.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver;
            this.gridViewMaterialListNonWorkship.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewMaterialListNonWorkship.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewMaterialListNonWorkship.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridViewMaterialListNonWorkship.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridViewMaterialListNonWorkship.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewMaterialListNonWorkship.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewMaterialListNonWorkship.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray;
            this.gridViewMaterialListNonWorkship.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewMaterialListNonWorkship.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewMaterialListNonWorkship.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewMaterialListNonWorkship.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver;
            this.gridViewMaterialListNonWorkship.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridViewMaterialListNonWorkship.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridViewMaterialListNonWorkship.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
            this.gridViewMaterialListNonWorkship.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewMaterialListNonWorkship.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gridViewMaterialListNonWorkship.Appearance.OddRow.Options.UseBackColor = true;
            this.gridViewMaterialListNonWorkship.Appearance.OddRow.Options.UseForeColor = true;
            this.gridViewMaterialListNonWorkship.Appearance.Preview.BackColor = System.Drawing.Color.White;
            this.gridViewMaterialListNonWorkship.Appearance.Preview.ForeColor = System.Drawing.Color.Navy;
            this.gridViewMaterialListNonWorkship.Appearance.Preview.Options.UseBackColor = true;
            this.gridViewMaterialListNonWorkship.Appearance.Preview.Options.UseForeColor = true;
            this.gridViewMaterialListNonWorkship.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridViewMaterialListNonWorkship.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridViewMaterialListNonWorkship.Appearance.Row.Options.UseBackColor = true;
            this.gridViewMaterialListNonWorkship.Appearance.Row.Options.UseForeColor = true;
            this.gridViewMaterialListNonWorkship.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gridViewMaterialListNonWorkship.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.gridViewMaterialListNonWorkship.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridViewMaterialListNonWorkship.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewMaterialListNonWorkship.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewMaterialListNonWorkship.Appearance.VertLine.BackColor = System.Drawing.Color.Silver;
            this.gridViewMaterialListNonWorkship.Appearance.VertLine.Options.UseBackColor = true;
            this.gridViewMaterialListNonWorkship.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gridViewMaterialListNonWorkship.GridControl = this.grdMaterialListNonWorkship;
            this.gridViewMaterialListNonWorkship.Name = "gridViewMaterialListNonWorkship";
            this.gridViewMaterialListNonWorkship.OptionsMenu.EnableColumnMenu = false;
            this.gridViewMaterialListNonWorkship.OptionsMenu.EnableFooterMenu = false;
            this.gridViewMaterialListNonWorkship.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewMaterialListNonWorkship.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewMaterialListNonWorkship.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewMaterialListNonWorkship.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewMaterialListNonWorkship.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewMaterialListNonWorkship.OptionsView.ShowDetailButtons = false;
            this.gridViewMaterialListNonWorkship.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridViewMaterialListNonWorkship.OptionsView.ShowFooter = true;
            this.gridViewMaterialListNonWorkship.OptionsView.ShowGroupPanel = false;
            this.gridViewMaterialListNonWorkship.PaintStyleName = "Web";
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.gridColumn1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridColumn1.AppearanceCell.Options.UseBackColor = true;
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
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.OptionsFilter.AllowFilter = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 58;
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
            this.gridColumn2.Caption = "AÇIKLAMA";
            this.gridColumn2.FieldName = "PozOBFDescription";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.OptionsFilter.AllowFilter = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 149;
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
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowFocus = false;
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.OptionsFilter.AllowFilter = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 49;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridColumn4.AppearanceCell.Options.UseFont = true;
            this.gridColumn4.AppearanceHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.gridColumn4.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridColumn4.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridColumn4.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridColumn4.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridColumn4.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn4.AppearanceHeader.Options.UseFont = true;
            this.gridColumn4.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn4.Caption = "SÖZ. MİKTARI";
            this.gridColumn4.FieldName = "Quantity";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.AllowFocus = false;
            this.gridColumn4.OptionsFilter.AllowFilter = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 57;
            // 
            // grdTenderGroup
            // 
            this.grdTenderGroup.Dock = System.Windows.Forms.DockStyle.Left;
            this.grdTenderGroup.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            gridLevelNode1.RelationName = "Level1";
            this.grdTenderGroup.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.grdTenderGroup.Location = new System.Drawing.Point(0, 52);
            this.grdTenderGroup.MainView = this.gridViewTenderGroup;
            this.grdTenderGroup.Margin = new System.Windows.Forms.Padding(4);
            this.grdTenderGroup.Name = "grdTenderGroup";
            this.grdTenderGroup.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnGuncelle,
            this.btnSil,
            this.rpstColIsSelected});
            this.grdTenderGroup.Size = new System.Drawing.Size(294, 639);
            this.grdTenderGroup.TabIndex = 34;
            this.grdTenderGroup.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTenderGroup,
            this.gridView2});
            // 
            // gridViewTenderGroup
            // 
            this.gridViewTenderGroup.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridViewTenderGroup.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gridViewTenderGroup.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridViewTenderGroup.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewTenderGroup.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridViewTenderGroup.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridViewTenderGroup.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridViewTenderGroup.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridViewTenderGroup.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.gridViewTenderGroup.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(215)))));
            this.gridViewTenderGroup.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White;
            this.gridViewTenderGroup.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gridViewTenderGroup.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridViewTenderGroup.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridViewTenderGroup.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridViewTenderGroup.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridViewTenderGroup.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gridViewTenderGroup.Appearance.Empty.Options.UseBackColor = true;
            this.gridViewTenderGroup.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridViewTenderGroup.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewTenderGroup.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridViewTenderGroup.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridViewTenderGroup.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridViewTenderGroup.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gridViewTenderGroup.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridViewTenderGroup.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridViewTenderGroup.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridViewTenderGroup.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridViewTenderGroup.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gridViewTenderGroup.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gridViewTenderGroup.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridViewTenderGroup.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridViewTenderGroup.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(148)))));
            this.gridViewTenderGroup.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridViewTenderGroup.Appearance.FocusedRow.BackColor = System.Drawing.Color.DodgerBlue;
            this.gridViewTenderGroup.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewTenderGroup.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewTenderGroup.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewTenderGroup.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridViewTenderGroup.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gridViewTenderGroup.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridViewTenderGroup.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridViewTenderGroup.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridViewTenderGroup.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridViewTenderGroup.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridViewTenderGroup.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridViewTenderGroup.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewTenderGroup.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridViewTenderGroup.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridViewTenderGroup.Appearance.GroupButton.Options.UseForeColor = true;
            this.gridViewTenderGroup.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridViewTenderGroup.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridViewTenderGroup.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridViewTenderGroup.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridViewTenderGroup.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridViewTenderGroup.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridViewTenderGroup.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gridViewTenderGroup.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridViewTenderGroup.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewTenderGroup.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridViewTenderGroup.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridViewTenderGroup.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridViewTenderGroup.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewTenderGroup.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewTenderGroup.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridViewTenderGroup.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gridViewTenderGroup.Appearance.GroupRow.Options.UseFont = true;
            this.gridViewTenderGroup.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridViewTenderGroup.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridViewTenderGroup.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gridViewTenderGroup.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridViewTenderGroup.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewTenderGroup.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridViewTenderGroup.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridViewTenderGroup.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridViewTenderGroup.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewTenderGroup.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.gridViewTenderGroup.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gridViewTenderGroup.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewTenderGroup.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewTenderGroup.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.gridViewTenderGroup.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridViewTenderGroup.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridViewTenderGroup.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewTenderGroup.Appearance.OddRow.Options.UseBackColor = true;
            this.gridViewTenderGroup.Appearance.OddRow.Options.UseForeColor = true;
            this.gridViewTenderGroup.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.gridViewTenderGroup.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.gridViewTenderGroup.Appearance.Preview.Options.UseBackColor = true;
            this.gridViewTenderGroup.Appearance.Preview.Options.UseForeColor = true;
            this.gridViewTenderGroup.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridViewTenderGroup.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridViewTenderGroup.Appearance.Row.Options.UseBackColor = true;
            this.gridViewTenderGroup.Appearance.Row.Options.UseForeColor = true;
            this.gridViewTenderGroup.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gridViewTenderGroup.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridViewTenderGroup.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(197)))), ((int)(((byte)(205)))));
            this.gridViewTenderGroup.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewTenderGroup.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewTenderGroup.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewTenderGroup.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.gridViewTenderGroup.Appearance.VertLine.Options.UseBackColor = true;
            this.gridViewTenderGroup.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIsSelected,
            this.colId,
            this.gridColumn9});
            this.gridViewTenderGroup.GridControl = this.grdTenderGroup;
            this.gridViewTenderGroup.Name = "gridViewTenderGroup";
            this.gridViewTenderGroup.OptionsMenu.EnableColumnMenu = false;
            this.gridViewTenderGroup.OptionsMenu.EnableFooterMenu = false;
            this.gridViewTenderGroup.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewTenderGroup.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewTenderGroup.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewTenderGroup.OptionsView.ShowFooter = true;
            this.gridViewTenderGroup.OptionsView.ShowGroupPanel = false;
            this.gridViewTenderGroup.PaintStyleName = "Web";
            // 
            // colIsSelected
            // 
            this.colIsSelected.Caption = " ";
            this.colIsSelected.ColumnEdit = this.rpstColIsSelected;
            this.colIsSelected.FieldName = "IsSelected";
            this.colIsSelected.Image = ((System.Drawing.Image)(resources.GetObject("colIsSelected.Image")));
            this.colIsSelected.Name = "colIsSelected";
            this.colIsSelected.OptionsFilter.AllowFilter = false;
            this.colIsSelected.Visible = true;
            this.colIsSelected.VisibleIndex = 0;
            // 
            // rpstColIsSelected
            // 
            this.rpstColIsSelected.AutoHeight = false;
            this.rpstColIsSelected.LookAndFeel.SkinName = "McSkin";
            this.rpstColIsSelected.LookAndFeel.UseDefaultLookAndFeel = false;
            this.rpstColIsSelected.Name = "rpstColIsSelected";
            // 
            // colId
            // 
            this.colId.Caption = "gridColumn7";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // gridColumn9
            // 
            this.gridColumn9.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridColumn9.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridColumn9.AppearanceHeader.Options.UseBorderColor = true;
            this.gridColumn9.AppearanceHeader.Options.UseFont = true;
            this.gridColumn9.Caption = "GRUP ADI";
            this.gridColumn9.FieldName = "Description";
            this.gridColumn9.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Value;
            this.gridColumn9.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn9.Image")));
            this.gridColumn9.MinWidth = 80;
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.OptionsColumn.AllowFocus = false;
            this.gridColumn9.OptionsColumn.ReadOnly = true;
            this.gridColumn9.OptionsFilter.AllowFilter = false;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 1;
            this.gridColumn9.Width = 429;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.AutoHeight = false;
            this.btnGuncelle.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.TopCenter, ((System.Drawing.Image)(resources.GetObject("btnGuncelle.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btnGuncelle.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // btnSil
            // 
            this.btnSil.AutoHeight = false;
            this.btnSil.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnSil.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.btnSil.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnSil.Name = "btnSil";
            this.btnSil.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.grdTenderGroup;
            this.gridView2.Name = "gridView2";
            // 
            // txtSozlesmeBedeli
            // 
            this.txtSozlesmeBedeli.Location = new System.Drawing.Point(627, 4);
            this.txtSozlesmeBedeli.Name = "txtSozlesmeBedeli";
            this.txtSozlesmeBedeli.Size = new System.Drawing.Size(206, 26);
            this.txtSozlesmeBedeli.TabIndex = 38;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Location = new System.Drawing.Point(497, 7);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(124, 19);
            this.labelControl1.TabIndex = 39;
            this.labelControl1.Text = "Sözleşme Bedeli :";
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.gridColumn5.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridColumn5.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn5.AppearanceHeader.Options.UseFont = true;
            this.gridColumn5.Caption = "SÖZ.B.FİYATI";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.gridColumn6.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridColumn6.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn6.AppearanceHeader.Options.UseFont = true;
            this.gridColumn6.Caption = "TUTARI";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // frm_SozlesmeKalemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 691);
            this.ControlBox = false;
            this.Controls.Add(this.grdMaterialListNonWorkship);
            this.Controls.Add(this.grdTenderGroup);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "frm_SozlesmeKalemleri";
            this.ShowInTaskbar = false;
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcWorld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMaterialListNonWorkship)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMaterialListNonWorkship)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTenderGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTenderGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpstColIsSelected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuncelle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSozlesmeBedeli.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private System.Windows.Forms.PictureBox pcWorld;
        private DevExpress.XtraEditors.LabelControl txtAdimAciklama;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl grdMaterialListNonWorkship;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMaterialListNonWorkship;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.GridControl grdTenderGroup;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTenderGroup;
        private DevExpress.XtraGrid.Columns.GridColumn colIsSelected;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit rpstColIsSelected;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnGuncelle;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnSil;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.TextEdit txtSozlesmeBedeli;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
    }
}