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
using DevExpress.LookAndFeel;

namespace IhalematikPro.Forms
{
    public partial class frm_YeniIhaleYarat : DevExpress.XtraEditors.XtraForm
    {
        private object a1;
        public int SelectedOfferId { get; set; }
        public frm_YeniIhaleYarat()
        {
            InitializeComponent();
        }

        private void frm_YeniIhaleYarat_Load(object sender, EventArgs e)
        {
            int lastTenderNumber = TenderManager.Instance.GetLastTenderNumber();
            txtTeklifNo.Text = string.Format("{0}", (lastTenderNumber + 1).ToString().PadLeft(8, '0'));
        }

        private void a1_FormClosed(object sender, FormClosedEventArgs e)
        {
            a1 = null;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIhaleOlustur_Click(object sender, EventArgs e)
        {
            UserLookAndFeel u = new UserLookAndFeel(this);
            u.UseDefaultLookAndFeel = false;
            u.UseWindowsXPTheme = false;
            u.Style = LookAndFeelStyle.Skin;
            u.SkinName = "McSkin";

            DialogResult resultMsg = XtraMessageBox.Show("Yeni İhale oluşturulsun mu?", "Yeni ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultMsg.Equals(DialogResult.Yes))
            {
                Tender tender = new Tender();
                tender.Equipments = new List<TenderEquipment>();
                int lastTenderNumber = TenderManager.Instance.GetLastTenderNumber();
                tender.Number = lastTenderNumber + 1;
                tender.Description = txtAciklama.Text;
                tender.OfferId = this.SelectedOfferId;
                tender.LastOfferDate = LastOfferDate.DateTime;
                tender.CompanyName = txtcompanyName.Text;
                tender.EkapNumber = txtEkapNumber.Text;
                tender.Type = txtType.Text;
                tender.Scope = txtScope.Text;
                tender.Procedure = txtProcedure.Text;
                tender.Place = txtPlace.Text;
                tender.Management = txtManagement.Text;
                tender.IsActive = true;

                if (!string.IsNullOrEmpty(txtTenderNearlyTotalAmount.Text))
                {
                    tender.NearlyTotalAmount = double.Parse(txtTenderNearlyTotalAmount.Text.Replace("TL", string.Empty).Trim());
                }

                bool result = TenderManager.Instance.Save(tender);
                if (!result)
                {
                    //TODO feyzullahg hata olustuysa yonlendir
                }
                else
                {
                    CurrentManager.Instance.CurrentTender = tender;
                }
                this.Enabled = false;
                frm_MesajFormu mf = new frm_MesajFormu();
                mf.lblMesaj.Text = "Yeni İhale Oluşturuldu";
                mf.ShowDialog();

                frm_IhaleGrup ig = new frm_IhaleGrup();
                ig.ShowDialog();
                this.Close();
                frm_Anaform af = (frm_Anaform)Application.OpenForms["frm_Anaform"];
                af.RibonPasif();
                af.btnAdimx1.PerformClick();
            }
        }

        private void frm_YeniIhaleYarat_Shown(object sender, EventArgs e)
        {
           // dateStart.DateTime = null;

            LastOfferDate.DateTime = DateTime.Now;
            this.LoadGridOffer();

        }

        private void LoadGridOffer()
        {
            List<Offer> offers = OfferProvider.Instance.GetItems();
            //offers.Where(p=> p.)
            grdOffer.DataSource = offers;
        }

        private void gridViewOffer_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            for (int i = 0; i < gridViewOffer.RowCount; i++)
            {
                gridViewOffer.SetRowCellValue(i, colIsSelected, false);
            }
            gridViewOffer.SetFocusedRowCellValue(colIsSelected, true);
            this.SelectedOfferId = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewOffer.GetFocusedRowCellValue("Id"));
        }

        private void rpstSelected_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < gridViewOffer.RowCount; i++)
            {
                gridViewOffer.SetRowCellValue(i, colIsSelected, false);
            }
            gridViewOffer.SetFocusedRowCellValue(colIsSelected, true);
            this.SelectedOfferId = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewOffer.GetFocusedRowCellValue("Id"));
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void txtOfferNumber_EditValueChanged(object sender, EventArgs e)
        {
            //SAMET ekledi
            {
                string tString = txtOfferNumber.Text;
                if (tString.Trim() == "") return;
                for (int i = 0; i < tString.Length; i++)
                {
                    if (!char.IsNumber(tString[i]))
                    {
                        MessageBox.Show("Lütfen Sadece Rakam Giriniz...");
                        txtOfferNumber.Text = "";
                        return;
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Offer> offers = OfferProvider.Instance.GetItems();
            string offerNumber = txtOfferNumber.Text.Trim();
            offers = offers.Where(p => p.Number.Contains(offerNumber)).ToList();
            DateTime? start = dateStart.DateTime.Date;
            DateTime? end = dateEnd.DateTime.Date;

            if (start != null && start != DateTime.MinValue)
            {
                offers = offers.Where(p => p.DateTime >= start).ToList();
            }
            if (end != null && end != DateTime.MinValue)
            {
                offers = offers.Where(p => p.DateTime <= end).ToList();
            }

            grdOffer.DataSource = null;
            grdOffer.DataSource = offers;
        }
    }
}
