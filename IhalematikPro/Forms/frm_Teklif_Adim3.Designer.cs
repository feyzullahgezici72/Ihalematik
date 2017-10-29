namespace IhalematikPro.Forms
{
    partial class frm_Teklif_Adim3
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
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtWorkerMarkup = new System.Windows.Forms.MaskedTextBox();
            this.btnTumuneUygula = new DevExpress.XtraEditors.SimpleButton();
            this.lblTenderNumber = new DevExpress.XtraEditors.LabelControl();
            this.lblTenderDescription = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.txtAdimAciklama = new DevExpress.XtraEditors.LabelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtBaseAmount = new DevExpress.XtraEditors.TextEdit();
            this.grdMaterialListIsWorkship = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtTotalAmount = new DevExpress.XtraEditors.TextEdit();
            this.txtMarkupAmount = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaseAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMaterialListIsWorkship)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarkupAmount.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.simpleButton1);
            this.panelControl2.Controls.Add(this.groupBox1);
            this.panelControl2.Controls.Add(this.lblTenderNumber);
            this.panelControl2.Controls.Add(this.lblTenderDescription);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 44);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(917, 55);
            this.panelControl2.TabIndex = 22;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(493, 17);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(265, 32);
            this.simpleButton1.TabIndex = 39;
            this.simpleButton1.Text = "Satır Üzerinde enter yada duble click olursa";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtWorkerMarkup);
            this.groupBox1.Controls.Add(this.btnTumuneUygula);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox1.Location = new System.Drawing.Point(804, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(113, 55);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kar % \'si";
            // 
            // txtWorkerMarkup
            // 
            this.txtWorkerMarkup.Location = new System.Drawing.Point(5, 22);
            this.txtWorkerMarkup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtWorkerMarkup.Mask = "##%";
            this.txtWorkerMarkup.Name = "txtWorkerMarkup";
            this.txtWorkerMarkup.Size = new System.Drawing.Size(45, 21);
            this.txtWorkerMarkup.TabIndex = 41;
            this.txtWorkerMarkup.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnTumuneUygula
            // 
            this.btnTumuneUygula.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTumuneUygula.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.btnTumuneUygula.Appearance.Options.UseFont = true;
            this.btnTumuneUygula.Appearance.Options.UseForeColor = true;
            this.btnTumuneUygula.AutoSize = true;
            this.btnTumuneUygula.Image = global::IhalematikProUI.Properties.Resources.ok_icon__1_1;
            this.btnTumuneUygula.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnTumuneUygula.Location = new System.Drawing.Point(56, 15);
            this.btnTumuneUygula.Name = "btnTumuneUygula";
            this.btnTumuneUygula.Size = new System.Drawing.Size(42, 38);
            this.btnTumuneUygula.TabIndex = 34;
            this.btnTumuneUygula.Click += new System.EventHandler(this.btnTumuneUygula_Click);
            // 
            // lblTenderNumber
            // 
            this.lblTenderNumber.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTenderNumber.Appearance.ForeColor = System.Drawing.Color.Crimson;
            this.lblTenderNumber.Location = new System.Drawing.Point(108, 6);
            this.lblTenderNumber.Name = "lblTenderNumber";
            this.lblTenderNumber.Size = new System.Drawing.Size(0, 19);
            this.lblTenderNumber.TabIndex = 37;
            // 
            // lblTenderDescription
            // 
            this.lblTenderDescription.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTenderDescription.Appearance.ForeColor = System.Drawing.Color.Crimson;
            this.lblTenderDescription.Location = new System.Drawing.Point(108, 30);
            this.lblTenderDescription.Name = "lblTenderDescription";
            this.lblTenderDescription.Size = new System.Drawing.Size(0, 19);
            this.lblTenderDescription.TabIndex = 36;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.labelControl1.Location = new System.Drawing.Point(12, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(79, 19);
            this.labelControl1.TabIndex = 35;
            this.labelControl1.Text = "Açıklama :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.labelControl4.Location = new System.Drawing.Point(12, 6);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(76, 19);
            this.labelControl4.TabIndex = 35;
            this.labelControl4.Text = "İhale No  :";
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.CadetBlue;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.ContentImageAlignment = System.Drawing.ContentAlignment.BottomLeft;
            this.panelControl1.Controls.Add(this.btnKapat);
            this.panelControl1.Controls.Add(this.txtAdimAciklama);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(917, 44);
            this.panelControl1.TabIndex = 21;
            // 
            // btnKapat
            // 
            this.btnKapat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKapat.Image = global::IhalematikProUI.Properties.Resources.Actions_dialog_close_icon;
            this.btnKapat.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnKapat.Location = new System.Drawing.Point(874, 0);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(43, 44);
            this.btnKapat.TabIndex = 3;
            this.btnKapat.TabStop = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // txtAdimAciklama
            // 
            this.txtAdimAciklama.Appearance.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdimAciklama.Appearance.ForeColor = System.Drawing.Color.AliceBlue;
            this.txtAdimAciklama.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.txtAdimAciklama.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtAdimAciklama.LineColor = System.Drawing.Color.Red;
            this.txtAdimAciklama.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.txtAdimAciklama.Location = new System.Drawing.Point(7, 9);
            this.txtAdimAciklama.Name = "txtAdimAciklama";
            this.txtAdimAciklama.ShowLineShadow = false;
            this.txtAdimAciklama.Size = new System.Drawing.Size(301, 32);
            this.txtAdimAciklama.TabIndex = 0;
            this.txtAdimAciklama.Text = "İŞÇİLİK KEŞİF LİSTESİ";
            // 
            // panelControl3
            // 
            this.panelControl3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl3.Appearance.Options.UseBackColor = true;
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl3.Controls.Add(this.panel2);
            this.panelControl3.Controls.Add(this.panel6);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(0, 451);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(917, 81);
            this.panelControl3.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnKaydet);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(579, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(93, 81);
            this.panel2.TabIndex = 10;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.Appearance.Options.UseForeColor = true;
            this.btnKaydet.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnKaydet.Image = global::IhalematikProUI.Properties.Resources.Save_as_icon__1_;
            this.btnKaydet.Location = new System.Drawing.Point(0, 0);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(91, 81);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtTotalAmount);
            this.panel6.Controls.Add(this.labelControl7);
            this.panel6.Controls.Add(this.labelControl6);
            this.panel6.Controls.Add(this.txtMarkupAmount);
            this.panel6.Controls.Add(this.txtBaseAmount);
            this.panel6.Controls.Add(this.labelControl8);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.ForeColor = System.Drawing.Color.Teal;
            this.panel6.Location = new System.Drawing.Point(672, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(245, 81);
            this.panel6.TabIndex = 9;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.labelControl6.Location = new System.Drawing.Point(4, 6);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(101, 13);
            this.labelControl6.TabIndex = 9;
            this.labelControl6.Text = "MALIYET TOPLAM:";
            // 
            // txtBaseAmount
            // 
            this.txtBaseAmount.Enabled = false;
            this.txtBaseAmount.Location = new System.Drawing.Point(105, 3);
            this.txtBaseAmount.Name = "txtBaseAmount";
            this.txtBaseAmount.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtBaseAmount.Properties.Appearance.Options.UseBackColor = true;
            this.txtBaseAmount.Properties.Mask.EditMask = "c";
            this.txtBaseAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtBaseAmount.Size = new System.Drawing.Size(136, 20);
            this.txtBaseAmount.TabIndex = 7;
            // 
            // grdMaterialListIsWorkship
            // 
            this.grdMaterialListIsWorkship.AllowUserToAddRows = false;
            this.grdMaterialListIsWorkship.AllowUserToDeleteRows = false;
            this.grdMaterialListIsWorkship.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMaterialListIsWorkship.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMaterialListIsWorkship.Location = new System.Drawing.Point(0, 99);
            this.grdMaterialListIsWorkship.Name = "grdMaterialListIsWorkship";
            this.grdMaterialListIsWorkship.Size = new System.Drawing.Size(917, 352);
            this.grdMaterialListIsWorkship.TabIndex = 26;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.labelControl7.Location = new System.Drawing.Point(14, 58);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(85, 13);
            this.labelControl7.TabIndex = 8;
            this.labelControl7.Text = "GENEL TOPLAM:";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Enabled = false;
            this.txtTotalAmount.Location = new System.Drawing.Point(105, 55);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtTotalAmount.Properties.Appearance.Options.UseBackColor = true;
            this.txtTotalAmount.Properties.Mask.EditMask = "c";
            this.txtTotalAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTotalAmount.Size = new System.Drawing.Size(136, 20);
            this.txtTotalAmount.TabIndex = 5;
            // 
            // txtMarkupAmount
            // 
            this.txtMarkupAmount.Enabled = false;
            this.txtMarkupAmount.Location = new System.Drawing.Point(105, 29);
            this.txtMarkupAmount.Name = "txtMarkupAmount";
            this.txtMarkupAmount.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtMarkupAmount.Properties.Appearance.Options.UseBackColor = true;
            this.txtMarkupAmount.Properties.Mask.EditMask = "c";
            this.txtMarkupAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtMarkupAmount.Size = new System.Drawing.Size(136, 20);
            this.txtMarkupAmount.TabIndex = 6;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.labelControl8.Location = new System.Drawing.Point(20, 32);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(80, 13);
            this.labelControl8.TabIndex = 10;
            this.labelControl8.Text = "KAR TOPLAMI:";
            // 
            // frm_Teklif_Adim3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnKapat;
            this.ClientSize = new System.Drawing.Size(917, 532);
            this.ControlBox = false;
            this.Controls.Add(this.grdMaterialListIsWorkship);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Teklif_Adim3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Teklif_Adim3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaseAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMaterialListIsWorkship)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarkupAmount.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.LabelControl txtAdimAciklama;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private System.Windows.Forms.Panel panel6;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtBaseAmount;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraEditors.LabelControl lblTenderDescription;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl lblTenderNumber;
        private System.Windows.Forms.DataGridView grdMaterialListIsWorkship;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtWorkerMarkup;
        private DevExpress.XtraEditors.SimpleButton btnTumuneUygula;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit txtTotalAmount;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtMarkupAmount;
        private DevExpress.XtraEditors.LabelControl labelControl8;
    }
}