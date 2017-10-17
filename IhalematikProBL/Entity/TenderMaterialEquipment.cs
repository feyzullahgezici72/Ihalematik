﻿using IhalematikProBL.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhalematikProBL.Entity
{
    public class TenderMaterialEquipment : CustomEntityBase
    {
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

        public int MaterialId { get; set; }
        private MaterialList materialList { get; set; }
        public MaterialList MaterialList
        {
            get
            {
                if (this.materialList == null)
                {
                    if (this.MaterialId != 0)
                    {
                        this.materialList = MaterialListProvider.Instance.GetItem(this.MaterialId);
                    }
                }
                return this.materialList;
            }
        }

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
        }

        public bool IsWorker { get; set; }
        public double Quantity { get; set; }
    }
}
