using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Advantage.ERP.DAL.DataContract
{
   public class QuotationTrans
    {
       public string pOrgCode { get; set; }
       public string pQuotationNo { get; set; }
       public string pBrnCd { get; set; }
       public string pCusname { get; set; }
       public string pFromDate { get; set; }
       public string pToDate { get; set; }
       public DateTime pQuoationDate { get; set; }
       public string pJobCategory { get; set; }
       public string pCustomerOrderNo { get; set; }
       public string pQuotationRemarks { get; set; }
       public string pQuotationStatus { get; set; }
       public string pAmountPaidStatus { get; set; }
       public string pCreatedBy { get; set; }
       
       public double lQty{get; set;}
       public double lPrice{get; set;}
       public double lDisPer{get; set;}
       public double lDisAmt{get; set;}
       public double lVATPer{get; set;}
       public double lVATAmt{get; set;}
       public double lNBTPer{get; set;}
       public double lNBTAmt{ get; set;}


       
    }
}
