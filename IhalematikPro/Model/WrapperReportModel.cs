using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhalematikProUI.Model
{
    public class WrapperReportModel
    {
        public List<ReportModel> Items { get; set; }

        public string TotalAmount { get; set; }

        public string TenderNumber { get; set; }
    }
}
