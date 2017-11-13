namespace IhalematikProUI.Forms
{
    partial class frm_IhaleGrup
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnIptal = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.grdVehicle = new DevExpress.XtraGrid.GridControl();
            this.gridViewVehicle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnGuncelle = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSil = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.txtAciklama = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtTeklifNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVehicle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVehicle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuncelle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTeklifNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.SteelBlue;
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.btnIptal);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(839, 54);
            this.panelControl2.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl3.LineColor = System.Drawing.Color.Red;
            this.labelControl3.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.labelControl3.Location = new System.Drawing.Point(4, 10);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.ShowLineShadow = false;
            this.labelControl3.Size = new System.Drawing.Size(154, 37);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "GRUPLAR";
            this.labelControl3.UseMnemonic = false;
            // 
            // btnIptal
            // 
            this.btnIptal.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.Appearance.Options.UseFont = true;
            this.btnIptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnIptal.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnIptal.Image = global::IhalematikProUI.Properties.Resources.Actions_dialog_close_icon;
            this.btnIptal.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnIptal.Location = new System.Drawing.Point(782, 0);
            this.btnIptal.Margin = new System.Windows.Forms.Padding(4);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(57, 54);
            this.btnIptal.TabIndex = 1;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Controls.Add(this.btnEkle);
            this.groupControl1.Controls.Add(this.textEdit1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 199);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(839, 77);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Grup Adı";
            // 
            // btnEkle
            // 
            this.btnEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Appearance.Options.UseFont = true;
            this.btnEkle.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEkle.Image = global::IhalematikProUI.Properties.Resources.Button_Add_icon__1_;
            this.btnEkle.Location = new System.Drawing.Point(708, 33);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(128, 41);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            // 
            // textEdit1
            // 
            this.textEdit1.EnterMoveNextControl = true;
            this.textEdit1.Location = new System.Drawing.Point(6, 41);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(682, 26);
            this.textEdit1.TabIndex = 0;
            // 
            // grdVehicle
            // 
            this.grdVehicle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdVehicle.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            gridLevelNode1.RelationName = "Level1";
            this.grdVehicle.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.grdVehicle.Location = new System.Drawing.Point(0, 276);
            this.grdVehicle.MainView = this.gridViewVehicle;
            this.grdVehicle.Margin = new System.Windows.Forms.Padding(4);
            this.grdVehicle.Name = "grdVehicle";
            this.grdVehicle.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnGuncelle,
            this.btnSil});
            this.grdVehicle.Size = new System.Drawing.Size(839, 430);
            this.grdVehicle.TabIndex = 39;
            this.grdVehicle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewVehicle});
            // 
            // gridViewVehicle
            // 
            this.gridViewVehicle.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver;
            this.gridViewVehicle.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewVehicle.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Silver;
            this.gridViewVehicle.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray;
            this.gridViewVehicle.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridViewVehicle.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridViewVehicle.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridViewVehicle.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewVehicle.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gridViewVehicle.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewVehicle.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue;
            this.gridViewVehicle.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridViewVehicle.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridViewVehicle.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridViewVehicle.Appearance.Empty.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gridViewVehicle.Appearance.Empty.Options.UseBackColor = true;
            this.gridViewVehicle.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gridViewVehicle.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite;
            this.gridViewVehicle.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewVehicle.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewVehicle.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridViewVehicle.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridViewVehicle.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewVehicle.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.gridViewVehicle.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewVehicle.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewVehicle.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewVehicle.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridViewVehicle.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridViewVehicle.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridViewVehicle.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(80)))), ((int)(((byte)(135)))));
            this.gridViewVehicle.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewVehicle.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gridViewVehicle.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewVehicle.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridViewVehicle.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridViewVehicle.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.gridViewVehicle.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridViewVehicle.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.gridViewVehicle.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gridViewVehicle.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridViewVehicle.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridViewVehicle.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewVehicle.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewVehicle.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver;
            this.gridViewVehicle.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver;
            this.gridViewVehicle.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewVehicle.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridViewVehicle.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridViewVehicle.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewVehicle.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.gridViewVehicle.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.gridViewVehicle.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewVehicle.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridViewVehicle.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridViewVehicle.Appearance.GroupButton.Options.UseForeColor = true;
            this.gridViewVehicle.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gridViewVehicle.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gridViewVehicle.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridViewVehicle.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridViewVehicle.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridViewVehicle.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridViewVehicle.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.gridViewVehicle.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gridViewVehicle.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewVehicle.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.gridViewVehicle.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewVehicle.Appearance.GroupPanel.Options.UseFont = true;
            this.gridViewVehicle.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridViewVehicle.Appearance.GroupRow.ForeColor = System.Drawing.Color.Silver;
            this.gridViewVehicle.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridViewVehicle.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.gridViewVehicle.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewVehicle.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewVehicle.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridViewVehicle.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewVehicle.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewVehicle.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray;
            this.gridViewVehicle.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewVehicle.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewVehicle.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewVehicle.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver;
            this.gridViewVehicle.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridViewVehicle.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridViewVehicle.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
            this.gridViewVehicle.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewVehicle.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gridViewVehicle.Appearance.OddRow.Options.UseBackColor = true;
            this.gridViewVehicle.Appearance.OddRow.Options.UseForeColor = true;
            this.gridViewVehicle.Appearance.Preview.BackColor = System.Drawing.Color.White;
            this.gridViewVehicle.Appearance.Preview.ForeColor = System.Drawing.Color.Navy;
            this.gridViewVehicle.Appearance.Preview.Options.UseBackColor = true;
            this.gridViewVehicle.Appearance.Preview.Options.UseForeColor = true;
            this.gridViewVehicle.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridViewVehicle.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridViewVehicle.Appearance.Row.Options.UseBackColor = true;
            this.gridViewVehicle.Appearance.Row.Options.UseForeColor = true;
            this.gridViewVehicle.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gridViewVehicle.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.gridViewVehicle.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridViewVehicle.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewVehicle.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewVehicle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.gridColumn7,
            this.gridColumn2,
            this.gridColumn1,
            this.gridColumn6});
            this.gridViewVehicle.GridControl = this.grdVehicle;
            this.gridViewVehicle.Name = "gridViewVehicle";
            this.gridViewVehicle.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewVehicle.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewVehicle.OptionsView.ShowGroupPanel = false;
            this.gridViewVehicle.PaintStyleName = "Web";
            // 
            // colId
            // 
            this.colId.Caption = "gridColumn7";
            this.colId.Name = "colId";
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "NO";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridColumn2.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridColumn2.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn2.AppearanceHeader.Options.UseBorderColor = true;
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.Caption = "GRUP ADI";
            this.gridColumn2.FieldName = "Title.Name";
            this.gridColumn2.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Value;
            this.gridColumn2.MinWidth = 80;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 429;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridColumn1.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridColumn1.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.ColumnEdit = this.btnGuncelle;
            this.gridColumn1.MaxWidth = 30;
            this.gridColumn1.MinWidth = 30;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 30;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.AutoHeight = false;
            this.btnGuncelle.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.TopCenter, global::IhalematikProUI.Properties.Resources.edit_icon, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btnGuncelle.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnGuncelle.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnGuncelle_ButtonClick);
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.gridColumn6.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridColumn6.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridColumn6.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn6.AppearanceHeader.Options.UseFont = true;
            this.gridColumn6.ColumnEdit = this.btnSil;
            this.gridColumn6.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.gridColumn6.MaxWidth = 30;
            this.gridColumn6.MinWidth = 30;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
            this.gridColumn6.Width = 30;
            // 
            // btnSil
            // 
            this.btnSil.AutoHeight = false;
            this.btnSil.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::IhalematikProUI.Properties.Resources.erase_icon, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.btnSil.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnSil.Name = "btnSil";
            this.btnSil.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl2.Controls.Add(this.textEdit2);
            this.groupControl2.Controls.Add(this.txtAciklama);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.txtTeklifNo);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Enabled = false;
            this.groupControl2.Location = new System.Drawing.Point(0, 54);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(839, 145);
            this.groupControl2.TabIndex = 40;
            this.groupControl2.Text = "İhale Bilgisi";
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(113, 102);
            this.textEdit2.Margin = new System.Windows.Forms.Padding(4);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.textEdit2.Properties.Appearance.Options.UseFont = true;
            this.textEdit2.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.textEdit2.Size = new System.Drawing.Size(719, 28);
            this.textEdit2.TabIndex = 13;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(113, 68);
            this.txtAciklama.Margin = new System.Windows.Forms.Padding(4);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAciklama.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtAciklama.Properties.Appearance.Options.UseFont = true;
            this.txtAciklama.Properties.Appearance.Options.UseForeColor = true;
            this.txtAciklama.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtAciklama.Size = new System.Drawing.Size(719, 28);
            this.txtAciklama.TabIndex = 12;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl4.Location = new System.Drawing.Point(23, 111);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(82, 19);
            this.labelControl4.TabIndex = 14;
            this.labelControl4.Text = "Kurum Adı:";
            // 
            // txtTeklifNo
            // 
            this.txtTeklifNo.Enabled = false;
            this.txtTeklifNo.Location = new System.Drawing.Point(113, 34);
            this.txtTeklifNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTeklifNo.Name = "txtTeklifNo";
            this.txtTeklifNo.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTeklifNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtTeklifNo.Properties.Appearance.Options.UseFont = true;
            this.txtTeklifNo.Properties.Appearance.Options.UseForeColor = true;
            this.txtTeklifNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtTeklifNo.Properties.Mask.BeepOnError = true;
            this.txtTeklifNo.Size = new System.Drawing.Size(188, 28);
            this.txtTeklifNo.TabIndex = 11;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Location = new System.Drawing.Point(35, 75);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 19);
            this.labelControl2.TabIndex = 15;
            this.labelControl2.Text = "İhale Adı:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.Location = new System.Drawing.Point(39, 39);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(66, 19);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "İhale No:";
            // 
            // frm_IhaleGrup
            // 
            this.AcceptButton = this.btnEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnIptal;
            this.ClientSize = new System.Drawing.Size(839, 706);
            this.ControlBox = false;
            this.Controls.Add(this.grdVehicle);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.panelControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_IhaleGrup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVehicle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVehicle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuncelle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTeklifNo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnIptal;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraGrid.GridControl grdVehicle;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewVehicle;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnGuncelle;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnSil;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit txtAciklama;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtTeklifNo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}