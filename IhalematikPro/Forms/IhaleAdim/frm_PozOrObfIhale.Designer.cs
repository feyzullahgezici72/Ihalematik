namespace IhalematikProUI.Forms.IhaleAdim
{
    partial class frm_PozOrObfIhale
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
            this.btnObfYukle = new DevExpress.XtraEditors.SimpleButton();
            this.btnPozYukle = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObfYukle
            // 
            this.btnObfYukle.Location = new System.Drawing.Point(234, 59);
            this.btnObfYukle.Name = "btnObfYukle";
            this.btnObfYukle.Size = new System.Drawing.Size(200, 82);
            this.btnObfYukle.TabIndex = 0;
            this.btnObfYukle.Text = "ÖBF";
            this.btnObfYukle.Click += new System.EventHandler(this.btnObfYukle_Click);
            // 
            // btnPozYukle
            // 
            this.btnPozYukle.Location = new System.Drawing.Point(16, 59);
            this.btnPozYukle.Name = "btnPozYukle";
            this.btnPozYukle.Size = new System.Drawing.Size(200, 82);
            this.btnPozYukle.TabIndex = 0;
            this.btnPozYukle.Text = "POZ";
            this.btnPozYukle.Click += new System.EventHandler(this.btnPozYukle_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Controls.Add(this.checkEdit1);
            this.groupControl1.Controls.Add(this.btnObfYukle);
            this.groupControl1.Controls.Add(this.btnPozYukle);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(453, 197);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Yükleyeceğiniz Malzeme Türünü Seçiniz";
            // 
            // checkEdit1
            // 
            this.checkEdit1.EditValue = true;
            this.checkEdit1.Location = new System.Drawing.Point(25, 156);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Birim Fiyatları Veritabanından Al";
            this.checkEdit1.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.checkEdit1.Size = new System.Drawing.Size(300, 23);
            this.checkEdit1.TabIndex = 1;
            // 
            // frm_PozOrObfIhale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 197);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.SkinName = "McSkin";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_PozOrObfIhale";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnObfYukle;
        private DevExpress.XtraEditors.SimpleButton btnPozYukle;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
    }
}