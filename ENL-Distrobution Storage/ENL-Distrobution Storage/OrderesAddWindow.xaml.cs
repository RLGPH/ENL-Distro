using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace ENL_Distrobution_Storage
{
    /// <summary>
    /// Interaction logic for OrderesAddWindow.xaml
    /// </summary>
    public partial class OrderesAddWindow : Window
    {
        readonly Database database = new();
        public OrderesAddWindow(Order_s order)
        {
            InitializeComponent();
            if(order != null) 
            {
                if(order.OrdersID > 0)
                {
                    int orderid = order.OrdersID;
                    int ProductID = order.ProduktID;
                    int workerID = order.WorkerID;
                    int quantity = order.OrderAmount;
                    string WorkerN = order.NWorker;
                    string ProductN = order.NProduct;
                    var status = order.OStatus;
                    int statusint = (int)order.OStatus;

                    CB_Status.SelectedIndex = statusint;

                    TB_nproduct.Text = ProductN;
                    TB_nworker.Text = WorkerN;
                    TB_OrderID.Text = orderid.ToString();
                    TB_productID.Text = ProductID.ToString();
                    TB_Quantity.Text = quantity.ToString();
                    TB_workerID.Text = workerID.ToString();
                    TB_Order_Status.Text = status.ToString();
                }
            }
            List<Product> products = database.products;
            database.GetAllProducts();
            DTG_things_to_order_and_who.ItemsSource = null;
            DTG_things_to_order_and_who.ItemsSource = products;
        }

        private void BTN_Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BTN_add_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxItem ProductorEmployee = (ComboBoxItem)CB_Products_Employees.SelectedItem;
            if (ProductorEmployee != null)
            {
                int productoremployee = Convert.ToInt32(ProductorEmployee.Tag);
                if (productoremployee == 0)
                {
                    Product product = (Product)DTG_things_to_order_and_who.SelectedItem;
                    string Pname = product.ProductName;
                    int ProductID = product.ProductID;

                    TB_nproduct.Text = Pname;
                    TB_productID.Text = ProductID.ToString();
                }
                else if (productoremployee == 1)
                {
                    Employee employee = (Employee)DTG_things_to_order_and_who.SelectedItem;
                    string FName = employee.FirstName;
                    string LName = employee.LastName;

                    int WorkID = employee.WorkerID;
                    string fullName = FName + " " + LName;
                    TB_nworker.Text = fullName;
                    TB_workerID.Text = WorkID.ToString();
                }
                else
                {
                    MessageBox.Show($"how did you get here(adding stuff)");
                }
            }
            else if ( ProductorEmployee == null ) 
            {
                Product product = (Product)DTG_things_to_order_and_who.SelectedItem;
                string Pname = product.ProductName;
                int ProductID = product.ProductID;

                TB_nproduct.Text = Pname;
                TB_productID.Text = ProductID.ToString();
            }
        }
        private void BTN_Complete_order_Click(object sender, RoutedEventArgs e)
        {
            string name = TB_nworker.Text;
            string Productname = TB_nproduct.Text;

            int WorkerID = int.Parse(TB_workerID.Text);
            int productid = int.Parse(TB_productID.Text);
            string amountString = TB_Quantity.Text;
            if (int.TryParse(amountString, out int Quantity))
            {

                Order_s order_S = new(0, productid, Quantity, Productname, name, 0, WorkerID);
                database.AddOrder_s(order_S);

                DialogResult = true;
                Close();
            }
            else 
            {
                MessageBox.Show($"Invalid input. Please enter only Numbers:{amountString}");
            }
        }
        private void BTN_save_change_Click(object sender, RoutedEventArgs e)
        { 
            string name = TB_nworker.Text;
            string Productname = TB_nproduct.Text;

            int WorkerID = int.Parse(TB_workerID.Text);
            int productid = int.Parse(TB_productID.Text);
            int OrderID = int.Parse(TB_OrderID.Text);
            string amountString = TB_Quantity.Text;
            if (int.TryParse(amountString, out int Quantity))
            {

                Order_s order_S = new(0, productid, Quantity, Productname, name, 0, WorkerID);
                database.AddOrder_s(order_S);

                DialogResult = true;
                Close();
            }
            else
            {
                MessageBox.Show($"Invalid input. Please enter only Numbers:{amountString}");
            }

            ComboBoxItem orderStatus = (ComboBoxItem)CB_Status.SelectedItem;
            if (orderStatus != null)
            {
                int statusint = Convert.ToInt32(orderStatus.Tag);
                Order_s.OrderStatus status = (Order_s.OrderStatus)statusint;

                Order_s order_S = new(OrderID, productid, Quantity, Productname, name, status, WorkerID);
                database.UpdateOrdersByID(order_S);

                DialogResult = true;
                Close();
            }
        }
        private void CB_Selection_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem ProductorEmployee = (ComboBoxItem)CB_Products_Employees.SelectedItem;
            if (ProductorEmployee != null)
            {
                int productoremployee = Convert.ToInt32(ProductorEmployee.Tag);
                if (productoremployee == 0)
                {
                    List<Product> products = database.products;
                    database.GetAllProducts();
                    DTG_things_to_order_and_who.ItemsSource = null;
                    DTG_things_to_order_and_who.ItemsSource = products;
                }
                else if (productoremployee == 1)
                {
                    List<Employee> employe = database.employees;
                    database.GetAllEmployees();
                    DTG_things_to_order_and_who.ItemsSource = null;
                    DTG_things_to_order_and_who.ItemsSource = employe;
                }
                else
                {
                    MessageBox.Show($"how did you get here(in moveing between list's)");
                }
            }
        }
    }
}
