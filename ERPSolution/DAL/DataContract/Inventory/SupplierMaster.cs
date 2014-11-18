using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Advantage.ERP.DAL.DataContract.Inventory
{
    public partial class SupplierMst
    {
        public string pOrgCode { get; set; }
        public string pSupplierCode { get; set; }
        public string pPrefix { get; set; }
        public string pSupplierName { get; set; }
        public string pAddress { get; set; }
        public string pCountry { get; set; }
        public string pContactPerson { get; set; }
        public string pMobileNo { get; set; }
        public string pPhoneNo1 { get; set; }
        public string pPhoneNo2 { get; set; }
        public string pFax { get; set; }
        public string pEmail { get; set; }
        public string pVATNo { get; set; }
        public string pTypeOfSupplier { get; set; }
        public string pPurchaseType { get; set; }
        public Nullable<int> pLeadTime { get; set; }
        public Nullable<decimal> pCreditLimit { get; set; }
        public Nullable<int> pCreditLimitTime { get; set; }
        public Nullable<System.DateTime> pLastPurchaseDate { get; set; }
        public Nullable<decimal> pCurrentCreditAmount { get; set; }
        public string pVATApplicable { get; set; }
        public string pCategory { get; set; }
        public string pCreatedBy { get; set; }
        public Nullable<System.DateTime> pCreateDate { get; set; }
        public string pUpDatedBy { get; set; }
        public Nullable<System.DateTime> pUpDatedDate { get; set; }
    }
}
