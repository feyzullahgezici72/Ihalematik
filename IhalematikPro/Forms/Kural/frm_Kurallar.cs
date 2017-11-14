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
    public partial class frm_Kurallar : DevExpress.XtraEditors.XtraForm
    {
        frm_Kurallistesi _owner = null;
        public int CurrentRuleId { get; set; }
        public IhalematikProBL.Entity.Rule currentRule { get; set; }
        public IhalematikProBL.Entity.Rule CurrentRule
        {
            get
            {
                if (this.currentRule == null)
                {
                    this.currentRule = RuleProvider.Instance.GetItem(this.CurrentRuleId);
                }
                return this.currentRule;
            }
        }

        public frm_Kurallar(frm_Kurallistesi Owner)
        {
            InitializeComponent();
            this._owner = Owner;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_Anaform af = (frm_Anaform)Application.OpenForms["frm_Anaform"];
            af.RibonAktif();
        }

        private void frm_Kurallar_Load(object sender, EventArgs e)
        {
            lblRuleName.Text = this.CurrentRule.Name;
            txtRuleValue.Text = this.CurrentRule.Value;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            this.CurrentRule.Value = txtRuleValue.Text;
            RuleProvider.Instance.Save(this.CurrentRule);
            this._owner.LoadGrid();
            this.Close();
        }
    }
}