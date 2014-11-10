using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Advantage.ERP.DAL.DataContract;
using ERPAdvantage;
using System.Collections;
using System.Drawing;
using Advantage.ERP.BLL;
using System.Data;
using System.Data.SqlClient;

namespace ERPAdvantage.Service.ServiceTransaction
{
    public partial class VisitingRequest : System.Web.UI.Page
    {

        string gvoption = null;

        private void LoadJobCategory()
        {
            UIControl uic = new UIControl();
            ADTWebService ws = new ADTWebService();
            VisitingReq objvr = new VisitingReq();
            objvr.pOrgcode = ERPSystemData.COM_DOM_ORG_CODE.AEL.ToString();
            objvr.pJobCategory = ERPSystemData.COM_DOM_TYPE.JOB_CATEGORY.ToString();
            List<gDropdownlist> drplist = ws.gMsGetCategoryforVisitingReq(objvr);
            uic.FillDropdownList(ddlcategory, drplist, "COM_DOM_CODE", "COM_DOM_CODE");                     
                                    
            
        }

        private void LoadJobPriority()
        {
            UIControl uic = new UIControl();
            ADTWebService ws = new ADTWebService();
            VisitingReq objvr = new VisitingReq();
            objvr.pOrgcode = ERPSystemData.COM_DOM_ORG_CODE.AEL.ToString();
            objvr.pJobPriority = ERPSystemData.COM_DOM_TYPE.PRIORITY.ToString();
            List<gDropdownlist> drplist = ws.gMsGetPriorityforVisitingReq(objvr);
            uic.FillDropdownList(ddlpriority, drplist, "COM_DOM_CODE", "COM_DOM_CODE");


        }

        private void LoadPrefix()
        {
            UIControl uic = new UIControl();
            ADTWebService ws = new ADTWebService();
            VisitingReq objvr = new VisitingReq();
            objvr.pOrgcode = ERPSystemData.COM_DOM_ORG_CODE.AEL.ToString();
            objvr.pCustprefif = ERPSystemData.COM_DOM_TYPE.PREFIX.ToString();
            List<gDropdownlist> drpolist = ws.gMsGetPrefixforVisitingRequest(objvr);
            uic.FillDropdownList(ddlprefix, drpolist, "COM_DOM_CODE", "COM_DOM_CODE");
        }

        private void LoadArea()
        {
            UIControl uic = new UIControl();
            ADTWebService ws = new ADTWebService();
            VisitingReq objvr = new VisitingReq();
            objvr.pOrgcode = ERPSystemData.COM_DOM_ORG_CODE.AEL.ToString();
            objvr.pCustArea = ERPSystemData.COM_DOM_TYPE.AREA.ToString();
            List<gDropdownlist> droplist= ws.gMsGetAreaForVisitingRequest(objvr);
            uic.FillDropdownList(ddlarea, droplist, "COM_DOM_CODE", "COM_DOM_CODE");
        }

        private void GetCustomerList()
        {
            //UIControl uic = new UIControl();
            //ADTWebService ws = new ADTWebService();
            //CustomMaster objcus = new CustomMaster();
            //objcus.pOrgCode = ERPSystemData.COM_DOM_ORG_CODE.AEL.ToString();
            //objcus.pCustName = txtsearchcustomername.Text;
            //objcus.pCustPhone1 = txtsearchphoneno.Text;
            //objcus.pCustArea = txtsearchcustomerarea.Text;
            //objcus.pCustAdd = txtsearchcustomeraddress.Text;
            //DataSet ds = ws.gMsGetCustomerDetailList(objcus);
            //try
            //{
            //    gvcustomerlist.DataSource = ds.Tables[0];
            //    gvcustomerlist.DataBind();
            //    gvcustomerlist.Caption = gvcustomerlist.Rows.Count.ToString() + "  " + "Record(s) found";
            //}
            //catch (Exception ex)
            //{

            //}
                       

        }


        protected void Page_Load(object sender, EventArgs e)
        {
            LoadJobCategory();
            LoadJobPriority();
            LoadPrefix();
            LoadArea();
        }

        protected void cmdgetlist_Click(object sender, EventArgs e)
        {
            if (panelvistitinglist.Visible == true)
            {
                panelvistitinglist.Visible = false;
            }
            else
            {
                panelvistitinglist.Visible = true;
            }
        }

        private void changeGvoption(string Option)
        {
            if (Option == "department")
            {
                txtsearchbydeptname.Enabled = true;
                txtsearchbywarrbyno.Enabled = false;
                txtsearchbwarrbyname.Enabled = false;
                txtsearchbwarrbytp.Enabled = false;
                txtsearchwarrbyserialno.Enabled = false;
                txtserachwarrbyaddress.Enabled = false;
            }
            else if (Option == "warranty")
            {
                txtsearchbydeptname.Enabled = false;
                txtsearchbywarrbyno.Enabled = true;
                txtsearchbwarrbyname.Enabled = true;
                txtsearchbwarrbytp.Enabled = true;
                txtsearchwarrbyserialno.Enabled = true;
                txtserachwarrbyaddress.Enabled = true;
            }

        }


        protected void cmdgetdeptlist_Click(object sender, EventArgs e)
        {
            gvoption = "department";

            if (panelsearchappliance.Visible == true)
            {
                panelsearchappliance.Visible = false;
            }
            else
            {
                panelsearchappliance.Visible = true;
                changeGvoption("department");
            }
        }

        protected void cmdgetwarrantylist_Click(object sender, EventArgs e)
        {
            gvoption = "warranty";

            if (panelsearchappliance.Visible == true)
            {
                panelsearchappliance.Visible = false;
            }
            else
            {
                panelsearchappliance.Visible = true;
                changeGvoption("warranty");
            }
        }

        protected void btngetcustlist_Click(object sender, EventArgs e)
        {

        }

    

        protected void btngetcustlist_Click1(object sender, EventArgs e)
        {
            if (panelsearchcustomer.Visible == true)
            {
                panelsearchcustomer.Visible = false;
            }
            else
            {
                panelsearchcustomer.Visible = true;
            }
        }

        protected void dbtnsearchcustomer_Click(object sender, EventArgs e)
        {
            GetCustomerList();
        }

        protected void gvcustomerlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtcustomercode.Text = gvcustomerlist.SelectedRow.Cells[1].Text;
            panelsearchcustomer.Visible = false;
        }
    }
}