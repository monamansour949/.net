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
    public partial class StokeStorageForm : Form
    {
        public event Action<storageCar> stockAdd;
        private IReadOnlyList<storageCar> stockes;

        public StokeStorageForm(IReadOnlyList<storageCar> _stockes)
        {
            InitializeComponent();
            stockes = _stockes;
            if (_stockes.Count > 0)
            {
                StockBrand_dataGridView1.DataSource = null;
                StockBrand_dataGridView1.DataSource = stockes;
            }
        }

      

        private void StockBrand_dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CarProductInStock_dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Add_Stock_Btn_Click(object sender, EventArgs e)
        {
            storageCar storage = new storageCar();
            storage.Name = Stock_TextBox1.Text;
            if (Stock_TextBox1.Text.Length > 0)
            {
                if (stockAdd != null)
                {
                    stockAdd(storage);
                }
                StockBrand_dataGridView1.DataSource = null;
                StockBrand_dataGridView1.DataSource = stockes;
            }
            else
                MessageBox.Show("Enter stock name");
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StockBrand_dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                CarProductInStock_dataGridView1.DataSource = null;
                if (stockes[e.RowIndex].products.Count > 0)
                {

                    CarProductInStock_dataGridView1.DataSource = stockes[e.RowIndex].products;
                }
                else
                {
                    MessageBox.Show("No products");
                }
            }
        }
    }
}
