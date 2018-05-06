namespace IhalematikProUI.Forms.Taseron
{
    partial class frm_TasareIsListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TasareIsListesi));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.grdActiveTenderList = new DevExpress.XtraGrid.GridControl();
            this.gridViewActiveTenderList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chYesNo = new DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit();
            this.colOpenTender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnIhaleAc = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDetay = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colPasive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnPasive = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnActive = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pcWorld = new System.Windows.Forms.PictureBox();
            this.lblTenderCaptin = new DevExpress.XtraEditors.LabelControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdActiveTenderList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewActiveTenderList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chYesNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIhaleAc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDetay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPasive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcWorld)).BeginInit();
            this.SuspendLayout();
            // 
            // grdActiveTenderList
            // 
            this.grdActiveTenderList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdActiveTenderList.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.grdActiveTenderList.Location = new System.Drawing.Point(0, 35);
            this.grdActiveTenderList.MainView = this.gridViewActiveTenderList;
            this.grdActiveTenderList.Margin = new System.Windows.Forms.Padding(4);
            this.grdActiveTenderList.Name = "grdActiveTenderList";
            this.grdActiveTenderList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnIhaleAc,
            this.btnDetay,
            this.btnPasive,
            this.btnActive,
            this.repositoryItemLookUpEdit1,
            this.chYesNo});
            this.grdActiveTenderList.Size = new System.Drawing.Size(1300, 582);
            this.grdActiveTenderList.TabIndex = 38;
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
            this.gridColumn6,
            this.gridColumn4,
            this.colOpenTender,
            this.gridColumn5,
            this.colPasive,
            this.colActive});
            this.gridViewActiveTenderList.GridControl = this.grdActiveTenderList;
            this.gridViewActiveTenderList.Name = "gridViewActiveTenderList";
            this.gridViewActiveTenderList.OptionsMenu.EnableColumnMenu = false;
            this.gridViewActiveTenderList.OptionsMenu.EnableFooterMenu = false;
            this.gridViewActiveTenderList.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewActiveTenderList.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewActiveTenderList.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewActiveTenderList.OptionsView.ShowDetailButtons = false;
            this.gridViewActiveTenderList.OptionsView.ShowFooter = true;
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
            this.gridColumn1.Caption = "TASERE NO";
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
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridColumn2.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridColumn2.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridColumn2.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridColumn2.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn2.Caption = "BİTİŞ TARİHİ";
            this.gridColumn2.FieldName = "LastOfferDate";
            this.gridColumn2.MinWidth = 80;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.OptionsFilter.AllowFilter = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            this.gridColumn2.Width = 175;
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
            this.gridColumn3.Width = 701;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.gridColumn6.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridColumn6.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn6.AppearanceHeader.Options.UseFont = true;
            this.gridColumn6.Caption = "BAŞLAMA TARİHİ";
            this.gridColumn6.FieldName = "TenderTypeDisplay";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.OptionsColumn.AllowFocus = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            this.gridColumn6.Width = 177;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.gridColumn4.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridColumn4.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn4.AppearanceHeader.Options.UseFont = true;
            this.gridColumn4.Caption = "KAZANDIK MI?";
            this.gridColumn4.ColumnEdit = this.chYesNo;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Width = 107;
            // 
            // chYesNo
            // 
            this.chYesNo.AutoHeight = false;
            this.chYesNo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.DropDown)});
            this.chYesNo.ForceUpdateEditValue = DevExpress.Utils.DefaultBoolean.True;
            this.chYesNo.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Evet"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Hayır")});
            this.chYesNo.Name = "chYesNo";
            this.chYesNo.SelectAllItemCaption = "";
            this.chYesNo.SelectAllItemVisible = false;
            this.chYesNo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            // 
            // colOpenTender
            // 
            this.colOpenTender.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colOpenTender.AppearanceCell.Options.UseFont = true;
            this.colOpenTender.AppearanceHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.colOpenTender.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colOpenTender.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colOpenTender.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colOpenTender.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.colOpenTender.AppearanceHeader.Options.UseBackColor = true;
            this.colOpenTender.AppearanceHeader.Options.UseFont = true;
            this.colOpenTender.AppearanceHeader.Options.UseForeColor = true;
            this.colOpenTender.ColumnEdit = this.btnIhaleAc;
            this.colOpenTender.MaxWidth = 30;
            this.colOpenTender.MinWidth = 30;
            this.colOpenTender.Name = "colOpenTender";
            this.colOpenTender.OptionsFilter.AllowFilter = false;
            this.colOpenTender.ToolTip = "İhale Aç";
            this.colOpenTender.Visible = true;
            this.colOpenTender.VisibleIndex = 4;
            this.colOpenTender.Width = 30;
            // 
            // btnIhaleAc
            // 
            this.btnIhaleAc.AutoHeight = false;
            this.btnIhaleAc.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnIhaleAc.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, "İhaleyi Aç", null, null, true)});
            this.btnIhaleAc.Name = "btnIhaleAc";
            this.btnIhaleAc.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
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
            this.gridColumn5.VisibleIndex = 5;
            this.gridColumn5.Width = 30;
            // 
            // btnDetay
            // 
            this.btnDetay.AutoHeight = false;
            this.btnDetay.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::IhalematikProUI.Properties.Resources.detail_icon, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject6, "İhale Güncelle", null, null, true)});
            this.btnDetay.Name = "btnDetay";
            this.btnDetay.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // colPasive
            // 
            this.colPasive.AppearanceHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.colPasive.AppearanceHeader.Options.UseBackColor = true;
            this.colPasive.ColumnEdit = this.btnPasive;
            this.colPasive.MaxWidth = 20;
            this.colPasive.Name = "colPasive";
            this.colPasive.Visible = true;
            this.colPasive.VisibleIndex = 6;
            this.colPasive.Width = 20;
            // 
            // btnPasive
            // 
            this.btnPasive.AutoHeight = false;
            this.btnPasive.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::IhalematikProUI.Properties.Resources.PasiveData, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject7, "", null, null, true)});
            this.btnPasive.Name = "btnPasive";
            this.btnPasive.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // colActive
            // 
            this.colActive.AppearanceHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.colActive.AppearanceHeader.Options.UseBackColor = true;
            this.colActive.ColumnEdit = this.btnActive;
            this.colActive.MaxWidth = 20;
            this.colActive.Name = "colActive";
            this.colActive.Visible = true;
            this.colActive.VisibleIndex = 7;
            this.colActive.Width = 20;
            // 
            // btnActive
            // 
            this.btnActive.AutoHeight = false;
            this.btnActive.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::IhalematikProUI.Properties.Resources.activeData, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject8, "", null, null, true)});
            this.btnActive.Name = "btnActive";
            this.btnActive.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.NullText = "Hayır";
            this.repositoryItemLookUpEdit1.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize;
            this.repositoryItemLookUpEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelControl1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
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
            this.panelControl1.Size = new System.Drawing.Size(1300, 35);
            this.panelControl1.TabIndex = 39;
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
            this.lblTenderCaptin.Size = new System.Drawing.Size(368, 35);
            this.lblTenderCaptin.TabIndex = 17;
            this.lblTenderCaptin.Text = "TAŞERE EDİLMİŞ İŞLERİN LİSTESİ";
            this.lblTenderCaptin.UseMnemonic = false;
            // 
            // btnKapat
            // 
            this.btnKapat.AutoSize = true;
            this.btnKapat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKapat.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.Image")));
            this.btnKapat.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnKapat.Location = new System.Drawing.Point(1272, 0);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(4);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(28, 35);
            this.btnKapat.TabIndex = 3;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // frm_TasaronListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnKapat;
            this.ClientSize = new System.Drawing.Size(1300, 617);
            this.ControlBox = false;
            this.Controls.Add(this.grdActiveTenderList);
            this.Controls.Add(this.panelControl1);
            this.Name = "frm_TasaronListesi";
            this.ShowInTaskbar = false;
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.grdActiveTenderList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewActiveTenderList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chYesNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIhaleAc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDetay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPasive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcWorld)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdActiveTenderList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewActiveTenderList;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit chYesNo;
        private DevExpress.XtraGrid.Columns.GridColumn colOpenTender;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnIhaleAc;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDetay;
        private DevExpress.XtraGrid.Columns.GridColumn colPasive;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnPasive;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnActive;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.PictureBox pcWorld;
        private DevExpress.XtraEditors.LabelControl lblTenderCaptin;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
    }
}