using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
   public class HumanSuppliers : Human
    {
        public string name { get; set; }
        public int phone { get; set; }
        public string company { get; set; }
        public string email { get; set; }
        public string address { get; set; }
       

        public HumanSuppliers ( string subName ,int subPhone, string subCompany, string subAddress)
        {
            name = subName;
            phone = subPhone;
            company = subCompany;
            address = subAddress;

            
        }
        public HumanSuppliers()
        {

        }
    }
}
