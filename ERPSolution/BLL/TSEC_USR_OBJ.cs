using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Advantage.ERP.BLL
{
  public  class TSEC_USR_OBJ
    {
      private string _SUSR_ORG_CD;
      private string _SUSR_USR_ID;
      private int _SUSR_MOD_ID;
      private int _SUSR_OBJ_ID;
      
      public TSEC_USR_OBJ(string SUSR_ORG_CD,string SUSR_USR_ID,int SUSR_MOD_ID, int SUSR_OBJ_ID)
      {
          this._SUSR_ORG_CD = SUSR_ORG_CD;
          this._SUSR_USR_ID = SUSR_USR_ID;
          this._SUSR_MOD_ID = SUSR_MOD_ID;
          this._SUSR_OBJ_ID = SUSR_OBJ_ID;
      }
      public string SUSR_ORG_CD
      {
          get { return _SUSR_ORG_CD; }
          set { _SUSR_ORG_CD = value; }
     }
      public string SUSR_USR_ID
      {
          get { return _SUSR_USR_ID; }
          set { _SUSR_USR_ID = value; }
      }

      public int SUSR_MOD_ID
      {
          get { return _SUSR_MOD_ID; }
          set { _SUSR_MOD_ID = value; }
      }

      public int SUSR_OBJ_ID
      {
          get { return _SUSR_OBJ_ID; }
          set { _SUSR_OBJ_ID = value; }
      }

    }
}
