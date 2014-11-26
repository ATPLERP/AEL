using Advantage.ERP.DAL.DataContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ERPAdvantage.Costing.CostingMaster
{
    public partial class ChargeMaster : System.Web.UI.Page
    {
    

        protected void Page_Load(object sender, EventArgs e)
        {

            //**************** objMst.pOrgCode = ERPSystemData.COM_DOM_ORG_CODE.AEL.ToString();
            UIControl uic = new UIControl();


           
         

        }

        protected void cmdsave_Click(object sender, EventArgs e)
        {
            UIControl uic = new UIControl();
            ADTWebService wser = new ADTWebService();
 
            UserSpecificData objumst = new UserSpecificData();  // specing
            UserSpecificData objuMod = new UserSpecificData();
            UIvalidations uiv = new UIvalidations();
            objuMod.pObjId = 6;   // Form Object Id
            objuMod.pModType = CostingMain.ModuleId; 



            if (uiv.CheckModuleAccess(objuMod))
            {
                objumst.pUserId = objuMod.pUserId;
                objumst.pBrnCode = objuMod.pBrnCode;
                objumst.pModType = objuMod.pModType;
                objumst.pObjId = objuMod.pObjId;
            }


            Advantage.ERP.DAL.DataContract.Costing.ChargeMaster objapp = new Advantage.ERP.DAL.DataContract.Costing.ChargeMaster();
            
            ////////////////////////////////
            //check if already ---CHARGE NAME available---
            //////////////////////////


            //objapp.pOrgCode = ERPSystemData.COM_DOM_ORG_CODE.AEL.ToString();
            objapp.pChargeNumber = 0;

            //objapp.pChargeHeading = "YYYY1";
            objapp.pChargeHeading = ddlPrefix.Text;
            
            //objapp.pChargeName = "YYYY1";
            objapp.pChargeName = txtCommonCharge.Text.Trim();
            
            //objapp.pItemLevel = true;
            objapp.pItemLevel = cheVatnumber.Checked;
            
            //objapp.pCreatedBy = "YYYY1";            
            objapp.pCreatedBy = objumst.pUserId;
            
            
            objapp.pCreatedDate = DateTime.Now;
            objapp.pUpdatedBy = "YYYY1";
            objapp.pUpdatedDate = DateTime.Now;

            wser.CreateChargeMaster(objapp);          
        }
    }
}