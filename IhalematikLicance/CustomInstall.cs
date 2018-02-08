using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhalematikLicance
{
    [System.ComponentModel.RunInstaller(true)]
    public class CustomInstall : System.Configuration.Install.Installer
    {
        public override void Install(System.Collections.IDictionary stateSaver)
        {
            LicenseAgreement frm = new LicenseAgreement();
            frm.ShowDialog();
            if (true)
            {
                base.Uninstall(stateSaver);
            }
            else
            {   
                base.Install(stateSaver);
            }
        }

        protected override void OnBeforeInstall(IDictionary savedState)
        {
            base.OnBeforeInstall(savedState);
        }
    }
}
