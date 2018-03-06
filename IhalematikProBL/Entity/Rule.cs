using IhalematikProBL.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhalematikProBL.Entity
{
    public class Rule : CustomEntityBase
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

        public RuleTypesEnum RuleType
        {
            get
            {
                return SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<RuleTypesEnum>(this.Code);
            }
        }

        private string text = string.Empty;
        public string Text
        {
            get
            {
                switch (RuleType)
                {
                    case RuleTypesEnum.MinimumWage:
                        this.text = string.Format("{0} TL", this.Value);
                        break;
                    case RuleTypesEnum.SGKPrimFare:
                        this.text = string.Format("%{0}", this.Value);
                        break;
                    case RuleTypesEnum.WorklesFonFare:
                        this.text = string.Format("%{0}", this.Value);
                        break;
                    case RuleTypesEnum.IncomeTaxFare:
                        this.text = string.Format("%{0}", this.Value);
                        break;
                    case RuleTypesEnum.StampTaxFare:
                        this.text = string.Format("‰{0}", this.Value);
                        break;
                    case RuleTypesEnum.CompletionBond:
                        this.text = string.Format("‰{0}", this.Value);
                        break;
                    case RuleTypesEnum.ProvisionalBond:
                        this.text = string.Format("‰{0}", this.Value);
                        break;
                    case RuleTypesEnum.TradingStamps:
                        this.text = string.Format("‰{0}", this.Value);
                        break;
                    case RuleTypesEnum.HourPerDayValue:
                        this.text = string.Format("{0}", this.Value);
                        break;
                    case RuleTypesEnum.DayPerMonthValue:
                        this.text = string.Format("{0}", this.Value);
                        break;
                    default:
                        break;
                }

                return this.text;
            }
        }
    }
}
