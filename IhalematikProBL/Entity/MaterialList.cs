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
        public float KDVPercentage { get; set; }
        public double KDVAmount
        {
            get
            {
                return Math.Round((this.KDVPercentage * this.pozOBF.UnitPrice / 100 * this.Quantity), 2);
            }
        }

        public double TotalAmount
        {
            get
            {
                return Math.Round(this.pozOBF.UnitPrice * this.Quantity, 2);// hata verdi
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
        }


    }
}
