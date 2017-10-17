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
using IhalematikPro.Forms;

namespace IhalematikProUI.Forms
{
    public partial class frm_YeniTeklifOlustur : DevExpress.XtraEditors.XtraForm
    {
        public frm_YeniTeklifOlustur()
        {
            InitializeComponent();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }  
    }
}