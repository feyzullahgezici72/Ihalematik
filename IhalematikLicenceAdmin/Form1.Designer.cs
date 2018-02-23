namespace IhalematikLicenceAdmin
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtSerialNumber = new System.Windows.Forms.TextBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.button2 = new System.Windows.Forms.Button();
            this.txtVergiNumarasi = new DevExpress.XtraEditors.TextEdit();
            this.txtVergiDairesi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.txtAddresi = new DevExpress.XtraEditors.MemoEdit();
            this.txtTelefon = new DevExpress.XtraEditors.TextEdit();
            this.txtCompanyName = new DevExpress.XtraEditors.TextEdit();
            this.txtAuthorNameSurname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridLicense = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtVergiNumarasi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVergiDairesi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddresi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthorNameSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLicense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 95);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.Enabled = false;
            this.txtSerialNumber.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSerialNumber.Location = new System.Drawing.Point(16, 54);
            this.txtSerialNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(481, 32);
            this.txtSerialNumber.TabIndex = 6;
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.groupControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Green;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Controls.Add(this.txtVergiNumarasi);
            this.groupControl1.Controls.Add(this.txtVergiDairesi);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl13);
            this.groupControl1.Controls.Add(this.txtAddresi);
            this.groupControl1.Controls.Add(this.txtTelefon);
            this.groupControl1.Controls.Add(this.txtCompanyName);
            this.groupControl1.Controls.Add(this.txtAuthorNameSurname);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.LookAndFeel.SkinName = "Coffee";
            this.groupControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(543, 640);
            this.groupControl1.TabIndex = 17;
            this.groupControl1.Text = "Lisans Sahibinin";
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl2.Controls.Add(this.button2);
            this.groupControl2.Controls.Add(this.txtSerialNumber);
            this.groupControl2.Controls.Add(this.button1);
            this.groupControl2.Location = new System.Drawing.Point(12, 375);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(512, 148);
            this.groupControl2.TabIndex = 103;
            this.groupControl2.Text = "Lisans Anahtarı";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(382, 95);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 35);
            this.button2.TabIndex = 8;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtVergiNumarasi
            // 
            this.txtVergiNumarasi.EnterMoveNextControl = true;
            this.txtVergiNumarasi.Location = new System.Drawing.Point(168, 185);
            this.txtVergiNumarasi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVergiNumarasi.Name = "txtVergiNumarasi";
            this.txtVergiNumarasi.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtVergiNumarasi.Properties.Appearance.Options.UseBackColor = true;
            this.txtVergiNumarasi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtVergiNumarasi.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtVergiNumarasi.Size = new System.Drawing.Size(352, 26);
            this.txtVergiNumarasi.TabIndex = 4;
            // 
            // txtVergiDairesi
            // 
            this.txtVergiDairesi.EnterMoveNextControl = true;
            this.txtVergiDairesi.Location = new System.Drawing.Point(168, 149);
            this.txtVergiDairesi.Name = "txtVergiDairesi";
            this.txtVergiDairesi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtVergiDairesi.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtVergiDairesi.Size = new System.Drawing.Size(350, 26);
            this.txtVergiDairesi.TabIndex = 3;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(44, 188);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(115, 19);
            this.labelControl6.TabIndex = 101;
            this.labelControl6.Text = "Vergi Numarası:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(62, 152);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(96, 19);
            this.labelControl7.TabIndex = 102;
            this.labelControl7.Text = "Vergi Dairesi:";
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(106, 217);
            this.labelControl13.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(52, 19);
            this.labelControl13.TabIndex = 100;
            this.labelControl13.Text = "Adres :";
            // 
            // txtAddresi
            // 
            this.txtAddresi.EnterMoveNextControl = true;
            this.txtAddresi.Location = new System.Drawing.Point(168, 217);
            this.txtAddresi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddresi.Name = "txtAddresi";
            this.txtAddresi.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtAddresi.Properties.Appearance.Options.UseBackColor = true;
            this.txtAddresi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtAddresi.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtAddresi.Size = new System.Drawing.Size(352, 129);
            this.txtAddresi.TabIndex = 5;
            // 
            // txtTelefon
            // 
            this.txtTelefon.EnterMoveNextControl = true;
            this.txtTelefon.Location = new System.Drawing.Point(168, 115);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtTelefon.Properties.Appearance.Options.UseBackColor = true;
            this.txtTelefon.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtTelefon.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtTelefon.Properties.Mask.EditMask = "999 000 00 00";
            this.txtTelefon.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtTelefon.Size = new System.Drawing.Size(352, 26);
            this.txtTelefon.TabIndex = 2;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.EnterMoveNextControl = true;
            this.txtCompanyName.Location = new System.Drawing.Point(168, 85);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtCompanyName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtCompanyName.Size = new System.Drawing.Size(350, 26);
            this.txtCompanyName.TabIndex = 1;
            // 
            // txtAuthorNameSurname
            // 
            this.txtAuthorNameSurname.EnterMoveNextControl = true;
            this.txtAuthorNameSurname.Location = new System.Drawing.Point(168, 52);
            this.txtAuthorNameSurname.Name = "txtAuthorNameSurname";
            this.txtAuthorNameSurname.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtAuthorNameSurname.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtAuthorNameSurname.Size = new System.Drawing.Size(350, 26);
            this.txtAuthorNameSurname.TabIndex = 0;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(94, 118);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(64, 19);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Telefon :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(60, 88);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(99, 19);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Ticari Ünvanı:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(76, 55);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(82, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Adı Soyadı:";
            // 
            // gridLicense
            // 
            this.gridLicense.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridLicense.Location = new System.Drawing.Point(543, 0);
            this.gridLicense.MainView = this.gridView1;
            this.gridLicense.Name = "gridLicense";
            this.gridLicense.Size = new System.Drawing.Size(827, 640);
            this.gridLicense.TabIndex = 18;
            this.gridLicense.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn7,
            this.gridColumn6});
            this.gridView1.GridControl = this.gridLicense;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ADI SOYADI";
            this.gridColumn1.FieldName = "AuthorNameSurname";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsFilter.AllowFilter = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 174;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "TİCARİ ÜNVANI";
            this.gridColumn2.FieldName = "CompanyName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsFilter.AllowFilter = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 174;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "TELEFONU";
            this.gridColumn3.FieldName = "Telephone";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsFilter.AllowFilter = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 127;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "V.DAİRESİ";
            this.gridColumn4.FieldName = "TaxOffice";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsFilter.AllowFilter = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 189;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "V.NUMARASI";
            this.gridColumn5.FieldName = "TaxNumber";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsFilter.AllowFilter = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 144;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "ADRES";
            this.gridColumn7.FieldName = "Address";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 5;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "LİSANS ANAHTARI";
            this.gridColumn6.FieldName = "LicenseKey";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsFilter.AllowFilter = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 6;
            this.gridColumn6.Width = 240;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 640);
            this.Controls.Add(this.gridLicense);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LifeTreeSoftware";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtVergiNumarasi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVergiDairesi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddresi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAuthorNameSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLicense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSerialNumber;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtVergiNumarasi;
        private DevExpress.XtraEditors.TextEdit txtVergiDairesi;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.MemoEdit txtAddresi;
        private DevExpress.XtraEditors.TextEdit txtTelefon;
        private DevExpress.XtraEditors.TextEdit txtCompanyName;
        private DevExpress.XtraEditors.TextEdit txtAuthorNameSurname;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Button button2;
        private DevExpress.XtraGrid.GridControl gridLicense;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
    }
}

