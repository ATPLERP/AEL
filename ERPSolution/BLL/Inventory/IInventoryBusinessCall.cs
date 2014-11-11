using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Advantage.ERP.BLL
{
    public interface IInventoryBusinessCall
    {
        void Create_I_SupplierMaster(DAL.DataContract.Inventory.I_SupplierMaster objMst);
        SqlDataReader List_I_SupplierMaster(DAL.DataContract.Inventory.I_SupplierMaster objMst);

        void Create_TC_ORG_MST(DAL.DataContract.Inventory.TC_ORG_MST objMst);
        void Create_TI_STORE_MST(DAL.DataContract.Inventory.TI_STORE_MST objMst);
        void Create_I_ItemMaster(DAL.DataContract.Inventory.I_ItemMaster objMst);

    }
}
