﻿using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace Advantage.ERP.BLL
{
    public interface IServiceBusinessCalls
    {
        List<gDropdownlist> pMsGetCategory(DAL.DataContract.Service.CustomMaster objMst);
        string GenerateCustomerCode(DAL.DataContract.Service.CustomMaster objMst);
        void gMsCreateCustDetails(DAL.DataContract.Service.CustomMaster objMst);
        void gMsUpdateCust(DAL.DataContract.Service.CustomMaster objMst);
        DataSet gMsCustDetails(DAL.DataContract.Service.CustomMaster objMst);
        DataSet gMsGetCustomerList(DAL.DataContract.Service.CustomMaster objMst);
        List<gDropdownlist> gMsGetBranchData(DAL.DataContract.UserSpecificData objuMst);
        //List<gDropdownlist> PMsGetCustomerServiceCenter(string orgCode);
        List<gDropdownlist> pMsGetAppliancecategory(DAL.DataContract.Service.Appliancemst objapp);
        DataSet gMsGetApplianceList(DAL.DataContract.Service.Appliancemst objapp);
        SqlDataReader gMsGetApplianceByAppCode(DAL.DataContract.Service.Appliancemst objapp);
        void gMsCreateAppliance(DAL.DataContract.Service.Appliancemst objapp);
        void gMsUpdateAppliance(DAL.DataContract.Service.Appliancemst objapp);
        DataSet gMsGetDomainTypes(DAL.DataContract.Service.Domainmst objdomain);
        DataSet gMsGetDomainDetails(DAL.DataContract.Service.Domainmst objdomain);
        void  gMsCreateDomain(DAL.DataContract.Service.Domainmst objdomain);
                #region VisitingRequest
        List<gDropdownlist> gMsGetCategoryforVisitingReq(DAL.DataContract.Service.VisitingReq objvr);
        List<gDropdownlist> gMsGetPriorityforVisitingReq(DAL.DataContract.Service.VisitingReq objvr);
        List<gDropdownlist> gMsGetPrefixforVisitingRequest(DAL.DataContract.Service.VisitingReq objvr);
        List<gDropdownlist> gMsGetAreaForVisitingRequest(DAL.DataContract.Service.VisitingReq objvr);
        DataSet gMsGetCustomerListForVisitingReguest(DAL.DataContract.Service.VisitingReq objvr);
        SqlDataReader gMsGetCustomerDataByCustomerCode(DAL.DataContract.Service.VisitingReq objvr);
        DataSet gMsGetDepartmentForVisitingRequest(DAL.DataContract.Service.VisitingReq objvr);
        DataSet gMsGetWarrantyForVisitingRequest(DAL.DataContract.Service.WarrantyMst objwarr);
        SqlDataReader gMsGetItemDataForVisitRequestBySTCode(DAL.DataContract.Inventory.ItemMst objitem);
        DataSet gMsSerachItemDetailsForVisitingRequest(DAL.DataContract.Inventory.ItemMst objitem);
        List<gDropdownlist> gMsGetModelListByappliance(DAL.DataContract.Inventory.ItemMst objitem);
        SqlDataReader gMsGetApplianceCategoryForVisitingRequest(DAL.DataContract.Inventory.ItemMst objitem);
        DataSet gMsGetQuestionListforVisitingRequest(DAL.DataContract.Service.QuestionMst objque);
        DataSet gMsGetVisitngRequestList(DAL.DataContract.Service.VisitingReq objvr);

        #region VRTransaction

        string gMsGetVisitingRequestNo(DAL.DataContract.Service.VisitingReq objvr);
        bool gMsCreateVisitingRequestMaster(DAL.DataContract.Service.VisitingReq objvr);
        bool gMsCreateVisitingRequestDetail(DAL.DataContract.Service.VisitingReq objvr);
        bool gMsCreateVisitingRequestQuestions(DAL.DataContract.Service.VisitingReq objvr);
        SqlDataReader gMsGetVisitingHeaderDataByNo(DAL.DataContract.Service.VisitingReq objvr);
        DataSet gMsGetVisitingItemDataByNo(DAL.DataContract.Service.VisitingReq objvr);
        DataSet gMsgGetVisitinRegQuestions(DAL.DataContract.Service.VisitingReq objvr);
        bool gMsUpdateVisitingRequestMaster(DAL.DataContract.Service.VisitingReq objvr);
        bool gMsUpdateVisitingRequestDetail(DAL.DataContract.Service.VisitingReq objvr);
        bool gMsUpdateVisitingRequestQuestions(DAL.DataContract.Service.VisitingReq objvr);

        #endregion VRTransaction


        #endregion VisitingRequest

        #region UserSpecification

        bool gMsGetUserPermissioncheck(DAL.DataContract.UserSpecificData objuMst);
        bool gMsCheckPassword(DAL.DataContract.UserSpecificData objuMst);
        List<TSEC_USR_OBJ> gMsCheckSpecifiedModulepermission(DAL.DataContract.UserSpecificData objuMst);
      

        #endregion

        #region Quotation-Transaction

        DataTable gMsItemDet(Advantage.ERP.DAL.DataContract.Service.QuotationTrans qutTrans);
        DataTable gMsQuotationList(DAL.DataContract.Service.QuotationTrans qutTrans);
        DataSet gMsQuotationDetails(DAL.DataContract.Service.QuotationTrans qutTrans, DAL.DataContract.Service.CustomMaster oblCustM);
        DataTable gMsOrgItemList(DAL.DataContract.Service.QuotationTrans qutTrans);
        void gMsGetStockCode(DAL.DataContract.Service.QuotationTrans qutTrans);
        void gMsGetQuotationNo(Advantage.ERP.DAL.DataContract.Service.QuotationTrans qutTrans);
        bool gMsGetStockPrice(Advantage.ERP.DAL.DataContract.Service.QuotationTrans qutTrans);
        void gMsGetTaxPercentage(Advantage.ERP.DAL.DataContract.Service.QuotationTrans qutTrans);
        void gMsCreateRecordQuotation(Advantage.ERP.DAL.DataContract.Service.QuotationTrans qutTrans);
        void gMsCgMsCreateRecordQuotationMst(Advantage.ERP.DAL.DataContract.Service.CustomMaster objMst, Advantage.ERP.DAL.DataContract.Service.QuotationTrans qutTrans);
      
        #endregion
    }
}