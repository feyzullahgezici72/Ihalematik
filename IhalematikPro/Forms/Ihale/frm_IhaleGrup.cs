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
using IhalematikProUI.Model;
using IhalematikProBL.Entity;
using IhalematikProBL.Provider;
using IhalematikPro.Model;
using IhalematikPro.Manager;
using IhalematikPro.Forms;
using IhalematikProUI.Forms.Base;
using IhalematikProUI.Manager;

namespace IhalematikProUI.Forms
{
    public partial class frm_IhaleGrup : IhalematikBaseForm
    {
        public IhalematikBaseForm _owner = null;
        public int FocusedRowHandle = 0;
        public frm_IhaleGrup(IhalematikBaseForm Owner)
        {
            this._owner = Owner;
            InitializeComponent();
            bindingSourceTenderGroup.DataSource = typeof(List<TenderGroupModel>);
            grdTenderGroup.DataSource = bindingSourceTenderGroup;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {

            if (UICurrentManager.Instance.CurrentTender.Groups == null || UICurrentManager.Instance.CurrentTender.Groups.Count == 0)
            {
                TenderGroup item = new TenderGroup();
                item.Description = "Genel Grup";
                item.Tender = UICurrentManager.Instance.CurrentTender;
                TenderGroupProvider.Instance.Save(item);
            }

            this.Close();
        }

        private void btnGuncelle_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int selectedGroupId = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewTenderGroup.GetFocusedRowCellValue("Id"));
            frm_IhaleGrupGuncelle ig = new frm_IhaleGrupGuncelle(this);
            ig.SelectedGroupId = selectedGroupId;
            this.FocusedRowHandle = gridViewTenderGroup.FocusedRowHandle;
            ig.ShowDialog();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTenderGroupDescription.Text))
            {
                TenderGroup item = new TenderGroup();
                item.Description = txtTenderGroupDescription.Text;

                if (UICurrentManager.Instance.CurrentTender.Groups != null)
                {
                    List<TenderGroup> existingItems = UICurrentManager.Instance.CurrentTender.Groups.Where(p => p.Description.Trim() == item.Description.Trim()).ToList();
                    if (existingItems != null && existingItems.Count != 0)
                    {
                        frm_MesajFormu message = new frm_MesajFormu();
                        message.lblMesaj.Text = "Bu grup adi zaten var.";
                        message.ShowDialog();
                    }
                    else
                    {
                        item.Tender = UICurrentManager.Instance.CurrentTender;
                        UICurrentManager.Instance.CurrentTender.Groups.Add(item);
                        TenderGroupProvider.Instance.Save(item);
                        this.LoadGrid();
                        txtTenderGroupDescription.Text = "";
                        txtTenderGroupDescription.Focus();
                    }
                }
            }
        }

        private void frm_IhaleGrup_Load(object sender, EventArgs e)
        {
            txtTenderNumber.Text = UICurrentManager.Instance.CurrentTender.DisplayNumber;
            txtTenderDescription.Text = UICurrentManager.Instance.CurrentTender.Description;
            txtTenderCompanyName.Text = UICurrentManager.Instance.CurrentTender.CompanyName;
            this.LoadGrid();
        }

        public void LoadGrid()
        {
            List<TenderGroup> items = TenderGroupProvider.Instance.GetItems("TenderId", UICurrentManager.Instance.CurrentTender.Id);
            List<TenderGroupModel> models = IhalematikModelBase.GetModels<TenderGroupModel, TenderGroup>(items);
            int i = 1;
            foreach (var item in models)
            {
                item.ItemNumber = i;
                i++;
            }
            grdTenderGroup.DataSource = models;
            if (this.FocusedRowHandle != 0)
            {
                gridViewTenderGroup.FocusedRowHandle = this.FocusedRowHandle;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Silmek  istediğinz emin misiniz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.Yes))
            {
                int selectedGroupId = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewTenderGroup.GetFocusedRowCellValue("Id"));
                TenderGroup tenderGroup = TenderGroupProvider.Instance.GetItem(selectedGroupId);
                tenderGroup.IsMarkedForDeletion = true;
                TenderGroupProvider.Instance.Save(tenderGroup);
                UICurrentManager.Instance.CurrentTender.Groups.Remove(tenderGroup);
                this.LoadGrid();
            }
            else
            {

            }

        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            if (UICurrentManager.Instance.CurrentTender.Groups == null || UICurrentManager.Instance.CurrentTender.Groups.Count == 0)
            {
                DialogResult resultMsg = MessageBox.Show("Hiç Grup oluşturmadınız emin misiniz?", "Uyarı!!! ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultMsg.Equals(DialogResult.Yes))
                {
                    TenderGroup item = new TenderGroup();
                    item.Description = "Genel Grup";
                    item.Tender = UICurrentManager.Instance.CurrentTender;
                    TenderGroupProvider.Instance.Save(item);
                    UIPopupManager.Instance.ShowPopup();
                    this.Close();
                }
                else
                {
                    txtTenderGroupDescription.Focus();
                }
            }
            else
            {
                this.Close();
            }
            if (this._owner is frm_Teklif_Adim1)
            {
                ((frm_Teklif_Adim1)this._owner).LoadTenderGroupGrid();
            }
        }

        private void frm_IhaleGrup_Shown(object sender, EventArgs e)
        {
            txtTenderGroupDescription.Focus();
        }
    }
}