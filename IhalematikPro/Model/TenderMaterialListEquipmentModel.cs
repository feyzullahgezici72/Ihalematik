using IhalematikPro.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleApplicationBase.BL.Base;
using IhalematikProBL.Entity;
using IhalematikProBL.Provider;
using IhalematikProBL.Enum;

namespace IhalematikProUI.Model
{
    public class TenderMaterialListEquipmentModel : CustomSaveableModelBase
    {
        public double Quantity { get; set; }

        //BIRIM SURE
        public double UnitTime { get; set; }

        //Zaman Tipi
        public UnitTimeTypesEnum UnitTimeType { get; set; }

        public int EquipmentId { get; set; }
        private TenderEquipment equipment { get; set; }
        public TenderEquipment Equipment
        {
            get
            {
                if (this.equipment == null)
                {
                    if (this.EquipmentId != 0)
                    {
                        this.equipment = TenderEquipmentProvider.Instance.GetItem(this.EquipmentId);
                    }
                }
                return this.equipment;
            }
            set
            {
                this.equipment = value;
                this.EquipmentId = this.equipment.Id;
            }
        }


        public TenderMaterialListEquipmentModel(TenderMaterialListEquipment Entity)
        {
            this.EquipmentId = Entity.EquipmentId;
            this.Quantity = Entity.Quantity;
            this.Id = Entity.Id;
            this.UnitTime = Entity.UnitTime;
            this.UnitTimeType = Entity.UnitTimeType;
        }

        public TenderMaterialListEquipmentModel()
        {

        }

        public override EntityBase ToEntity()
        {
            TenderMaterialListEquipment entity = new TenderMaterialListEquipment();

            entity.EquipmentId = this.EquipmentId;
            entity.Quantity = this.Quantity;
            entity.UnitTimeType = this.UnitTimeType;
            entity.UnitTime = this.UnitTime;
            if (this.Id.HasValue)
            {
                entity.Id = this.Id.Value;
            }
            return entity;
        }

        protected override void SaveEntity(EntityBase Entity)
        {
            TenderMaterialListEquipmentProvider.Instance.Save(Entity);
        }
    }
}
