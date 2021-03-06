﻿using System;
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
using DevExpress.LookAndFeel;
using IhalematikProUI.Manager;

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
            this.Enabled = false;
            DialogResult resultMsg = MessageBox.Show("Yeni Teklif oluşturulsun mu?              ", "Teklif Oluştur ",  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultMsg.Equals(DialogResult.Yes))
            {
                Offer offer = new Offer();
                offer.Description = txtAciklama.Text.Trim();
                offer.IsActive = true;
                offer.Number = txtTeklifNo.Text;
                offer.DateTime = DateTime.Parse(txtDateTime.Text);

                OfferProvider.Instance.Save(offer);
                UICurrentManager.Instance.CurrentOffer = offer;
                //frm_MesajFormu mf = new frm_MesajFormu();
                //mf.lblMesaj.Text = "Yeni Teklif Oluşturuldu...";
                //mf.ShowDialog();
                UIPopupManager.Instance.ShowPopup();
                this.Close();
                frm_Anaform af = (frm_Anaform)Application.OpenForms["frm_Anaform"];
                af.RibonPasif();
                af.barButtonItem14.PerformClick();
            }
        }

        private void Tg_FormClosed(object sender, FormClosedEventArgs e)
        {
            tg = null;
            frm_Anaform af = (frm_Anaform)Application.OpenForms["frm_Anaform"];
            af.RibonAktif();

        }

        private void frm_YeniTeklifOlustur_Load(object sender, EventArgs e)
        {
            int lastOfferNumber = OfferManager.Instance.GetLastOfferNumber();
            txtTeklifNo.Text = string.Format("{0}", (lastOfferNumber + 1).ToString().PadLeft(8, '0'));
            txtDateTime.DateTime = DateTime.Now;
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

        private void frm_YeniTeklifOlustur_Shown(object sender, EventArgs e)
        {
            txtAciklama.Focus();
        }
    }
}