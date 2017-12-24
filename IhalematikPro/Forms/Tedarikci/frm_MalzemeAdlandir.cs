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
    public partial class frm_MalzemeAdlandir : DevExpress.XtraEditors.XtraForm
    {
        public frm_MalzemeAdlandir()
        {
            InitializeComponent();
        }

        private void btnChangeName_Click(object sender, EventArgs e)
        {
            if (txtNewMeterialName.Text!=null)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen Malzeme Adını Belirtiniz...");
                txtNewMeterialName.Focus();
            }
        }

        private void frm_MalzemeAdlandir_Load(object sender, EventArgs e)
        {
         int uzunluk =int.Parse(txtNewMeterialName.Text.Length.ToString());
           
        }

        private void trcBar_EditValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}