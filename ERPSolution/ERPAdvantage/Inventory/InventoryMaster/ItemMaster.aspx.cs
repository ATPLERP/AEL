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
            I_ItemMaster objMst = new I_ItemMaster();
            ADTWebService objWs = new ADTWebService();

            objMst.OrgCode = ERPSystemData.COM_DOM_ORG_CODE.AEL.ToString();
            objMst.StockCode = txtStockCode.Text;
            objMst.ItemDescription = txtItemDescription.Text;
            objMst.MajorGroup = txtMajorGroup.Text;
            objMst.Appliance = txtAppliance.Text;
            objMst.Brand = txtBrand.Text;
            objMst.ModelNo = txtModelNo.Text;
            objMst.Capacity = txtCapacity.Text;
            objMst.PurchaseType = txtPurchaseType.Text;
            objMst.FSN = txtFSN.Text;
            objMst.VATPercentage = Convert.ToDecimal(txtVATPercentage.Text);
            objMst.UoM = txtUoM.Text;
            objMst.LifeTime = Convert.ToInt32(txtLifeTime.Text);
            objMst.Obsolete = txtObsolete.Text;
            objMst.HSCode = txtHSCode.Text;
            objMst.LastGRNNo = txtLastGRNNo.Text;
            objMst.LastInCost = Convert.ToDecimal(txtLastInCost.Text);
            objMst.AverageCost = Convert.ToDecimal(txtAverageCost.Text);
            objMst.StockApplicable = txtStockApplicable.Text;
            objMst.LedgerCode = txtLedgerCode.Text;
            objMst.CreatedBy = txtCreatedBy.Text;
            objMst.CreateDate = Convert.ToDateTime(txtCreateDate.Text);
            objMst.UpDatedBy = null;
            objMst.UpDatedDate = null;
            objMst.InstllationAmt = Convert.ToDecimal(txtInstllationAmt.Text);
            objMst.PartNo = txtPartNo.Text;
            objMst.ST = txtST.Text;
            objMst.NormCode = txtNormCode.Text;
            objMst.RateCategory = txtRateCategory.Text;
            objMst.JobType = txtJobType.Text;
            objMst.Duration = txtDuration.Text;
            objMst.Meterial = Convert.ToDecimal(txtMeterial.Text);
            objMst.Labour = Convert.ToDecimal(txtLabour.Text);
            objMst.Points = Convert.ToDecimal(txtPoints.Text);
            objMst.CommonJob = txtCommonJob.Text;

            objWs.Create_I_ItemMaster(objMst);

        }
    }
}