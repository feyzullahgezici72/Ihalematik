using IhalematikPro.Model;
using IhalematikProBL.Entity;
using IhalematikProBL.Enum;
using IhalematikProBL.Provider;
using IhalematikProUI.Forms;
using SimpleApplicationBase.BL.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhalematikPro.Manager
{
    public class UICurrentManager : SingletonBase<UICurrentManager>
    {
        public Tender CurrentTender { get; set; }
        public Company CurrentCompany { get; set; }
        public Offer CurrentOffer { get; set; }

        public List<MaterialListModel> CurrentMaterialListModel { get; set; }

        public Member CurrentMember { get; set; }
    }
}
