﻿namespace IhalematikProUI.Forms.IhaleAdim
{
    partial class frm_TopluObfYukleIhale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TopluObfYukleIhale));
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnYukle = new DevExpress.XtraEditors.SimpleButton();
            this.lblPosSayisi = new DevExpress.XtraEditors.LabelControl();
            this.btnIptal = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.pnlYukle = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.picture1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlYukle)).BeginInit();
            this.pnlYukle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnYukle);
            this.groupControl2.Controls.Add(this.lblPosSayisi);
            this.groupControl2.Controls.Add(this.btnIptal);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(3, 597);
            this.groupControl2.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.groupControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(988, 94);
            this.groupControl2.TabIndex = 34;
            // 
            // btnYukle
            // 
            this.btnYukle.Image = ((System.Drawing.Image)(resources.GetObject("btnYukle.Image")));
            this.btnYukle.Location = new System.Drawing.Point(693, 26);
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
            this.btnIptal.Location = new System.Drawing.Point(838, 26);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(140, 57);
            this.btnIptal.TabIndex = 29;
            this.btnIptal.Text = "&Iptal";
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.Location = new System.Drawing.Point(136, 26);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(147, 19);
            this.labelControl1.TabIndex = 30;
            this.labelControl1.Text = "Yüklenen Öbf Sayısı:";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Black;
            this.listBox1.Font = new System.Drawing.Font("Calibri", 12F);
            this.listBox1.ForeColor = System.Drawing.Color.Lime;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
            this.listBox1.Location = new System.Drawing.Point(5, 42);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(982, 555);
            this.listBox1.TabIndex = 35;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.pnlYukle);
            this.groupControl1.Controls.Add(this.listBox1);
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(994, 694);
            this.groupControl1.TabIndex = 36;
            this.groupControl1.Text = " ";
            // 
            // pnlYukle
            // 
            this.pnlYukle.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlYukle.Controls.Add(this.labelControl2);
            this.pnlYukle.Controls.Add(this.memoEdit1);
            this.pnlYukle.Controls.Add(this.picture1);
            this.pnlYukle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlYukle.Location = new System.Drawing.Point(3, 30);
            this.pnlYukle.Name = "pnlYukle";
            this.pnlYukle.Size = new System.Drawing.Size(988, 567);
            this.pnlYukle.TabIndex = 39;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl2.Location = new System.Drawing.Point(8, 57);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(77, 24);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "UYARI !!!";
            // 
            // memoEdit1
            // 
            this.memoEdit1.EditValue = resources.GetString("memoEdit1.EditValue");
            this.memoEdit1.Location = new System.Drawing.Point(7, 86);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.memoEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.memoEdit1.Properties.LookAndFeel.SkinName = "Lilian";
            this.memoEdit1.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.memoEdit1.Properties.ReadOnly = true;
            this.memoEdit1.Size = new System.Drawing.Size(435, 414);
            this.memoEdit1.TabIndex = 9;
            // 
            // picture1
            // 
            this.picture1.Image = ((System.Drawing.Image)(resources.GetObject("picture1.Image")));
            this.picture1.Location = new System.Drawing.Point(449, 87);
            this.picture1.Name = "picture1";
            this.picture1.Size = new System.Drawing.Size(528, 414);
            this.picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture1.TabIndex = 8;
            this.picture1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frm_TopluObfYukleIhale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 694);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_TopluObfYukleIhale";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TOPLU ÖBF YÜKLE";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlYukle)).EndInit();
            this.pnlYukle.ResumeLayout(false);
            this.pnlYukle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnYukle;
        private DevExpress.XtraEditors.LabelControl lblPosSayisi;
        private DevExpress.XtraEditors.SimpleButton btnIptal;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ListBox listBox1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PanelControl pnlYukle;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private System.Windows.Forms.PictureBox picture1;
        private System.Windows.Forms.Timer timer1;
    }
}