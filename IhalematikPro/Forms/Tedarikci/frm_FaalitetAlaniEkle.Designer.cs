namespace IhalematikProUI.Forms
{
    partial class frm_FaalitetAlaniEkle
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_FaalitetAlaniEkle));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtUnvan = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.grdTenderGroup = new DevExpress.XtraGrid.GridControl();
            this.gridViewTenderGroup = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnGuncelle = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtUnvan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTenderGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTenderGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuncelle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            // 
            // txtUnvan
            // 
            this.txtUnvan.EnterMoveNextControl = true;
            this.dxErrorProvider1.SetIconAlignment(this.txtUnvan, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.txtUnvan.Location = new System.Drawing.Point(123, 50);
            this.txtUnvan.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnvan.Name = "txtUnvan";
            this.txtUnvan.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtUnvan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUnvan.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtUnvan.Properties.Appearance.Options.UseBackColor = true;
            this.txtUnvan.Properties.Appearance.Options.UseFont = true;
            this.txtUnvan.Properties.Appearance.Options.UseForeColor = true;
            this.txtUnvan.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtUnvan.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtUnvan.Size = new System.Drawing.Size(516, 26);
            this.txtUnvan.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Location = new System.Drawing.Point(15, 54);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(100, 19);
            this.labelControl2.TabIndex = 97;
            this.labelControl2.Text = "Faaliyet Alanı:";
            // 
            // groupControl2
            // 
            this.groupControl2.Appearance.BackColor = System.Drawing.Color.White;
            this.groupControl2.Appearance.Options.UseBackColor = true;
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.Navy;
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl2.Controls.Add(this.grdTenderGroup);
            this.groupControl2.Controls.Add(this.btnSave);
            this.groupControl2.Controls.Add(this.txtUnvan);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 35);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(674, 550);
            this.groupControl2.TabIndex = 36;
            this.groupControl2.Text = "Faaliyet Bilgileri";
            // 
            // grdTenderGroup
            // 
            this.grdTenderGroup.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            gridLevelNode1.RelationName = "Level1";
            this.grdTenderGroup.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.grdTenderGroup.Location = new System.Drawing.Point(6, 153);
            this.grdTenderGroup.MainView = this.gridViewTenderGroup;
            this.grdTenderGroup.Margin = new System.Windows.Forms.Padding(4);
            this.grdTenderGroup.Name = "grdTenderGroup";
            this.grdTenderGroup.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnGuncelle});
            this.grdTenderGroup.Size = new System.Drawing.Size(668, 390);
            this.grdTenderGroup.TabIndex = 99;
            this.grdTenderGroup.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTenderGroup});
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
            this.gridViewTenderGroup.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
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
            this.colId,
            this.gridColumn2,
            this.gridColumn6});
            this.gridViewTenderGroup.GridControl = this.grdTenderGroup;
            this.gridViewTenderGroup.Name = "gridViewTenderGroup";
            this.gridViewTenderGroup.OptionsMenu.EnableColumnMenu = false;
            this.gridViewTenderGroup.OptionsMenu.EnableFooterMenu = false;
            this.gridViewTenderGroup.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewTenderGroup.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewTenderGroup.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewTenderGroup.OptionsView.ShowGroupPanel = false;
            this.gridViewTenderGroup.PaintStyleName = "Flat";
            // 
            // colId
            // 
            this.colId.Caption = "gridColumn7";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridColumn2.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridColumn2.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn2.AppearanceHeader.Options.UseBorderColor = true;
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.Caption = "FAALİYET ALANI";
            this.gridColumn2.FieldName = "Description";
            this.gridColumn2.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Value;
            this.gridColumn2.MinWidth = 80;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.OptionsFilter.AllowFilter = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 429;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.gridColumn6.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridColumn6.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridColumn6.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn6.AppearanceHeader.Options.UseFont = true;
            this.gridColumn6.ColumnEdit = this.btnGuncelle;
            this.gridColumn6.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.gridColumn6.MaxWidth = 30;
            this.gridColumn6.MinWidth = 30;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsFilter.AllowFilter = false;
            this.gridColumn6.ToolTip = "Sil";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            this.gridColumn6.Width = 30;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.AutoHeight = false;
            this.btnGuncelle.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::IhalematikProUI.Properties.Resources.edit_icon, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btnGuncelle.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnGuncelle.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnGuncelle_ButtonClick);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Appearance.Options.UseForeColor = true;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnSave.Location = new System.Drawing.Point(511, 84);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 61);
            this.btnSave.TabIndex = 93;
            this.btnSave.Text = "Kaydet";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.AutoSize = true;
            this.btnKapat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKapat.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.Image")));
            this.btnKapat.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnKapat.Location = new System.Drawing.Point(646, 0);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(4);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(28, 35);
            this.btnKapat.TabIndex = 1;
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
            this.panelControl1.Size = new System.Drawing.Size(674, 35);
            this.panelControl1.TabIndex = 35;
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.btnKapat);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(674, 35);
            this.panelControl2.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl1.LineColor = System.Drawing.Color.Red;
            this.labelControl1.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.labelControl1.Location = new System.Drawing.Point(6, 0);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.ShowLineShadow = false;
            this.labelControl1.Size = new System.Drawing.Size(247, 35);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "FAALİYET ALANI EKLE";
            this.labelControl1.UseMnemonic = false;
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // frm_FaalitetAlaniEkle
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnKapat;
            this.ClientSize = new System.Drawing.Size(674, 585);
            this.ControlBox = false;
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.LookAndFeel.SkinName = "London Liquid Sky";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_FaalitetAlaniEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.txtUnvan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTenderGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTenderGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuncelle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.TextEdit txtUnvan;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private DevExpress.XtraGrid.GridControl grdTenderGroup;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTenderGroup;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnGuncelle;
    }
}