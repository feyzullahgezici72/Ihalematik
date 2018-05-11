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
using IhalematikProBL.Entity;
using IhalematikProBL.Provider;
using IhalematikPro.Manager;

namespace IhalematikProUI.Forms.Taseron
{
    public partial class frm_TaseronSec : DevExpress.XtraEditors.XtraForm
    {
        public int SelectedJobberId { get; set; }
        public frm_TaseronSec()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            if (this.SelectedJobberId == 0)
            {
                MessageBox.Show("Lütfen Taşeron seçiniz?");
                return;
            }
            UICurrentManager.Instance.CurrentJobberTender.JobberId = this.SelectedJobberId;
            JobberTenderProvider.Instance.Save(UICurrentManager.Instance.CurrentJobberTender);
            this.Close();
            frm_Anaform af = (frm_Anaform)Application.OpenForms["frm_Anaform"];
            af.barButtonItem53.PerformClick();
        }

        private void frm_TaseronSec_Shown(object sender, EventArgs e)
        {
            List<Jobber> jobbers = JobberProvider.Instance.GetItems();
            grdJobber.DataSource = jobbers.Where(p => p.IsActive).ToList();
        }

        private void rpstSelected_CheckedChanged(object sender, EventArgs e)
        {
            bool isSelected = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<bool>(gridViewTender.GetFocusedRowCellValue("IsSelected"));
            for (int i = 0; i < gridViewTender.RowCount; i++)
            {
                gridViewTender.SetRowCellValue(i, colIsSelected, false);
            }

            if (isSelected)
            {
                gridViewTender.SetFocusedRowCellValue(colIsSelected, false);
                this.SelectedJobberId = 0;
            }
            else
            {
                gridViewTender.SetFocusedRowCellValue(colIsSelected, true);
                this.SelectedJobberId = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewTender.GetFocusedRowCellValue("Id"));
            }
        }
    }
}