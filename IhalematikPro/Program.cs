using IhalematikPro.Manager;
using IhalematikProBL.Provider;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
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
            //Kuzen burayı halledersin
            //bool calisiyor = false;
            //foreach (Process prog in Process.GetProcesses())
            //{
            //    if (prog.ProcessName == Assembly.GetEntryAssembly().GetName().Name)
            //    {
            //        calisiyor = true;
            //    }
            //    else
            //    {
            //        calisiyor = false;
            //    }
            //}
            //if (!calisiyor)
            //{
                DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Lilian"; //"Money Twins";  //"Lilian";//
                DevExpress.Skins.SkinManager.EnableFormSkins();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                CurrentManager.Instance.CurrentTender = TenderProvider.Instance.GetItems().OrderByDescending(p => p.InsertTime).First();
                CurrentManager.Instance.CurrentCompany = CompanyProvider.Instance.GetItems().FirstOrDefault();
                //CurrentManager.Instance.CurrentOffer = OfferProvider.Instance.GetItems().OrderByDescending(p => p.InsertTime).First();//.LastOrDefault();
                Application.Run(new Forms.frm_Anaform());
            //}
            //else
            //{
            //    MessageBox.Show("Programın bir kopyası zaten çalışıyor...", "LifeTreeSoftware", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //}
        }
    }
}
