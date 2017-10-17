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
    public class UITitleManager : SingletonBase<UITitleManager>
    {
        public List<TitleModel> GetTitles()
        {
            List<Title> titles = TitleProvider.Instance.GetItems();
            List<TitleModel> models = CustomSaveableModelBase.GetModels<TitleModel, Title>(titles);

            return models;
        }
    }
}
