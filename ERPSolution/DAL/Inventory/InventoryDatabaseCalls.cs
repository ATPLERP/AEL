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
        #region supplierMst I_SupplierMaster
        public void Create_I_SupplierMaster(DataContract.Inventory.SupplierMst objMst)
        {
            Database db = DatabaseFactory.CreateDatabase();
            string sqlCommand = "SP_I_SupplierMaster";
            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

            db.AddInParameter(dbCommand, "@spType", DbType.String, "InS");
            db.AddInParameter(dbCommand, "@OrgCode", DbType.String, objMst.pOrgCode);
            db.AddInParameter(dbCommand, "@SupplierCode", DbType.String, objMst.pSupplierCode);
            db.AddInParameter(dbCommand, "@Prefix", DbType.String, objMst.pPrefix);
            db.AddInParameter(dbCommand, "@SupplierName", DbType.String, objMst.pSupplierName);
            db.AddInParameter(dbCommand, "@Address", DbType.String, objMst.pAddress);
            db.AddInParameter(dbCommand, "@Country", DbType.String, objMst.pCountry);
            db.AddInParameter(dbCommand, "@ContactPerson", DbType.String, objMst.pContactPerson);
            db.AddInParameter(dbCommand, "@MobileNo", DbType.String, objMst.pMobileNo);
            db.AddInParameter(dbCommand, "@PhoneNo1", DbType.String, objMst.pPhoneNo1);
            db.AddInParameter(dbCommand, "@PhoneNo2", DbType.String, objMst.pPhoneNo2);
            db.AddInParameter(dbCommand, "@Fax", DbType.String, objMst.pFax);
            db.AddInParameter(dbCommand, "@Email", DbType.String, objMst.pEmail);
            db.AddInParameter(dbCommand, "@VATNo", DbType.String, objMst.pVATNo);
            db.AddInParameter(dbCommand, "@TypeOfSupplier", DbType.String, objMst.pTypeOfSupplier);
            db.AddInParameter(dbCommand, "@PurchaseType", DbType.String, objMst.pPurchaseType);
            db.AddInParameter(dbCommand, "@LeadTime", DbType.String, objMst.pLeadTime);
            db.AddInParameter(dbCommand, "@CreditLimit", DbType.String, objMst.pCreditLimit);
            db.AddInParameter(dbCommand, "@CreditLimitTime", DbType.String, objMst.pCreditLimitTime);
            db.AddInParameter(dbCommand, "@LastPurchaseDate", DbType.String, objMst.pLastPurchaseDate);
            db.AddInParameter(dbCommand, "@CurrentCreditAmount", DbType.String, objMst.pCurrentCreditAmount);
            db.AddInParameter(dbCommand, "@VATApplicable", DbType.String, objMst.pVATApplicable);
            db.AddInParameter(dbCommand, "@Category", DbType.String, objMst.pCategory);
            db.AddInParameter(dbCommand, "@CreatedBy", DbType.String, objMst.pCreatedBy);
            db.AddInParameter(dbCommand, "@CreateDate", DbType.String, objMst.pCreateDate);

            db.ExecuteNonQuery(dbCommand);
        }

        public DataSet dcListSupplierMaster(DAL.DataContract.Inventory.SupplierMst objMst)
        {
            Database db = DatabaseFactory.CreateDatabase();
            string sqlCommand = "[SP_I_SupplierMaster_Grid]";
            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

            db.AddInParameter(dbCommand, "@supplierCode", DbType.String, objMst.pSupplierCode);
            db.AddInParameter(dbCommand, "@supplierName", DbType.String, objMst.pSupplierName);
            db.AddInParameter(dbCommand, "@Country", DbType.String, objMst.pCountry);

            DataSet myDataSet = null;
            myDataSet = db.ExecuteDataSet(dbCommand);

            return myDataSet;
        }

        #endregion

        #region OrgMst TC_ORG_MST

        public DataSet Grid_OrgMst(DAL.DataContract.Inventory.ItemMst objMst)
        {
            Database db = DatabaseFactory.CreateDatabase();
            string sqlCommand = "SP_I_ItemMaster_Grid";
            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

                db.AddInParameter(dbCommand,"@StockCode",DbType.String, objMst.pStockCode);
                db.AddInParameter(dbCommand,"@ItemDescription",DbType.String, objMst.pItemDescription);
                db.AddInParameter(dbCommand,"@MajorGroup",DbType.String, objMst.pMajorGroup);
                db.AddInParameter(dbCommand,"@ModelNo",DbType.String, objMst.pModelNo);
                db.AddInParameter(dbCommand,"@PartNo", DbType.String, objMst.pPartNo);

                DataSet Ds = null;
                Ds = db.ExecuteDataSet(dbCommand);
                return Ds;

        }

        public void Create_TC_ORG_MST(DataContract.Inventory.OrgMst objMst)
        {
            Database db = DatabaseFactory.CreateDatabase();
            string sqlCommand = "SP_TC_ORG_MST";
            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

            db.AddInParameter(dbCommand, "@COM_ORG_CD", DbType.String, objMst.pCOM_ORG_CD);
            db.AddInParameter(dbCommand, "@COM_ORG_BRANCH_FLAG", DbType.String, objMst.pCOM_ORG_BRANCH_FLAG);
            db.AddInParameter(dbCommand, "@COM_ORG_MAIN_CODE", DbType.String, objMst.pCOM_ORG_MAIN_CODE);
            db.AddInParameter(dbCommand, "@COM_ORG_NAME", DbType.String, objMst.pCOM_ORG_NAME);
            db.AddInParameter(dbCommand, "@COM_VAT_NO", DbType.String, objMst.pCOM_VAT_NO);
            db.AddInParameter(dbCommand, "@COM_ORG_CONT_PER", DbType.String, objMst.pCOM_ORG_CONT_PER);
            db.AddInParameter(dbCommand, "@COM_ORG_ADD", DbType.String, objMst.pCOM_ORG_ADD);
            db.AddInParameter(dbCommand, "@COM_ORG_CITY", DbType.String, objMst.pCOM_ORG_CITY);
            db.AddInParameter(dbCommand, "@COM_ORG_PROV", DbType.String, objMst.pCOM_ORG_PROV);
            db.AddInParameter(dbCommand, "@COM_ORG_CTRY", DbType.String, objMst.pCOM_ORG_CTRY);
            db.AddInParameter(dbCommand, "@COM_ORG_PIN", DbType.String, objMst.pCOM_ORG_PIN);
            db.AddInParameter(dbCommand, "@COM_ORG_PH1", DbType.String, objMst.pCOM_ORG_PH1);
            db.AddInParameter(dbCommand, "@COM_ORG_PH2", DbType.String, objMst.pCOM_ORG_PH2);
            db.AddInParameter(dbCommand, "@COM_ORG_FAX1", DbType.String, objMst.pCOM_ORG_FAX1);
            db.AddInParameter(dbCommand, "@COM_ORG_FAX2", DbType.String, objMst.pCOM_ORG_FAX2);
            db.AddInParameter(dbCommand, "@COM_ORG_EMAIL", DbType.String, objMst.pCOM_ORG_EMAIL);
            db.AddInParameter(dbCommand, "@COM_ORG_WEB", DbType.String, objMst.pCOM_ORG_WEB);
            db.AddInParameter(dbCommand, "@COM_ORG_CREA_BY", DbType.String, objMst.pCOM_ORG_CREA_BY);
            db.AddInParameter(dbCommand, "@COM_ORG_CREA_DT", DbType.String, objMst.pCOM_ORG_CREA_DT);
            db.AddInParameter(dbCommand, "@COM_ORG_UPD_BY", DbType.String, objMst.pCOM_ORG_UPD_BY);
            db.AddInParameter(dbCommand, "@COM_ORG_UPD_DT", DbType.String, objMst.pCOM_ORG_UPD_DT);
            db.AddInParameter(dbCommand, "@COM_DOC_CODE", DbType.String, objMst.pCOM_DOC_CODE);

            db.ExecuteNonQuery(dbCommand);
        }
        #endregion

        #region StoreMst TI_Store_Mst
        public void CreateTI_Store_Mst(DataContract.Inventory.StoreMst objMst)
        {
            Database db = DatabaseFactory.CreateDatabase();
            string sqlCommand = "SP_TI_STORE_MST";
            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

            db.AddInParameter(dbCommand, "@spType", DbType.String, "InShamee");
            db.AddInParameter(dbCommand, "@ISM_ORG_CODE", DbType.String, objMst.pISM_ORG_CODE);
            db.AddInParameter(dbCommand, "@ISM_STORE_ID", DbType.String, objMst.pISM_STORE_ID);
            db.AddInParameter(dbCommand, "@ISM_STORE_DESC", DbType.String, objMst.pISM_STORE_DESC);
            db.AddInParameter(dbCommand, "@ISM_STORE_ADD", DbType.String, objMst.pISM_STORE_ADD);
            db.AddInParameter(dbCommand, "@ISM_STORE_CITY", DbType.String, objMst.pISM_STORE_CITY);
            db.AddInParameter(dbCommand, "@ISM_STORE_PINCODE", DbType.String, objMst.pISM_STORE_PINCODE);
            db.AddInParameter(dbCommand, "@ISM_STORE_PROV", DbType.String, objMst.pISM_STORE_PROV);
            db.AddInParameter(dbCommand, "@ISM_PHONE1", DbType.String, objMst.pISM_PHONE1);
            db.AddInParameter(dbCommand, "@ISM_PHONE2", DbType.String, objMst.pISM_PHONE2);
            db.AddInParameter(dbCommand, "@ISM_FAX1", DbType.String, objMst.pISM_FAX1);
            db.AddInParameter(dbCommand, "@ISM_FAX2", DbType.String, objMst.pISM_FAX2);
            db.AddInParameter(dbCommand, "@ISM_CONT_PER", DbType.String, objMst.pISM_CONT_PER);
            db.AddInParameter(dbCommand, "@ISM_BRANCH_CD", DbType.String, objMst.pISM_BRANCH_CD);
            db.AddInParameter(dbCommand, "@ISM_STORE_LEVEL", DbType.String, objMst.pISM_STORE_LEVEL);
            db.AddInParameter(dbCommand, "@ISM_STORE_TYPE", DbType.String, objMst.pISM_STORE_TYPE);
            db.AddInParameter(dbCommand, "@ISM_CREA_DT", DbType.String, objMst.pISM_CREA_DT);
            db.AddInParameter(dbCommand, "@ISM_CREA_BY", DbType.String, objMst.pISM_CREA_BY);
            db.AddInParameter(dbCommand, "@ISM_UPD_DT", DbType.String, objMst.pISM_UPD_DT);
            db.AddInParameter(dbCommand, "@ISM_UPD_BY", DbType.String, objMst.pISM_UPD_BY);

            db.ExecuteNonQuery(dbCommand);
        }
        #endregion

        #region ItemMaster I_itemMaster
        public DataSet dSel_ItemMaster(DAL.DataContract.Inventory.ItemMst objMst)
        {
            Database db = DatabaseFactory.CreateDatabase();
            string sqlCommand = "[SP_I_ItemMaster_Grid]";
            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

            db.AddInParameter(dbCommand, "@StockCode", DbType.String, objMst.pStockCode);
            db.AddInParameter(dbCommand, "@ItemDescription", DbType.String, objMst.pItemDescription);
            db.AddInParameter(dbCommand, "@MajorGroup", DbType.String, objMst.pMajorGroup);
            db.AddInParameter(dbCommand, "@ModelNo", DbType.String, objMst.pModelNo);
            db.AddInParameter(dbCommand, "@PartNo", DbType.String, objMst.pPartNo);

            DataSet ds = null;
            ds = db.ExecuteDataSet(dbCommand);
            return ds;
        }

        public void Create_ItemMaster(DataContract.Inventory.ItemMst objMst)
        {
            Database db = DatabaseFactory.CreateDatabase();
            string sqlCommand = "SP_I_ItemMaster";
            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);

            db.AddInParameter(dbCommand, "@spType", DbType.String, "InShamee");
            db.AddInParameter(dbCommand, "@OrgCode", DbType.String, objMst.pOrgCode);
            db.AddInParameter(dbCommand, "@StockCode", DbType.String, objMst.pStockCode);
            db.AddInParameter(dbCommand, "@ItemDescription", DbType.String, objMst.pItemDescription);
            db.AddInParameter(dbCommand, "@MajorGroup", DbType.String, objMst.pMajorGroup);
            db.AddInParameter(dbCommand, "@Appliance", DbType.String, objMst.pAppliance);
            db.AddInParameter(dbCommand, "@Brand", DbType.String, objMst.pBrand);
            db.AddInParameter(dbCommand, "@ModelNo", DbType.String, objMst.pModelNo);
            db.AddInParameter(dbCommand, "@Capacity", DbType.String, objMst.pCapacity);
            db.AddInParameter(dbCommand, "@PurchaseType", DbType.String, objMst.pPurchaseType);
            db.AddInParameter(dbCommand, "@FSN", DbType.String, objMst.pFSN);
            db.AddInParameter(dbCommand, "@VATPercentage", DbType.String, objMst.pVATPercentage);
            db.AddInParameter(dbCommand, "@UoM", DbType.String, objMst.pUoM);
            db.AddInParameter(dbCommand, "@LifeTime", DbType.String, objMst.pLifeTime);
            db.AddInParameter(dbCommand, "@Obsolete", DbType.String, objMst.pObsolete);
            db.AddInParameter(dbCommand, "@HSCode", DbType.String, objMst.pHSCode);
            db.AddInParameter(dbCommand, "@LastGRNNo", DbType.String, objMst.pLastGRNNo);
            db.AddInParameter(dbCommand, "@LastInCost", DbType.String, objMst.pLastInCost);
            db.AddInParameter(dbCommand, "@AverageCost", DbType.String, objMst.pAverageCost);
            db.AddInParameter(dbCommand, "@StockApplicable", DbType.String, objMst.pStockApplicable);
            db.AddInParameter(dbCommand, "@LedgerCode", DbType.String, objMst.pLedgerCode);
            db.AddInParameter(dbCommand, "@CreatedBy", DbType.String, objMst.pCreatedBy);
            db.AddInParameter(dbCommand, "@CreateDate", DbType.String, objMst.pCreateDate);
            db.AddInParameter(dbCommand, "@UpDatedBy", DbType.String, objMst.pUpDatedBy);
            db.AddInParameter(dbCommand, "@UpDatedDate", DbType.String, objMst.pUpDatedDate);
            db.AddInParameter(dbCommand, "@InstllationAmt", DbType.String, objMst.pInstllationAmt);
            db.AddInParameter(dbCommand, "@PartNo", DbType.String, objMst.pPartNo);
            db.AddInParameter(dbCommand, "@ST", DbType.String, objMst.pST);
            db.AddInParameter(dbCommand, "@NormCode", DbType.String, objMst.pNormCode);
            db.AddInParameter(dbCommand, "@RateCategory", DbType.String, objMst.pRateCategory);
            db.AddInParameter(dbCommand, "@JobType", DbType.String, objMst.pJobType);
            db.AddInParameter(dbCommand, "@Duration", DbType.String, objMst.pDuration);
            db.AddInParameter(dbCommand, "@Meterial", DbType.String, objMst.pMeterial);
            db.AddInParameter(dbCommand, "@Labour", DbType.String, objMst.pLabour);
            db.AddInParameter(dbCommand, "@Points", DbType.String, objMst.pPoints);
            db.AddInParameter(dbCommand, "@CommonJob", DbType.String, objMst.pCommonJob);

            db.ExecuteNonQuery(dbCommand);

        }
        #endregion

    }
}
