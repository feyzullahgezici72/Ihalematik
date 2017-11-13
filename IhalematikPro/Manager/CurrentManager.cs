using IhalematikPro.Model;
using IhalematikProBL.Entity;
using IhalematikProUI.Forms;
using SimpleApplicationBase.BL.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhalematikPro.Manager
{
    public class CurrentManager : SingletonBase<CurrentManager>
    {
        public List<VehicleModel> Vehicles { get; set; }
        public List<WorkerModel> Workers { get; set; }

        public Tender CurrentTender { get; set; }
        public Company CurrentCompany { get; set; }
    }
}
