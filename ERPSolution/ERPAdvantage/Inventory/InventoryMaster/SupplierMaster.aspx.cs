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
            I_SupplierMaster objMst = new I_SupplierMaster();
            ADTWebService objWs = new ADTWebService();

            objMst.OrgCode = ERPSystemData.COM_DOM_ORG_CODE.AEL.ToString(); ;
            objMst.SupplierCode = txtSupplierCode.Text;
            objMst.Prefix = txtPrefix.Text;
            objMst.SupplierName = txtSupplierName.Text;
            objMst.Address = txtAddress.Text;
            objMst.Country = txtCountry.Text;
            objMst.ContactPerson = txtContactPerson.Text;
            objMst.MobileNo = txtMobileNo.Text;
            objMst.PhoneNo1 = txtPhoneNo1.Text;
            objMst.PhoneNo2 = txtPhoneNo2.Text;
            objMst.Fax = txtFax.Text;
            objMst.Email = txtEmail.Text;
            objMst.VATNo = txtVATNo.Text;
            objMst.TypeOfSupplier = txtTypeOfSupplier.Text;
            objMst.PurchaseType = txtPurchaseType.Text;
            objMst.LeadTime = Convert.ToInt32(txtLeadTime.Text);
            objMst.CreditLimit = Convert.ToDecimal(txtCreditLimit.Text);
            objMst.CreditLimitTime = Convert.ToInt32(txtCreditLimitTime.Text);
            objMst.LastPurchaseDate = Convert.ToDateTime(txtLastPurchaseDate.Text);
            objMst.CurrentCreditAmount = Convert.ToDecimal(txtCurrentCreditAmount.Text);
            objMst.VATApplicable = txtVATApplicable.Text;
            objMst.Category = txtCategory.Text;
            objMst.CreatedBy = "Saminda";
            objMst.CreateDate = DateTime.Now;

            objWs.Create_I_SupplierMaster(objMst);
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            Create_SupplierMaster();
        }

    }
}