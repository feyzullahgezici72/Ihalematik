using IhalematikProBL.Entity;
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
        public bool IsActivateSerialNumber { get; internal set; }
        public bool IsAdministratorLogin { get; internal set; }

        public License License { get; set; }

        public override void Install(System.Collections.IDictionary stateSaver)
        {
            try
            {
                LicenseActivate frmLicenseActivate = new LicenseActivate(this);
                frmLicenseActivate.ShowDialog();

                if (this.IsActivateSerialNumber)
                {
                    frmLicenseActivate.Close();
                    LicenseInformation frmLicenseInformation = new LicenseInformation(this);
                    frmLicenseInformation.ShowDialog();

                    Administrator frmAdministrator = new Administrator(this);
                    frmLicenseActivate.ShowDialog();
                    if (this.IsAdministratorLogin)
                    {
                        base.Install(stateSaver);
                    }
                }
                else
                {
                    base.Uninstall(stateSaver);
                }
            }
            catch (Exception ex)
            {
                base.Uninstall(stateSaver);
            }
        }

    }
}
