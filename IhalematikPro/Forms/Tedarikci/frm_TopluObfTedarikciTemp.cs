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

namespace IhalematikProUI.Forms.Tedarikci
{
    public partial class frm_TopluObfTedarikciTemp : DevExpress.XtraEditors.XtraForm
    {
        public frm_TopluObfTedarikciTemp()
        {
            InitializeComponent();
        }

        private void btnHayir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}