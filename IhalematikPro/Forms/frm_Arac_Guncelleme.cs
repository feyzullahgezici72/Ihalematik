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

namespace IhalematikProUI.Forms
{
    public partial class frm_Arac_Guncelleme : DevExpress.XtraEditors.XtraForm
    {
        public frm_Arac_Guncelleme()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbCompanyVehicle_CheckedChanged(object sender, EventArgs e)
        {
            PanelSirket.Visible = true;
            PanelKira.Visible = false;
            PanelSirket.Location = new Point(13, 72);
        }

        private void rbAsgariUcret_CheckedChanged(object sender, EventArgs e)
        {
            PanelKira.Visible = true;
            PanelSirket.Visible = false;
            PanelKira.Location = new Point(13, 72);
        }
    }
}