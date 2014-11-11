using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Advantage.ERP.DAL.Inventory
{
    public interface IInventoryDatabaseCalls
    {
        void Create_I_SupplierMaster(DAL.DataContract.Inventory.I_SupplierMaster objMst);
        DataSet Grid_I_SupplierMaster(DAL.DataContract.Inventory.I_SupplierMaster objMst);

        void Create_TC_ORG_MST(DAL.DataContract.Inventory.TC_ORG_MST objMst);

        void CreateTI_Store_Mst(DAL.DataContract.Inventory.TI_STORE_MST objMst);

        void CreateI_ItemMaster(DAL.DataContract.Inventory.I_ItemMaster objMst);
        DataSet Grid_ItemMasterGrid(DAL.DataContract.Inventory.I_ItemMaster objMst);

    }
}
