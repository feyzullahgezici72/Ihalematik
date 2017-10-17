﻿using IhalematikProBL.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhalematikProBL.Entity
{
    public class Tender : CustomEntityBase
    {
        public string DisplayNumber
        {
            get
            {
                return string.Format("{0}", (this.Number).ToString().PadLeft(8, '0'));
            }
        }
        public int Number { get; set; }
        public string Description { get; set; }
        public DateTime? LastOfferDate { get; set; }
        public bool IsActive { get; set; }

        private List<TenderEquipment> equipments { get; set; }
        public List<TenderEquipment> Equipments
        {
            get
            {
                if (this.equipments == null)
                {
                    this.equipments = TenderEquipmentProvider.Instance.GetItems("TenderId", this.Id);
                }
                return this.equipments;
            }

            set
            {
                this.equipments = value;
            }
        }

        private List<MaterialList> materialList { get; set; }
        public List<MaterialList> MaterialList
        {
            get
            {
                if (this.materialList == null)
                {
                    this.materialList = MaterialListProvider.Instance.GetItems("TenderId", this.Id);
                }

                return this.materialList;
            }
        }
    }
}
