using IhalematikProBL.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhalematikProBL.Entity
{
    public class OfferMaterialList : CustomEntityBase
    {
        public bool IsPoz { get; set; }

        public int PozOBFId { get; set; }
        private Material pozOBF { get; set; }
        public Material PozOBF
        {
            get
            {
                if (this.pozOBF == null)
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
                }

                return this.pozOBF;
            }
        }

        public float Quantity { get; set; }

        public int OfferId { get; set; }
        private Offer offer { get; set; }
        public Offer Offer
        {
            get
            {
                if (this.offer == null)
                {
                    if (this.OfferId != 0)
                    {
                        this.offer = OfferProvider.Instance.GetItem(this.OfferId);
                    }
                }
                return this.offer;
            }
            set
            {
                this.offer = value;
                this.OfferId = this.offer.Id;
            }
        }
        public bool IsSelected { get; set; }

    }
}
