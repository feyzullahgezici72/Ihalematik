using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhalematikProUI.Model
{
    public class ReportModel
    {
        //Sira no
        public string ItemNumber { get; set; }

        //Is kalemi no
        public string PozOBFNumber { get; set; }

        //Is kaleminin adi ve kisa aciklamasi
        public string Description { get; set; }

        //Olcu birimi
        public string Unit { get; set; }

        public string  Quantity { get; set; }

        //Teklif Edilen birim fiyat
        public string UnitPrice { get; set; }

        //Tutar
        public string Total { get; set; }
    }
}
