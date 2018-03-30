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
using IhalematikProUI.Manager;
using IhalematikProUI.Forms.Base;

namespace IhalematikProUI.Forms.OBF
{
    public partial class frm_TopluObfTemp :IhalematikBaseForm
    {
        public List<IhalematikProBL.Entity.OBF> obfItems = null;
        private frm_OzelStokListesi _owner;
        public frm_TopluObfTemp(frm_OzelStokListesi Owner)
        {
            this._owner = Owner;
            InitializeComponent();
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
                //this.Enabled = false;
                //LoadingManager.Instance.Show(this);
                foreach (IhalematikProBL.Entity.OBF item in obfItems)
                {
                    OBFProvider.Instance.Save(item);
                }
                //LoadingManager.Instance.Hide();
                this._owner.LoadGrid();
                //this.Enabled = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Kaydedilecek OBF bulunamadı.");
            }
            this.Close();
        }
    }
}