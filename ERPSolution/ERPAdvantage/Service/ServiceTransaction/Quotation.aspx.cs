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
<<<<<<< HEAD
using System.Windows.Forms; 
//using ERPAdvantage.MST;
using Advantage.ERP.BLL;
using Microsoft.VisualBasic;
=======
using Advantage.ERP.BLL;
using Advantage.ERP.DAL.DataContract.Service;
using Advantage.ERP.DAL.DataContract.Inventory;
>>>>>>> 9448027d02381d679bf555fce2be0fe0803b5bb4

namespace ERPAdvantage.Service.ServiceTransaction
{
    public partial class Quotation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ADTWebService wsoj = new ADTWebService();
            UIControl uicon = new UIControl();
            QuotationTrans qutTrans = new QuotationTrans();
            if (!IsPostBack)
            {
                getPrefix();
                getArea();
                GetAppliance();
                pMsGetQuotationCategory();
                uicon.filllMajorGroup(ddlMajorGroup, ERPSystemData.lMajorGroup.S.ToString());
                 // pMsItmLst();
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
               ViewState["CurrentTableexisting"] = dt;
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
            btnApplianceList_ModalPopupExtender.Show();
            pMsItmLst();
          
        }
        private void GetAppliance()
        {
            UIControl ui = new UIControl();
            ADTWebService wser = new ADTWebService();
            Appliancemst app = new Appliancemst();
            app.pOrgCode = ERPSystemData.COM_DOM_ORG_CODE.AEL.ToString();
            app.pApplianceCode = string.Empty;
            app.pApplianceName = string.Empty;
            DataSet ds = wser.GetApplianceList(app);
            ddlApplianceCode.DataValueField = "ApplianceCode";
            ddlApplianceCode.DataTextField = "ApplianceCode";
            ddlApplianceCode.DataSource = ds;
            ddlApplianceCode.DataBind();
        }
        private void pMsItmLst()
        {
           ADTWebService wsoj = new ADTWebService();
           QuotationTrans qutTrans = new QuotationTrans();
           qutTrans.pOrgCode=ERPSystemData.COM_DOM_ORG_CODE.AEL.ToString();
           qutTrans.pStockCode =txtItemCode.Text;
           qutTrans.pItemName =txttItemname.Text;
           qutTrans.pAppCode = ddlApplianceCode.SelectedValue ;  
           qutTrans.pMajorCode =ddlMajorGroup.SelectedItem.Text ;
           DataTable dt =wsoj.gMsOrgItemList(qutTrans);
           gvOrgItemList.DataSource = dt;
           gvOrgItemList.DataBind();
           btnApplianceList_ModalPopupExtender.Show(); 

        }
          
        protected void gvOrgItemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            QuotationTrans qutTrans = new QuotationTrans();
            ADTWebService wsoj = new ADTWebService();
            UIvalidations uiv = new UIvalidations();
            UserSpecificData objumst = new UserSpecificData();
            objumst.pObjId = 28;
            objumst.pModType = ServiceMain.ModuleId;

            if (uiv.CheckModuleAccess(objumst))
            {
                qutTrans.pBrnCd = objumst.pBrnCode;
                qutTrans.pStockCode = gvOrgItemList.SelectedRow.Cells[2].Text;
                qutTrans.pOrgCode = ERPSystemData.COM_DOM_ORG_CODE.AEL.ToString();
                qutTrans.pPriceType = ERPSystemData.PriceType.S.ToString();   
               // qutTrans.pGroupType = ERPSystemData.GroupType.General.ToString();
                txtAppliaenceCode.Text = qutTrans.pStockCode;
                wsoj.gMsGetStockCode(qutTrans);
                    txtDescription.Text = qutTrans.pItemName;
                    txtVAT.Text = qutTrans.lVATPer.ToString();
                    if (txtAppliaenceCode.Text != string.Empty)
                    {
                     pMsItmLst();
                    }
                    bool success = wsoj.gMsGetStockPrice(qutTrans);
                    //lblStates.Text = Resources.UIMessege.msgPriceCheck;
                    txtPrice.Text = qutTrans.pPrice.ToString();
            }
            else
              {
                lblStates.Text = Resources.UIMessege.msgAdeni;
                lblStates.ForeColor = Color.Red;
             }
        }

        protected void gvOrgItemList_PageIndexChanged(object sender, EventArgs e)
        {
           //deselect the prior selected index after paging
            gvOrgItemList.SelectedIndex = -1;
            btnApplianceList_ModalPopupExtender.Show();
        }

        protected void gvOrgItemList_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            ADTWebService wsoj = new ADTWebService();
            QuotationTrans qutTrans = new QuotationTrans();
            qutTrans.pOrgCode = ERPSystemData.COM_DOM_ORG_CODE.AEL.ToString();
            //Page.Validate();
            UIvalidations uiv = new UIvalidations();
            UserSpecificData objumst = new UserSpecificData();
            objumst.pObjId = 28;
            objumst.pModType = ServiceMain.ModuleId;
            if (uiv.CheckModuleAccess(objumst))
            {
                qutTrans.pStockCode = txtItemCode.Text;
                qutTrans.pItemName = txttItemname.Text;
                qutTrans.pAppCode = ddlApplianceCode.SelectedValue;
                qutTrans.pMajorCode = ddlMajorGroup.SelectedItem.Text;
                DataTable dt = wsoj.gMsOrgItemList(qutTrans);
                gvOrgItemList.PageIndex = e.NewPageIndex;//
                gvOrgItemList.DataSource = null;
                gvOrgItemList.DataSource = dt;
                gvOrgItemList.DataBind();
                btnApplianceList_ModalPopupExtender.Show();
            }
            else
            {
                lblStates.Text = Resources.UIMessege.msgAdeni;
                lblStates.ForeColor = Color.Red;
            }
        }

        protected void btnAddList_Click(object sender, EventArgs e)
        {
           
         Addata();
        }
        protected void Addata()
        {
            bool success = false;
            ADTWebService wsoj = new ADTWebService();
            QuotationTrans qutTrans = new QuotationTrans();
            if (txtPrice.Text == "0")
            {MessageBox.Show(Resources.UIMessege.msgPriceCheck); }
           // if (qutTrans.pItemCode == 0)
           // {MessageBox.Show(Resources.UIMessege.msgCheckItemode);}
            if (txtAppliaenceCode.Text.Trim() == "0")
            {MessageBox.Show(Resources.UIMessege.msgCheckStockCode);}
            if (txtQuontaty.Text == "0")
            {MessageBox.Show(Resources.UIMessege.msgCheckQuontity);}
            if (txtTotal.Text == "0")
            {MessageBox.Show(Resources.UIMessege.msgCheckTotalQuontity); }
            qutTrans.pTax = "NBT-S2011";
            wsoj.gMsGetTaxPercentage(qutTrans);
            DataTable dt = new DataTable();
            DataRow dr = dt.NewRow();
            MakeDataTable(dt);
            int rowcount=gvItemDescription.Rows.Count;
            //GridViewRow daataRow = new GridViewRow(1, 0, DataControlRowType.DataRow, DataControlRowState.Insert);
             foreach (GridViewRow row in gvItemDescription.Rows)
              {
                for (int i = 0; i < gvItemDescription.Columns.Count-1; i++)
                {//Add Items to Grid
                  
                    switch (i)
                    {
                        case 2://Check Item is already is Exist in GRID
                        if (txtAppliaenceCode.Text.Trim() == row.Cells[i].Text)//message
                        success = true;{}break;
                        case 1: row.Cells[i].Text = qutTrans.pItemCode.ToString(); break;
                        case 3: row.Cells[i].Text = txtDescription.Text; break;
                        case 7: row.Cells[i].Text = ddlType.SelectedValue; break;
                        case 8: row.Cells[i].Text = txtQuontaty.Text; break;
                        case 9: row.Cells[i].Text = txtPrice.Text; break;
                        case 10: row.Cells[i].Text = txtDiscountPer.Text; break;
                        case 11: row.Cells[i].Text = txtDiscounnt.Text; break;
                        case 12: row.Cells[i].Text = txtVAT.Text; break;
                        case 18: row.Cells[i].Text = qutTrans.lNBTPer.ToString(); break;
                        case 19:
                            row.Cells[i].Text = Convert.ToString(Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtQuontaty.Text) - Convert.ToDouble(txtDiscounnt.Text) * qutTrans.lNBTPer / (100 - qutTrans.lNBTPer));
                        //Col = 19: .Text = Round(((Val(txtPrice.Text) * Val(txtQuantity.Text) - Val(txtDiscountAmt)) * lNBTPer) / (100 - lNBTPer), 2)
                        qutTrans.lNBTAmt = Convert.ToDouble(row.Cells[i].Text);break;
                        case 13:
                        qutTrans.lVATAmt = Convert.ToDouble((Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtQuontaty.Text) - Convert.ToDouble(txtDiscounnt.Text) + qutTrans.lNBTAmt) * Convert.ToDouble(txtVAT.Text) / 100);
                        //lVATAmount = ((Val(txtQuantity.Text) * Val(txtprice.Text)) - Val(txtDiscountAmt.Text) + lNBTAmt) * Val(txtVAT.Text) / 100
                        row.Cells[i].Text = qutTrans.lVATAmt.ToString();break;
                        case 14: row.Cells[i].Text = txtTotal.Text; break;
                        case 15: row.Cells[i].Text = "Y"; break;
                        case 4: row.Cells[i].Text = txtItemModal.Text; break;
                        case 5: row.Cells[i].Text = txtItemSerial.Text; break;
                        case 6: row.Cells[i].Text = txtItemCapacity.Text; break;
                                              
                    }
                    dr[i] = row.Cells[i].Text;
                   // daataRow.Cells.Add(row.Cells[i]);
                   }
               
                if (success) // check if inner loop set break
                {MessageBox.Show(Resources.UIMessege.msgCheckItemSelected); txtAppliaenceCode.Focus(); break; } // break outer loop 
                }
            //}
         
           dt.Rows.Add(dr);
             //gvItemDescription.Controls[0].Controls.AddAt(6, daataRow);
           //dt.AcceptChanges();
           ViewState["CurrentTable"] = dt;
           //(gvItemDescription.DataSource as DataTable).Rows.Add(dr);
           DataTable dtOldDAta = (DataTable)ViewState["CurrentTableexisting"];
           DataTable dtNewData = (DataTable)ViewState["CurrentTable"];
          // DataSet ds = new DataSet();
          // ds.Tables.Add(dtOldDAta);
          // ds.Tables.Add(dtNewData);
           dtOldDAta.Merge(dtNewData, true);

           gvItemDescription.DataSource = dtNewData;
           gvItemDescription.DataBind();

           // DataTable dt = new DataTable();
            //for (int j = 1; j < gvItemDescription.Rows.Count; j++)
            //{
            //    DataRow dr;
            //    GridViewRow row = gvItemDescription.Rows[j];
            //    dr = dt.NewRow();
            //    for (int i =1; i < row.Cells.Count; i++)
            //    {
            //        dr[i] = row.Cells[i].Text;
            //    }
            //    dt.Rows.Add(dr);

            //}
            
            CalGridTotal();
      }

        private void MakeDataTable(DataTable dt)
        {
            dt.Columns.Add("#");
            dt.Columns.Add("ItemCode");
            dt.Columns.Add("StockCode");
            dt.Columns.Add("ItemDescription");
            dt.Columns.Add("ItemModal");
            dt.Columns.Add("ItemSerialNo");
            dt.Columns.Add("ItemCapacity");
            dt.Columns.Add("Category");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Price");
            dt.Columns.Add("Discount[%]");
            dt.Columns.Add("DiscountAmt");
            dt.Columns.Add("VATPer");
            dt.Columns.Add("VAT");
            dt.Columns.Add("Amount");
            dt.Columns.Add("S");
            dt.Columns.Add("X");
            dt.Columns.Add("Stock");
            dt.Columns.Add("NBTPer");
            dt.Columns.Add("NBTAmt");
            
        }
                   
  }

}