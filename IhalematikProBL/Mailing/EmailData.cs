using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhalematikProBL.Entity
{
    [Serializable]
    public class EmailData : CustomEntityBase
    {
        public string Sender { get; set; }
        public string DisplayName { get; set; }
     
        public string Recipient { get; set; }
        
        public string Subject { get; set; }
        
        public string Body { get; set; }
        public bool IsBodyHtml { get; set; }
        public string BCC { get; set; }

        public string AttachmentFileName { get; set; }
    }
}
