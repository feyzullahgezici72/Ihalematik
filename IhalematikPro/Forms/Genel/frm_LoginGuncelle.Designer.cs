namespace IhalematikProUI.Forms.Genel
{
    partial class frm_LoginGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_LoginGuncelle));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtPassword2 = new DevExpress.XtraEditors.TextEdit();
            this.txtPassword1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.btnTamam = new DevExpress.XtraEditors.SimpleButton();
            this.btnIptal = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Location = new System.Drawing.Point(153, 44);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(247, 1);
            this.panelControl1.TabIndex = 24;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(146, 92);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(71, 13);
            this.labelControl2.TabIndex = 18;
            this.labelControl2.Text = "Şifreyi Onayla:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(166, 66);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(49, 13);
            this.labelControl1.TabIndex = 20;
            this.labelControl1.Text = "Yeni Şifre:";
            // 
            // txtPassword2
            // 
            this.txtPassword2.EditValue = "Demo";
            this.txtPassword2.EnterMoveNextControl = true;
            this.txtPassword2.Location = new System.Drawing.Point(219, 90);
            this.txtPassword2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtPassword2.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtPassword2.Properties.PasswordChar = '*';
            this.txtPassword2.Size = new System.Drawing.Size(181, 20);
            this.txtPassword2.TabIndex = 2;
            // 
            // txtPassword1
            // 
            this.txtPassword1.EditValue = "Demo";
            this.txtPassword1.EnterMoveNextControl = true;
            this.txtPassword1.Location = new System.Drawing.Point(219, 64);
            this.txtPassword1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassword1.Name = "txtPassword1";
            this.txtPassword1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtPassword1.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtPassword1.Properties.PasswordChar = '*';
            this.txtPassword1.Size = new System.Drawing.Size(181, 20);
            this.txtPassword1.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl3.Location = new System.Drawing.Point(155, 24);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(59, 13);
            this.labelControl3.TabIndex = 26;
            this.labelControl3.Text = "Kullanıcı Adı:";
            // 
            // txtUserName
            // 
            this.txtUserName.EditValue = "";
            this.txtUserName.EnterMoveNextControl = true;
            this.txtUserName.Location = new System.Drawing.Point(219, 22);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtUserName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtUserName.Size = new System.Drawing.Size(181, 20);
            this.txtUserName.TabIndex = 0;
            // 
            // btnTamam
            // 
            this.btnTamam.Appearance.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTamam.Appearance.Options.UseFont = true;
            this.btnTamam.Image = ((System.Drawing.Image)(resources.GetObject("btnTamam.Image")));
            this.btnTamam.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnTamam.Location = new System.Drawing.Point(264, 114);
            this.btnTamam.LookAndFeel.SkinName = "London Liquid Sky";
            this.btnTamam.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnTamam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(67, 38);
            this.btnTamam.TabIndex = 3;
            this.btnTamam.Text = "Güncelle";
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Appearance.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.Appearance.Options.UseFont = true;
            this.btnIptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnIptal.Image = ((System.Drawing.Image)(resources.GetObject("btnIptal.Image")));
            this.btnIptal.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnIptal.Location = new System.Drawing.Point(335, 114);
            this.btnIptal.LookAndFeel.SkinName = "London Liquid Sky";
            this.btnIptal.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnIptal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(67, 38);
            this.btnIptal.TabIndex = 4;
            this.btnIptal.Text = "İptal";
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IhalematikProUI.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // frm_LoginGuncelle
            // 
            this.AcceptButton = this.btnTamam;
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnIptal;
            this.ClientSize = new System.Drawing.Size(409, 162);
            this.ControlBox = false;
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtPassword2);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.txtPassword1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.LookAndFeel.SkinName = "VS2010";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_LoginGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Şifresi Güncelle";
            this.Load += new System.EventHandler(this.frm_LoginGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnIptal;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtPassword2;
        private DevExpress.XtraEditors.SimpleButton btnTamam;
        private DevExpress.XtraEditors.TextEdit txtPassword1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtUserName;
    }
}