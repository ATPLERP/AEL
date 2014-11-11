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

public partial class MST_CustomerMaster : System.Web.UI.Page
{
   UserSpecificData objumst = new UserSpecificData();
   TSEC_USR_OBJData objTs = new TSEC_USR_OBJData(); 
   ADTWebService wsoj = new ADTWebService();
   CustomMaster objMst = new CustomMaster();
    
   string cFlagSE;
    protected void Page_Load(object sender, EventArgs e)
    {
        objMst.pOrgCode = ERPSystemData.COM_DOM_ORG_CODE.AEL.ToString();
        objMst.pCustCode = "";
        cFlagSE = Convert.ToString(Session["cFlagSE"]);
        if (!IsPostBack)
        {
                       
           UIvalidations uiv = new UIvalidations();
            uiv.ClearInputs(Page.Controls);
            getPrefix();
            getArea();
            getCategory();
            //uiv.DisableControls(Page, false );
            DataSet dt= wsoj.getCustDetails(objMst);
            gvCustomerDetails.DataSource = null;
            gvCustomerDetails.DataSource = dt;
            gvCustomerDetails.DataBind();
        }
       
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
  private void getCategory()
    {
       UIControl uicon = new UIControl();
       ADTWebService wsoj = new ADTWebService();
       Advantage.ERP.DAL.DataContract.CustomMaster objMst = new Advantage.ERP.DAL.DataContract.CustomMaster();
       objMst.pOrgCode = ERPSystemData.COM_DOM_ORG_CODE.AEL.ToString();
       objMst.pDomType = ERPSystemData.COM_DOM_TYPE.CUSTOMER_CATEGORY.ToString();
       List<gDropdownlist> drplist = wsoj.pMsGetCategory(objMst);
       uicon.FillDropdownList(ddlCatogory, drplist, "COM_DOM_CODE", "COM_DOM_DESC");
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
         uicon.FillDropdownList(ddlAreaNameSearch, drplist, "COM_DOM_CODE", "COM_DOM_DESC");
     }

  protected void btnSave_Click(object sender, EventArgs e)
     {
        //  Page.Validate();
         UIvalidations uiv = new UIvalidations();
         UserSpecificData objumst = new UserSpecificData();
         objumst.pObjId = 4;
         objumst.pModType=ServiceMain.ModuleId;
         if (uiv.CheckModuleAccess(objumst))
         {
             gMsCreateCustDetails(objumst);
         }
         else
         {
             lblStates.Text = Resources.UIMessege.msgAdeni;
             lblStates.ForeColor = Color.Red;
         }
        
     }

  private void gMsCreateCustDetails(Advantage.ERP.DAL.DataContract.UserSpecificData objuMod)
    {
       bool success=false;
       ADTWebService wsoj = new ADTWebService();
       CustomMaster objMst = new CustomMaster();
       UIvalidations uiv = new UIvalidations();

       if (uiv.Isnotname(txtFname.Text.Trim()))
       {
           lblStates.Text = Resources.UIMessege.msgVName;
           lblStates.ForeColor = Color.Red;
           txtFname.Focus();
           return;
       }
       else
       {
         objMst.pCustName = txtFname.Text.Trim();
       }

         objumst.pUserId = objuMod.pUserId;
         objumst.pBrnCode = objuMod.pBrnCode;
         objumst.pModType = objuMod.pModType;
         objumst.pObjId = objuMod.pObjId;
       
         success = wsoj.gMsGetUserPermissioncheck(objuMod);
         if (success == true && objuMod.pNew == "Y")
         {
             try
             {
                // objMst.pUserId = "admin";
                 objMst.pCustPrefix = ddlPrefix.SelectedItem.Text;
                 objMst.pCustAdd = txtInAddress.Text;
                 objMst.pCustServiceAddress = txtSerAddress.Text;
                 objMst.pCustArea = ddlAreaName.SelectedItem.Text;
                 objMst.pOrgCode = ERPSystemData.COM_DOM_ORG_CODE.AEL.ToString();
                 objMst.pSpeCust = ddlSplcust.SelectedItem.Text;
                 if (!string.IsNullOrEmpty(txtCreGiven.Text.Trim()))
                 {
                     objMst.pCustCreditLimit = Convert.ToDouble(txtCreLimit.Text.Trim());
                 }
                 else
                 {
                     objMst.pCustCreditLimit = 0;
                 }

                 if (!string.IsNullOrEmpty(txtCreGiven.Text.Trim()))
                 {
                     objMst.pCustCreditGiven = Convert.ToDouble(txtCreGiven.Text.Trim());
                 }
                 else
                 {
                     objMst.pCustCreditGiven = 0;
                 }

                if (cheVatnumber.Checked == true)
                 {
                     objMst.pVATApplicable = "Y";
                 }
                 else
                 {
                     objMst.pVATApplicable = "N";
                 }
                 objMst.pCustVATNo = txtVatNo.Text.Trim();
                 objMst.pSVAT = txtSvatNo.Text.Trim();
                 objMst.pCustCategory = ddlCatogory.SelectedItem.Text;
                 objMst.pSVAT_Cat = ddlSvatcatogary.SelectedItem.Text;
                 objMst.pCustPhone1 = txttelNo1.Text.Trim();
                 objMst.pCustPhone2 = txtTelno2.Text.Trim();
                 objMst.pCustFax = txtFaxno.Text.Trim();
                 objMst.pCustCellNo = txtMobNo.Text.Trim();

                 if (!string.IsNullOrEmpty(this.txtEmailAddress.Text))
                 {
                     if (uiv.IsnotEmailAddress(this.txtEmailAddress.Text))
                     {
                         lblStates.Text = Resources.UIMessege.msgIsValiedEmail;
                         lblStates.ForeColor = Color.Red;
                         txtEmailAddress.Focus();
                         return;
                     }
                     else
                     {
                         objMst.pCustEmail = txtEmailAddress.Text.Trim();
                         // lblEmailAddress.Text = "";
                     }
                 }
                 else
                 {
                     objMst.pCustEmail = ""; 
                 }
                 objMst.pCustContactPerson_Technical = txtContPerSer.Text.Trim();
                 objMst.pCustContactPerson_PhoneNo3 = txtTelnoSer.Text.Trim();
                 objMst.pCustContactPerson_PhoneNo4 = txtTelnoInv.Text.Trim();

                 if (!string.IsNullOrEmpty(objMst.pSVAT_Cat))
                 {
                     uiv.CatNo(objMst);
                 }
                 else
                 {
                     objMst.pCat_No = "";
                     objMst.pCat_Desc = "";
                 }
                                  
                 if (btnSave.Text == ERPSystemData.Status.Update.ToString())
                 {
                      objMst.pCustCode = this.gvCustomerDetails.SelectedDataKey.Values[0].ToString();
                     //Update function
                     wsoj.gMsUpdateCust(objMst);
                     lblStates.Text = Resources.UIMessege.msgUpdateOk;
                     lblStates.ForeColor = Color.Blue;
                     btnSave.Text = ERPSystemData.Status.Save.ToString();
                     uiv.DisableControls(Page, false); 
                 }
                 else if (btnSave.Text == ERPSystemData.Status.Save.ToString()) 
                  {
                    //Call Saving Function
                     // uiv.CatNo(objMst);
                     string custcode = uiv.GenerateCustomerCode(objMst);
                     objMst.pCustCode = custcode;
                     bool success1 = false;
                     success1 = uiv.CHKSelect(Page.Controls);
                     if (success1 == false)
                    {
                         wsoj.gMsCreateCustDetails(objMst);
                         objMst.pCustCode = "";
                       
                         DataSet dt=wsoj.getCustDetails(objMst);
                         gvCustomerDetails.DataSource = dt;
                         gvCustomerDetails.DataBind(); 
                        
                         lblStates.Text = Resources.UIMessege.msgSaveOk;
                         lblStates.ForeColor = Color.Blue;
                         uiv.DisableControls(Page, false); 
                     }
                   else
                     {
                        lblStates.Text =Resources.UIMessege.msgSelect;
                   }
                 }
             
             }
             catch (Exception )
             {
                 lblStates.Text = Resources.UIMessege.msgSaveError;
                 lblStates.ForeColor = Color.Red;
             }
            }
         else
         {
             lblStates.Text = Resources.UIMessege.msgAdeni;
             lblStates.ForeColor = Color.Red;
         }
     }
   protected void gvCustomerDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
       // string studentID = ((Label)gvCustomerDetails.Rows[e.RowIndex].FindControl("Label1")).Text;
        //call the get methtod
    }

    protected void gvCustomerDetails_SelectedIndexChanged(object sender, EventArgs e)
    {
        bool success = false;
        //ADTWebService wsoj = new ADTWebService();
        //CustomMaster objMst = new CustomMaster();
        UserSpecificData objumst = new UserSpecificData();
        UserSpecificData objuMod = new UserSpecificData();
        UIvalidations uiv = new UIvalidations();
        objuMod.pObjId = 4;
        objuMod.pModType = ServiceMain.ModuleId; 

        if (uiv.CheckModuleAccess(objuMod))
        {
            objumst.pUserId = objuMod.pUserId;
            objumst.pBrnCode = objuMod.pBrnCode;
            objumst.pModType = objuMod.pModType;
            objumst.pObjId = objuMod.pObjId;

            success = wsoj.gMsGetUserPermissioncheck(objumst);
            if (success == true && objumst.pEdit == "Y" && objumst.pView == "Y")
            {
                try
                {
                    objMst.pOrgCode = ERPSystemData.COM_DOM_ORG_CODE.AEL.ToString();
                    objMst.pCustCode = this.gvCustomerDetails.SelectedDataKey.Values[0].ToString();
                    wsoj.gMsGetCustomerList(objMst);

                    if (!string.IsNullOrEmpty(objMst.pCustPrefix))
                    {
                        //objMst.pCustPrefix = objMst.pCustPrefix.Substring(0, 1).ToUpper() + objMst.pCustPrefix.Substring(1).ToLower();
                        ddlPrefix.SelectedValue = objMst.pCustPrefix;
                    }
                    else
                    {
                        ddlPrefix.SelectedIndex = -1;
                    }
                    txtFname.Text = objMst.pCustName.ToString();
                    txtInAddress.Text = objMst.pCustAdd.ToString();
                    txtSerAddress.Text = objMst.pCustServiceAddress;
                    if (!string.IsNullOrEmpty(objMst.pCustArea))
                    {
                        ddlAreaName.SelectedValue = objMst.pCustArea;
                    }
                    else
                    {
                        ddlAreaName.SelectedIndex = -1;
                    }
                    if (!string.IsNullOrEmpty(objMst.pCustCategory))
                    {
                        ddlCatogory.SelectedValue = objMst.pCustCategory;
                    }
                    else
                    {
                        ddlCatogory.SelectedIndex = -1;
                    }

                    ddlSplcust.Text = objMst.pSpeCust;
                    txtCreLimit.Text = objMst.pCustCreditLimit.ToString();
                    txtCreGiven.Text = objMst.pCustCreditGiven.ToString();

                    if (objMst.pVATApplicable == "Y")
                    {
                        cheVatnumber.Checked = true;
                    }
                    else
                    {
                        cheVatnumber.Checked = false;
                    }
                    txtVatNo.Text = objMst.pCustVATNo;
                    txtSvatNo.Text = objMst.pSVAT;
                    ddlSvatcatogary.SelectedIndex = 1;
                    txttelNo1.Text = objMst.pCustPhone1;
                    txtTelno2.Text = objMst.pCustPhone2;
                    txtFaxno.Text = objMst.pCustFax;
                    txtMobNo.Text = objMst.pCustCellNo;
                    txtEmailAddress.Text = objMst.pCustEmail;
                    txtContPerSer.Text = objMst.pCustContactPerson_Technical;
                    txtTelnoSer.Text = objMst.pCustContactPerson_PhoneNo3;
                    txtConPerinv.Text = objMst.pCustContactPerson_Invoice;
                    txtTelnoInv.Text = objMst.pCustContactPerson_PhoneNo4;

                    btnSave.Text = ERPSystemData.Status.Update.ToString();

                }
                catch (Exception)
                {
                    //lblError.Text = Resources.UIMessege.msgSaveError;
                }

            }
            else if (success == true && objumst.pView == "Y")
            {
                uiv.DisableControls(Page, false);
            }
        }
        else
        {
            lblStates.Text = Resources.UIMessege.msgAdeni;
            lblStates.ForeColor = Color.Red;
        }

    }

    protected void btnReset_Click(object sender, EventArgs e)
    {
       UIvalidations uiv = new UIvalidations();
       //Clear the inputs to save new record.
       uiv.ClearInputs(Page.Controls);
       //Enable the controls to edit.
       uiv.DisableControls(Page, true);
       btnSave.Text = ERPSystemData.Status.Save.ToString();
       lblStates.Text = "";
    }

    protected void gvCustomerDetails_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        ADTWebService wsoj = new ADTWebService();
        CustomMaster objMst = new CustomMaster();
        objMst.pCustCode = "";
        objMst.pOrgCode = ERPSystemData.COM_DOM_ORG_CODE.AEL.ToString();
        objMst.pCustName = txtCustomerName.Text;
        objMst.pCustPhone1 = txttelNoSerch.Text;
        objMst.pCustArea = ddlAreaNameSearch.SelectedItem.Text;
        if (objMst.pCustArea == "---Select---")
        {
            objMst.pCustArea = "";
        }
        objMst.pCustAdd = txtAddressSerch.Text;

        if (cFlagSE != "Search")
        {
            DataSet dt = wsoj.getCustDetails(objMst);
            gvCustomerDetails.PageIndex = e.NewPageIndex;//
            gvCustomerDetails.DataSource = null;
            gvCustomerDetails.DataSource = dt;
            gvCustomerDetails.DataBind();
            
        }
        else
        {
            DataSet ds = wsoj.gMsGetCustomerList(objMst);
            gvCustomerDetails.PageIndex = e.NewPageIndex;//
            gvCustomerDetails.DataSource = null;
            gvCustomerDetails.DataSource = ds;
            gvCustomerDetails.DataBind();
        }

      
    }
  protected void btnSearch_Click(object sender, EventArgs e)
    {
        Session["cFlagSE"] = "Search";
        ADTWebService wsoj = new ADTWebService();
        CustomMaster objMst = new CustomMaster();
        try
        {
            objMst.pSearch = Convert.ToString(Session["cFlagSE"]);
            objMst.pCustCode = "";
            objMst.pOrgCode = ERPSystemData.COM_DOM_ORG_CODE.AEL.ToString();
            objMst.pCustName = txtCustomerName.Text;
            objMst.pCustPhone1 = txttelNoSerch.Text;
            objMst.pCustArea = ddlAreaNameSearch.SelectedItem.Text;
            if (objMst.pCustArea == "---Select---")
            {
                objMst.pCustArea = "";
            }
            objMst.pCustAdd = txtAddressSerch.Text;
            DataSet ds= wsoj.gMsGetCustomerList(objMst);
            if (objMst.pSelect != "Select")
            {
               gvCustomerDetails.DataSource = null;
               gvCustomerDetails.DataSource = ds;
               gvCustomerDetails.DataBind();
            }

        }
        catch (Exception )
        {
            //lblError.Text = Resources.UIMessege.msgSaveError;
        }
    }
  protected void gvCustomerDetails_PageIndexChanged(object sender, EventArgs e)
     {
          //deselect the prior selected index after paging
         gvCustomerDetails.SelectedIndex = -1;

     }

     
    
 
}