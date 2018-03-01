namespace IhalematikProUI.Forms.OBF
{
    partial class frm_TopluOBFekle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TopluOBFekle));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.MesajPanel = new DevExpress.XtraEditors.PanelControl();
            this.panelControl7 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl6 = new DevExpress.XtraEditors.PanelControl();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.lblWait = new DevExpress.XtraEditors.LabelControl();
            this.btnTopluOFBekle = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MesajPanel)).BeginInit();
            this.MesajPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl7)).BeginInit();
            this.panelControl7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).BeginInit();
            this.panelControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Controls.Add(this.MesajPanel);
            this.groupControl1.Controls.Add(this.btnTopluOFBekle);
            this.groupControl1.Controls.Add(this.pictureBox1);
            this.groupControl1.Location = new System.Drawing.Point(10, 8);
            this.groupControl1.LookAndFeel.SkinName = "McSkin";
            this.groupControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(519, 351);
            this.groupControl1.TabIndex = 33;
            this.groupControl1.Text = "Ekleyeceğiniz Excel Dosyası Aşağıdaki gibi ayarlanmalıdır";
            // 
            // MesajPanel
            // 
            this.MesajPanel.Appearance.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.MesajPanel.Appearance.Options.UseBackColor = true;
            this.MesajPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.MesajPanel.Controls.Add(this.panelControl7);
            this.MesajPanel.Controls.Add(this.panelControl6);
            this.MesajPanel.Location = new System.Drawing.Point(63, 40);
            this.MesajPanel.LookAndFeel.SkinName = "Money Twins";
            this.MesajPanel.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MesajPanel.Name = "MesajPanel";
            this.MesajPanel.Size = new System.Drawing.Size(388, 205);
            this.MesajPanel.TabIndex = 8;
            this.MesajPanel.Visible = false;
            // 
            // panelControl7
            // 
            this.panelControl7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelControl7.Appearance.BackColor2 = System.Drawing.Color.Crimson;
            this.panelControl7.Appearance.Options.UseBackColor = true;
            this.panelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl7.Controls.Add(this.labelControl7);
            this.panelControl7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl7.Location = new System.Drawing.Point(0, 0);
            this.panelControl7.Name = "panelControl7";
            this.panelControl7.Size = new System.Drawing.Size(388, 37);
            this.panelControl7.TabIndex = 1;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl7.Location = new System.Drawing.Point(14, 6);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(63, 24);
            this.labelControl7.TabIndex = 3;
            this.labelControl7.Text = "UYARI !";
            // 
            // panelControl6
            // 
            this.panelControl6.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl6.Appearance.Options.UseBackColor = true;
            this.panelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl6.Controls.Add(this.pictureBox2);
            this.panelControl6.Controls.Add(this.labelControl8);
            this.panelControl6.Controls.Add(this.lblWait);
            this.panelControl6.Location = new System.Drawing.Point(14, 48);
            this.panelControl6.Name = "panelControl6";
            this.panelControl6.Size = new System.Drawing.Size(360, 145);
            this.panelControl6.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::IhalematikProUI.Properties.Resources.cargo_2_icon;
            this.pictureBox2.Location = new System.Drawing.Point(3, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(77, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl8.Location = new System.Drawing.Point(85, 40);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(270, 29);
            this.labelControl8.TabIndex = 4;
            this.labelControl8.Text = "MALZEMELER YÜKLENİYOR";
            // 
            // lblWait
            // 
            this.lblWait.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWait.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblWait.Location = new System.Drawing.Point(197, 75);
            this.lblWait.Name = "lblWait";
            this.lblWait.Size = new System.Drawing.Size(143, 22);
            this.lblWait.TabIndex = 3;
            this.lblWait.Text = "Lütfen Bekleyiniz...";
            // 
            // btnTopluOFBekle
            // 
            this.btnTopluOFBekle.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnTopluOFBekle.Appearance.Options.UseFont = true;
            this.btnTopluOFBekle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTopluOFBekle.Image = global::IhalematikProUI.Properties.Resources.Excel_icon;
            this.btnTopluOFBekle.Location = new System.Drawing.Point(3, 272);
            this.btnTopluOFBekle.Name = "btnTopluOFBekle";
            this.btnTopluOFBekle.Size = new System.Drawing.Size(513, 76);
            this.btnTopluOFBekle.TabIndex = 7;
            this.btnTopluOFBekle.Text = "Excel Dosyasını Seçip Yükleyiniz";
            this.btnTopluOFBekle.Click += new System.EventHandler(this.btnTopluOFBekle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(513, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frm_TopluOBFekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 359);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.LookAndFeel.SkinName = "McSkin";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_TopluOBFekle";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toplu ÖBF Malzeme Ekle";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MesajPanel)).EndInit();
            this.MesajPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl7)).EndInit();
            this.panelControl7.ResumeLayout(false);
            this.panelControl7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).EndInit();
            this.panelControl6.ResumeLayout(false);
            this.panelControl6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PanelControl MesajPanel;
        private DevExpress.XtraEditors.PanelControl panelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.PanelControl panelControl6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl lblWait;
        private DevExpress.XtraEditors.SimpleButton btnTopluOFBekle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}