using IhalematikPro.Forms;
using IhalematikPro.Manager;
using IhalematikProBL.Manager;
using IhalematikProBL.Provider;
using IhalematikProUI.Forms.Genel;
using IhalematikProUI.Manager;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IhalematikPro
{
    static class Program
    {
        private static Mutex mutex = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            const string appName = "LifeTree Software ihale Programı";
            bool createdNew;
            mutex = new Mutex(true, appName, out createdNew);
            if (!createdNew)
            {
                MessageBox.Show(appName + " zaten çalışıyor!");
                return;
            }
           
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Office 2007 Green"; //"Money Twins";  //"Lilian";//
            DevExpress.Skins.SkinManager.EnableFormSkins();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
             CurrentManager.Instance.CurrentTender = TenderProvider.Instance.GetItems().OrderByDescending(p => p.InsertTime).FirstOrDefault();
             CurrentManager.Instance.CurrentCompany = CompanyProvider.Instance.GetItems().FirstOrDefault();
             CurrentManager.Instance.CurrentOffer = OfferProvider.Instance.GetItems().OrderByDescending(p => p.InsertTime).FirstOrDefault();//.LastOrDefault();

            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);

            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            if (UICustomConfigurationManager.Instance.Mode == "DEVELOPMENT")
            {
                Application.Run(new frm_Anaform());
            }

            else
            {
                Application.Run(new frm_Login());
            }
        }

        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            // Log the exception, display it, etc
            LoggingManager.Instance.SaveErrorLog(e.Exception);
            //Debug.WriteLine(e.Exception.Message);
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            // Log the exception, display it, etc
            LoggingManager.Instance.SaveErrorLog((e.ExceptionObject as Exception));
        }
    }
}
