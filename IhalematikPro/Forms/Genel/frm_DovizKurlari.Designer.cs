namespace IhalematikPro.Forms
{
    partial class frm_DovizKurlari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DovizKurlari));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtEuro = new DevExpress.XtraEditors.TextEdit();
            this.txtDolar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtSabitEuro = new DevExpress.XtraEditors.TextEdit();
            this.txtSabitDolar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.dtSabitDolar = new DevExpress.XtraEditors.DateEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.dtSabitEuro = new DevExpress.XtraEditors.DateEdit();
            this.btnIptal = new DevExpress.XtraEditors.SimpleButton();
            this.btnOnlineAl = new DevExpress.XtraEditors.SimpleButton();
            this.btnKurKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit2 = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEuro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDolar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSabitEuro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSabitDolar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSabitDolar.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSabitDolar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSabitEuro.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSabitEuro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelControl1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.btnIptal);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(396, 39);
            this.panelControl1.TabIndex = 13;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Location = new System.Drawing.Point(10, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(150, 29);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "KUR İŞLEMLERİ";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnOnlineAl);
            this.groupControl2.Controls.Add(this.txtEuro);
            this.groupControl2.Controls.Add(this.txtDolar);
            this.groupControl2.Controls.Add(this.btnKurKaydet);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 39);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(396, 143);
            this.groupControl2.TabIndex = 14;
            this.groupControl2.Text = "Güncel Kur Kaydet";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.checkEdit2);
            this.groupControl1.Controls.Add(this.checkEdit1);
            this.groupControl1.Controls.Add(this.dtSabitEuro);
            this.groupControl1.Controls.Add(this.dtSabitDolar);
            this.groupControl1.Controls.Add(this.txtSabitEuro);
            this.groupControl1.Controls.Add(this.txtSabitDolar);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 182);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(396, 250);
            this.groupControl1.TabIndex = 15;
            this.groupControl1.Text = "Kur Sabitle";
            // 
            // txtEuro
            // 
            this.txtEuro.Location = new System.Drawing.Point(100, 95);
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.Size = new System.Drawing.Size(136, 26);
            this.txtEuro.TabIndex = 14;
            // 
            // txtDolar
            // 
            this.txtDolar.Location = new System.Drawing.Point(100, 49);
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(136, 26);
            this.txtDolar.TabIndex = 15;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(45, 98);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(44, 19);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "Euro :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(45, 52);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(49, 19);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Dolar :";
            // 
            // txtSabitEuro
            // 
            this.txtSabitEuro.Location = new System.Drawing.Point(19, 151);
            this.txtSabitEuro.Name = "txtSabitEuro";
            this.txtSabitEuro.Size = new System.Drawing.Size(136, 26);
            this.txtSabitEuro.TabIndex = 14;
            // 
            // txtSabitDolar
            // 
            this.txtSabitDolar.Location = new System.Drawing.Point(19, 78);
            this.txtSabitDolar.Name = "txtSabitDolar";
            this.txtSabitDolar.Size = new System.Drawing.Size(136, 26);
            this.txtSabitDolar.TabIndex = 15;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(19, 126);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(38, 19);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = "Euro ";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(19, 53);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(43, 19);
            this.labelControl5.TabIndex = 13;
            this.labelControl5.Text = "Dolar ";
            // 
            // dtSabitDolar
            // 
            this.dtSabitDolar.EditValue = null;
            this.dtSabitDolar.Location = new System.Drawing.Point(161, 78);
            this.dtSabitDolar.Name = "dtSabitDolar";
            this.dtSabitDolar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtSabitDolar.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtSabitDolar.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.dtSabitDolar.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dtSabitDolar.Size = new System.Drawing.Size(188, 26);
            this.dtSabitDolar.TabIndex = 16;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(161, 53);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(75, 19);
            this.labelControl6.TabIndex = 13;
            this.labelControl6.Text = "Bitiş Tarihi";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(161, 126);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(75, 19);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "Bitiş Tarihi";
            // 
            // dtSabitEuro
            // 
            this.dtSabitEuro.EditValue = null;
            this.dtSabitEuro.Location = new System.Drawing.Point(161, 151);
            this.dtSabitEuro.Name = "dtSabitEuro";
            this.dtSabitEuro.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtSabitEuro.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtSabitEuro.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.dtSabitEuro.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dtSabitEuro.Size = new System.Drawing.Size(188, 26);
            this.dtSabitEuro.TabIndex = 16;
            // 
            // btnIptal
            // 
            this.btnIptal.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.Appearance.Options.UseFont = true;
            this.btnIptal.AutoSize = true;
            this.btnIptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnIptal.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnIptal.Image = ((System.Drawing.Image)(resources.GetObject("btnIptal.Image")));
            this.btnIptal.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnIptal.Location = new System.Drawing.Point(368, 0);
            this.btnIptal.Margin = new System.Windows.Forms.Padding(4);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(28, 39);
            this.btnIptal.TabIndex = 2;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnOnlineAl
            // 
            this.btnOnlineAl.Image = ((System.Drawing.Image)(resources.GetObject("btnOnlineAl.Image")));
            this.btnOnlineAl.Location = new System.Drawing.Point(253, 86);
            this.btnOnlineAl.Name = "btnOnlineAl";
            this.btnOnlineAl.Size = new System.Drawing.Size(125, 42);
            this.btnOnlineAl.TabIndex = 16;
            this.btnOnlineAl.Text = "Online Al";
            this.btnOnlineAl.Click += new System.EventHandler(this.btnOnlineAl_Click);
            // 
            // btnKurKaydet
            // 
            this.btnKurKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnKurKaydet.Image")));
            this.btnKurKaydet.Location = new System.Drawing.Point(253, 40);
            this.btnKurKaydet.Name = "btnKurKaydet";
            this.btnKurKaydet.Size = new System.Drawing.Size(125, 42);
            this.btnKurKaydet.TabIndex = 17;
            this.btnKurKaydet.Text = "Kaydet";
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(357, 76);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "";
            this.checkEdit1.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined;
            this.checkEdit1.Properties.PictureChecked = global::IhalematikProUI.Properties.Resources.Lock_Lock_icon;
            this.checkEdit1.Properties.PictureUnchecked = global::IhalematikProUI.Properties.Resources.Lock_Unlock_icon;
            this.checkEdit1.Size = new System.Drawing.Size(39, 28);
            this.checkEdit1.TabIndex = 17;
            // 
            // checkEdit2
            // 
            this.checkEdit2.Location = new System.Drawing.Point(355, 149);
            this.checkEdit2.Name = "checkEdit2";
            this.checkEdit2.Properties.Caption = "";
            this.checkEdit2.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined;
            this.checkEdit2.Properties.PictureChecked = global::IhalematikProUI.Properties.Resources.Lock_Lock_icon;
            this.checkEdit2.Properties.PictureUnchecked = global::IhalematikProUI.Properties.Resources.Lock_Unlock_icon;
            this.checkEdit2.Size = new System.Drawing.Size(39, 28);
            this.checkEdit2.TabIndex = 18;
            // 
            // frm_DovizKurlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnIptal;
            this.ClientSize = new System.Drawing.Size(396, 398);
            this.ControlBox = false;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_DovizKurlari";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frm_DovizKurlari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEuro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDolar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSabitEuro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSabitDolar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSabitDolar.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSabitDolar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSabitEuro.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSabitEuro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnIptal;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnOnlineAl;
        private DevExpress.XtraEditors.TextEdit txtEuro;
        private DevExpress.XtraEditors.TextEdit txtDolar;
        private DevExpress.XtraEditors.SimpleButton btnKurKaydet;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.DateEdit dtSabitEuro;
        private DevExpress.XtraEditors.DateEdit dtSabitDolar;
        private DevExpress.XtraEditors.TextEdit txtSabitEuro;
        private DevExpress.XtraEditors.TextEdit txtSabitDolar;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.CheckEdit checkEdit2;
    }
}