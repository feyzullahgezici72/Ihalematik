using IhalematikPro.Model;
using IhalematikProBL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhalematikPro.Manager
{
    public static class GlobalVeriablesManager
    {
        public static List<MaterialList> MaterialList { get; set; }
        public static List<MaterialListModel> MaterialListNonWorkship { get; set; }

        public static List<MaterialListModel> MaterialListIsWorkship { get; set; }

        public static List<VehicleModel> Vehicles { get; set; }
        public static List<WorkerModel> Workers { get; set; }

        public static Tender CurrentTender { get; set; }
    }
}
