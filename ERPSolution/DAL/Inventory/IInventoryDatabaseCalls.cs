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
        void Create_I_SupplierMaster(DAL.DataContract.Inventory.SupplierMst objMst);
        DataSet dcListSupplierMaster(DAL.DataContract.Inventory.SupplierMst objMst);

        void Create_TC_ORG_MST(DAL.DataContract.Inventory.OrgMst objMst);

        void CreateTI_Store_Mst(DAL.DataContract.Inventory.StoreMst objMst);

        void CreateI_ItemMaster(DAL.DataContract.Inventory.ItemMst objMst);
        DataSet Grid_ItemMasterGrid(DAL.DataContract.Inventory.ItemMst objMst);
        
    }
}
