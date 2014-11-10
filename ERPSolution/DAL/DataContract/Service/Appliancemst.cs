using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Advantage.ERP.DAL.DataContract
{
    public class Appliancemst
    {

        
       public string pOrgCode { get; set; }
       public string pApplianceCode {get; set;}
       public string pApplianceName {get; set;}
       public double pStorageCost { get; set; }
       public double pEstimateCost { get; set; }
       public string pAppCategory { get; set; }

    }
}
