using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web.UI.HtmlControls;
using Advantage.ERP.DAL.DataContract;
using Advantage.ERP.BLL;

namespace ERPAdvantage.Account
{
    public partial class Login : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
              gMsGetBranchList();
            }
           
           // RegisterHyperLink.NavigateUrl = "Register.aspx?ReturnUrl=" + HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
            
        }

        private void gMsGetBranchList()
        {
            
            UIControl uicon = new UIControl();

           // Page page = (Page)HttpContext.Current.Handler;
            DropDownList ddlBranch = ((DropDownList)this.LoginUser.FindControl("ddlBranch"));
           // TextBox txtBranchName = ((TextBox)this.LoginUser.FindControl("txtBranchName"));
              
            ADTWebService wsoj = new ADTWebService();
           // WSTest wsoj = new WSTest();
            UserSpecificData objuMst = new UserSpecificData();
            objuMst.pOrgCode = ERPSystemData.COM_DOM_ORG_CODE.AEL.ToString();
            // tmpDataSet = wsoj.gMsGetBranchData(objuMst);
           // uicon.FillDropdownList(ddlBranch, tmpDataSet.Tables[0],"COM_ORG_CD","COM_ORG_NAME");
           //txtBranchName.Text = ddlBranch.SelectedItem.Text;
            List<gDropdownlist> drplist = wsoj.gMsGetBranchData(objuMst);
            uicon.FillDropdownList(ddlBranch, drplist, "COM_ORG_CD", "COM_ORG_NAME");      
        }

        protected void ddlBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList ddlBranch = ((DropDownList)this.LoginUser.FindControl("ddlBranch"));
            TextBox txtBranchName = ((TextBox)this.LoginUser.FindControl("txtBranchName"));
            txtBranchName.Text = ddlBranch.SelectedItem.Text;
        }

        private void Cmd_Login_Click()
        {
         //  bool success=false;
            //Creating objects for general classes
            UserSpecificData objumst = new UserSpecificData();
            UIvalidations uiv = new UIvalidations();
            objumst.pPwd=uiv.GetMD5(((TextBox)this.LoginUser.FindControl("Password")).ToString());
            objumst.pUserId =((TextBox)this.LoginUser.FindControl("UserName")).ToString(); 
            objumst.pBrnCode=((DropDownList)this.LoginUser.FindControl("ddlBranch")).Text;
           // success=gMsValidateUser();

        }
       
        
    }
}
