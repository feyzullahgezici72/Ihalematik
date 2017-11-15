using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhalematikProUI.Forms.Base
{
    public class IhalematikBaseForm : DevExpress.XtraEditors.XtraForm
    {
        private DevExpress.XtraEditors.PictureEdit panelLoading;

        public IhalematikBaseForm()
        {
            InitializeComponent();
        }
        public void ShowLoading()
        {
            this.panelLoading.Show();
            //loading.ShowDialog();
        }
        public void HideLoading()
        {
            this.panelLoading.Hide();
            //loading.Hide();
        }

        private void InitializeComponent()
        {
            this.panelLoading = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelLoading.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLoading
            // 
            this.panelLoading.EditValue = global::IhalematikProUI.Properties.Resources.kaydediliyor;
            this.panelLoading.Location = new System.Drawing.Point(171, 12);
            this.panelLoading.Name = "panelLoading";
            this.panelLoading.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelLoading.Properties.Appearance.Options.UseBackColor = true;
            this.panelLoading.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelLoading.Properties.InitialImage = global::IhalematikProUI.Properties.Resources.loading;
            this.panelLoading.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.panelLoading.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.panelLoading.Properties.ZoomPercent = 75D;
            this.panelLoading.Size = new System.Drawing.Size(101, 83);
            this.panelLoading.TabIndex = 1;
            // 
            // IhalematikBaseForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.panelLoading);
            this.Name = "IhalematikBaseForm";
            ((System.ComponentModel.ISupportInitialize)(this.panelLoading.Properties)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
