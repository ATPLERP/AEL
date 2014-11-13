using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Advantage.ERP.DAL.DataContract.Inventory
{
    public partial class ItemMst
    {
        public int pItemCode { get; set; }
        public string pOrgCode { get; set; }
        public string pStockCode { get; set; }
        public string pItemDescription { get; set; }
        public string pMajorGroup { get; set; }
        public string pAppliance { get; set; }
        public string pBrand { get; set; }
        public string pModelNo { get; set; }
        public string pCapacity { get; set; }
        public string pPurchaseType { get; set; }
        public string pFSN { get; set; } // Gone for Asset: Fix Asset / Sandry (Fix asset but deprisiation is very high / none )
        public Nullable<decimal> pVATPercentage { get; set; }
        public string pUoM { get; set; }
        public Nullable<int> pLifeTime { get; set; }
        public string pObsolete { get; set; }
        public string pHSCode { get; set; }
        public string pLastGRNNo { get; set; }
        public Nullable<decimal> pLastInCost { get; set; }
        public Nullable<decimal> pAverageCost { get; set; }
        public string pStockApplicable { get; set; }
        public string pLedgerCode { get; set; }
        public string pCreatedBy { get; set; }
        public Nullable<System.DateTime> pCreateDate { get; set; }
        public string pUpDatedBy { get; set; }
        public Nullable<System.DateTime> pUpDatedDate { get; set; }
        public Nullable<decimal> pInstllationAmt { get; set; }
        public string pPartNo { get; set; }
        public string pST { get; set; }
        public string pNormCode { get; set; }
        public string pRateCategory { get; set; }
        public string pJobType { get; set; }
        public string pDuration { get; set; }
        public Nullable<decimal> pMeterial { get; set; }
        public Nullable<decimal> pLabour { get; set; }
        public Nullable<decimal> pPoints { get; set; }
        public string pCommonJob { get; set; }
    }
}
