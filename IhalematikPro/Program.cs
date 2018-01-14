using IhalematikPro.Manager;
using IhalematikProBL.Provider;
using IhalematikProUI.Forms.Genel;
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
            const string appName = "LifeTree Software ihale Programı";
            bool createdNew;

            mutex = new Mutex(true, appName, out createdNew);

            if (!createdNew)
            {
                MessageBox.Show(appName + " zaten çalışıyor!");
                //Console.ReadKey();
                return;
            }

            //Console.WriteLine("Continuing with the application");
            //Console.ReadKey();


            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Office 2007 Green"; //"Money Twins";  //"Lilian";//
            DevExpress.Skins.SkinManager.EnableFormSkins();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CurrentManager.Instance.CurrentTender = TenderProvider.Instance.GetItems().OrderByDescending(p => p.InsertTime).First();
            CurrentManager.Instance.CurrentCompany = CompanyProvider.Instance.GetItems().FirstOrDefault();
            CurrentManager.Instance.CurrentOffer = OfferProvider.Instance.GetItems().OrderByDescending(p => p.InsertTime).First();//.LastOrDefault();
            Application.Run(new frm_Login());
        }
    }
}
