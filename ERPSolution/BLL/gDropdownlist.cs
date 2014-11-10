using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Advantage.ERP.BLL
{
    public class gDropdownlist
    {
        //string datavalueField, string dataTextField
        private string _datavalueField;
        private string _dataTextField;

        public gDropdownlist(string DatavalueField, string DataTextField)
        {
            this._datavalueField = DatavalueField;
            this._dataTextField = DataTextField;
        }

        public string COM_DOM_CODE
        {

            get { return _datavalueField; }

            set { _datavalueField = value; }

        }

        public string COM_DOM_DESC
        {

            get { return _dataTextField; }

            set { _dataTextField = value; }

        }
        public string COM_ORG_CD
        {

            get { return _datavalueField; }

            set { _datavalueField = value; }

        }

        public string COM_ORG_NAME
        {

            get { return _dataTextField; }

            set { _dataTextField = value; }

        }


        //public string COM_DOM_CODE { get; set; }
        // public string COM_DOM_DESC { get; set; }


    }
}
