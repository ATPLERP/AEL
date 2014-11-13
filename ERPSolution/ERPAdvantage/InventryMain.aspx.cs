using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Advantage.ERP.DAL.DataContract.Inventory;

namespace ERPAdvantage
{
    public partial class InventryMain : System.Web.UI.Page
    {
        public const string ModuleId = "19";// Stores module ID
        protected void Page_Load(object sender, EventArgs e)
        {
            ADTWebService objWs = new ADTWebService();
            ItemMst objMst = new ItemMst();
        }

        private void getStoreList()
        { 

        }
    }
}