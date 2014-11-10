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

        private void ClearFormdata()
        {
            UIvalidations uic = new UIvalidations();
            uic.ClearInputs(this.Controls);                        
            addeddom.Visible = false;
            txtdomaintype.Enabled = true;
        }

        private void GetDomainDetails()
        {
            UIControl uic = new UIControl();
            ADTWebService ws = new ADTWebService();
            Domainmst objdomain = new Domainmst();
            objdomain.pOrgCode = ERPSystemData.COM_DOM_ORG_CODE.AEL.ToString(); ;
            objdomain.pDomType = txtdomaintype.Text;
            DataSet ds = ws.gMsGetDomainDetails(objdomain);
            if (ds !=null)
            {
                addeddom.Visible = true;
            }
            else
            {
                addeddom.Visible = false;
            }
            gvaddeddomain.DataSource = ds;            
            gvaddeddomain.DataBind();
            

        }

        private void SearchDomain()
        {
            UIControl uic = new UIControl();
            ADTWebService ws = new ADTWebService();
            Domainmst objdom = new Domainmst();
            objdom.pOrgCode = ERPSystemData.COM_DOM_ORG_CODE.AEL.ToString();
            objdom.pDomType = txtdomaintype.Text;
            objdom.pDomCode = txtsearchcode.Text;
            objdom.pDomName = txtsearchname.Text;
            DataSet ds = null;
            ds=(DataSet) ws.gMsSearchDomain(objdom);
            gvaddeddomain.DataSource = ds;
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

        private bool DeleteDomain(string domtype,string domcode)
        {
            UIControl uic = new UIControl();
            ADTWebService ws = new ADTWebService();
            Domainmst objdom=new Domainmst();
            ServiceBusinessCalls obj = new ServiceBusinessCalls();
            objdom.pOrgCode = ERPSystemData.COM_DOM_ORG_CODE.AEL.ToString();
            objdom.pDomType = domtype;
            objdom.pDomCode = domcode;
            obj.gMsDeleteDomain(objdom);
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
            
            DeleteDomain(gvaddeddomain.Rows[e.RowIndex].Cells[2].Text, gvaddeddomain.Rows[e.RowIndex].Cells[3].Text.Replace("&nbsp;", ""));
            GetDomainDetails();
            lblstatus.Text = Resources.UIMessege.msgDeleteOk;
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

        protected void cmdsearchdomain_Click(object sender, EventArgs e)
        {
            SearchDomain();
        }

        protected void btnaddnewdomaintype_Click(object sender, EventArgs e)
        {
            UIControl uic = new UIControl();
            ADTWebService ws = new ADTWebService();
            Domainmst objdom = new Domainmst();
            ServiceBusinessCalls obj = new ServiceBusinessCalls();
            objdom.pDomType = txtdomaintype.Text;

            if (obj.gMsAddDomainType(objdom) > 0) 
            {
                lblstatus.Text = Resources.UIMessege.msgSaveOk;
                lblstatus.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblstatus.Text = Resources.UIMessege.msgDuplicateEntry;
                lblstatus.ForeColor = System.Drawing.Color.Red;
                txtdomaintype.Text = string.Empty;
            }

        }

        protected void cmdreset_Click(object sender, EventArgs e)
        {
            ClearFormdata();
        }

        protected void gvtemp_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            
        }

      

        
     
     
            
        }


    
}