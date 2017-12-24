namespace IhalematikProUI.Forms.Tedarikci
{
    partial class frm_MalzemeAdlandir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MalzemeAdlandir));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtNewMeterialName = new DevExpress.XtraEditors.TextEdit();
            this.btnChangeName = new DevExpress.XtraEditors.SimpleButton();
            this.trcBar = new DevExpress.XtraEditors.TrackBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewMeterialName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcBar.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(8, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(96, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Malzeme Adı:";
            // 
            // txtNewMeterialName
            // 
            this.txtNewMeterialName.Location = new System.Drawing.Point(115, 27);
            this.txtNewMeterialName.Name = "txtNewMeterialName";
            this.txtNewMeterialName.Size = new System.Drawing.Size(865, 26);
            this.txtNewMeterialName.TabIndex = 1;
            // 
            // btnChangeName
            // 
            this.btnChangeName.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeName.Image")));
            this.btnChangeName.Location = new System.Drawing.Point(880, 134);
            this.btnChangeName.Name = "btnChangeName";
            this.btnChangeName.Size = new System.Drawing.Size(100, 34);
            this.btnChangeName.TabIndex = 2;
            this.btnChangeName.Text = "Değiştir";
            this.btnChangeName.Click += new System.EventHandler(this.btnChangeName_Click);
            // 
            // trcBar
            // 
            this.trcBar.Location = new System.Drawing.Point(107, 59);
            this.trcBar.Name = "trcBar";
            this.trcBar.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.trcBar.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.trcBar.Properties.LargeChange = 1;
            this.trcBar.Properties.LookAndFeel.SkinName = "McSkin";
            this.trcBar.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.trcBar.Size = new System.Drawing.Size(879, 69);
            this.trcBar.TabIndex = 3;
            // 
            // frm_MalzemeAdlandir
            // 
            this.AcceptButton = this.btnChangeName;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 180);
            this.Controls.Add(this.trcBar);
            this.Controls.Add(this.btnChangeName);
            this.Controls.Add(this.txtNewMeterialName);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.LookAndFeel.SkinName = "Money Twins";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_MalzemeAdlandir";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MALZEMEYİ YENİDEN ADLANDIR";
            this.Load += new System.EventHandler(this.frm_MalzemeAdlandir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNewMeterialName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcBar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtNewMeterialName;
        private DevExpress.XtraEditors.SimpleButton btnChangeName;
        private DevExpress.XtraEditors.TrackBarControl trcBar;
    }
}