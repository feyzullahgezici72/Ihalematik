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
using IhalematikProBL.Manager;
using IhalematikPro.Model;
using IhalematikPro.Manager;
using System.Threading;
using IhalematikProUI.Forms;
using IhalematikProUI.Manager;

namespace IhalematikProUI.Forms.Tedarikci
{
    public partial class frm_MailListesi : DevExpress.XtraEditors.XtraForm
    {
        public frm_MailListesi()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                bool isSuccess = UIReportManager.Instance.ExtractExcel(grdMailList);
                if (!isSuccess)
                {
                    MessageBox.Show("Hay Aksii!! \nProgram beklenmeyen bir hata ile karşılaştı.");
                }
            }
            catch (Exception ex)
            {
                LoggingManager.Instance.SaveErrorLog(ex);
            }
        }

        private void btnDetail_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frm_TedarikcilereMailleGonderilenMalzemeDetayi frm = new frm_TedarikcilereMailleGonderilenMalzemeDetayi();
            frm.ShowDialog();
        }
        private void LoadGridOffer()
        {
            List<Offer> offers = OfferProvider.Instance.GetItems();
            //offers.Where(p=> p.)
            grdMailList.DataSource = offers.Where(p => p.IsCompleated).ToList();
        }
        private void frm_MailListesi_Load(object sender, EventArgs e)
        {

        }

        private void frm_MailListesi_Shown(object sender, EventArgs e)
        {
   
            this.LoadGridOffer();
        }
    }
}