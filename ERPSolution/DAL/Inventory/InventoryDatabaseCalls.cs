using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Advantage.ERP.DAL
{
    public class InventoryDatabaseCalls
    {
        #region I_SupplierMaster
        public void Create_I_SupplierMaster(DataContract.Inventory.I_SupplierMaster objMst)
        {
            Database db = DatabaseFactory.CreateDatabase();
            string sqlCommand = "SP_I_SupplierMaster";
            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

            db.AddInParameter(dbCommand, "@spType", DbType.String, "InS");
            db.AddInParameter(dbCommand, "@OrgCode", DbType.String, objMst.OrgCode);
            db.AddInParameter(dbCommand, "@SupplierCode", DbType.String, objMst.SupplierCode);
            db.AddInParameter(dbCommand, "@Prefix", DbType.String, objMst.Prefix);
            db.AddInParameter(dbCommand, "@SupplierName", DbType.String, objMst.SupplierName);
            db.AddInParameter(dbCommand, "@Address", DbType.String, objMst.Address);
            db.AddInParameter(dbCommand, "@Country", DbType.String, objMst.Country);
            db.AddInParameter(dbCommand, "@ContactPerson", DbType.String, objMst.ContactPerson);
            db.AddInParameter(dbCommand, "@MobileNo", DbType.String, objMst.MobileNo);
            db.AddInParameter(dbCommand, "@PhoneNo1", DbType.String, objMst.PhoneNo1);
            db.AddInParameter(dbCommand, "@PhoneNo2", DbType.String, objMst.PhoneNo2);
            db.AddInParameter(dbCommand, "@Fax", DbType.String, objMst.Fax);
            db.AddInParameter(dbCommand, "@Email", DbType.String, objMst.Email);
            db.AddInParameter(dbCommand, "@VATNo", DbType.String, objMst.VATNo);
            db.AddInParameter(dbCommand, "@TypeOfSupplier", DbType.String, objMst.TypeOfSupplier);
            db.AddInParameter(dbCommand, "@PurchaseType", DbType.String, objMst.PurchaseType);
            db.AddInParameter(dbCommand, "@LeadTime", DbType.String, objMst.LeadTime);
            db.AddInParameter(dbCommand, "@CreditLimit", DbType.String, objMst.CreditLimit);
            db.AddInParameter(dbCommand, "@CreditLimitTime", DbType.String, objMst.CreditLimitTime);
            db.AddInParameter(dbCommand, "@LastPurchaseDate", DbType.String, objMst.LastPurchaseDate);
            db.AddInParameter(dbCommand, "@CurrentCreditAmount", DbType.String, objMst.CurrentCreditAmount);
            db.AddInParameter(dbCommand, "@VATApplicable", DbType.String, objMst.VATApplicable);
            db.AddInParameter(dbCommand, "@Category", DbType.String, objMst.Category);
            db.AddInParameter(dbCommand, "@CreatedBy", DbType.String, objMst.CreatedBy);
            db.AddInParameter(dbCommand, "@CreateDate", DbType.String, objMst.CreateDate);

            db.ExecuteNonQuery(dbCommand);
        }

        public DataSet Grid_I_SupplierMaster(DAL.DataContract.Inventory.I_SupplierMaster objMst)
        {
            Database db = DatabaseFactory.CreateDatabase();
            string sqlCommand = "Select_ItemMasterGrid";
            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

            db.AddInParameter(dbCommand, "@SupplierCode", DbType.String, objMst.SupplierCode);
            db.AddInParameter(dbCommand, "@SupplierCode", DbType.String, objMst.SupplierName);
            db.AddInParameter(dbCommand, "@SupplierCode", DbType.String, objMst.PurchaseType);
            db.AddInParameter(dbCommand, "@SupplierCode", DbType.String, objMst.Category);

            DataSet myDataSet = null;
            myDataSet = db.ExecuteDataSet(dbCommand);

            return myDataSet;
        }

        #endregion

        #region TC_ORG_MST
        public void Create_TC_ORG_MST(DataContract.Inventory.TC_ORG_MST objMst)
        {
            Database db = DatabaseFactory.CreateDatabase();
            string sqlCommand = "SP_TC_ORG_MST";
            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

            db.AddInParameter(dbCommand, "@COM_ORG_CD", DbType.String, objMst.COM_ORG_CD);
            db.AddInParameter(dbCommand, "@COM_ORG_BRANCH_FLAG", DbType.String, objMst.COM_ORG_BRANCH_FLAG);
            db.AddInParameter(dbCommand, "@COM_ORG_MAIN_CODE", DbType.String, objMst.COM_ORG_MAIN_CODE);
            db.AddInParameter(dbCommand, "@COM_ORG_NAME", DbType.String, objMst.COM_ORG_NAME);
            db.AddInParameter(dbCommand, "@COM_VAT_NO", DbType.String, objMst.COM_VAT_NO);
            db.AddInParameter(dbCommand, "@COM_ORG_CONT_PER", DbType.String, objMst.COM_ORG_CONT_PER);
            db.AddInParameter(dbCommand, "@COM_ORG_ADD", DbType.String, objMst.COM_ORG_ADD);
            db.AddInParameter(dbCommand, "@COM_ORG_CITY", DbType.String, objMst.COM_ORG_CITY);
            db.AddInParameter(dbCommand, "@COM_ORG_PROV", DbType.String, objMst.COM_ORG_PROV);
            db.AddInParameter(dbCommand, "@COM_ORG_CTRY", DbType.String, objMst.COM_ORG_CTRY);
            db.AddInParameter(dbCommand, "@COM_ORG_PIN", DbType.String, objMst.COM_ORG_PIN);
            db.AddInParameter(dbCommand, "@COM_ORG_PH1", DbType.String, objMst.COM_ORG_PH1);
            db.AddInParameter(dbCommand, "@COM_ORG_PH2", DbType.String, objMst.COM_ORG_PH2);
            db.AddInParameter(dbCommand, "@COM_ORG_FAX1", DbType.String, objMst.COM_ORG_FAX1);
            db.AddInParameter(dbCommand, "@COM_ORG_FAX2", DbType.String, objMst.COM_ORG_FAX2);
            db.AddInParameter(dbCommand, "@COM_ORG_EMAIL", DbType.String, objMst.COM_ORG_EMAIL);
            db.AddInParameter(dbCommand, "@COM_ORG_WEB", DbType.String, objMst.COM_ORG_WEB);
            db.AddInParameter(dbCommand, "@COM_ORG_CREA_BY", DbType.String, objMst.COM_ORG_CREA_BY);
            db.AddInParameter(dbCommand, "@COM_ORG_CREA_DT", DbType.String, objMst.COM_ORG_CREA_DT);
            db.AddInParameter(dbCommand, "@COM_ORG_UPD_BY", DbType.String, objMst.COM_ORG_UPD_BY);
            db.AddInParameter(dbCommand, "@COM_ORG_UPD_DT", DbType.String, objMst.COM_ORG_UPD_DT);
            db.AddInParameter(dbCommand, "@COM_DOC_CODE", DbType.String, objMst.COM_DOC_CODE);

            db.ExecuteNonQuery(dbCommand);
        }
        #endregion

        #region TI_Store_Mst
        public void CreateTI_Store_Mst(DataContract.Inventory.TI_STORE_MST objMst)
        {
            Database db = DatabaseFactory.CreateDatabase();
            string sqlCommand = "SP_TI_STORE_MST";
            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

            db.AddInParameter(dbCommand, "@spType", DbType.String, "InShamee");
            db.AddInParameter(dbCommand, "@ISM_ORG_CODE", DbType.String, objMst.ISM_ORG_CODE);
            db.AddInParameter(dbCommand, "@ISM_STORE_ID", DbType.String, objMst.ISM_STORE_ID);
            db.AddInParameter(dbCommand, "@ISM_STORE_DESC", DbType.String, objMst.ISM_STORE_DESC);
            db.AddInParameter(dbCommand, "@ISM_STORE_ADD", DbType.String, objMst.ISM_STORE_ADD);
            db.AddInParameter(dbCommand, "@ISM_STORE_CITY", DbType.String, objMst.ISM_STORE_CITY);
            db.AddInParameter(dbCommand, "@ISM_STORE_PINCODE", DbType.String, objMst.ISM_STORE_PINCODE);
            db.AddInParameter(dbCommand, "@ISM_STORE_PROV", DbType.String, objMst.ISM_STORE_PROV);
            db.AddInParameter(dbCommand, "@ISM_PHONE1", DbType.String, objMst.ISM_PHONE1);
            db.AddInParameter(dbCommand, "@ISM_PHONE2", DbType.String, objMst.ISM_PHONE2);
            db.AddInParameter(dbCommand, "@ISM_FAX1", DbType.String, objMst.ISM_FAX1);
            db.AddInParameter(dbCommand, "@ISM_FAX2", DbType.String, objMst.ISM_FAX2);
            db.AddInParameter(dbCommand, "@ISM_CONT_PER", DbType.String, objMst.ISM_CONT_PER);
            db.AddInParameter(dbCommand, "@ISM_BRANCH_CD", DbType.String, objMst.ISM_BRANCH_CD);
            db.AddInParameter(dbCommand, "@ISM_STORE_LEVEL", DbType.String, objMst.ISM_STORE_LEVEL);
            db.AddInParameter(dbCommand, "@ISM_STORE_TYPE", DbType.String, objMst.ISM_STORE_TYPE);
            db.AddInParameter(dbCommand, "@ISM_CREA_DT", DbType.String, objMst.ISM_CREA_DT);
            db.AddInParameter(dbCommand, "@ISM_CREA_BY", DbType.String, objMst.ISM_CREA_BY);
            db.AddInParameter(dbCommand, "@ISM_UPD_DT", DbType.String, objMst.ISM_UPD_DT);
            db.AddInParameter(dbCommand, "@ISM_UPD_BY", DbType.String, objMst.ISM_UPD_BY);

            db.ExecuteNonQuery(dbCommand);
        }
        #endregion

        #region ItemMaster
        public DataSet Grid_ItemMaster(DAL.DataContract.Inventory.I_ItemMaster objMst)
        {
            Database db = DatabaseFactory.CreateDatabase();
            string sqlCommand = "Select_ItemMasterGrid";
            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

            db.AddInParameter(dbCommand, "@MajorGroup", DbType.String, objMst.MajorGroup);
            db.AddInParameter(dbCommand, "@StockCode", DbType.String, objMst.StockCode);
            db.AddInParameter(dbCommand, "@ItemDescription", DbType.String, objMst.ItemDescription);
            db.AddInParameter(dbCommand, "@ModelNo", DbType.String, objMst.ModelNo);
            db.AddInParameter(dbCommand, "@ItemDescription", DbType.String, objMst.ItemDescription);

            DataSet myDataSet = null;
            myDataSet = db.ExecuteDataSet(dbCommand);

            return myDataSet;
        }

        public void Create_ItemMaster(DataContract.Inventory.I_ItemMaster objMst)
        {
            Database db = DatabaseFactory.CreateDatabase();
            string sqlCommand = "SP_I_ItemMaster";
            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

            db.AddInParameter(dbCommand, "@spType", DbType.String, "InShamee");
            db.AddInParameter(dbCommand, "@OrgCode", DbType.String, objMst.OrgCode);
            db.AddInParameter(dbCommand, "@StockCode", DbType.String, objMst.StockCode);
            db.AddInParameter(dbCommand, "@ItemDescription", DbType.String, objMst.ItemDescription);
            db.AddInParameter(dbCommand, "@MajorGroup", DbType.String, objMst.MajorGroup);
            db.AddInParameter(dbCommand, "@Appliance", DbType.String, objMst.Appliance);
            db.AddInParameter(dbCommand, "@Brand", DbType.String, objMst.Brand);
            db.AddInParameter(dbCommand, "@ModelNo", DbType.String, objMst.ModelNo);
            db.AddInParameter(dbCommand, "@Capacity", DbType.String, objMst.Capacity);
            db.AddInParameter(dbCommand, "@PurchaseType", DbType.String, objMst.PurchaseType);
            db.AddInParameter(dbCommand, "@FSN", DbType.String, objMst.FSN);
            db.AddInParameter(dbCommand, "@VATPercentage", DbType.String, objMst.VATPercentage);
            db.AddInParameter(dbCommand, "@UoM", DbType.String, objMst.UoM);
            db.AddInParameter(dbCommand, "@LifeTime", DbType.String, objMst.LifeTime);
            db.AddInParameter(dbCommand, "@Obsolete", DbType.String, objMst.Obsolete);
            db.AddInParameter(dbCommand, "@HSCode", DbType.String, objMst.HSCode);
            db.AddInParameter(dbCommand, "@LastGRNNo", DbType.String, objMst.LastGRNNo);
            db.AddInParameter(dbCommand, "@LastInCost", DbType.String, objMst.LastInCost);
            db.AddInParameter(dbCommand, "@AverageCost", DbType.String, objMst.AverageCost);
            db.AddInParameter(dbCommand, "@StockApplicable", DbType.String, objMst.StockApplicable);
            db.AddInParameter(dbCommand, "@LedgerCode", DbType.String, objMst.LedgerCode);
            db.AddInParameter(dbCommand, "@CreatedBy", DbType.String, objMst.CreatedBy);
            db.AddInParameter(dbCommand, "@CreateDate", DbType.String, objMst.CreateDate);
            db.AddInParameter(dbCommand, "@UpDatedBy", DbType.String, objMst.UpDatedBy);
            db.AddInParameter(dbCommand, "@UpDatedDate", DbType.String, objMst.UpDatedDate);
            db.AddInParameter(dbCommand, "@InstllationAmt", DbType.String, objMst.InstllationAmt);
            db.AddInParameter(dbCommand, "@PartNo", DbType.String, objMst.PartNo);
            db.AddInParameter(dbCommand, "@ST", DbType.String, objMst.ST);
            db.AddInParameter(dbCommand, "@NormCode", DbType.String, objMst.NormCode);
            db.AddInParameter(dbCommand, "@RateCategory", DbType.String, objMst.RateCategory);
            db.AddInParameter(dbCommand, "@JobType", DbType.String, objMst.JobType);
            db.AddInParameter(dbCommand, "@Duration", DbType.String, objMst.Duration);
            db.AddInParameter(dbCommand, "@Meterial", DbType.String, objMst.Meterial);
            db.AddInParameter(dbCommand, "@Labour", DbType.String, objMst.Labour);
            db.AddInParameter(dbCommand, "@Points", DbType.String, objMst.Points);
            db.AddInParameter(dbCommand, "@CommonJob", DbType.String, objMst.CommonJob);

            db.ExecuteNonQuery(dbCommand);

        }
        #endregion


    }
}
