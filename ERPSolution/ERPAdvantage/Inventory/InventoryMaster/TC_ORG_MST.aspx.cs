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
            Advantage.ERP.DAL.DataContract.Inventory.TC_ORG_MST objMst = new Advantage.ERP.DAL.DataContract.Inventory.TC_ORG_MST();
            ADTWebService objWs = new ADTWebService();

            objMst.COM_ORG_CD = txtCOM_ORG_CD.Text;
            objMst.COM_ORG_BRANCH_FLAG = txtCOM_ORG_BRANCH_FLAG.Text;
            objMst.COM_ORG_MAIN_CODE = txtCOM_ORG_MAIN_CODE.Text;
            objMst.COM_ORG_NAME = txtCOM_ORG_NAME.Text;
            objMst.COM_VAT_NO = txtCOM_VAT_NO.Text;
            objMst.COM_ORG_CONT_PER = txtCOM_ORG_CONT_PER.Text;
            objMst.COM_ORG_ADD = txtCOM_ORG_ADD.Text;
            objMst.COM_ORG_CITY = txtCOM_ORG_CITY.Text;
            objMst.COM_ORG_PROV = txtCOM_ORG_PROV.Text;
            objMst.COM_ORG_CTRY = txtCOM_ORG_CTRY.Text;
            objMst.COM_ORG_PIN = txtCOM_ORG_PIN.Text;
            objMst.COM_ORG_PH1 = txtCOM_ORG_PH1.Text;
            objMst.COM_ORG_PH2 = txtCOM_ORG_PH2.Text;
            objMst.COM_ORG_FAX1 = txtCOM_ORG_FAX1.Text;
            objMst.COM_ORG_FAX2 = txtCOM_ORG_FAX2.Text;
            objMst.COM_ORG_EMAIL = txtCOM_ORG_EMAIL.Text;
            objMst.COM_ORG_WEB = txtCOM_ORG_WEB.Text;
            objMst.COM_ORG_CREA_BY = "Samidna";
            objMst.COM_ORG_CREA_DT = DateTime.Now;
        }

        protected void cmdSave_Click(object sender, EventArgs e)
        {
            Create_TI_ORG_MST();
        }


    }
}