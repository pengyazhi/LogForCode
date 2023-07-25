using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projLogforCodes;


namespace projLogforCodes.Models
{
    public class CCustomerFactory
    {
        public string show(CCustomer x, ref string result)
        {
            string s;
            s = x.name + "/" + x.email + "/" + x.phone;
            result = s;
            return result;
        }
    }
}
