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

namespace IhalematikProUI.Forms.PozTem
{
    public partial class frm_TopluPozTemp : DevExpress.XtraEditors.XtraForm
    {
        public frm_TopluPozTemp()
        {
            InitializeComponent();
        }

       

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHayir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}