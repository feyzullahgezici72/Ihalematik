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
        public CustomInstall()
        {

        }
        public bool IsActivateSerialNumber { get; internal set; }
        public bool IsAdministratorLogin { get; internal set; }

        public License License { get; set; }
        public static System.Collections.IDictionary StateSaver = null;
        public override void Install(System.Collections.IDictionary stateSaver)
        {
            try
            {
                StateSaver = stateSaver;
                LicenseActivate frmLicenseActivate = new LicenseActivate(this);
                frmLicenseActivate.ShowDialog();
            }
            catch (Exception ex)
            {
                base.Uninstall(stateSaver);
            }
        }

        protected override void OnBeforeInstall(IDictionary savedState)
        {
            base.OnBeforeInstall(savedState);
        }

        public void LicenseInformationForm()
        {
            try
            {
                if (this.IsActivateSerialNumber)
                {
                    LicenseInformation frmLicenseInformation = new LicenseInformation(this);
                    frmLicenseInformation.ShowDialog();
                }
                else
                {
                    base.Uninstall(StateSaver);
                }
            }
            catch (Exception)
            {
                base.Uninstall(StateSaver);
            }
        }

        public void AdministratorForm()
        {
            try
            {
                Administrator frmAdministrator = new Administrator(this);
                frmAdministrator.ShowDialog();
            }
            catch (Exception)
            {
                base.Uninstall(StateSaver);
            }
        }

        public void CompleateInstall()
        {
            try
            {
                if (this.IsAdministratorLogin)
                {
                    base.Install(StateSaver);
                }
                else
                {
                    base.Uninstall(StateSaver);
                }
            }
            catch (Exception)
            {
                base.Uninstall(StateSaver);
            }
        }
    }
}
