using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public class SellBill // bill class
    {
        public int BillNumber { get; set; }
        public DateTime Date { get; set; }
        public string Customer { get; set; }
        public double TotalPrice { get; set; }
       
        public List<CarProducts> listOfbilldetealis { get; set; }
       

        
        public SellBill( string stock, string customer, int billnum,
            DateTime data, double totalprice)
        {
            this.BillNumber = billnum;
            this.Date = data;
            this.Customer = customer.ToString();
            this.TotalPrice = totalprice;
            

        }

        public SellBill()
        {
            //listOfbilldetealis = new List<BillProducts>();
            listOfbilldetealis = new List<CarProducts>();
        }
    }
    
}
