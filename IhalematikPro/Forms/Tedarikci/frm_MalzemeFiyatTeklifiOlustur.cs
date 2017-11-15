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
using IhalematikProUI.Forms.Base;

namespace IhalematikProUI.Forms
{
    public partial class frm_MalzemeFiyatTeklifiOlustur : IhalematikBaseForm
    {
        public frm_MalzemeFiyatTeklifiOlustur()
        {
            InitializeComponent();
            base.ScreenMethod();
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