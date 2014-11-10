using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AjaxControlToolkit;

namespace ERPAdvantage
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPopup_Click(object sender, EventArgs e)
        {
           this.btnPopup_ModalPopupExtender.Show();

        }

      
    }
}
