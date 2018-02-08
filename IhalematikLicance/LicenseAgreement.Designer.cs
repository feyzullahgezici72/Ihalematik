namespace IhalematikLicance
{
    partial class LicenseAgreement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LicenseAgreement));
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnLisansla = new DevExpress.XtraEditors.SimpleButton();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnCancel.Location = new System.Drawing.Point(763, 6);
            this.btnCancel.LookAndFeel.SkinName = "London Liquid Sky";
            this.btnCancel.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(203, 88);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "İptal";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLisansla
            // 
            this.btnLisansla.Appearance.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLisansla.Appearance.Options.UseFont = true;
            this.btnLisansla.Image = ((System.Drawing.Image)(resources.GetObject("btnLisansla.Image")));
            this.btnLisansla.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnLisansla.Location = new System.Drawing.Point(554, 6);
            this.btnLisansla.LookAndFeel.SkinName = "London Liquid Sky";
            this.btnLisansla.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnLisansla.Name = "btnLisansla";
            this.btnLisansla.Size = new System.Drawing.Size(203, 88);
            this.btnLisansla.TabIndex = 0;
            this.btnLisansla.Text = "Kabul Ediyorum";
            this.btnLisansla.Click += new System.EventHandler(this.btnLisansla_Click);
            // 
            // memoEdit1
            // 
            this.memoEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoEdit1.EditValue = resources.GetString("memoEdit1.EditValue");
            this.memoEdit1.Location = new System.Drawing.Point(0, 0);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Properties.LookAndFeel.SkinName = "McSkin";
            this.memoEdit1.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.memoEdit1.Properties.ReadOnly = true;
            this.memoEdit1.Size = new System.Drawing.Size(971, 587);
            this.memoEdit1.TabIndex = 4;
            this.memoEdit1.TabStop = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Controls.Add(this.btnLisansla);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 587);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(971, 100);
            this.panelControl1.TabIndex = 3;
            // 
            // LicenseAgreement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 687);
            this.ControlBox = false;
            this.Controls.Add(this.memoEdit1);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LicenseAgreement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lisans Sözleşmesi";
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnLisansla;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}