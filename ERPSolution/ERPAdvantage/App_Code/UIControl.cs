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
     objDropDownList.Items.Insert(0, new ListItem("---Select---", "-1"));
    
 }

    public void filllMajorGroup(DropDownList dropdownList, string lMajorGroup)
    { 
      DropDownList objDropDownList = new DropDownList();
      objDropDownList = dropdownList;
     switch(lMajorGroup)
     {
         case "S":
         {
            objDropDownList.Items.Insert(0, new ListItem("%","-1"));
            objDropDownList.Items.Insert(1, new ListItem("Accessories", "1"));
            objDropDownList.Items.Insert(2, new ListItem("Complete Unit", "2"));
            //objDropDownList.Items.Insert(0, new ListItem("---Select---", "-1"));
            break; 
         }
         case "I":
         {
            objDropDownList.Items.Insert(0, new ListItem("%", "-1"));
            objDropDownList.Items.Insert(1, new ListItem("Service", "3"));
            objDropDownList.Items.Insert(2, new ListItem("Spares", "4"));
            objDropDownList.Items.Insert(3, new ListItem("Stationery", "5"));
            objDropDownList.Items.Insert(4, new ListItem("Tools", "6"));
           // objDropDownList.Items.Insert(0, new ListItem("---Select---", "-1"));
            break; 
         }
         case "A":
         {
           objDropDownList.Items.Insert(0, new ListItem("%","-1"));
           objDropDownList.Items.Insert(1, new ListItem("Accessories", "1"));
           objDropDownList.Items.Insert(2, new ListItem("Complete Unit", "2"));
           objDropDownList.Items.Insert(3, new ListItem("Service", "3"));
           objDropDownList.Items.Insert(4, new ListItem("Spares", "4"));
           //objDropDownList.Items.Add("Complete Unit");
           break; 
         }
         case "C":
         {
          objDropDownList.Items.Insert(0, new ListItem("%", "-1"));
          objDropDownList.Items.Insert(1, new ListItem("Complete Unit", "2"));
          break;
         }
         case "R":
         {
         objDropDownList.Items.Insert(0, new ListItem("%", "-1"));
         objDropDownList.Items.Insert(1, new ListItem("Accessories", "1"));
         break;
         }
         case "V":
         {
         objDropDownList.Items.Insert(0, new ListItem("%", "-1"));
         objDropDownList.Items.Insert(1, new ListItem("Service", "3"));
         break;
         }
         case "T":
         {
          objDropDownList.Items.Insert(0, new ListItem("%", "-1"));
          objDropDownList.Items.Insert(1, new ListItem("Tools", "6"));
         break;
         }
         case "Y":
         {
         objDropDownList.Items.Insert(0, new ListItem("%", "-1"));
         objDropDownList.Items.Insert(1, new ListItem("Stationery", "5"));
         break;
         }
     
     }
   }
}