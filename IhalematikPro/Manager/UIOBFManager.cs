﻿using IhalematikPro.Model;
using IhalematikProBL.Entity;
using IhalematikProBL.Manager;
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
        public int GetLastOBFNumber()
        {
            object obfNumber = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(CustomDBConnectionManager.Instance.ExecuteScalar("OBF_GetLastNumber", new System.Collections.Hashtable()));

            return (int)obfNumber;
        }

        public List<OBFModel> GetOBFs(string OBFNumber, string OBFDescription)
        {
            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("StokNumber", OBFNumber);
            param.Add("Description", OBFDescription);
            List<OBF> obfs = OBFProvider.Instance.GetItems(param);
            List<OBFModel> models = CustomSaveableModelBase.GetModels<OBFModel, OBF>(obfs);

            List<OBFModel> items = new List<OBFModel>();

            foreach (var item in models)
            {
                if (item.Childrens.Count == 0)
                {
                    items.Add(item);
                }
                else
                {
                    items.Add(item.Childrens.OrderByDescending(p => p.InserTime).FirstOrDefault());
                }
            }


            return items;
        }
        public List<OBFModel> GetOBFs(string OBFDescription)
        {
            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("Description", OBFDescription);
            List<OBF> obfs = OBFProvider.Instance.GetItems(param);
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
