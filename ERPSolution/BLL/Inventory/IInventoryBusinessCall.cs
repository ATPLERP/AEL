using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Advantage.ERP.BLL
{
    public interface IInventoryBusinessCall
    {
        void Create_I_SupplierMaster(DAL.DataContract.Inventory.SupplierMst objMst);
        DataSet bizListSupplierMaster(DAL.DataContract.Inventory.SupplierMst objMst);

        void Create_TC_ORG_MST(DAL.DataContract.Inventory.OrgMst objMst);
        void Create_TI_STORE_MST(DAL.DataContract.Inventory.StoreMst objMst);
        void Create_I_ItemMaster(DAL.DataContract.Inventory.ItemMst objMst);

    }
}
