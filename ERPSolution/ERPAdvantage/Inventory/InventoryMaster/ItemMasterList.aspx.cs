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
    public partial class ItemMasterList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadItemGrid();
        }
        private void LoadItemGrid()
        {
            ADTWebService wsObj = new ADTWebService();
            ItemMst objMst = new ItemMst();
            objMst.pStockCode = txtStockCode.Text;
            objMst.pMajorGroup = txtMajorGroup.Text;
            objMst.pItemDescription = txtMajorGroup.Text;
            objMst.pPartNo = txtPartNo.Text;
            objMst.pModelNo = txtModelNo.Text; 

            DataSet ds = wsObj.wSel_ItemMaster(objMst);
            gvItemMaster.DataSource = null;
            gvItemMaster.DataSource = ds;
            gvItemMaster.DataBind();

            //gvItemMaster.Columns[0].ItemStyle.Width = 200;


        }

        protected void btnView_Click(object sender, EventArgs e)
        {
            LoadItemGrid();
        }
    }
}