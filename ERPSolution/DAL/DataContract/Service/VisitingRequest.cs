using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

 namespace Advantage.ERP.DAL.DataContract.Service
     
{
    public class VisitingReq
    {
        public string pOrgcode {get; set;}
        public string pBrncode {get; set;}
        public string pVisitReqno {get; set;}
        public DateTime pVisitReqdate{get; set; }
        public string pJobcat { get; set; }
        public string pCompTakenby { get; set; }
        public string pComplainDesc { get; set; }
        public int pCustCode { get; set; }
        public string pCustprefif { get; set; }
        public string pCustomerName { get; set; }
        public string pCustomerAddressInv { get; set; }
        public string pCustomerAddressSer { get; set; }
        public string pCustArea { get; set; }
        public string pCustPhone { get; set; }
        public string pCustFax { get; set; }
        public string pCustMobile { get; set; }
        public string pCustEmail { get; set; }
        public string pCustVatno { get; set; }
        public string pContactInvoice { get; set; }
        public string pContactTech { get; set; }
        public string pInstructTech { get; set; }
        public DateTime pCustReqdate { get; set; }
        public string pVisitReqStatus { get; set; }
        public string pVisitItemCode { get; set; }
        public string pPaidStatus { get; set; }
        public int pDepatment { get; set; }
        public string pDepatName { get; set; }
        public string pCreatedBy { get; set; }
        public DateTime pCreatedDate { get; set; }
        public string pUpdatedBy { get; set; }
        public DateTime pUpdatedDate { get; set; }
        public string pSiteContactPerson { get; set; }
        public string pSiteconatctTp { get; set; }
        public string pSiteContactMobno { get; set; }
        public string Priority { get; set; }
        public int pItemCode { get; set; }
        public int pItemModel { get; set; }
        public string pItemSerial { get; set; }
        public string pWarrantyNo { get; set; }
        public DateTime pWarrantyStartDate { get; set; }
        public DateTime pWarrantyEndDate { get; set; }
        public string pItemType { get; set; }
        public string pItemCapacity { get; set; }
        public string pItemLocation { get; set; }
        public int pQty { get; set; }
        public string pJobCategory { get; set; }
        public string pJobPriority { get; set; }
    }
}
