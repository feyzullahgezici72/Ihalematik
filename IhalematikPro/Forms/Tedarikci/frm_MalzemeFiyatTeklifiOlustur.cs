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
using IhalematikPro.Manager;

namespace IhalematikProUI.Forms
{
    public partial class frm_MalzemeFiyatTeklifiOlustur : DevExpress.XtraEditors.XtraForm
    {
        public frm_MalzemeFiyatTeklifiOlustur()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_MalzemeFiyatTeklifiOlustur_Load(object sender, EventArgs e)
        {
            
        }
    }
}