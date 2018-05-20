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
    public partial class frm_Takvim : DevExpress.XtraEditors.XtraForm
    {
        public frm_Takvim()
        {
            InitializeComponent();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Takvim_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ihalematikDBDataSet.Appointments' table. You can move, or remove it, as needed.
            this.appointmentsTableAdapter.Fill(this.ihalematikDBDataSet.Appointments);
            // TODO: This line of code loads data into the 'ihalematikDBDataSet.Appointments' table. You can move, or remove it, as needed.
            //this.appointmentsTableAdapter.Fill(this.ihalematikDBDataSet.Appointments);

        }
    }
}