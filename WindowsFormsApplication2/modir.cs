using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class modir
    {     private int _sid;
        private string _esm;
        private string _famili;
        private int _phone;
    
        private string _sabege;
        public modir(int _sid, string _esm, string _famili, int _phone, string _sabege)
        {
            this._sid = _sid;
            this._esm = _esm;
            this._famili = _famili;
            this._phone = _phone;
            this._sabege = _sabege;
        }
        public bool Register(List<estekhdam>ls)
        {
            bool isreg = true;
            //...code
            return isreg;
        }

    }
}
