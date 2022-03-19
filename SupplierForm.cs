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
    public partial class SupplierForm : Form
    {
        public event Action<HumanSuppliers> AddSupplier;
        private List<HumanSuppliers> sublist;
        public SupplierForm(List<HumanSuppliers> mySuplist)
        {
            InitializeComponent();
            sublist = mySuplist;
            if (mySuplist.Count > 0)
            {
                Supplier_dataGridView1.DataSource = null;
                Supplier_dataGridView1.DataSource = sublist;

            }
        }

        private void Car_number_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_supplier_btn_Click(object sender, EventArgs e)
        {
            HumanSuppliers supp = new HumanSuppliers();
            if (SupplierNameTextBox1.Text.Length > 0 && Supplier_number_textBox.Text.Length>0 && Company_txtbox.Text.Length>0
                && Supplier_addressTextBox1.Text.Length>0 && Supplier_emailTextBox3.Text.Length>0)

     
            {
               
                supp.name = SupplierNameTextBox1.Text;
                supp.phone = int.Parse(Supplier_number_textBox.Text);
                supp.company = Company_txtbox.Text;
                supp.address = Supplier_addressTextBox1.Text;
                supp.email = Supplier_emailTextBox3.Text;
               
                if (AddSupplier != null)
                {
                    AddSupplier(supp);
                }
               
           
                Supplier_dataGridView1.DataSource = null;
                Supplier_dataGridView1.DataSource = sublist;



            }
            else
                MessageBox.Show("Enter Supplier Data");
        }

        private void Remove_Button1_Click(object sender, EventArgs e)
        {
            sublist.RemoveAt(Supplier_dataGridView1.SelectedRows[0].Index);
            Supplier_dataGridView1.DataSource = null;
            Supplier_dataGridView1.DataSource = sublist;
        }
    }
}
