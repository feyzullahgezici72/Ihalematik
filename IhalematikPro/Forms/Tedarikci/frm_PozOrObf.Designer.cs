namespace IhalematikProUI.Forms.Tedarikci
{
    partial class frm_PozOrObf
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnObfYukle = new DevExpress.XtraEditors.SimpleButton();
            this.btnPozYukle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.SteelBlue;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Controls.Add(this.btnObfYukle);
            this.groupControl1.Controls.Add(this.btnPozYukle);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(453, 172);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Yükleyeceğiniz Malzeme Türünü Seçiniz";
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
            // frm_PozOrObf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 172);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.SkinName = "McSkin";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_PozOrObf";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_PozOrObf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnObfYukle;
        private DevExpress.XtraEditors.SimpleButton btnPozYukle;
    }
}