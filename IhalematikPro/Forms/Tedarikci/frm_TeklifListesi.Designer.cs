namespace IhalematikProUI.Forms
{
    partial class frm_TeklifListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TeklifListesi));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTenderCaptin = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.pcWorld = new System.Windows.Forms.PictureBox();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.grdOffer = new DevExpress.XtraGrid.GridControl();
            this.gridViewOffer = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOpen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnOpen = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnActive = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colPasive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnPasive = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.statusPanel = new System.Windows.Forms.Panel();
            this.cmbAktivePasive = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblRecordCount = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcWorld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOffer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOffer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPasive)).BeginInit();
            this.statusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAktivePasive.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            // 
            // lblTenderCaptin
            // 
            this.lblTenderCaptin.Appearance.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTenderCaptin.Appearance.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblTenderCaptin.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lblTenderCaptin.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lblTenderCaptin.LineColor = System.Drawing.Color.Red;
            this.lblTenderCaptin.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.lblTenderCaptin.Location = new System.Drawing.Point(51, 1);
            this.lblTenderCaptin.Margin = new System.Windows.Forms.Padding(4);
            this.lblTenderCaptin.Name = "lblTenderCaptin";
            this.lblTenderCaptin.ShowLineShadow = false;
            this.lblTenderCaptin.Size = new System.Drawing.Size(161, 35);
            this.lblTenderCaptin.TabIndex = 0;
            this.lblTenderCaptin.Text = "TEKLİF LİSTESİ";
            this.lblTenderCaptin.UseMnemonic = false;
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.pcWorld);
            this.panelControl2.Controls.Add(this.lblTenderCaptin);
            this.panelControl2.Controls.Add(this.btnKapat);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1362, 35);
            this.panelControl2.TabIndex = 2;
            // 
            // pcWorld
            // 
            this.pcWorld.Dock = System.Windows.Forms.DockStyle.Left;
            this.pcWorld.Image = ((System.Drawing.Image)(resources.GetObject("pcWorld.Image")));
            this.pcWorld.Location = new System.Drawing.Point(0, 0);
            this.pcWorld.Name = "pcWorld";
            this.pcWorld.Size = new System.Drawing.Size(50, 35);
            this.pcWorld.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcWorld.TabIndex = 95;
            this.pcWorld.TabStop = false;
            // 
            // btnKapat
            // 
            this.btnKapat.AutoSize = true;
            this.btnKapat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKapat.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.Image")));
            this.btnKapat.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnKapat.Location = new System.Drawing.Point(1334, 0);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(4);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(28, 35);
            this.btnKapat.TabIndex = 1;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelControl1.Appearance.BackColor2 = System.Drawing.Color.DodgerBlue;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.ContentImageAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1362, 35);
            this.panelControl1.TabIndex = 95;
            // 
            // grdOffer
            // 
            this.grdOffer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdOffer.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.grdOffer.Location = new System.Drawing.Point(0, 35);
            this.grdOffer.MainView = this.gridViewOffer;
            this.grdOffer.Margin = new System.Windows.Forms.Padding(4);
            this.grdOffer.Name = "grdOffer";
            this.grdOffer.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnOpen,
            this.btnActive,
            this.btnPasive});
            this.grdOffer.Size = new System.Drawing.Size(1362, 707);
            this.grdOffer.TabIndex = 98;
            this.grdOffer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewOffer});
            // 
            // gridViewOffer
            // 
            this.gridViewOffer.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver;
            this.gridViewOffer.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewOffer.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Silver;
            this.gridViewOffer.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray;
            this.gridViewOffer.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridViewOffer.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridViewOffer.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridViewOffer.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewOffer.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gridViewOffer.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewOffer.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue;
            this.gridViewOffer.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridViewOffer.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridViewOffer.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridViewOffer.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.gridViewOffer.Appearance.Empty.Options.UseBackColor = true;
            this.gridViewOffer.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gridViewOffer.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite;
            this.gridViewOffer.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewOffer.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewOffer.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridViewOffer.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridViewOffer.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewOffer.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.gridViewOffer.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewOffer.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewOffer.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewOffer.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridViewOffer.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridViewOffer.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridViewOffer.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(80)))), ((int)(((byte)(135)))));
            this.gridViewOffer.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewOffer.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gridViewOffer.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewOffer.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridViewOffer.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridViewOffer.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.gridViewOffer.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridViewOffer.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.gridViewOffer.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gridViewOffer.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridViewOffer.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridViewOffer.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewOffer.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewOffer.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver;
            this.gridViewOffer.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver;
            this.gridViewOffer.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewOffer.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridViewOffer.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridViewOffer.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewOffer.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.gridViewOffer.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.gridViewOffer.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewOffer.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridViewOffer.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridViewOffer.Appearance.GroupButton.Options.UseForeColor = true;
            this.gridViewOffer.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gridViewOffer.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gridViewOffer.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridViewOffer.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridViewOffer.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridViewOffer.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridViewOffer.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.gridViewOffer.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gridViewOffer.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewOffer.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.gridViewOffer.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewOffer.Appearance.GroupPanel.Options.UseFont = true;
            this.gridViewOffer.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridViewOffer.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray;
            this.gridViewOffer.Appearance.GroupRow.ForeColor = System.Drawing.Color.Silver;
            this.gridViewOffer.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridViewOffer.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridViewOffer.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gridViewOffer.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver;
            this.gridViewOffer.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewOffer.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewOffer.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridViewOffer.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridViewOffer.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewOffer.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewOffer.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray;
            this.gridViewOffer.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewOffer.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewOffer.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewOffer.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver;
            this.gridViewOffer.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridViewOffer.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridViewOffer.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
            this.gridViewOffer.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewOffer.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gridViewOffer.Appearance.OddRow.Options.UseBackColor = true;
            this.gridViewOffer.Appearance.OddRow.Options.UseForeColor = true;
            this.gridViewOffer.Appearance.Preview.BackColor = System.Drawing.Color.White;
            this.gridViewOffer.Appearance.Preview.ForeColor = System.Drawing.Color.Navy;
            this.gridViewOffer.Appearance.Preview.Options.UseBackColor = true;
            this.gridViewOffer.Appearance.Preview.Options.UseForeColor = true;
            this.gridViewOffer.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridViewOffer.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridViewOffer.Appearance.Row.Options.UseBackColor = true;
            this.gridViewOffer.Appearance.Row.Options.UseForeColor = true;
            this.gridViewOffer.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gridViewOffer.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.gridViewOffer.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridViewOffer.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewOffer.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewOffer.Appearance.VertLine.BackColor = System.Drawing.Color.Silver;
            this.gridViewOffer.Appearance.VertLine.Options.UseBackColor = true;
            this.gridViewOffer.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.colOpen,
            this.colActive,
            this.colPasive});
            this.gridViewOffer.GridControl = this.grdOffer;
            this.gridViewOffer.Name = "gridViewOffer";
            this.gridViewOffer.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewOffer.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewOffer.OptionsView.ShowDetailButtons = false;
            this.gridViewOffer.OptionsView.ShowGroupPanel = false;
            this.gridViewOffer.PaintStyleName = "Web";
            // 
            // colId
            // 
            this.colId.Caption = "gridColumn4";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
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
            this.gridColumn1.Caption = "TEKLİF NO";
            this.gridColumn1.FieldName = "Number";
            this.gridColumn1.MinWidth = 80;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.OptionsFilter.AllowFilter = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 132;
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
            this.gridColumn2.Caption = "TEKLİF TARIHI";
            this.gridColumn2.FieldName = "LastOfferDate";
            this.gridColumn2.MinWidth = 80;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.OptionsFilter.AllowFilter = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 174;
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
            this.gridColumn3.Caption = "ACIKLAMA";
            this.gridColumn3.FieldName = "Description";
            this.gridColumn3.MinWidth = 80;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowFocus = false;
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.OptionsFilter.AllowFilter = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 1260;
            // 
            // colOpen
            // 
            this.colOpen.AppearanceHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.colOpen.AppearanceHeader.Options.UseBackColor = true;
            this.colOpen.ColumnEdit = this.btnOpen;
            this.colOpen.MaxWidth = 20;
            this.colOpen.Name = "colOpen";
            this.colOpen.OptionsFilter.AllowFilter = false;
            this.colOpen.Visible = true;
            this.colOpen.VisibleIndex = 3;
            this.colOpen.Width = 20;
            // 
            // btnOpen
            // 
            this.btnOpen.AutoHeight = false;
            this.btnOpen.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnOpen.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "Teklifi Aç", null, null, true)});
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnOpen.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnOpen_ButtonClick);
            // 
            // colActive
            // 
            this.colActive.AppearanceHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.colActive.AppearanceHeader.Options.UseBackColor = true;
            this.colActive.ColumnEdit = this.btnActive;
            this.colActive.MaxWidth = 20;
            this.colActive.Name = "colActive";
            this.colActive.OptionsFilter.AllowFilter = false;
            this.colActive.Visible = true;
            this.colActive.VisibleIndex = 4;
            this.colActive.Width = 20;
            // 
            // btnActive
            // 
            this.btnActive.AutoHeight = false;
            this.btnActive.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::IhalematikProUI.Properties.Resources.activeData, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "Aktif Yap", null, null, true)});
            this.btnActive.Name = "btnActive";
            this.btnActive.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // colPasive
            // 
            this.colPasive.AppearanceHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.colPasive.AppearanceHeader.Options.UseBackColor = true;
            this.colPasive.ColumnEdit = this.btnPasive;
            this.colPasive.MaxWidth = 20;
            this.colPasive.Name = "colPasive";
            this.colPasive.OptionsFilter.AllowFilter = false;
            this.colPasive.Visible = true;
            this.colPasive.VisibleIndex = 5;
            this.colPasive.Width = 20;
            // 
            // btnPasive
            // 
            this.btnPasive.AutoHeight = false;
            this.btnPasive.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::IhalematikProUI.Properties.Resources.PasiveData, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "Pasif Yap", null, null, true)});
            this.btnPasive.Name = "btnPasive";
            this.btnPasive.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // statusPanel
            // 
            this.statusPanel.Controls.Add(this.cmbAktivePasive);
            this.statusPanel.Controls.Add(this.lblRecordCount);
            this.statusPanel.Controls.Add(this.labelControl14);
            this.statusPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusPanel.Location = new System.Drawing.Point(0, 708);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(1362, 34);
            this.statusPanel.TabIndex = 99;
            // 
            // cmbAktivePasive
            // 
            this.cmbAktivePasive.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmbAktivePasive.EditValue = "Aktif Kayıtlar";
            this.cmbAktivePasive.EnterMoveNextControl = true;
            this.cmbAktivePasive.Location = new System.Drawing.Point(1192, 0);
            this.cmbAktivePasive.Name = "cmbAktivePasive";
            this.cmbAktivePasive.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbAktivePasive.Properties.Appearance.Options.UseFont = true;
            this.cmbAktivePasive.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.cmbAktivePasive.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbAktivePasive.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.cmbAktivePasive.Properties.Items.AddRange(new object[] {
            "Aktif Kayıtlar",
            "Pasif Kayıtlar"});
            this.cmbAktivePasive.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbAktivePasive.Size = new System.Drawing.Size(170, 28);
            this.cmbAktivePasive.TabIndex = 1;
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRecordCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblRecordCount.Location = new System.Drawing.Point(97, 0);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(18, 22);
            this.lblRecordCount.TabIndex = 0;
            this.lblRecordCount.Text = "10";
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl14.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelControl14.Location = new System.Drawing.Point(0, 0);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(97, 22);
            this.labelControl14.TabIndex = 0;
            this.labelControl14.Text = "Kayıt Sayısı : ";
            // 
            // frm_TeklifListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnKapat;
            this.ClientSize = new System.Drawing.Size(1362, 742);
            this.ControlBox = false;
            this.Controls.Add(this.statusPanel);
            this.Controls.Add(this.grdOffer);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_TeklifListesi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_TeklifListesi_Load);
            this.Shown += new System.EventHandler(this.frm_TeklifListesi_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcWorld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdOffer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOffer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPasive)).EndInit();
            this.statusPanel.ResumeLayout(false);
            this.statusPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAktivePasive.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.LabelControl lblTenderCaptin;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.PictureBox pcWorld;
        private DevExpress.XtraGrid.GridControl grdOffer;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewOffer;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn colOpen;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnOpen;
        private System.Windows.Forms.Panel statusPanel;
        private DevExpress.XtraEditors.ComboBoxEdit cmbAktivePasive;
        private DevExpress.XtraEditors.LabelControl lblRecordCount;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnActive;
        private DevExpress.XtraGrid.Columns.GridColumn colPasive;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnPasive;
    }
}