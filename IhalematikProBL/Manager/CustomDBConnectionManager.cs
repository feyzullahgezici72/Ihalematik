using SimpleApplicationBase.BL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhalematikProBL.Manager
{
    [Serializable]
    public class CustomDBConnectionManager : MsSqlDBConnectionManager<CustomDBConnectionManager>
    {
        protected override string GetConnectionStringName()
        {
            return "Stonefish.Sabre.MSSQL";
        }
    }
}
