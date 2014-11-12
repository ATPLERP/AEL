using Advantage.ERP.DAL.DataContract;
using Advantage.ERP.DAL.DataContract.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ERPAdvantage.Inventory.InventoryMaster
{
    public partial class ItemMaster : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cmdSave_Click(object sender, EventArgs e)
        {
            Create_I_ItemMaster();
        }

        private void Create_I_ItemMaster()
        {
            UserSpecificData objUsd = new UserSpecificData();
            ItemMst objMst = new ItemMst();
            ADTWebService objWs = new ADTWebService();

            objMst.pOrgCode = ERPSystemData.COM_DOM_ORG_CODE.AEL.ToString();
            objMst.pStockCode = txtStockCode.Text;
            objMst.pItemDescription = txtItemDescription.Text;
            objMst.pMajorGroup = txtMajorGroup.Text;
            objMst.pAppliance = txtAppliance.Text;
            objMst.pBrand = txtBrand.Text;
            objMst.pModelNo = txtModelNo.Text;
            objMst.pCapacity = txtCapacity.Text;
            objMst.pPurchaseType = txtPurchaseType.Text;
            objMst.pFSN = txtFSN.Text;
            objMst.pVATPercentage = Convert.ToDecimal(txtVATPercentage.Text);
            objMst.pUoM = txtUoM.Text;
            objMst.pLifeTime = Convert.ToInt32(txtLifeTime.Text);
            objMst.pObsolete = txtObsolete.Text;
            objMst.pHSCode = txtHSCode.Text;
            objMst.pLastGRNNo = txtLastGRNNo.Text;
            objMst.pLastInCost = Convert.ToDecimal(txtLastInCost.Text);
            objMst.pAverageCost = Convert.ToDecimal(txtAverageCost.Text);
            objMst.pStockApplicable = txtStockApplicable.Text;
            objMst.pLedgerCode = txtLedgerCode.Text;
            objMst.pCreatedBy = txtCreatedBy.Text;
            objMst.pCreateDate = Convert.ToDateTime(txtCreateDate.Text);
            objMst.pUpDatedBy = null;
            objMst.pUpDatedDate = null;
            objMst.pInstllationAmt = Convert.ToDecimal(txtInstllationAmt.Text);
            objMst.pPartNo = txtPartNo.Text;
            objMst.pST = txtST.Text;
            objMst.pNormCode = txtNormCode.Text;
            objMst.pRateCategory = txtRateCategory.Text;
            objMst.pJobType = txtJobType.Text;
            objMst.pDuration = txtDuration.Text;
            objMst.pMeterial = Convert.ToDecimal(txtMeterial.Text);
            objMst.pLabour = Convert.ToDecimal(txtLabour.Text);
            objMst.pPoints = Convert.ToDecimal(txtPoints.Text);
            objMst.pCommonJob = txtCommonJob.Text;

            objWs.Create_I_ItemMaster(objMst);

        }
    }
}