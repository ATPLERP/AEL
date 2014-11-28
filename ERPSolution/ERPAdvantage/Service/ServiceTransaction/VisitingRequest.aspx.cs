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
using Advantage.ERP.DAL.DataContract.Service;
using System.Data.Common;


namespace ERPAdvantage.Service.ServiceTransaction
{
    public partial class VisitingRequest : System.Web.UI.Page
    {
        #region Form Params
        string gvoption = null;
#endregion Form Params

        #region form Methods

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

        private string getApplianceType(string Stockcode)
        {
            ADTWebService ws = new ADTWebService();
            ItemMst objitem = new ItemMst();
            objitem.pStockCode = Stockcode;
            SqlDataReader sdr= ws.gMsGetApplianceCategoryForVisitingRequest(objitem);
            while (sdr.Read())
            {
                return sdr[0].ToString();
            }
            return "";

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

        private void GetModelListByAppliance(string AppCode)
        {
            UIControl uic = new UIControl();
            ADTWebService ws = new ADTWebService();
            ItemMst objitem = new ItemMst();
            objitem.pAppliance = AppCode;            
            List<gDropdownlist> droplist = ws.gMsGetModelListByappliance(objitem);
            uic.FillDropdownList(ddlmodelnos, droplist, "COM_DOM_CODE", "COM_DOM_DESC");
          
        }

        private bool CreateVisitingRequest()
        {            
            
            ADTWebService ws = new ADTWebService();
            VisitingReq objvr = new VisitingReq();
            objvr.pOrgcode = ERPSystemData.COM_DOM_ORG_CODE.AEL.ToString();
            objvr.pBrncode = Session["LoggedBranch"].ToString();
            objvr.pVisitReqno = txtvisitingno.Text;
            objvr.pVisitReqdate = Convert.ToDateTime(txtvisitingdate.Text);
            objvr.pJobCategory = ddlcategory.SelectedItem.ToString();
            objvr.pComplainDesc = txtcomplain.Text;
            objvr.pCustCode = Convert.ToInt32(txtcustomercode.Text);
            objvr.pCustprefif = ddlprefix.SelectedItem.ToString();
            objvr.pCustomerName = txtcustomername.Text;
            objvr.pCustomerAddressInv = txtinvoiceaddress.Text;
            objvr.pCustomerAddressSer = txtserviceaddress.Text;
            objvr.pCustArea = ddlarea.SelectedItem.ToString();
            objvr.pCustPhone = txtphoneno.Text;
            objvr.pCustFax = txtfaxno.Text;
            objvr.pCustMobile = txtmobileno.Text;
            objvr.pCustEmail = txtemail.Text.Trim();
            objvr.pCustVatno = txtvatno.Text.Trim();
            objvr.pContactInvoice = txtcontactperinvoice.Text.Trim();
            objvr.pContactService = txtcontactperservice.Text.Trim();
            objvr.pInstructTech = txtinstruction.Text.Trim();
            objvr.pCustReqdate = Convert.ToDateTime(txtreqdate.Text);
            objvr.pVisitReqStatus = "C";
            objvr.pVisitItemCode = Convert.ToDouble(txtitemcode.Text);
            objvr.pPaidStatus = "N";
            objvr.pCreatedBy = Session["LoggedUser"].ToString();
            objvr.pCreatedDate = DateTime.Now;
            objvr.pCompTakenby = txtcomplaintakenby.Text;
            objvr.pDepatment = Convert.ToInt16(txtdeptcode.Text);
            objvr.pDepatName = txtdepratment.Text;
            objvr.pSiteContactPerson = txtsitecontactperson.Text;
            objvr.pSiteconatctTp = txtsitetp.Text;
            objvr.pSiteContactMobno = txtsitecontactmobile.Text;
            objvr.Priority = ddlpriority.SelectedItem.ToString();


            
            if (ws.gMsCreateVisitingRequestMaster(objvr) == false)
           
            {
                return false;
            }

            
            foreach (GridViewRow gr in gvaddeditemdata.Rows)
            {
                objvr.pItemCode =Convert.ToInt32(gr.Cells[1].Text);
                objvr.pItemModel = gr.Cells[3].Text;
                objvr.pItemSerial = gr.Cells[4].Text;
                objvr.pWarrantyNo = gr.Cells[5].Text;
                objvr.pItemType = gr.Cells[6].Text;
                objvr.pItemCapacity = gr.Cells[7].Text;
                objvr.pQty = Convert.ToInt32(gr.Cells[8].Text);

                if (ws.gMsCreateVisitingRequestDetail(objvr) == false)
                {
                    return false;
                }
               
            }

            foreach (GridViewRow gr1 in gvquestions.Rows)
            {
                CheckBox chk=(CheckBox)(gr1.FindControl("chkselect"));

                if (chk.Checked)
                {
                    objvr.pQid = Convert.ToInt16(gr1.Cells[1].Text);
                    if (ws.gMsCreateVisitingRequestQuestions(objvr) == false)
                    {
                        return false;
                    }

                }
            }

            return true;

        }

        private bool UpdateVisitingRequest()
        {

            ADTWebService ws = new ADTWebService();
            VisitingReq objvr = new VisitingReq();
            objvr.pOrgcode = ERPSystemData.COM_DOM_ORG_CODE.AEL.ToString();
            objvr.pBrncode = Session["LoggedBranch"].ToString();
            objvr.pVisitReqno = txtvisitingno.Text;
            objvr.pVisitReqdate = Convert.ToDateTime(txtvisitingdate.Text);
            objvr.pJobCategory = ddlcategory.SelectedItem.ToString();
            objvr.pComplainDesc = txtcomplain.Text;
            objvr.pCustCode = Convert.ToInt32(txtcustomercode.Text);
            objvr.pCustprefif = ddlprefix.SelectedItem.ToString();
            objvr.pCustomerName = txtcustomername.Text;
            objvr.pCustomerAddressInv = txtinvoiceaddress.Text;
            objvr.pCustomerAddressSer = txtserviceaddress.Text;
            objvr.pCustArea = ddlarea.SelectedItem.ToString();
            objvr.pCustPhone = txtphoneno.Text;
            objvr.pCustFax = txtfaxno.Text;
            objvr.pCustMobile = txtmobileno.Text;
            objvr.pCustEmail = txtemail.Text.Trim();
            objvr.pCustVatno = txtvatno.Text.Trim();
            objvr.pContactInvoice = txtcontactperinvoice.Text.Trim();
            objvr.pContactService = txtcontactperservice.Text.Trim();
            objvr.pInstructTech = txtinstruction.Text.Trim();
            objvr.pCustReqdate = Convert.ToDateTime(txtreqdate.Text);
            objvr.pVisitReqStatus = "C";
            objvr.pVisitItemCode = Convert.ToDouble(gvaddeditemdata.Rows[0].Cells[1].Text);
            objvr.pPaidStatus = "N";
            objvr.pCreatedBy = Session["LoggedUser"].ToString();
            objvr.pCreatedDate = DateTime.Now;
            objvr.pCompTakenby = txtcomplaintakenby.Text;
            objvr.pDepatment = Convert.ToInt16(txtdeptcode.Text);
            objvr.pDepatName = txtdepratment.Text;
            objvr.pSiteContactPerson = txtsitecontactperson.Text;
            objvr.pSiteconatctTp = txtsitetp.Text;
            objvr.pSiteContactMobno = txtsitecontactmobile.Text;
            objvr.Priority = ddlpriority.SelectedItem.ToString();



            if (ws.gMsUpdateVisitingRequestMaster(objvr) == false)
            {
                return false;
            }


            foreach (GridViewRow gr in gvaddeditemdata.Rows)
            {
                objvr.pItemCode = Convert.ToInt32(gr.Cells[1].Text);
                objvr.pItemModel = gr.Cells[3].Text;
                objvr.pItemSerial = gr.Cells[4].Text;
                objvr.pWarrantyNo = gr.Cells[5].Text;
                objvr.pItemType = gr.Cells[6].Text;
                objvr.pItemCapacity = gr.Cells[7].Text;
                objvr.pQty = Convert.ToInt32(gr.Cells[8].Text);

                if (ws.gMsUpdateVisitingRequestDetail(objvr) == false)
                {
                    return false;
                }

            }

            foreach (GridViewRow gr1 in gvquestions.Rows)
            {
                CheckBox chk = (CheckBox)(gr1.FindControl("chkselect"));

                if (chk.Checked)
                {
                    objvr.pQid = Convert.ToInt16(gr1.Cells[1].Text);
                    if (ws.gMsUpdateVisitingRequestQuestions(objvr) == false)
                    {
                        return false;
                    }

                }
            }

            return true;

        }

        private void AddCustomerQuestions(string AppCategory)
        {
            ADTWebService ws = new ADTWebService();
            QuestionMst objque = new QuestionMst();
            objque.pAppCategory = AppCategory;
            DataSet ds = null;
            ds = ws.gMsGetQuestionListforVisitingRequest(objque);
            gvquestions.DataSource = ds;
            gvquestions.DataBind();
        }

        private void GetVisitingRequestData(string VisitingNumber)
        {
            VisitingReq objvr = new VisitingReq();
            ADTWebService ws = new ADTWebService();
            objvr.pOrgcode = ERPSystemData.COM_DOM_ORG_CODE.AEL.ToString();
            objvr.pBrncode = Session["LoggedBranch"].ToString();
            objvr.pVisitReqno = VisitingNumber;
            SqlDataReader sdr=ws.gMsGetVisitingHeaderDataByNo(objvr);
            while (sdr.Read())
            {
                txtvisitingdate.Text = sdr["VisitRequestDate"].ToString();
                ddlcategory.SelectedValue = sdr["JobCategory"].ToString();
                txtcomplain.Text = sdr["CustomerComplaint"].ToString();
                txtcustomercode.Text = sdr["CustomerCode"].ToString();
                ddlprefix.SelectedItem.Text = sdr["CustomerPrefix"].ToString();
                txtcustomername.Text = sdr["CustomerName"].ToString();
                txtinvoiceaddress.Text = sdr["CustomerAddressInvoce"].ToString();
                txtserviceaddress.Text = sdr["CustomerAddressService"].ToString();
                ddlarea.SelectedItem.Text= sdr["CustomerArea"].ToString();
                txtphoneno.Text = sdr["CustomerPhoneNo"].ToString();
                txtfaxno.Text = sdr["CustomerFaxNo"].ToString();
                txtmobileno.Text = sdr["CustomerCell"].ToString();
                txtemail.Text = sdr["CustomerEmail"].ToString();
                txtvatno.Text = sdr["CustomerVATNo"].ToString();
                txtcontactperinvoice.Text = sdr["ContactPersonInvoice"].ToString();
                txtcontactperservice.Text = sdr["ContactPersonTechnician"].ToString();
                txtinstruction.Text = sdr["InstructionToTechnician"].ToString();
                txtreqdate.Text = sdr["CustomerRequestDate"].ToString();
                txtdepratment.Text = sdr["Department"].ToString();
                txtdeptcode.Text = sdr["Deptcode"].ToString();

                DataSet ds = null;
                ds=ws.gMsGetVisitingItemDataByNo(objvr);
                gvaddeditemdata.DataSource = ds;
                gvaddeditemdata.DataBind();                              
                ds=ws.gMsgGetVisitinRegQuestions(objvr);              
                gvquestions.DataSource = ds;
                gvquestions.DataBind();
                foreach (GridViewRow gr in gvquestions.Rows)
                {
                    CheckBox chk = (CheckBox)(gr.FindControl("chkselect"));
                    chk.Checked = true;
                }



            }
        }
        
#endregion form Methods

        #region Form events


        protected void Page_Load(object sender, EventArgs e)
        {
            

            if (!IsPostBack)
            {
                chkupdate.Checked = false;
                LoadJobCategory();
                LoadJobPriority();
                LoadPrefix();
                LoadArea();
            }
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


        private void GetMajorGroupTypes(string MgType)
        {
            if (MgType == ERPSystemData.MajorGroupTypes.Service.ToString())
            {
                ddlsearchbymajorgroup.Items.Add("Complete Unit");
                ddlsearchbymajorgroup.Items.Add("Accessories");
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
                GetMajorGroupTypes(ERPSystemData.MajorGroupTypes.Service.ToString());
            }else
            {
                PanelSearchItem.Visible = false;
            }
        }

        protected void btnsearchitemcode_Click(object sender, EventArgs e)
        {
            ADTWebService ws = new ADTWebService();
            ItemMst objitem = new ItemMst();
            objitem.pOrgCode = ERPSystemData.COM_DOM_ORG_CODE.AEL.ToString();
            objitem.pStockCode = txtsearchbystockcode.Text;
            objitem.pItemDescription = txtsearchbyitemname.Text;
            objitem.pMajorGroup = ddlsearchbymajorgroup.Text;
            objitem.pAppliance = txtsearchbyappliance.Text;
            DataSet ds = null; 
            ds=ws.gMsSerachItemDetailsForVisitingRequest(objitem);
            gvitem.DataSource = ds;
            gvitem.DataBind();            
        }

        protected void gvitem_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtitemcode.Text = gvitem.SelectedRow.Cells[1].Text;
            txtstockcode.Text = gvitem.SelectedRow.Cells[2].Text;
            GetItemDataByStockCode(txtstockcode.Text);
            GetModelListByAppliance(txtitemappliance.Text);
            PanelSearchItem.Visible = false;
        }

     


        protected void btnadditem_Click(object sender, EventArgs e)
        {
            
            

            DataTable VrData = new DataTable();            
            VrData.Columns.Add(new DataColumn("Item Code",Type.GetType("System.Int64")));
            VrData.Columns.Add(new DataColumn("Stock Code", Type.GetType("System.String")));
            VrData.Columns.Add(new DataColumn("Model No", Type.GetType("System.String")));
            VrData.Columns.Add(new DataColumn("Serial No", Type.GetType("System.String")));
            VrData.Columns.Add(new DataColumn("Warranty No", Type.GetType("System.String")));
            VrData.Columns.Add(new DataColumn("Item Type", Type.GetType("System.String")));
            VrData.Columns.Add(new DataColumn("Capacity", Type.GetType("System.String")));
            VrData.Columns.Add(new DataColumn("Qty", Type.GetType("System.Int16")));
            DataRow dr = VrData.NewRow();
            dr["Item Code"] =Convert.ToInt64(txtitemcode.Text);
            dr["Stock Code"] = txtstockcode.Text;
            dr["Model No"] = ddlmodelnos.SelectedItem.ToString();
            dr["Serial No"] = txtitemserial.Text;
            dr["Warranty No"] = txtitemwarranty.Text;
            dr["Item Type"] = txtitemappliance.Text;
            dr["Capacity"] = txtitemcapacity.Text;
            dr["Qty"] = 1;
            VrData.Rows.Add(dr);
            gvaddeditemdata.DataSource = VrData;
            gvaddeditemdata.DataBind();

            AddCustomerQuestions(getApplianceType(txtstockcode.Text));
        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            UIControl uic = new UIControl();
            ADTWebService ws = new ADTWebService();
            VisitingReq objvr = new VisitingReq();
            objvr.pOrgcode = ERPSystemData.COM_DOM_ORG_CODE.AEL.ToString();
            objvr.pBrncode = Session["LoggedBranch"].ToString();     
            
           
            if (chkupdate.Checked==false)
            {
            txtvisitingno.Text = ws.gMsGetVisitingRequestNo(objvr);
            if (CreateVisitingRequest() == true)
            {

                ScriptManager.RegisterClientScriptBlock(this, typeof(Page), "Success", "alert('Data Saved')", true);
                
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(Page), "Error", "alert('Not Saved')", true);

            }
            }else
            {
                if (UpdateVisitingRequest() == true)
                {

                    ScriptManager.RegisterClientScriptBlock(this, typeof(Page), "Success", "alert('Data Updated')", true);

                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, typeof(Page), "Error", "alert('Not Updated')", true);

                }

            }
        }


        protected void btnsearch_Click(object sender, EventArgs e)
        {

            ADTWebService ws = new ADTWebService();
            VisitingReq objvr = new VisitingReq();
            objvr.pOrgcode = ERPSystemData.COM_DOM_ORG_CODE.AEL.ToString();
            objvr.pBrncode = Session["LoggedBranch"].ToString();
            objvr.pVisitReqno = txtsearbyno.Text.Trim();
            objvr.pCustomerName = txtsearchbyname.Text.Trim();
            objvr.pVisitReqdate = Convert.ToDateTime(txtfromdate.Text);
            objvr.pVisitReqdateTo = Convert.ToDateTime(txttodate.Text);
            objvr.pVisitReqStatus = "C";
            DataSet ds = null;
            ds = ws.gMsGetVisitngRequestList(objvr);
            dgridvrlist.DataSource = ds;
            dgridvrlist.DataBind();
        }

        protected void dgridvrlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtvisitingno.Text = dgridvrlist.SelectedRow.Cells[1].Text;
            GetVisitingRequestData(txtvisitingno.Text.Trim());
            panelvistitinglist.Visible = false;
            chkupdate.Checked = true;
        }

#endregion Form events

    }
}