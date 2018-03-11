using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhalematikProBL.Entity
{
    public class Company : CustomEntityBase
    {
        public string Name{ get; set; }
        public string Title { get; set; }
        public string BossName { get; set; }
        public string BossSurName { get; set; }
        public string Telephone1 { get; set; }
        public string Telephone2 { get; set; }
        public string Fax { get; set; }
        public string GSM { get; set; }
        public string Address { get; set; }
        public string WebAddress { get; set; }
        public string MailAddress { get; set; }
        public string MailPassword { get; set; }

        public string TaxNumber  { get; set; }

        public string TaxOffice { get; set; }
        public string LogoPath { get; set; }
    }
}
