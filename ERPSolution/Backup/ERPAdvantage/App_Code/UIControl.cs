using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data ;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using Advantage.ERP.BLL;
using System.Web.UI; 

/// <summary>
/// Summary description for UIControl
/// </summary>
public class UIControl
{
	public UIControl()
	{
		//
		// TODO: Add constructor logic here
		//
	}


// public void FillDropdownList(DropDownList dropdownList,DataTable  dataTable, string datavalueField, string dataTextField)
//{
//    DropDownList objDropDownList = new DropDownList();
//    objDropDownList = dropdownList;
	
//    objDropDownList.DataValueField = datavalueField;
//    objDropDownList.DataTextField = dataTextField;
//    objDropDownList.CssClass ="select";
//    objDropDownList.DataSource = dataTable;
//    objDropDownList.DataBind();
//}

    public void FillDropdownList(DropDownList dropdownList, List<gDropdownlist> list, string datavalueField, string dataTextField)
 {
    // int iCount = 0;

     DropDownList objDropDownList = new DropDownList();
     objDropDownList = dropdownList;

     objDropDownList.DataValueField = datavalueField;
     objDropDownList.DataTextField = dataTextField;
     objDropDownList.CssClass = "select";
     objDropDownList.DataSource = list;
     objDropDownList.DataBind();

     //iCount = objDropDownList.Items.Count;
     //objDropDownList.Items.Add("---Select---");
     //objDropDownList.SelectedIndex = iCount;
    objDropDownList.Items.Insert(0, new ListItem("---Select---", "-1"));
   // objDropDownList.Items.Insert(0, new ListItem(" ", " -1"));

   //  objDropDownList.Text = "--Select--";
   // objDropDownList.SelectedItem.Text = "--Select--";
  
 }
}