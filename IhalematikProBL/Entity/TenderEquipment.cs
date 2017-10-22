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

        private Worker worker { get; set; }
        public Worker Worker
        {
            get
            {
                if (this.worker == null)
                {
                    if (this.IsWorker)
                    {
                        this.worker = WorkerProvider.Instance.GetItem(this.WorkerVehicleId);
                    }
                }
                return this.worker;
            }
        }

        private Vehicle vehicle { get; set; }
        public Vehicle Vehicle
        {
            get
            {
                if (this.vehicle == null)
                {
                    if (!this.IsWorker)
                    {
                        this.vehicle = VehicleProvider.Instance.GetItem(this.WorkerVehicleId);
                    }
                }
                return this.vehicle;
            }
        }

        public Fare UnitPrice
        {
            get
            {
                if (this.IsWorker)
                {
                    return this.Worker.TotalFare;
                }
                else
                {
                    return this.Vehicle.TotalFare;
                }
            }
        }

        public override string ToString()
        {
            if (this.IsWorker)
            {
                return this.Worker.Title.Name;
            }
            else
            {
                return this.Vehicle.Title.Name;
            }
        }

    }
}
