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

        public UnitTimeTypesModel Self { get { return this; } }
    }
}
