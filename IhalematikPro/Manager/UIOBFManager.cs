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
    public class UIOBFManager : SingletonBase<UIOBFManager>
    {

        public List<OBFModel> GetOBFs(string OBFNumber)
        {
            List<OBF> obfs = OBFProvider.Instance.GetItems("Number", OBFNumber);
            List<OBFModel> models = CustomSaveableModelBase.GetModels<OBFModel, OBF>(obfs);
            return models;
        }
        public List<OBFModel> GetOBFs()
        {
            List<OBF> items = OBFProvider.Instance.GetItems();
            List<OBFModel> models = CustomSaveableModelBase.GetModels<OBFModel, OBF>(items);
            return models;
        }

        public List<OBF> GetOBF(string PozNumber)
        {
            List<OBF> pozs = OBFProvider.Instance.GetItems("Number", PozNumber);
            if (pozs.Count != 0)
            {
                return pozs;
            }
            return null;
        }
    }
}
