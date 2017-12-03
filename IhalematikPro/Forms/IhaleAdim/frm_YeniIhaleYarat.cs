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
            DialogResult resultMsg = MessageBox.Show("Yeni İhale oluşturulsun mu?", "Yeni ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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
            this.LoadGridOffer();
        }

        private void LoadGridOffer()
        {
            List<Offer> offers = OfferProvider.Instance.GetItems();
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
    }
}
