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
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MalzemeAdlandir));
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtdescriptionForSupplier = new DevExpress.XtraEditors.TextEdit();
            this.btnChangeName = new DevExpress.XtraEditors.SimpleButton();
            this.txtDescription = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtdescriptionForSupplier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(17, 55);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(96, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Malzeme Adı:";
            // 
            // txtdescriptionForSupplier
            // 
            this.txtdescriptionForSupplier.EditValue = "";
            this.txtdescriptionForSupplier.EnterMoveNextControl = true;
            this.txtdescriptionForSupplier.Location = new System.Drawing.Point(120, 89);
            this.txtdescriptionForSupplier.Name = "txtdescriptionForSupplier";
            this.txtdescriptionForSupplier.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtdescriptionForSupplier.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtdescriptionForSupplier.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtdescriptionForSupplier.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtdescriptionForSupplier.Size = new System.Drawing.Size(734, 26);
            toolTipTitleItem1.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            toolTipTitleItem1.Appearance.Options.UseImage = true;
            toolTipTitleItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolTipTitleItem1.Image")));
            toolTipTitleItem1.Text = "AÇIKLAMA";
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "Tedarikçilere gönderilecek malzeme listesinde burada belirteceğiniz malzeme hakkı" +
    "ndaki açıklama gönderilecektir.\r\nBoş bırakırsanız Malzeme adı gönderilecektir.";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.txtdescriptionForSupplier.SuperTip = superToolTip1;
            this.txtdescriptionForSupplier.TabIndex = 1;
            // 
            // btnChangeName
            // 
            this.btnChangeName.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeName.Image")));
            this.btnChangeName.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnChangeName.Location = new System.Drawing.Point(737, 121);
            this.btnChangeName.Name = "btnChangeName";
            this.btnChangeName.Size = new System.Drawing.Size(117, 68);
            this.btnChangeName.TabIndex = 2;
            this.btnChangeName.Text = "&Tamam";
            this.btnChangeName.Click += new System.EventHandler(this.btnChangeName_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Enabled = false;
            this.txtDescription.EnterMoveNextControl = true;
            this.txtDescription.Location = new System.Drawing.Point(120, 52);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtDescription.Properties.Appearance.Options.UseBackColor = true;
            this.txtDescription.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtDescription.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtDescription.Size = new System.Drawing.Size(734, 26);
            toolTipTitleItem2.Text = "AÇIKLAMA";
            toolTipItem2.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            toolTipItem2.Appearance.Options.UseImage = true;
            toolTipItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolTipItem2.Image")));
            toolTipItem2.LeftIndent = 6;
            toolTipItem2.Text = "Tedarikçilere gönderilecek işçilikli malzemenin adı";
            superToolTip2.Items.Add(toolTipTitleItem2);
            superToolTip2.Items.Add(toolTipItem2);
            this.txtDescription.SuperTip = superToolTip2;
            this.txtDescription.TabIndex = 122;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl8.Location = new System.Drawing.Point(38, 92);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(75, 19);
            this.labelControl8.TabIndex = 123;
            this.labelControl8.Text = "Açıklama :";
            // 
            // groupControl2
            // 
            this.groupControl2.Appearance.BackColor = System.Drawing.Color.White;
            this.groupControl2.Appearance.Options.UseBackColor = true;
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.Navy;
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl2.Controls.Add(this.txtDescription);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.txtdescriptionForSupplier);
            this.groupControl2.Controls.Add(this.labelControl8);
            this.groupControl2.Controls.Add(this.btnChangeName);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(862, 204);
            this.groupControl2.TabIndex = 125;
            this.groupControl2.Text = "Malzeme Adı";
            // 
            // frm_MalzemeAdlandir
            // 
            this.AcceptButton = this.btnChangeName;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 204);
            this.Controls.Add(this.groupControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_MalzemeAdlandir";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MALZEME HAKKINDA DETAYLI AÇIKLAMA GİRİNİZ";
            this.Load += new System.EventHandler(this.frm_MalzemeAdlandir_Load);
            this.Shown += new System.EventHandler(this.frm_MalzemeAdlandir_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.txtdescriptionForSupplier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtdescriptionForSupplier;
        private DevExpress.XtraEditors.SimpleButton btnChangeName;
        private DevExpress.XtraEditors.TextEdit txtDescription;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.GroupControl groupControl2;
    }
}