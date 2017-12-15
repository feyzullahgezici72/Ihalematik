namespace IhalematikProUI.Forms
{
    partial class frm_Kurallistesi
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Kurallistesi));
            this.grdRules = new DevExpress.XtraGrid.GridControl();
            this.gridViewRules = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnGuncelle = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnSil = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.bindingSourceRules = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdRules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuncelle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRules)).BeginInit();
            this.SuspendLayout();
            // 
            // grdRules
            // 
            this.grdRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdRules.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.grdRules.Location = new System.Drawing.Point(0, 35);
            this.grdRules.MainView = this.gridViewRules;
            this.grdRules.Margin = new System.Windows.Forms.Padding(4);
            this.grdRules.Name = "grdRules";
            this.grdRules.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnGuncelle,
            this.btnSil});
            this.grdRules.Size = new System.Drawing.Size(512, 604);
            this.grdRules.TabIndex = 0;
            this.grdRules.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRules});
            // 
            // gridViewRules
            // 
            this.gridViewRules.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridViewRules.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gridViewRules.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridViewRules.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewRules.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridViewRules.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridViewRules.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridViewRules.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridViewRules.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.gridViewRules.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(215)))));
            this.gridViewRules.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White;
            this.gridViewRules.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gridViewRules.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridViewRules.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridViewRules.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridViewRules.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridViewRules.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gridViewRules.Appearance.Empty.Options.UseBackColor = true;
            this.gridViewRules.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridViewRules.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewRules.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridViewRules.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridViewRules.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridViewRules.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gridViewRules.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridViewRules.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridViewRules.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridViewRules.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridViewRules.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gridViewRules.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gridViewRules.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridViewRules.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridViewRules.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(148)))));
            this.gridViewRules.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridViewRules.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.gridViewRules.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewRules.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewRules.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewRules.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridViewRules.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gridViewRules.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridViewRules.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridViewRules.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridViewRules.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridViewRules.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridViewRules.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridViewRules.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewRules.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridViewRules.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridViewRules.Appearance.GroupButton.Options.UseForeColor = true;
            this.gridViewRules.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridViewRules.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridViewRules.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridViewRules.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridViewRules.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridViewRules.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridViewRules.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gridViewRules.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridViewRules.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewRules.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridViewRules.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridViewRules.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridViewRules.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewRules.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewRules.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridViewRules.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gridViewRules.Appearance.GroupRow.Options.UseFont = true;
            this.gridViewRules.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridViewRules.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridViewRules.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gridViewRules.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gridViewRules.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewRules.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridViewRules.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridViewRules.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridViewRules.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewRules.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.gridViewRules.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gridViewRules.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewRules.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewRules.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.gridViewRules.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridViewRules.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridViewRules.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewRules.Appearance.OddRow.Options.UseBackColor = true;
            this.gridViewRules.Appearance.OddRow.Options.UseForeColor = true;
            this.gridViewRules.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.gridViewRules.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.gridViewRules.Appearance.Preview.Options.UseBackColor = true;
            this.gridViewRules.Appearance.Preview.Options.UseForeColor = true;
            this.gridViewRules.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridViewRules.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridViewRules.Appearance.Row.Options.UseBackColor = true;
            this.gridViewRules.Appearance.Row.Options.UseForeColor = true;
            this.gridViewRules.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gridViewRules.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridViewRules.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(197)))), ((int)(((byte)(205)))));
            this.gridViewRules.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewRules.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridViewRules.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewRules.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.gridViewRules.Appearance.VertLine.Options.UseBackColor = true;
            this.gridViewRules.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn1});
            this.gridViewRules.GridControl = this.grdRules;
            this.gridViewRules.Name = "gridViewRules";
            this.gridViewRules.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewRules.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewRules.OptionsView.ShowGroupPanel = false;
            this.gridViewRules.PaintStyleName = "Flat";
            // 
            // colId
            // 
            this.colId.Caption = "gridColumn8";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
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
            this.gridColumn2.Caption = "KURAL ADI";
            this.gridColumn2.FieldName = "Name";
            this.gridColumn2.MinWidth = 10;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.OptionsColumn.AllowSize = false;
            this.gridColumn2.OptionsFilter.AllowFilter = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 210;
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
            this.gridColumn3.Caption = "KURAL DEĞERİ";
            this.gridColumn3.DisplayFormat.FormatString = "C2";
            this.gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.gridColumn3.FieldName = "Text";
            this.gridColumn3.MinWidth = 10;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowFocus = false;
            this.gridColumn3.OptionsFilter.AllowFilter = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 137;
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
            this.gridColumn1.ColumnEdit = this.btnGuncelle;
            this.gridColumn1.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.gridColumn1.MaxWidth = 30;
            this.gridColumn1.MinWidth = 30;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsFilter.AllowFilter = false;
            this.gridColumn1.ToolTip = "Güncelle";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 30;
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
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
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
            this.panelControl2.Size = new System.Drawing.Size(512, 35);
            this.panelControl2.TabIndex = 96;
            // 
            // btnKapat
            // 
            this.btnKapat.AutoSize = true;
            this.btnKapat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKapat.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.Image")));
            this.btnKapat.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnKapat.Location = new System.Drawing.Point(484, 0);
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
            this.labelControl1.Size = new System.Drawing.Size(164, 35);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "KURAL LİSTESİ";
            this.labelControl1.UseMnemonic = false;
            // 
            // frm_Kurallistesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnKapat;
            this.ClientSize = new System.Drawing.Size(512, 639);
            this.ControlBox = false;
            this.Controls.Add(this.grdRules);
            this.Controls.Add(this.panelControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.LookAndFeel.SkinName = "Money Twins";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Kurallistesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frm_Kurallistesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdRules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuncelle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRules)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdRules;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRules;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnGuncelle;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnSil;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource bindingSourceRules;
    }
}