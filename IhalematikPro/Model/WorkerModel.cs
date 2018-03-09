using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleApplicationBase.BL.Base;
using IhalematikProBL.Entity;
using IhalematikProBL.Provider;
using IhalematikProUI.Manager;
using IhalematikProBL.Enum;

namespace IhalematikPro.Model
{
    public class WorkerModel : CustomSaveableModelBase
    {
        public string Code { get; set; }

        public int TitleId { get; set; }
        private Title title { get; set; }
        public Title Title
        {
            get
            {
                if (this.title == null)
                {
                    if (this.TitleId != 0)
                    {
                        this.title = TitleProvider.Instance.GetItem(this.TitleId);
                    }
                }

                return this.title;
            }
            set
            {
                this.title = value;
                if (this.title != null)
                {
                    this.TitleId = this.title.Id;
                }
            }
        }

        public WorkerTypesEnum WorkerType { get; set; }

        //Net Maas
        public Fare BaseFare { get; set; }

        //SGK Prim Kesintisi
        public Fare SGKPrimFare { get; set; }

        //Issizlik sigorta fonu
        public Fare WorklesFonFare { get; set; }

        //Gelir Vergisi
        public Fare IncomeTaxFare { get; set; }

        //Kidem Tazminati
        public Fare SeveranceFare { get; set; }

        //AGI
        public Fare AGIFare { get; set; }


        //Damga Vergisi
        public Fare StampTaxFare { get; set; }

        //Yemek ucreti
        public Fare FoodFare { get; set; }

        //Yol ucreti
        public Fare TravelFare { get; set; }

        //Konaklama ucreti
        public Fare HotelFare { get; set; }

        public Fare ISGFare { get; set; }

        //Diger ucretler
        public Fare ExtraFare { get; set; }

        public bool IsActive { get; internal set; }

        public Fare TotalFare
        {
            get
            {
                double totalAmount = this.AGIFare.Amount + this.BaseFare.Amount + this.ExtraFare.Amount + (this.FoodFare.Amount * RuleManager.Instance.DayPerMonthValue) + (this.HotelFare.Amount * RuleManager.Instance.DayPerMonthValue) + this.ISGFare.Amount + this.SGKPrimFare.Amount + this.StampTaxFare.Amount + (this.TravelFare.Amount * RuleManager.Instance.DayPerMonthValue) + this.WorklesFonFare.Amount + this.IncomeTaxFare.Amount + this.SeveranceFare.Amount;

                return new Fare(totalAmount);
            }
        }

        public Fare DayFare
        {
            get
            {
                return new Fare(Math.Round((this.TotalFare.Amount / RuleManager.Instance.DayPerMonthValue), 2));
            }
        }

        public Fare HourFare
        {
            get
            {
                return new Fare(Math.Round((this.DayFare.Amount / RuleManager.Instance.HourPerDayValue), 2));
            }
        }

        public Fare MinuteFare
        {
            get
            {
                return new Fare(Math.Round((this.HourFare.Amount / 60), 2));
            }
        }

        public string DisplayText
        {
            get
            {
                return this.Title.Name;
            }
        }

        public WorkerModel()
        {

        }

        public WorkerModel(Worker Entity)
        {
            this.AGIFare = Entity.AGIFare;
            this.BaseFare = Entity.BaseFare;
            this.Code = Entity.Code;
            this.ExtraFare = Entity.ExtraFare;
            this.FoodFare = Entity.FoodFare;
            this.HotelFare = Entity.HotelFare;
            this.Id = Entity.Id;
            this.ISGFare = Entity.ISGFare;
            this.WorkerType = Entity.WorkerType;
            this.SGKPrimFare = Entity.SGKPrimFare;
            this.StampTaxFare = Entity.StampTaxFare;
            this.Title = Entity.Title;
            this.TravelFare = Entity.TravelFare;
            this.SeveranceFare = Entity.SeveranceFare;
            this.IncomeTaxFare = Entity.IncomeTaxFare;
            this.WorklesFonFare = Entity.WorklesFonFare;
            this.IsActive = Entity.IsActive;
        }
        public override EntityBase ToEntity()
        {
            Worker worker = new Worker();
            worker.AGIFare = this.AGIFare;
            worker.BaseFare = this.BaseFare;
            worker.Code = this.Code;
            worker.ExtraFare = this.ExtraFare;
            worker.FoodFare = this.FoodFare;
            worker.HotelFare = this.HotelFare;
            if (this.Id.HasValue)
            {
                worker.Id = this.Id.Value;
            }
            worker.ISGFare = this.ISGFare;
            worker.WorkerType = this.WorkerType;
            worker.SGKPrimFare = this.SGKPrimFare;
            worker.StampTaxFare = this.StampTaxFare;
            worker.Title = this.Title;
            worker.TravelFare = this.TravelFare;
            worker.SeveranceFare = this.SeveranceFare;
            worker.IncomeTaxFare = this.IncomeTaxFare;
            worker.WorklesFonFare = this.WorklesFonFare;
            worker.IsActive = this.IsActive;
            return worker;
        }

        protected override void SaveEntity(EntityBase Entity)
        {
            WorkerProvider.Instance.Save(Entity);
        }
    }
}
