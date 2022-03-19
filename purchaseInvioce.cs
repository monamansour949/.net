using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public  class purchaseInvioce
    {

        public double Pirce { get; set; }
        public int Amount { get; set; }
        public string CarCateegoryPurchase { get; set; }
        public string stockprodPurchaase { get; set; }
        public string supplierPurchase   { get; set; }

        public string CarProductPurchases { get; set; }
        public purchaseInvioce(double pircePur, int amountPur, CarCategory CarCateegoryPur, storageCar stockprodPur, HumanSuppliers supplierPur ,CarProducts carProductPur)
        {

            Pirce=pircePur;
            Amount=amountPur;
            CarCateegoryPurchase = CarCateegoryPur.ToString();
            stockprodPurchaase=stockprodPur.ToString();
            supplierPurchase=supplierPur.ToString();
            CarProductPurchases = carProductPur.ToString();


     }

        public purchaseInvioce()
        {

            CarCategory cateegoryPur = new CarCategory();
            HumanSuppliers humanSuppliersPur = new HumanSuppliers();
            storageCar storageCarPur = new storageCar();
            CarProducts carProductsPurchases = new CarProducts();

        }



    }
}
