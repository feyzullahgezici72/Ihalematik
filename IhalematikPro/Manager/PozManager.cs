using IhalematikPro.Model;
using IhalematikProBL.Entity;
using IhalematikProBL.Provider;
using SimpleApplicationBase.BL.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhalematikPro.Manager
{
    public class PozManager : SingletonBase<PozManager>
    {
        public List<PozModel> GetPozs()
        {
            List<Poz> pozs = PozProvider.Instance.GetItems();
            List<PozModel> models = CustomSaveableModelBase.GetModels<PozModel, Poz>(pozs);
            return models;
        }

        public List<PozModel> GetPozs(string PozNumber)
        {
            List<Poz> pozs = PozProvider.Instance.GetItems("Number", PozNumber);
            List<PozModel> models = CustomSaveableModelBase.GetModels<PozModel, Poz>(pozs);
            return models;
        }

        public Poz GetPoz(string PozNumber)
        {
            List<Poz> pozs = PozProvider.Instance.GetItems("Number", PozNumber);
            if (pozs.Count != 0)
            {
                return pozs.First();
            }
            return null;
        }
    }
}
