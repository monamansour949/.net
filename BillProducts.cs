using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public class BillProducts //this class to releation m to m between salebill and  carproduct
    {
       public CarProducts carproduct ;
        
        public BillProducts()
        {
            CarProducts carproduct = new CarProducts();
        }



    }
}
