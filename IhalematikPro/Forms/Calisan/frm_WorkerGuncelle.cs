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

namespace IhalematikProUI.Forms.Calisan
{
    public partial class frm_WorkerGuncelle : DevExpress.XtraEditors.XtraForm
    {
        frm_CalisanEkle _owner = null;
        public int CurrentWorkerTitleId { get; set; }
        public Title currentWorkerTitle { get; set; }
        public Title CurrentWorkerTitle
        {
            get
            {
                if (this.currentWorkerTitle == null)
                {
                    this.currentWorkerTitle = TitleProvider.Instance.GetItem(this.CurrentWorkerTitleId);
                }
                return this.currentWorkerTitle;
            }
        }
        public frm_WorkerGuncelle(frm_CalisanEkle Owner)
        {
            this._owner = Owner;
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_WorkerGuncelle_Shown(object sender, EventArgs e)
        {
            txtWorkerTitle.Text = this.CurrentWorkerTitle.Name;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtWorkerTitle.Text))
            {
                this.CurrentWorkerTitle.Name = txtWorkerTitle.Text;
                TitleProvider.Instance.Save(this.CurrentWorkerTitle);
                this.Close();
                this._owner.LoadGrid();
            }
        }
    }
}