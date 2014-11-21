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
        PREFIX,
        APPLIANCE_CATEGORY,
        QUOTATION_CATEGORY,
        JOB_CATEGORY,
        PRIORITY
    }

    public enum COM_DOM_ORG_CODE
    {
        AEL
    }
    public enum gModuleName
    {
        SERVICE,
        COSTING,
        STORE,
        ACCOUNTS
   }
    public enum Status
    {
        New,
        Save,
        View,
        Update,
        Delete
    }

    public enum lMajorGroup
    {
        S,// Service
        I,//Inventory
        A,//ALL TYPE
        C,//ONLY COMPLETE UNIT
        R,//Accessories
        V,//SERVICE
        T,//Tools
        Y//Stationery
    }
    public enum GroupType
    {
        General
    }
    public enum PriceType
    {
        S,
        W
    }
    public enum MajorGroupTypes
    {
        Service,
        Inventory,
        Tools,
        Stationery,
        Accessories
     }
    public enum pDocType
    {
      QuotationNO
    }
}