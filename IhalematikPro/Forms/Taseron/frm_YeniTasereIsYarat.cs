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
using IhalematikProUI.Manager;
using IhalematikPro.Model;
using IhalematikProUI.Forms.Base;
using IhalematikProBL.Manager;
using IhalematikPro.Manager;

namespace IhalematikProUI.Forms.Taseron
{
    public partial class frm_YeniTasereIsYarat : IhalematikBaseForm
    {
        public int SelectedTenderId { get; set; }

        public frm_YeniTasereIsYarat()
        {
            InitializeComponent();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIhaleOlustur_Click(object sender, EventArgs e)
        {
            if (this.SelectedTenderId == 0)
            {
                MessageBox.Show("Lütfen İhale seçiniz?");
                return;
            }
            DialogResult resultMsg = MessageBox.Show("Yeni Taşere İş oluşturulsun mu?", "Yeni ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultMsg.Equals(DialogResult.Yes))
            {
                JobberTender jobTender = new JobberTender();
                jobTender.TenderId = this.SelectedTenderId;
                UICurrentManager.Instance.CurrentJobberTender = jobTender;

                JobberTenderProvider.Instance.Save(UICurrentManager.Instance.CurrentJobberTender);
                this.Close();
              
            }
            else
            {
                return;
            }
            frm_TaseronSec tSec = new frm_TaseronSec();
            tSec.ShowDialog();
        }

        private void frm_YeniTasereIsYarat_Shown(object sender, EventArgs e)
        {
            List<Tender> tenders = TenderProvider.Instance.GetItems();
            grdTender.DataSource = tenders.Where(p=> p.IsActive).ToList();

        }
        
        private void gridViewOffer_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            for (int i = 0; i < gridViewTender.RowCount; i++)
            {
                gridViewTender.SetRowCellValue(i, colIsSelected, false);
            }
            gridViewTender.SetFocusedRowCellValue(colIsSelected, true);
            this.SelectedTenderId = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewTender.GetFocusedRowCellValue("Id"));
            this.LoadTender();
        }

        private void rpstSelected_CheckedChanged(object sender, EventArgs e)
        {
            bool isSelected = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<bool>(gridViewTender.GetFocusedRowCellValue("IsSelected"));
            for (int i = 0; i < gridViewTender.RowCount; i++)
            {
                gridViewTender.SetRowCellValue(i, colIsSelected, false);
            }

            if (isSelected)
            {
                gridViewTender.SetFocusedRowCellValue(colIsSelected, false);
                this.SelectedTenderId = 0;
            }
            else
            {
                gridViewTender.SetFocusedRowCellValue(colIsSelected, true);
                this.SelectedTenderId = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewTender.GetFocusedRowCellValue("Id"));
            }
            this.LoadTender();
        }

        private void LoadTender()
        {
            Tender tender = TenderProvider.Instance.GetItem(this.SelectedTenderId);
            if (tender != null)
            {
                txtTeklifNo.Text = tender.DisplayNumber.ToString();
                txtAciklama.Text = tender.Description;
                LastOfferDate.DateTime = tender.LastOfferDate.Value;
                txtcompanyName.Text = tender.CompanyName;
                txtEkapNumber.Text = tender.EkapNumber;
                txtType.Text = tender.Type;
                txtScope.Text = tender.Scope;
                txtProcedure.Text = tender.Procedure;
                txtPlace.Text = tender.Place;
                txtManagement.Text = tender.Management;
                ddlTenderType.SelectedIndex = (int)tender.TenderType;
                this.LoadMaterialList(tender);
            }

            //if (this.Tender.MaterialList == null || this.Tender.MaterialList.Count == 0)
            //{
            //    grdOffer.Enabled = true;
            //}
            //else
            //{
            //    grdOffer.Enabled = false;
            //}
        }

        private void LoadMaterialList(Tender Tender)
        {
            LoadingManager.Instance.Show(this);
            List<MaterialList> items = Tender.MaterialList;
            List<MaterialListModel> dataSource = IhalematikModelBase.GetModels<MaterialListModel, MaterialList>(items);
            LoadingManager.Instance.Hide();
            grdMaterialList.DataSource = null;
            grdMaterialList.DataSource = dataSource;
        }

        private void frm_YeniTasereIsYarat_Load(object sender, EventArgs e)
        {

        }
    }
}