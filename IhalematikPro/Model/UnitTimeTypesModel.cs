using IhalematikProBL.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhalematikProUI.Model
{
    public class UnitTimeTypesModel
    {
        public UnitTimeTypesEnum UnitTimeType { get; set; }
        public int Id { get; set; }
        public string DisplayText { get; set; }

        public UnitTimeTypesModel Create(UnitTimeTypesEnum Item)
        {
            UnitTimeTypesModel model = new UnitTimeTypesModel();
            model.DisplayText = this.GetUnitTimeTypesDisplayText(Item);
            model.Id = (int)Item;
            model.UnitTimeType = Item;
            return model;
        }
        private string GetUnitTimeTypesDisplayText(UnitTimeTypesEnum UnitTimeType)
        {
            string displayText = string.Empty;
            switch (UnitTimeType)
            {
                case UnitTimeTypesEnum.Minute:
                    displayText = "Dakika";
                    break;
                case UnitTimeTypesEnum.Hour:
                    displayText = "Saat";
                    break;
                case UnitTimeTypesEnum.Day:
                    displayText = "Gün";
                    break;
                case UnitTimeTypesEnum.Week:
                    displayText = "Hafta";
                    break;
                case UnitTimeTypesEnum.Month:
                    displayText = "Ay";
                    break;
                case UnitTimeTypesEnum.Year:
                    displayText = "Yıl";
                    break;
                default:
                    break;
            }

            return displayText;
        }
    }
}
