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
    public partial class SalesReportForm : Form
    {
        SalesBillForm sell;
        public List<SellBill> sellbills;

        public SalesReportForm(List<SellBill> _sellbills)
        {


            InitializeComponent();
            sellbills = _sellbills;


        }

    

        private void Print_Click(object sender, EventArgs e)
        {
            List<CarProducts> Newsellbills = new List<CarProducts>();
            List<SellBill> Newsellbillss = new List<SellBill>();
            if (sellbills.Count > 0)
            {
                foreach (SellBill item in sellbills)
                {
                  
                    ReportdataGridView1.DataSource = null;
                    if (item.Date >= FromDateTimePicker1.Value && item.Date <= ToDateTimePicker1.Value)
                    {

                        Newsellbillss.Add(item);
                        ReportdataGridView1.DataSource = Newsellbillss;

                    }
                }
                
            }
        }


        private void guna2DataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            //List<CarProducts> Newsellbills = new List<CarProducts>();
            //List<SellBill> Newsellbillss = new List<SellBill>();
            //if (sellbills.Count > 0)
            //{
            //    foreach (SellBill item in sellbills)
            //    {
            //        //Items.Add(item.Name);
            //        DetailsDataGridView1.DataSource = null;

            //        for (int i = 0; i < item.listOfbilldetealis.Count; i++)
            //        {
            //            Newsellbills.Add(item.listOfbilldetealis[i]);

            //        }
            //        DetailsDataGridView1.DataSource = Newsellbills;
            //    }

            //}
        }

        private void guna2DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
            private void ReportdataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
            {
            //List<CarProducts> Newsellbills = new List<CarProducts>();
            //List<SellBill> Newsellbillss = new List<SellBill>();
            //if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            //{
            //    RepDetdataGridView1.DataSource = null;
            //    if (Newsellbillss[e.RowIndex].listOfbilldetealis.Count > 0)
            //    {

            //        RepDetdataGridView1.DataSource = Newsellbillss[e.RowIndex].listOfbilldetealis;
            //    }
            //    else
            //    {
            //        MessageBox.Show("No products");
            //    }
            //}
        }
        }
    }
