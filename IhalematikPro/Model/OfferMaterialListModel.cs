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
    public class OfferMaterialListModel : CustomSaveableModelBase
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

            set
            {
                this.pozOBF = value;
                this.PozOBFId = this.pozOBF.Id;
            }
        }

        public string PozOBFDescription
        {
            get
            {
                if (this.PozOBF != null)
                {
                    return this.PozOBF.Description;
                }
                return string.Empty;
            }
        }

        public string PozOBFNumber
        {
            get
            {
                if (this.PozOBF != null)
                {
                    return this.PozOBF.Number;
                }
                return string.Empty;
            }
        }

        public string PozOBFUnit
        {
            get
            {
                if (this.PozOBF != null)
                {
                    return this.PozOBF.Unit;
                }
                return string.Empty;
            }
        }

        public double PozOBFUnitPrice
        {
            get
            {
                if (this.PozOBF != null)
                {
                    return this.PozOBF.UnitPrice;
                }
                return 0;
            }
        }

        public float Quantity { get; set; }
        public bool IsSelected { get;  set; }

        public OfferMaterialListModel(OfferMaterialList Entity)
        {
            this.IsPoz = Entity.IsPoz;
            this.PozOBF = Entity.PozOBF;
            this.Quantity = Entity.Quantity;
            this.Id = Entity.Id;
            this.IsSelected = false;
        }

        public override EntityBase ToEntity()
        {
            throw new NotImplementedException();
        }

        protected override void SaveEntity(EntityBase Entity)
        {
            throw new NotImplementedException();
        }
    }
}
