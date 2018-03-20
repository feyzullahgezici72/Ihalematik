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
using System.Diagnostics;

namespace IhalematikProUI.Forms.Tedarikci
{
    public partial class frm_MailListesi : DevExpress.XtraEditors.XtraForm
    {
        public frm_MailListesi()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                string FileName = "\\Development\\Ihalematik\\IhalematikPro\\ExcelFiles\\eMailListesi.xls";
                grdMailList.ExportToXls(FileName);
                frm_MesajFormu mesaj = new frm_MesajFormu();
                mesaj.lblMesaj.Text = "Veriler Excel dosyasına aktarıldı...";
                mesaj.ShowDialog();
                System.Diagnostics.ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "EXCEL.EXE";
                startInfo.Arguments = FileName;
                Process.Start(startInfo);
            }
            catch (Exception)
            {

                MessageBox.Show("Hay Aksii!! \nProgram beklenmeyen bir hata ile karşılaştı.");
            }
        }
    }
}