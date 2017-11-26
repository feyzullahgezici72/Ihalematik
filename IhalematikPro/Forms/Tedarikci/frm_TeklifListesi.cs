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
    public partial class frm_TeklifListesi : IhalematikBaseForm
    {
        public frm_TeklifListesi()
        {
            InitializeComponent();
            base.ScreenMethod();

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_TeklifListesi_Load(object sender, EventArgs e)
        {

        }

        private void btnOpen_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }
    }
}