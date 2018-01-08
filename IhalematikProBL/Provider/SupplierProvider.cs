using IhalematikProBL.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleApplicationBase.Toolkit;

namespace IhalematikProBL.Provider
{
    public class SupplierProvider : CustomEntityBaseProvider<Supplier, SupplierProvider>
    {
        protected override Hashtable GetCommonParameters(Supplier t)
        {
            Hashtable parameters = base.GetCommonParameters(t);
            parameters.Add("Address", t.Address);
            parameters.Add("AuthorNameSurname", t.AuthorNameSurname);
            parameters.Add("CompanyName", t.CompanyName);
            parameters.Add("Email", t.Email);
            parameters.Add("GSM", t.GSM);
            parameters.Add("Score", t.Score);
            parameters.Add("Telephone", t.Telephone);
            parameters.Add("IsActive", t.IsActive);
            parameters.Add("Country", t.Country);
            if (t.Segments != null && t.Segments.Count != 0)
            {
                string segments = string.Join(";", t.Segments.Select(p => p.Id));
                parameters.Add("SupplierSegment", segments);
            }
            return parameters;
        }
        protected override void Initialize(Supplier t, Dictionary<string, object> dr)
        {
            base.Initialize(t, dr);
            t.Address = dr.GetValue<string>("Address");
            t.AuthorNameSurname = dr.GetValue<string>("AuthorNameSurname");
            t.CompanyName = dr.GetValue<string>("CompanyName");
            t.Email = dr.GetValue<string>("Email");
            t.GSM = dr.GetValue<string>("GSM");
            t.Score = dr.GetValue<string>("Score");
            t.Telephone = dr.GetValue<string>("Telephone");
            t.Country = dr.GetValue<string>("Country");
            t.IsActive = dr.GetValue<bool>("IsActive");

            string segments = dr.GetValue<string>("SupplierSegment");
            if (!string.IsNullOrEmpty(segments))
            {
                string[] segmentIds = segments.Split(';');
                if (segmentIds != null && segmentIds.Count() != 0)
                {
                    t.Segments = new List<SupplierSegment>();
                    foreach (var id in segmentIds)
                    {
                        SupplierSegment supplierSegment = SupplierSegmentProvider.Instance.GetItem(int.Parse(id));
                        t.Segments.Add(supplierSegment);
                    }
                }
            }
        }
    }
}
