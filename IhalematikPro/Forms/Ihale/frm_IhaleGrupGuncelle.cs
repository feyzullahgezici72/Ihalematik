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

namespace IhalematikProUI.Forms
{
    public partial class frm_IhaleGrupGuncelle : DevExpress.XtraEditors.XtraForm
    {
        public int SelectedGroupId { get; set; }
        public TenderGroup SelectedGroup { get; set; }

        public frm_IhaleGrup _owner = null;
        public frm_IhaleGrupGuncelle(frm_IhaleGrup Owner)
        {
            InitializeComponent();
            this._owner = Owner;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
         
        }

        private void frm_IhaleGrupGuncelle_Load(object sender, EventArgs e)
        {
            this.SelectedGroup = TenderGroupProvider.Instance.GetItem(this.SelectedGroupId);
            txtDescription.Text = SelectedGroup.Description;

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (this.SelectedGroup != null)
            {
                this.SelectedGroup.Description = txtDescription.Text;
                TenderGroupProvider.Instance.Save(this.SelectedGroup);
            }
            this._owner.LoadGrid();
            UIPopupManager.Instance.ShowPopup();
            this.Close();
        }
    }
}