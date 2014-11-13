using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.HtmlControls;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Common;
using System.Configuration;
using Advantage.ERP.DAL.DataContract;
using Advantage.ERP.DAL;

namespace Advantage.ERP.BLL
{
    public class InventoryBusinessCalls
    {
        #region I_ItemMaster definitions
        public void Create_I_ItemMaster(DAL.DataContract.Inventory.ItemMst objMst)
        {
            InventoryDatabaseCalls obj = new InventoryDatabaseCalls();
            obj.Create_ItemMaster(objMst);
        }

        //public DataSet Grid_ItemMaster(DAL.DataContract.Inventory.I_ItemMaster objMst)
        //{
        //    InventoryDatabaseCalls objDbc = new DAL.InventoryDatabaseCalls();
        //    DataSet ds = objDbc.Grid_ItemMaster(objMst);
        //    DataTableReader dr = ds.Tables[0].CreateDataReader();
        //    while (dr.Read())
        //    {


        //    }
        //}
        #endregion

        #region I_SupplierMaster definitions
        public void Create_I_SupplierMaster(DAL.DataContract.Inventory.I_SupplierMaster objMst)
        {
            InventoryDatabaseCalls obj = new InventoryDatabaseCalls();
            obj.Create_I_SupplierMaster(objMst);
        }

        public void List_I_SupplierMaster(DAL.DataContract.Inventory.I_SupplierMaster objMst)
        {
            InventoryBusinessCalls obj = new InventoryBusinessCalls();
            obj.List_I_SupplierMaster(objMst);
        }
        #endregion

        #region TC_ORG_MST definitions
        public void Create_TC_ORG_MST(DAL.DataContract.Inventory.TC_ORG_MST objMst)
        {
            InventoryDatabaseCalls obj = new InventoryDatabaseCalls();
            obj.Create_TC_ORG_MST(objMst);
        }
        #endregion

        #region TI_Store_Mst definitions
        public void Create_TI_STORE_MST(DAL.DataContract.Inventory.TI_STORE_MST objMst)
        {
            InventoryDatabaseCalls obj = new InventoryDatabaseCalls();
            obj.CreateTI_Store_Mst(objMst);
        }
        #endregion

        #region sel_StoreList definitions
                public void Sel_StoreList(DAL.DataContract.Inventory.TI_STORE_MST objMst)
                {
                    InventoryDatabaseCalls obj = new InventoryDatabaseCalls();
                    obj.CreateTI_Store_Mst(objMst);
                }
        #endregion
    }

}
