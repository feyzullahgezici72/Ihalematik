using SimpleApplicationBase.BL.Base;
using SimpleApplicationBase.Toolkit;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace IhalematikProBL.Manager
{
    public class CustomConfigurationManager : SingletonBase<CustomConfigurationManager>
    {
        public string SmtpAdress
        {
            get
            {
                return ConfigurationManager.AppSettings["SmtpAdress"];
            }
        }

        public int SmtpPort
        {
            get
            {
                return int.Parse(ConfigurationManager.AppSettings["SmtpPort"]);
            }
        }

        public string SmtpUserName
        {
            get
            {
                return ConfigurationManager.AppSettings["SmtpUserName"];
            }
        }

        public string SmtpPassword
        {
            get
            {
                return ConfigurationManager.AppSettings["SmtpPassword"];
            }
        }

        public string SmtpMailSender
        {
            get
            {
                return ConfigurationManager.AppSettings["SmtpMailSender"];
            }
        }

        public string SmtpMailSenderDisplayName
        {
            get
            {
                return ConfigurationManager.AppSettings["SmtpMailSenderDisplayName"];
            }
        }

        public bool UseOfflineResults
        {
            get
            {
                return Helpers.GetValueFromObject<bool>(ConfigurationManager.AppSettings["UseOfflineResults"]);
            }
        }

        public string ApplicationUrl
        {
            get
            {
                string baseUrl = HttpContext.Current.Request.Url.Scheme + "://" + HttpContext.Current.Request.Url.Authority +
                HttpContext.Current.Request.ApplicationPath.TrimEnd('/') + "/";

                return baseUrl;
            }
        }

        public string ErrorEMailAddresses
        {
            get
            {
                return ConfigurationManager.AppSettings["ErrorEMailAddresses"];
            }
        }

        public string GetValue(string Key)
        {
            return ConfigurationManager.AppSettings[Key];
        }

        public string PassPhrase
        {
            get
            {
                return ConfigurationManager.AppSettings["PassPhrase"];
            }
        }
    }
}
