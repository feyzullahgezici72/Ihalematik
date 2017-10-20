﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using IhalematikProUI.Forms;
using IhalematikPro.Manager;
using IhalematikProBL.Provider;

namespace IhalematikPro.Forms
{
    public partial class frm_Anaform : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private const int CP_NOCLOSE_BUTTON = 0X200;// X buttonunu pasif yap
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;

            }
        }
        public frm_Anaform()
        {
            InitializeComponent();
        }

        private void frm_Anaform_Load(object sender, EventArgs e)
        {
            GlobalVeriablesManager.CurrentTender = TenderProvider.Instance.GetItem(160);
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barBtnCikis_ItemClick(object sender, ItemClickEventArgs e)
        {
            //radialMenu.HidePopup();
            Forms.frm_Cikis frm = new frm_Cikis();
            frm.ShowDialog();
        }

        private void barBtnFirmaTanimlama_ItemClick(object sender, ItemClickEventArgs e)
        {
            //radialMenu.HidePopup();
            Forms.frm_FirmaTanimlama frm = new frm_FirmaTanimlama();
            frm.ShowDialog();
        }

        private void barBtnDovizKurlari_ItemClick(object sender, ItemClickEventArgs e)
        {
            //radialMenu.HidePopup();
            Forms.frm_DovizKurlari frm = new frm_DovizKurlari();
            frm.ShowDialog();
        }

        Forms.frm_PozListesi pl;
        private void barBtnPozListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            //radialMenu.HidePopup();
            if (pl == null)
            {
                pl = new frm_PozListesi();
                pl.MdiParent = this;
                pl.FormClosed += new FormClosedEventHandler(Pl_FormClosed);
                pl.Show();
            }
            else
            {
                pl.Activate();
            }

        }

        private void Pl_FormClosed(object sender, FormClosedEventArgs e)
        {
            pl = null;
        }

        Forms.frm_OzelStokListesi osl;
        private void barBtnOzelStokListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            //radialMenu.HidePopup();
            if (osl == null)
            {
                osl = new frm_OzelStokListesi();
                osl.MdiParent = this;
                osl.FormClosed += new FormClosedEventHandler(Osl_FormClosed);
                osl.Show();
            }
            else
            {
                osl.Activate();
            }


        }

        private void Osl_FormClosed(object sender, FormClosedEventArgs e)
        {
            osl = null;
        }

        //public void AdimlarAktif()
        //{
        //    btnAdimx1.Enabled = true;
        //    btnAdimx2.Enabled = true;
        //    btnAdimx3.Enabled = true;
        //    btnAdimx4.Enabled = true;
        //    btnAdimx5.Enabled = true;

        //}
        private void barBtnTeklifHazirla_ItemClick(object sender, ItemClickEventArgs e)
        {
            Adimlar.Visible = true;
            //AdimlarPasif();
            frm_YeniIhaleYarat frm = new frm_YeniIhaleYarat();
            frm.ShowDialog();
        }
        Forms.frm_Teklif_Adim1 ta1;
        private void btnAdimx1_ItemClick(object sender, ItemClickEventArgs e)
        {
            //radialMenu.HidePopup();
            if (ta1 == null)
            {
                ta1 = new frm_Teklif_Adim1();
                ta1.MdiParent = this;
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
        }

        //Forms.frm_Teklif_Adim2 ta2;
        private void btnAdimx2_ItemClick(object sender, ItemClickEventArgs e)
        {

            //Forms.frm_Teklif_Adim2 ad2 = new frm_Teklif_Adim2();
            //ad2.ShowDialog();
            ////if (ta2==null)
            //{
            //    ta2 = new frm_Teklif_Adim2();
            //    ta2.MdiParent = this;
            //    ta2.FormClosed +=new FormClosedEventHandler(Ta2_FormClosed);
            //    ta2.Show();
            //}
            //else
            //{
            //    ta2.Activate();
            //}
        }

        //private void Ta2_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    ta2 = null;
        //}
        Forms.frm_CalisanTanimlama ct;
        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            //radialMenu.HidePopup();
            if (ct == null)
            {
                ct = new frm_CalisanTanimlama();
                ct.MdiParent = this;
                ct.FormClosed += new FormClosedEventHandler(Ct_FormClosed);
                ct.Show();
            }
            else
            {
                ct.Activate();
            }
        }

        private void Ct_FormClosed(object sender, FormClosedEventArgs e)
        {
            ct = null;
        }
        Forms.frm_Teklif_Adim3 ta3;
        private void btnAdimx3_ItemClick(object sender, ItemClickEventArgs e)
        {
            //radialMenu.HidePopup();
            if (ta3 == null)
            {
                ta3 = new frm_Teklif_Adim3();
                ta3.MdiParent = this;
                ta3.FormClosed += new FormClosedEventHandler(Ta3_FormClosed);
                ta3.Show();
            }
            else
            {
                ta3.Activate();
            }
        }

        private void Ta3_FormClosed(object sender, FormClosedEventArgs e)
        {
            ta3 = null;
        }

        Forms.frm_Teklif_Adim4 ta4;
        private void btnAdimx4_ItemClick(object sender, ItemClickEventArgs e)
        {
            //radialMenu.HidePopup();
            if (ta4 == null)
            {
                ta4 = new frm_Teklif_Adim4();
                ta4.MdiParent = this;
                ta4.FormClosed += new FormClosedEventHandler(Ta4_FormClosed);
                ta4.Show();
            }
            else
            {
                ta4.Activate();
            }
        }

        private void Ta4_FormClosed(object sender, FormClosedEventArgs e)
        {
            ta4 = null;
        }

        private void barBtnProgramHakkinda_ItemClick(object sender, ItemClickEventArgs e)
        {


        }

        private void backstageViewControl1_Click(object sender, EventArgs e)
        {

        }
        frm_AracTanimlama at;
        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            //radialMenu.HidePopup();
            if (at == null)
            {
                at = new frm_AracTanimlama();
                at.MdiParent = this;
                at.FormClosed += new FormClosedEventHandler(At_FormClosed);
                at.Show();
            }
            else
            {
                at.Activate();
            }
        }

        private void At_FormClosed(object sender, FormClosedEventArgs e)
        {
            at = null;
        }

        frm_DevamEdenIhaleListesi dei;
        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (dei == null)
            {
                dei = new frm_DevamEdenIhaleListesi();
                dei.MdiParent = this;
                dei.FormClosed += new FormClosedEventHandler(Dei_FormClosed);
                dei.Show();
            }
            else
            {
                dei.Activate();
            }
        }

        private void Dei_FormClosed(object sender, FormClosedEventArgs e)
        {
            dei = null;
        }

        private void pasif_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        frm_TedarikciTanimlama tt;

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (tt == null)
            {
                tt = new frm_TedarikciTanimlama();
                tt.MdiParent = this;
                tt.FormClosed += new FormClosedEventHandler(Tt_FormClosed);
                tt.Show();
            }
            else
            {
                tt.Activate();
            }
        }

        private void Tt_FormClosed(object sender, FormClosedEventArgs e)
        {
            tt = null;
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_YeniTeklifOlustur frm = new frm_YeniTeklifOlustur();
            frm.ShowDialog();
        }
        frm_TeklifListesi tl;
        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (tl == null)
            {
                tl = new frm_TeklifListesi();
                tl.MdiParent = this;
                tl.FormClosed += new FormClosedEventHandler(Tl_FormClosed);
                tl.Show();
            }
            else
            {
                tl.Activate();
            }
        }

        private void Tl_FormClosed(object sender, FormClosedEventArgs e)
        {
            tl = null;
        }
        frm_MalzemeFiyatTeklifiOlustur mfto;
        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {

            if (mfto == null)
            {
                mfto = new frm_MalzemeFiyatTeklifiOlustur();
                mfto.MdiParent = this;
                mfto.FormClosed += new FormClosedEventHandler(Mfto_FormClosed);
                mfto.Show();
            }
            else
            {
                mfto.Activate();
            }

        }

        private void Mfto_FormClosed(object sender, FormClosedEventArgs e)
        {
            mfto = null;
        }
        frm_TedarikcilerdenFiyatAl tfa;
        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (tfa == null)
            {
                tfa = new frm_TedarikcilerdenFiyatAl();
                tfa.MdiParent = this;
                tfa.FormClosed += new FormClosedEventHandler(Tfa_FormClosed);
                tfa.Show();
            }
            else
            {
                tfa.Activate();
            }

        }

        private void Tfa_FormClosed(object sender, FormClosedEventArgs e)
        {
            tfa = null;
        }
        frm_TeklifSonAdim ts;
        private void btnAdimx5_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (ts == null)
            {
                ts = new frm_TeklifSonAdim();
                ts.MdiParent = this;
                ts.FormClosed += new FormClosedEventHandler(Ts_FormClosed);
                ts.Show();
            }
            else
            {
                ts.Activate();
            }
        }

        private void Ts_FormClosed(object sender, FormClosedEventArgs e)
        {
            ts = null;
        }

        private void barButtonItem23_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Forms.frm_Cikis frm = new frm_Cikis();
            //frm.ShowDialog();
        }

        private void barButtonItem24_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem29_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barbtnCikisx_ItemClick(object sender, ItemClickEventArgs e)
        {
            Forms.frm_Cikis frm = new frm_Cikis();
            frm.ShowDialog();
        }
        PopupMenu pm;
        private void barButtonItem1_ItemClick_1(object sender, ItemClickEventArgs e)
        {


            popupMenu1.ShowPopup(Control.MousePosition);


        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void frm_Anaform_MaximumSizeChanged(object sender, EventArgs e)
        {
        }

        private void barButtonItem27_ItemClick(object sender, ItemClickEventArgs e)
        {
            Forms.frm_ProgramHakkinda ph = new frm_ProgramHakkinda();
            ph.ShowDialog();
        }

        private void barButtonItem23_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            Forms.frm_FirmaTanimlama frm = new frm_FirmaTanimlama();
            frm.ShowDialog();
        }

        private void frm_Anaform_Resize(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
                    this.WindowState = FormWindowState.Maximized;
            
        }
        
        

       

        private void frm_Anaform_ResizeEnd(object sender, EventArgs e)
        {

        }

        private void frm_Anaform_Move(object sender, EventArgs e)
        {
          
        }
    }
}