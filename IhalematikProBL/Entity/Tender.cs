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

        public string CompanyName { get; set; }
        public string EkapNumber { get; set; }
        public string Type { get; set; }
        //ihalenin kapsami
        public string Scope { get; set; }
        //Ihalenin Usulu
        public string Procedure { get; set; }
        //ihalenin yeri
        public string Place { get; set; }
        //Ust Idare
        public string Management { get; set; }

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
                //if (this.Offer != null)
                //{
                //    this.materialList = new List<Entity.MaterialList>();

                //    foreach (var item in this.Offer.MaterialList)
                //    {
                //        MaterialList materialList = new MaterialList().ToMaterialList(item);
                //        this.materialList.Add(materialList);
                //    }
                //}

                if (this.materialList == null)
                {
                    this.materialList = MaterialListProvider.Instance.GetItems("TenderId", this.Id);
                }

                return this.materialList;
            }
            set
            {
                this.materialList = value;
            }
        }

        private List<TenderGroup> groups = null;
        public List<TenderGroup> Groups
        {
            get
            {
                if (this.groups == null || this.groups.Count == 0)
                {
                    this.groups = TenderGroupProvider.Instance.GetItems("TenderId", this.Id);
                }

                return this.groups;
            }
            set
            {
                this.groups = value;
            }
        }

        public int OfferId { get; set; }
        private Offer offer { get; set; }
        public Offer Offer
        {
            get
            {
                if (this.offer == null && this.OfferId != 0)
                {
                    this.offer = OfferProvider.Instance.GetItem(this.OfferId);
                }
                return this.offer;
            }
        }
    }
}
