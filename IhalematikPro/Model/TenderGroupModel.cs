using IhalematikPro.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleApplicationBase.BL.Base;
using IhalematikProBL.Entity;
using IhalematikProBL.Provider;

namespace IhalematikProUI.Model
{
    public class TenderGroupModel : CustomSaveableModelBase
    {
        public bool SelectedId { get; set; }
        private Tender tender { get; set; }
        public int TenderId { get; set; }
        public Tender Tender
        {
            get
            {
                if (this.tender == null)
                {
                    this.tender = TenderProvider.Instance.GetItem(this.TenderId);
                }
                return this.tender;
            }
            set
            {
                this.tender = value;
                this.TenderId = this.tender.Id;
            }
        }
        public string Description { get; set; }
        public int ItemNumber { get; internal set; }

        public TenderGroupModel()
        {

        }

        public TenderGroupModel(TenderGroup TenderGroup)
        {
            this.Description = TenderGroup.Description;
            this.Tender = TenderGroup.Tender;
            this.Id = TenderGroup.Id;
        }

        public override EntityBase ToEntity()
        {
            TenderGroup tenderGroup = new TenderGroup();
            tenderGroup.Description = this.Description;
            tenderGroup.Tender = this.Tender;
            if (this.Id.HasValue)
            {
                tenderGroup.Id = this.Id.Value;
            }

            return tenderGroup;
        }

        protected override void SaveEntity(EntityBase Entity)
        {
            TenderGroupProvider.Instance.Save(Entity);
        }
    }
}
