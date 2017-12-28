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
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtdescriptionForSupplier = new DevExpress.XtraEditors.TextEdit();
            this.btnChangeName = new DevExpress.XtraEditors.SimpleButton();
            this.txtDescription = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtdescriptionForSupplier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(7, 52);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Malzeme Adı:";
            // 
            // txtdescriptionForSupplier
            // 
            this.txtdescriptionForSupplier.EditValue = "";
            this.txtdescriptionForSupplier.Location = new System.Drawing.Point(79, 49);
            this.txtdescriptionForSupplier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtdescriptionForSupplier.Name = "txtdescriptionForSupplier";
            this.txtdescriptionForSupplier.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtdescriptionForSupplier.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtdescriptionForSupplier.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtdescriptionForSupplier.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtdescriptionForSupplier.Size = new System.Drawing.Size(489, 20);
            this.txtdescriptionForSupplier.TabIndex = 1;
            // 
            // btnChangeName
            // 
            this.btnChangeName.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeName.Image")));
            this.btnChangeName.Location = new System.Drawing.Point(499, 84);
            this.btnChangeName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChangeName.Name = "btnChangeName";
            this.btnChangeName.Size = new System.Drawing.Size(67, 23);
            this.btnChangeName.TabIndex = 2;
            this.btnChangeName.Text = "Değiştir";
            this.btnChangeName.Click += new System.EventHandler(this.btnChangeName_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Enabled = false;
            this.txtDescription.EnterMoveNextControl = true;
            this.txtDescription.Location = new System.Drawing.Point(79, 17);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtDescription.Properties.Appearance.Options.UseBackColor = true;
            this.txtDescription.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtDescription.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtDescription.Size = new System.Drawing.Size(489, 20);
            toolTipTitleItem1.Text = "AÇIKLAMA";
            toolTipItem1.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            toolTipItem1.Appearance.Options.UseImage = true;
            toolTipItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolTipItem1.Image")));
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "Tedarikçilere gönderilecek işçilikli malzemenin adı";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.txtDescription.SuperTip = superToolTip1;
            this.txtDescription.TabIndex = 122;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl8.Location = new System.Drawing.Point(5, 19);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(66, 13);
            toolTipTitleItem2.Text = "AÇIKLAMA";
            toolTipItem2.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            toolTipItem2.Appearance.Options.UseImage = true;
            toolTipItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolTipItem2.Image")));
            toolTipItem2.LeftIndent = 6;
            toolTipItem2.Text = "Tedarikçilere gönderilecek işçilikli malzemenin adı";
            superToolTip2.Items.Add(toolTipTitleItem2);
            superToolTip2.Items.Add(toolTipItem2);
            this.labelControl8.SuperTip = superToolTip2;
            this.labelControl8.TabIndex = 123;
            this.labelControl8.Text = "T.G.Açıklama:";
            // 
            // frm_MalzemeAdlandir
            // 
            this.AcceptButton = this.btnChangeName;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 126);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.btnChangeName);
            this.Controls.Add(this.txtdescriptionForSupplier);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.LookAndFeel.SkinName = "Money Twins";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_MalzemeAdlandir";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MALZEMEYİ YENİDEN ADLANDIR";
            this.Load += new System.EventHandler(this.frm_MalzemeAdlandir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtdescriptionForSupplier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtdescriptionForSupplier;
        private DevExpress.XtraEditors.SimpleButton btnChangeName;
        private DevExpress.XtraEditors.TextEdit txtDescription;
        private DevExpress.XtraEditors.LabelControl labelControl8;
    }
}