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
using ERPAdvantage;
//using ERPAdvantage.MST;
using Advantage.ERP.BLL;
namespace ERPAdvantage.MST
{
    public partial class CustomerM : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               // getPrefix();
               // getArea();
               // getCategory();
            }
        
        }
        //private void getPrefix()
        //{
        //    DataSet tmpDataSet;
        //    UIControl uicon = new UIControl();

        //    // API.Service1 wsoj = new API.Service1();
        //    ADTWebService wsoj = new ADTWebService();
        //    CustomMaster objMst = new CustomMaster();
        //    // API.CustomMaster objMst = new API.CustomMaster();

        //    objMst.pOrgCode = ERPSystemData.COM_DOM_ORG_CODE.AEL.ToString();
        //    objMst.pDomType = ERPSystemData.COM_DOM_TYPE.PREFIX.ToString();

        //    // tmpDataSet = wsoj.pMsGetCategory(objMst);
        //    // uicon.FillDropdownList(ddlPrefix, tmpDataSet.Tables[0], "COM_DOM_CODE", "COM_DOM_DESC");
        //    List<gDropdownlist> drplist = wsoj.pMsGetCategory(objMst);
        //    //gDropdownlist dr = new gDropdownlist("COM_DOM_CODE", "COM_DOM_DESC");

        //    uicon.FillDropdownList(ddlPrefix, drplist, "COM_DOM_CODE", "COM_DOM_DESC");

        //    // ddlPrefix.DataSource = drplist;
        //    // ddlPrefix.DataBind();
        //}

        //private void getCategory()
        //{
        //    DataSet tmpDataSet;
        //    UIControl uicon = new UIControl();
        //    //API.Service1 wsoj = new API.Service1();
        //    //API.CustomMaster objMst = new API.CustomMaster();
        //    ADTWebService wsoj = new ADTWebService();
        //    Advantage.ERP.DAL.DataContract.CustomMaster objMst = new Advantage.ERP.DAL.DataContract.CustomMaster();


        //    objMst.pOrgCode = ERPSystemData.COM_DOM_ORG_CODE.AEL.ToString();
        //    objMst.pDomType = ERPSystemData.COM_DOM_TYPE.CUSTOMER_CATEGORY.ToString();
        //    // tmpDataSet = wsoj.pMsGetCategory(objMst);
        //    // uicon.FillDropdownList(ddlCatogory , tmpDataSet.Tables[0], "COM_DOM_CODE", "COM_DOM_DESC");
        //    List<gDropdownlist> drplist = wsoj.pMsGetCategory(objMst);
        //    uicon.FillDropdownList(ddlCatogory, drplist, "COM_DOM_CODE", "COM_DOM_DESC");
        //}

        //private void getArea()
        //{
        //    DataSet tmpDataSet;
        //    UIControl uicon = new UIControl();

        //    //API.Service1 wsoj = new API.Service1();
        //    ADTWebService wsoj = new ADTWebService();
        //    //API.CustomMaster objMst = new API.CustomMaster() ;
        //    CustomMaster objMst = new CustomMaster();
        //    objMst.pOrgCode = ERPSystemData.COM_DOM_ORG_CODE.AEL.ToString();
        //    objMst.pDomType = ERPSystemData.COM_DOM_TYPE.AREA.ToString();
        //    // tmpDataSet = wsoj.pMsGetCategory(objMst);
        //    // uicon.FillDropdownList(ddlAreaName, tmpDataSet.Tables[0], "COM_DOM_CODE", "COM_DOM_DESC");
        //    List<gDropdownlist> drplist = wsoj.pMsGetCategory(objMst);
        //    uicon.FillDropdownList(ddlAreaName, drplist, "COM_DOM_CODE", "COM_DOM_DESC");
        //}



        protected void btnPopup_Click(object sender, EventArgs e)
        {
         //   this.btnPopup_ModalPopupExtender.Show();

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
           // gMsCreateCustDetails();
        }
    }
}