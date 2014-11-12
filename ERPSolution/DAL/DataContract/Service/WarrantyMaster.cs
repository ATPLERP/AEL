using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Advantage.ERP.DAL.DataContract
{
  public  class WarrantyMst
    {
        public Int64 pTransNo { get; set; }
        public int pItemCode { get; set; }
        public string pModelNo { get; set; }
        public string pSerialNo { get; set; }
        public string pWarrantyNo { get; set; }
        public DateTime pWarrantydate { get; set; }
        public int pWarrPeriod { get; set; }
        public string pSalesOrderNo { get; set; }
        public int pCustcode { get; set; }
        public string pCustPrefix { get; set; }
        public string pCustName { get; set; }
        public string pCustAddInv { get; set; }
        public string pCustAddSer { get; set; }
        public string  pCustArea { get; set; }
        public string pCustPhoneNo { get; set; }
        public string pCustFaxNo { get; set; }
        public string pCustMobile { get; set; }
        public string pCustEmail { get; set; }
        public string pCustVATNo { get; set; }
        public string PContactInv { get; set; }
        public string pContactTech { get; set; }
        public string pVoidStatus { get; set; }
        public string pCreatedBy { get; set; }
        public DateTime pCreatedDate { get; set; }
        public string pUpdatedBy { get; set; }
        public DateTime pUpdatedDate { get; set; }
        public string pWarrStatus { get; set; }
        public DateTime pPoDate { get; set; }
        public string pBrand { get; set; }
        public string pItemDesc { get; set; }
        public string pShowRoomId { get; set; }
        public string pShowRoomName { get; set; }
        public string pLGItemCode { get; set; }
        public string pInvoiceNo { get; set; }
        public string pHpAcctNo { get; set; }
        public string pAelInvoice { get; set; }
        public DateTime pAelInvoiceDate { get; set; }
        public string pAblTransNo { get; set; }
        public string pVoidCompService { get; set; }
        public string pAblCustCode { get; set; }
        public string pWarrantyRemark { get; set; }
    }
}
