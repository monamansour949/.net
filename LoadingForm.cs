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
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
            timer1.Start();
        }

       
        int StartP = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            StartP +=1;
            guna2ProgressBar1.Value = StartP;
            if(guna2ProgressBar1.Value==100)
            {
                guna2ProgressBar1.Value = 0;
                timer1.Stop();
                AdminForm admin = new AdminForm();
                admin.Show();
                this.Hide();
            }
        }

        private void guna2ProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
