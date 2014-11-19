using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ERPAdvantage.Inventory.InventoryMaster
{
    public partial class TC_ORG_MST : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void Create_TI_ORG_MST()
        {
            Advantage.ERP.DAL.DataContract.UserSpecificData objUSD = new Advantage.ERP.DAL.DataContract.UserSpecificData();
            Advantage.ERP.DAL.DataContract.Inventory.OrgMst objMst = new Advantage.ERP.DAL.DataContract.Inventory.OrgMst();
            ADTWebService objWs = new ADTWebService();

            objMst.pCOM_ORG_CD = txtCOM_ORG_CD.Text;
            objMst.pCOM_ORG_BRANCH_FLAG = txtCOM_ORG_BRANCH_FLAG.Text;
            objMst.pCOM_ORG_MAIN_CODE = txtCOM_ORG_MAIN_CODE.Text;
            objMst.pCOM_ORG_NAME = txtCOM_ORG_NAME.Text;
            objMst.pCOM_VAT_NO = txtCOM_VAT_NO.Text;
            objMst.pCOM_ORG_CONT_PER = txtCOM_ORG_CONT_PER.Text;
            objMst.pCOM_ORG_ADD = txtCOM_ORG_ADD.Text;
            objMst.pCOM_ORG_CITY = txtCOM_ORG_CITY.Text;
            objMst.pCOM_ORG_PROV = txtCOM_ORG_PROV.Text;
            objMst.pCOM_ORG_CTRY = txtCOM_ORG_CTRY.Text;
            objMst.pCOM_ORG_PIN = txtCOM_ORG_PIN.Text;
            objMst.pCOM_ORG_PH1 = txtCOM_ORG_PH1.Text;
            objMst.pCOM_ORG_PH2 = txtCOM_ORG_PH2.Text;
            objMst.pCOM_ORG_FAX1 = txtCOM_ORG_FAX1.Text;
            objMst.pCOM_ORG_FAX2 = txtCOM_ORG_FAX2.Text;
            objMst.pCOM_ORG_EMAIL = txtCOM_ORG_EMAIL.Text;
            objMst.pCOM_ORG_WEB = txtCOM_ORG_WEB.Text;
            objMst.pCOM_ORG_CREA_BY = "Samidna";
            objMst.pCOM_ORG_CREA_DT = DateTime.Now;
        }

        protected void cmdSave_Click(object sender, EventArgs e)
        {
            Create_TI_ORG_MST();
        }

        protected void cmdUpdate_Click(object sender, EventArgs e)
        {

        }


    }
}