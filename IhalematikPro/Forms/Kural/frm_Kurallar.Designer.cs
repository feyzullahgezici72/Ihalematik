namespace IhalematikProUI.Forms
{
    partial class frm_Kurallar
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
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.lblRuleName = new DevExpress.XtraEditors.LabelControl();
            this.txtRuleValue = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRuleValue.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.btnGuncelle);
            this.groupControl1.Controls.Add(this.lblRuleName);
            this.groupControl1.Controls.Add(this.txtRuleValue);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(524, 170);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "KURAL GÜNCELLE";
            // 
            // btnKapat
            // 
            this.btnKapat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnKapat.Image = global::IhalematikProUI.Properties.Resources.Actions_dialog_close_icon;
            this.btnKapat.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnKapat.Location = new System.Drawing.Point(447, 90);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(4);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(64, 54);
            this.btnKapat.TabIndex = 148;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Appearance.Options.UseFont = true;
            this.btnGuncelle.Image = global::IhalematikProUI.Properties.Resources.refresh_icon;
            this.btnGuncelle.Location = new System.Drawing.Point(309, 90);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(130, 54);
            this.btnGuncelle.TabIndex = 147;
            this.btnGuncelle.Text = "&Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // lblRuleName
            // 
            this.lblRuleName.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRuleName.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblRuleName.Location = new System.Drawing.Point(52, 58);
            this.lblRuleName.Margin = new System.Windows.Forms.Padding(4);
            this.lblRuleName.Name = "lblRuleName";
            this.lblRuleName.Size = new System.Drawing.Size(0, 19);
            this.lblRuleName.TabIndex = 146;
            // 
            // txtRuleValue
            // 
            this.txtRuleValue.EnterMoveNextControl = true;
            this.txtRuleValue.Location = new System.Drawing.Point(309, 58);
            this.txtRuleValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtRuleValue.Name = "txtRuleValue";
            this.txtRuleValue.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtRuleValue.Properties.Appearance.Options.UseBackColor = true;
            this.txtRuleValue.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtRuleValue.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtRuleValue.Properties.DisplayFormat.FormatString = "f";
            this.txtRuleValue.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtRuleValue.Properties.EditFormat.FormatString = "f";
            this.txtRuleValue.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtRuleValue.Size = new System.Drawing.Size(202, 26);
            this.txtRuleValue.TabIndex = 145;
            // 
            // frm_Kurallar
            // 
            this.AcceptButton = this.btnGuncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnKapat;
            this.ClientSize = new System.Drawing.Size(524, 170);
            this.ControlBox = false;
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.LookAndFeel.SkinName = "London Liquid Sky";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Kurallar";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frm_Kurallar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRuleValue.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.LabelControl lblRuleName;
        private DevExpress.XtraEditors.TextEdit txtRuleValue;
    }
}