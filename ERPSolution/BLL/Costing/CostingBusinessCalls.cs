using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Advantage.ERP.DAL.DataContract.Costing;
using Advantage.ERP.DAL.Costing;

namespace Advantage.ERP.BLL.Costing
{
    public class CostingBusinessCalls : ICostingBusinessCalls
    {
        public void gMsCreateChargeMaster(DAL.DataContract.Costing.ChargeMaster objapp)
        {
            CostingDatabaseCalls obj = new CostingDatabaseCalls();
            obj.gMsCreateChargeMaster(objapp);

        }

    }
}
