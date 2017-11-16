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
using IhalematikPro.Forms;
using System.Threading;
using IhalematikProUI.Forms.Tedarikci;
using IhalematikProBL.Manager;
using IhalematikProBL.Entity;
using IhalematikProBL.Provider;
using IhalematikPro.Manager;

namespace IhalematikProUI.Forms
{
    public partial class frm_YeniTeklifOlustur : DevExpress.XtraEditors.XtraForm
    {
        public frm_YeniTeklifOlustur()
        {
            InitializeComponent();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        frm_TedarikcilereTeklifGonder tg;
        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            IsEmptyKontrol();
            for (int i = 0; i < 101; i++)
            {
                Thread.Sleep(0);
                pbControl.Position = i;
                Application.DoEvents();
            }
            this.Enabled = false;
            DialogResult resultMsg = MessageBox.Show("Yeni Teklif oluşturulsun mu?", "Yeni ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resultMsg.Equals(DialogResult.Yes))
            {
                Offer offer = new Offer();
                offer.Description = txtAciklama.Text.Trim();
                offer.IsActive = true;
                offer.Number = txtTeklifNo.Text;

                OfferProvider.Instance.Save(offer);
                CurrentManager.Instance.CurrentOffer = offer;

                pbControl.Visible = true;
                
                this.Enabled = false;
                for (int i = 0; i < 101; i++)
                {
                    Thread.Sleep(0);
                    pbControl.Position = i;
                    Application.DoEvents();
                }
                frm_MesajFormu mf = new frm_MesajFormu();
                mf.lblMesaj.Text = "Yeni Teklif Oluşturuldu...";
                mf.ShowDialog();
                this.Close();
                frm_TedarikcilereTeklifGonder tg = (frm_TedarikcilereTeklifGonder)Application.OpenForms["frm_TedarikcilereTeklifGonder"];
                frm_Anaform af = (frm_Anaform)Application.OpenForms["frm_Anaform"];
                if (tg == null)
                {
                    tg = new frm_TedarikcilereTeklifGonder();
                    tg.MdiParent = (frm_Anaform)Application.OpenForms["frm_Anaform"];
                    tg.FormClosed +=new FormClosedEventHandler( Tg_FormClosed);
                    af.MainPanel.Visible = false;
                    tg.Show();

                }
                else
                {
                    tg.Activate();
                }
                pbControl.Visible = false;
            }
        }

        private void Tg_FormClosed(object sender, FormClosedEventArgs e)
        {
            tg = null;
        }

        private void frm_YeniTeklifOlustur_Load(object sender, EventArgs e)
        {
            int lastOfferNumber = OfferManager.Instance.GetLastOfferNumber();
            txtTeklifNo.Text = string.Format("{0}", (lastOfferNumber + 1).ToString().PadLeft(8, '0'));
        }
        public bool IsEmptyKontrol()
        {
            if (string.IsNullOrEmpty(txtTeklifNo.Text.Trim()))
            {
                dxErrorProvider1.SetError(txtAciklama, "Açıklama boş bırakılamaz", DevExpress.XtraEditors.DXErrorProvider.ErrorType.User3);
                return true;
            }
            else
            {
                dxErrorProvider1.ClearErrors();
            }
            return false;
        }
    }
}