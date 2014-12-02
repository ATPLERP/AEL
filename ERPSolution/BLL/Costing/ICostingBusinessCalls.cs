using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Advantage.ERP.BLL.Costing
{
    public interface ICostingBusinessCalls
    {
        void gMsCreateChargeMaster(DAL.DataContract.Costing.ChargeMaster objapp);
    }
}
