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

namespace IhalematikProUI.Forms.Tedarikci
{
    public partial class frm_TopluPozTedarikciTemp : IhalematikBaseForm
    {
        private frm_TedarikcilereTeklifGonder _owner = null;
        public List<Poz> pozItems = null;
        public frm_TopluPozTedarikciTemp(frm_TedarikcilereTeklifGonder Owner)
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
                LoadingManager.Instance.Hide(); ;
                this._owner.LoadMaterialGrid();
            }
            else
            {
                MessageBox.Show("Kaydedilecek Poz bulunamadı.");
            }
            this.Close();
        }

        private void frm_TopluPozTedarikciTemp_Load(object sender, EventArgs e)
        {

        }
    }
}