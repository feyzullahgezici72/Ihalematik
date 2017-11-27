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
using IhalematikProUI.Forms.Base;
using IhalematikProBL.Entity;
using IhalematikProBL.Provider;
using IhalematikProUI.Forms.Tedarikci;
using IhalematikPro.Forms;
using IhalematikPro.Manager;

namespace IhalematikProUI.Forms
{
    public partial class frm_TeklifListesi : IhalematikBaseForm
    {
        public frm_TeklifListesi()
        {
            InitializeComponent();
            base.ScreenMethod();

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_TeklifListesi_Load(object sender, EventArgs e)
        {

        }
        frm_TedarikcilereTeklifGonder teklifGonder;
        private void btnOpen_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int id = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewOffer.GetFocusedRowCellValue("Id"));

            CurrentManager.Instance.CurrentOffer = OfferProvider.Instance.GetItem(id);

            this.Close();
            frm_Anaform af = (frm_Anaform)Application.OpenForms["frm_Anaform"];
            af.RibonPasif();
            if (teklifGonder == null)
            {
                teklifGonder = new frm_TedarikcilereTeklifGonder();
                teklifGonder.MdiParent = (frm_Anaform)Application.OpenForms["frm_Anaform"];
                teklifGonder.FormClosed += new FormClosedEventHandler(TeklifGonder_FormClosed);
                af.MainPanel.Visible = false;
                teklifGonder.Show();
            }
            else
            {
                teklifGonder.Activate();
            }
        }

        private void TeklifGonder_FormClosed(object sender, FormClosedEventArgs e)
        {
            teklifGonder = null;
            frm_Anaform af = (frm_Anaform)Application.OpenForms["frm_Anaform"];
            af.RibonAktif();

        }

        private void frm_TeklifListesi_Shown(object sender, EventArgs e)
        {
            List<Offer> items = OfferProvider.Instance.GetItems();
            grdOffer.DataSource = items;
        }
    }
}