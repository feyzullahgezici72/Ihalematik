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
using System.Threading;

namespace IhalematikProUI.Forms
{
    public partial class frm_IscilikFirimFiyat : DevExpress.XtraEditors.XtraForm
    {
        public frm_IscilikFirimFiyat()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void wait()
        {
            Thread.Sleep(1000);
        }
        public void formLoading()
        {
            using (frm_wait frm = new frm_wait(wait))
            {
                frm.ShowDialog();
            }
        }
        private void frm_IscilikFirimFiyat_Load(object sender, EventArgs e)
        {
            formLoading();
        }
    }
}