using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class estekhdam
    {
        private int _sid;
        private string _esm;
        private string _famili;
        private int _phone;
        private int _mizanhogug;
        private string _bakhshfaaliat;
        private string _sabege;
        private string _address;
        public estekhdam(int _sid, string _esm, string _famili, int _phone, string _sabege,int _mizanhogug,string _bakhshfaaliat,string _address)
        {
            this._sid = _sid;
            this._esm = _esm;
            this._famili = _famili;
            this._phone = _phone;
            this._sabege = _sabege;
            this._mizanhogug = _mizanhogug;
            this._bakhshfaaliat = _bakhshfaaliat;
            this._address = _address;
           
        }
        public bool Register(List<sandugdar>ls)
        {
            bool isreg = true;
            // .....code
            return isreg;
        }
        public bool Register(List<ashpaz> ls)
        {
            bool isreg = true;
            // .....code
            return isreg;
        }
        public bool Register(List<anbardar> ls)
        {
            bool isreg = true;
            //...code
            return isreg;
      
        }
        public bool Register(List<garson> ls)
         {
            bool isreg = true;
            //...code
            return isreg;
        }
        public bool Register(List<modir> ls)
        {
            bool isreg = true;
            //...code
            return isreg;
        }
        public bool Register(List<zarfshur> ls)
        {
            bool isreg = true;
            //...code
            return isreg;
        }
        public bool Register(List<nezafatchi> ls)
        {
            bool isreg = true;
            //...code
            return isreg;
        }
    }
}
