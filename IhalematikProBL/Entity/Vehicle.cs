using IhalematikProBL.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhalematikProBL.Entity
{
    public class Vehicle : CustomEntityBase
    {
        public int TitleId { get; set; }
        private VehicleTitle title { get; set; }
        public VehicleTitle Title
        {
            get
            {
                if (this.title == null)
                {
                    if (TitleId != 0)
                    {
                        this.title = VehicleTitleProvider.Instance.GetItem(this.TitleId);
                    }
                }

                return this.title;
            }
        }

        //sirket aracimi?
        public bool IsCompanyVehicle { get; set; }

        //calisacak saat
        public float WorkHour { get; set; }

        //saatlik gider
        public double HourPrice { get; set; }

        //diger giderler
        public double OtherPrice { get; set; }
    }
}
