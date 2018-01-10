using IhalematikProBL.Enum;
using IhalematikProBL.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhalematikProBL.Entity
{
    public class MaterialList : CustomEntityBase
    {
        public double Markup { get; set; }

        public double WorkerMarkup { get; set; }

        public float KDVPercentage { get; set; }
        public double KDVAmount
        {
            get
            {
                return Math.Round((this.KDVPercentage * this.PozOBF.UnitPrice / 100 * this.Quantity), 2);
            }
        }

        public double TotalAmount
        {
            get
            {
                return Math.Round(this.PozOBF.UnitPrice * this.Quantity, 2);// hata verdi
            }
        }
        public bool IsPoz { get; set; }

        public int PozOBFId { get; set; }
        private Material pozOBF { get; set; }
        public Material PozOBF
        {
            get
            {
                if (this.IsPoz)
                {
                    Poz poz = PozProvider.Instance.GetItem(this.PozOBFId);
                    this.pozOBF = new Material().CreateMaterial(poz);
                }

                else
                {
                    OBF obf = OBFProvider.Instance.GetItem(this.PozOBFId);
                    this.pozOBF = new Material().CreateMaterial(obf);
                }

                return this.pozOBF;
            }
        }

        public float Quantity { get; set; }

        public bool IsWorkship { get; set; }

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
            set
            {
                this.tender = value;
                this.TenderId = this.tender.Id;
            }
        }

        public int TenderGroupId { get; set; }
        private TenderGroup tenderGroup { get; set; }
        public TenderGroup TenderGroup
        {
            get
            {
                if (this.tenderGroup == null)
                {
                    this.tenderGroup = TenderGroupProvider.Instance.GetItem(this.TenderGroupId);
                }
                return this.tenderGroup;
            }
            set
            {
                this.tenderGroup = value;
                this.TenderGroupId = this.tenderGroup.Id;
            }
        }

        //Zaman Tipi
        public UnitTimeTypesEnum UnitTimeType { get; set; }

        //BIRIM SURE
        public int UnitTime { get; set; }

        public double OfferPrice { get; set; }

        public double CustomWorkerUnitPrice { get; set; }

        private List<TenderEquipment> tenderEquipments = null;

        public List<TenderEquipment> TenderEquipments
        {
            get
            {
                if (this.tenderEquipments == null)
                {
                    this.tenderEquipments = TenderEquipmentProvider.Instance.GetItems("TenderId", this.Tender.Id);
                }
                return this.tenderEquipments;
            }
            set
            {
                this.tenderEquipments = value;
            }
        }

        private List<TenderMaterialListEquipment> tenderMaterialListEquipment = null;

        public List<TenderMaterialListEquipment> TenderMaterialListEquipment
        {
            get
            {
                if (this.tenderMaterialListEquipment == null)
                {
                    this.tenderMaterialListEquipment = new List<IhalematikProBL.Entity.TenderMaterialListEquipment>();
                    foreach (TenderEquipment item in this.TenderEquipments)
                    {
                        Dictionary<string, object> parameters = new Dictionary<string, object>();
                        parameters.Add("TenderId", this.Tender.Id);
                        parameters.Add("MaterialId", this.Id);
                        parameters.Add("EquipmentId", item.Id);

                        TenderMaterialListEquipment tenderMaterialListEquipment = TenderMaterialListEquipmentProvider.Instance.GetItems(parameters).FirstOrDefault();
                        if (tenderMaterialListEquipment == null)
                        {
                            tenderMaterialListEquipment = new IhalematikProBL.Entity.TenderMaterialListEquipment()
                            {
                                TenderId = this.Tender.Id,
                                MaterialListId = this.Id,
                                EquipmentId = item.Id
                            };
                        }
                        this.tenderMaterialListEquipment.Add(tenderMaterialListEquipment);
                    }
                }
                return this.tenderMaterialListEquipment;
            }
            set
            {
                this.tenderMaterialListEquipment = value;
            }
        }


    }
}
