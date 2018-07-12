namespace IhalematikProUI.Forms.Genel
{
    partial class frm_ProgramiGuncelle
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
            this.lblAck = new DevExpress.XtraEditors.LabelControl();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAck
            // 
            this.lblAck.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.lblAck.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.lblAck.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.lblAck.Location = new System.Drawing.Point(23, 32);
            this.lblAck.Name = "lblAck";
            this.lblAck.Size = new System.Drawing.Size(477, 19);
            this.lblAck.TabIndex = 108;
            this.lblAck.Text = "Bu işlem İnternet hızınıza bağlı olarak 5-10 dakika sürebilir.";
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBarControl1.Location = new System.Drawing.Point(0, 231);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Properties.FlowAnimationDelay = 100;
            this.progressBarControl1.Properties.FlowAnimationEnabled = true;
            this.progressBarControl1.Size = new System.Drawing.Size(638, 27);
            this.progressBarControl1.TabIndex = 107;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Appearance.Options.UseFont = true;
            this.btnGuncelle.Image = global::IhalematikProUI.Properties.Resources.network_icon32;
            this.btnGuncelle.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnGuncelle.Location = new System.Drawing.Point(23, 68);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(275, 111);
            this.btnGuncelle.TabIndex = 106;
            this.btnGuncelle.Text = "Güncellemeleri \r\nKontrol Et ve Yükle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IhalematikProUI.Properties.Resources.yukleniyor;
            this.pictureBox1.Location = new System.Drawing.Point(490, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 105;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // frm_ProgramiGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 258);
            this.Controls.Add(this.lblAck);
            this.Controls.Add(this.progressBarControl1);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_ProgramiGuncelle";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PROGRAM GÜNCELLE";
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl lblAck;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}