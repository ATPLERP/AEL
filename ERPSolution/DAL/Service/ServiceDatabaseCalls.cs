using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Web.Security;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using Microsoft.Practices.EnterpriseLibrary.Common;



namespace Advantage.ERP.DAL
{
   public class ServiceDatabaseCalls : IServiceDatabaseCalls
   {

       #region frmCustomerMaster definitions
       public SqlDataReader pMsGetCategory(DAL.DataContract.CustomMaster objMst)
        {
           
            // Create the Database object, using the default database service. The
            // default database service is determined through configuration.
            Database db = DatabaseFactory.CreateDatabase();
            string sqlCommand = "gMsGetDomainType";
            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
            //Retrieve daata
            db.AddInParameter(dbCommand, "@pOrgCode", DbType.String, objMst.pOrgCode);
            db.AddInParameter(dbCommand, "@pDomType", DbType.String, objMst.pDomType);
            // DataSet that will hold the returned results		
           // DataSet myDataSet = null;
           // myDataSet = db.ExecuteDataSet(dbCommand);
            // Note: connection was closed by ExecuteDataSet method call 
           // return myDataSet;
            IDataReader iDR = db.ExecuteReader(dbCommand);
            // Note: connection was closed by ExecuteDataSet method call 
            return (SqlDataReader)((RefCountingDataReader)iDR).InnerReader;

        }

        public string GenerateCustomerCode(DAL.DataContract.CustomMaster objMst)
        {
            
            // string custName = string.Empty;
            // Create the Database object, using the default database service. The
            // default database service is determined through configuration.
            Database db = DatabaseFactory.CreateDatabase();
            string sqlCommand = "GetLastCustCode";
            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
            db.AddInParameter(dbCommand, "@CustName", DbType.String, objMst.pCustName);
            using (IDataReader dataReader = db.ExecuteReader(dbCommand))
            {
                // Processing code
                StringBuilder readerData = new StringBuilder();
                while (dataReader.Read())
                {
                    // Get the value of the Name column in the DbDataReader.
                    readerData.Append(dataReader["LASTCUSTCODE"]);
                    // readerData.Append(Environment.NewLine);
                    //if (dataReader != null)
                    //  dataReader.Close();
                }
                return readerData.ToString();
            }
        }

        public void gMsCreateCustDetails(DAL.DataContract.CustomMaster objMst)
        {
            
            // Create the Database object, using the default database service. The
            // default database service is determined through configuration.
            Database db = DatabaseFactory.CreateDatabase();
            string sqlCommand = "gMsCreateCustDetails";
            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
            db.AddInParameter(dbCommand, "@pOrgCode", DbType.String, objMst.pOrgCode);
            db.AddInParameter(dbCommand, "@pCustPrefix", DbType.String, objMst.pCustPrefix);
            db.AddInParameter(dbCommand, "@pCustName", DbType.String, objMst.pCustName);
            db.AddInParameter(dbCommand, "@pCustAdd", DbType.String, objMst.pCustAdd);
            db.AddInParameter(dbCommand, "@pCustServiceAddress", DbType.String, objMst.pCustServiceAddress);
            db.AddInParameter(dbCommand, "@pCustArea", DbType.String, objMst.pCustArea);
            db.AddInParameter(dbCommand, "@pCustPhone1", DbType.String, objMst.pCustPhone1);
            db.AddInParameter(dbCommand, "@pCustPhone2", DbType.String, objMst.pCustPhone2);
            db.AddInParameter(dbCommand, "@pCustFax", DbType.String, objMst.pCustFax);
            db.AddInParameter(dbCommand, "@pCustCellNo", DbType.String, objMst.pCustCellNo);
            db.AddInParameter(dbCommand, "@pCustEmail", DbType.String, objMst.pCustEmail);
            db.AddInParameter(dbCommand, "@pCustCreditLimit", DbType.Double, objMst.pCustCreditLimit);
            db.AddInParameter(dbCommand, "@pCustVATNo", DbType.String, objMst.pCustVATNo);
            db.AddInParameter(dbCommand, "@pVATApplicable", DbType.String, objMst.pVATApplicable);
            db.AddInParameter(dbCommand, "@pCustCreditGiven", DbType.Double, objMst.pCustCreditGiven);
            db.AddInParameter(dbCommand, "@pCustCategory", DbType.String, objMst.pCustCategory);
            db.AddInParameter(dbCommand, "@pCustContactPerson_Technical", DbType.String, objMst.pCustContactPerson_Technical);
            db.AddInParameter(dbCommand, "@pCustContactPerson_PhoneNo3", DbType.String, objMst.pCustContactPerson_PhoneNo3);
            db.AddInParameter(dbCommand, "@pCustContactPerson_Invoice", DbType.String, objMst.pCustContactPerson_Invoice);
            db.AddInParameter(dbCommand, "@pCustContactPerson_PhoneNo4", DbType.String, objMst.pCustContactPerson_PhoneNo4);
            db.AddInParameter(dbCommand, "@pCustSpecicalCustomer", DbType.String, objMst.pSpeCust);
            db.AddInParameter(dbCommand, "@pCustomerNo", DbType.String, objMst.pCustCode);
            db.AddInParameter(dbCommand, "@pUserId", DbType.String, objMst.pUserId);
            db.AddInParameter(dbCommand, "@pCat_No", DbType.String, objMst.pCat_No);
            db.AddInParameter(dbCommand, "@pCat_Desc", DbType.String, objMst.pCat_Desc);
            
            db.ExecuteNonQuery(dbCommand);
        }

        public void gMsUpdateCust(DAL.DataContract.CustomMaster objMst)
        {
            // Create the Database object, using the default database service. The
            // default database service is determined through configuration.
            Database db = DatabaseFactory.CreateDatabase();
            string sqlCommand = "gMsUpdateCust";
            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
            db.AddInParameter(dbCommand, "@pOrgCode", DbType.String, objMst.pOrgCode);
            db.AddInParameter(dbCommand, "@pCustPrefix", DbType.String, objMst.pCustPrefix);
            db.AddInParameter(dbCommand, "@pCustFName", DbType.String, objMst.pCustName);
            db.AddInParameter(dbCommand, "@pCustAdd", DbType.String, objMst.pCustAdd);
            db.AddInParameter(dbCommand, "@pCustServiceAddress", DbType.String, objMst.pCustServiceAddress);
            db.AddInParameter(dbCommand, "@pCustArea ", DbType.String, objMst.pCustArea);
            db.AddInParameter(dbCommand, "@pCustPhone1", DbType.String, objMst.pCustPhone1);
            db.AddInParameter(dbCommand, "@pCustPhone2", DbType.String, objMst.pCustPhone2);
            db.AddInParameter(dbCommand, "@pCustFax", DbType.String, objMst.pCustFax);
            db.AddInParameter(dbCommand, "@pCustCellNo", DbType.String, objMst.pCustCellNo);
            db.AddInParameter(dbCommand, "@pCustEmail", DbType.String, objMst.pCustEmail);
            db.AddInParameter(dbCommand, "@pCustCreditLimit", DbType.Double, objMst.pCustCreditLimit);
            db.AddInParameter(dbCommand, "@pCustVATNo", DbType.String, objMst.pCustVATNo);
            db.AddInParameter(dbCommand, "@pVATApplicable", DbType.String, objMst.pVATApplicable);
            db.AddInParameter(dbCommand, "@pCustCreditGiven", DbType.Double, objMst.pCustCreditGiven);
            db.AddInParameter(dbCommand, "@pCustCategory", DbType.String, objMst.pCustCategory);
            db.AddInParameter(dbCommand, "@pCustContactPerson_Technical", DbType.String, objMst.pCustContactPerson_Technical);
            db.AddInParameter(dbCommand, "@pCustContactPerson_PhoneNo3", DbType.String, objMst.pCustContactPerson_PhoneNo3);
            db.AddInParameter(dbCommand, "@pCustContactPerson_Invoice", DbType.String, objMst.pCustContactPerson_Invoice);
            db.AddInParameter(dbCommand, "@pCustContactPerson_PhoneNo4", DbType.String, objMst.pCustContactPerson_PhoneNo4);
            db.AddInParameter(dbCommand, "@pCustSpecicalCustomer", DbType.String, objMst.pSpeCust);
          //  db.AddInParameter(dbCommand, "@pCustomerCode", DbType.String, objMst.pCustCode);
            db.AddInParameter(dbCommand, "@pUserId", DbType.String, objMst.pUserId);
            db.AddInParameter(dbCommand, "@pSVAT", DbType.String, objMst.pSVAT);
            db.AddInParameter(dbCommand, "@pCustomerNo", DbType.String, objMst.pCustCode);
            db.AddInParameter(dbCommand, "@pCat_No", DbType.String, objMst.pCat_No);
            db.AddInParameter(dbCommand, "@pCat_Desc", DbType.String, objMst.pCat_Desc);
                  
            db.ExecuteNonQuery(dbCommand);
        }

       public DataSet gMsCustDetails(DAL.DataContract.CustomMaster objMst)
        {
            // Create the Database object, using the default database service. The
            // default database service is determined through configuration.
            Database db = DatabaseFactory.CreateDatabase();
            string sqlCommand = "gMsCustDetails";
            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
            //Retrieve daata
            db.AddInParameter(dbCommand, "@pCustomerNo", DbType.String, objMst.pCustCode);
            db.AddInParameter(dbCommand, "@pOrgCode", DbType.String, objMst.pOrgCode);
            // DataSet that will hold the returned results		
             DataSet myDataSet = null;
             myDataSet = db.ExecuteDataSet(dbCommand);
           //  Note: connection was closed by ExecuteDataSet method call 
             return myDataSet;
           
        }

       public DataSet gMsGetCustomerList(DAL.DataContract.CustomMaster objMst)
       {
           //SqlDataAdapter da = null;
          // DataSet ds = null;

           // Create the Database object, using the default database service. The
           // default database service is determined through configuration.
           Database db = DatabaseFactory.CreateDatabase();
           string sqlCommand = "gMsGetCustomerList";
           DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
           //Retrieve daata
           db.AddInParameter(dbCommand, "@pOrgCode", DbType.String, objMst.pOrgCode);
           db.AddInParameter(dbCommand, "@pCustomerName", DbType.String, objMst.pCustName);
           db.AddInParameter(dbCommand, "@pCustomerPhone", DbType.String, objMst.pCustPhone1);
           db.AddInParameter(dbCommand, "@pCustomerArea", DbType.String, objMst.pCustArea);
           db.AddInParameter(dbCommand, "@pCustomerAdd", DbType.String, objMst.pCustAdd);
           db.AddInParameter(dbCommand, "@pCustomerNo", DbType.String, objMst.pCustCode);
           dbCommand.Connection = db.CreateConnection();
           DbDataAdapter da = (SqlDataAdapter)db.GetDataAdapter();
           da.SelectCommand = dbCommand;
           DataSet ds = new DataSet(); 
           da.Fill(ds, 0, 20, "table");
          // da.Fill(ds);
           return ds;
       }
      
#endregion

#region User  definitions
        public SqlDataReader gMsGetUserPermission(DAL.DataContract.UserSpecificData objuMst)
        {
            // IDataReader reader;
            // Create the Database object, using the default database service. The
            // default database service is determined through configuration.
            Database db = DatabaseFactory.CreateDatabase();
            string sqlCommand = "gMsGetUserPermission";
            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
            db.AddInParameter(dbCommand, "@pUserId", DbType.String, objuMst.pUserId);
            db.AddInParameter(dbCommand, "@pObjId", DbType.Int16, objuMst.pObjId);
            db.AddInParameter(dbCommand, "@pBrnCode", DbType.String, objuMst.pBrnCode);
            db.AddInParameter(dbCommand, "@pModType", DbType.String, objuMst.pModType);
            //return db.ExecuteDataSet(dbCommand);
            IDataReader iDR = db.ExecuteReader(dbCommand);
            //Convefrt IDatareader to  SqlDataReader
            //SqlDataReader dr = iDR as SqlDataReader;
           return (SqlDataReader)((RefCountingDataReader)iDR).InnerReader;
        }

#endregion

 #region LoginMeIn.aspx definitions
        public SqlDataReader gMsGetBranchData(DAL.DataContract.UserSpecificData objuMst)
        {
            // IDataReader reader;
            // Create the Database object, using the default database service. The
            // default database service is determined through configuration.
            Database db = DatabaseFactory.CreateDatabase();
            string sqlCommand = "GenGetBranchList";
            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
            db.AddInParameter(dbCommand, "@vOrgCode", DbType.String, objuMst.pOrgCode);
            IDataReader iDR = db.ExecuteReader(dbCommand);
           // Note: connection was closed by ExecuteDataSet method call 
            return (SqlDataReader)((RefCountingDataReader)iDR).InnerReader;
        }

        public SqlDataReader gMsValidateUser(DAL.DataContract.UserSpecificData objuMst)
        {
            Database db = DatabaseFactory.CreateDatabase();
            string sqlCommand = "gMsValidateUser";
            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
            db.AddInParameter(dbCommand, "@pModule", DbType.String, objuMst.pModType);
            db.AddInParameter(dbCommand, "@pUser", DbType.String, objuMst.pUserId);
            db.AddInParameter(dbCommand, "@pBranchStore", DbType.String, objuMst.pBrnCode);
            IDataReader iDR = db.ExecuteReader(dbCommand);
            return (SqlDataReader)((RefCountingDataReader)iDR).InnerReader;
        }

        public SqlDataReader gMsCheckPassword(DAL.DataContract.UserSpecificData objuMst)
        {
            Database db = DatabaseFactory.CreateDatabase();
            string sqlCommand = "gCheckThePassWord";
            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
            db.AddInParameter(dbCommand, "@pUser", DbType.String, objuMst.pUserId);
            string encryptedpassword = FormsAuthentication.HashPasswordForStoringInConfigFile(objuMst.pPwd, "MD5");
            db.AddInParameter(dbCommand, "@pPassowrd", DbType.String, encryptedpassword);
            IDataReader iDR = db.ExecuteReader(dbCommand);
            return (SqlDataReader)((RefCountingDataReader)iDR).InnerReader;
        }

        public SqlDataReader gMsCheckSpecifiedModulepermission(DAL.DataContract.UserSpecificData objuMst)
        {
            Database db = DatabaseFactory.CreateDatabase();
            string sqlCommand = "gMsCheckSpecifiedModulepermission";
            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
            db.AddInParameter(dbCommand, "@pUser", DbType.String, objuMst.pUserId);
            IDataReader iDR = db.ExecuteReader(dbCommand);
            return (SqlDataReader)((RefCountingDataReader)iDR).InnerReader;
        }

  
 #endregion

       #region ApplianceMaster

        public SqlDataReader gMsGetAppliancecategory(DAL.DataContract.Appliancemst objapp)
        {
           // Advantage.ERP.DAL.DataContract.UserSpecificData udc = new DataContract.UserSpecificData();           
            Database db = DatabaseFactory.CreateDatabase();
            string sqlcomm = "gMsGetDomainType";
            DbCommand dbCommand = db.GetStoredProcCommand(sqlcomm);
            db.AddInParameter(dbCommand, "@pOrgCode", DbType.String, objapp.pOrgCode);            
            db.AddInParameter(dbCommand, "@pDomType", DbType.String, objapp.pAppCategory);
            
            IDataReader idr = db.ExecuteReader(dbCommand);
            return (SqlDataReader)((RefCountingDataReader)idr).InnerReader;
        }

        public DataSet gMsGetApplianceList(DAL.DataContract.Appliancemst objapp)
        {
            Database db = DatabaseFactory.CreateDatabase();
            string sqlcmd = "S_GetApplianceList";
            DbCommand dbc = db.GetStoredProcCommand(sqlcmd);
            db.AddInParameter(dbc, "@OrgCode", DbType.String, objapp.pOrgCode);
            db.AddInParameter(dbc, "@AppCode", DbType.String, objapp.pApplianceCode);
            db.AddInParameter(dbc, "@AppName", DbType.String, objapp.pApplianceName);
            DataSet myDataSet = null;
            myDataSet = db.ExecuteDataSet(dbc);            
            return myDataSet;           
                     
        }

        public SqlDataReader gMsGetApplianceByAppCode(DAL.DataContract.Appliancemst objapp)
        {
            Database db = DatabaseFactory.CreateDatabase();
            string sqlcom = "S_GetApplianceDetails";
            DbCommand dbcommand = db.GetStoredProcCommand(sqlcom);
            db.AddInParameter(dbcommand, "@OrgCode", DbType.String,objapp.pOrgCode);
            db.AddInParameter(dbcommand, "@AppCode", DbType.String,objapp.pApplianceCode);
            IDataReader idr = db.ExecuteReader(dbcommand);
            return (SqlDataReader)((RefCountingDataReader)idr).InnerReader;
        }

        public bool gMsCreateAppliance(DAL.DataContract.Appliancemst objapp)
        {
            DAL.DataContract.UserSpecificData logdata = new DataContract.UserSpecificData();            
            Database db = DatabaseFactory.CreateDatabase();
            string sqlcmd = "S_InsertAppliance";
            DbCommand dbcommand = db.GetStoredProcCommand(sqlcmd);
            db.AddInParameter(dbcommand, "@orgcode", DbType.String, objapp.pOrgCode);
            db.AddInParameter(dbcommand, "@AppCode", DbType.String, objapp.pApplianceCode);
            db.AddInParameter(dbcommand, "@AppName", DbType.String, objapp.pApplianceName);
            db.AddInParameter(dbcommand, "@Storage", DbType.Double, objapp.pStorageCost);
            db.AddInParameter(dbcommand, "@Estimation", DbType.Double, objapp.pEstimateCost);
            db.AddInParameter(dbcommand, "@AppCategory", DbType.String, objapp.pAppCategory);            
            db.AddInParameter(dbcommand, "@Createdby", DbType.String, logdata.pUserId);
            int x = db.ExecuteNonQuery(dbcommand);
             if (x > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool gMsUpdateAppliance(DAL.DataContract.Appliancemst objapp)
        {
            DAL.DataContract.UserSpecificData logdata = new DataContract.UserSpecificData();   
            Database db = DatabaseFactory.CreateDatabase();
            string sqlcommand = "UpdateAppliance";
            DbCommand dbcom = db.GetStoredProcCommand(sqlcommand);
            db.AddInParameter(dbcom, "@orgcode", DbType.String, objapp.pOrgCode);
            db.AddInParameter(dbcom, "@AppCode", DbType.String, objapp.pApplianceCode);
            db.AddInParameter(dbcom, "@AppName", DbType.String, objapp.pApplianceName);
            db.AddInParameter(dbcom, "@Storage", DbType.String,Convert.ToDouble(objapp.pStorageCost));
            db.AddInParameter(dbcom, "@Estimation", DbType.String, Convert.ToDouble(objapp.pEstimateCost));
            db.AddInParameter(dbcom, "@AppCategory", DbType.String,objapp.pAppCategory);
            db.AddInParameter(dbcom, "@UpdatedBy", DbType.String, logdata.pUserId);
            int x= db.ExecuteNonQuery(dbcom);
            if (x >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

       #endregion ApplianceMaster

       #region DomainMaster

        public DataSet gMsGetDomainTypes(DAL.DataContract.Domainmst objdomain)
        {
            Database db = DatabaseFactory.CreateDatabase();
            string sqlcommand = "GetDomainTypes";
            DbCommand dbcommand = db.GetStoredProcCommand(sqlcommand);
            db.AddInParameter(dbcommand, "@domaintype", DbType.String, objdomain.pDomType);
            DataSet domdata = null;
            domdata = db.ExecuteDataSet(dbcommand);
            return domdata;
            
        }

       public DataSet gMsGetDomainDetails(DAL.DataContract.Domainmst objdomain)
        {
            Database db = DatabaseFactory.CreateDatabase();
            string sqlcommand = "GetDomainDetails";
            DbCommand dbcommand = db.GetStoredProcCommand(sqlcommand);
            db.AddInParameter(dbcommand, "@orgcode", DbType.String, objdomain.pOrgCode);
            db.AddInParameter(dbcommand, "@DomType", DbType.String, objdomain.pDomType);
            DataSet domdata =null;
            domdata = db.ExecuteDataSet(dbcommand);
            return domdata;
        }

        public bool gMsCreateDomain(DAL.DataContract.Domainmst objdom)
        {
            DAL.DataContract.UserSpecificData usrdata = new DataContract.UserSpecificData();
            int y = 0;
            Database db = DatabaseFactory.CreateDatabase();
            string sqlcom = "AddDomian";
            DbCommand dbcommand = db.GetStoredProcCommand(sqlcom);
            db.AddInParameter(dbcommand, "@OrgCode", DbType.String, objdom.pOrgCode);
            db.AddInParameter(dbcommand, "@DomType", DbType.String, objdom.pDomType);
            db.AddInParameter(dbcommand, "@DomCode", DbType.String, objdom.pDomCode);
            db.AddInParameter(dbcommand, "@DomDesc", DbType.String, objdom.pDomName);
            db.AddInParameter(dbcommand, "@DomPrefix", DbType.String, objdom.pDomPrefix);
            db.AddInParameter(dbcommand, "@DomCreatedon", DbType.DateTime, DateTime.Now);
            db.AddInParameter(dbcommand, "@DomCreatedBy", DbType.String, usrdata.pUserId);
            y = db.ExecuteNonQuery(dbcommand);
            if (y > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       #endregion DomainMaster


  #region Quotation.aspx

        public DataTable gMsItemDet(DAL.DataContract.QuotationTrans qutTrans)
        {
            // Create the Database object, using the default database service. The
            // default database service is determined through configuration.
            Database db = DatabaseFactory.CreateDatabase();
            string sqlCommand = "gMsItemDet";
            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
            //Retrieve daata
            db.AddInParameter(dbCommand, "@pOrgCode", DbType.String, qutTrans.pOrgCode);
            db.AddInParameter(dbCommand, "@pQuotationNo", DbType.String, qutTrans.pQuotationNo);
            db.AddInParameter(dbCommand, "@pBrnCd", DbType.String, qutTrans.pBrnCd);
            // DataSet that will hold the returned results		
            DataSet myDataSet = null;
            myDataSet = db.ExecuteDataSet(dbCommand);
            //  Note: connection was closed by ExecuteDataSet method call 
            return myDataSet.Tables[0];
        }

        public DataTable gMsQuotationList(DAL.DataContract.QuotationTrans qutTrans)
        {
            // Create the Database object, using the default database service. The
            // default database service is determined through configuration.
            Database db = DatabaseFactory.CreateDatabase();
            string sqlCommand = "gMsQuotationList";
            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
            //Retrieve daata
            db.AddInParameter(dbCommand, "@pQuotationNo", DbType.String, qutTrans.pQuotationNo);
            db.AddInParameter(dbCommand, "@pOrgCode", DbType.String, qutTrans.pOrgCode);
            db.AddInParameter(dbCommand, "@pBrnCode", DbType.String, qutTrans.pBrnCd);
            db.AddInParameter(dbCommand, "@pCusname", DbType.String, qutTrans.pCusname);
            db.AddInParameter(dbCommand, "@pFromDate", DbType.String , qutTrans.pFromDate);
            db.AddInParameter(dbCommand, "@pToDate", DbType.String, qutTrans.pToDate);
            dbCommand.Connection = db.CreateConnection();
            DbDataAdapter da = (SqlDataAdapter)db.GetDataAdapter();
            da.SelectCommand = dbCommand;
            DataSet ds = new DataSet();
           // da.Fill(ds, 0, 20, "table");
             da.Fill(ds);
            return ds.Tables[0];
        }

        public DataSet gMsQuotationDetails(DAL.DataContract.QuotationTrans qutTrans)
        {
            // Create the Database object, using the default database service. The
            // default database service is determined through configuration.
            Database db = DatabaseFactory.CreateDatabase();
            string sqlCommand = "gMsQuotationDetails";
            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
            db.AddInParameter(dbCommand, "@pQuotationNo", DbType.String, qutTrans.pQuotationNo);
            db.AddInParameter(dbCommand, "@pOrgCode", DbType.String, qutTrans.pOrgCode);
            // DataSet that will hold the returned results		
            DataSet myDataSet = null;
            myDataSet = db.ExecuteDataSet(dbCommand);
            //  Note: connection was closed by ExecuteDataSet method call 
            return myDataSet;

        }

        public SqlDataReader gMsOrgItemList(DAL.DataContract.QuotationTrans qutTrans)
        {
            // Create the Database object, using the default database service. The
            // default database service is determined through configuration.
            Database db = DatabaseFactory.CreateDatabase();
            string sqlCommand = "gMsOrgItemList";
            DbCommand dbCommand = db.GetStoredProcCommand(sqlCommand);
            //Retrieve daata
            db.AddInParameter(dbCommand, "@pOrgCode", DbType.String, qutTrans.pOrgCode);
            db.AddInParameter(dbCommand, "@pStockCode", DbType.String, qutTrans.pStockCode);
            db.AddInParameter(dbCommand, "@pItemName", DbType.String, qutTrans.pItemName);
            db.AddInParameter(dbCommand, "@pMajorCode", DbType.String, qutTrans.pMajorCode);
            db.AddInParameter(dbCommand, "@pAppCode", DbType.String, qutTrans.pAppCode);
            IDataReader iDR = db.ExecuteReader(dbCommand);
            // Note: connection was closed by ExecuteDataSet method call 
            return (SqlDataReader)((RefCountingDataReader)iDR).InnerReader;
        }

   #endregion

        #region VisitingRequest

        public SqlDataReader gMsGetCategoryforVisitingReq(DAL.DataContract.VisitingReq objvr)
        {
            DAL.DataContract.Domainmst objdom = new DataContract.Domainmst();
            Database db = DatabaseFactory.CreateDatabase();
            string sqlcommand = "gMsGetDomainType";
            DbCommand dbcommand = db.GetStoredProcCommand(sqlcommand);
            db.AddInParameter(dbcommand, "@pOrgCode", DbType.String, objvr.pOrgcode);
            db.AddInParameter(dbcommand, "@pDomType", DbType.String, objvr.pJobCategory);
            IDataReader idr = db.ExecuteReader(dbcommand);
            return (SqlDataReader)((RefCountingDataReader)idr).InnerReader;


        }

        public SqlDataReader gMsGetPriorityforVisitingReq(DAL.DataContract.VisitingReq objvr)
        {
            DAL.DataContract.Domainmst objdom = new DataContract.Domainmst();
            Database db = DatabaseFactory.CreateDatabase();
            string sqlcommand = "gMsGetDomainType";
            DbCommand dbcommand = db.GetStoredProcCommand(sqlcommand);
            db.AddInParameter(dbcommand, "@pOrgCode", DbType.String, objvr.pOrgcode);
            db.AddInParameter(dbcommand, "@pDomType", DbType.String, objvr.pJobPriority);
            IDataReader idr = db.ExecuteReader(dbcommand);
            return (SqlDataReader)((RefCountingDataReader)idr).InnerReader;


        }

        public SqlDataReader gMsGetPrefixforVisitingRequest(DAL.DataContract.VisitingReq objvr)
        {
            Database db = DatabaseFactory.CreateDatabase();
            string sqlcommand = "gMsGetDomainType";
            DbCommand dbcommand = db.GetStoredProcCommand(sqlcommand);
            db.AddInParameter(dbcommand, "@pOrgCode", DbType.String, objvr.pOrgcode);
            db.AddInParameter(dbcommand, "@pDomType", DbType.String, objvr.pCustprefif);
            IDataReader idr = db.ExecuteReader(dbcommand);
            return (SqlDataReader)((RefCountingDataReader)idr).InnerReader;

        }

        public SqlDataReader gMsGetAreaForVisitingRequest(DAL.DataContract.VisitingReq objvr)
        {
            Database db = DatabaseFactory.CreateDatabase();
            string sqlcommmand = "gMsGetDomainType";
            DbCommand dbcommand = db.GetStoredProcCommand(sqlcommmand);
            db.AddInParameter(dbcommand, "@pOrgCode", DbType.String, objvr.pOrgcode);
            db.AddInParameter(dbcommand, "@pDomType", DbType.String, objvr.pCustArea);
            IDataReader idr = db.ExecuteReader(dbcommand);
            return (SqlDataReader)((RefCountingDataReader)idr).InnerReader;

        }

        public DataSet gMsGetCustomerListForVisitingReguest(DAL.DataContract.VisitingReq objvr)
       {
           Database db = DatabaseFactory.CreateDatabase();
           string Sqlcommand = "GetCustomerDetails";
           DbCommand dbcommand = db.GetStoredProcCommand(Sqlcommand);
           db.AddInParameter(dbcommand, "@OrgCode", DbType.String, objvr.pOrgcode);
           db.AddInParameter(dbcommand, "@CustomerName", DbType.String, objvr.pCustomerName);
           db.AddInParameter(dbcommand, "@TelephoneNo", DbType.String, objvr.pCustPhone);
           db.AddInParameter(dbcommand, "@AreaName", DbType.String, objvr.pCustArea);
           db.AddInParameter(dbcommand, "@InvoiceAddress", DbType.String, objvr.pCustomerAddressInv);
           DataSet ds = null;
           ds = db.ExecuteDataSet(dbcommand);
           return ds;

       }

        public SqlDataReader gMsGetCustomerDataByCustomerCode(DAL.DataContract.VisitingReq objvr)
        {
            Database db = DatabaseFactory.CreateDatabase();
            string sqlcommand = "GetCustomerDataByCustno";
            DbCommand dbcommand = db.GetStoredProcCommand(sqlcommand);
            db.AddInParameter(dbcommand, "@OrgCode", DbType.String, objvr.pOrgcode);
            db.AddInParameter(dbcommand, "@Custcode", DbType.Int64, objvr.pCustCode);
            IDataReader idr= db.ExecuteReader(dbcommand);
            return (SqlDataReader)((RefCountingDataReader)idr).InnerReader;
        }

        public DataSet gMsGetDepartmentForVisitingRequest(DAL.DataContract.VisitingReq objvr)
        {
            Database db = DatabaseFactory.CreateDatabase();
            string sqlcommand = "GetDepartmentData";
            DbCommand dbcommand = db.GetStoredProcCommand(sqlcommand);
            db.AddInParameter(dbcommand, "@Deptname",DbType.String, objvr.pDepatName);
            DataSet ds = null;
            return ds = db.ExecuteDataSet(dbcommand);
        }

        public DataSet gMsGetWarrantyForVisitingRequest(DAL.DataContract.WarrantyMst objwarr)
        {
            Database db = DatabaseFactory.CreateDatabase();
            string Sqlcommand = "GetWarrantyData";
            DbCommand dbcommand = db.GetStoredProcCommand(Sqlcommand);
            db.AddInParameter(dbcommand, "@SerialNo", DbType.String, objwarr.pSerialNo);
            db.AddInParameter(dbcommand, "@WarrantyNo", DbType.String, objwarr.pWarrantyNo);
            db.AddInParameter(dbcommand, "@CustName", DbType.String, objwarr.pCustName);
            db.AddInParameter(dbcommand, "@custAddInv", DbType.String, objwarr.pCustAddInv);
            db.AddInParameter(dbcommand, "@CustPhoneno", DbType.String, objwarr.pCustPhoneNo);
            db.AddInParameter(dbcommand, "@SalesOrderNo", DbType.String, objwarr.pSalesOrderNo);
            DataSet ds = null;            
            ds = db.ExecuteDataSet(dbcommand);
            return ds;
        }

        public DataSet gMsGetItemDataForVisitingRequest(DAL.DataContract.Inventory.ItemMst objitem)
        {
            Database db = DatabaseFactory.CreateDatabase();
            string sqlcommand = "GetItemData";
            DbCommand dbcommand = db.GetStoredProcCommand(sqlcommand);
            db.AddInParameter(dbcommand, "@StockCode", DbType.String, objitem.pStockCode);
            db.AddInParameter(dbcommand, "@ItemDesc", DbType.String, objitem.pItemDescription);
            db.AddInParameter(dbcommand, "@MajorGroup", DbType.String, objitem.pMajorGroup);
            db.AddInParameter(dbcommand, "@Appliance", DbType.String, objitem.pAppliance);
            DataSet ds = null;
            ds = db.ExecuteDataSet(dbcommand);
            return ds;
            
        }

        public SqlDataReader gMsGetItemDataForVisitRequestBySTCode(DAL.DataContract.Inventory.ItemMst objitem)
        {
            Database db = DatabaseFactory.CreateDatabase();            
            string sqlcommand = "SearchItemCode";
            DbCommand dbcommand = db.GetStoredProcCommand(sqlcommand);
            db.AddInParameter(dbcommand, "@vOrgCode", DbType.String, objitem.pOrgCode);
            db.AddInParameter(dbcommand, "@vStockCode", DbType.String, objitem.pStockCode);
            IDataReader idr= db.ExecuteReader(dbcommand);
            return (SqlDataReader)((RefCountingDataReader)idr).InnerReader;
        }

        public SqlDataReader gMsGetModelByappliance(DAL.DataContract.Inventory.ItemMst objitem)
        {
            Database db = DatabaseFactory.CreateDatabase();
            string sqlcommand = "GetModelDataByAppliance";
            DbCommand dbcommand = db.GetStoredProcCommand(sqlcommand);
            db.AddInParameter(dbcommand, "@AppCode", DbType.String, objitem.pAppliance);
            IDataReader idr = db.ExecuteReader(dbcommand);
            return (SqlDataReader)((RefCountingDataReader)idr).InnerReader;

        }


        #endregion VisitingRequest


   }
}
