using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhalematikProBL.Entity
{
    [Serializable]
    public class EmailSetting : CustomEntityBase
    {
        public string Code { get; set; }

        public string Template { get; set; }

        public string Subject { get; set; }

        public string CultureCode { get; set; }
    }
}
