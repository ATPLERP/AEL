using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ERPSystemData
/// </summary>
public class ERPSystemData
{
    //public ERPSystemData()
    //{
    //    //
    //    // TODO: Add constructor logic here
    //    //
    //}
    
    public enum COM_DOM_TYPE
    {
        CUSTOMER_CATEGORY,
        AREA,
        PREFIX
    }

    public enum COM_DOM_ORG_CODE
    {
        AEL
    }
    public enum gModuleName
    {
        Service,
        Finance,
        Inventory,
        Costing

    }
    public enum Status
    {
        New,
        Save,
        View,
        Update,
        Delete
    }
}