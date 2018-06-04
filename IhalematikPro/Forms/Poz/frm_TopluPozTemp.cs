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
using IhalematikPro.Forms;
using IhalematikProBL.Provider;
using IhalematikProUI.Manager;
using IhalematikProUI.Forms.Base;

namespace IhalematikProUI.Forms.PozTem
{
    public partial class frm_TopluPozTemp : IhalematikBaseForm
    {
        private frm_PozListesi _owner = null;
        public List<Poz> pozItems = null;
        public frm_TopluPozTemp(frm_PozListesi Owner)
        {
            this._owner = Owner;
            InitializeComponent();
        }

        private void btnHayir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEvet_Click(object sender, EventArgs e)
        {
            if (this.pozItems != null)
            {
                this.Enabled = false;
                LoadingManager.Instance.Show(this);
                foreach (IhalematikProBL.Entity.Poz item in pozItems)
                {
                    PozProvider.Instance.Save(item);
                }
                UIPopupManager.Instance.ShowPopup();
                LoadingManager.Instance.Hide();;
                this._owner.LoadPozGrid();
            }
            else
            {
                MessageBox.Show("Kaydedilecek Poz bulunamadı.");
            }
            this.Close();
        }

        private void frm_TopluPozTemp_Shown(object sender, EventArgs e)
        {
            grdPozTempList.DataSource = this.pozItems;
        }
    }
}