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
    public partial class SalesBillForm : Form
    {
        
        public event Action<SellBill> sellAdd; //event for add bill

        private IReadOnlyList<Customer> Customerlist;
        private IReadOnlyList<storageCar> stockes = new List<storageCar>();
        public List<CarProducts> listOfbilldetealis;
        public CarProducts cars;
        public SalesBillForm(IReadOnlyList<Customer> Customers, IReadOnlyList<storageCar> sstock , List<CarProducts> _listOfbilldetealis)
        {

            InitializeComponent();
            listOfbilldetealis = _listOfbilldetealis;
            Customerlist = Customers;
            stockes = sstock;
            if (Customers.Count > 0)
            {
                foreach (Customer item in Customers)
                {
                    CustomerName_ComboBox1.Items.Add(item.Name);
                }
            }
            if (stockes.Count > 0)
            {
                foreach (storageCar item in stockes)
                {
                    StockName_ComboBox3.Items.Add(item.Name);
                }
            }
        }

        private void StockName_ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StockName_ComboBox3.SelectedIndex > -1)
            {
                stokk_dataGridView1.DataSource = null;
                if (stockes[StockName_ComboBox3.SelectedIndex].products.Count > 0)
                {

                    stokk_dataGridView1.DataSource = stockes[StockName_ComboBox3.SelectedIndex].products;
                }
                else
                {
                    MessageBox.Show("No products");
                }
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void stokk_dataGridView1_SelectionChanged(object sender, EventArgs e)
        {


        }

        private void billGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void stokk_dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //billGridView.DataSource = null;
            //billGridView.DataSource = stokk_dataGridView1.Columns[2].Visible = true;


        }
        
        private void AddButton1_Click(object sender, EventArgs e)
        {
            if (CategoryTextBox1.Text.Length > 0 && BrandTextBox1.Text.Length > 0 && ModelTextBox1.Text.Length > 0 &&
                PriceTextBox1.TextLength > 0 &&Amount_Sales_TextBox1.Text.Length > 0 && ColorTextBox1.Text.Length > 0&&
                Convert.ToInt32(Amount_Sales_TextBox1.Text) < Convert.ToInt32(stokk_dataGridView1.CurrentRow.Cells["Amount"].Value.ToString()) && Convert.ToInt32(stokk_dataGridView1.CurrentRow.Cells["Modle"].Value.ToString()) == Convert.ToInt32(ModelTextBox1.Text) 
                && stokk_dataGridView1.CurrentRow.Cells["Brand"].Value.ToString() == BrandTextBox1.Text
            && Convert.ToDouble(stokk_dataGridView1.CurrentRow.Cells["Price"].Value.ToString()) == Convert.ToDouble(PriceTextBox1.Text)
             && stokk_dataGridView1.CurrentRow.Cells["Color"].Value.ToString() == ColorTextBox1.Text && stokk_dataGridView1.CurrentRow.Cells["CarCateegory"].Value.ToString() ==
             CategoryTextBox1.Text)
            {
                
                    string category = CategoryTextBox1.Text;
                    string brand = BrandTextBox1.Text;
                    int model = int.Parse(ModelTextBox1.Text);
                    int price = int.Parse(PriceTextBox1.Text);
                    int amount = int.Parse(Amount_Sales_TextBox1.Text);
                    string color = ColorTextBox1.Text;
                    object[] data = { category, brand, model, price, amount, color };
                BilldataGridView1.Rows.Add(data);
                
                }
            
            else
            {
                MessageBox.Show("Please compelet data or The amount not exist or data is wrong");

            }
            
            }
            

        private void stokk_dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        // to show the values of selected row in the gridview in text boxes (this code to achieve edit process) 
        private void billGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (BilldataGridView1.CurrentRow != null)
            {
                CategoryTextBox1.Text = BilldataGridView1.CurrentRow.Cells[0].Value.ToString();
                BrandTextBox1.Text = BilldataGridView1.CurrentRow.Cells[1].Value.ToString();
                ModelTextBox1.Text = BilldataGridView1.CurrentRow.Cells[2].Value.ToString();
                PriceTextBox1.Text = BilldataGridView1.CurrentRow.Cells[3].Value.ToString();
                Amount_Sales_TextBox1.Text = BilldataGridView1.CurrentRow.Cells[4].Value.ToString();
                ColorTextBox1.Text = BilldataGridView1.CurrentRow.Cells[5].Value.ToString();
            }
        }

        private void EditButton2_Click(object sender, EventArgs e)
        {
            if (BilldataGridView1.CurrentRow != null)
            {
                BilldataGridView1.CurrentRow.Cells[0].Value = CategoryTextBox1.Text;
                BilldataGridView1.CurrentRow.Cells[1].Value = BrandTextBox1.Text;
                BilldataGridView1.CurrentRow.Cells[2].Value = ModelTextBox1.Text;
                BilldataGridView1.CurrentRow.Cells[3].Value = PriceTextBox1.Text;
                BilldataGridView1.CurrentRow.Cells[4].Value = Amount_Sales_TextBox1.Text;
                BilldataGridView1.CurrentRow.Cells[5].Value = ColorTextBox1.Text;
            }
        }

        private void DeleteButton3_Click(object sender, EventArgs e)
        {
            if (BilldataGridView1.CurrentRow != null && BilldataGridView1.Rows.Count > 0)
            
                try
                {
                    BilldataGridView1.Rows.RemoveAt(BilldataGridView1.CurrentRow.Index);
                }
            
            catch
            {
                return;
            }
            
        }

        //button to save the bill
        public List<SellBill> selbil = new List<SellBill>();
        
        private void Save_btn_Click(object sender, EventArgs e)
        {

            if (stokk_dataGridView1.CurrentRow != null)
            {
                
                if (Convert.ToInt32(Amount_Sales_TextBox1.Text) <= Convert.ToInt32(stokk_dataGridView1.CurrentRow.Cells["Amount"].Value.ToString())  )
                {
                    try
                    {
                        stokk_dataGridView1.CurrentRow.Cells["Amount"].Value =
                        (Convert.ToInt32(stokk_dataGridView1.CurrentRow.Cells["Amount"].Value.ToString())) -
                        (Convert.ToInt32(Amount_Sales_TextBox1.Text));
                    }

                    catch
                    {
                        MessageBox.Show("This amount not exist");
                    }
                   }
                 }
            // billGridView.Rows.Count = 0;
            //TotalTextBox1.Text = null;

            //event fire

            SellBill sellbill = new SellBill();
            sellbill.TotalPrice = 0;
            sellbill.BillNumber = int.Parse(billNumTextBox1.Text);
            sellbill.Date = guna2DateTimePicker1.Value;
            sellbill.Customer = CustomerName_ComboBox1.SelectedItem.ToString();
            //if (this.Totallabel.Text == "" || this.Totallabel.Text == null)

            //    MessageBox.Show("Total is null");

            //else
            //    sellbill.TotalPrice = double.Parse(Totallabel.Text);
            Double total = 0;
            foreach (DataGridViewRow row in BilldataGridView1.Rows)
            {

                total += Convert.ToDouble(row.Cells[3].Value) *
                        Convert.ToDouble(row.Cells[4].Value);
            }
            sellbill.TotalPrice = total;

            foreach (DataGridViewRow row in BilldataGridView1.Rows)
            {
                if (row != null)
                { 
                    CarProducts billproducts = new CarProducts();

                    billproducts.CarCateegory = (string)row.Cells[0].Value;
                    billproducts.Brand = (string)row.Cells[1].Value;
                    billproducts.Modle = Convert.ToInt32(row.Cells[2].Value);
                    billproducts.Price = Convert.ToInt32(row.Cells[3].Value);
                    billproducts.Amount = Convert.ToInt32(row.Cells[4].Value);
                    billproducts.Color = (string)row.Cells[5].Value;


                    billproducts.stockprod = StockName_ComboBox3.SelectedItem.ToString();
                   
                    sellbill.listOfbilldetealis.Add(billproducts);
                }
                else
                    MessageBox.Show("no data");
                }

                if (sellAdd != null)
                {
                    sellAdd(sellbill);
                }
            //billNumTextBox1.Text = " ";
            //CategoryTextBox1.Text = " ";
            //BrandTextBox1.Text = " ";
            //ModelTextBox1.Text = " ";
            //PriceTextBox1.Text = " ";
            //Amount_Sales_TextBox1.Text = " ";
            //ColorTextBox1.Text = " ";
            Totallabel.Text = " 0.0";

            BilldataGridView1.RowCount = 0;

        }

        //Calculate Total Price
       
        private void TotalButton4_Click(object sender, EventArgs e)
        {
             //SellBill sellbil = new SellBill();
        //int p = int.Parse(PriceTextBox1.Text);
        //int q = int.Parse(Amount_Sales_TextBox1.Text);
        //TotalTextBox1.Text = ( p * q).ToString() + " LE ";
        Double total = 0;
            foreach (DataGridViewRow row in BilldataGridView1.Rows)
            {

                total += Convert.ToDouble(row.Cells[3].Value) *
                        Convert.ToDouble(row.Cells[4].Value);
            }
            //Totallabel.Text += total + " LE";
            Totallabel.Text = total.ToString() + " LE";
            //sellbil.TotalPrice = total;
        }
    }
    
}
