using IhalematikProBL.Entity;
using IhalematikProBL.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleApplicationBase.BL.Base;
using System.Dynamic;

namespace IhalematikPro.Model
{
    public class MaterialListModel : CustomSaveableModelBase
    {
        public float KDVPercentage { get; set; }
        public double KDVAmount
        {
            get
            {
                if (this.pozOBF == null)
                {
                    return 0;
                }
                return Math.Round((this.KDVPercentage * this.pozOBF.UnitPrice / 100 * this.Quantity), 2);
            }
        }

        public double TotalAmount
        {
            get
            {
                if (this.pozOBF == null)
                {
                    return 0;
                }
                return Math.Round(this.pozOBF.UnitPrice * this.Quantity, 2);
            }
        }
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

        public bool IsWorkship { get; set; }
        public double Markup { get; set; }

        public double UnitMarkup
        {
            get
            {
                return Math.Round(this.Markup * this.PozOBF.UnitPrice / 100, 2);
            }
        }

        public double TotalMarkup
        {
            get
            {
                return Math.Round(this.UnitMarkup * this.Quantity, 2);
            }
        }

        public double WorkerMarkup { get; set; }

        public double MaterialMarkup { get; set; }

        public double MarkupUnitPrice
        {
            get
            {
                return Math.Round(this.PozOBF.UnitPrice + this.UnitMarkup, 2);
            }
        }

        public dynamic GeneralProperty = new ExpandoObject() as IDictionary<string, Object>;

        public MaterialListModel()
        {

        }
        public MaterialListModel(MaterialList Entity)
        {
            this.IsWorkship = Entity.IsWorkship;
            this.KDVPercentage = Entity.KDVPercentage;
            this.PozOBFId = Entity.PozOBFId;
            this.Quantity = Entity.Quantity;
            this.Id = Entity.Id;
            this.IsPoz = Entity.IsPoz;
            this.Markup = Entity.Markup;
        }

        public override EntityBase ToEntity()
        {
            MaterialList materialList = new MaterialList();
            materialList.Id = this.Id.Value;
            materialList.IsPoz = this.IsPoz;
            materialList.IsWorkship = this.IsWorkship;
            materialList.KDVPercentage = this.KDVPercentage;
            materialList.Markup = this.Markup;
            materialList.PozOBFId = this.PozOBFId;
            materialList.Quantity = this.Quantity;
            return materialList;
        }

        protected override void SaveEntity(EntityBase Entity)
        {
            MaterialListProvider.Instance.Save(Entity);
        }
    }
}
