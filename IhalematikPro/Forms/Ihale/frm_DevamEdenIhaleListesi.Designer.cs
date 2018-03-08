namespace IhalematikPro.Forms
{
    partial class frm_DevamEdenIhaleListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DevamEdenIhaleListesi));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pcWorld = new System.Windows.Forms.PictureBox();
            this.lblTenderCaptin = new DevExpress.XtraEditors.LabelControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grdActiveTenderList = new DevExpress.XtraGrid.GridControl();
            this.gridViewActiveTenderList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnIhaleAc = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDetay = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.statusPanel = new System.Windows.Forms.Panel();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblRecordCount = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtTenderNumber = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenderDescription = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcWorld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdActiveTenderList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewActiveTenderList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIhaleAc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDetay)).BeginInit();
            this.statusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenderNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenderDescription.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelControl1.Appearance.BackColor2 = System.Drawing.Color.DodgerBlue;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.ContentImageAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.panelControl1.Controls.Add(this.pcWorld);
            this.panelControl1.Controls.Add(this.lblTenderCaptin);
            this.panelControl1.Controls.Add(this.btnKapat);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1224, 35);
            this.panelControl1.TabIndex = 37;
            // 
            // pcWorld
            // 
            this.pcWorld.Dock = System.Windows.Forms.DockStyle.Left;
            this.pcWorld.Image = ((System.Drawing.Image)(resources.GetObject("pcWorld.Image")));
            this.pcWorld.Location = new System.Drawing.Point(0, 0);
            this.pcWorld.Name = "pcWorld";
            this.pcWorld.Size = new System.Drawing.Size(50, 35);
            this.pcWorld.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcWorld.TabIndex = 18;
            this.pcWorld.TabStop = false;
            // 
            // lblTenderCaptin
            // 
            this.lblTenderCaptin.Appearance.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTenderCaptin.Appearance.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblTenderCaptin.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lblTenderCaptin.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lblTenderCaptin.LineColor = System.Drawing.Color.Red;
            this.lblTenderCaptin.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.lblTenderCaptin.Location = new System.Drawing.Point(57, 0);
            this.lblTenderCaptin.Margin = new System.Windows.Forms.Padding(4);
            this.lblTenderCaptin.Name = "lblTenderCaptin";
            this.lblTenderCaptin.ShowLineShadow = false;
            this.lblTenderCaptin.Size = new System.Drawing.Size(221, 35);
            this.lblTenderCaptin.TabIndex = 17;
            this.lblTenderCaptin.Text = "AÇIK TEKLİF LİSTESİ";
            this.lblTenderCaptin.UseMnemonic = false;
            // 
            // btnKapat
            // 
            this.btnKapat.AutoSize = true;
            this.btnKapat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKapat.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.Image")));
            this.btnKapat.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnKapat.Location = new System.Drawing.Point(1196, 0);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(4);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(28, 35);
            this.btnKapat.TabIndex = 3;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            // 
            // grdActiveTenderList
            // 
            this.grdActiveTenderList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdActiveTenderList.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.grdActiveTenderList.Location = new System.Drawing.Point(0, 85);
            this.grdActiveTenderList.MainView = this.gridViewActiveTenderList;
            this.grdActiveTenderList.Margin = new System.Windows.Forms.Padding(4);
            this.grdActiveTenderList.Name = "grdActiveTenderList";
            this.grdActiveTenderList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnIhaleAc,
            this.btnDetay});
            this.grdActiveTenderList.Size = new System.Drawing.Size(1224, 568);
            this.grdActiveTenderList.TabIndex = 0;
            this.grdActiveTenderList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewActiveTenderList});
            // 
            // gridViewActiveTenderList
            // 
            this.gridViewActiveTenderList.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver;
            this.gridViewActiveTenderList.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewActiveTenderList.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Silver;
            this.gridViewActiveTenderList.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray;
            this.gridViewActiveTenderList.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridViewActiveTenderList.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridViewActiveTenderList.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridViewActiveTenderList.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewActiveTenderList.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gridViewActiveTenderList.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewActiveTenderList.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue;
            this.gridViewActiveTenderList.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridViewActiveTenderList.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridViewActiveTenderList.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridViewActiveTenderList.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gridViewActiveTenderList.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite;
            this.gridViewActiveTenderList.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewActiveTenderList.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewActiveTenderList.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridViewActiveTenderList.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridViewActiveTenderList.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewActiveTenderList.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.gridViewActiveTenderList.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewActiveTenderList.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewActiveTenderList.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewActiveTenderList.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridViewActiveTenderList.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridViewActiveTenderList.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridViewActiveTenderList.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(80)))), ((int)(((byte)(135)))));
            this.gridViewActiveTenderList.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewActiveTenderList.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gridViewActiveTenderList.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewActiveTenderList.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridViewActiveTenderList.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridViewActiveTenderList.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.gridViewActiveTenderList.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridViewActiveTenderList.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.gridViewActiveTenderList.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gridViewActiveTenderList.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridViewActiveTenderList.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridViewActiveTenderList.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewActiveTenderList.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewActiveTenderList.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver;
            this.gridViewActiveTenderList.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver;
            this.gridViewActiveTenderList.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewActiveTenderList.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridViewActiveTenderList.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridViewActiveTenderList.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewActiveTenderList.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.gridViewActiveTenderList.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.gridViewActiveTenderList.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewActiveTenderList.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridViewActiveTenderList.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridViewActiveTenderList.Appearance.GroupButton.Options.UseForeColor = true;
            this.gridViewActiveTenderList.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gridViewActiveTenderList.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gridViewActiveTenderList.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridViewActiveTenderList.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridViewActiveTenderList.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridViewActiveTenderList.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridViewActiveTenderList.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.gridViewActiveTenderList.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gridViewActiveTenderList.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewActiveTenderList.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.gridViewActiveTenderList.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewActiveTenderList.Appearance.GroupPanel.Options.UseFont = true;
            this.gridViewActiveTenderList.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridViewActiveTenderList.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray;
            this.gridViewActiveTenderList.Appearance.GroupRow.ForeColor = System.Drawing.Color.Silver;
            this.gridViewActiveTenderList.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridViewActiveTenderList.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridViewActiveTenderList.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gridViewActiveTenderList.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver;
            this.gridViewActiveTenderList.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewActiveTenderList.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewActiveTenderList.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridViewActiveTenderList.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridViewActiveTenderList.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewActiveTenderList.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewActiveTenderList.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray;
            this.gridViewActiveTenderList.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewActiveTenderList.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewActiveTenderList.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewActiveTenderList.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver;
            this.gridViewActiveTenderList.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridViewActiveTenderList.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridViewActiveTenderList.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
            this.gridViewActiveTenderList.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewActiveTenderList.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gridViewActiveTenderList.Appearance.OddRow.Options.UseBackColor = true;
            this.gridViewActiveTenderList.Appearance.OddRow.Options.UseForeColor = true;
            this.gridViewActiveTenderList.Appearance.Preview.BackColor = System.Drawing.Color.White;
            this.gridViewActiveTenderList.Appearance.Preview.ForeColor = System.Drawing.Color.Navy;
            this.gridViewActiveTenderList.Appearance.Preview.Options.UseBackColor = true;
            this.gridViewActiveTenderList.Appearance.Preview.Options.UseForeColor = true;
            this.gridViewActiveTenderList.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridViewActiveTenderList.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridViewActiveTenderList.Appearance.Row.Options.UseBackColor = true;
            this.gridViewActiveTenderList.Appearance.Row.Options.UseForeColor = true;
            this.gridViewActiveTenderList.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gridViewActiveTenderList.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.gridViewActiveTenderList.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridViewActiveTenderList.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewActiveTenderList.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewActiveTenderList.Appearance.VertLine.BackColor = System.Drawing.Color.Silver;
            this.gridViewActiveTenderList.Appearance.VertLine.Options.UseBackColor = true;
            this.gridViewActiveTenderList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gridViewActiveTenderList.GridControl = this.grdActiveTenderList;
            this.gridViewActiveTenderList.Name = "gridViewActiveTenderList";
            this.gridViewActiveTenderList.OptionsMenu.EnableColumnMenu = false;
            this.gridViewActiveTenderList.OptionsMenu.EnableFooterMenu = false;
            this.gridViewActiveTenderList.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewActiveTenderList.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewActiveTenderList.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewActiveTenderList.OptionsView.ShowDetailButtons = false;
            this.gridViewActiveTenderList.OptionsView.ShowGroupPanel = false;
            this.gridViewActiveTenderList.PaintStyleName = "Web";
            // 
            // colId
            // 
            this.colId.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colId.AppearanceHeader.Options.UseFont = true;
            this.colId.Caption = "gridColumn6";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumn1.AppearanceHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridColumn1.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridColumn1.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridColumn1.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridColumn1.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn1.Caption = "IHALE NO";
            this.gridColumn1.FieldName = "Number";
            this.gridColumn1.MinWidth = 80;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.OptionsFilter.AllowFilter = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 142;
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
            this.gridColumn2.Caption = "IHALE TARIHI";
            this.gridColumn2.FieldName = "LastOfferDate";
            this.gridColumn2.MinWidth = 80;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.OptionsFilter.AllowFilter = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 172;
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
            this.gridColumn3.Caption = "ACIKLAMA";
            this.gridColumn3.FieldName = "Description";
            this.gridColumn3.MinWidth = 80;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowFocus = false;
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.OptionsFilter.AllowFilter = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 880;
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
            this.gridColumn4.ColumnEdit = this.btnIhaleAc;
            this.gridColumn4.MaxWidth = 30;
            this.gridColumn4.MinWidth = 30;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsFilter.AllowFilter = false;
            this.gridColumn4.ToolTip = "İhale Aç";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 30;
            // 
            // btnIhaleAc
            // 
            this.btnIhaleAc.AutoHeight = false;
            this.btnIhaleAc.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnIhaleAc.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btnIhaleAc.Name = "btnIhaleAc";
            this.btnIhaleAc.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnIhaleAc.Click += new System.EventHandler(this.btnIhaleAc_Click);
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.gridColumn5.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridColumn5.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn5.AppearanceHeader.Options.UseFont = true;
            this.gridColumn5.ColumnEdit = this.btnDetay;
            this.gridColumn5.MaxWidth = 30;
            this.gridColumn5.MinWidth = 30;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsFilter.AllowFilter = false;
            this.gridColumn5.ToolTip = "İhale Detayı Göster";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 30;
            // 
            // btnDetay
            // 
            this.btnDetay.AutoHeight = false;
            this.btnDetay.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::IhalematikProUI.Properties.Resources.detail_icon, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.btnDetay.Name = "btnDetay";
            this.btnDetay.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnDetay.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnDetay_ButtonClick);
            // 
            // statusPanel
            // 
            this.statusPanel.Controls.Add(this.comboBoxEdit1);
            this.statusPanel.Controls.Add(this.lblRecordCount);
            this.statusPanel.Controls.Add(this.labelControl14);
            this.statusPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusPanel.Location = new System.Drawing.Point(0, 653);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(1224, 34);
            this.statusPanel.TabIndex = 96;
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Dock = System.Windows.Forms.DockStyle.Right;
            this.comboBoxEdit1.EditValue = "Aktif Kayıtlar";
            this.comboBoxEdit1.EnterMoveNextControl = true;
            this.comboBoxEdit1.Location = new System.Drawing.Point(1054, 0);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxEdit1.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "Aktif Kayıtlar",
            "Pasif Kayıtlar",
            "Tüm Kayıtlar"});
            this.comboBoxEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEdit1.Size = new System.Drawing.Size(170, 28);
            this.comboBoxEdit1.TabIndex = 1;
            this.comboBoxEdit1.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit1_SelectedIndexChanged);
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
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.simpleButton1);
            this.panelControl3.Controls.Add(this.txtTenderNumber);
            this.panelControl3.Controls.Add(this.labelControl7);
            this.panelControl3.Controls.Add(this.txtTenderDescription);
            this.panelControl3.Controls.Add(this.labelControl6);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(0, 35);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1224, 50);
            this.panelControl3.TabIndex = 97;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.simpleButton1.Location = new System.Drawing.Point(770, 13);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(50, 31);
            toolTipTitleItem1.Text = "Kaydet";
            superToolTip1.Items.Add(toolTipTitleItem1);
            this.simpleButton1.SuperTip = superToolTip1;
            this.simpleButton1.TabIndex = 26;
            this.simpleButton1.Text = "Bul";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // txtTenderNumber
            // 
            this.txtTenderNumber.EnterMoveNextControl = true;
            this.txtTenderNumber.Location = new System.Drawing.Point(86, 12);
            this.txtTenderNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenderNumber.Name = "txtTenderNumber";
            this.txtTenderNumber.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtTenderNumber.Properties.Appearance.Options.UseBackColor = true;
            this.txtTenderNumber.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtTenderNumber.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtTenderNumber.Size = new System.Drawing.Size(150, 26);
            this.txtTenderNumber.TabIndex = 0;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl7.Location = new System.Drawing.Point(22, 13);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(66, 19);
            this.labelControl7.TabIndex = 22;
            this.labelControl7.Text = "İhale No:";
            // 
            // txtTenderDescription
            // 
            this.txtTenderDescription.EnterMoveNextControl = true;
            this.txtTenderDescription.Location = new System.Drawing.Point(340, 15);
            this.txtTenderDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenderDescription.Name = "txtTenderDescription";
            this.txtTenderDescription.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtTenderDescription.Properties.Appearance.Options.UseBackColor = true;
            this.txtTenderDescription.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtTenderDescription.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtTenderDescription.Size = new System.Drawing.Size(422, 26);
            this.txtTenderDescription.TabIndex = 1;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl6.Location = new System.Drawing.Point(266, 15);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(70, 19);
            this.labelControl6.TabIndex = 19;
            this.labelControl6.Text = "Açıklama:";
            // 
            // frm_DevamEdenIhaleListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 687);
            this.ControlBox = false;
            this.Controls.Add(this.grdActiveTenderList);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.statusPanel);
            this.Controls.Add(this.panelControl1);
            this.LookAndFeel.SkinName = "London Liquid Sky";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_DevamEdenIhaleListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_DevamEdenIhaleListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcWorld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdActiveTenderList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewActiveTenderList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIhaleAc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDetay)).EndInit();
            this.statusPanel.ResumeLayout(false);
            this.statusPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenderNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenderDescription.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraGrid.GridControl grdActiveTenderList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewActiveTenderList;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnIhaleAc;
        private System.Windows.Forms.Panel statusPanel;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.LabelControl lblRecordCount;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit txtTenderNumber;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtTenderDescription;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDetay;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private System.Windows.Forms.PictureBox pcWorld;
        private DevExpress.XtraEditors.LabelControl lblTenderCaptin;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
    }
}