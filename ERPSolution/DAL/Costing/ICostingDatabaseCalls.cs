using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Advantage.ERP.DAL.Costing
{

    public interface ICostingDatabaseCalls
    {
        bool gMsCreateChargeMaster(DAL.DataContract.Costing.ChargeMaster objapp);
        int GenerateChargeNo(DAL.DataContract.Costing.ChargeMaster objMst);
    }
}
