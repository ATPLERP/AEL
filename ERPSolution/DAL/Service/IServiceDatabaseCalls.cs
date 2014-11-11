using System.Data;
using System.Data.SqlClient;
using Advantage.ERP.DAL.DataContract;

namespace Advantage.ERP.DAL
{
    public interface IServiceDatabaseCalls
    {
        SqlDataReader pMsGetCategory(DAL.DataContract.CustomMaster objMst);
        string GenerateCustomerCode(DAL.DataContract.CustomMaster objMst);        
        void gMsCreateCustDetails(DAL.DataContract.CustomMaster objMst);
        void gMsUpdateCust(DAL.DataContract.CustomMaster objMst);
        DataSet gMsCustDetails(DAL.DataContract.CustomMaster objMst);
        DataSet gMsGetCustomerList(DAL.DataContract.CustomMaster objMst);
        SqlDataReader gMsGetUserPermission(DAL.DataContract.UserSpecificData objuMst);
        SqlDataReader gMsGetBranchData(UserSpecificData objuMst);
        SqlDataReader gMsValidateUser(DAL.DataContract.UserSpecificData objuMst);
        SqlDataReader gMsCheckPassword(DAL.DataContract.UserSpecificData objuMst);
        SqlDataReader gMsCheckSpecifiedModulepermission(DAL.DataContract.UserSpecificData objuMst);
        //  SqlDataReader PMsGetCustomerServiceCenter(string orgCode);
        SqlDataReader gMsGetAppliancecategory(DAL.DataContract.Appliancemst objapp);
        DataSet gMsGetApplianceList(DAL.DataContract.Appliancemst objapp);
        SqlDataReader gMsGetApplianceByAppCode(DAL.DataContract.Appliancemst objapp);
        bool gMsCreateAppliance(DAL.DataContract.Appliancemst objapp);
        bool gMsUpdateAppliance(DAL.DataContract.Appliancemst objapp);
        DataSet gMsGetDomainTypes(DAL.DataContract.Domainmst objdomain);
        DataSet gMsGetDomainDetails(DAL.DataContract.Domainmst objdomain);
        bool gMsCreateDomain(DAL.DataContract.Domainmst objdom);

        #region VisitingRequest

        SqlDataReader gMsGetCategoryforVisitingReq(DAL.DataContract.VisitingReq objvr);
        SqlDataReader gMsGetPriorityforVisitingReq(DAL.DataContract.VisitingReq objvr);
        SqlDataReader gMsGetPrefixforVisitingRequest(DAL.DataContract.VisitingReq objvr);
        SqlDataReader gMsGetAreaForVisitingRequest(DAL.DataContract.VisitingReq objvr);
        DataSet gMsGetCustomerListForVisitingReguest(DAL.DataContract.VisitingReq objvr);
        SqlDataReader gMsGetCustomerDataByCustomerCode(DAL.DataContract.VisitingReq objvr);
        DataSet gMsGetDepartmentForVisitingRequest(DAL.DataContract.VisitingReq objvr);
        DataSet gMsGetWarrantyForVisitingRequest(DAL.DataContract.WarrantyMst objwarr);


        #endregion VisitingRequest

       

    }
}