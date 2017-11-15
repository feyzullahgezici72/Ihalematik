using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhalematikProUI.Forms.Base
{
    public class IhalematikBaseForm : DevExpress.XtraEditors.XtraForm
    {

        public IhalematikBaseForm()
        {
            InitializeComponent();
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

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // IhalematikBaseForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "IhalematikBaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.ResumeLayout(false);

        }

        private void panelLoading_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
