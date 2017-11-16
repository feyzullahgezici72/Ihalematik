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

namespace IhalematikPro.Forms
{
    public partial class frm_CalisanEkle : DevExpress.XtraEditors.XtraForm
    {

        frm_CalisanTanimlama _owner = null;
        public frm_CalisanEkle(frm_CalisanTanimlama Owner)
        {
            InitializeComponent();
            this._owner = Owner;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    this._owner.InitilalizeForm();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Bu unvan zaten mevcut");
                    txtUnvan.ResetText();
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
    }
}