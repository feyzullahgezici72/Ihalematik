using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IhalematikProUI.Forms.Base
{
    public class IhalematikBaseForm : DevExpress.XtraEditors.XtraForm
    {
        public IhalematikBaseForm()
        {
            this.InitializeMethod();
        }
        public void ShowLoading()
        {
            //this.panelLoading.Show();
            //loading.ShowDialog();
        }
        public void HideLoading()
        {
            //this.panelLoading.Hide();
            //loading.Hide();
        }

        private void InitializeMethod()
        {
            this.SuspendLayout();
            // 
            // IhalematikBaseForm
            // 
            ScreenMethod();
            this.Load += new System.EventHandler(this.IhalematikBaseForm_Load);
            this.ResumeLayout(false);

        }

        public void ScreenMethod()
        {
            this.ClientSize = new System.Drawing.Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            this.Name = "IhalematikBaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
        }

        private void panelLoading_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void IhalematikBaseForm_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // IhalematikBaseForm
            // 
            this.ClientSize = new System.Drawing.Size(1902, 1020);
            this.LookAndFeel.SkinName = "Money Twins";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "IhalematikBaseForm";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.IhalematikBaseForm_Load_1);
            this.ResumeLayout(false);

        }

        private void IhalematikBaseForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
