using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Advantage.ERP.DAL.DataContract.Inventory
{
    public partial class I_SupplierMaster
    {
        public string OrgCode { get; set; }
        public string SupplierCode { get; set; }
        public string Prefix { get; set; }
        public string SupplierName { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string ContactPerson { get; set; }
        public string MobileNo { get; set; }
        public string PhoneNo1 { get; set; }
        public string PhoneNo2 { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string VATNo { get; set; }
        public string TypeOfSupplier { get; set; }
        public string PurchaseType { get; set; }
        public Nullable<int> LeadTime { get; set; }
        public Nullable<decimal> CreditLimit { get; set; }
        public Nullable<int> CreditLimitTime { get; set; }
        public Nullable<System.DateTime> LastPurchaseDate { get; set; }
        public Nullable<decimal> CurrentCreditAmount { get; set; }
        public string VATApplicable { get; set; }
        public string Category { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string UpDatedBy { get; set; }
        public Nullable<System.DateTime> UpDatedDate { get; set; }
    }
}
