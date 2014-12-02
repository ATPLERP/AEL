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
        DataSet gMsSerachItemDetailsForVisitingRequest(DAL.DataContract.Inventory.ItemMst objitem);
        SqlDataReader gMsGetModelListByappliance(DAL.DataContract.Inventory.ItemMst objitem);
        SqlDataReader gMsGetApplianceCategoryForVisitingRequest(DAL.DataContract.Inventory.ItemMst objitem);
        DataSet gMsGetQuestionListforVisitingRequest(DAL.DataContract.Service.QuestionMst objques);

        #region Vr Transaction

        string gMsGetVisitingRequestNo(DAL.DataContract.Service.VisitingReq objvr);
        bool gMsCreateVisitingRequestMaster(DAL.DataContract.Service.VisitingReq objvr);
        bool gMsCreateVisitingRequestDetail(DAL.DataContract.Service.VisitingReq objvr);
        bool gMsCreateVisitingRequestQuestions(DAL.DataContract.Service.VisitingReq objvr);
        DataSet gMsGetVisitngRequestList(DAL.DataContract.Service.VisitingReq objvr);
        SqlDataReader gMsGetVisitingHeaderDataByNo(DAL.DataContract.Service.VisitingReq objvr);
        DataSet gMsGetVisitingItemDataByNo(DAL.DataContract.Service.VisitingReq objvr);
        DataSet gMsgGetVisitinRegQuestions(DAL.DataContract.Service.VisitingReq objvr);
        bool gMsUpdateVisitingRequestMaster(DAL.DataContract.Service.VisitingReq objvr);
        bool gMsUpdateVisitingRequestDetail(DAL.DataContract.Service.VisitingReq objvr);
        bool gMsUpdateVisitingRequestQuestions(DAL.DataContract.Service.VisitingReq objvr);

        #endregion Vr Transaction

        #endregion VisitingRequest

         #region UserSpecification
         
        SqlDataReader gMsValidateUser(DAL.DataContract.UserSpecificData objuMst);
         SqlDataReader gMsCheckPassword(DAL.DataContract.UserSpecificData objuMst);
         SqlDataReader gMsCheckSpecifiedModulepermission(DAL.DataContract.UserSpecificData objuMst);

         #endregion

         #region Quotation-Transaction

        DataTable gMsItemDet(DAL.DataContract.Service.QuotationTrans qutTrans);
        DataTable gMsQuotationList(DAL.DataContract.Service.QuotationTrans qutTrans);
        DataSet gMsQuotationDetails(DAL.DataContract.Service.QuotationTrans qutTrans);
        SqlDataReader gMsOrgItemList(DAL.DataContract.Service.QuotationTrans qutTrans);
        SqlDataReader gMsGetStockCode(DAL.DataContract.Service.QuotationTrans qutTrans);
        SqlDataReader gMsGetStockPrice(DAL.DataContract.Service.QuotationTrans qutTrans);
        SqlDataReader gMsGetTaxPercentage(DAL.DataContract.Service.QuotationTrans qutTrans);
        SqlDataReader gMsGetQuotationNo(DAL.DataContract.Service.QuotationTrans qutTrans);
        void gMsCreateRecordQuotation(Advantage.ERP.DAL.DataContract.Service.QuotationTrans qutTrans);
        void gMsCgMsCreateRecordQuotationMst(Advantage.ERP.DAL.DataContract.Service.CustomMaster objMst, Advantage.ERP.DAL.DataContract.Service.QuotationTrans qutTrans);
       
        #endregion

       

    }
}