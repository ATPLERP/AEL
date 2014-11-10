using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Web.UI.WebControls;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Text;
//using System.String;
using Microsoft.VisualBasic;
using Advantage.ERP.DAL.DataContract;
using Advantage.ERP.BLL;
using ERPAdvantage;



/// <summary>
/// Summary description for UIvalidations
/// </summary>
public class UIvalidations:Page
{

    public string GenerateCustomerCode(CustomMaster objMst)
    {
       // ERPAdvantage.ADTWebService wsoj = new ERPAdvantage.ADTWebService();
        ADTWebService wsoj = new ADTWebService();
        string custCode= wsoj.GenerateCustomerCode(objMst);
        if (string.IsNullOrEmpty(custCode))
        {
            custCode = (objMst.pCustName.Substring(0, 1) +  "00001");
        }
        else
        {
         // Left(pCustName, 1) & Strings.Right("00000" & Strings.Right(gRst.Fields("LASTCUSTCODE"), 5) + 1, 5)
         //custCode = (objMst.pCustName.Substring(0, 1) + ("00001" + custCode.Substring(1,6) ) );
         //custCode = (objMst.pCustName.Substring(0, 1) + "00001");
            int custCode1 = int.Parse(custCode.Substring(1, 5));
            custCode1 = custCode1 + 00001;
            custCode= objMst.pCustName.Substring(0, 1) + custCode1;
        }

        return custCode;  
    }

    public void CatNo(CustomMaster objMst)
    {
        // CustomMaster objMst = new CustomMaster();
        //string Cat_No = null;
        //string Cat_Desc = null;
        int x = 0;
       // int y = 0;
        // Cat_No =pSVAT_Cat.Substring(0 , 1);
        // x = pSVAT_Cat.Substring()
        //  Cat_Desc = Strings.Right(pSVAT_Cat, (Strings.Len(pSVAT_Cat) - (x + 1)));

        objMst.pCat_No = objMst.pSVAT_Cat.Substring(0, 1);
       // x = Strings.InStr(1, objMst.pSVAT_Cat, "");
        x = objMst.pSVAT_Cat.IndexOf(' ');
        //x = int.Parse(objMst.pSVAT_Cat.Substring(1, y));
        //objMst.pCat_Desc = Strings.Right(objMst.pSVAT_Cat, (Strings.Len(objMst.pSVAT_Cat) - (x + 1)));

        objMst.pCat_Desc = objMst.pSVAT_Cat.Substring(1, objMst.pSVAT_Cat.Length - (x + 1));
     
        if (objMst.pCat_No == "1")
        {
            objMst.pCat_No = "3";
        }
        else if (objMst.pCat_No == "2")
        {
            objMst.pCat_No = "4";
        }
        else if (objMst.pCat_No == "3")
        {
            objMst.pCat_No = "5";
        }
        else if (objMst.pCat_No == "4")
        {
            objMst.pCat_No = "6";
        }
        else if (objMst.pCat_No == "5")
        {
            objMst.pCat_No = "7";
        }

    }

    public bool CHKSelect(ControlCollection ctrls)
    {
        bool isFound = false;
        foreach (Control ctrl in ctrls)
        {
            if (ctrl is DropDownList)
            {
                if ((((DropDownList)ctrl).Text == "---Select---"))
                {
                    isFound = true;
                }
            }
            else
            {
                if (ctrl.Controls.Count > 0)//recursive loop through all child controls
                {
                    isFound = CHKSelect(ctrl.Controls);
                }
            }
            if (isFound)
            {
                break;
            }

        }
       return isFound;
    }


   public void ClearInputs(ControlCollection ctrls)
    {
        foreach (Control ctrl in ctrls)
        {
            if (ctrl is TextBox)
                ((TextBox)ctrl).Text = string.Empty;
            if (ctrl is DropDownList)
            {
              ((DropDownList)ctrl).ClearSelection();
             // ((DropDownList)ctrl).SelectedIndex = -1;
             //string myValue= ((DropDownList)ctrl).Items[((DropDownList)ctrl).Items.Count - 1].Value;
              //((DropDownList)ctrl).SelectedValue = "---Select---";
              //((DropDownList)ctrl).SelectedItem.Text = "---Select---";
               // ((DropDownList)ctrl).Items.Insert(0, new ListItem("---Select---", "-1"));
             //((DropDownList)ctrl).Text = "---Select---";
                         
            }
             if (ctrl is CheckBox)
            {
                CheckBox checkBox = (CheckBox)ctrl;
                checkBox.Checked = false;
            }
             if (ctrl is ListBox)
             {
                 ListBox listBox = (ListBox)ctrl;
                 listBox.ClearSelection();
             }
             if (ctrl is HtmlTextArea)
                 ((HtmlTextArea)ctrl).Value = string.Empty;

             if (ctrl is GridView)
             {
                 
                 ctrl.DataBind();
             }
                                   
            ClearInputs(ctrl.Controls);
        }
    }

    public void DisableControls(Control parent, bool State)
    {
        foreach (Control c in parent.Controls)
        {
            if (c is DropDownList)
            {
                ((DropDownList)(c)).Enabled = State;
            }
            if (c is CheckBox)
            {
                ((CheckBox)(c)).Enabled = State;
            }

            if (c is TextBox )
            {
                ((TextBox)(c)).Enabled = State;
            }
            if (c is HtmlTextArea)
            {
                if (State == true)
                {
                    ((HtmlTextArea)(c)).Disabled = false;
                }
                else
                {
                    ((HtmlTextArea)(c)).Disabled = true;
                }
            }

            if (c is ListBox)
            {
                ((ListBox)(c)).Enabled = State;
            }
             //DisableControls(c, State);
             //if (c is RequiredFieldValidator)
             //{
             //    ((RequiredFieldValidator)(c)).Enabled = State;
             //}
             DisableControls(c, State);
        }
    }

    public bool IsnotEmailAddress(string textValue)
    {
        if (!(Regex.IsMatch(textValue, "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*")))
        {
            // lblIsname.Text = "Please insert a valied " & obj
            //TextBox.Focus()
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool Isnotname(string textValue)
    {
        //If Not (Regex.IsMatch(textValue, "^[azAZ'.]{1,40}$")) Then

        if (!(Regex.IsMatch(textValue, "[a-zA-Z. ]+")))
        {
            // lblIsname.Text = "Please insert a valied " & obj
            //TextBox.Focus()
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool IsvaliedPhoneno(string textValue)
    {
        //If Not (Regex.IsMatch(textValue, "^[azAZ'.]{1,40}$")) Then

        if (!(Regex.IsMatch(textValue, "(\\(\\d{3}\\)|\\d{3}-)?\\d{8}")))
        {
            // lblIsname.Text = "Please insert a valied " & obj
            //TextBox.Focus()
           return true;
     
        }
        else
        {
            return false;
        }
    }
        
    public string GetMD5(string text)
    {
        MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
        md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
        byte[] result = md5.Hash;
        StringBuilder str = new StringBuilder();
        for (int i = 1; i < result.Length; i++)
        {
          str.Append(result[i].ToString("x2"));
        }
        return str.ToString(); 
    }
    
    public bool CheckModuleAccess(Advantage.ERP.DAL.DataContract.UserSpecificData objumst)
    {
        bool success = false;
        string sTempModuleType=null;
        // When retrieving an object from session state, cast it to 
        // the appropriate type.
        TSEC_USR_OBJData objTs = new TSEC_USR_OBJData();
        List<TSEC_USR_OBJ> userMlist = (List<TSEC_USR_OBJ>)Session["UserPerModules"];
        UserSpecificData useObj = (UserSpecificData)Session["UserobjuMst"];
       // list = (List<TSEC_USR_OBJ>)Session["UserPerModules"];
        for (int i = 0; i < userMlist.Count; i++)
        {
            objTs.pSUSR_MOD_ID = userMlist[i].SUSR_MOD_ID;
            objTs.pSUSR_OBJ_ID = userMlist[i].SUSR_OBJ_ID;
            objTs.pSUSR_ORG_CD = userMlist[i].SUSR_ORG_CD;
            objTs.pSUSR_USR_ID = userMlist[i].SUSR_USR_ID;
            if (Convert.ToString(objTs.pSUSR_MOD_ID) == objumst.pModType)
            {
                switch (Convert.ToString(userMlist[i].SUSR_MOD_ID))
                {
                    case ServiceMain.ModuleId:
                     if (objTs.pSUSR_OBJ_ID == objumst.pObjId)
                     success = true;
                     sTempModuleType = ERPSystemData.gModuleName.SERVICE.ToString();
                     break;
                    case FinanceMain.ModuleId:
                     if (objTs.pSUSR_OBJ_ID == objumst.pObjId)
                     success = true;
                     sTempModuleType = ERPSystemData.gModuleName.ACCOUNTS.ToString();
                     break;
                    case InventryMain.ModuleId:
                     if (objTs.pSUSR_OBJ_ID == objumst.pObjId)
                     success = true;
                     sTempModuleType = ERPSystemData.gModuleName.STORE.ToString();
                     break;
                    case CostingMain.ModuleId:
                     if (objTs.pSUSR_OBJ_ID == objumst.pObjId)
                     success = true;
                     sTempModuleType = ERPSystemData.gModuleName.COSTING.ToString();
                     break;
                }
            }
           // break;
            if (success) // check if inner loop set break
            {
                objumst.pModType = sTempModuleType;
                objumst.pUserId = useObj.pUserId;
                objumst.pBrnCode = useObj.pBrnCode;
                objumst.pObjId = objTs.pSUSR_OBJ_ID;
                break; // break outer loop
            }

        }
       return success;
       }
    }
    