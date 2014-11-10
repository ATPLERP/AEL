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
            // uicon.FillDropdownList(ddlAreaNameSearch, drplist, "COM_DOM_CODE", "COM_DOM_DESC");
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
            // uicon.FillDropdownList(ddlAreaNameSearch, drplist, "COM_DOM_CODE", "COM_DOM_DESC");
        }

    }
}