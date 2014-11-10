using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Advantage.ERP.BLL;
using Advantage.ERP.DAL.DataContract;

namespace ERPAdvantage.Service.ServiceMaster
{
    public partial class AreaMaster : System.Web.UI.Page
    {
        ADTWebService wsoj = new ADTWebService();
        UserSpecificData objuMst = new UserSpecificData();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetArea();
                GetCustomerServiceCenter();
            }
        }

        private void GetArea()
        {
            var uicon = new UIControl();
            var wsoj = new ADTWebService();
            var objMst = new CustomMaster
            {
                pOrgCode = ERPSystemData.COM_DOM_ORG_CODE.AEL.ToString(),
                pDomType = ERPSystemData.COM_DOM_TYPE.AREA.ToString()
            };
            List<gDropdownlist> drplist = wsoj.pMsGetCategory(objMst);
            uicon.FillDropdownList(ddlArea, drplist, "COM_DOM_CODE", "COM_DOM_DESC");
        }

        private void GetCustomerServiceCenter()
        {
            var uicon = new UIControl();
            ADTWebService wsoj = new ADTWebService();
            objuMst.pOrgCode = ERPSystemData.COM_DOM_ORG_CODE.AEL.ToString();
            var drplist = wsoj.gMsGetBranchData(objuMst);
            uicon.FillDropdownList(ddlCutomerServiceCenter, drplist, "COM_ORG_NAME", "COM_ORG_CD");
        }
    }
}