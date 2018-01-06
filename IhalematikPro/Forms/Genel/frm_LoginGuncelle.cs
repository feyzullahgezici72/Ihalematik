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

namespace IhalematikProUI.Forms.Genel
{
    public partial class frm_LoginGuncelle : DevExpress.XtraEditors.XtraForm
    {
        public frm_LoginGuncelle()
        {
            InitializeComponent();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Parola Güncellendi...");
        }
    }
}