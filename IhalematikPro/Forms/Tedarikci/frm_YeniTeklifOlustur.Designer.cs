﻿namespace IhalematikProUI.Forms
{
    partial class frm_YeniTeklifOlustur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_YeniTeklifOlustur));
            this.txtAciklama = new DevExpress.XtraEditors.TextEdit();
            this.txtTeklifNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnIptal = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.pcWorld = new System.Windows.Forms.PictureBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.pbControl = new DevExpress.XtraEditors.ProgressBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTeklifNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcWorld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbControl.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(80, 87);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAciklama.Properties.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.txtAciklama.Properties.Appearance.Options.UseFont = true;
            this.txtAciklama.Properties.Appearance.Options.UseForeColor = true;
            this.txtAciklama.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtAciklama.Size = new System.Drawing.Size(442, 22);
            this.txtAciklama.TabIndex = 33;
            // 
            // txtTeklifNo
            // 
            this.txtTeklifNo.Enabled = false;
            this.txtTeklifNo.Location = new System.Drawing.Point(80, 62);
            this.txtTeklifNo.Name = "txtTeklifNo";
            this.txtTeklifNo.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTeklifNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtTeklifNo.Properties.Appearance.Options.UseFont = true;
            this.txtTeklifNo.Properties.Appearance.Options.UseForeColor = true;
            this.txtTeklifNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtTeklifNo.Properties.Mask.BeepOnError = true;
            this.txtTeklifNo.Size = new System.Drawing.Size(109, 22);
            this.txtTeklifNo.TabIndex = 32;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Location = new System.Drawing.Point(28, 90);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 13);
            this.labelControl2.TabIndex = 35;
            this.labelControl2.Text = "Açıklama:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.Location = new System.Drawing.Point(28, 65);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 13);
            this.labelControl1.TabIndex = 36;
            this.labelControl1.Text = "Teklif No:";
            // 
            // btnIptal
            // 
            this.btnIptal.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.Appearance.Options.UseFont = true;
            this.btnIptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnIptal.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnIptal.Image = global::IhalematikProUI.Properties.Resources.Actions_dialog_close_icon;
            this.btnIptal.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnIptal.Location = new System.Drawing.Point(489, 0);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(40, 37);
            this.btnIptal.TabIndex = 1;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.SteelBlue;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.ContentImageAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(529, 37);
            this.panelControl1.TabIndex = 38;
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.pcWorld);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.btnIptal);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(529, 37);
            this.panelControl2.TabIndex = 3;
            // 
            // pcWorld
            // 
            this.pcWorld.Dock = System.Windows.Forms.DockStyle.Left;
            this.pcWorld.Image = ((System.Drawing.Image)(resources.GetObject("pcWorld.Image")));
            this.pcWorld.Location = new System.Drawing.Point(0, 0);
            this.pcWorld.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pcWorld.Name = "pcWorld";
            this.pcWorld.Size = new System.Drawing.Size(47, 37);
            this.pcWorld.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcWorld.TabIndex = 16;
            this.pcWorld.TabStop = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl3.LineColor = System.Drawing.Color.Red;
            this.labelControl3.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.labelControl3.Location = new System.Drawing.Point(48, 8);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.ShowLineShadow = false;
            this.labelControl3.Size = new System.Drawing.Size(422, 24);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "YENİ TEKLİF MALZEME LİSTESİ OLUŞTUR";
            this.labelControl3.UseMnemonic = false;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(431, 123);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(94, 37);
            this.simpleButton2.TabIndex = 41;
            this.simpleButton2.Text = "Oluştur";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click_1);
            // 
            // pbControl
            // 
            this.pbControl.Location = new System.Drawing.Point(11, 129);
            this.pbControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbControl.Name = "pbControl";
            this.pbControl.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.pbControl.Properties.Step = 1;
            this.pbControl.Size = new System.Drawing.Size(414, 21);
            this.pbControl.TabIndex = 42;
            // 
            // frm_YeniTeklifOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnIptal;
            this.ClientSize = new System.Drawing.Size(529, 171);
            this.ControlBox = false;
            this.Controls.Add(this.pbControl);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtTeklifNo);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_YeniTeklifOlustur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frm_YeniTeklifOlustur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTeklifNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcWorld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbControl.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnIptal;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtAciklama;
        private DevExpress.XtraEditors.TextEdit txtTeklifNo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.PictureBox pcWorld;
        private DevExpress.XtraEditors.ProgressBarControl pbControl;
    }
}