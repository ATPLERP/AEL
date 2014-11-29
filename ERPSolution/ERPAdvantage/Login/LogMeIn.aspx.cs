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


namespace ERPAdvantage.Login
{
    public partial class LogMeIn : System.Web.UI.Page
    {
        ADTWebService wsoj = new ADTWebService();
        UserSpecificData objuMst = new UserSpecificData();
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
            //DropDownList ddlBranch = ((DropDownList)this.LoginUser.FindControl("ddlBranch"));
            DropDownList ddlBranch = ((DropDownList)this.ddlBranch);
            objuMst.pOrgCode = ERPSystemData.COM_DOM_ORG_CODE.AEL.ToString();
            List<gDropdownlist> drplist = wsoj.gMsGetBranchData(objuMst);
            uicon.FillDropdownList(ddlBranch, drplist, "COM_ORG_NAME", "COM_ORG_CD");
        }

        protected void ddlBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBranchName.Text = ddlBranch.SelectedValue;
                 
        }

        private void LoginToTheSystem()
        {
            bool success = false;
            //Creating objects for general classes
           
            UIvalidations uiv = new UIvalidations();
            objuMst.pUserId = UserName.Text; 
            objuMst.pPwd = Password.Text;
            objuMst.pOrgCode = ERPSystemData.COM_DOM_ORG_CODE.AEL.ToString();
            objuMst.pBrnCode = ddlBranch.SelectedItem.Text;
            Session["LoggedOrg"] = objuMst.pOrgCode;
            Session["LoggedUser"] = objuMst.pUserId;
            Session["LoggedBranch"] = objuMst.pBrnCode;
            
            success = wsoj.gMsCheckPassword(objuMst);
            List<TSEC_USR_OBJ> list = wsoj.gMsCheckSpecifiedModulepermission(objuMst);
            // Write the user permission to access at least one module list back to session state.
            Session["UserPerModules"] = list;
            Session["UserobjuMst"] = objuMst;
        
            if (list.Count>=0)
            {
            if (success == true)
            {
               Response.Redirect("~/Default.aspx");
            }
            }

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            LoginToTheSystem();
        }
    }
}