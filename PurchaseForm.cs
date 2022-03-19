using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garage
{
    public partial class PurchaseForm : Form
    {
        public event Action<purchaseInvioce> AddPurchaseInvioce;
      

        private List<purchaseInvioce> purchaseslist;
        private List<HumanSuppliers> suppliersList;
        private List<CarCategory> categories;
        private List<storageCar> stockes;
        private List<CarProducts> carproductList;

        public PurchaseForm(List<purchaseInvioce> purchaseslist, List<HumanSuppliers> suppliersList, List<CarCategory> categories, List<storageCar> stockes, List<CarProducts> carproductList)
        {
            InitializeComponent();
            this.purchaseslist = purchaseslist;
            this.suppliersList = suppliersList;
            this.categories = categories;
            this.stockes = stockes;
            this.carproductList = carproductList;

            if (categories.Count > 0)
            {
                foreach (CarCategory item in categories)
                {
                    CategoryName_ComboBox2.Items.Add(item.Name);
                }
            }
            if (carproductList.Count > 0)
            {
                foreach (CarProducts item in carproductList)
                {
                    
                    CarProduct_purchase_ComboBox1.Items.Add(item.Brand);
                }
            }

            if (stockes.Count > 0)
            {
                foreach (storageCar item in stockes)
                {
                    StockName_ComboBox3.Items.Add(item.Name);
                }
            }

            if (suppliersList.Count > 0)
            {
                foreach (HumanSuppliers item in suppliersList)
                {
                    supplierName_ComboBox1.Items.Add(item.name);
                }
            }

            
            if (purchaseslist.Count > 0)
            {
                purchaseInvoice_dataGridView1.DataSource = null;
                purchaseInvoice_dataGridView1.DataSource = purchaseslist;

            }

        }

       

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

     

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void purchaseInvoice_dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void add_purchase_Button1_Click(object sender, EventArgs e)
        {
            purchaseInvioce pur = new purchaseInvioce();

            if (supplierName_ComboBox1.SelectedIndex != -1 && CategoryName_ComboBox2.SelectedIndex != -1 && StockName_ComboBox3.SelectedIndex != -1 &&
                  Amount_Purches_TextBox1.Text.Length > 0 && PricePurchase_TextBox3.Text.Length > 0)

            {
                pur.Amount = int.Parse(Amount_Purches_TextBox1.Text);
                pur.Pirce = double.Parse(PricePurchase_TextBox3.Text);
                pur.CarCateegoryPurchase = CategoryName_ComboBox2.SelectedItem.ToString();
                pur.stockprodPurchaase = StockName_ComboBox3.SelectedItem.ToString();
                pur.supplierPurchase = supplierName_ComboBox1.SelectedItem.ToString();
                pur.CarProductPurchases = CarProduct_purchase_ComboBox1.SelectedItem.ToString();
                if (AddPurchaseInvioce != null)
                {
                    AddPurchaseInvioce(pur);

                    purchaseInvoice_dataGridView1.DataSource = null;
                    purchaseInvoice_dataGridView1.DataSource = purchaseslist;
                }

            }
        }

        private void Remove_Button1_Click(object sender, EventArgs e)
        {
            purchaseslist.RemoveAt(purchaseInvoice_dataGridView1.SelectedRows[0].Index);
            purchaseInvoice_dataGridView1.DataSource = null;
            purchaseInvoice_dataGridView1.DataSource = purchaseslist;
        }

        private void Print_Button1_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string AmountNumber = "The amount :  " + Amount_Purches_TextBox1.Text;
            string nameOfCtegory = "Category Name :  " + CategoryName_ComboBox2.SelectedItem.ToString();
            string supplierName = "Supplier Name : " + supplierName_ComboBox1.SelectedItem.ToString();
            string stockName = "Stock Name : " + StockName_ComboBox3.SelectedItem.ToString();
            string carName = "Car Name :" + CarProduct_purchase_ComboBox1.SelectedItem.ToString();
            string price = " Price :" + PricePurchase_TextBox3.Text;
            string date = "Date : " + Purchase_DateTimePicker1.Text;

            e.Graphics.DrawImage(Properties.Resources.TheLogo, 5, 5, 100, 100);

            e.Graphics.DrawString(supplierName, new Font("Elephant", 18, FontStyle.Bold), Brushes.Crimson, 200, 100);
            e.Graphics.DrawString(AmountNumber, new Font("Elephant", 18, FontStyle.Bold), Brushes.Crimson, 200, 150);
            e.Graphics.DrawString(nameOfCtegory, new Font("Elephant", 18, FontStyle.Bold), Brushes.Crimson, 200, 200);
            e.Graphics.DrawString(stockName, new Font("Elephant", 18, FontStyle.Bold), Brushes.Crimson, 200, 250);
            e.Graphics.DrawString(carName, new Font("Elephant", 18, FontStyle.Bold), Brushes.Crimson, 200, 300);
            e.Graphics.DrawString(date, new Font("Elephant", 18, FontStyle.Bold), Brushes.Crimson, 200, 350);
        }

        private void Save_purchase_btn_Click(object sender, EventArgs e)
        {
            if (Stock_dataGridView1.CurrentRow != null)
            {

                if (Convert.ToInt32(Amount_Purches_TextBox1.Text) <= Convert.ToInt32(Stock_dataGridView1.CurrentRow.Cells["Amount"].Value.ToString()))
                {
                    try
                    {
                        Stock_dataGridView1.CurrentRow.Cells["Amount"].Value =
                        (Convert.ToInt32(Stock_dataGridView1.CurrentRow.Cells["Amount"].Value.ToString())) +
                        (Convert.ToInt32(Amount_Purches_TextBox1.Text));
                    }

                    catch
                    {
                        MessageBox.Show("This amount not exist");
                    }
                }
            }
        }

        private void Total_Purchases_GradientButton1_Click(object sender, EventArgs e)
        {

            totat_price.Text = (float.Parse(Amount_Purches_TextBox1.Text) *
            float.Parse(PricePurchase_TextBox3.Text)).ToString();

        }

        private void Stock_dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CategoryName_ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CategoryName_ComboBox2.SelectedIndex > -1)
            {
                Stock_dataGridView1.DataSource = null;
                if (categories[CategoryName_ComboBox2.SelectedIndex].Products.Count > 0)
                {

                    Stock_dataGridView1.DataSource = categories[CategoryName_ComboBox2.SelectedIndex].Products;
                }
                else
                {
                    MessageBox.Show("No products");
                }
            }
        }
    }
}
