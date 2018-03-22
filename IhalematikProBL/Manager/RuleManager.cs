using IhalematikProBL.Provider;
using SimpleApplicationBase.BL.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhalematikProBL.Manager
{
    public class RuleManager : SingletonBase<RuleManager>
    {
        public int HourPerDayValue
        {
            get
            {
                return int.Parse(RuleProvider.Instance.GetOne("Code", "HourPerDayValue").Value);
            }
        }

        public int DayPerMonthValue
        {
            get
            {
                return int.Parse(RuleProvider.Instance.GetOne("Code", "DayPerMonthValue").Value);
            }
        }
    }
}
