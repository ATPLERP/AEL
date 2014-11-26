using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Web.Security;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using Microsoft.Practices.EnterpriseLibrary.Common;


namespace Advantage.ERP.DAL.Costing
{
    public class CostingDatabaseCalls : ICostingDatabaseCalls
    {
        #region ChargeMaster
        public bool gMsCreateChargeMaster(DAL.DataContract.Costing.ChargeMaster objapp)
        {
            int CharNo; 
            //Geting the Last Charge No from the Charge Master Table and increse and assiging to the DB contract object
            {
                Database db = DatabaseFactory.CreateDatabase();
                string sqlcmd = "SELECT MAX(ChargeNumber) from C_ChargeMaster";
                DbCommand dbcommand = db.GetSqlStringCommand(sqlcmd);
                 CharNo = Convert.ToInt32(db.ExecuteScalar(dbcommand));
                if (CharNo > 0)
                {
                    objapp.pChargeNumber = CharNo+1;
                }
            }

            DAL.DataContract.UserSpecificData logdata = new DataContract.UserSpecificData();
            Database db1 = DatabaseFactory.CreateDatabase();


            string sqlcmd1 = "insert into C_ChargeMaster(ChargeNumber,ChargeHeading,ChargeName,ItemLevelApplicable,CreatedBy,CreateDate) values(@ChargeNumber,@ChargeHeading,@ChargeName,@ItemLevel,@CreatedBy,@CreatedDate)";
            DbCommand dbcommand1 = db1.GetSqlStringCommand(sqlcmd1);

            db1.AddInParameter(dbcommand1, "@ChargeNumber", DbType.String, objapp.pChargeNumber);
            db1.AddInParameter(dbcommand1, "@ChargeHeading", DbType.String, objapp.pChargeHeading);
            db1.AddInParameter(dbcommand1, "@ChargeName", DbType.String, objapp.pChargeName);
            db1.AddInParameter(dbcommand1, "@ItemLevel", DbType.Boolean, objapp.pItemLevel);
            db1.AddInParameter(dbcommand1, "@CreatedBy", DbType.String, objapp.pCreatedBy);
            db1.AddInParameter(dbcommand1, "@CreatedDate", DbType.DateTime, objapp.pCreatedDate);
            //db1.AddInParameter(dbcommand1, "@UpdatedBy", DbType.String, objapp.pUpdatedBy);
            //db1.AddInParameter(dbcommand1, "@UpdatedDate", DbType.DateTime, objapp.pUpdatedDate);
            // db.AddInParameter(dbcommand, "@Createdby", DbType.String, logdata.pUserId);


            int x = db1.ExecuteNonQuery(dbcommand1);
            if (x > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Geting the Last Charge No from the Charge Master Table
        public int GenerateChargeNo(DAL.DataContract.Costing.ChargeMaster objMst)
        {
            Database db = DatabaseFactory.CreateDatabase();
            string sqlcmd = "SELECT MAC(ChargeNumber) from C_ChargeMaster";
            DbCommand dbcommand = db.GetSqlStringCommand(sqlcmd);
            int CharNo = Convert.ToInt32(db.ExecuteScalar(dbcommand));
            if (CharNo > 0)
            {
                return CharNo;
            }
            else
            {
                return CharNo;
            }
        }
        #endregion ChargeMaster
    }

}
