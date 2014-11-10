using System.Data;
using System.Data.SqlClient;
using Advantage.ERP.DAL.DataContract;

namespace Advantage.ERP.DAL
{
    public interface IServiceDatabaseCalls
    {
        #region Customer
        SqlDataReader pMsGetCategory(DAL.DataContract.CustomMaster objMst);
        string GenerateCustomerCode(DAL.DataContract.CustomMaster objMst);
        void gMsCreateCustDetails(DAL.DataContract.CustomMaster objMst);
        void gMsUpdateCust(DAL.DataContract.CustomMaster objMst);
        DataSet gMsCustDetails(DAL.DataContract.CustomMaster objMst);
        DataSet gMsGetCustomerList(DAL.DataContract.CustomMaster objMst);
        DataSet gMsGetCustomerDetailList(DAL.DataContract.CustomMaster objMst);
        #endregion Customer

        #region UserData
        SqlDataReader gMsGetUserPermission(DAL.DataContract.UserSpecificData objuMst);
        SqlDataReader gMsGetBranchData(UserSpecificData objuMst);
        SqlDataReader gMsValidateUser(DAL.DataContract.UserSpecificData objuMst);
        SqlDataReader gMsCheckPassword(DAL.DataContract.UserSpecificData objuMst);
        SqlDataReader gMsCheckSpecifiedModulepermission(DAL.DataContract.UserSpecificData objuMst);
        #endregion UserData

        #region Appliance

        SqlDataReader gMsGetAppliancecategory(DAL.DataContract.Appliancemst objapp);
        DataSet gMsGetApplianceList(DAL.DataContract.Appliancemst objapp);
        SqlDataReader gMsGetApplianceByAppCode(DAL.DataContract.Appliancemst objapp);
        bool gMsCreateAppliance(DAL.DataContract.Appliancemst objapp);
        bool gMsUpdateAppliance(DAL.DataContract.Appliancemst objapp);
        #endregion Appliance

        #region Domain
        DataSet gMsGetDomainTypes(DAL.DataContract.Domainmst objdomain);
        DataSet gMsGetDomainDetails(DAL.DataContract.Domainmst objdomain);
        bool gMsCreateDomain(DAL.DataContract.Domainmst objdom);
        DataSet gMsSearchDomain(DAL.DataContract.Domainmst objdom);
        bool gMsDeleteDomain(DAL.DataContract.Domainmst objdom);
        int gMsAddDomainType(DAL.DataContract.Domainmst objdom);

        #endregion Domain

        #region VisitingRequest

        SqlDataReader gMsGetCategoryforVisitingReq(DAL.DataContract.VisitingReq objvr);
        SqlDataReader gMsGetPriorityforVisitingReq(DAL.DataContract.VisitingReq objvr);
        SqlDataReader gMsGetPrefixforVisitingRequest(DAL.DataContract.VisitingReq objvr);
        SqlDataReader gMsGetAreaForVisitingRequest(DAL.DataContract.VisitingReq objvr);

        #endregion VisitingRequest
    }
}