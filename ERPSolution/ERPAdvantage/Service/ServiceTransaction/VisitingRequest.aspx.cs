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
using Advantage.ERP.DAL.DataContract.Inventory;

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

        private void GetModelByAppliance(string Appcode)
        {
            UIControl uic = new UIControl();
            ADTWebService ws = new ADTWebService();
            ItemMst objitem=new ItemMst();
            objitem.pAppliance = Appcode;
            List<gDropdownlist> droplist = ws.gMsGetModelByappliance(objitem);
            uic.FillDropdownList(ddlmodel, droplist, "COM_DOM_DESC", "COM_DOM_DESC");
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
            UIControl uic = new UIControl();
            ADTWebService ws = new ADTWebService();
            VisitingReq objvr = new VisitingReq();
            objvr.pOrgcode = ERPSystemData.COM_DOM_ORG_CODE.AEL.ToString();
            objvr.pCustomerName = txtsearchcustomername.Text;
            objvr.pCustPhone = txtsearchphoneno.Text;
            objvr.pCustArea = txtsearchcustomerarea.Text;
            objvr.pCustomerAddressInv = txtsearchcustomeraddress.Text;
            DataSet ds = null;
            ds=ws.gMsGetCustomerListForVisitingReguest(objvr);
            gvcustomerlist.DataSource = ds;
            gvcustomerlist.DataBind();
        }

        private void GetCustomerDataByCustCode()
        {
            UIControl uic = new UIControl();
            ADTWebService ws = new ADTWebService();
            VisitingReq objvr = new VisitingReq();
            objvr.pOrgcode = ERPSystemData.COM_DOM_ORG_CODE.AEL.ToString();
            objvr.pCustCode = Convert.ToInt32(txtcustomercode.Text);
            SqlDataReader dr=ws.gMsGetCustomerDataByCustomerCode(objvr);
            while (dr.Read())
            {
                txtcustomername.Text = dr["CustomerName"].ToString();
                ddlprefix.SelectedItem.Text = dr["Prefix"].ToString();
                txtinvoiceaddress.Text = dr["InvoiceAddress"].ToString();
                txtserviceaddress.Text = dr["ServiceAddress"].ToString();
                ddlarea.SelectedIndex = ddlarea.Items.IndexOf(ddlarea.Items.FindByValue(dr["Area"].ToString()));
                txtvatno.Text = dr["VatNo"].ToString();
                txtphoneno.Text = dr["ContactNo"].ToString();
                txtmobileno.Text = dr["Mobile"].ToString();
                               
            }

        }

        private void GetItemDataByStockCode(string Stockcode)
        {
            ADTWebService ws = new ADTWebService();
            ItemMst objitem = new ItemMst();
            objitem.pOrgCode = ERPSystemData.COM_DOM_ORG_CODE.AEL.ToString();
            objitem.pStockCode = Stockcode;
            SqlDataReader sdr=ws.gMsGetItemDataForVisitRequestBySTCode(objitem);
            while (sdr.Read())
            {
                txtitemappliance.Text = sdr["Appliance"].ToString();
            }
            
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
            if (ViewState["gvoption"].ToString() == "department")
            {
                txtsearchbydeptname.Enabled = true;
                txtsearchbywarrbyno.Enabled = false;
                txtsearchbwarrbyname.Enabled = false;
                txtsearchbwarrbytp.Enabled = false;
                txtsearchwarrbyserialno.Enabled = false;
                txtserachwarrbyaddress.Enabled = false;
            }
            else if (ViewState["gvoption"].ToString() == "warranty")
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
            DataSet ds = null;
            dgriddeptorwarranty.DataSource = ds;
            dgriddeptorwarranty.DataBind();

            ViewState["gvoption"] = "department";
                
           

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

            DataSet ds = null;
            dgriddeptorwarranty.DataSource = ds;
            dgriddeptorwarranty.DataBind();
            ViewState["gvoption"]="warranty";

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
            GetCustomerDataByCustCode();
            panelsearchcustomer.Visible = false;
        }

        protected void btnsearch2_Click(object sender, EventArgs e)
        {

            if (ViewState["gvoption"].ToString() == "department")
            {
                UIControl uic = new UIControl();
                ADTWebService ws = new ADTWebService();
                VisitingReq objvr = new VisitingReq();
                objvr.pDepatName = txtsearchbydeptname.Text;
                DataSet ds = null;
                ds = ws.gMsGetDepartmentForVisitingRequest(objvr);
                dgriddeptorwarranty.DataSource = ds;
                dgriddeptorwarranty.DataBind();
            }
            else if (ViewState["gvoption"].ToString() == "warranty")
            {
                UIControl objui = new UIControl();
                ADTWebService objws = new ADTWebService();
                WarrantyMst objwarr = new WarrantyMst();
                objwarr.pSerialNo = txtsearchwarrbyserialno.Text;
                objwarr.pWarrantyNo = txtsearchbywarrbyno.Text;
                objwarr.pCustName = txtsearchbwarrbyname.Text;
                objwarr.pCustAddInv = txtserachwarrbyaddress.Text;
                objwarr.pCustPhoneNo = txtsearchbwarrbytp.Text;
                objwarr.pSalesOrderNo = txtsearchbwarrbusalesorder.Text;
                DataSet ds = null;
                ds=objws.gMsGetWarrantyForVisitingRequest(objwarr);
                dgriddeptorwarranty.DataSource = ds;
                dgriddeptorwarranty.DataBind();
            }
        }

        protected void dgriddeptorwarranty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ViewState["gvoption"].ToString() == "department")
            {
                txtdeptcode.Text = dgriddeptorwarranty.SelectedRow.Cells[1].Text;
                txtdepratment.Text = dgriddeptorwarranty.SelectedRow.Cells[2].Text;
                panelsearchappliance.Visible = false;
            }
            else if (ViewState["gvoption"].ToString() == "warranty")
            {
                txtwarranttno.Text = dgriddeptorwarranty.SelectedRow.Cells[3].Text;                
                panelsearchappliance.Visible = false;
            }
        }

        protected void cmdgetitemlist_Click(object sender, EventArgs e)
        {
            if (PanelSearchItem.Visible == false)
            {
                PanelSearchItem.Visible = true;
            }
            else
            {
                PanelSearchItem.Visible = false;
            }
        }

        protected void btnsearchitemcode_Click(object sender, EventArgs e)
        {
            UIControl uic = new UIControl();
            ADTWebService ws = new ADTWebService();
            ItemMst objitem = new ItemMst();
            objitem.pStockCode=txtsearchbyitemcode.Text;
            objitem.pItemDescription=txtsearchbyitemname.Text;
            objitem.pMajorGroup=ddlsearchbymajorgroup.SelectedValue;
            objitem.pAppliance=txtsearchbyappliance.Text;
            DataSet ds = null;
            ds=ws.gMsGetItemDataForVisitingRequest(objitem);
            gvitem.DataSource = ds;
            gvitem.DataBind();
        }

        protected void gvitem_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtitemcd.Text = gvitem.SelectedRow.Cells[1].Text;
            txtstockcode.Text = gvitem.SelectedRow.Cells[2].Text;
            GetItemDataByStockCode(txtstockcode.Text.Trim());
            GetModelByAppliance(txtitemappliance.Text);
            PanelSearchItem.Visible = false;

        }
    }
}