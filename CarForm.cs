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
    public partial class CarForm : Form
    {
        public event Action<CarProducts> carAdd;
        private IReadOnlyList<CarProducts> carProduct;
        private IReadOnlyList<CarCategory> categories;
        private IReadOnlyList<storageCar> carstorage;
        public CarForm(IReadOnlyList<CarCategory> _categories, IReadOnlyList<storageCar> _carstorage, IReadOnlyList<CarProducts> _carProduct)
        {
            carProduct = _carProduct;
            categories = _categories;
            carstorage = _carstorage;
            InitializeComponent();
            if (_categories.Count > 0)
            {
                foreach (CarCategory item in _categories)
                {
                    Category_ComboBox1.Items.Add(item.Name);
                }
            }
            if (_carstorage.Count > 0)
            {
                foreach (storageCar item in _carstorage)
                {
                    Stoke_ComboBox1.Items.Add(item.Name);
                }
            }
            carProduct = _carProduct;
            if(_carProduct.Count >0)
            {
                CarProduct_dataGridView1.DataSource = null;
                CarProduct_dataGridView1.DataSource = carProduct;

            }

        }
        //view products in category form
        public CarCategory Getcategorybyname(string name)
        {
            foreach (CarCategory catlist in categories)
            {
                if (catlist.Name == name)
                    return catlist;
            }
                    MessageBox.Show("Category not founded");
            
                   return null;
             }
        //view products in stock form
        public storageCar Getstockbyname(string name)
        {
            foreach (storageCar storlist in carstorage)
            {
                if (storlist.Name == name)
                    return storlist;
            }
            MessageBox.Show("stock not founded");

            return null;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

    

        private void Add_car_Btn_Click(object sender, EventArgs e)
        {
           
        }

        private void Stoke_ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Category_ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CarProduct_dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Add_car_btn_Click(object sender, EventArgs e)
        {
            CarProducts carproduct = new CarProducts();


            if ( Car_BrandNameTextBox1.Text.Length > 0 && txtcolor.Text.Length > 0
                && Car_PriceTextBox1.Text.Length > 0 && CarModelTextBox3.Text.Length > 0 && guna2TextBox_count.Text.Length > 0
                && Category_ComboBox1.SelectedIndex != -1 && Stoke_ComboBox1.SelectedIndex != -1)
            {
                
                carproduct.Brand = Car_BrandNameTextBox1.Text;
                carproduct.Color = txtcolor.Text;
                carproduct.Price = int.Parse(Car_PriceTextBox1.Text);
                carproduct.Modle = int.Parse(CarModelTextBox3.Text);
                carproduct.Amount = int.Parse(guna2TextBox_count.Text);
                carproduct.CarCateegory = Category_ComboBox1.SelectedItem.ToString();
                carproduct.stockprod = Stoke_ComboBox1.SelectedItem.ToString();
               
                if (carAdd != null)
                {
                    carAdd(carproduct);
                }
                CarCategory cat = Getcategorybyname(carproduct.CarCateegory);
                cat.Products.Add(carproduct);

                storageCar Stock = Getstockbyname(carproduct.stockprod);
                Stock.products.Add(carproduct);
                CarProduct_dataGridView1.DataSource = null;
                CarProduct_dataGridView1.DataSource = carProduct;


            }
            else
                MessageBox.Show("You should Enter details");
        }
    }
}
