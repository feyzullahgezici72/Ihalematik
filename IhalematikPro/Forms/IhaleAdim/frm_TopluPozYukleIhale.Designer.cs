namespace IhalematikProUI.Forms.IhaleAdim
{
    partial class frm_TopluPozYukleIhale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TopluPozYukleIhale));
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnYukle = new DevExpress.XtraEditors.SimpleButton();
            this.lblPosSayisi = new DevExpress.XtraEditors.LabelControl();
            this.btnIptal = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblPozListesi = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pcWorld = new System.Windows.Forms.PictureBox();
            this.lblPozno = new DevExpress.XtraEditors.LabelControl();
            this.lblBirim = new DevExpress.XtraEditors.LabelControl();
            this.lblAciklama = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.pnlYuke = new DevExpress.XtraEditors.PanelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbar1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblMiktar = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcWorld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlYuke)).BeginInit();
            this.pnlYuke.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbar1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnYukle);
            this.groupControl2.Controls.Add(this.lblPosSayisi);
            this.groupControl2.Controls.Add(this.btnIptal);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(3, 629);
            this.groupControl2.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.groupControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(988, 94);
            this.groupControl2.TabIndex = 34;
            // 
            // btnYukle
            // 
            this.btnYukle.Image = ((System.Drawing.Image)(resources.GetObject("btnYukle.Image")));
            this.btnYukle.Location = new System.Drawing.Point(698, 26);
            this.btnYukle.Name = "btnYukle";
            this.btnYukle.Size = new System.Drawing.Size(140, 57);
            this.btnYukle.TabIndex = 28;
            this.btnYukle.Text = "&Yükle";
            this.btnYukle.Click += new System.EventHandler(this.btnYukle_Click);
            // 
            // lblPosSayisi
            // 
            this.lblPosSayisi.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPosSayisi.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.lblPosSayisi.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblPosSayisi.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.lblPosSayisi.Location = new System.Drawing.Point(146, 53);
            this.lblPosSayisi.Name = "lblPosSayisi";
            this.lblPosSayisi.Size = new System.Drawing.Size(117, 31);
            this.lblPosSayisi.TabIndex = 23;
            // 
            // btnIptal
            // 
            this.btnIptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnIptal.Image = ((System.Drawing.Image)(resources.GetObject("btnIptal.Image")));
            this.btnIptal.Location = new System.Drawing.Point(843, 26);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(140, 57);
            this.btnIptal.TabIndex = 29;
            this.btnIptal.Text = "&İptal";
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.Location = new System.Drawing.Point(136, 26);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(146, 19);
            this.labelControl1.TabIndex = 30;
            this.labelControl1.Text = "Yüklenen Poz Sayısı:";
            // 
            // lblPozListesi
            // 
            this.lblPozListesi.Appearance.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPozListesi.Appearance.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblPozListesi.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lblPozListesi.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lblPozListesi.LineColor = System.Drawing.Color.Red;
            this.lblPozListesi.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.lblPozListesi.Location = new System.Drawing.Point(52, 0);
            this.lblPozListesi.Margin = new System.Windows.Forms.Padding(4);
            this.lblPozListesi.Name = "lblPozListesi";
            this.lblPozListesi.ShowLineShadow = false;
            this.lblPozListesi.Size = new System.Drawing.Size(211, 35);
            this.lblPozListesi.TabIndex = 22;
            this.lblPozListesi.Text = "TOPLU POZ YÜKLE";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Location = new System.Drawing.Point(52, 64);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(56, 19);
            this.labelControl2.TabIndex = 33;
            this.labelControl2.Text = "Poz No:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl4.Location = new System.Drawing.Point(62, 156);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(47, 19);
            this.labelControl4.TabIndex = 31;
            this.labelControl4.Text = "Birimi:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl5.Location = new System.Drawing.Point(56, 205);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(53, 19);
            this.labelControl5.TabIndex = 30;
            this.labelControl5.Text = "Miktarı:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl3.Location = new System.Drawing.Point(39, 113);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(70, 19);
            this.labelControl3.TabIndex = 32;
            this.labelControl3.Text = "Açıklama:";
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelControl1.Appearance.BackColor2 = System.Drawing.Color.DodgerBlue;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.ContentImageAlignment = System.Drawing.ContentAlignment.BottomLeft;
            this.panelControl1.Controls.Add(this.pcWorld);
            this.panelControl1.Controls.Add(this.lblPozListesi);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(994, 35);
            this.panelControl1.TabIndex = 33;
            // 
            // pcWorld
            // 
            this.pcWorld.BackColor = System.Drawing.Color.Transparent;
            this.pcWorld.Dock = System.Windows.Forms.DockStyle.Left;
            this.pcWorld.Image = ((System.Drawing.Image)(resources.GetObject("pcWorld.Image")));
            this.pcWorld.Location = new System.Drawing.Point(0, 0);
            this.pcWorld.Name = "pcWorld";
            this.pcWorld.Size = new System.Drawing.Size(50, 35);
            this.pcWorld.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcWorld.TabIndex = 23;
            this.pcWorld.TabStop = false;
            // 
            // lblPozno
            // 
            this.lblPozno.Appearance.BackColor = System.Drawing.Color.Black;
            this.lblPozno.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPozno.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblPozno.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblPozno.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.lblPozno.Location = new System.Drawing.Point(122, 63);
            this.lblPozno.Name = "lblPozno";
            this.lblPozno.Size = new System.Drawing.Size(174, 31);
            this.lblPozno.TabIndex = 20;
            // 
            // lblBirim
            // 
            this.lblBirim.Appearance.BackColor = System.Drawing.Color.Black;
            this.lblBirim.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBirim.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblBirim.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBirim.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.lblBirim.Location = new System.Drawing.Point(122, 153);
            this.lblBirim.Name = "lblBirim";
            this.lblBirim.Size = new System.Drawing.Size(174, 31);
            this.lblBirim.TabIndex = 22;
            // 
            // lblAciklama
            // 
            this.lblAciklama.Appearance.BackColor = System.Drawing.Color.Black;
            this.lblAciklama.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAciklama.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblAciklama.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblAciklama.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.lblAciklama.Location = new System.Drawing.Point(122, 108);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(860, 31);
            this.lblAciklama.TabIndex = 21;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.pnlYuke);
            this.groupControl1.Controls.Add(this.pbar1);
            this.groupControl1.Controls.Add(this.listBox1);
            this.groupControl1.Controls.Add(this.lblMiktar);
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.lblPozno);
            this.groupControl1.Controls.Add(this.lblAciklama);
            this.groupControl1.Controls.Add(this.lblBirim);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.LookAndFeel.SkinName = "Office 2010 Blue";
            this.groupControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(994, 726);
            this.groupControl1.TabIndex = 34;
            this.groupControl1.Text = " ";
            // 
            // pnlYuke
            // 
            this.pnlYuke.Controls.Add(this.pictureBox1);
            this.pnlYuke.Location = new System.Drawing.Point(6, 41);
            this.pnlYuke.Name = "pnlYuke";
            this.pnlYuke.Size = new System.Drawing.Size(984, 559);
            this.pnlYuke.TabIndex = 38;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(978, 556);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pbar1
            // 
            this.pbar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbar1.Location = new System.Drawing.Point(3, 599);
            this.pbar1.Name = "pbar1";
            this.pbar1.Size = new System.Drawing.Size(988, 30);
            this.pbar1.TabIndex = 37;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Black;
            this.listBox1.Font = new System.Drawing.Font("Calibri", 12F);
            this.listBox1.ForeColor = System.Drawing.Color.Lime;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
            this.listBox1.Location = new System.Drawing.Point(8, 51);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(982, 555);
            this.listBox1.TabIndex = 24;
            // 
            // lblMiktar
            // 
            this.lblMiktar.Appearance.BackColor = System.Drawing.Color.Black;
            this.lblMiktar.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMiktar.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblMiktar.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblMiktar.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.lblMiktar.Location = new System.Drawing.Point(122, 197);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(174, 31);
            this.lblMiktar.TabIndex = 35;
            // 
            // frm_TopluPozYukleIhale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 726);
            this.ControlBox = false;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_TopluPozYukleIhale";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcWorld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlYuke)).EndInit();
            this.pnlYuke.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbar1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcWorld;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnYukle;
        private DevExpress.XtraEditors.LabelControl lblPosSayisi;
        private DevExpress.XtraEditors.SimpleButton btnIptal;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblPozListesi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lblPozno;
        private DevExpress.XtraEditors.LabelControl lblBirim;
        private DevExpress.XtraEditors.LabelControl lblAciklama;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl lblMiktar;
        private System.Windows.Forms.ListBox listBox1;
        private DevExpress.XtraEditors.ProgressBarControl pbar1;
        private DevExpress.XtraEditors.PanelControl pnlYuke;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}