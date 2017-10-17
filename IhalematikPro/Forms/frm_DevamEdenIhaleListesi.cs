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

namespace IhalematikPro.Forms
{
    public partial class frm_DevamEdenIhaleListesi : DevExpress.XtraEditors.XtraForm
    {
        public frm_DevamEdenIhaleListesi()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_DevamEdenIhaleListesi_Load(object sender, EventArgs e)
        {
            List<Tender> list = TenderProvider.Instance.GetItems("IsActive", true);
            txtSumTender.Text = list.Count.ToString();
            grdActiveTenderList.DataSource = list;
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            List<Tender> list = TenderProvider.Instance.GetItems("IsActive", true);
            txtSumTender.Text = list.Count.ToString();
            grdActiveTenderList.DataSource = list;
            lblTenderCaptin.Text = "AKTİF İHALE LİSTESİ";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            List<Tender> list = TenderProvider.Instance.GetItems("IsActive", false);
            txtSumTender.Text = list.Count.ToString();
            grdActiveTenderList.DataSource = list;
            lblTenderCaptin.Text = "PAİF İHALE LİSTESİ";
        }
    }
}