using IhalematikProBL.Entity;
using IhalematikProBL.Manager;
using SimpleApplicationBase.BL.Base;
using SimpleApplicationBase.BL.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleApplicationBase.Toolkit;

namespace IhalematikProBL.Provider
{
    [Serializable]
    public abstract class CustomEntityBaseProvider<T, K> : EntityBaseProvider<T, K, int>
          where T : CustomEntityBase
          where K : ProviderBase
    {
        protected override DBConnectionManager ConnectionManager
        {
            get
            {
                return CustomDBConnectionManager.Instance;
            }
        }

        public CustomEntityBaseProvider()
            : base()
        {
            string typeName = typeof(T).Name;
            this.InsertSp = typeName + "_Insert";
            this.UpdateSp = typeName + "_Update";
            this.SelectSp = typeName + "_Select";
            this.DeleteSp = typeName + "_Delete";
            this.EnableCaching = false;
            this.CacheManager = (Microsoft.Practices.EnterpriseLibrary.Caching.CacheManager)Microsoft.Practices.EnterpriseLibrary.Caching.CacheFactory.GetCacheManager();
        }

        protected override void Initialize(T t, Dictionary<string, object> dr)
        {
            t.Id = dr.GetValue<int>("Id");
            t.InsertTime = dr.GetValue<DateTime>("InsertTime");
        }

        protected override Hashtable GetCommonParameters(T t)
        {
            Hashtable parameters = new Hashtable();
            return parameters;
        }

        public override OperationResult Save(T t)
        {
            OperationResult result = base.Save(t);   
            return result;
        }
    }
}
