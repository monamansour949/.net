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
    public partial class CategoryForm : Form
    {
        public event Action<CarCategory> categAdd;
        private IReadOnlyList<CarCategory> carcategories;


        public CategoryForm(IReadOnlyList<CarCategory> _carcategories)
        {
            InitializeComponent();
            carcategories = _carcategories;
            if (_carcategories.Count > 0)
            {
                Category_dataGridView1.DataSource = null;
                Category_dataGridView1.DataSource = carcategories;
            }
        }

       

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Category_DataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

     
        private void Category_dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void CarProduct_dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Add_category_Btn_Click(object sender, EventArgs e)
        {
            CarCategory carCat = new CarCategory();
            carCat.Name = guna2TextBox1.Text;
            if (guna2TextBox1.Text.Length > 0)
            {
                if (categAdd != null)
                {
                    categAdd(carCat);
                }
                Category_dataGridView1.DataSource = null;
                Category_dataGridView1.DataSource = carcategories;
            }
            else
                MessageBox.Show("Enter category name");
        }

        private void Category_dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                CarProduct_dataGridView1.DataSource = null;
                if (carcategories[e.RowIndex].Products.Count > 0)
                {

                    CarProduct_dataGridView1.DataSource = carcategories[e.RowIndex].Products;
                }
                else
                {
                    MessageBox.Show("No products");
                }
            }
        }
    }
}
