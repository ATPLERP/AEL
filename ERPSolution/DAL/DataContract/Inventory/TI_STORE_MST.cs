using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Advantage.ERP.DAL.DataContract.Inventory
{
    public partial class StoreMst
    {
        public string pISM_ORG_CODE { get; set; }
        public string pISM_STORE_ID { get; set; }
        public string pISM_STORE_DESC { get; set; }
        public string pISM_STORE_ADD { get; set; }
        public string pISM_STORE_CITY { get; set; }
        public string pISM_STORE_PINCODE { get; set; }
        public string pISM_STORE_PROV { get; set; }
        public string pISM_PHONE1 { get; set; }
        public string pISM_PHONE2 { get; set; }
        public string pISM_FAX1 { get; set; }
        public string pISM_FAX2 { get; set; }
        public string pISM_CONT_PER { get; set; }
        public string pISM_BRANCH_CD { get; set; }
        public string pISM_STORE_LEVEL { get; set; }
        public string pISM_STORE_TYPE { get; set; }
        public Nullable<System.DateTime> pISM_CREA_DT { get; set; }
        public string pISM_CREA_BY { get; set; }
        public Nullable<System.DateTime> pISM_UPD_DT { get; set; }
        public string pISM_UPD_BY { get; set; }
    }
}
