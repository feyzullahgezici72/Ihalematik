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
using IhalematikProBL.Entity;
using IhalematikProBL.Provider;
using IhalematikPro.Manager;
using IhalematikPro.Forms;

namespace IhalematikProUI.Forms.Taseron
{
    public partial class frm_TasareIsListesi : DevExpress.XtraEditors.XtraForm
    {
        public frm_TasareIsListesi()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Forms.Taseron.frm_IhaleTasereEt ta1;
        private void btnJobberTenderAc_Click(object sender, EventArgs e)
        {
            int Id = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewActiveTenderList.GetFocusedRowCellValue("Id"));
            UICurrentManager.Instance.CurrentJobberTender = JobberTenderProvider.Instance.GetItem(Id);
            this.Close();
            frm_Anaform af = (frm_Anaform)Application.OpenForms["frm_Anaform"];
            af.ribbonPage7.Ribbon.SelectedPage = af.ribbonPage7;
            af.RibonPasif();
            if (ta1 == null)
            {
                ta1 = new frm_IhaleTasereEt();
                ta1.MdiParent = af;
                ta1.FormClosed += new FormClosedEventHandler(Ta1_FormClosed);
                ta1.Show();
            }
            else
            {
                ta1.Activate();
            }
        }

        private void Ta1_FormClosed(object sender, FormClosedEventArgs e)
        {
            ta1 = null;
            frm_Anaform af = (frm_Anaform)Application.OpenForms["frm_Anaform"];
            af.RibonAktif();
        }
        private void frm_TasareIsListesi_Shown(object sender, EventArgs e)
        {
            List<JobberTender> items = JobberTenderProvider.Instance.GetItems();

            grdActiveTenderList.DataSource = items;
        }
    }
}