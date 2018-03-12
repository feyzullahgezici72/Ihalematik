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

namespace IhalematikProUI.Forms.Ihale
{
    public partial class frm_IhaleKalanGun : DevExpress.XtraEditors.XtraForm
    {
        public frm_IhaleKalanGun()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_IhaleKalanGun_Load(object sender, EventArgs e)
        {
            List<Tender> list = TenderProvider.Instance.GetItems("IsActive", true);

            grdActiveTenderList.DataSource = list.Where(p => p.LastOfferDate == null || p.LastOfferDate.Value >= DateTime.Now).ToList();
        }
    }
}