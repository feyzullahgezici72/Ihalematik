using IhalematikProBL.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhalematikProBL.Entity
{
    public class TenderEquipment : CustomEntityBase
    {
        public int Quantity { get; set; }
        public int TenderId { get; set; }
        private Tender tender { get; set; }
        public Tender Tender
        {
            get
            {
                if (this.tender == null)
                {
                    if (this.TenderId != 0)
                    {
                        this.tender = TenderProvider.Instance.GetItem(this.TenderId);
                    }
                }
                return this.tender;
            }
        }
        public int WorkerVehicleId { get; set; }
        public bool IsWorker { get; set; }

        private CustomEntityBase workerVehicle { get; set; }
        public CustomEntityBase WorkerVehicle
        {
            get
            {
                if (this.workerVehicle == null)
                {
                    if (this.IsWorker)
                    {
                        this.workerVehicle = WorkerProvider.Instance.GetItem(this.WorkerVehicleId);
                    }
                    else
                    {
                        this.workerVehicle = VehicleProvider.Instance.GetItem(this.WorkerVehicleId);
                    }
                }
                return this.workerVehicle;
            }
        }

        public Fare UnitPrice
        {
            get
            {
                if (this.IsWorker)
                {
                    return ((Worker)this.WorkerVehicle).TotalFare;
                }
                else
                {
                    return ((Vehicle)this.workerVehicle).TotalFare;
                }
            }
        }

        public override string ToString()
        {
            if (this.IsWorker)
            {
                return ((Worker)this.WorkerVehicle).Title.Name;
            }
            else
            {
                return ((Vehicle)this.WorkerVehicle).Title.Name;
            }
        }

    }
}
