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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void Login_Button1_Click(object sender, EventArgs e)
        {
            if (UserName_TextBox1.Text == "admin" && Password_TextBox2.Text == "admin")
            {
                new Form1().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The Username or password you entered incorrect, try again!");
                UserName_TextBox1.Clear();
                Password_TextBox2.Clear();
                UserName_TextBox1.Focus();
                
            }
        }

        private void Password_TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
