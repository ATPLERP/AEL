using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using Advantage.ERP.BLL;


namespace ERPAdvantage
{
    /// <summary>
    /// Summary description for ADTWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ADTWebService : System.Web.Services.WebService
  
  {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }


        [WebMethod]
        public List<gDropdownlist> pMsGetCategory(Advantage.ERP.DAL.DataContract.CustomMaster objMst)
        {
            Advantage.ERP.BLL.ERPBusinessCalls bsOj = new Advantage.ERP.BLL.ERPBusinessCalls();
              
            return bsOj.pMsGetCategory(objMst);
        }

        [WebMethod]
        public string GenerateCustomerCode(Advantage.ERP.DAL.DataContract.CustomMaster objMst)
        {
            Advantage.ERP.BLL.ERPBusinessCalls bsOj = new  Advantage.ERP.BLL.ERPBusinessCalls();

            return bsOj.GenerateCustomerCode(objMst);
        }

        [WebMethod]
        public void gMsCreateCustDetails(Advantage.ERP.DAL.DataContract.CustomMaster objMst)
        {
            Advantage.ERP.BLL.ERPBusinessCalls bsOj = new Advantage.ERP.BLL.ERPBusinessCalls();

            bsOj.gMsCreateCustDetails(objMst);
        }


        [WebMethod]
        public bool gMsGetUserPermissioncheck(Advantage.ERP.DAL.DataContract.UserSpecificData objuMst)
        {
            // bool success = false;
            Advantage.ERP.BLL.ERPBusinessCalls bsOj = new Advantage.ERP.BLL.ERPBusinessCalls();
            return bsOj.gMsGetUserPermissioncheck(objuMst);
        }

 #region Login.aspx definitions
       [WebMethod]
        public List<gDropdownlist> gMsGetBranchData(Advantage.ERP.DAL.DataContract.UserSpecificData objMst)
        {
            Advantage.ERP.BLL.ERPBusinessCalls obj = new Advantage.ERP.BLL.ERPBusinessCalls();
        return obj.gMsGetBranchData(objMst);
        }
#endregion
 }
}
