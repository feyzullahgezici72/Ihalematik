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

namespace IhalematikProUI.Forms
{
    public partial class frm_FaalitetAlaniEkle : DevExpress.XtraEditors.XtraForm
    {
        public frm_FaalitetAlaniEkle()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUnvan.Text.Trim()))
            {
                SupplierSegment supplierSegment = new SupplierSegment();
                supplierSegment.Name = txtUnvan.Text.Trim();
                List<SupplierSegment> existingItem = SupplierSegmentProvider.Instance.GetItems("Name", supplierSegment.Name);

                if (existingItem.Count == 0)
                {
                    SupplierSegmentProvider.Instance.Save(supplierSegment);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ayni kayit vardir");
                }
            }
        }
    }
}