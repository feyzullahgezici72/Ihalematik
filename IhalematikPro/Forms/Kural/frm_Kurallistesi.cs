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

namespace IhalematikProUI.Forms
{
    public partial class frm_Kurallistesi : DevExpress.XtraEditors.XtraForm
    {
        public frm_Kurallistesi()
        {
            InitializeComponent();
            bindingSourceRules.DataSource = typeof(List<IhalematikProBL.Entity.Rule>);
            grdRules.DataSource = bindingSourceRules;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_Anaform af = (frm_Anaform)Application.OpenForms["frm_Anaform"];
            af.RibonAktif();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

        }

        private void btnGuncelle_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int currentRuleId = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewRules.GetFocusedRowCellValue("Id"));
            frm_Kurallar krl = new frm_Kurallar(this);
            krl.CurrentRuleId = currentRuleId;
            krl.ShowDialog();
        }

        private void frm_Kurallistesi_Load(object sender, EventArgs e)
        {
            this.LoadGrid();
        }

        public void LoadGrid()
        {
            List<IhalematikProBL.Entity.Rule> rules = RuleProvider.Instance.GetItems();
            grdRules.DataSource = rules;
        }
    }
}