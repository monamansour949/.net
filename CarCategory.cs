using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public class CarCategory
    {
        
            //public int Id { get; set; }
            public string Name { get; set; }
        public List<CarProducts> Products = new List<CarProducts>();
           
            public CarCategory()
            {
                 Name = "bmw"; 
            }
        public CarCategory(string Name)
        {
           
            this.Name = Name;

        }
        
        
        public bool checkIfProductExist(string productBrand)
        {
            foreach (CarProducts  product  in Products)
            {
                if (product.Brand == productBrand)
                {
                    return true;
                }
            }
            return false;
        }

    }
    
}
