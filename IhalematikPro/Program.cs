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
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Lilian"; //"Money Twins";  //"Lilian";//
            DevExpress.Skins.SkinManager.EnableFormSkins();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CurrentManager.Instance.CurrentTender = TenderProvider.Instance.GetItems().OrderByDescending(p=> p.InsertTime).First();
            CurrentManager.Instance.CurrentCompany = CompanyProvider.Instance.GetItems().FirstOrDefault();
            CurrentManager.Instance.CurrentOffer = OfferProvider.Instance.GetItems().OrderByDescending(p => p.InsertTime).First();//.LastOrDefault();
            Application.Run(new Forms.frm_Anaform());
            //Application.Run(new Forms.frm_Teklif_Adim3());
            //Application.Run(new Forms.frm_Login()); //.frm_Anaform

        }
    }
}
