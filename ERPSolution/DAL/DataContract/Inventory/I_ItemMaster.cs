using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Advantage.ERP.DAL.DataContract.Inventory
{
    public partial class I_ItemMaster
    {
        public int ItemCode { get; set; }
        public string OrgCode { get; set; }
        public string StockCode { get; set; }
        public string ItemDescription { get; set; }
        public string MajorGroup { get; set; }
        public string Appliance { get; set; }
        public string Brand { get; set; }
        public string ModelNo { get; set; }
        public string Capacity { get; set; }
        public string PurchaseType { get; set; }
        public string FSN { get; set; } // Gone for Asset: Fix Asset / Sandry (Fix asset but deprisiation is very high / none )
        public Nullable<decimal> VATPercentage { get; set; }
        public string UoM { get; set; }
        public Nullable<int> LifeTime { get; set; }
        public string Obsolete { get; set; }
        public string HSCode { get; set; }
        public string LastGRNNo { get; set; }
        public Nullable<decimal> LastInCost { get; set; }
        public Nullable<decimal> AverageCost { get; set; }
        public string StockApplicable { get; set; }
        public string LedgerCode { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string UpDatedBy { get; set; }
        public Nullable<System.DateTime> UpDatedDate { get; set; }
        public Nullable<decimal> InstllationAmt { get; set; }
        public string PartNo { get; set; }
        public string ST { get; set; }
        public string NormCode { get; set; }
        public string RateCategory { get; set; }
        public string JobType { get; set; }
        public string Duration { get; set; }
        public Nullable<decimal> Meterial { get; set; }
        public Nullable<decimal> Labour { get; set; }
        public Nullable<decimal> Points { get; set; }
        public string CommonJob { get; set; }
    }
}
