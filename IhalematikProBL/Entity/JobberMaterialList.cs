using IhalematikProBL.Enum;
using IhalematikProBL.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhalematikProBL.Entity
{
    public class JobberMaterialList : CustomEntityBase
    {
        public int JobberTenderId { get; set; }
        private JobberTender jobberTender { get; set; }
        public JobberTender JobberTender
        {
            get
            {
                if (this.jobberTender == null)
                {
                    this.jobberTender = JobberTenderProvider.Instance.GetItem(this.JobberTenderId);
                }
                return this.jobberTender;
            }
            set
            {
                this.jobberTender = value;
                this.JobberTenderId = this.jobberTender.Id;
            }
        }

        public int MaterialListId { get; set; }
        private MaterialList materialList { get; set; }
        public MaterialList MaterialList
        {
            get
            {
                if (this.materialList == null)
                {
                    this.materialList = MaterialListProvider.Instance.GetItem(this.MaterialListId);
                }
                return this.materialList;
            }
            set
            {
                this.materialList = value;
                this.MaterialListId = this.materialList.Id;
            }
        }

        public JobberTypesEnum JobberType { get; set; }

        public int JobberTypeValue { get; set; }
    }
}
