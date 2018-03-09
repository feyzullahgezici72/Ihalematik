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
using IhalematikPro.Model;
using IhalematikProBL.Entity;
using IhalematikProBL.Provider;
using IhalematikProUI.Forms;
using IhalematikProUI.Forms.Calisan;

namespace IhalematikPro.Forms
{
    public partial class frm_CalisanEkle : DevExpress.XtraEditors.XtraForm
    {
        public int FocusedRowHandle = 0;

        frm_CalisanTanimlama _owner = null;
        public frm_CalisanEkle(frm_CalisanTanimlama Owner)
        {
            InitializeComponent();
            this._owner = Owner;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
            this._owner.LoadGrid();
            this._owner.LoadWorkerTitles();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool IsEmpty = IsEmptyKontrol();
            if (!IsEmpty)
            {
                Title model = new Title();
                model.Name = txtUnvan.Text;
                List<Title> existingItems = TitleProvider.Instance.GetItems("Name", model.Name.Trim());
                if (existingItems.Count == 0)
                {
                    TitleProvider.Instance.Save(model);

                    frm_MesajFormu mf = new frm_MesajFormu();
                    mf.lblMesaj.Text = "Çalışan Ünvanı Kaydedildi...";
                    mf.ShowDialog();
                    this._owner.SelectedTitleId = model.Id;
                    this._owner.LoadWorkerTitles();
                    this.Close();
                   
                }
                else
                {
                    MessageBox.Show("Bu unvan zaten mevcut");
                    txtUnvan.Text="";
                    txtUnvan.Focus();
                }
            }
        }
        public bool IsEmptyKontrol()
        {
            if (string.IsNullOrEmpty(txtUnvan.Text.Trim()))
            {
                dxErrorProvider1.SetError(txtUnvan, "Ünvan boş bırakılamaz", DevExpress.XtraEditors.DXErrorProvider.ErrorType.User3);
                return true;
            }
            else
            {
                dxErrorProvider1.ClearErrors();
            }
            return false;
        }

        private void btnGuncelle_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int id = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewWorkerTitle.GetFocusedRowCellValue("Id"));
            frm_WorkerGuncelle wg = new frm_WorkerGuncelle(this);
            this.FocusedRowHandle = gridViewWorkerTitle.FocusedRowHandle;
            wg.CurrentWorkerTitleId = id;

            wg.ShowDialog();
        }

        private void frm_CalisanEkle_Shown(object sender, EventArgs e)
        {
            this.LoadGrid();
            txtUnvan.Focus();
        }

        public void LoadGrid()
        {
            List<Title> workerTitles = TitleProvider.Instance.GetItems();
            grdWorkerTitle.DataSource = workerTitles;
        }
    }
}