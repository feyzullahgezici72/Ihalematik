using IhalematikPro.Model;
using IhalematikProBL.Entity;
using IhalematikProBL.Provider;
using IhalematikProUI.Model;
using SimpleApplicationBase.BL.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhalematikPro.Manager
{
    public class UIWorkerManager : SingletonBase<UIWorkerManager>
    {
        public List<WorkerModel> GetWorkers()
        {
            List<Worker> workers = WorkerProvider.Instance.GetItems();
            List<WorkerModel> models = CustomSaveableModelBase.GetModels<WorkerModel, Worker>(workers);
            return models;
        }

        public List<DropDownModel> GetDropDownWorkers()
        {
            List<Worker> workers = WorkerProvider.Instance.GetItems().Where(p=> p.IsActive).ToList();
            List<DropDownModel> models = new List<DropDownModel>();
            foreach (var item in workers)
            {
                DropDownModel model = new DropDownModel()
                {
                    Id = item.Id,
                    Text = item.Title.Name
                };
                models.Add(model);
            }
            return models;
        }
    }
}
