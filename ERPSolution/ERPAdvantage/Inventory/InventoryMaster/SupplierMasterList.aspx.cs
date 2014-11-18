using Advantage.ERP.DAL.DataContract.Inventory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ERPAdvantage.Inventory.InventoryMaster
{
    public partial class SupplierMasterList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void LoadSupplierDetails()
        {
            ADTWebService wsObj = new ADTWebService();
            SupplierMst objMst = new SupplierMst();

            objMst.pSupplierCode = txtSupplierCode.Text;
            objMst.pSupplierName = txtSupplierName.Text;
            objMst.pCountry = txtCountry.Text;
            objMst.pTypeOfSupplier = txtTypeOfSuppler.Text;

            DataSet ds = wsObj.wsListSupplier(objMst);
            gvSupplierList.DataSource = null;
            gvSupplierList.DataSource = ds;
            gvSupplierList.DataBind();


            
        }

        protected void btnView_Click(object sender, EventArgs e)
        {
            LoadSupplierDetails();
        }
    }
}