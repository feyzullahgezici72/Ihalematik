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
using IhalematikPro.Forms;
using IhalematikProBL.Provider;

namespace IhalematikProUI.Forms.OBF
{
    public partial class frm_TopluObfTemp : DevExpress.XtraEditors.XtraForm
    {
        public List<IhalematikProBL.Entity.OBF> obfItems = null;
        private frm_OzelStokListesi _owner;
        public frm_TopluObfTemp(frm_OzelStokListesi Owner)
        {
            this._owner = Owner;
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void btnHayir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_TopluObfTemp_Shown(object sender, EventArgs e)
        {
            grdOBFTempList.DataSource = this.obfItems;
        }

        private void btnEvet_Click(object sender, EventArgs e)
        {
            if (this.obfItems != null)
            {
                foreach (IhalematikProBL.Entity.OBF item in obfItems)
                {
                    OBFProvider.Instance.Save(item);
                }
                MessageBox.Show("OBF listesi kaydedildi.");
                this._owner.LoadGrid();
            }
            else
            {
                MessageBox.Show("Kaydedilecek OBF bulunamadı.");
            }
            this.Close();
        }
    }
}