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
using System.Diagnostics;
using IhalematikProUI.Manager;

namespace IhalematikProUI.Forms.Tedarikci
{
    public partial class frm_MailListesi : DevExpress.XtraEditors.XtraForm
    {
        public frm_MailListesi()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                bool isSuccess = UIReportManager.Instance.ExtractExcel(grdMailList);
                if (!isSuccess)
                {
                    MessageBox.Show("Hay Aksii!! \nProgram beklenmeyen bir hata ile karşılaştı.");
                }
            }
            catch (Exception)
            {


            }
        }
    }
}