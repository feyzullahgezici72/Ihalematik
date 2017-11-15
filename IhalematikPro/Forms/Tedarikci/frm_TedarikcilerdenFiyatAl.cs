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
using IhalematikProUI.Forms.Base;

namespace IhalematikProUI.Forms
{
    public partial class frm_TedarikcilerdenFiyatAl : IhalematikBaseForm
    {
        public frm_TedarikcilerdenFiyatAl()
        {
            InitializeComponent();
            base.ScreenMethod();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_TedarikcilerdenFiyatAl_Load(object sender, EventArgs e)
        {

        }
    }
}