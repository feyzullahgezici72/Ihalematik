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

namespace IhalematikProUI.Forms.Tedarikci
{
    public partial class frm_MalzemeAdlandir : DevExpress.XtraEditors.XtraForm
    {
        frm_TedarikcilereTeklifGonder _owner = null;
        public int currentPozOBFId { get; internal set; }
        public bool IsPoz { get; internal set; }

        private Material pozOBF { get; set; }
        public Material PozOBF
        {
            get
            {
                if (this.pozOBF == null)
                {
                    if (this.IsPoz)
                    {
                        Poz poz = PozProvider.Instance.GetItem(this.currentPozOBFId);
                        this.pozOBF = new Material().CreateMaterial(poz);
                    }

                    else
                    {
                        IhalematikProBL.Entity.OBF obf = OBFProvider.Instance.GetItem(this.currentPozOBFId);
                        this.pozOBF = new Material().CreateMaterial(obf);
                    }

                }
                return this.pozOBF;
            }
        }

        public frm_MalzemeAdlandir(frm_TedarikcilereTeklifGonder Owner)
        {
            this._owner = Owner;
            InitializeComponent();
        }

        private void btnChangeName_Click(object sender, EventArgs e)
        {
            if (txtdescriptionForSupplier.Text != null)
            {
                if (this.IsPoz)
                {
                    Poz poz = PozProvider.Instance.GetItem(this.currentPozOBFId);
                    poz.DescriptionForSupplier = txtdescriptionForSupplier.Text.Trim();
                    PozProvider.Instance.Save(poz);
                }
                else
                {
                    IhalematikProBL.Entity.OBF obf = OBFProvider.Instance.GetItem(this.currentPozOBFId);
                    obf.DescriptionForSupplier = txtdescriptionForSupplier.Text.Trim();
                    OBFProvider.Instance.Save(obf);
                }
                this.PozOBF.DescriptionForSupplier = txtdescriptionForSupplier.Text.Trim();
                this._owner.LoadMaterialGrid();
                UIPopupManager.Instance.ShowPopup();
                this.Close();
            }
            //else
            //{
            //    MessageBox.Show("Lütfen Malzeme Adını Belirtiniz...");
            //    txtNewMeterialName.Focus();
            //}
        }

        private void frm_MalzemeAdlandir_Load(object sender, EventArgs e)
        {
            // int uzunluk = int.Parse(txtNewMeterialName.Text.Length.ToString());
            txtDescription.Text = this.PozOBF.Description;
            txtdescriptionForSupplier.Text = this.PozOBF.DescriptionForSupplier;
            txtdescriptionForSupplier.Text = txtDescription.Text;
        }

        private void trcBar_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_MalzemeAdlandir_Shown(object sender, EventArgs e)
        {
            txtdescriptionForSupplier.Focus();
        }
    }
}