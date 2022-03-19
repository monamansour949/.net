using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public class storageCar
    {
        //public int Id { get; set; }
        public string Name { get; set; }
        public List<CarProducts> products { get; set; }

        public storageCar()
        {
            products = new List<CarProducts>();
        }

        public storageCar(string name)
        {
            
            Name = name;
            products = new List<CarProducts>();
        }

    }
}
