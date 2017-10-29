namespace IhalematikPro.Forms
{
    partial class frm_ihaleOlustuMesaj
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblMesaj = new DevExpress.XtraEditors.LabelControl();
            this.btnTamam = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblMesaj
            // 
            this.lblMesaj.Appearance.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMesaj.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblMesaj.Location = new System.Drawing.Point(196, 35);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(345, 34);
            this.lblMesaj.TabIndex = 6;
            this.lblMesaj.Text = "Yeni İhale Oluşturuldu...";
            // 
            // btnTamam
            // 
            this.btnTamam.Image = global::IhalematikProUI.Properties.Resources.Check_icon__1_;
            this.btnTamam.Location = new System.Drawing.Point(482, 102);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(129, 58);
            this.btnTamam.TabIndex = 8;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::IhalematikProUI.Properties.Resources.Status_dialog_information_icon;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frm_ihaleOlustuMesaj
            // 
            this.AcceptButton = this.btnTamam;
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 172);
            this.ControlBox = false;
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblMesaj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_ihaleOlustuMesaj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_ihaleOlustuMesaj_FormClosed);
            this.Load += new System.EventHandler(this.frm_ihaleOlustuMesaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnTamam;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        public DevExpress.XtraEditors.LabelControl lblMesaj;
    }
}