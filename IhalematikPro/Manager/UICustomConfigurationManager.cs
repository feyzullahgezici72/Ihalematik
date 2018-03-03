using SimpleApplicationBase.BL.Base;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhalematikProUI.Manager
{
    public class UICustomConfigurationManager : SingletonBase<UICustomConfigurationManager>
    {
        public string Mode
        {
            get
            {
                return ConfigurationManager.AppSettings["Mode"];
            }
        }
    }
}
