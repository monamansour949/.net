using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public class Customer
    {
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        public Customer(string name, int phone)
        {
            this.Name = name.ToString();
            this.PhoneNumber = phone;

        }
        public Customer()
        {

        }
    }
}
