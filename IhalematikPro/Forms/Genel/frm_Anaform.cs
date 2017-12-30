using System;
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
            picLogo.Left = (pnlAna.Width / 2) - (picLogo.Width / 2);
            picLogo.Top = (pnlAna.Height / 2) - (picLogo.Height / 2);
        }
        public void frm_Anaform_Load(object sender, EventArgs e)
        {
            logoOrtala();
            DevExpress.UserSkins.BonusSkins.Register();
            List<Tender> list = TenderProvider.Instance.GetItems("IsActive", true);

            grdActiveTenderList.DataSource = list.Where(p => p.LastOfferDate == null || p.LastOfferDate.Value >= DateTime.Now).ToList();
            this.WindowState = FormWindowState.Maximized;
            if (CurrentManager.Instance.CurrentCompany != null)
            {
                lblCompanyName.Text = CurrentManager.Instance.CurrentCompany.Name;
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

        private void Ta3_FormClosed(object sender, FormClosedEventArgs e)
        {
            ta3 = null;
            RibonAktif();
            btnAdimx3.ButtonStyle = BarButtonStyle.Default;
        }

        Forms.frm_Teklif_Adim2 ta4;
        private void btnAdimx4_ItemClick(object sender, ItemClickEventArgs e)
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
            barButtonItem13.ButtonStyle = BarButtonStyle.Check;
        }
        frm_TedarikcilerdenFiyatAl tfa;
        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
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

        private void Tfa_FormClosed(object sender, FormClosedEventArgs e)
        {
            tfa = null;
            RibonAktif();
            barButtonItem15.ButtonStyle = BarButtonStyle.Default;
        }
        frm_TeklifAdimSon ts;
        private void btnAdimx5_ItemClick(object sender, ItemClickEventArgs e)
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
            //ribbon.Enabled = true;
        }

        public void RibonAktif()
        {
            ribbon.Enabled = true;
            MainPanel.Visible = true;
        }
        public void RibonPasif()
        {
            MainPanel.Visible = false;
            ribbon.Enabled = false;
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
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Lilian"; //"Money Twins"; //"Lilian";
            DevExpress.Skins.SkinManager.EnableFormSkins();
            Application.EnableVisualStyles();
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Office 2007 Green";
            DevExpress.Skins.SkinManager.EnableFormSkins();
            Application.EnableVisualStyles();
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "iMaginary"; //Office 2007 Blue
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
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Money Twins"; //London Liquid Sky
            DevExpress.Skins.SkinManager.EnableFormSkins();
            Application.EnableVisualStyles();
        }

        private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (pnIhaleListesi.Visible == false)
            {
                pnIhaleListesi.Visible = true;
                barButtonItem18.ButtonStyle = BarButtonStyle.Check;
            }
            else
            {
                pnIhaleListesi.Visible = false;
                barButtonItem18.ButtonStyle = BarButtonStyle.Default;
            }

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
            popupMenu1.ShowPopup(Control.MousePosition);
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
            barButtonItem14.ButtonStyle = BarButtonStyle.Check;
            RibonPasif();
            frm_Anaform af = (frm_Anaform)Application.OpenForms["frm_Anaform"];
            if (tg == null)
            {
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
        }
        frm_TeklifAktar teklifAktar;
        private void barButtonItem28_ItemClick(object sender, ItemClickEventArgs e)
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

        private void TeklifAktar_FormClosed(object sender, FormClosedEventArgs e)
        {
            teklifAktar = null;
            RibonAktif();
            barButtonItem28.ButtonStyle = BarButtonStyle.Default;
        }

        private void barButtonItem21_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            frm_PozlariOnlineGuncelle pg = new frm_PozlariOnlineGuncelle();
            pg.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void barButtonItem25_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_LisansSozlesmesi ls = new frm_LisansSozlesmesi();
            ls.ShowDialog();
        }
    }
}