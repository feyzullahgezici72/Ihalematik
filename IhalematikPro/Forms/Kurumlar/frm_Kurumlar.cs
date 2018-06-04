using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using IhalematikProUI.Manager;

namespace IhalematikProUI.Forms.Kurumlar
{
    public partial class frm_Kurumlar : DevExpress.XtraEditors.XtraForm
    {
        public frm_Kurumlar()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UIPopupManager.Instance.ShowPopup();

        }
    }
}