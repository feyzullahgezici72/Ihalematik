using IhalematikPro.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleApplicationBase.BL.Base;
using IhalematikProBL.Entity;
using IhalematikProBL.Provider;

namespace IhalematikProUI.Model
{
    class SubSupplierModel : CustomSaveableModelBase
    {
        public bool IsSelected { get; set; }
        public List<SubSupplierSegment> segments { get; set; }
        public List<SubSupplierSegment> Segments
        {
            get
            {
                if (this.segments == null)
                {
                    this.segments = SupplierSegmentProvider.Instance.GetItems();
                }
                return this.segments;
            }
            set
            {
                this.segments = value;
            }
        }

        public string SegmentText
        {
            get
            {
                return string.Join(", ", this.Segments.Select(p => p.Name));
            }
        }
        public string CompanyName { get; set; }
        public string AuthorNameSurname { get; set; }
        public string GSM { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Score { get; set; }
        public string Address { get; set; }
        public bool IsActive { get; set; }
        public string Country { get; set; }
        public string TaxOffice { get; private set; }
        public string TaxNumber { get; private set; }

        public SubSupplierModel(Supplier Entity)
        {
            this.Address = Entity.Address;
            this.AuthorNameSurname = Entity.AuthorNameSurname;
            this.CompanyName = Entity.CompanyName;
            this.Country = Entity.Country;
            this.Email = Entity.Email;
            this.GSM = Entity.GSM;
            this.IsActive = Entity.IsActive;
            this.Id = Entity.Id;
            this.Score = Entity.Score;
            this.Segments = Entity.Segments;
            this.Telephone = Entity.Telephone;
            this.TaxOffice = Entity.TaxOffice;
            this.TaxNumber = Entity.TaxNumber;

            this.IsSelected = false;
        }

        public override EntityBase ToEntity()
        {
            throw new NotImplementedException();
        }

        protected override void SaveEntity(EntityBase Entity)
        {
            throw new NotImplementedException();
        }
    }
}
