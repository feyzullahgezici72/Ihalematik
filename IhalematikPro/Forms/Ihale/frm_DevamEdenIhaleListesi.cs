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
using IhalematikProUI.Forms;

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
            lblRecordCount.Text = list.Count.ToString();
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
            //aktifler
           
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //pasifler
            
        }

        private void btnIhaleAc_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            MessageBox.Show("Hazır Değil...");
        }

        private void grdActiveTenderList_Click(object sender, EventArgs e)
        {

        }
        Forms.frm_Teklif_Adim1 ta1;
        private void btnIhaleAc_Click(object sender, EventArgs e)
        {
            int Id = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewActiveTenderList.GetFocusedRowCellValue("Id"));
            CurrentManager.Instance.CurrentTender = TenderProvider.Instance.GetItem(Id);
            this.Close();
            frm_Anaform af = (frm_Anaform)Application.OpenForms["frm_Anaform"];
            af.RibonPasif();
            if (ta1 == null)
            {
                ta1 = new frm_Teklif_Adim1();
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

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEdit1.SelectedIndex==0)
            {
                List<Tender> list = TenderProvider.Instance.GetItems("IsActive", true);
                lblRecordCount.Text = list.Count.ToString();
                grdActiveTenderList.DataSource = list;
                lblTenderCaptin.Text = "AÇIK TEKLİF LİSTESİ";
                 

            }
            if (comboBoxEdit1.SelectedIndex==1)
            {
                List<Tender> list = TenderProvider.Instance.GetItems("IsActive", false);
                lblRecordCount.Text = list.Count.ToString();
                grdActiveTenderList.DataSource = list;
                lblTenderCaptin.Text = "KAPALI TEKLİF LİSTESİ";
            }
            if (comboBoxEdit1.SelectedIndex == 2)
            {
                List<Tender> list = TenderProvider.Instance.GetItems();
                lblRecordCount.Text = list.Count.ToString();
                grdActiveTenderList.DataSource = list;
                lblTenderCaptin.Text = "TÜM TEKLİF LİSTESİ";
            }
        }

        private void btnDetay_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frm_IhaleBilgisiDetay ibd = new frm_IhaleBilgisiDetay();
            ibd.ShowDialog();

        }
    }
 }
    