using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleApplicationBase.BL.Base;
using IhalematikProBL.Entity;
using IhalematikPro.Manager;
using IhalematikProBL.Provider;

namespace IhalematikPro.Model
{
    public class OBFModel : CustomSaveableModelBase
    {

        public string Number { get; set; }
        public string Description { get; set; }
        public string Unit { get; set; }
        public double UnitPrice { get; set; }

        public OBFModel(OBF Entity)
        {
            this.Number = Entity.Number;
            this.Unit = Entity.Unit;
            this.UnitPrice = Entity.UnitPrice;
            this.Description = Entity.Description;
            this.Id = Entity.Id;
        }

        public OBFModel()
        {

        }

        public override EntityBase ToEntity()
        {
            OBF OBF = new OBF();
            OBF.Description = this.Description;
            if (this.Id.HasValue)
            {
                OBF.Id = this.Id.Value;
            }
            OBF.Number = this.Number;
            OBF.Unit = this.Unit;
            OBF.UnitPrice = this.UnitPrice;
            return OBF;
        }

        protected override void SaveEntity(EntityBase Entity)
        {
            OBF OBF = (OBF)Entity;

            if (OBF.Id == 0)
            {
                OBF existingOBF = UIOBFManager.Instance.GetOBF(OBF.Number);
                if (existingOBF != null)
                {
                    System.Windows.Forms.MessageBox.Show("Bu OBF numarasi ile kayit bulunmaktadir");

                }//OBFProvider.Instance.get
                else
                {
                    OperationResult result = OBFProvider.Instance.Save(Entity);
                    if (result.Success)
                    {
                        System.Windows.Forms.MessageBox.Show("OBF Kaydedildi");
                    }
                }
            }
        }
    }
}
