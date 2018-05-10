using IhalematikProBL.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhalematikProBL.Entity
{
    public class JobberTender : CustomEntityBase
    {
        public int TenderId { get; set; }
        private Tender tender { get; set; }
        public Tender Tender
        {
            get
            {
                if (this.tender == null)
                {
                    this.tender = TenderProvider.Instance.GetItem(this.TenderId);
                }
                return this.tender;
            }
            set
            {
                this.tender = value;
            }
        }

        public int JobberId { get; set; }
        private Jobber jobber { get; set; }
        public Jobber Jobber
        {
            get
            {
                if (this.jobber == null)
                {
                    this.jobber = JobberProvider.Instance.GetItem(this.JobberId);
                }
                return this.jobber;
            }
            set
            {
                this.jobber = value;
            }
        }

        public string JobName { get; set; }

        public string JobDescription { get; set; }

        public double ContractPrice { get; set; }

        public DateTime? ContractDate { get; set; }
        public DateTime? StartJobDate { get; set; }
        public DateTime? EndJobDate { get; set; }

        private List<JobberMaterialList> materialList { get; set; }
        public List<JobberMaterialList> MaterialList
        {
            get
            {
                if (this.materialList == null || this.materialList.Count == 0)
                {
                    this.materialList = JobberMaterialListProvider.Instance.GetItems("JobberTenderId", this.Id);
                }

                return this.materialList;
            }
            set
            {
                this.materialList = value;
            }
        }
    }
}
