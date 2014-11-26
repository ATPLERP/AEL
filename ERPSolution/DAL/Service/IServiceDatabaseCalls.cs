using System.Data;
using System.Data.SqlClient;
using Advantage.ERP.DAL.DataContract;

namespace Advantage.ERP.DAL
{
    public interface IServiceDatabaseCalls
    {
        SqlDataReader pMsGetCategory(DAL.DataContract.Service.CustomMaster objMst);
        string GenerateCustomerCode(DAL.DataContract.Service.CustomMaster objMst);        
        void gMsCreateCustDetails(DAL.DataContract.Service.CustomMaster objMst);
        void gMsUpdateCust(DAL.DataContract.Service.CustomMaster objMst);
        DataSet gMsCustDetails(DAL.DataContract.Service.CustomMaster objMst);
        DataSet gMsGetCustomerList(DAL.DataContract.Service.CustomMaster objMst);
        SqlDataReader gMsGetUserPermission(DAL.DataContract.UserSpecificData objuMst);
        SqlDataReader gMsGetBranchData(UserSpecificData objuMst);
        SqlDataReader gMsValidateUser(DAL.DataContract.UserSpecificData objuMst);
        SqlDataReader gMsCheckPassword(DAL.DataContract.UserSpecificData objuMst);
        SqlDataReader gMsCheckSpecifiedModulepermission(DAL.DataContract.UserSpecificData objuMst);
        //  SqlDataReader PMsGetCustomerServiceCenter(string orgCode);
        SqlDataReader gMsGetAppliancecategory(DAL.DataContract.Service.Appliancemst objapp);
        DataSet gMsGetApplianceList(DAL.DataContract.Service.Appliancemst objapp);
        SqlDataReader gMsGetApplianceByAppCode(DAL.DataContract.Service.Appliancemst objapp);
        bool gMsCreateAppliance(DAL.DataContract.Service.Appliancemst objapp);
        bool gMsUpdateAppliance(DAL.DataContract.Service.Appliancemst objapp);
        DataSet gMsGetDomainTypes(DAL.DataContract.Service.Domainmst objdomain);
        DataSet gMsGetDomainDetails(DAL.DataContract.Service.Domainmst objdomain);
        bool gMsCreateDomain(DAL.DataContract.Service.Domainmst objdom);

        #region VisitingRequest

        SqlDataReader gMsGetCategoryforVisitingReq(DAL.DataContract.Service.VisitingReq objvr);
        SqlDataReader gMsGetPriorityforVisitingReq(DAL.DataContract.Service.VisitingReq objvr);
        SqlDataReader gMsGetPrefixforVisitingRequest(DAL.DataContract.Service.VisitingReq objvr);
        SqlDataReader gMsGetAreaForVisitingRequest(DAL.DataContract.Service.VisitingReq objvr);
        DataSet gMsGetCustomerListForVisitingReguest(DAL.DataContract.Service.VisitingReq objvr);
        SqlDataReader gMsGetCustomerDataByCustomerCode(DAL.DataContract.Service.VisitingReq objvr);
        DataSet gMsGetDepartmentForVisitingRequest(DAL.DataContract.Service.VisitingReq objvr);
        DataSet gMsGetWarrantyForVisitingRequest(DAL.DataContract.Service.WarrantyMst objwarr);
        DataSet gMsGetItemDataForVisitingRequest(DAL.DataContract.Inventory.ItemMst objitem);
        SqlDataReader gMsGetItemDataForVisitRequestBySTCode(DAL.DataContract.Inventory.ItemMst objitem);
        #endregion VisitingRequest

       

    }
}