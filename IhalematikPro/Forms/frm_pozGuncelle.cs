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
    public partial class frm_pozGuncelle : DevExpress.XtraEditors.XtraForm
    {
        frm_PozListesi _owner = null;
        public int CurrentPozId { get; set; }
        public Poz currentPoz { get; set; }
        public Poz CurrentPoz
        {
            get
            {
                if (this.currentPoz == null)
                {
                    this.currentPoz = PozProvider.Instance.GetItem(this.CurrentPozId);
                }
                return this.currentPoz;
            }
        }
        public frm_pozGuncelle(frm_PozListesi Owner)
        {
            InitializeComponent();
            this._owner = Owner;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
            this._owner.LoadGrid();
        }

        private void frm_pozGuncelle_Load(object sender, EventArgs e)
        {
            if (this.CurrentPoz != null)
            {
                txtDescription.Text = this.CurrentPoz.Description;
                txtNumber.Text = this.CurrentPoz.Number;
                txtUnit.Text = this.CurrentPoz.Unit;
                txtUnitPrice.Text = this.CurrentPoz.UnitPrice.ToString();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (this.CurrentPoz != null)
            {
                PozModel model = new PozModel(this.CurrentPoz);
                model.Description = txtDescription.Text;
                model.Number = txtNumber.Text;
                model.Unit = txtUnit.Text;
                model.UnitPrice = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtUnitPrice.Text);
                model.Save();
                //PozProvider.Instance.Save()
                frm_MesajFormu mf = new frm_MesajFormu();
                mf.lblMesaj.Text = "Kayıt Güncellendi...";
                mf.ShowDialog();
                this.Close();
            }
        }
    }
}