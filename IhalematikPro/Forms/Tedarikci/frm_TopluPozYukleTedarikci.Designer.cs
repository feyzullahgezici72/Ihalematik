﻿namespace IhalematikProUI.Forms.Tedarikci
{
    partial class frm_TopluPozYukleTedarikci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TopluPozYukleTedarikci));
            this.lblPosSayisi = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnYukle = new DevExpress.XtraEditors.SimpleButton();
            this.btnIptal = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.pnlYuke = new DevExpress.XtraEditors.PanelControl();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.picture1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblPozListesi = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pcWorld = new System.Windows.Forms.PictureBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlYuke)).BeginInit();
            this.pnlYuke.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcWorld)).BeginInit();
            this.SuspendLayout();
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
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnYukle);
            this.groupControl2.Controls.Add(this.lblPosSayisi);
            this.groupControl2.Controls.Add(this.btnIptal);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(0, 565);
            this.groupControl2.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.groupControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(994, 94);
            this.groupControl2.TabIndex = 34;
            // 
            // btnYukle
            // 
            this.btnYukle.Image = ((System.Drawing.Image)(resources.GetObject("btnYukle.Image")));
            this.btnYukle.Location = new System.Drawing.Point(697, 27);
            this.btnYukle.Name = "btnYukle";
            this.btnYukle.Size = new System.Drawing.Size(140, 57);
            this.btnYukle.TabIndex = 28;
            this.btnYukle.Text = "&Yükle";
            this.btnYukle.Click += new System.EventHandler(this.btnYukle_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnIptal.Image = ((System.Drawing.Image)(resources.GetObject("btnIptal.Image")));
            this.btnIptal.Location = new System.Drawing.Point(843, 27);
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
            this.labelControl1.Location = new System.Drawing.Point(137, 27);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(146, 19);
            this.labelControl1.TabIndex = 30;
            this.labelControl1.Text = "Yüklenen Poz Sayısı:";
            // 
            // groupControl1
            // 
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl1.Controls.Add(this.pnlYuke);
            this.groupControl1.Controls.Add(this.listBox1);
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 35);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(994, 659);
            this.groupControl1.TabIndex = 32;
            this.groupControl1.Text = " ";
            // 
            // pnlYuke
            // 
            this.pnlYuke.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlYuke.Controls.Add(this.labelControl2);
            this.pnlYuke.Controls.Add(this.memoEdit1);
            this.pnlYuke.Controls.Add(this.picture1);
            this.pnlYuke.Location = new System.Drawing.Point(8, 7);
            this.pnlYuke.Name = "pnlYuke";
            this.pnlYuke.Size = new System.Drawing.Size(984, 559);
            this.pnlYuke.TabIndex = 40;
            // 
            // memoEdit1
            // 
            this.memoEdit1.EditValue = resources.GetString("memoEdit1.EditValue");
            this.memoEdit1.Location = new System.Drawing.Point(8, 72);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.memoEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.memoEdit1.Properties.LookAndFeel.SkinName = "Lilian";
            this.memoEdit1.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.memoEdit1.Properties.ReadOnly = true;
            this.memoEdit1.Size = new System.Drawing.Size(435, 414);
            this.memoEdit1.TabIndex = 5;
            // 
            // picture1
            // 
            this.picture1.Image = ((System.Drawing.Image)(resources.GetObject("picture1.Image")));
            this.picture1.Location = new System.Drawing.Point(449, 72);
            this.picture1.Name = "picture1";
            this.picture1.Size = new System.Drawing.Size(528, 414);
            this.picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture1.TabIndex = 4;
            this.picture1.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Black;
            this.listBox1.Font = new System.Drawing.Font("Calibri", 12F);
            this.listBox1.ForeColor = System.Drawing.Color.Lime;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
            this.listBox1.Location = new System.Drawing.Point(11, 11);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(982, 555);
            this.listBox1.TabIndex = 39;
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
            this.panelControl1.TabIndex = 31;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
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
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl2.Location = new System.Drawing.Point(8, 42);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(77, 24);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "UYARI !!!";
            // 
            // frm_TopluPozYukleTedarikci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 694);
            this.ControlBox = false;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_TopluPozYukleTedarikci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlYuke)).EndInit();
            this.pnlYuke.ResumeLayout(false);
            this.pnlYuke.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcWorld)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl lblPosSayisi;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnYukle;
        private DevExpress.XtraEditors.SimpleButton btnIptal;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.PictureBox pcWorld;
        private DevExpress.XtraEditors.LabelControl lblPozListesi;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl pnlYuke;
        private System.Windows.Forms.ListBox listBox1;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private System.Windows.Forms.PictureBox picture1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}