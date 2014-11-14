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
//using ERPAdvantage.MST;
using Advantage.ERP.BLL;
using Microsoft.VisualBasic;

namespace ERPAdvantage.Service.ServiceTransaction
{
    public partial class Quotation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UIControl uicon = new UIControl();
            if (!IsPostBack)
            {
                getPrefix();
                getArea();
                GetAppliancecategory();
                pMsGetQuotationCategory();
                uicon.filllMajorGroup(ddlMajorGroup, ERPSystemData.lMajorGroup.S.ToString());
                pMsItmLst();
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
               CalGridTotal();
            }
        }

        private void CalGridTotal()
        {
           QuotationTrans qutTrans = new QuotationTrans();
           txtGrandTotal.Text = string.Empty ;
           txtVATTotal.Text = string.Empty;
           txtDiscountTotal.Text = string.Empty;
           txtNetAmount.Text = string.Empty;
           txtNBTAmt.Text = string.Empty;
           double lVATAmtOld = 0;
           double lNBTAmtold = 0;
           double lDisAmtold = 0;
           double lGrandTotold = 0; 
            
           foreach(GridViewRow row in gvItemDescription.Rows)
           {
               for (int i = 0; i < gvItemDescription.Columns.Count; i++)
               {
                   string header = gvItemDescription.Columns[i].HeaderText;
                   String cellText = row.Cells[i].Text;
                   switch (i)
                   {
                       case 8:
                           if (!string.IsNullOrEmpty(row.Cells[i].Text))
                           {qutTrans.lQty = Convert.ToDouble(row.Cells[i].Text);}//Quantity
                           else { qutTrans.lQty = 0; }break;
                       case 9:
                           if (!string.IsNullOrEmpty(row.Cells[i].Text))
                           {qutTrans.lPrice = Convert.ToDouble(row.Cells[i].Text); }//Price
                           else{qutTrans.lPrice = 0;}break;
                       case 10:
                           if (!string.IsNullOrEmpty(row.Cells[i].Text))
                           {qutTrans.lDisPer = Convert.ToDouble(row.Cells[i].Text); } //Dis Percentage
                           else{qutTrans.lDisPer = 0;} break;
                       case 11:
                           if (!string.IsNullOrEmpty(row.Cells[i].Text))
                           {qutTrans.lDisAmt = Convert.ToDouble(row.Cells[i].Text); } //Dis Amount
                           else{qutTrans.lDisAmt = 0;}break;
                       case 12:
                          if (!string.IsNullOrEmpty(row.Cells[i].Text))
                          {qutTrans.lVATPer = Convert.ToDouble(row.Cells[i].Text); }//VAT Percentage
                          else{qutTrans.lVATPer = 0;}break;
                       case 13:
                          if (!string.IsNullOrEmpty(row.Cells[i].Text))
                          { qutTrans.lVATAmt = Convert.ToDouble(row.Cells[i].Text); }//VAT Amount
                          else{qutTrans.lVATAmt = 0;}break;
                       case 18:
                           if (!string.IsNullOrEmpty(row.Cells[i].Text))
                           { qutTrans.lNBTPer = Convert.ToDouble(row.Cells[i].Text); }//NBT Percentage
                           else{qutTrans.lNBTPer = 0;}break;
                       case 19:
                           if (qutTrans.lNBTPer == 0) {row.Cells[i].Text = "0"; qutTrans.lNBTAmt = 0; }
                           {qutTrans.lNBTAmt = ((qutTrans.lQty * qutTrans.lPrice) - qutTrans.lDisAmt) * qutTrans.lNBTPer / (100 - qutTrans.lNBTPer);
                           row.Cells[i].Text = qutTrans.lNBTAmt.ToString();}
                           qutTrans.lNBTAmt = lNBTAmtold + qutTrans.lNBTAmt;
                           lNBTAmtold = qutTrans.lNBTAmt;
                           txtNBTAmt.Text = qutTrans.lNBTAmt.ToString();
                           qutTrans.lGrandTot = (qutTrans.lQty * qutTrans.lPrice);
                          // lGrandTotold = qutTrans.lGrandTot;
                           qutTrans.lGrandTot = lGrandTotold + qutTrans.lGrandTot;
                           lGrandTotold = qutTrans.lGrandTot;
                           txtGrandTotal.Text = qutTrans.lGrandTot.ToString(); 
                           //txtGrandTotal.Text = txtGrandTotal.Text + (qutTrans.lQty * qutTrans.lPrice);
                           if (qutTrans.lDisAmt == 0)
                           {
                               row.Cells[11].Text = Convert.ToString(((qutTrans.lQty * qutTrans.lPrice) * qutTrans.lDisPer)/ 100);
                               qutTrans.lDisAmt = Convert.ToDouble(row.Cells[11].Text);
                               qutTrans.lDisAmt = lDisAmtold + qutTrans.lDisAmt;
                               lDisAmtold = qutTrans.lDisAmt;
                               txtDiscountTotal.Text = qutTrans.lDisAmt.ToString();                             
                           }
                            row.Cells[13].Text = Convert.ToString((((qutTrans.lQty * qutTrans.lPrice) - qutTrans.lDisAmt) + qutTrans.lNBTAmt) * qutTrans.lVATPer / 100); //VAT AMOUNT
                            //qutTrans.lVATAmt = 0;
                            qutTrans.lVATAmt = Convert.ToDouble(row.Cells[13].Text); //VAT Amount
                            //double lVATAmtOld = 0;
                            qutTrans.lVATAmt = lVATAmtOld + qutTrans.lVATAmt;
                            lVATAmtOld = qutTrans.lVATAmt;
                            txtVATTotal.Text = qutTrans.lVATAmt.ToString();
                            row.Cells[14].Text =Convert.ToString(((qutTrans.lQty * qutTrans.lPrice) + qutTrans.lVATAmt) - qutTrans.lDisAmt + qutTrans.lNBTAmt);//Total Amount
                            qutTrans.lNetAmount = ((qutTrans.lGrandTot + qutTrans.lVATAmt) - qutTrans.lDisAmt) + qutTrans.lNBTAmt;
                            txtNetAmount.Text = qutTrans.lNetAmount.ToString();
                            break;
                         // txtNetAmount.Text =txtGrandTotal.Text.Trim() + txtVATTotal.Text.Trim() - txtDiscountTotal.Text.Trim() + txtNBTAmt.Text.Trim() ;
                          
                   }

               
               }
           }


        }

        protected void btnApplianceList_Click(object sender, EventArgs e)
        {
           // pnModelPopupitem.Visible = true;
            //btnApplianceList_ModalPopupExtender.Show();
            // pMsItmLst();
        }

        protected void btnItemSearch_Click(object sender, EventArgs e)
        {

        }

        private void GetAppliancecategory()
        {
            UIControl uic = new UIControl();
            ADTWebService wser = new ADTWebService();
            Appliancemst objapp = new Appliancemst();
            objapp.pOrgCode = ERPSystemData.COM_DOM_ORG_CODE.AEL.ToString();
            objapp.pAppCategory = ERPSystemData.COM_DOM_TYPE.APPLIANCE_CATEGORY.ToString();
            List<gDropdownlist> droplist = wser.pMsGetAppliancecategory(objapp);
            uic.FillDropdownList(ddlApplianceCode, droplist, "COM_DOM_CODE", "COM_DOM_DESC");

        }
        private void pMsItmLst()
        {
           ADTWebService wsoj = new ADTWebService();
           QuotationTrans qutTrans = new QuotationTrans();
           qutTrans.pOrgCode=ERPSystemData.COM_DOM_ORG_CODE.AEL.ToString();
           qutTrans.pStockCode =txtItemCode.Text;
           qutTrans.pItemName =txttItemname.Text;
           //qutTrans.pMajorCode =;
          // qutTrans.pAppCode =;
          SqlDataReader dr =wsoj.gMsOrgItemList(qutTrans);

        }
        
        
    }
}