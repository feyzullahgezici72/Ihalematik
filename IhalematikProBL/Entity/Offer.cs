using IhalematikProBL.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhalematikProBL.Entity
{
    public class Offer : CustomEntityBase
    {
        public string Number { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

        private List<MaterialList> materialList { get; set; }
        public List<MaterialList> MaterialList
        {
            get
            {
                if (this.materialList == null)
                {
                    this.materialList = MaterialListProvider.Instance.GetItems("TenderId", this.Id);
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
