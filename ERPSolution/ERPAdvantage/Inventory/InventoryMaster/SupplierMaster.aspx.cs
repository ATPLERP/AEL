using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Advantage.ERP.DAL.DataContract.Inventory;
using Advantage.ERP.BLL;
using System.Data;
using Advantage.ERP.DAL.DataContract;

namespace ERPAdvantage.Inventory.InventoryMaster
{
    public partial class SupplierMaster : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void Create_SupplierMaster()
        {
            UserSpecificData objUsd = new UserSpecificData();
            SupplierMst objMst = new SupplierMst();
            ADTWebService objWs = new ADTWebService();

            objMst.pOrgCode = ERPSystemData.COM_DOM_ORG_CODE.AEL.ToString(); ;
            objMst.pSupplierCode = txtSupplierCode.Text;
            objMst.pPrefix = txtPrefix.Text;
            objMst.pSupplierName = txtSupplierName.Text;
            objMst.pAddress = txtAddress.Text;
            objMst.pCountry = txtCountry.Text;
            objMst.pContactPerson = txtContactPerson.Text;
            objMst.pMobileNo = txtMobileNo.Text;
            objMst.pPhoneNo1 = txtPhoneNo1.Text;
            objMst.pPhoneNo2 = txtPhoneNo2.Text;
            objMst.pFax = txtFax.Text;
            objMst.pEmail = txtEmail.Text;
            objMst.pVATNo = txtVATNo.Text;
            objMst.pTypeOfSupplier = txtTypeOfSupplier.Text;
            objMst.pPurchaseType = txtPurchaseType.Text;
            objMst.pLeadTime = Convert.ToInt32(txtLeadTime.Text);
            objMst.pCreditLimit = Convert.ToDecimal(txtCreditLimit.Text);
            objMst.pCreditLimitTime = Convert.ToInt32(txtCreditLimitTime.Text);
            objMst.pLastPurchaseDate = Convert.ToDateTime(txtLastPurchaseDate.Text);
            objMst.pCurrentCreditAmount = Convert.ToDecimal(txtCurrentCreditAmount.Text);
            objMst.pVATApplicable = txtVATApplicable.Text;
            objMst.pCategory = txtCategory.Text;
            objMst.pCreatedBy = "Saminda";
            objMst.pCreateDate = DateTime.Now;

            objWs.Create_I_SupplierMaster(objMst);
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            Create_SupplierMaster();
        }

    }
}