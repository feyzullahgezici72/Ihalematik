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
            lblTenderCaptin.Text = "AÇIK TEKLİF LİSTESİ";
            labelControl2.Text = "Açık Teklif Toplamı: ";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            List<Tender> list = TenderProvider.Instance.GetItems("IsActive", false);
            txtSumTender.Text = list.Count.ToString();
            grdActiveTenderList.DataSource = list;
            lblTenderCaptin.Text = "KAPALI TEKLİF LİSTESİ";
            labelControl2.Text = "Kapalı Teklif Toplamı: ";
        }

        private void btnIhaleAc_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            MessageBox.Show("Hazır Değil...");
        }

        private void grdActiveTenderList_Click(object sender, EventArgs e)
        {

        }

        private void btnIhaleAc_Click(object sender, EventArgs e)
        {
            int Id = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewActiveTenderList.GetFocusedRowCellValue("Id"));
            CurrentManager.CurrentTender = TenderProvider.Instance.GetItem(Id);
            this.Close();
        }
    }
}
