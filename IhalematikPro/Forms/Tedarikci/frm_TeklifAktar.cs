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
    public partial class frm_TeklifAktar : DevExpress.XtraEditors.XtraForm
    {
        public frm_TeklifAktar()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}