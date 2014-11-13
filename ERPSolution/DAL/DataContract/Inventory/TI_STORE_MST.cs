using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Advantage.ERP.DAL.DataContract.Inventory
{
    public partial class TI_STORE_MST
    {
        public string ISM_ORG_CODE { get; set; }
        public string ISM_STORE_ID { get; set; }
        public string ISM_STORE_DESC { get; set; }
        public string ISM_STORE_ADD { get; set; }
        public string ISM_STORE_CITY { get; set; }
        public string ISM_STORE_PINCODE { get; set; }
        public string ISM_STORE_PROV { get; set; }
        public string ISM_PHONE1 { get; set; }
        public string ISM_PHONE2 { get; set; }
        public string ISM_FAX1 { get; set; }
        public string ISM_FAX2 { get; set; }
        public string ISM_CONT_PER { get; set; }
        public string ISM_BRANCH_CD { get; set; }
        public string ISM_STORE_LEVEL { get; set; }
        public string ISM_STORE_TYPE { get; set; }
        public Nullable<System.DateTime> ISM_CREA_DT { get; set; }
        public string ISM_CREA_BY { get; set; }
        public Nullable<System.DateTime> ISM_UPD_DT { get; set; }
        public string ISM_UPD_BY { get; set; }
    }
}
