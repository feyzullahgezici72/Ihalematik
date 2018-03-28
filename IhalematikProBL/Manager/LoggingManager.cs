using IhalematikProBL.Entity;
using IhalematikProBL.Provider;
using SimpleApplicationBase.BL.Base;
using SimpleApplicationBase.BL.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhalematikProBL.Manager
{
    public class LoggingManager : SingletonBase<LoggingManager>
    {
        public void SaveErrorLog(Exception Exception)
        {
            ErrorLog errorLog = new ErrorLog(Exception);
            errorLog.LogType = ErrorLogTypesEnum.Exception;
            ErrorLogProvider.Instance.Save(errorLog);
        }
    }
}
