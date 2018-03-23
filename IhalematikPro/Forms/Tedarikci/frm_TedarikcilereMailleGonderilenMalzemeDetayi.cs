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

namespace IhalematikProUI.Forms.Tedarikci
{
    public partial class frm_TedarikcilereMailleGonderilenMalzemeDetayi : DevExpress.XtraEditors.XtraForm
    {
        public frm_TedarikcilereMailleGonderilenMalzemeDetayi()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                bool isSuccess = UIReportManager.Instance.ExtractExcel(grdMaterialList);
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