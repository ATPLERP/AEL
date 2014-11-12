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
    public class ServiceBusinessCalls : IServiceBusinessCalls
    {

        #region frmAreaMaster from Kavinda

        //public List<gDropdownlist> PMsGetCustomerServiceCenter(string orgCode)
        //{
        //    IServiceDatabaseCalls obj = new ServiceDatabaseCalls();
        //    var drpdwlst = new List<gDropdownlist>();
        //    //var dr = obj.PMsGetCustomerServiceCenter(orgCode);
        //    while (dr.Read())
        //    {
        //        var drl = new gDropdownlist(dr.GetString(0), dr.GetString(1));
        //        drpdwlst.Add(drl);
        //    }
        //    return drpdwlst;

        //}

        #endregion

        #region frmCustomerMaster definitions
        public List<gDropdownlist> pMsGetCategory(DAL.DataContract.CustomMaster objMst)
        {
            Advantage.ERP.DAL.ServiceDatabaseCalls obj = new Advantage.ERP.DAL.ServiceDatabaseCalls();
            //DataContract.MST.CustomMaster objMst = new DataContract.MST.CustomMaster();
            // return obj.pMsGetCategory(objMst);
            List<gDropdownlist> drpdwlst = new List<gDropdownlist>();

            SqlDataReader dr = obj.pMsGetCategory(objMst);
            while (dr.Read())
            {
                gDropdownlist drl = new gDropdownlist(dr.GetString(0), dr.GetString(1));
                drpdwlst.Add(drl);
            }
            return drpdwlst;
        }

        public string GenerateCustomerCode(DAL.DataContract.CustomMaster objMst)
        {
            DAL.ServiceDatabaseCalls obj = new DAL.ServiceDatabaseCalls();
            return obj.GenerateCustomerCode(objMst);
        }

        public void gMsCreateCustDetails(DAL.DataContract.CustomMaster objMst)
        {
            DAL.ServiceDatabaseCalls obj = new DAL.ServiceDatabaseCalls();
            obj.gMsCreateCustDetails(objMst);
        }
        public void gMsUpdateCust(DAL.DataContract.CustomMaster objMst)
        {
            DAL.ServiceDatabaseCalls obj = new DAL.ServiceDatabaseCalls();
            obj.gMsUpdateCust(objMst);
        }

        public DataSet gMsCustDetails(DAL.DataContract.CustomMaster objMst)
        {
            DAL.ServiceDatabaseCalls obj = new DAL.ServiceDatabaseCalls();
            DataSet dt = obj.gMsCustDetails(objMst);
            // DataTable dt = new DataTable();
            // call load method of datatable to copy content of reader 
            // SqlCommand cmd = new SqlCommand();
            // dt.Load(cmd.ExecuteReader()); // Load method does not close the connnection. In this case, the using statement does.
            DataTableReader dr = dt.Tables[0].CreateDataReader();
            while (dr.Read())
            {
                objMst.pCustPrefix = dr.GetValue(1).ToString();
                objMst.pCustCode = dr.GetValue(2).ToString();
                objMst.pCustName = dr.GetValue(3).ToString();
                objMst.pCustAdd = dr.GetValue(4).ToString();
                objMst.pCustServiceAddress = dr.GetValue(5).ToString();
                objMst.pCustArea = dr.GetValue(6).ToString();
                objMst.pCustPhone1 = dr.GetValue(7).ToString();
                objMst.pCustPhone2 = dr.GetValue(8).ToString();
                objMst.pCustFax = dr.GetValue(9).ToString();
                objMst.pCustCellNo = dr.GetValue(10).ToString();
                objMst.pCustEmail = dr.GetValue(11).ToString();
                // objMst.pCustCreditLimit = Convert.ToDouble(dr.GetValue(12).ToString());
                if (!string.IsNullOrEmpty(dr.GetValue(12).ToString()))
                {
                    objMst.pCustCreditLimit = Convert.ToDouble(dr.GetValue(12).ToString());
                }
                else
                {
                    objMst.pCustCreditLimit = 0;
                }

                objMst.pCustVATNo = dr.GetValue(13).ToString();
                //  objMst.pCustCreditGiven = Convert.ToDouble(dr.GetValue(14).ToString());
                if (!string.IsNullOrEmpty(dr.GetValue(14).ToString()))
                {
                    objMst.pCustCreditGiven = Convert.ToDouble(dr.GetValue(14).ToString());
                }
                else
                {
                    objMst.pCustCreditGiven = 0;
                }
                objMst.pCustCategory = dr.GetValue(15).ToString();
                objMst.pCustContactPerson_Technical = dr.GetValue(16).ToString();
                objMst.pCustContactPerson_PhoneNo3 = dr.GetValue(17).ToString();
                objMst.pCustContactPerson_Invoice = dr.GetValue(18).ToString();
                objMst.pCustContactPerson_PhoneNo4 = dr.GetValue(19).ToString();
                objMst.pSpeCust = dr.GetValue(20).ToString();
                objMst.pVATApplicable = dr.GetValue(21).ToString();
                objMst.pSVAT = dr.GetValue(23).ToString();
                objMst.pSVAT_Cat = dr.GetValue(24).ToString();

            }
            //return obj.gMsCustDetails(objMst);
            return dt;
        }
        public DataSet gMsGetCustomerList(DAL.DataContract.CustomMaster objMst)
        {
            DAL.ServiceDatabaseCalls obj = new DAL.ServiceDatabaseCalls();
            DataSet ds = obj.gMsGetCustomerList(objMst);
            DataTableReader dr = ds.Tables[0].CreateDataReader();
            while (dr.Read())
            {
                objMst.pCustPrefix = dr.GetValue(1).ToString();
                objMst.pCustCode = dr.GetValue(2).ToString();
                objMst.pCustName = dr.GetValue(3).ToString();
                objMst.pCustAdd = dr.GetValue(4).ToString();
                objMst.pCustServiceAddress = dr.GetValue(5).ToString();
                objMst.pCustArea = dr.GetValue(6).ToString();
                objMst.pCustPhone1 = dr.GetValue(7).ToString();
                objMst.pCustPhone2 = dr.GetValue(8).ToString();
                objMst.pCustFax = dr.GetValue(9).ToString();
                objMst.pCustCellNo = dr.GetValue(10).ToString();
                objMst.pCustEmail = dr.GetValue(11).ToString();
                //objMst.pCustCreditLimit = Convert.ToDouble(dr.GetValue(12).ToString());
                if (!string.IsNullOrEmpty(dr.GetValue(12).ToString()))
                {
                    objMst.pCustCreditLimit = Convert.ToDouble(dr.GetValue(12).ToString());
                }
                else
                {
                    objMst.pCustCreditLimit = 0;
                }
                objMst.pCustVATNo = dr.GetValue(13).ToString();
                //objMst.pCustCreditGiven =Convert.ToDouble(dr.GetValue(14).ToString());
                if (!string.IsNullOrEmpty(dr.GetValue(14).ToString()))
                {
                    objMst.pCustCreditGiven = Convert.ToDouble(dr.GetValue(14).ToString());
                }
                else
                {
                    objMst.pCustCreditGiven = 0;
                }
                objMst.pCustCategory = dr.GetValue(15).ToString();
                objMst.pCustContactPerson_Technical = dr.GetValue(16).ToString();
                objMst.pCustContactPerson_PhoneNo3 = dr.GetValue(17).ToString();
                objMst.pCustContactPerson_Invoice = dr.GetValue(18).ToString();
                objMst.pCustContactPerson_PhoneNo4 = dr.GetValue(19).ToString();
                objMst.pSpeCust = dr.GetValue(20).ToString();
                objMst.pVATApplicable = dr.GetValue(21).ToString();
                objMst.pSVAT = dr.GetValue(23).ToString();
                //objMst.pSVAT_Cat = dr.GetValue(24).ToString();

            }
            return ds;
        }

        #endregion

        #region User  definitions
        public bool gMsGetUserPermissioncheck(DAL.DataContract.UserSpecificData objuMst)
        {
            bool success = false;
            DAL.ServiceDatabaseCalls obj = new DAL.ServiceDatabaseCalls();

            SqlDataReader dr = obj.gMsGetUserPermission(objuMst);
            //Read the data
            while (dr.Read())
            {
                if (dr.GetValue(0).ToString() == "Y" || dr.GetValue(1).ToString() == "Y" || dr.GetValue(2).ToString() == "Y" || dr.GetValue(3).ToString() == "Y")
                {
                    // Get the values of the Name column in the DbDataReader
                    objuMst.pNew = dr.GetValue(0).ToString();
                    objuMst.pView = dr.GetValue(1).ToString();
                    objuMst.pEdit = dr.GetValue(2).ToString();
                    objuMst.pPwd = dr.GetValue(3).ToString();
                    success = true;
                }
                else
                {
                    success = false;
                }
            }

            return success;
        }

        public bool gMsCheckPassword(DAL.DataContract.UserSpecificData objuMst)
        {
            bool success = false;
            DAL.ServiceDatabaseCalls obj = new DAL.ServiceDatabaseCalls();
            SqlDataReader dr = obj.gMsCheckPassword(objuMst);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    success = true;
                }
            }
            else
            {
                success = false;
            }
            return success;

        }

        public List<TSEC_USR_OBJ> gMsCheckSpecifiedModulepermission(DAL.DataContract.UserSpecificData objuMst)
        {
            Advantage.ERP.DAL.ServiceDatabaseCalls obj = new Advantage.ERP.DAL.ServiceDatabaseCalls();
            List<TSEC_USR_OBJ> tsUsrList = new List<TSEC_USR_OBJ>();
            SqlDataReader dr = obj.gMsCheckSpecifiedModulepermission(objuMst);
            while (dr.Read())
            {
                TSEC_USR_OBJ uselist = new TSEC_USR_OBJ(dr.GetString(0), dr.GetString(1), dr.GetInt32(2), dr.GetInt32(3));
                tsUsrList.Add(uselist);
            }
            return tsUsrList;
        }



        #endregion

        #region Login.aspx definitions
        public List<gDropdownlist> gMsGetBranchData(UserSpecificData objuMst)
        {
            ServiceDatabaseCalls obj = new ServiceDatabaseCalls();
            List<gDropdownlist> drpdwlst = new List<gDropdownlist>();

            SqlDataReader dr = obj.gMsGetBranchData(objuMst);
            while (dr.Read())
            {
                gDropdownlist drl = new gDropdownlist(dr.GetString(0), dr.GetString(1));
                drpdwlst.Add(drl);
            }
            return drpdwlst;
        }
        #endregion


        #region ApplianceMaster
        public List<gDropdownlist> pMsGetAppliancecategory(DAL.DataContract.Appliancemst objapp)
        {
            Advantage.ERP.DAL.ServiceDatabaseCalls obj = new Advantage.ERP.DAL.ServiceDatabaseCalls();
            List<gDropdownlist> droplist = new List<gDropdownlist>();
            SqlDataReader sdr = obj.gMsGetAppliancecategory(objapp);
            while (sdr.Read())
            {
                gDropdownlist drl = new gDropdownlist(sdr.GetString(0), sdr.GetString(1));
                droplist.Add(drl);
            }
            return droplist;
        }

        public DataSet gMsGetcategoryList(DAL.DataContract.Appliancemst objapp)
        {
            //Advantage.ERP.DAL.ServiceDatabaseCalls objsercall = new ServiceDatabaseCalls();
            ServiceDatabaseCalls objsercall = new ServiceDatabaseCalls();
            return null;
        }

        public DataSet gMsGetApplianceList(DAL.DataContract.Appliancemst objapp)
        {
            ServiceDatabaseCalls dbcall = new ServiceDatabaseCalls();
            DataSet ds = dbcall.gMsGetApplianceList(objapp);            
            return ds;
        }

        public SqlDataReader gMsGetApplianceByAppCode(DAL.DataContract.Appliancemst objmst)
        {
            ServiceDatabaseCalls objs = new ServiceDatabaseCalls();
            SqlDataReader sdr = objs.gMsGetApplianceByAppCode(objmst);
            return sdr;
        }

        public void  gMsCreateAppliance(DAL.DataContract.Appliancemst objapp)
        {
            ServiceDatabaseCalls obj = new ServiceDatabaseCalls();
            obj.gMsCreateAppliance(objapp);
                        
        }

        public void gMsUpdateAppliance(DAL.DataContract.Appliancemst objapp)
        {
            ServiceDatabaseCalls obj = new ServiceDatabaseCalls();
            obj.gMsUpdateAppliance(objapp);
        }


        #endregion

        #region DomainMaster

        public DataSet gMsGetDomainTypes(DAL.DataContract.Domainmst objdomain)
        {
            ServiceDatabaseCalls objd = new ServiceDatabaseCalls();
            DataSet domainds=objd.gMsGetDomainTypes(objdomain);
            return domainds;
        }

        public DataSet gMsGetDomainDetails(DAL.DataContract.Domainmst objdom)
        {
            ServiceDatabaseCalls obj = new ServiceDatabaseCalls();
            DataSet objdomain = obj.gMsGetDomainDetails(objdom);
            return objdomain;
        }

        public void gMsCreateDomain(DAL.DataContract.Domainmst objdom)
        {
            ServiceDatabaseCalls objser = new ServiceDatabaseCalls();
            objser.gMsCreateDomain(objdom);
        }

        #endregion DomainMaster


   #region QuotationTrans.cs
   
     public DataTable gMsItemDet(Advantage.ERP.DAL.DataContract.QuotationTrans qutTrans)
     {
      ServiceDatabaseCalls obj = new ServiceDatabaseCalls();
      return obj.gMsItemDet(qutTrans);
     }
     public DataTable gMsQuotationList(DAL.DataContract.QuotationTrans qutTrans)
     {
         ServiceDatabaseCalls obj = new ServiceDatabaseCalls();
         return obj.gMsQuotationList(qutTrans);
     }
     public DataSet gMsQuotationDetails(DAL.DataContract.QuotationTrans qutTrans,DAL.DataContract.CustomMaster oblCustM )
     {
        DAL.ServiceDatabaseCalls obj = new DAL.ServiceDatabaseCalls();
        //CustomMaster oblCustM = new CustomMaster(); 
        DataSet ds = obj.gMsQuotationDetails(qutTrans);
        DataTableReader dr = ds.Tables[0].CreateDataReader();
            while (dr.Read())
            {
                qutTrans.pQuoationDate = Convert.ToDateTime(dr.GetValue(1));
                qutTrans.pJobCategory = dr.GetValue(2).ToString();
                qutTrans.pCustomerOrderNo = dr.GetValue(3).ToString();
                oblCustM.pCustCode = dr.GetValue(4).ToString();
                oblCustM.pCustPrefix = dr.GetValue(5).ToString();
                oblCustM.pCustName = dr.GetValue(6).ToString();
                oblCustM.pCustAdd = dr.GetValue(7).ToString();
                oblCustM.pCustServiceAddress = dr.GetValue(8).ToString();
                oblCustM.pCustArea = dr.GetValue(9).ToString();
                oblCustM.pCustPhone1 = dr.GetValue(10).ToString();
                oblCustM.pCustFax = dr.GetValue(11).ToString();
                oblCustM.pCustCellNo = dr.GetValue(12).ToString();
                oblCustM.pCustEmail = dr.GetValue(13).ToString();
                oblCustM.pCustVATNo = dr.GetValue(14).ToString();
                oblCustM.pCustContactPerson_Invoice = dr.GetValue(15).ToString();
                oblCustM.pCustContactPerson_Technical = dr.GetValue(16).ToString();
                qutTrans.pQuotationRemarks = dr.GetValue(17).ToString();
                qutTrans.pQuotationStatus = dr.GetValue(18).ToString();
                qutTrans.pAmountPaidStatus = dr.GetValue(19).ToString();
                qutTrans.pCreatedBy = dr.GetValue(20).ToString();
            }
            return ds;
     }
   #endregion

     #region VisitingRequest

     public List<gDropdownlist> gMsGetCategoryforVisitingReq(DAL.DataContract.VisitingReq objvr)
     {

         ServiceDatabaseCalls obj = new ServiceDatabaseCalls();

         List<gDropdownlist> droplist = new List<gDropdownlist>();
         SqlDataReader sdr = obj.gMsGetCategoryforVisitingReq(objvr);
         while (sdr.Read())
         {
             gDropdownlist drl = new gDropdownlist(sdr.GetString(0), sdr.GetString(1));
             droplist.Add(drl);
         }
         return droplist;

     }



     public List<gDropdownlist> gMsGetPriorityforVisitingReq(DAL.DataContract.VisitingReq objvr)
     {

         ServiceDatabaseCalls obj = new ServiceDatabaseCalls();

         List<gDropdownlist> droplist = new List<gDropdownlist>();
         SqlDataReader sdr = obj.gMsGetPriorityforVisitingReq(objvr);
         while (sdr.Read())
         {
             gDropdownlist drl = new gDropdownlist(sdr.GetString(0), sdr.GetString(1));
             droplist.Add(drl);
         }
         return droplist;

     }
     public List<gDropdownlist> gMsGetPrefixforVisitingRequest(DAL.DataContract.VisitingReq objvr)
     {
         ServiceDatabaseCalls obj = new ServiceDatabaseCalls();
         List<gDropdownlist> droplist = new List<gDropdownlist>();
         SqlDataReader sdr = obj.gMsGetPrefixforVisitingRequest(objvr);
         while (sdr.Read())
         {
             gDropdownlist dr1 = new gDropdownlist(sdr.GetString(0), sdr.GetString(1));
             droplist.Add(dr1);
         }
         return droplist;
     }

     public List<gDropdownlist> gMsGetAreaForVisitingRequest(DAL.DataContract.VisitingReq objvr)
     {
         ServiceDatabaseCalls obj = new ServiceDatabaseCalls();
         List<gDropdownlist> droplist = new List<gDropdownlist>();
         SqlDataReader sdr = obj.gMsGetAreaForVisitingRequest(objvr);
         while (sdr.Read())
         {
             gDropdownlist dr1 = new gDropdownlist(sdr.GetString(0), sdr.GetString(1));
             droplist.Add(dr1);
         }
         return droplist;
     }

     public DataSet gMsGetCustomerListForVisitingReguest(DAL.DataContract.VisitingReq objvr)
     {
         ServiceDatabaseCalls obj = new ServiceDatabaseCalls();
         return obj.gMsGetCustomerListForVisitingReguest(objvr);
     }

     public SqlDataReader gMsGetCustomerDataByCustomerCode(DAL.DataContract.VisitingReq objvr)
     {
         ServiceDatabaseCalls objdbcall = new ServiceDatabaseCalls();
         return objdbcall.gMsGetCustomerDataByCustomerCode(objvr);

     }

     public DataSet gMsGetDepartmentForVisitingRequest(DAL.DataContract.VisitingReq objvr)
     {
         ServiceDatabaseCalls objdbcall = new ServiceDatabaseCalls();
         return objdbcall.gMsGetDepartmentForVisitingRequest(objvr);
     }

     public DataSet gMsGetWarrantyForVisitingRequest(DAL.DataContract.WarrantyMst objwarr)
     {
         ServiceDatabaseCalls objsalldb = new ServiceDatabaseCalls();
         return objsalldb.gMsGetWarrantyForVisitingRequest(objwarr);
         
     }

     public DataSet gMsGetItemDataForVisitingRequest(DAL.DataContract.Inventory.ItemMst objitem)
     {
         ServiceDatabaseCalls objbcall = new ServiceDatabaseCalls();
         return objbcall.gMsGetItemDataForVisitingRequest(objitem);
     }
     public SqlDataReader gMsGetItemDataForVisitRequestBySTCode(DAL.DataContract.Inventory.ItemMst objitem)
     {
         ServiceDatabaseCalls objdbcall = new ServiceDatabaseCalls();
         return objdbcall.gMsGetItemDataForVisitRequestBySTCode(objitem);
     }

     #endregion VisitingRequest





    }
}
