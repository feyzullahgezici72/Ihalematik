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
using DevExpress.XtraBars.Helpers;
using IhalematikProUI.Forms;
using IhalematikPro.Manager;
using IhalematikProBL.Provider;
using IhalematikProBL.Entity;
using IhalematikProUI.Forms.Tedarikci;
using IhalematikProUI.Forms.Genel;
using IhalematikProUI.Forms.IhaleAdim;
using IhalematikProUI.Forms.Ihale;
using IhalematikProBL.Provider;
using IhalematikProUI.Hakedis;
using IhalematikProUI.Forms.Taseron;
using DevExpress.XtraBars.Docking;
using DevExpress.Xpf.Core.Native;
using Tulpep.NotificationWindow;
using IhalematikProUI.Manager;

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

        public void logoOrtala()
        {
            if (UICurrentManager.Instance.CurrentCompany != null)
            {
                if (UICurrentManager.Instance.CurrentCompany.LogoWidth != 0)
                {
                    picLogo.Width = UICurrentManager.Instance.CurrentCompany.LogoWidth;
                }
                if (UICurrentManager.Instance.CurrentCompany.LogoHeight != 0)
                {
                    picLogo.Height = UICurrentManager.Instance.CurrentCompany.LogoHeight;
                }
            }

            picLogo.Left = (pnlAna.Width / 2) - (picLogo.Width / 2);
            picLogo.Top = (pnlAna.Height / 2) - (picLogo.Height / 2);
            }
        public void frm_Anaform_Load(object sender, EventArgs e)
        {
            DevExpress.UserSkins.BonusSkins.Register();
            this.WindowState = FormWindowState.Maximized;
            this.LoadLogo();
            if (UICurrentManager.Instance.CurrentMember != null && !string.IsNullOrEmpty(UICurrentManager.Instance.CurrentMember.UserName))
            {
                UserName.Caption = UICurrentManager.Instance.CurrentMember.UserName.ToString(); 
            }

        }

        public void LoadLogo()
        {
            logoOrtala();
            if (UICurrentManager.Instance.CurrentCompany != null)
            {
                lblCompanyName.Text = UICurrentManager.Instance.CurrentCompany.Name;
                if (!string.IsNullOrEmpty(UICurrentManager.Instance.CurrentCompany.LogoPath))
                {
                    //string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                    //picLogo.Image = Image.FromFile(path + "\\ihalematik\\EmailFile\\Images\\Logo\\" + CurrentManager.Instance.CurrentCompany.LogoPath);
                    string path = string.Empty;
                    if (Application.StartupPath.Contains("bin\\Debug"))
                    {
                        path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                    }
                    else
                    {
                        path = Application.StartupPath.Substring(0, (Application.StartupPath.Length));
                    }
                    try
                    {
                        picLogo.Image = Image.FromFile(path + "\\EmailFile\\Images\\Logo\\" + UICurrentManager.Instance.CurrentCompany.LogoPath);
                    }
                    catch (Exception)
                    {
                        
                    }
                }
                else
                {
                    picLogo.Image = null;
                }
            }
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
            Forms.frm_FirmaTanimlama frm = new frm_FirmaTanimlama(this);
            frm.ShowDialog();
        }

        private void barBtnDovizKurlari_ItemClick(object sender, ItemClickEventArgs e)
        {
            //radialMenu.HidePopup();

        }

        Forms.frm_PozListesi pl;
        private void barBtnPozListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            barBtnPozListesi.ButtonStyle = BarButtonStyle.Check;
            RibonPasif();

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
            RibonAktif();
            barBtnPozListesi.ButtonStyle = BarButtonStyle.Default;
        }

        Forms.frm_OzelStokListesi osl;
        private void barBtnOzelStokListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            barBtnOzelStokListesi.ButtonStyle = BarButtonStyle.Check;
            RibonPasif();

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
            RibonAktif();
            barBtnOzelStokListesi.ButtonStyle = BarButtonStyle.Default;
        }


        private void barBtnTeklifHazirla_ItemClick(object sender, ItemClickEventArgs e)
        {
            barBtnTeklifHazirla.ButtonStyle = BarButtonStyle.Check;
            frm_YeniIhaleYarat frm = new frm_YeniIhaleYarat();
            frm.ShowDialog();
            barBtnTeklifHazirla.ButtonStyle = BarButtonStyle.Default;

        }
        Forms.frm_Teklif_Adim1 ta1;
        private void btnAdimx1_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (UICurrentManager.Instance.CurrentTender != null)
            {
                btnAdimx1.ButtonStyle = BarButtonStyle.Check;
                RibonPasif();
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
            else
            {
                btnAdimx1.ButtonStyle = BarButtonStyle.Default;
                frm_MesajFormu mf = new frm_MesajFormu();
                mf.lblMesaj.Text = "Aktif bir İhale Bulunamadı\n Yeni bir İhale oluşturun yada \n Raporlar Menüsünden bir İhale açın.";
                mf.ShowDialog();
            }

        }


        private void Ta1_FormClosed(object sender, FormClosedEventArgs e)
        {
            ta1 = null;
            RibonAktif();
            btnAdimx1.ButtonStyle = BarButtonStyle.Default;
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
            barButtonItem2.ButtonStyle = BarButtonStyle.Check;
            RibonPasif();
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
            RibonAktif();
            barButtonItem2.ButtonStyle = BarButtonStyle.Default;
        }
        Forms.frm_Teklif_Adim3 ta3;
        private void btnAdimx3_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (UICurrentManager.Instance.CurrentTender != null)
            {
                btnAdimx3.ButtonStyle = BarButtonStyle.Check;
                RibonPasif();
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
            else
            {
                btnAdimx3.ButtonStyle = BarButtonStyle.Default;
                frm_MesajFormu mf = new frm_MesajFormu();
                mf.lblMesaj.Text = "Aktif bir İhale Bulunamadı\n Yeni bir İhale oluşturun yada \n Raporlar Menüsünden bir İhale açın.";
                mf.ShowDialog();
            }
        }

        private void Ta3_FormClosed(object sender, FormClosedEventArgs e)
        {
            ta3 = null;
            RibonAktif();
            btnAdimx3.ButtonStyle = BarButtonStyle.Default;
        }

        Forms.frm_Teklif_Adim2 ta4;
        private void btnAdimx4_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (UICurrentManager.Instance.CurrentTender != null && UICurrentManager.Instance.CurrentTender.MaterialList != null && UICurrentManager.Instance.CurrentTender.MaterialList.Count != 0)
            {
                btnAdimx4.ButtonStyle = BarButtonStyle.Check;
                RibonPasif();
                if (ta4 == null)
                {
                    ta4 = new frm_Teklif_Adim2();
                    ta4.MdiParent = this;
                    ta4.FormClosed += new FormClosedEventHandler(Ta4_FormClosed);
                    ta4.Show();
                }
                else
                {
                    ta4.Activate();
                }
            }
            else
            {
                btnAdimx4.ButtonStyle = BarButtonStyle.Default;
                frm_MesajFormu mf = new frm_MesajFormu();
                mf.lblMesaj.Text = "Aktif bir İhale Bulunamadı\n Yeni bir İhale oluşturun yada \n Raporlar Menüsünden bir İhale açın.";
                mf.ShowDialog();
            }
        }

        private void Ta4_FormClosed(object sender, FormClosedEventArgs e)
        {
            ta4 = null;
            RibonAktif();
            btnAdimx4.ButtonStyle = BarButtonStyle.Default;
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
            barButtonItem4.ButtonStyle = BarButtonStyle.Check;
            RibonPasif();
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
            RibonAktif();
            barButtonItem4.ButtonStyle = BarButtonStyle.Default;
        }

        frm_DevamEdenIhaleListesi dei;
        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            barButtonItem6.ButtonStyle = BarButtonStyle.Check;
            RibonPasif();
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
            RibonAktif();
            barButtonItem6.ButtonStyle = BarButtonStyle.Default;
        }

        private void pasif_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        frm_TedarikciTanimlama tt;

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            barButtonItem10.ButtonStyle = BarButtonStyle.Check;
            RibonPasif();
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
            RibonAktif();
            barButtonItem10.ButtonStyle = BarButtonStyle.Default;
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            barButtonItem12.ButtonStyle = BarButtonStyle.Check;
            frm_YeniTeklifOlustur frm = new frm_YeniTeklifOlustur();
            frm.ShowDialog();
            barButtonItem12.ButtonStyle = BarButtonStyle.Default;
        }
        frm_TeklifListesi tl;
        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            barButtonItem13.ButtonStyle = BarButtonStyle.Check;
            RibonPasif();
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
            RibonAktif();
            barButtonItem13.ButtonStyle = BarButtonStyle.Default;
        }
        frm_TedarikcilerdenFiyatAl tfa;
        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (UICurrentManager.Instance.CurrentOffer != null && UICurrentManager.Instance.CurrentOffer.MaterialList != null)
            {
                barButtonItem15.ButtonStyle = BarButtonStyle.Check;
                RibonPasif();
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
            else
            {
                barButtonItem15.ButtonStyle = BarButtonStyle.Default;
                frm_MesajFormu mf = new frm_MesajFormu();
                mf.lblMesaj.Text = "Aktif bir Teklif Bulunamadı\n Yeni bir teklif oluşturun yada \n Raporlar Menüsünden bir teklif açın.";
                mf.ShowDialog();
            }
        }

        private void Tfa_FormClosed(object sender, FormClosedEventArgs e)
        {
            tfa = null;
            RibonAktif();
            barButtonItem15.ButtonStyle = BarButtonStyle.Default;
        }
        frm_TeklifAdimSon ts;
        private void btnAdimx5_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (UICurrentManager.Instance.CurrentTender != null)
            {
                btnAdimx5.ButtonStyle = BarButtonStyle.Check;
                RibonPasif();
                if (ts == null)
                {
                    ts = new frm_TeklifAdimSon();
                    ts.MdiParent = this;
                    ts.FormClosed += new FormClosedEventHandler(Ts_FormClosed);
                    ts.Show();
                }
                else
                {
                    ts.Activate();
                }
            }
            else
            {
                btnAdimx5.ButtonStyle = BarButtonStyle.Default;
                frm_MesajFormu mf = new frm_MesajFormu();
                mf.lblMesaj.Text = "Aktif bir İhale Bulunamadı\n Yeni bir İhale oluşturun yada \n Raporlar Menüsünden bir İhale açın.";
                mf.ShowDialog();
            }
        }

        private void Ts_FormClosed(object sender, FormClosedEventArgs e)
        {
            ts = null;
            RibonAktif();
            btnAdimx5.ButtonStyle = BarButtonStyle.Default;
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
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }


        private void barButtonItem27_ItemClick(object sender, ItemClickEventArgs e)
        {
            Forms.frm_ProgramHakkinda ph = new frm_ProgramHakkinda();
            ph.ShowDialog();
        }

        private void barButtonItem23_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            Forms.frm_FirmaTanimlama frm = new frm_FirmaTanimlama(this);
            frm.ShowDialog();
        }

        private void frm_Anaform_Resize(object sender, EventArgs e)
        {
            //if (this.WindowState != FormWindowState.Minimized)
            //        this.WindowState = FormWindowState.Maximized;

        }





        private void frm_Anaform_ResizeEnd(object sender, EventArgs e)
        {

        }

        private void frm_Anaform_Move(object sender, EventArgs e)
        {

        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void frm_Anaform_Deactivate(object sender, EventArgs e)
        {
            //ribbon.Enabled = false;
        }

        private void frm_Anaform_Activated(object sender, EventArgs e)
        {
           
        }

        public void RibonAktif()
        {
            ribbon.Enabled = true;
            MainPanel.Visible = true;
            dockPanel1.Enabled = true;
        }
        public void RibonPasif()
        {
            MainPanel.Visible = false;
            ribbon.Enabled = false;
            dockPanel1.Enabled = false;
        }
        private void barButtonItem2_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            //childForm.ShowDialog(this);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Money Twins"; //"Money Twins"; //"Lilian";
            DevExpress.Skins.SkinManager.EnableFormSkins();
            Application.EnableVisualStyles();
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Lilian";
            DevExpress.Skins.SkinManager.EnableFormSkins();
            Application.EnableVisualStyles();
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "iMaginary"; //
            DevExpress.Skins.SkinManager.EnableFormSkins();
            Application.EnableVisualStyles();
        }

        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Caramel";
            DevExpress.Skins.SkinManager.EnableFormSkins();
            Application.EnableVisualStyles();
        }

        private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Office 2007 Green"; //London Liquid Sky
            DevExpress.Skins.SkinManager.EnableFormSkins();
            Application.EnableVisualStyles();
        }

        private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_IhaleKalanGun kg = new frm_IhaleKalanGun();
            kg.ShowDialog();

        }

        private void barButtonItem19_ItemClick(object sender, ItemClickEventArgs e)
        {

            frm_Kurallistesi kl = new frm_Kurallistesi();
            kl.ShowDialog();
        }

        private void barButtonItem20_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_GenelBilgiler gb = new frm_GenelBilgiler();
            gb.ShowDialog();
        }

        private void barButtonItem21_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem22_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //lblDate.Caption = DateTime.Now.ToLongDateString();
            //lblTime.Caption= DateTime.Now.ToLongTimeString();
        }

        private void barBtnDovizKurlar_ItemClick(object sender, ItemClickEventArgs e)
        {
            barBtnDovizKurlar.ButtonStyle = BarButtonStyle.Check;
            Forms.frm_DovizKurlari frm = new frm_DovizKurlari();
            frm.ShowDialog();
            barBtnDovizKurlar.ButtonStyle = BarButtonStyle.Default;
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            //lblHatirlatma.Top = lblHatirlatma.Top - 1;
            //if (lblHatirlatma.Top<-lblHatirlatma.Height)
            //{
            //    lblHatirlatma.Top = groupControl1.Height; 
            //}
        }

        private void groupControl2_Click(object sender, EventArgs e)
        {
            Forms.frm_FirmaTanimlama frm = new frm_FirmaTanimlama(this);
            frm.ShowDialog();
        }

        private void panelControl1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dockPanel1.Width > 100)
            {
                dockPanel1.HideSliding();
            }
            else
            {
                dockPanel1.ShowSliding();
            }


        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void skinRibbonGalleryBarItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void skin_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        frm_TedarikcilereTeklifGonder tg;
        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (UICurrentManager.Instance.CurrentOffer != null && UICurrentManager.Instance.CurrentOffer.MaterialList != null)
            {
                frm_Anaform af = (frm_Anaform)Application.OpenForms["frm_Anaform"];
                if (tg == null)
                {
                    barButtonItem14.ButtonStyle = BarButtonStyle.Check;
                    RibonPasif();
                    tg = new frm_TedarikcilereTeklifGonder();
                    tg.MdiParent = (frm_Anaform)Application.OpenForms["frm_Anaform"];
                    tg.FormClosed += new FormClosedEventHandler(Tg_FormClosed);
                    af.MainPanel.Visible = false;
                    tg.Show();

                }
                else
                {
                    tg.Activate();
                }

            }
            else
            {
                barButtonItem14.ButtonStyle = BarButtonStyle.Default;
                frm_MesajFormu mf = new frm_MesajFormu();
                mf.lblMesaj.Text = "Aktif bir Teklif Bulunamadı\n Yeni bir teklif oluşturun yada \n Raporlar Menüsünden bir teklif açın.";
                mf.ShowDialog();
            }

        }

        private void Tg_FormClosed(object sender, FormClosedEventArgs e)
        {
            tg = null;
            RibonAktif();
            barButtonItem14.ButtonStyle = BarButtonStyle.Default;
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picLogo_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {

        }

        private void frm_Anaform_Shown(object sender, EventArgs e)
        {
            picLogo.Visible = true;
            DateTime tarih = DateTime.Now;    
            string format = "dd.MM.yyyy";  
            txtDate.Caption= (tarih.ToString(format));
        }
        frm_TeklifAktar teklifAktar;
        private void barButtonItem28_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (UICurrentManager.Instance.CurrentOffer != null && UICurrentManager.Instance.CurrentOffer.MaterialList != null)
            {
                barButtonItem28.ButtonStyle = BarButtonStyle.Check;
                RibonPasif();
                if (teklifAktar == null)
                {
                    teklifAktar = new frm_TeklifAktar();
                    teklifAktar.MdiParent = this;
                    teklifAktar.FormClosed += new FormClosedEventHandler(TeklifAktar_FormClosed);
                    teklifAktar.Show();
                }
                else
                {
                    teklifAktar.Activate();
                }
            }
            else
            {
                barButtonItem28.ButtonStyle = BarButtonStyle.Default;
                frm_MesajFormu mf = new frm_MesajFormu();
                mf.lblMesaj.Text = "Aktif bir Teklif Bulunamadı\n Yeni bir teklif oluşturun yada \n Raporlar Menüsünden bir teklif açın.";
                mf.ShowDialog();
            }

        }

        private void TeklifAktar_FormClosed(object sender, FormClosedEventArgs e)
        {
            teklifAktar = null;
            RibonAktif();
            barButtonItem28.ButtonStyle = BarButtonStyle.Default;
        }

        private void barButtonItem21_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            frm_ProgramiGuncelle pg = new frm_ProgramiGuncelle();
            pg.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem25_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem24_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            frm_LoginGuncelle lg = new frm_LoginGuncelle();
            lg.ShowDialog();
        }

        private void barButtonItem7_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            frm_ProgramiGuncelle pg = new frm_ProgramiGuncelle();
            pg.ShowDialog();
        }

        private void barButtonItem29_ItemClick_1(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem39_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_Kurallistesi kl = new frm_Kurallistesi();
            kl.ShowDialog();
        }

        private void barButtonItem30_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_LoginGuncelle lg = new frm_LoginGuncelle();
            lg.ShowDialog();
        }

        private void barButtonItem31_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem32_ItemClick(object sender, ItemClickEventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Office 2010 Blue"; //""; //"Lilian";
            DevExpress.Skins.SkinManager.EnableFormSkins();
            Application.EnableVisualStyles();
        }

        private void barButtonItem33_ItemClick(object sender, ItemClickEventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Lilian";
            DevExpress.Skins.SkinManager.EnableFormSkins();
            Application.EnableVisualStyles();
        }

        private void barButtonItem34_ItemClick(object sender, ItemClickEventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "iMaginary"; //Office 2007 Blue
            DevExpress.Skins.SkinManager.EnableFormSkins();
            Application.EnableVisualStyles();
        }

        private void barButtonItem36_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem38_ItemClick(object sender, ItemClickEventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = " Office 2010 Green"; //London Liquid Sky
            DevExpress.Skins.SkinManager.EnableFormSkins();
            Application.EnableVisualStyles();
        }

        private void barButtonItem19_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            Forms.frm_FirmaTanimlama frm = new frm_FirmaTanimlama(this);
            frm.ShowDialog();
        }

        private void barButtonItem21_ItemClick_2(object sender, ItemClickEventArgs e)
        {
            //if (pnIhaleListesi.Visible == false)
            //{
            //    pnIhaleListesi.Visible = true;
            //    barButtonItem18.ButtonStyle = BarButtonStyle.Check;
            //}
            //else
            //{
            //    pnIhaleListesi.Visible = false;
            //    barButtonItem18.ButtonStyle = BarButtonStyle.Default;
            //}
        }

        private void barButtonItem25_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            Forms.frm_ProgramHakkinda ph = new frm_ProgramHakkinda();
            ph.ShowDialog();
        }

        private void barButtonItem24_ItemClick_2(object sender, ItemClickEventArgs e)
        {
            frm_GenelBilgiler gb = new frm_GenelBilgiler();
            gb.ShowDialog();
        }

        private void barButtonItem42_ItemClick(object sender, ItemClickEventArgs e)
        {
            Forms.frm_Cikis frm = new frm_Cikis();
            frm.ShowDialog();
        }

        private void barButtonItem1_ItemClick_2(object sender, ItemClickEventArgs e)
        {
            frm_Duyurular duyurular = new frm_Duyurular();
            duyurular.ShowDialog();
        }
        frm_BirimFiyatHistory bfh;
        private void barButtonItem43_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (UICurrentManager.Instance.CurrentTender != null)
            {
                barButtonItem43.ButtonStyle = BarButtonStyle.Check;
                RibonPasif();
                if (bfh == null)
                {
                    bfh = new frm_BirimFiyatHistory();
                    bfh.MdiParent = this;
                    bfh.FormClosed += new FormClosedEventHandler(Bfh_FormClosed);
                    bfh.Show();
                }
                else
                {
                    bfh.Activate();
                }
            }
            else
            {
                barButtonItem43.ButtonStyle = BarButtonStyle.Default;
                frm_MesajFormu mf = new frm_MesajFormu();
                mf.lblMesaj.Text = "Aktif bir İhale Bulunamadı\n Yeni bir İhale oluşturun yada \n Raporlar Menüsünden bir İhale açın.";
                mf.ShowDialog();
            }
        }

        private void Bfh_FormClosed(object sender, FormClosedEventArgs e)
        {
            bfh = null;
            RibonAktif();
            barButtonItem43.ButtonStyle = BarButtonStyle.Default;
        }

        private void barButtonItem31_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            frm_LogoAyarları logo = new frm_LogoAyarları(this);
            logo.ShowDialog();
        }

        private void barStaticItem6_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        frm_MailListesi ml;
        private void barButtonItem44_ItemClick(object sender, ItemClickEventArgs e)
        {
            barButtonItem44.ButtonStyle = BarButtonStyle.Check;
            RibonPasif();
            if (ml == null)
            {
                ml = new frm_MailListesi();
                ml.MdiParent = this;
                ml.FormClosed += new FormClosedEventHandler(Ml_FormClosed);
                ml.Show();
            }
            else
            {
                ml.Activate();
            }
        }

        private void Ml_FormClosed(object sender, FormClosedEventArgs e)
        {
            ml = null;
            RibonAktif();
            barButtonItem44.ButtonStyle = BarButtonStyle.Default;
        }
        frm_KarsilastirmadaSecilenFirmaUrunListesi ufl;
        private void barButtonItem45_ItemClick(object sender, ItemClickEventArgs e)
        {
            barButtonItem45.ButtonStyle = BarButtonStyle.Check;
            RibonPasif();
            if (ufl == null)
            {
                ufl = new frm_KarsilastirmadaSecilenFirmaUrunListesi();
                ufl.MdiParent = this;
                ufl.FormClosed += new FormClosedEventHandler(Ufl_FormClosed);
                ufl.Show();
            }
            else
            {
                ufl.Activate();
            }
        }

        private void Ufl_FormClosed(object sender, FormClosedEventArgs e)
        {
            ufl = null;
            RibonAktif();
            barButtonItem45.ButtonStyle = BarButtonStyle.Default;
        }
        frm_Mybrowser myB;
        private void barButtonItem46_ItemClick(object sender, ItemClickEventArgs e)
        {
            barButtonItem46.ButtonStyle = BarButtonStyle.Check;
            RibonPasif();
            if (myB == null)
            {
                myB = new frm_Mybrowser();
                myB.MdiParent = this;
                myB.FormClosed += new FormClosedEventHandler(MyB_FormClosed);
                myB.Show();
            }
            else
            {
                myB.Activate();
            }
        }

        private void MyB_FormClosed(object sender, FormClosedEventArgs e)
        {
            myB = null;
            RibonAktif();
            barButtonItem46.ButtonStyle = BarButtonStyle.Default;
        }

        private void barButtonItem49_ItemClick(object sender, ItemClickEventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "The Asphalt World"; //London Liquid Sky
            DevExpress.Skins.SkinManager.EnableFormSkins();
            Application.EnableVisualStyles();
        }

        private void ribbon_ApplicationButtonClick(object sender, EventArgs e)
        {
            frm_ProgramiGuncelle pg = new frm_ProgramiGuncelle();
            pg.ShowDialog();
        }
        frm_SozlesmeBilgileriFormu sbf;
        private void barSozlesmeBilgileri_ItemClick(object sender, ItemClickEventArgs e)
        {
            barSozlesmeBilgileri.ButtonStyle = BarButtonStyle.Check;
            RibonPasif();
            if (sbf == null)
            {
                sbf = new frm_SozlesmeBilgileriFormu();
                sbf.MdiParent = this;
                sbf.FormClosed +=new FormClosedEventHandler(Sbf_FormClosed);
                sbf.Show();
            }
            else
            {
                sbf.Activate();
            }
        }

        private void Sbf_FormClosed(object sender, FormClosedEventArgs e)
        {
            sbf = null;
            RibonAktif();
            barSozlesmeBilgileri.ButtonStyle = BarButtonStyle.Default;
        }
        private void barSozlesmeMiktarlari_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        

        frm_OdenekDilimleriFormu odf;
        private void barOdenekDilimleri_ItemClick(object sender, ItemClickEventArgs e)
        {
            barOdenekDilimleri.ButtonStyle = BarButtonStyle.Check;
            RibonPasif();
            if (odf == null)
            {
                odf = new  frm_OdenekDilimleriFormu();
                odf.MdiParent = this;
                odf.FormClosed +=new FormClosedEventHandler(Odf_FormClosed);
                odf.Show();
            }
            else
            {
                odf.Activate();
            }
        }

        private void Odf_FormClosed(object sender, FormClosedEventArgs e)
        {
            odf = null;
            RibonAktif();
            barOdenekDilimleri.ButtonStyle = BarButtonStyle.Default;
        }
        frm_SozlesmeKalemleri sk;
        private void barSozlesmeKalemleri_ItemClick(object sender, ItemClickEventArgs e)
        {
            barSozlesmeKalemleri.ButtonStyle = BarButtonStyle.Check;
            RibonPasif();
            if (sk == null)
            {
                sk = new frm_SozlesmeKalemleri();
                sk.MdiParent = this;
                sk.FormClosed += new FormClosedEventHandler(Sk_FormClosed);
                sk.Show();
            }
            else
            {
                sk.Activate();
            }
        }
        private void Sk_FormClosed(object sender, FormClosedEventArgs e)
        {
            sk = null;
            RibonAktif();
            barSozlesmeKalemleri.ButtonStyle = BarButtonStyle.Default;
        }

        private void barButtonItem50_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_KurListele kl = new frm_KurListele();
            kl.ShowDialog();
        }
        frm_TaseronTanimlama tsr;
        private void barButtonItem51_ItemClick(object sender, ItemClickEventArgs e)
        {
            barButtonItem51.ButtonStyle = BarButtonStyle.Check;
            RibonPasif();
            if (tsr == null)
            {
                tsr = new frm_TaseronTanimlama();
                tsr.MdiParent = this;
                tsr.FormClosed +=new FormClosedEventHandler(Tsr_FormClosed);
                tsr.Show();
            }
            else
            {
                tsr.Activate();
            }
        }

        private void Tsr_FormClosed(object sender, FormClosedEventArgs e)
        {
            tsr = null;
            RibonAktif();
            barButtonItem51.ButtonStyle = BarButtonStyle.Default;
        }
        frm_YeniTasereIsYarat tsrEt;
        private void barButtonItem52_ItemClick(object sender, ItemClickEventArgs e)
        {
            barButtonItem52.ButtonStyle = BarButtonStyle.Check;
            RibonPasif();
            if (tsrEt == null)
            {
                tsrEt = new frm_YeniTasereIsYarat();
                tsrEt.MdiParent = this;
                tsrEt.FormClosed +=new FormClosedEventHandler(TsrEt_FormClosed);
                tsrEt.Show();
            }
            else
            {
                tsrEt.Activate();
            }
        }

        private void TsrEt_FormClosed(object sender, FormClosedEventArgs e)
        {
            tsrEt = null;
            RibonAktif();
            barButtonItem52.ButtonStyle = BarButtonStyle.Default;
        }

        private void hideContainerLeft_Click(object sender, EventArgs e)
        {
           
        }


        private void navBarControl1_Click(object sender, EventArgs e)
        {
            
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            dockPanel1.HideSliding();
            barButtonItem4.PerformClick();
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            dockPanel1.HideSliding();
            barButtonItem2.PerformClick();
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            dockPanel1.HideSliding();
            barButtonItem10.PerformClick();
        }

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            dockPanel1.HideSliding();
            barButtonItem51.PerformClick();
        }

        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            dockPanel1.HideSliding();
            barBtnPozListesi.PerformClick();
        }

        private void navBarItem6_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            dockPanel1.HideSliding();
            barBtnOzelStokListesi.PerformClick();
        }

        private void navBarItem7_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            dockPanel1.HideSliding();
            barBtnDovizKurlar.PerformClick();
        }

        private void navBarItem8_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            dockPanel1.HideSliding();
            barButtonItem12.PerformClick();
        }

        private void navBarItem9_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            dockPanel1.HideSliding();
            barButtonItem14.PerformClick();
        }

        private void navBarItem10_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            dockPanel1.HideSliding();
            barButtonItem28.PerformClick();
        }

        private void navBarItem11_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            dockPanel1.HideSliding();
            barButtonItem15.PerformClick();
        }

        private void navBarItem12_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            dockPanel1.HideSliding();
            barButtonItem45.PerformClick();
        }

        private void navBarItem13_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            dockPanel1.HideSliding();
            barBtnTeklifHazirla.PerformClick();
        }

        private void navBarItem14_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            dockPanel1.HideSliding();
            btnAdimx1.PerformClick();
        }

        private void navBarItem15_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            dockPanel1.HideSliding();
            btnAdimx4.PerformClick();
        }

        private void navBarItem16_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            dockPanel1.HideSliding();
            btnAdimx3.PerformClick();
        }

        private void navBarItem17_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            dockPanel1.HideSliding();
            btnAdimx5.PerformClick();
        }

        private void navBarItem18_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            dockPanel1.HideSliding();
            barButtonItem52.PerformClick();
        }

        private void navBarItem19_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            dockPanel1.HideSliding();
            barButtonItem43.PerformClick();
        }

        private void navBarItem20_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            dockPanel1.HideSliding();
            barButtonItem13.PerformClick();
        }

        private void navBarItem21_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            dockPanel1.HideSliding();
            barButtonItem6.PerformClick();
        }

        private void navBarItem22_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            dockPanel1.HideSliding();
            barButtonItem50.PerformClick();
        }

        private void navBarItem23_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            dockPanel1.HideSliding();
            barButtonItem7.PerformClick();
        }

        private void navBarItem24_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            dockPanel1.HideSliding();
            barButtonItem39.PerformClick();
        }

        private void navBarItem25_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            dockPanel1.HideSliding();
            barButtonItem30.PerformClick();
        }

        private void navBarItem26_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            dockPanel1.HideSliding();
            barButtonItem31.PerformClick();
        }

        private void ribbon_MouseMove(object sender, MouseEventArgs e)
        {
            if (dockPanel1.Width > 100)
            {
                dockPanel1.HideSliding();
            }
            else
            {
                dockPanel1.ShowSliding();
            }

        }

        private void hideContainerLeft_Click_1(object sender, EventArgs e)
        {
           
        }

        private void navBarItem27_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            dockPanel1.HideSliding();
            barButtonItem42.PerformClick();
        }
        frm_IhaleTasereEt tsrEtx;
        private void barButtonItem53_ItemClick(object sender, ItemClickEventArgs e)
        {
            barButtonItem53.ButtonStyle = BarButtonStyle.Check;
            RibonPasif();
            if (tsrEtx == null)
            {
                tsrEtx = new frm_IhaleTasereEt();
                tsrEtx.MdiParent = this;
                tsrEtx.FormClosed +=new FormClosedEventHandler(TsrEtx_FormClosed);
                tsrEtx.Show();
            }
            else
            {
                tsrEtx.Activate();
            }
        }

        private void TsrEtx_FormClosed(object sender, FormClosedEventArgs e)
        {
            tsrEtx = null;
            RibonAktif();
            barButtonItem53.ButtonStyle = BarButtonStyle.Default;
        }
        frm_TasareIsListesi tsrEtl;
        private void barButtonItem54_ItemClick(object sender, ItemClickEventArgs e)
        {
            barButtonItem54.ButtonStyle = BarButtonStyle.Check;
            RibonPasif();
            if (tsrEtl == null)
            {
                tsrEtl = new frm_TasareIsListesi();
                tsrEtl.MdiParent = this;
                tsrEtl.FormClosed += new FormClosedEventHandler(TsrEtl_FormClosed);
                tsrEtl.Show();
            }
            else
            {
                tsrEtl.Activate();
            }
        }
        private void TsrEtl_FormClosed(object sender, FormClosedEventArgs e)
        {
            tsrEtl = null;
            RibonAktif();
            barButtonItem54.ButtonStyle = BarButtonStyle.Default;
        }

        private void navBarItem28_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            dockPanel1.HideSliding();
            barButtonItem52.PerformClick();
        }

        private void navBarItem29_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            dockPanel1.HideSliding();
            barButtonItem53.PerformClick();
        }

        private void navBarItem30_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            dockPanel1.HideSliding();
            barButtonItem54.PerformClick();
        }

        private void barButtonItem40_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_IsTakvimi tk = new frm_IsTakvimi();
            tk.ShowDialog();
        }

        private void barButtonItem41_ItemClick(object sender, ItemClickEventArgs e)
        {
            dockPanel1.Visibility = DockVisibility.AutoHide;
            dockPanel1.Show();
        }

        private void barButtonItem58_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("Calc");
            }
            catch (Exception)
            {

                MessageBox.Show("Hesap Makinesi bulunamadı...");
            }
        }

        private void barButtonItem59_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void barButtonItem60_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void barButtonItem61_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }
    }
}
