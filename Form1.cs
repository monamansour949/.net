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
    public partial class Form1 : Form
    {
        List<CarCategory> categories = new List<CarCategory>();
        List<storageCar> stockes = new List<storageCar>();
        List<CarProducts> cars = new List<CarProducts>();
        List<HumanSuppliers> suppliersList = new List<HumanSuppliers>();
        List<purchaseInvioce> purchaseslist = new List<purchaseInvioce>();
        List<Customer> customersList = new List<Customer>();
        List<SellBill> sellbillList = new List<SellBill>(); //list of bills
        // for test
        IReadOnlyCollection<purchaseInvioce> purchaseInvioces = new List<purchaseInvioce>();
        IReadOnlyCollection<HumanSuppliers> SUBlist = new List<HumanSuppliers>();
        IReadOnlyCollection<storageCar> Stocklist = new List<storageCar>();
        IReadOnlyCollection<CarCategory> Caregorieslist = new List<CarCategory>();
        
        public Form1()
        {
            InitializeComponent();
        }


        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }


        private void Form1_Load_1(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

      
        private void Addcat(CarCategory obj)
        {
            categories.Add(obj);
        }
        private void AddCutomer(Customer obj)
        {
            customersList.Add(obj);

        }
        // Add bill Function
        private void AddBill(SellBill obj)
        {
            
            sellbillList.Add(obj);
            MessageBox.Show("Bill saved");
        }
        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryForm frm = new CategoryForm(categories);
            frm.MdiParent = this;
            frm.TopLevel = false;
            frm.ControlBox = false;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
            frm.categAdd += Addcat;
        }
        private void Addcar(CarProducts obj)
        {
            cars.Add(obj);
        }
        private void supplierFun ( HumanSuppliers obj)
        {
            suppliersList.Add(obj);

        }

        //purchases 
        private void purchasesFun(  purchaseInvioce  obj)
        {
            purchaseslist.Add(obj);
        }
        private void carToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarForm fcar = new CarForm(categories, stockes, cars);
            fcar.MdiParent = this;
            fcar.TopLevel = false;
            fcar.ControlBox = false;
            fcar.Dock = DockStyle.Fill;
            fcar.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fcar.Show();
            fcar.WindowState = FormWindowState.Maximized;
            fcar.carAdd += Addcar;

           
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void Addstock(storageCar obj)
        {
            stockes.Add(obj);
        }
        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StokeStorageForm stock = new StokeStorageForm(stockes);
            stock.MdiParent = this;
            stock.TopLevel = false;
            stock.ControlBox = false;
            stock.Dock = DockStyle.Fill;
            stock.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            stock.Show();
            stock.WindowState = FormWindowState.Maximized;
            stock.stockAdd += Addstock;

        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void subllierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplierForm supplierForm = new SupplierForm(suppliersList);
            supplierForm.MdiParent = this;
            supplierForm.TopLevel = false;
            supplierForm.ControlBox = false;
            supplierForm.Dock = DockStyle.Fill;
            supplierForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            supplierForm.Show();
            supplierForm.WindowState = FormWindowState.Maximized;
            supplierForm.AddSupplier += supplierFun;

        }

        private void Purchases_Inovice_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseForm purchaseForm = new PurchaseForm(purchaseslist, suppliersList, categories, stockes, cars); 
            purchaseForm.MdiParent = this;
            purchaseForm.TopLevel = false;
            purchaseForm.ControlBox = false;
            purchaseForm.Dock = DockStyle.Fill;
            purchaseForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            purchaseForm.Show();
            purchaseForm.WindowState = FormWindowState.Maximized;
            purchaseForm.AddPurchaseInvioce += purchasesFun;

        }
        private void customerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CustomerForm customerf = new CustomerForm(customersList);
            customerf.MdiParent = this;
            customerf.TopLevel = false;
            customerf.ControlBox = false;
            customerf.Dock = DockStyle.Fill;
            customerf.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            customerf.Show();
            customerf.WindowState = FormWindowState.Maximized;
            customerf.AddCustomer += AddCutomer;
        }
        // لازم تعملي constructor في المبيعات برده زي ما عملت ف المشتريات

        private void salesInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesBillForm sellfrm = new SalesBillForm( customersList, stockes, cars);
            sellfrm.MdiParent = this;
            
            sellfrm.TopLevel = false;
            sellfrm.ControlBox = false;
            sellfrm.Dock = DockStyle.Fill;
            sellfrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            sellfrm.Show();
            sellfrm.WindowState = FormWindowState.Maximized;
            sellfrm.sellAdd += AddBill;

        }

        private void salesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesReportForm salesreport = new SalesReportForm(sellbillList);
            salesreport.MdiParent = this;
            salesreport.TopLevel = false;
            salesreport.ControlBox = false;
            salesreport.Dock = DockStyle.Fill;
            salesreport.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            salesreport.Show();
            salesreport.WindowState = FormWindowState.Maximized;
            
        }

     

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminForm adminf = new AdminForm();
            adminf.Show();
            this.Hide();
        }
    }
}
