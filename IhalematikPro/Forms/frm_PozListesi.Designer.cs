namespace IhalematikPro.Forms
{
    partial class frm_PozListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_PozListesi));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pcWorld = new System.Windows.Forms.PictureBox();
            this.btnListele = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pozMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtUnit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescription = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtUnitPrice = new DevExpress.XtraEditors.TextEdit();
            this.txtNumber = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.xpPageSelector1 = new DevExpress.Xpo.XPPageSelector(this.components);
            this.grdPozList = new DevExpress.XtraGrid.GridControl();
            this.gridViewPozList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnGncelle = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSl = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcWorld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pozMenu)).BeginInit();
            this.pozMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPozList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPozList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGncelle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSl)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.CadetBlue;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.ContentImageAlignment = System.Drawing.ContentAlignment.BottomLeft;
            this.panelControl1.Controls.Add(this.panel2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1376, 50);
            this.panelControl1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.pcWorld);
            this.panel2.Controls.Add(this.btnListele);
            this.panel2.Controls.Add(this.btnKapat);
            this.panel2.Controls.Add(this.labelControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1376, 50);
            this.panel2.TabIndex = 1;
            // 
            // pcWorld
            // 
            this.pcWorld.Dock = System.Windows.Forms.DockStyle.Left;
            this.pcWorld.Image = ((System.Drawing.Image)(resources.GetObject("pcWorld.Image")));
            this.pcWorld.Location = new System.Drawing.Point(0, 0);
            this.pcWorld.Name = "pcWorld";
            this.pcWorld.Size = new System.Drawing.Size(70, 50);
            this.pcWorld.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcWorld.TabIndex = 21;
            this.pcWorld.TabStop = false;
            // 
            // btnListele
            // 
            this.btnListele.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListele.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.btnListele.Appearance.Options.UseFont = true;
            this.btnListele.Appearance.Options.UseForeColor = true;
            this.btnListele.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnListele.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnListele.Image = global::IhalematikProUI.Properties.Resources.Inventory_icon__1_;
            this.btnListele.Location = new System.Drawing.Point(1182, 0);
            this.btnListele.Margin = new System.Windows.Forms.Padding(4);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(132, 50);
            this.btnListele.TabIndex = 20;
            this.btnListele.TabStop = false;
            this.btnListele.Text = "Listele";
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKapat.Image = global::IhalematikProUI.Properties.Resources.Actions_dialog_close_icon;
            this.btnKapat.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnKapat.Location = new System.Drawing.Point(1314, 0);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(4);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(62, 50);
            this.btnKapat.TabIndex = 19;
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
            this.labelControl1.Location = new System.Drawing.Point(72, 7);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.ShowLineShadow = false;
            this.labelControl1.Size = new System.Drawing.Size(192, 37);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "POZ LİSTESİ";
            // 
            // pozMenu
            // 
            this.pozMenu.Appearance.BackColor = System.Drawing.Color.PowderBlue;
            this.pozMenu.Appearance.BackColor2 = System.Drawing.Color.White;
            this.pozMenu.Appearance.Options.UseBackColor = true;
            this.pozMenu.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pozMenu.AppearanceCaption.ForeColor = System.Drawing.Color.Maroon;
            this.pozMenu.AppearanceCaption.Options.UseFont = true;
            this.pozMenu.AppearanceCaption.Options.UseForeColor = true;
            this.pozMenu.Controls.Add(this.btnKaydet);
            this.pozMenu.Controls.Add(this.btnTemizle);
            this.pozMenu.Controls.Add(this.labelControl5);
            this.pozMenu.Controls.Add(this.txtUnit);
            this.pozMenu.Controls.Add(this.labelControl4);
            this.pozMenu.Controls.Add(this.txtDescription);
            this.pozMenu.Controls.Add(this.labelControl3);
            this.pozMenu.Controls.Add(this.txtUnitPrice);
            this.pozMenu.Controls.Add(this.txtNumber);
            this.pozMenu.Controls.Add(this.labelControl2);
            this.pozMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pozMenu.Location = new System.Drawing.Point(0, 50);
            this.pozMenu.Margin = new System.Windows.Forms.Padding(4);
            this.pozMenu.Name = "pozMenu";
            this.pozMenu.Size = new System.Drawing.Size(442, 608);
            this.pozMenu.TabIndex = 37;
            this.pozMenu.Text = "Yeni Poz Ekle";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.Appearance.Options.UseForeColor = true;
            this.btnKaydet.Image = global::IhalematikProUI.Properties.Resources.Save_as_icon__1_;
            this.btnKaydet.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnKaydet.Location = new System.Drawing.Point(170, 210);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(124, 50);
            toolTipTitleItem1.Text = "Kaydet";
            superToolTip1.Items.Add(toolTipTitleItem1);
            this.btnKaydet.SuperTip = superToolTip1;
            this.btnKaydet.TabIndex = 26;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.btnTemizle.Appearance.Options.UseFont = true;
            this.btnTemizle.Appearance.Options.UseForeColor = true;
            this.btnTemizle.Image = global::IhalematikProUI.Properties.Resources.Actions_edit_clear_icon;
            this.btnTemizle.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnTemizle.Location = new System.Drawing.Point(303, 210);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(4);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(124, 50);
            toolTipTitleItem2.Text = "Temizle";
            superToolTip2.Items.Add(toolTipTitleItem2);
            this.btnTemizle.SuperTip = superToolTip2;
            this.btnTemizle.TabIndex = 25;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.labelControl5.Location = new System.Drawing.Point(9, 165);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(103, 21);
            this.labelControl5.TabIndex = 14;
            this.labelControl5.Text = "Birim Fiyatı:";
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(114, 123);
            this.txtUnit.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtUnit.Properties.Appearance.Options.UseBackColor = true;
            this.txtUnit.Size = new System.Drawing.Size(314, 26);
            this.txtUnit.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.labelControl4.Location = new System.Drawing.Point(56, 127);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(56, 21);
            this.labelControl4.TabIndex = 18;
            this.labelControl4.Text = "Birimi:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(114, 85);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtDescription.Properties.Appearance.Options.UseBackColor = true;
            this.txtDescription.Size = new System.Drawing.Size(314, 26);
            this.txtDescription.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.labelControl3.Location = new System.Drawing.Point(26, 89);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(83, 21);
            this.labelControl3.TabIndex = 19;
            this.labelControl3.Text = "Açıklama:";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.EditValue = "";
            this.txtUnitPrice.Location = new System.Drawing.Point(114, 161);
            this.txtUnitPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtUnitPrice.Properties.Appearance.Options.UseBackColor = true;
            this.txtUnitPrice.Properties.DisplayFormat.FormatString = "N2";
            this.txtUnitPrice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtUnitPrice.Properties.EditFormat.FormatString = "N2";
            this.txtUnitPrice.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtUnitPrice.Properties.Mask.EditMask = "c2";
            this.txtUnitPrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtUnitPrice.Size = new System.Drawing.Size(314, 26);
            this.txtUnitPrice.TabIndex = 3;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(114, 47);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtNumber.Properties.Appearance.Options.UseBackColor = true;
            this.txtNumber.Size = new System.Drawing.Size(150, 26);
            this.txtNumber.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.labelControl2.Location = new System.Drawing.Point(48, 50);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(66, 21);
            this.labelControl2.TabIndex = 22;
            this.labelControl2.Text = "Poz No:";
            // 
            // grdPozList
            // 
            this.grdPozList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdPozList.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.grdPozList.Location = new System.Drawing.Point(442, 50);
            this.grdPozList.MainView = this.gridViewPozList;
            this.grdPozList.Margin = new System.Windows.Forms.Padding(4);
            this.grdPozList.Name = "grdPozList";
            this.grdPozList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnGncelle,
            this.btnSl});
            this.grdPozList.Size = new System.Drawing.Size(934, 608);
            this.grdPozList.TabIndex = 38;
            this.grdPozList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPozList});
            // 
            // gridViewPozList
            // 
            this.gridViewPozList.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver;
            this.gridViewPozList.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewPozList.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Silver;
            this.gridViewPozList.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray;
            this.gridViewPozList.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridViewPozList.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridViewPozList.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridViewPozList.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewPozList.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gridViewPozList.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gridViewPozList.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue;
            this.gridViewPozList.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridViewPozList.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridViewPozList.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridViewPozList.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.gridViewPozList.Appearance.Empty.Options.UseBackColor = true;
            this.gridViewPozList.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gridViewPozList.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite;
            this.gridViewPozList.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewPozList.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewPozList.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridViewPozList.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridViewPozList.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewPozList.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.gridViewPozList.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewPozList.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewPozList.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewPozList.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridViewPozList.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridViewPozList.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridViewPozList.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(80)))), ((int)(((byte)(135)))));
            this.gridViewPozList.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewPozList.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gridViewPozList.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gridViewPozList.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridViewPozList.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridViewPozList.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.gridViewPozList.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridViewPozList.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.gridViewPozList.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gridViewPozList.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridViewPozList.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridViewPozList.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewPozList.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewPozList.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver;
            this.gridViewPozList.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver;
            this.gridViewPozList.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewPozList.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridViewPozList.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridViewPozList.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridViewPozList.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.gridViewPozList.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.gridViewPozList.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gridViewPozList.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridViewPozList.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridViewPozList.Appearance.GroupButton.Options.UseForeColor = true;
            this.gridViewPozList.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gridViewPozList.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gridViewPozList.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gridViewPozList.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridViewPozList.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridViewPozList.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridViewPozList.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.gridViewPozList.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gridViewPozList.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewPozList.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.gridViewPozList.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewPozList.Appearance.GroupPanel.Options.UseFont = true;
            this.gridViewPozList.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridViewPozList.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray;
            this.gridViewPozList.Appearance.GroupRow.ForeColor = System.Drawing.Color.Silver;
            this.gridViewPozList.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridViewPozList.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridViewPozList.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gridViewPozList.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver;
            this.gridViewPozList.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridViewPozList.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewPozList.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridViewPozList.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridViewPozList.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewPozList.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewPozList.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray;
            this.gridViewPozList.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gridViewPozList.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridViewPozList.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridViewPozList.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver;
            this.gridViewPozList.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridViewPozList.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridViewPozList.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
            this.gridViewPozList.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridViewPozList.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gridViewPozList.Appearance.OddRow.Options.UseBackColor = true;
            this.gridViewPozList.Appearance.OddRow.Options.UseForeColor = true;
            this.gridViewPozList.Appearance.Preview.BackColor = System.Drawing.Color.White;
            this.gridViewPozList.Appearance.Preview.ForeColor = System.Drawing.Color.Navy;
            this.gridViewPozList.Appearance.Preview.Options.UseBackColor = true;
            this.gridViewPozList.Appearance.Preview.Options.UseForeColor = true;
            this.gridViewPozList.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridViewPozList.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridViewPozList.Appearance.Row.Options.UseBackColor = true;
            this.gridViewPozList.Appearance.Row.Options.UseForeColor = true;
            this.gridViewPozList.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gridViewPozList.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.gridViewPozList.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridViewPozList.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gridViewPozList.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridViewPozList.Appearance.VertLine.BackColor = System.Drawing.Color.Silver;
            this.gridViewPozList.Appearance.VertLine.Options.UseBackColor = true;
            this.gridViewPozList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gridViewPozList.GridControl = this.grdPozList;
            this.gridViewPozList.Name = "gridViewPozList";
            this.gridViewPozList.OptionsFind.FindFilterColumns = "";
            this.gridViewPozList.OptionsFind.FindNullPrompt = "Poz No giriniz...";
            this.gridViewPozList.OptionsFind.SearchInPreview = true;
            this.gridViewPozList.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewPozList.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewPozList.OptionsView.ShowFooter = true;
            this.gridViewPozList.OptionsView.ShowGroupPanel = false;
            this.gridViewPozList.PaintStyleName = "Web";
            // 
            // colId
            // 
            this.colId.Caption = "gridColumn7";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.BackColor = System.Drawing.Color.Gray;
            this.gridColumn1.AppearanceHeader.BackColor2 = System.Drawing.Color.White;
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridColumn1.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridColumn1.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridColumn1.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridColumn1.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn1.Caption = "POZ NO";
            this.gridColumn1.FieldName = "Number";
            this.gridColumn1.MinWidth = 80;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 137;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.BackColor = System.Drawing.Color.Gray;
            this.gridColumn2.AppearanceHeader.BackColor2 = System.Drawing.Color.White;
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridColumn2.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridColumn2.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridColumn2.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridColumn2.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn2.Caption = "AÇIKLAMA";
            this.gridColumn2.FieldName = "Description";
            this.gridColumn2.MinWidth = 80;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 515;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceHeader.BackColor = System.Drawing.Color.Gray;
            this.gridColumn3.AppearanceHeader.BackColor2 = System.Drawing.Color.White;
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridColumn3.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridColumn3.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridColumn3.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridColumn3.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            this.gridColumn3.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn3.Caption = "BİRİMİ";
            this.gridColumn3.FieldName = "Unit";
            this.gridColumn3.MinWidth = 80;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowFocus = false;
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 245;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceHeader.BackColor = System.Drawing.Color.Gray;
            this.gridColumn4.AppearanceHeader.BackColor2 = System.Drawing.Color.White;
            this.gridColumn4.AppearanceHeader.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridColumn4.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridColumn4.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridColumn4.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridColumn4.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn4.AppearanceHeader.Options.UseFont = true;
            this.gridColumn4.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn4.Caption = "BİRİM FİYATI";
            this.gridColumn4.DisplayFormat.FormatString = "N2";
            this.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.gridColumn4.FieldName = "UnitPrice";
            this.gridColumn4.MinWidth = 80;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.AllowFocus = false;
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 139;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceHeader.BackColor = System.Drawing.Color.Gray;
            this.gridColumn5.AppearanceHeader.BackColor2 = System.Drawing.Color.White;
            this.gridColumn5.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridColumn5.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridColumn5.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridColumn5.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridColumn5.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn5.AppearanceHeader.Options.UseFont = true;
            this.gridColumn5.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn5.ColumnEdit = this.btnGncelle;
            this.gridColumn5.MaxWidth = 30;
            this.gridColumn5.MinWidth = 30;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 30;
            // 
            // btnGncelle
            // 
            this.btnGncelle.AutoHeight = false;
            this.btnGncelle.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::IhalematikProUI.Properties.Resources.edit_icon, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btnGncelle.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnGncelle.Name = "btnGncelle";
            this.btnGncelle.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnGncelle.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEdit1_ButtonClick);
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceHeader.BackColor = System.Drawing.Color.Gray;
            this.gridColumn6.AppearanceHeader.BackColor2 = System.Drawing.Color.White;
            this.gridColumn6.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gridColumn6.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridColumn6.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridColumn6.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridColumn6.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn6.AppearanceHeader.Options.UseFont = true;
            this.gridColumn6.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn6.ColumnEdit = this.btnSl;
            this.gridColumn6.MaxWidth = 30;
            this.gridColumn6.MinWidth = 30;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 30;
            // 
            // btnSl
            // 
            this.btnSl.AutoHeight = false;
            this.btnSl.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::IhalematikProUI.Properties.Resources.erase_icon, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.btnSl.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnSl.Name = "btnSl";
            this.btnSl.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // frm_PozListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnKapat;
            this.ClientSize = new System.Drawing.Size(1376, 658);
            this.ControlBox = false;
            this.Controls.Add(this.grdPozList);
            this.Controls.Add(this.pozMenu);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_PozListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_PozListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcWorld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pozMenu)).EndInit();
            this.pozMenu.ResumeLayout(false);
            this.pozMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPozList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPozList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGncelle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl pozMenu;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtUnit;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtDescription;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtUnitPrice;
        private DevExpress.XtraEditors.TextEdit txtNumber;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.Xpo.XPPageSelector xpPageSelector1;
        private DevExpress.XtraEditors.SimpleButton btnListele;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private System.Windows.Forms.PictureBox pcWorld;
        private DevExpress.XtraGrid.GridControl grdPozList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPozList;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnGncelle;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnSl;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
    }
}