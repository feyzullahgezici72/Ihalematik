using IhalematikPro.Manager;
using IhalematikProBL.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IhalematikPro
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CurrentManager.CurrentTender = TenderProvider.Instance.GetItem(1157);

            //Application.Run(new Forms.frm_Teklif_Adim3());
            Application.Run(new Forms.frm_Anaform());

        }
    }
}
