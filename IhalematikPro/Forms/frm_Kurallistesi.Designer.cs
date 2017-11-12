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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.grdWorker = new DevExpress.XtraGrid.GridControl();
            this.gridViewWorker = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnGuncelle = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnSil = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grdWorker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewWorker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuncelle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdWorker
            // 
            this.grdWorker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdWorker.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.grdWorker.Location = new System.Drawing.Point(0, 54);
            this.grdWorker.MainView = this.gridViewWorker;
            this.grdWorker.Margin = new System.Windows.Forms.Padding(4);
            this.grdWorker.Name = "grdWorker";
            this.grdWorker.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnGuncelle,
            this.btnSil});
            this.grdWorker.Size = new System.Drawing.Size(512, 584);
            this.grdWorker.TabIndex = 34;
            this.grdWorker.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewWorker});
            // 
            // gridViewWorker
            // 
            this.gridViewWorker.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver;
            this.gridViewWorker.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewWorker.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Silver;
            this.gridViewWorker.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray;
            this.gridViewWorker.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridViewWorker.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridViewWorker.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridViewWorker.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewWorker.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gridViewWorker.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewWorker.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue;
            this.gridViewWorker.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridViewWorker.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridViewWorker.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridViewWorker.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.gridViewWorker.Appearance.Empty.Options.UseBackColor = true;
            this.gridViewWorker.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gridViewWorker.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite;
            this.gridViewWorker.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewWorker.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewWorker.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridViewWorker.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridViewWorker.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewWorker.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.gridViewWorker.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewWorker.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewWorker.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewWorker.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridViewWorker.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridViewWorker.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridViewWorker.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(80)))), ((int)(((byte)(135)))));
            this.gridViewWorker.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewWorker.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gridViewWorker.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewWorker.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridViewWorker.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridViewWorker.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.gridViewWorker.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridViewWorker.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.gridViewWorker.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gridViewWorker.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridViewWorker.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridViewWorker.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewWorker.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewWorker.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver;
            this.gridViewWorker.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver;
            this.gridViewWorker.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewWorker.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridViewWorker.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridViewWorker.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewWorker.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.gridViewWorker.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.gridViewWorker.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewWorker.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridViewWorker.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridViewWorker.Appearance.GroupButton.Options.UseForeColor = true;
            this.gridViewWorker.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gridViewWorker.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gridViewWorker.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridViewWorker.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridViewWorker.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridViewWorker.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridViewWorker.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.gridViewWorker.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gridViewWorker.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewWorker.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.gridViewWorker.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewWorker.Appearance.GroupPanel.Options.UseFont = true;
            this.gridViewWorker.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridViewWorker.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray;
            this.gridViewWorker.Appearance.GroupRow.ForeColor = System.Drawing.Color.Silver;
            this.gridViewWorker.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridViewWorker.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridViewWorker.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gridViewWorker.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver;
            this.gridViewWorker.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewWorker.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewWorker.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridViewWorker.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridViewWorker.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewWorker.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewWorker.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray;
            this.gridViewWorker.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewWorker.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewWorker.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewWorker.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver;
            this.gridViewWorker.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridViewWorker.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridViewWorker.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
            this.gridViewWorker.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewWorker.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gridViewWorker.Appearance.OddRow.Options.UseBackColor = true;
            this.gridViewWorker.Appearance.OddRow.Options.UseForeColor = true;
            this.gridViewWorker.Appearance.Preview.BackColor = System.Drawing.Color.White;
            this.gridViewWorker.Appearance.Preview.ForeColor = System.Drawing.Color.Navy;
            this.gridViewWorker.Appearance.Preview.Options.UseBackColor = true;
            this.gridViewWorker.Appearance.Preview.Options.UseForeColor = true;
            this.gridViewWorker.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridViewWorker.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridViewWorker.Appearance.Row.Options.UseBackColor = true;
            this.gridViewWorker.Appearance.Row.Options.UseForeColor = true;
            this.gridViewWorker.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gridViewWorker.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.gridViewWorker.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridViewWorker.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewWorker.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewWorker.Appearance.VertLine.BackColor = System.Drawing.Color.Silver;
            this.gridViewWorker.Appearance.VertLine.Options.UseBackColor = true;
            this.gridViewWorker.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn1});
            this.gridViewWorker.GridControl = this.grdWorker;
            this.gridViewWorker.Name = "gridViewWorker";
            this.gridViewWorker.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewWorker.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewWorker.OptionsView.ShowGroupPanel = false;
            this.gridViewWorker.PaintStyleName = "Web";
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
            this.gridColumn2.FieldName = "Title.Name";
            this.gridColumn2.MinWidth = 10;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.OptionsColumn.AllowSize = false;
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
            this.gridColumn3.FieldName = "TotalFare.Amount";
            this.gridColumn3.MinWidth = 10;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowFocus = false;
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
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.SteelBlue;
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.btnKapat);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(512, 54);
            this.panelControl2.TabIndex = 96;
            // 
            // btnKapat
            // 
            this.btnKapat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKapat.Image = global::IhalematikProUI.Properties.Resources.Actions_dialog_close_icon;
            this.btnKapat.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnKapat.Location = new System.Drawing.Point(448, 0);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(4);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(64, 54);
            this.btnKapat.TabIndex = 21;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl1.LineColor = System.Drawing.Color.Red;
            this.labelControl1.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.labelControl1.Location = new System.Drawing.Point(10, 9);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.ShowLineShadow = false;
            this.labelControl1.Size = new System.Drawing.Size(238, 37);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "KURAL LİSTESİ";
            this.labelControl1.UseMnemonic = false;
            // 
            // frm_Kurallistesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnKapat;
            this.ClientSize = new System.Drawing.Size(512, 638);
            this.ControlBox = false;
            this.Controls.Add(this.grdWorker);
            this.Controls.Add(this.panelControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Kurallistesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.grdWorker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewWorker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuncelle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdWorker;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewWorker;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnGuncelle;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnSil;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}