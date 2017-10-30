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
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Office 2007 Pink";
            DevExpress.Skins.SkinManager.EnableFormSkins();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CurrentManager.CurrentTender = TenderProvider.Instance.GetItem(1199);

            //Application.Run(new Forms.frm_Anaform());
            Application.Run(new Forms.frm_Teklif_Adim3());
            //Application.Run(new Forms.frm_Login()); //.frm_Anaform

        }
    }
}
