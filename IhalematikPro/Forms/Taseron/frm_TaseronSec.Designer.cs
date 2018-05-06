namespace IhalematikProUI.Forms.Taseron
{
    partial class frm_TaseronSec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TaseronSec));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grdSupplier = new DevExpress.XtraGrid.GridControl();
            this.gridViewSupplier = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnPasive = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnActive = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnTamam = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPasive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelControl2.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.btnKapat);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(660, 35);
            this.panelControl2.TabIndex = 103;
            // 
            // btnKapat
            // 
            this.btnKapat.AutoSize = true;
            this.btnKapat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKapat.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.Image")));
            this.btnKapat.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnKapat.Location = new System.Drawing.Point(632, 0);
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
            this.labelControl1.Location = new System.Drawing.Point(8, 0);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.ShowLineShadow = false;
            this.labelControl1.Size = new System.Drawing.Size(159, 35);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "TAŞERON SEÇ";
            this.labelControl1.UseMnemonic = false;
            // 
            // grdSupplier
            // 
            this.grdSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdSupplier.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.grdSupplier.Location = new System.Drawing.Point(0, 35);
            this.grdSupplier.MainView = this.gridViewSupplier;
            this.grdSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.grdSupplier.Name = "grdSupplier";
            this.grdSupplier.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEdit,
            this.btnPasive,
            this.btnActive});
            this.grdSupplier.Size = new System.Drawing.Size(660, 526);
            this.grdSupplier.TabIndex = 104;
            this.grdSupplier.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSupplier});
            // 
            // gridViewSupplier
            // 
            this.gridViewSupplier.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver;
            this.gridViewSupplier.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewSupplier.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Silver;
            this.gridViewSupplier.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray;
            this.gridViewSupplier.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridViewSupplier.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridViewSupplier.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridViewSupplier.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewSupplier.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gridViewSupplier.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewSupplier.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue;
            this.gridViewSupplier.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridViewSupplier.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridViewSupplier.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridViewSupplier.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gridViewSupplier.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite;
            this.gridViewSupplier.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewSupplier.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewSupplier.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridViewSupplier.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridViewSupplier.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewSupplier.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.gridViewSupplier.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewSupplier.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewSupplier.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewSupplier.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridViewSupplier.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridViewSupplier.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridViewSupplier.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(80)))), ((int)(((byte)(135)))));
            this.gridViewSupplier.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewSupplier.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gridViewSupplier.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewSupplier.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridViewSupplier.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridViewSupplier.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.gridViewSupplier.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridViewSupplier.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.gridViewSupplier.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gridViewSupplier.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridViewSupplier.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridViewSupplier.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewSupplier.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewSupplier.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver;
            this.gridViewSupplier.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver;
            this.gridViewSupplier.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewSupplier.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridViewSupplier.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridViewSupplier.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewSupplier.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.gridViewSupplier.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.gridViewSupplier.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewSupplier.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridViewSupplier.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridViewSupplier.Appearance.GroupButton.Options.UseForeColor = true;
            this.gridViewSupplier.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gridViewSupplier.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gridViewSupplier.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridViewSupplier.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridViewSupplier.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridViewSupplier.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridViewSupplier.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.gridViewSupplier.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gridViewSupplier.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewSupplier.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.gridViewSupplier.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewSupplier.Appearance.GroupPanel.Options.UseFont = true;
            this.gridViewSupplier.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridViewSupplier.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray;
            this.gridViewSupplier.Appearance.GroupRow.ForeColor = System.Drawing.Color.Silver;
            this.gridViewSupplier.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridViewSupplier.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridViewSupplier.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gridViewSupplier.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver;
            this.gridViewSupplier.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewSupplier.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewSupplier.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridViewSupplier.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridViewSupplier.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewSupplier.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewSupplier.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray;
            this.gridViewSupplier.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewSupplier.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewSupplier.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewSupplier.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver;
            this.gridViewSupplier.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridViewSupplier.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridViewSupplier.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
            this.gridViewSupplier.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewSupplier.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gridViewSupplier.Appearance.OddRow.Options.UseBackColor = true;
            this.gridViewSupplier.Appearance.OddRow.Options.UseForeColor = true;
            this.gridViewSupplier.Appearance.Preview.BackColor = System.Drawing.Color.White;
            this.gridViewSupplier.Appearance.Preview.ForeColor = System.Drawing.Color.Navy;
            this.gridViewSupplier.Appearance.Preview.Options.UseBackColor = true;
            this.gridViewSupplier.Appearance.Preview.Options.UseForeColor = true;
            this.gridViewSupplier.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridViewSupplier.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridViewSupplier.Appearance.Row.Options.UseBackColor = true;
            this.gridViewSupplier.Appearance.Row.Options.UseForeColor = true;
            this.gridViewSupplier.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gridViewSupplier.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.gridViewSupplier.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridViewSupplier.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewSupplier.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewSupplier.Appearance.VertLine.BackColor = System.Drawing.Color.Silver;
            this.gridViewSupplier.Appearance.VertLine.Options.UseBackColor = true;
            this.gridViewSupplier.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCompanyName,
            this.gridColumn6,
            this.gridColumn1});
            this.gridViewSupplier.GridControl = this.grdSupplier;
            this.gridViewSupplier.Name = "gridViewSupplier";
            this.gridViewSupplier.OptionsMenu.EnableColumnMenu = false;
            this.gridViewSupplier.OptionsMenu.EnableFooterMenu = false;
            this.gridViewSupplier.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridViewSupplier.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewSupplier.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewSupplier.OptionsView.ShowDetailButtons = false;
            this.gridViewSupplier.OptionsView.ShowGroupPanel = false;
            this.gridViewSupplier.PaintStyleName = "Web";
            // 
            // colCompanyName
            // 
            this.colCompanyName.AppearanceHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.colCompanyName.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colCompanyName.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colCompanyName.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colCompanyName.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.colCompanyName.AppearanceHeader.Options.UseBackColor = true;
            this.colCompanyName.AppearanceHeader.Options.UseFont = true;
            this.colCompanyName.AppearanceHeader.Options.UseForeColor = true;
            this.colCompanyName.Caption = "FİRMA ADI";
            this.colCompanyName.FieldName = "CompanyName";
            this.colCompanyName.MinWidth = 80;
            this.colCompanyName.Name = "colCompanyName";
            this.colCompanyName.OptionsColumn.AllowEdit = false;
            this.colCompanyName.OptionsColumn.AllowFocus = false;
            this.colCompanyName.OptionsColumn.ReadOnly = true;
            this.colCompanyName.OptionsFilter.AllowFilter = false;
            this.colCompanyName.Visible = true;
            this.colCompanyName.VisibleIndex = 0;
            this.colCompanyName.Width = 171;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.gridColumn6.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridColumn6.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridColumn6.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridColumn6.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridColumn6.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn6.AppearanceHeader.Options.UseFont = true;
            this.gridColumn6.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn6.Caption = "ŞEHİR";
            this.gridColumn6.FieldName = "Country";
            this.gridColumn6.MinWidth = 80;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.OptionsColumn.AllowFocus = false;
            this.gridColumn6.OptionsColumn.ReadOnly = true;
            this.gridColumn6.OptionsFilter.AllowFilter = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            this.gridColumn6.Width = 113;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridColumn1.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.Caption = "PUAN";
            this.gridColumn1.FieldName = "Score";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            // 
            // btnEdit
            // 
            this.btnEdit.AutoHeight = false;
            this.btnEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnEdit.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "Güncelle", null, null, true)});
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // btnPasive
            // 
            this.btnPasive.AutoHeight = false;
            this.btnPasive.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnPasive.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::IhalematikProUI.Properties.Resources.PasiveData, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "Pasif Yap", null, null, true)});
            this.btnPasive.Name = "btnPasive";
            this.btnPasive.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // btnActive
            // 
            this.btnActive.AutoHeight = false;
            this.btnActive.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnActive.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::IhalematikProUI.Properties.Resources.activeData, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "Aktif Yap", null, null, true)});
            this.btnActive.Name = "btnActive";
            this.btnActive.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnTamam);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 561);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(660, 72);
            this.panelControl1.TabIndex = 105;
            // 
            // btnTamam
            // 
            this.btnTamam.Appearance.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTamam.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.btnTamam.Appearance.Options.UseFont = true;
            this.btnTamam.Appearance.Options.UseForeColor = true;
            this.btnTamam.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTamam.Image = ((System.Drawing.Image)(resources.GetObject("btnTamam.Image")));
            this.btnTamam.Location = new System.Drawing.Point(523, 7);
            this.btnTamam.Margin = new System.Windows.Forms.Padding(4);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(130, 56);
            this.btnTamam.TabIndex = 10;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // frm_TaseronSec
            // 
            this.AcceptButton = this.btnTamam;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 633);
            this.ControlBox = false;
            this.Controls.Add(this.grdSupplier);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_TaseronSec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPasive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl grdSupplier;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSupplier;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnPasive;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnActive;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnTamam;
    }
}