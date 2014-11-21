using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Web.Services;
using Advantage.ERP.BLL;
using System.Web.UI.HtmlControls;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Advantage.ERP.DAL.DataContract;

[WebService(Namespace = "http://tempuri2.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class ADTWebService : WebServiceBase
{
    #region AreaMaster.aspx definitions

    //[WebMethod]
    //public List<gDropdownlist> PMsGetCustomerServiceCenter(string orgCode)
    //{
    //    IServiceBusinessCalls bsOj = new ServiceBusinessCalls();
    //    return bsOj.PMsGetCustomerServiceCenter(orgCode);
    //}

    #endregion

    #region CustomerMaster.aspx definitions
    [WebMethod()]
public string HelloWorld()
{
    return "Hello World";
}
    
[WebMethod]
public List<gDropdownlist> pMsGetCategory(Advantage.ERP.DAL.DataContract.Service.CustomMaster objMst)
{
    Advantage.ERP.BLL.ServiceBusinessCalls bsOj = new Advantage.ERP.BLL.ServiceBusinessCalls();
    
   return bsOj.pMsGetCategory(objMst);
   
}

[WebMethod]
public string GenerateCustomerCode(Advantage.ERP.DAL.DataContract.Service.CustomMaster objMst)
{
    Advantage.ERP.BLL.ServiceBusinessCalls bsOj = new Advantage.ERP.BLL.ServiceBusinessCalls();

    return bsOj.GenerateCustomerCode(objMst);
}

[WebMethod]
public void gMsCreateCustDetails(Advantage.ERP.DAL.DataContract.Service.CustomMaster objMst)
{
    Advantage.ERP.BLL.ServiceBusinessCalls bsOj = new Advantage.ERP.BLL.ServiceBusinessCalls();

    bsOj.gMsCreateCustDetails(objMst);
}
[WebMethod]
public void gMsUpdateCust(Advantage.ERP.DAL.DataContract.Service.CustomMaster objMst)
{
    Advantage.ERP.BLL.ServiceBusinessCalls bsOj = new Advantage.ERP.BLL.ServiceBusinessCalls();

    bsOj.gMsUpdateCust(objMst);
}
    

[WebMethod]
public DataSet getCustDetails(Advantage.ERP.DAL.DataContract.Service.CustomMaster objMst)
{
    Advantage.ERP.BLL.ServiceBusinessCalls bsOj = new Advantage.ERP.BLL.ServiceBusinessCalls();
   return bsOj.gMsCustDetails(objMst);
}
 [WebMethod]
public DataSet gMsGetCustomerList(Advantage.ERP.DAL.DataContract.Service.CustomMaster objMst)
{
    Advantage.ERP.BLL.ServiceBusinessCalls bsOj = new Advantage.ERP.BLL.ServiceBusinessCalls();
   return bsOj.gMsGetCustomerList(objMst);
}
     

#endregion

[WebMethod]
public bool gMsGetUserPermissioncheck(Advantage.ERP.DAL.DataContract.UserSpecificData objuMst)
{
    Advantage.ERP.BLL.ServiceBusinessCalls bsOj = new Advantage.ERP.BLL.ServiceBusinessCalls();
    return bsOj.gMsGetUserPermissioncheck(objuMst);
}
[WebMethod]
public bool gMsCheckPassword(Advantage.ERP.DAL.DataContract.UserSpecificData objuMst)
{
   Advantage.ERP.BLL.ServiceBusinessCalls bsOj = new Advantage.ERP.BLL.ServiceBusinessCalls();
   return bsOj.gMsCheckPassword(objuMst);
}

#region Login.aspx definitions

[WebMethod]
public List<gDropdownlist> gMsGetBranchData(Advantage.ERP.DAL.DataContract.UserSpecificData objMst)
{
    Advantage.ERP.BLL.ServiceBusinessCalls obj = new Advantage.ERP.BLL.ServiceBusinessCalls();
    return obj.gMsGetBranchData(objMst);
}

[WebMethod]
public List<TSEC_USR_OBJ> gMsCheckSpecifiedModulepermission(Advantage.ERP.DAL.DataContract.UserSpecificData objMst)
{
    Advantage.ERP.BLL.ServiceBusinessCalls obj = new Advantage.ERP.BLL.ServiceBusinessCalls();
    return obj.gMsCheckSpecifiedModulepermission(objMst);
}

#endregion

    #region ApplianceMaster
    [WebMethod]

public List<gDropdownlist> pMsGetAppliancecategory(Advantage.ERP.DAL.DataContract.Service.Appliancemst apm)
{
    ServiceBusinessCalls bsobj = new Advantage.ERP.BLL.ServiceBusinessCalls();
    return bsobj.pMsGetAppliancecategory(apm);
}
   
    [WebMethod]
    public DataSet GetApplianceList(Advantage.ERP.DAL.DataContract.Service.Appliancemst apm)
    {
        ServiceBusinessCalls objapp = new ServiceBusinessCalls();
        return objapp.gMsGetApplianceList(apm);
    }

    [WebMethod]
    public SqlDataReader GetApplianceDatabyAppCode(Advantage.ERP.DAL.DataContract.Service.Appliancemst objapp)
    {
        ServiceBusinessCalls objbservice = new ServiceBusinessCalls();
        return objbservice.gMsGetApplianceByAppCode(objapp);
        
    }

    [WebMethod]
    public void CreateAppliance(Advantage.ERP.DAL.DataContract.Service.Appliancemst objapp)
    {
        ServiceBusinessCalls objnewapp = new ServiceBusinessCalls();
        objnewapp.gMsCreateAppliance(objapp);
    }

    [WebMethod]

    public void UpdateAppliance(Advantage.ERP.DAL.DataContract.Service.Appliancemst objapp)
    {
        ServiceBusinessCalls objeditapp = new ServiceBusinessCalls();
        objeditapp.gMsUpdateAppliance(objapp);

    }


    #endregion
    
    #region DomainMaster
    [WebMethod]
    public DataSet gMsGetDomainTypes(Advantage.ERP.DAL.DataContract.Service.Domainmst objdomain)
    {
        ServiceBusinessCalls obj = new ServiceBusinessCalls();
        return obj.gMsGetDomainTypes(objdomain);
    }

    [WebMethod]
    public DataSet gMsGetDomainDetails(Advantage.ERP.DAL.DataContract.Service.Domainmst objdomain)
    {
        ServiceBusinessCalls obj = new ServiceBusinessCalls();
        return obj.gMsGetDomainDetails(objdomain);
    }
    [WebMethod]
    public void gMsCreateDomain(Advantage.ERP.DAL.DataContract.Service.Domainmst objdom)
    {
        ServiceBusinessCalls obj = new ServiceBusinessCalls();
        obj.gMsCreateDomain(objdom);
    }

    #endregion DomainMaster

    #region QuotationTrans.cs
    [WebMethod]
    public DataTable gMsItemDet(Advantage.ERP.DAL.DataContract.Service.QuotationTrans qutTrans)
    {
        ServiceBusinessCalls bsOj = new Advantage.ERP.BLL.ServiceBusinessCalls();
        return bsOj.gMsItemDet(qutTrans);
    }
    [WebMethod]
    public DataTable gMsQuotationList(Advantage.ERP.DAL.DataContract.Service.QuotationTrans qutTrans)
    {
        ServiceBusinessCalls bsOj = new Advantage.ERP.BLL.ServiceBusinessCalls();
        return bsOj.gMsQuotationList(qutTrans);
    }
    [WebMethod]
    public DataSet gMsQuotationDetails(Advantage.ERP.DAL.DataContract.Service.QuotationTrans qutTrans, Advantage.ERP.DAL.DataContract.Service.CustomMaster oblCustM)
    {
        ServiceBusinessCalls bsOj = new Advantage.ERP.BLL.ServiceBusinessCalls();
        return bsOj.gMsQuotationDetails(qutTrans, oblCustM);
    }
    [WebMethod]
    public DataTable gMsOrgItemList(Advantage.ERP.DAL.DataContract.Service.QuotationTrans qutTrans)
    {
        ServiceBusinessCalls bsOj = new Advantage.ERP.BLL.ServiceBusinessCalls();
        return bsOj.gMsOrgItemList(qutTrans);
    }
    [WebMethod]
    public void gMsGetStockCode(Advantage.ERP.DAL.DataContract.Service.QuotationTrans qutTrans)
    {
        ServiceBusinessCalls bsOj = new Advantage.ERP.BLL.ServiceBusinessCalls();
        bsOj.gMsGetStockCode(qutTrans);
    }
    [WebMethod]
    public bool gMsGetStockPrice(Advantage.ERP.DAL.DataContract.Service.QuotationTrans qutTrans)
    {
       ServiceBusinessCalls bsOj = new Advantage.ERP.BLL.ServiceBusinessCalls();
       return bsOj.gMsGetStockPrice(qutTrans);
    }
    [WebMethod]
    public void gMsGetTaxPercentage(Advantage.ERP.DAL.DataContract.Service.QuotationTrans qutTrans)
    {
        ServiceBusinessCalls bsOj = new Advantage.ERP.BLL.ServiceBusinessCalls();
        bsOj.gMsGetTaxPercentage(qutTrans);
    }
     [WebMethod]
     public void gMsGetQuotationNo(Advantage.ERP.DAL.DataContract.Service.QuotationTrans qutTrans)
     {
         ServiceBusinessCalls bsOj = new Advantage.ERP.BLL.ServiceBusinessCalls();
         bsOj.gMsGetQuotationNo(qutTrans);
     }
    #endregion

    #region VisitingRequest
    [WebMethod]
    public List<gDropdownlist> gMsGetCategoryforVisitingReq(Advantage.ERP.DAL.DataContract.Service.VisitingReq objvr)
    {
        ServiceBusinessCalls objs = new ServiceBusinessCalls();
        return objs.gMsGetCategoryforVisitingReq(objvr);

    }
    [WebMethod]
    public List<gDropdownlist> gMsGetPriorityforVisitingReq(Advantage.ERP.DAL.DataContract.Service.VisitingReq objvr)
    {
        ServiceBusinessCalls objs = new ServiceBusinessCalls();
        return objs.gMsGetPriorityforVisitingReq(objvr);

    }
    [WebMethod]
    public List<gDropdownlist> gMsGetPrefixforVisitingRequest(Advantage.ERP.DAL.DataContract.Service.VisitingReq objvr)
    {
        ServiceBusinessCalls objs = new ServiceBusinessCalls();
        return objs.gMsGetPrefixforVisitingRequest(objvr);
    }
    [WebMethod]
    public List<gDropdownlist> gMsGetAreaForVisitingRequest(Advantage.ERP.DAL.DataContract.Service.VisitingReq objvr)
    {
        ServiceBusinessCalls objs = new ServiceBusinessCalls();
        return objs.gMsGetAreaForVisitingRequest(objvr);
    }
  
    [WebMethod]
    public DataSet gMsGetCustomerListForVisitingReguest(Advantage.ERP.DAL.DataContract.Service.VisitingReq objvr)
    {
        ServiceBusinessCalls objs = new ServiceBusinessCalls();
        return objs.gMsGetCustomerListForVisitingReguest(objvr);
    }
    [WebMethod]
    public SqlDataReader gMsGetCustomerDataByCustomerCode(Advantage.ERP.DAL.DataContract.Service.VisitingReq objvr)
    {
        ServiceBusinessCalls objbscall = new ServiceBusinessCalls();
        return objbscall.gMsGetCustomerDataByCustomerCode(objvr);
    }
    [WebMethod]
    public DataSet gMsGetDepartmentForVisitingRequest(Advantage.ERP.DAL.DataContract.Service.VisitingReq objvr)
    {
        ServiceBusinessCalls objbscall = new ServiceBusinessCalls();
        return objbscall.gMsGetDepartmentForVisitingRequest(objvr);
    }
    [WebMethod]

    public DataSet gMsGetWarrantyForVisitingRequest(Advantage.ERP.DAL.DataContract.Service.WarrantyMst objwarr)
    {
        ServiceBusinessCalls objserbc = new ServiceBusinessCalls();
        return objserbc.gMsGetWarrantyForVisitingRequest(objwarr);
    }
    [WebMethod]
    public SqlDataReader gMsGetItemDataForVisitRequestBySTCode(Advantage.ERP.DAL.DataContract.Inventory.ItemMst objitem)
    {
        ServiceBusinessCalls objserbc = new ServiceBusinessCalls();
        return objserbc.gMsGetItemDataForVisitRequestBySTCode(objitem);
    }
    [WebMethod]
    public DataSet gMsSerachItemDetailsForVisitingRequest(Advantage.ERP.DAL.DataContract.Inventory.ItemMst objitem)
    {
        ServiceBusinessCalls objbs = new ServiceBusinessCalls();
        return objbs.gMsSerachItemDetailsForVisitingRequest(objitem);
    }
    [WebMethod]
    public List<gDropdownlist> gMsGetModelListByappliance(Advantage.ERP.DAL.DataContract.Inventory.ItemMst objitem)
    {
        ServiceBusinessCalls objbcall = new ServiceBusinessCalls();
        return objbcall.gMsGetModelListByappliance(objitem);
    }
    [WebMethod]

    public SqlDataReader gMsGetApplianceCategoryForVisitingRequest(Advantage.ERP.DAL.DataContract.Inventory.ItemMst objitem)
    {
        ServiceBusinessCalls objbscall = new ServiceBusinessCalls();
        return objbscall.gMsGetApplianceCategoryForVisitingRequest(objitem);
    }

    [WebMethod]
    public DataSet gMsGetQuestionListforVisitingRequest(Advantage.ERP.DAL.DataContract.Service.QuestionMst objque)
    {
        ServiceBusinessCalls objbscall = new ServiceBusinessCalls();
        return objbscall.gMsGetQuestionListforVisitingRequest(objque);
    }

    #endregion VisitingRequest


    #region I_ItemMaster.aspx definition
    [WebMethod]
    public DataSet wSel_ItemMaster(Advantage.ERP.DAL.DataContract.Inventory.ItemMst objMst)
    {
        Advantage.ERP.BLL.InventoryBusinessCalls bsObj = new Advantage.ERP.BLL.InventoryBusinessCalls();
        return bsObj.bSel_ItemMaser(objMst);
    }

    [WebMethod]
    public void Create_I_ItemMaster(Advantage.ERP.DAL.DataContract.Inventory.ItemMst objMst)
    {
        InventoryBusinessCalls objBiz = new InventoryBusinessCalls();
        objBiz.Create_I_ItemMaster(objMst);
    }
    #endregion

    #region SupplierMaster.aspx definition
    [WebMethod]
    public void Create_I_SupplierMaster(Advantage.ERP.DAL.DataContract.Inventory.SupplierMst objMst)
    {
        Advantage.ERP.BLL.InventoryBusinessCalls objBiz = new Advantage.ERP.BLL.InventoryBusinessCalls();
        objBiz.Create_I_SupplierMaster(objMst);
    }

    [WebMethod]
    public DataSet wsListSupplier(Advantage.ERP.DAL.DataContract.Inventory.SupplierMst objMst)
    {
        Advantage.ERP.BLL.InventoryBusinessCalls objBiz = new Advantage.ERP.BLL.InventoryBusinessCalls();
        return objBiz.bizListSupplier(objMst);
    }

    #endregion

    #region StoreMaster.aspx definition
    [WebMethod]
    public void Create_TI_STORE_MST(Advantage.ERP.DAL.DataContract.Inventory.StoreMst objMst)
    {
        Advantage.ERP.BLL.InventoryBusinessCalls objBiz = new Advantage.ERP.BLL.InventoryBusinessCalls();
        objBiz.Create_TI_STORE_MST(objMst);
    }

    #endregion

    #region Organization.aspx definition
    [WebMethod]
    public void create_TC_ORG_MST(Advantage.ERP.DAL.DataContract.Inventory.OrgMst objMst)
    {
        Advantage.ERP.BLL.InventoryBusinessCalls objBiz = new Advantage.ERP.BLL.InventoryBusinessCalls();
        objBiz.Create_TC_ORG_MST(objMst);
    }
    #endregion

}

