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
    public partial class DomainMaster : System.Web.UI.Page
    {

        private void GetDomainTypes()
        {
            UIControl uic = new UIControl();
            ADTWebService ws = new ADTWebService();
            Domainmst objdomain = new Domainmst();
            objdomain.pDomType = txtsearchbydomname.Text;
            DataSet ds=ws.gMsGetDomainTypes(objdomain);
            GridVdomlist.DataSource = ds;
            GridVdomlist.DataBind();
        }

        private void GetDomainDetails()
        {
            UIControl uic = new UIControl();
            ADTWebService ws = new ADTWebService();
            Domainmst objdomain = new Domainmst();
            objdomain.pOrgCode = ERPSystemData.COM_DOM_ORG_CODE.AEL.ToString(); ;
            objdomain.pDomType = txtdomaintype.Text;
            DataSet ds = ws.gMsGetDomainDetails(objdomain);
            gvaddeddomain.DataSource = ds;
            //ViewState["AddedDomain"] = ds;
            gvaddeddomain.DataBind();
            

        }

        private bool CreateDomain()
        {
            foreach (GridViewRow gr in gvtemp.Rows)
            {
                UIControl uic = new UIControl();
                ADTWebService ws = new ADTWebService();
                Domainmst objdom = new Domainmst();
                objdom.pOrgCode = ERPSystemData.COM_DOM_ORG_CODE.AEL.ToString();
                objdom.pDomCode = gr.Cells[1].Text;
                objdom.pDomType = txtdomaintype.Text;
                objdom.pDomName = gr.Cells[2].Text;
                objdom.pDomPrefix = gr.Cells[3].Text;
                ws.gMsCreateDomain(objdom);
                
            }
            return true;
            
        }

        private void ClearInputs()
        {
            txtdomcode.Text = string.Empty;
            txtdomaindesc.Text = string.Empty;
            txtdomprefix.Text = string.Empty;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btngetdomainlist_Click(object sender, EventArgs e)
        {
            if (Domainlist.Visible == false)
            {
                GetDomainTypes();
                Domainlist.Visible = true;
            }
            else
            {
                Domainlist.Visible = false;
            }
        }

        protected void cmdsearch_Click(object sender, EventArgs e)
        {
            GetDomainTypes();
        }

        protected void GridVdomlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtsearchbydomname.Text = GridVdomlist.SelectedRow.Cells[1].Text;
            txtdomaintype.Text = GridVdomlist.SelectedRow.Cells[1].Text;
            Domainlist.Visible = false;
            GetDomainDetails();
            txtdomaintype.Enabled = false;
        }

        protected void btnadd_Click(object sender, EventArgs e)
        {
            tempdom.Visible = true;
            if (ViewState["AddedDomain"] != null)
            {
                DataTable dtt = (DataTable)(ViewState["AddedDomain"]);
                DataRow drr = dtt.NewRow();
                drr["domcode"] = txtdomcode.Text;
                drr["domdesc"] = txtdomaindesc.Text;
                drr["domprefix"] = txtdomprefix.Text;
                dtt.Rows.Add(drr);
                gvtemp.DataSource = dtt;
                gvtemp.DataBind();
                ViewState["AddedDomain"] = dtt;
                ClearInputs();
            }
            else
            {

                DataTable dt1 = new DataTable();
                dt1.Columns.Add(new DataColumn("domcode", Type.GetType("System.String")));
                dt1.Columns.Add(new DataColumn("domdesc", Type.GetType("System.String")));
                dt1.Columns.Add(new DataColumn("domprefix", Type.GetType("System.String")));

                DataRow dr = dt1.NewRow();
                dr["domcode"] = txtdomcode.Text;
                dr["domdesc"] = txtdomaindesc.Text;
                dr["domprefix"] = txtdomprefix.Text;

                dt1.Rows.Add(dr);
                gvtemp.DataSource = dt1;
                gvtemp.DataBind();
                ViewState["AddedDomain"] = dt1;
                ClearInputs();
            }
        }

        protected void gvaddeddomain_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void cmdsave_Click(object sender, EventArgs e)
        {
            if (CreateDomain() == true)
            {
                lblstatus.Text = Resources.UIMessege.msgSaveOk;
                gvtemp.DataSource = null;
                gvtemp.DataBind();
                GetDomainDetails();
            }
        }

        
     
     
            
        }


    
}