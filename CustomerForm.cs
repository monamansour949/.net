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
    public partial class CustomerForm : Form
    {
        public event Action<Customer> AddCustomer;
        private IReadOnlyList<Customer> Customerlist;
        public CustomerForm(IReadOnlyList<Customer> customerlist)
        {
            InitializeComponent();
            Customerlist = customerlist;
            if (customerlist.Count > 0)
            {
                Customer_dataGridView1.DataSource = null;
                Customer_dataGridView1.DataSource = customerlist;
            }
        }
        private void Add_Customer_btn_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            if (Customer_NameTextBox1.Text.Length > 0 && customer_number_textBox.Text.Length > 0)
            {
                customer.Name = Customer_NameTextBox1.Text;
                customer.PhoneNumber = int.Parse(customer_number_textBox.Text);
                if (AddCustomer != null)
                {
                    AddCustomer(customer);
                }
                Customer_dataGridView1.DataSource = null;
                Customer_dataGridView1.DataSource = Customerlist;
            }

            else
                MessageBox.Show("Enter Customer Data");
        }

       
    }
}
