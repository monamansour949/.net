using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public class CarProducts
    {
      
        public string Brand { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }
        public int Modle { get; set; }
        public int Amount { get; set; }
     
        public string CarCateegory { get; set; }
        public string stockprod{ get; set; }
      
        public CarProducts( string brand, double price, int modle, int mount,string color, string _CarCateegory, string _stockprod)
        {
            
            Brand = brand;
            Price = price;
            Modle = modle;
            Color = color;
            CarCateegory = _CarCateegory.ToString();
            stockprod = _stockprod.ToString();


        }

        //public CarProducts( string brand, double price, int modle, int mount, string color, string _CarCateegory, string _stockprod)
        //{
          
        //    Brand = brand;
        //    Price = price;
        //    Modle = modle;
        //    Color = color;
        //    CarCateegory = _CarCateegory.ToString();
        //    stockprod = _stockprod.ToString();


        //}
        public CarProducts()
        {

            CarCategory cateegory = new CarCategory();
        }

    }
}
