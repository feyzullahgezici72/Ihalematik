namespace IhalematikProUI.Forms.Genel
{
    partial class frm_Mybrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Mybrowser));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pcWorld = new System.Windows.Forms.PictureBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.panel = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcWorld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelControl1.Appearance.BackColor2 = System.Drawing.Color.DodgerBlue;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.ContentImageAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.panelControl1.Controls.Add(this.pcWorld);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.btnKapat);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(908, 24);
            this.panelControl1.TabIndex = 29;
            // 
            // pcWorld
            // 
            this.pcWorld.Dock = System.Windows.Forms.DockStyle.Left;
            this.pcWorld.Image = ((System.Drawing.Image)(resources.GetObject("pcWorld.Image")));
            this.pcWorld.Location = new System.Drawing.Point(0, 0);
            this.pcWorld.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pcWorld.Name = "pcWorld";
            this.pcWorld.Size = new System.Drawing.Size(33, 24);
            this.pcWorld.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcWorld.TabIndex = 18;
            this.pcWorld.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.AliceBlue;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl1.LineColor = System.Drawing.Color.Red;
            this.labelControl1.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.labelControl1.Location = new System.Drawing.Point(37, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.ShowLineShadow = false;
            this.labelControl1.Size = new System.Drawing.Size(169, 23);
            this.labelControl1.TabIndex = 17;
            this.labelControl1.Text = "EKAP İHALE İLANLARI";
            this.labelControl1.UseMnemonic = false;
            // 
            // btnKapat
            // 
            this.btnKapat.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKapat.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.btnKapat.Appearance.Options.UseFont = true;
            this.btnKapat.Appearance.Options.UseForeColor = true;
            this.btnKapat.AutoSize = true;
            this.btnKapat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKapat.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.Image")));
            this.btnKapat.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnKapat.Location = new System.Drawing.Point(882, 0);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(26, 24);
            this.btnKapat.TabIndex = 3;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // panel
            // 
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 24);
            this.panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(908, 389);
            this.panel.TabIndex = 30;
            // 
            // frm_Mybrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnKapat;
            this.ClientSize = new System.Drawing.Size(908, 413);
            this.ControlBox = false;
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Mybrowser";
            this.ShowInTaskbar = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Mybrowser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcWorld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.PictureBox pcWorld;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.GroupControl panel;
        private System.Windows.Forms.WebBrowser ekapBrowser;
    }
}