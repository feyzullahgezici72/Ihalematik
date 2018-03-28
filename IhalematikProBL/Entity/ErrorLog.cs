using SimpleApplicationBase.BL.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhalematikProBL.Entity
{
    public class ErrorLog : CustomEntityBase
    {
        public ErrorLogTypesEnum LogType { get; set; }
        public string Message { get; set; }

        public ErrorLog()
        {

        }

        public ErrorLog(Exception Exception)
        {
            this.Message = Exception.ToString();
        }
    }
}
