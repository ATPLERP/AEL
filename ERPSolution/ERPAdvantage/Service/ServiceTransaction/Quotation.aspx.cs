using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Web.UI.HtmlControls;
using Advantage.ERP.DAL.DataContract;
using ERPAdvantage;
using System.Drawing;
using Advantage.ERP.BLL;
using Advantage.ERP.DAL.DataContract.Service;
using Advantage.ERP.DAL.DataContract.Inventory;

namespace ERPAdvantage.Service.ServiceTransaction
{
    public partial class Quotation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                getPrefix();
                getArea();
                pMsGetQuotationCategory();
            }
        }

        protected void btnQuotNoSearch_ModalPopupExtender_PreRender(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Get the Salutation 
        /// </summary>
        private void getPrefix()
        {
            UIControl uicon = new UIControl();
            ADTWebService wsoj = new ADTWebService();
            CustomMaster objMst = new CustomMaster();
            objMst.pOrgCode = ERPSystemData.COM_DOM_ORG_CODE.AEL.ToString();
            objMst.pDomType = ERPSystemData.COM_DOM_TYPE.PREFIX.ToString();
            List<gDropdownlist> drplist = wsoj.pMsGetCategory(objMst);
            uicon.FillDropdownList(ddlPrefix, drplist, "COM_DOM_CODE", "COM_DOM_DESC");

        }

        private void getArea()
        {
            UIControl uicon = new UIControl();
            ADTWebService wsoj = new ADTWebService();
            CustomMaster objMst = new CustomMaster();
            objMst.pOrgCode = ERPSystemData.COM_DOM_ORG_CODE.AEL.ToString();
            objMst.pDomType = ERPSystemData.COM_DOM_TYPE.AREA.ToString();
            List<gDropdownlist> drplist = wsoj.pMsGetCategory(objMst);
            uicon.FillDropdownList(ddlAreaName, drplist, "COM_DOM_CODE", "COM_DOM_DESC");
         }

        private void pMsGetQuotationCategory()
        {
            UIControl uicon = new UIControl();
            ADTWebService wsoj = new ADTWebService();
            CustomMaster objMst = new CustomMaster();
            objMst.pOrgCode = ERPSystemData.COM_DOM_ORG_CODE.AEL.ToString();
            objMst.pDomType = ERPSystemData.COM_DOM_TYPE.QUOTATION_CATEGORY.ToString();
            List<gDropdownlist> drplist = wsoj.pMsGetCategory(objMst);
            uicon.FillDropdownList(ddlJobcategory, drplist, "COM_DOM_CODE", "COM_DOM_DESC");
         }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
         ADTWebService wsoj = new ADTWebService();
         QuotationTrans qutTrans = new QuotationTrans();
         qutTrans.pOrgCode = ERPSystemData.COM_DOM_ORG_CODE.AEL.ToString();
         //  Page.Validate();
         UIvalidations uiv = new UIvalidations();
         UserSpecificData objumst = new UserSpecificData();
         objumst.pObjId = 28;
         objumst.pModType = ServiceMain.ModuleId;
        
        if (uiv.CheckModuleAccess(objumst))
         {
             qutTrans.pBrnCd = objumst.pBrnCode;
             qutTrans.pFromDate = txtFromDate.Text; 
             qutTrans.pToDate = txtToDate.Text;
             
             DataTable dt = wsoj.gMsQuotationList(qutTrans);
             gvQuotationDetails.DataSource = null;
             gvQuotationDetails.DataSource = dt;
             gvQuotationDetails.DataBind();
             btnQuotNoSearch_ModalPopupExtender.Show();

         }
            
         else
         {
             lblStates.Text = Resources.UIMessege.msgAdeni;
             lblStates.ForeColor = Color.Red;
         }
        }
        protected void gvQuotationDetails_PageIndexChanged(object sender, EventArgs e)
        {
            //deselect the prior selected index after paging
            gvQuotationDetails.SelectedIndex = -1;
            btnQuotNoSearch_ModalPopupExtender.Show();

        }

        protected void gvQuotationDetails_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            ADTWebService wsoj = new ADTWebService();
            QuotationTrans qutTrans = new QuotationTrans();
            qutTrans.pOrgCode = ERPSystemData.COM_DOM_ORG_CODE.AEL.ToString();
            //  Page.Validate();
            UIvalidations uiv = new UIvalidations();
            UserSpecificData objumst = new UserSpecificData();
            objumst.pObjId = 28;
            objumst.pModType = ServiceMain.ModuleId;

            if (uiv.CheckModuleAccess(objumst))
            {
                qutTrans.pBrnCd = objumst.pBrnCode;
                qutTrans.pFromDate = txtFromDate.Text;
                qutTrans.pToDate = txtToDate.Text;

                DataTable dt = wsoj.gMsQuotationList(qutTrans);
                gvQuotationDetails.PageIndex = e.NewPageIndex;//
                gvQuotationDetails.DataSource = null;
                gvQuotationDetails.DataSource = dt;
                gvQuotationDetails.DataBind();
                btnQuotNoSearch_ModalPopupExtender.Show();
            }
            else
            {
                lblStates.Text = Resources.UIMessege.msgAdeni;
                lblStates.ForeColor = Color.Red;
            }
        }

       
        //protected void gvQuotationDetails_RowCommand(object sender, GridViewCommandEventArgs e)
        //{
        //    QuotationTrans qutTrans = new QuotationTrans();

        //    // Convert the row index stored in the CommandArgument
        //    // property to an Integer.
        //       int index = Convert.ToInt32(e.CommandArgument);

        //    // Get the last name of the selected author from the appropriate
        //    // cell in the GridView control.
        //    GridViewRow selectedRow = gvQuotationDetails.Rows[index];
        //    TableCell lastNameCell = selectedRow.Cells[1];
        //    qutTrans.pQuotationNo = lastNameCell.Text;
        //    txtQuotationNumber.Text = qutTrans.pQuotationNo;
          
        //}

        protected void gvQuotationDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            QuotationTrans qutTrans = new QuotationTrans();
            qutTrans.pQuotationNo = gvQuotationDetails.SelectedRow.Cells[1].Text;
            txtQuotNo.Text = qutTrans.pQuotationNo;
            if (txtQuotNo.Text!=string.Empty)
            {
             pMsPopQuotationDet();
             pMsPopItemDet();
            }
          
        }
        private void pMsPopQuotationDet()
        {
            QuotationTrans qutTrans = new QuotationTrans();
            CustomMaster oblCustM = new CustomMaster();
            ADTWebService wsoj = new ADTWebService();
            qutTrans.pOrgCode = ERPSystemData.COM_DOM_ORG_CODE.AEL.ToString();
            qutTrans.pQuotationNo = txtQuotNo.Text;
            DataSet ds = wsoj.gMsQuotationDetails(qutTrans, oblCustM);
            if (!string.IsNullOrEmpty(qutTrans.pJobCategory))
            {
             ddlJobcategory.SelectedValue = qutTrans.pJobCategory;
            }
            else
            {
              ddlJobcategory.SelectedIndex = -1;
            }
            txtCustOrNo.Text = qutTrans.pCustomerOrderNo;
            txtQuotRemarks.Text = qutTrans.pQuotationRemarks;
            txtCustNo.Text = oblCustM.pCustCode;
            if (!string.IsNullOrEmpty(oblCustM.pCustPrefix))
            {
             ddlPrefix.SelectedValue = oblCustM.pCustPrefix.TrimEnd().TrimStart() ;
            }
            else
            {
             ddlPrefix.SelectedIndex = -1;
            }
            txtCustNmae.Text = oblCustM.pCustName;
            txtInvAddres.Text = oblCustM.pCustAdd;
            txtSerAddress.Text = oblCustM.pCustServiceAddress;
            if (!string.IsNullOrEmpty(oblCustM.pCustArea))
            {
            ddlAreaName.SelectedValue = oblCustM.pCustArea;
            }
            else
            {
             ddlAreaName.SelectedIndex = -1;
            }
            txtVatNo.Text = oblCustM.pCustVATNo;
            txtTelPhone.Text = oblCustM.pCustPhone1;
            txtFax.Text = oblCustM.pCustFax;
            txtCell.Text = oblCustM.pCustCellNo;
            txtEmail.Text = oblCustM.pCustEmail;
            txtContPerInv.Text = oblCustM.pCustContactPerson_Invoice;
            txtContPerSer.Text = oblCustM.pCustContactPerson_Technical;

        }
        private void pMsPopItemDet()
        {
            QuotationTrans qutTrans = new QuotationTrans();
            CustomMaster oblCustM = new CustomMaster();
            ADTWebService wsoj = new ADTWebService();
            qutTrans.pOrgCode = ERPSystemData.COM_DOM_ORG_CODE.AEL.ToString();
            qutTrans.pQuotationNo = txtQuotNo.Text;

            //  Page.Validate();
            UIvalidations uiv = new UIvalidations();
            UserSpecificData objumst = new UserSpecificData();
            objumst.pObjId = 28;
            objumst.pModType = ServiceMain.ModuleId;

            if (uiv.CheckModuleAccess(objumst))
            {
               qutTrans.pBrnCd = objumst.pBrnCode;
               DataTable dt= wsoj.gMsItemDet(qutTrans);
               gvItemDescription.DataSource = null;
               gvItemDescription.DataSource = dt;
               gvItemDescription.DataBind();
            }
        }

       
    }
}