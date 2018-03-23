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
            this.Close();
        }
    }
}