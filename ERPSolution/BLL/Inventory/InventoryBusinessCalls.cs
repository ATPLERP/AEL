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
using Advantage.ERP.DAL.DataContract.Inventory;

namespace Advantage.ERP.BLL
{
    public class InventoryBusinessCalls
    {
        #region I_ItemMaster definitions
        public void Create_I_ItemMaster(ItemMst objMst)
        {
            InventoryDatabaseCalls obj = new InventoryDatabaseCalls();
            obj.Create_ItemMaster(objMst);
        }

        public DataSet bSel_ItemMaser(DAL.DataContract.Inventory.ItemMst objMst)
        {
            DAL.InventoryDatabaseCalls objSel = new DAL.InventoryDatabaseCalls();
            DataSet ds = objSel.dSel_ItemMaster(objMst);

            DataTableReader dtr = ds.Tables[0].CreateDataReader();
            while (dtr.Read())
            {
                objMst.pStockCode = dtr.GetValue(1).ToString();
                objMst.pItemDescription = dtr.GetValue(2).ToString();
                objMst.pAppliance = dtr.GetValue(3).ToString();
                objMst.pBrand = dtr.GetValue(4).ToString();
                objMst.pCapacity = dtr.GetValue(5).ToString();
                objMst.pMajorGroup = dtr.GetValue(6).ToString();
                objMst.pPartNo = dtr.GetValue(7).ToString();
            }
            return ds;
        }

        #endregion

        #region I_SupplierMaster definitions
        public void Create_I_SupplierMaster(DAL.DataContract.Inventory.SupplierMst objMst)
        {
            InventoryDatabaseCalls obj = new InventoryDatabaseCalls();
            obj.Create_I_SupplierMaster(objMst);
        }

        public DataSet bizListSupplier(DAL.DataContract.Inventory.SupplierMst objMst)
        {
            InventoryDatabaseCalls objList = new InventoryDatabaseCalls();
            DataSet ds = objList.dcListSupplierMaster(objMst);
            DataTableReader dtr = ds.Tables[0].CreateDataReader();
            while (dtr.Read())
            { 
                objMst.pSupplierCode = dtr.GetValue(1).ToString();
                objMst.pSupplierName = dtr.GetValue(2).ToString();
                objMst.pCountry = dtr.GetValue(3).ToString();
                objMst.pTypeOfSupplier = dtr.GetValue(4).ToString();
            }
            return ds;
        }
        #endregion

        #region TC_ORG_MST definitions
        public void Create_TC_ORG_MST(DAL.DataContract.Inventory.OrgMst objMst)
        {
            InventoryDatabaseCalls obj = new InventoryDatabaseCalls();
            obj.Create_TC_ORG_MST(objMst);
        }
        #endregion

        #region TI_Store_Mst definitions
        public void Create_TI_STORE_MST(DAL.DataContract.Inventory.StoreMst objMst)
        {
            InventoryDatabaseCalls obj = new InventoryDatabaseCalls();
            obj.CreateTI_Store_Mst(objMst);
        }
        #endregion

        #region sel_StoreList definitions
                public void Sel_StoreList(DAL.DataContract.Inventory.StoreMst objMst)
                {
                    InventoryDatabaseCalls obj = new InventoryDatabaseCalls();
                    obj.CreateTI_Store_Mst(objMst);
                }
        #endregion
    }

}
