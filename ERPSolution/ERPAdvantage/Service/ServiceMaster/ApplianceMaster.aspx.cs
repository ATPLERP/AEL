using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Advantage.ERP.BLL;
using Advantage.ERP.DAL.DataContract;
using System.Data;
using System.Data.SqlClient;



namespace ERPAdvantage.Service.ServiceMaster
{
    public partial class ApplianceMaster : System.Web.UI.Page
    {
     
        

        private void GetAppliancecategory()
        {
            UIControl uic = new UIControl();
            ADTWebService wser = new ADTWebService();
            Appliancemst objapp = new Appliancemst();
            objapp.pOrgCode = ERPSystemData.COM_DOM_ORG_CODE.AEL.ToString();
            objapp.pAppCategory = ERPSystemData.COM_DOM_TYPE.APPLIANCE_CATEGORY.ToString();
            List<gDropdownlist> droplist = wser.pMsGetAppliancecategory(objapp);
            uic.FillDropdownList(ddlappcategory, droplist, "COM_DOM_CODE", "COM_DOM_DESC");
        
        }

        private void GetAppliance()
        {
            UIControl ui = new UIControl();
            ADTWebService wser = new ADTWebService();
            Appliancemst app = new Appliancemst();
            app.pOrgCode = ERPSystemData.COM_DOM_ORG_CODE.AEL.ToString();
            app.pApplianceCode = txtsearchbyappcode.Text;
            app.pApplianceName = txtsearchbyappname.Text;
            DataSet ds = wser.GetApplianceList(app);
            GridVapplist.DataSource = ds;
            GridVapplist.DataBind();
        }


        private void GetApplianceDetails()
        {
            UIControl uic = new UIControl();
            ADTWebService ws = new ADTWebService();
            Appliancemst objapp = new Appliancemst();
            objapp.pOrgCode = ERPSystemData.COM_DOM_ORG_CODE.AEL.ToString();
            objapp.pApplianceCode = txtappliancecode.Text.ToString();
            IDataReader  mydata = ws.GetApplianceDatabyAppCode(objapp);
            while (mydata.Read())
            {
                txtappliancedesc.Text = mydata[1].ToString();
                txtstoragecost.Text = mydata[2].ToString();
                txtestimationcost.Text = mydata[3].ToString();
                ddlappcategory.SelectedValue = mydata[4].ToString();
            }
            txtappliancecode.Enabled = false;
            Session["formmode"] = ERPSystemData.Status.Update.ToString();
        }

        private bool CreateAppliance()
        {
            UIControl uic = new UIControl();
            ADTWebService wser = new ADTWebService();
            Appliancemst objapp = new Appliancemst();
            objapp.pOrgCode = ERPSystemData.COM_DOM_ORG_CODE.AEL.ToString();
            objapp.pApplianceCode = txtappliancecode.Text.ToString();
            objapp.pApplianceName = txtappliancedesc.Text.ToString();
            objapp.pStorageCost = Convert.ToDouble(txtstoragecost.Text.Trim());
            objapp.pEstimateCost =Convert.ToDouble(txtestimationcost.Text.Trim());
            objapp.pAppCategory = ddlappcategory.SelectedItem.Text;
            wser.CreateAppliance(objapp);
            return true;
        }

        private bool UpdateAppliance()
        {
            UIControl uic = new UIControl();
            ADTWebService wser = new ADTWebService();
            Appliancemst objapp = new Appliancemst();
            objapp.pOrgCode = ERPSystemData.COM_DOM_ORG_CODE.AEL.ToString();
            objapp.pApplianceCode = txtappliancecode.Text;
            objapp.pApplianceName = txtappliancedesc.Text;
            objapp.pStorageCost =Convert.ToDouble(txtstoragecost.Text);
            objapp.pEstimateCost = Convert.ToDouble(txtestimationcost.Text);
            objapp.pAppCategory = ddlappcategory.SelectedItem.Text;
            wser.UpdateAppliance(objapp);
            return true;
        }



        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                GetAppliancecategory();
                GetAppliance();                
                Session["formmode"] = ERPSystemData.Status.New.ToString();
            }
        }

        protected void cmdgetlist_Click(object sender, EventArgs e)
        {
            if (Applist.Visible == false)
            {
                Applist.Visible = true;
            }
            else
            {
                Applist.Visible = false;
            }
            
        }

        protected void cmdselectapp_Click(object sender, EventArgs e)
        {
            
           
        }

        protected void txtappliancecode_TextChanged(object sender, EventArgs e)
        {
            GetApplianceDetails();
        }

      

        protected void cmdsave_Click(object sender, EventArgs e)
        {
            if (ddlappcategory.SelectedIndex == 0)
            {
                lblstatus.Text = "Invalid Appliance category";
                lblstatus.ForeColor = System.Drawing.Color.Red;
                return;
            }

            if (Session["formmode"].ToString() == ERPSystemData.Status.New.ToString())
          {

                if (CreateAppliance() == true)
                {
                    lblstatus.Text = Resources.UIMessege.msgSaveOk;
                }
                else
                {
                    lblstatus.Text = Resources.UIMessege.msgSaveError;
                }
        }
            else if (Session["formmode"].ToString() == ERPSystemData.Status.Update.ToString())
        {
            if(UpdateAppliance()== true)
            {
                lblstatus.Text = Resources.UIMessege.msgUpdateOk;
            }
            else
            {
                lblstatus.Text = Resources.UIMessege.msgupdateerror;
            }
        }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }

        protected void txtsearchbyappcode_TextChanged(object sender, EventArgs e)
        {

        }

        protected void cmdsearch_Click(object sender, EventArgs e)
        {
            GetAppliance();
        }

        protected void GridVapplist_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtappliancecode.Text = GridVapplist.SelectedRow.Cells[1].Text;            
            GetApplianceDetails();
            Applist.Visible = false;
            Session["formmode"] = ERPSystemData.Status.Update.ToString();
        }

        protected void cmdresetform_Click(object sender, EventArgs e)
        {
            UIvalidations uic = new UIvalidations();
            uic.ClearInputs(Page.Controls);
            lblstatus.Text = string.Empty;
            txtappliancecode.Enabled = true;
            txtsearchbyappcode.Text = "%";
            txtsearchbyappname.Text = "%";
            Session["formmode"] = ERPSystemData.Status.New.ToString();
        }

        

     
    }
}