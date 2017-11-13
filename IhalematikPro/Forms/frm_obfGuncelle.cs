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
using IhalematikPro.Forms;
using IhalematikPro.Model;

namespace IhalematikProUI.Forms
{
    public partial class frm_obfGuncelle : DevExpress.XtraEditors.XtraForm
    {
        frm_OzelStokListesi _owner = null;
        public int CurrentOBFId { get; set; }
        public OBF currentOBF { get; set; }
        public OBF CurrentOBF
        {
            get
            {
                if (this.currentOBF == null)
                {
                    this.currentOBF = OBFProvider.Instance.GetItem(this.CurrentOBFId);
                }
                return this.currentOBF;
            }
        }
        public frm_obfGuncelle(frm_OzelStokListesi Owner)
        {
            InitializeComponent();
            this._owner = Owner;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
            this._owner.LoadGrid();
        }

        private void frm_obfGuncelle_Load(object sender, EventArgs e)
        {
            if (this.CurrentOBF != null)
            {
                txtDescription.Text = this.CurrentOBF.Description;
                txtNumber.Text = this.CurrentOBF.Number;
                txtUnit.Text = this.CurrentOBF.Unit;
                txtUnitPrice.Text = this.CurrentOBF.UnitPrice.ToString();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (this.CurrentOBF != null)
            {
                OBFModel model = new OBFModel(this.currentOBF);
                model.Description = txtDescription.Text;
                model.Number = txtNumber.Text;
                model.Unit = txtUnit.Text;
                model.UnitPrice = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtUnitPrice.Text);
                model.Save();
                frm_MesajFormu mf = new frm_MesajFormu();
                mf.lblMesaj.Text = "Kayıt Güncellendi...";
                mf.ShowDialog();
                this.Close();
                //PozProvider.Instance.Save()
            }
        }
    }
}