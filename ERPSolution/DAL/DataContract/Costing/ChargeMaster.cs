using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Advantage.ERP.DAL.DataContract.Costing
{
    public class ChargeMaster
    {
        public int pChargeNumber { get; set; }
        public string pChargeHeading { get; set; }
        public string pChargeName { get; set; }
        public bool pItemLevel { get; set; }
        public string pCreatedBy { get; set; }
        public DateTime pCreatedDate { get; set; }
        public string pUpdatedBy { get; set; }
        public DateTime pUpdatedDate { get; set; }
    }
}
