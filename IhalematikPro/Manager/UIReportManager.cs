using DevExpress.XtraPrinting;
using IhalematikProBL.Manager;
using IhalematikProUI.Forms;
using SimpleApplicationBase.BL.Base;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IhalematikProUI.Manager
{
    public class UIReportManager : SingletonBase<UIReportManager>
    {
        public bool ExtractExcel(DevExpress.XtraGrid.GridControl GridControl)
        {
            try
            {
                GridControl.ExportToXls(UIGlobalVeriables.Instance.MalzemeMaliyetListesiPath);
                frm_MesajFormu mesaj = new frm_MesajFormu();
                mesaj.lblMesaj.Text = "Veriler Excel dosyasına aktarıldı...";
                mesaj.ShowDialog();
                System.Diagnostics.ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "EXCEL.EXE";
                startInfo.Arguments = UIGlobalVeriables.Instance.MalzemeMaliyetListesiPath;
                Process.Start(startInfo);
                return true;
            }
            catch (Exception ex)
            {
                LoggingManager.Instance.SaveErrorLog(ex);
                return false;
            }
        }

    }
}
