using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace Advantage.ERP.BLL
{
    public interface IServiceBusinessCalls
    {
        #region Customer
        List<gDropdownlist> pMsGetCategory(DAL.DataContract.CustomMaster objMst);
        string GenerateCustomerCode(DAL.DataContract.CustomMaster objMst);
        void gMsCreateCustDetails(DAL.DataContract.CustomMaster objMst);
        void gMsUpdateCust(DAL.DataContract.CustomMaster objMst);
        DataSet gMsCustDetails(DAL.DataContract.CustomMaster objMst);
        DataSet gMsGetCustomerList(DAL.DataContract.CustomMaster objMst);
        DataSet gMsGetCustomerDetailList(DAL.DataContract.CustomMaster objcus);

        #endregion Customer

        #region UserData
        bool gMsGetUserPermissioncheck(DAL.DataContract.UserSpecificData objuMst);
        bool gMsCheckPassword(DAL.DataContract.UserSpecificData objuMst);
        List<TSEC_USR_OBJ> gMsCheckSpecifiedModulepermission(DAL.DataContract.UserSpecificData objuMst);
        List<gDropdownlist> gMsGetBranchData(DAL.DataContract.UserSpecificData objuMst);
        
        #endregion UserData

        #region Appliance

        List<gDropdownlist> pMsGetAppliancecategory(DAL.DataContract.Appliancemst objapp);
        DataSet gMsGetApplianceList(DAL.DataContract.Appliancemst objapp);
        SqlDataReader gMsGetApplianceByAppCode(DAL.DataContract.Appliancemst objapp);
        void gMsCreateAppliance(DAL.DataContract.Appliancemst objapp);
        void gMsUpdateAppliance(DAL.DataContract.Appliancemst objapp);

        #endregion Appliance


        #region Domain
        DataSet gMsGetDomainTypes(DAL.DataContract.Domainmst objdomain);
        DataSet gMsGetDomainDetails(DAL.DataContract.Domainmst objdomain);
        void gMsCreateDomain(DAL.DataContract.Domainmst objdomain);
        DataSet gMsSearchDomain(DAL.DataContract.Domainmst objdom);
        bool gMsDeleteDomain(DAL.DataContract.Domainmst objdom);
        int gMsAddDomainType(DAL.DataContract.Domainmst objdom);

        #endregion Domain

        #region VisitingRequest
        List<gDropdownlist> gMsGetCategoryforVisitingReq(DAL.DataContract.VisitingReq objvr);
        List<gDropdownlist> gMsGetPriorityforVisitingReq(DAL.DataContract.VisitingReq objvr);
        List<gDropdownlist> gMsGetPrefixforVisitingRequest(DAL.DataContract.VisitingReq objvr);
        List<gDropdownlist> gMsGetAreaForVisitingRequest(DAL.DataContract.VisitingReq objvr);

        #endregion VisitingRequest
    }
}