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
        public bool IsLicenceAktivated { get; set; }
        public override void Install(System.Collections.IDictionary stateSaver)
        {
            LicenseAgreement frm = new LicenseAgreement(this);
            frm.ShowDialog();

            if (this.IsLicenceAktivated)
            {
                frm.Close();
                Administrator administrator = new Administrator();
                administrator.ShowDialog();
            }

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
