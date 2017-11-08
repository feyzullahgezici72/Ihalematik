using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleApplicationBase.BL.Base;
using IhalematikProBL.Provider;
using IhalematikProBL.Entity;
using IhalematikPro.Manager;

namespace IhalematikPro.Model
{
    public class PozModel : CustomSaveableModelBase
    {
        public string Number { get; set; }
        public string Description { get; set; }
        public string Unit { get; set; }
        public double UnitPrice { get; set; }

        public PozModel(Poz Entity)
        {
            this.Number = Entity.Number;
            this.Unit = Entity.Unit;
            this.UnitPrice = Entity.UnitPrice;
            this.Description = Entity.Description;
            this.Id = Entity.Id;
        }

        public PozModel()
        {

        }

        public override EntityBase ToEntity()
        {
            Poz poz = new Poz();
            poz.Description = this.Description;
            if (this.Id.HasValue)
            {
                poz.Id = this.Id.Value;
            }
            poz.Number = this.Number;
            poz.Unit = this.Unit;
            poz.UnitPrice = this.UnitPrice;
            return poz;
        }

        protected override void SaveEntity(EntityBase Entity)
        {
            Poz poz = (Poz)Entity;

            //if (poz.Id == 0)
            //{
            List<Poz> existingPozs = UIPozManager.Instance.GetPoz(poz.Number);
            if (existingPozs != null)
            {
                Poz existingPoz = existingPozs.Where(p => p.Id != poz.Id).FirstOrDefault();
                if (existingPoz != null)
                {
                    System.Windows.Forms.MessageBox.Show("Bu Poz numarasi ile kayit bulunmaktadir");
                }
                else
                {
                    OperationResult result = PozProvider.Instance.Save(Entity);
                    if (result.Success)
                    {
                        System.Windows.Forms.MessageBox.Show("Poz Kaydedildi");
                    }
                }

            }
            else
            {
                OperationResult result = PozProvider.Instance.Save(Entity);
                if (result.Success)
                {
                    System.Windows.Forms.MessageBox.Show("Poz Kaydedildi");
                }
            }
        }
    }
}
