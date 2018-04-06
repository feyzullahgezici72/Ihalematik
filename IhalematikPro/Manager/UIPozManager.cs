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
    public class UIPozManager : SingletonBase<UIPozManager>
    {
        public List<Poz> GetPozs()
        {
            List<Poz> pozs = PozProvider.Instance.GetItems();
            return pozs;
        }

        public List<PozModel> GetPozs(string PozNumber, string PozDescription)
        {
            List<Poz> pozs = new List<Poz>();
            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("Number", PozNumber);
            param.Add("Description", PozDescription);
            param.Add("Year", DateTime.Now.Year);
            pozs = PozProvider.Instance.GetItems(param);
            List<PozModel> models = CustomSaveableModelBase.GetModels<PozModel, Poz>(pozs);
            return models;
        }

        public List<Poz> GetExistingPozs(string PozNumber, string PozDescription)
        {
            List<Poz> pozs = new List<Poz>();
            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("Number", PozNumber);
            param.Add("Description", PozDescription);
            param.Add("Year", DateTime.Now.Year);
            pozs = PozProvider.Instance.GetItems(param);
            return pozs;
        }

        public List<Poz> GetPoz(string PozNumber)
        {
            List<Poz> pozs = PozProvider.Instance.GetItems("Number", PozNumber);
            if (pozs.Count != 0)
            {
                return pozs;
            }
            return null;
        }
        public List<Poz> GetPozs(bool IsActive, int Year)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("IsActive", IsActive);
            parameters.Add("Year", Year);
            List<Poz> pozs = PozProvider.Instance.GetItems(parameters);
            return pozs;
        }
    }
}
