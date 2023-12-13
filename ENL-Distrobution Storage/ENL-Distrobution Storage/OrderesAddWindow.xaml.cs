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
            //only really initialize this if it has anything and holds a value greater then 0
            if(order != null) 
            {
                if(order.OrdersID > 0)
                {
                    //splits the data
                    int orderid = order.OrdersID;
                    int ProductID = order.ProduktID;
                    int workerID = order.WorkerID;
                    int quantity = order.OrderAmount;
                    string WorkerN = order.NWorker;
                    string ProductN = order.NProduct;
                    var status = order.OStatus;

                    //indexes status combobox to be the current status
                    int statusint = (int)order.OStatus;
                    CB_Status.SelectedIndex = statusint;

                    //gives the data to the textboxes
                    TB_nproduct.Text = ProductN;
                    TB_nworker.Text = WorkerN;
                    TB_OrderID.Text = orderid.ToString();
                    TB_productID.Text = ProductID.ToString();
                    TB_Quantity.Text = quantity.ToString();
                    TB_workerID.Text = workerID.ToString();
                    TB_Order_Status.Text = status.ToString();
                }
            }
            //to start with the list from products for the datagrid
            List<Product> products = database.products;
            database.GetAllProducts();
            DTG_things_to_order_and_who.ItemsSource = null;
            DTG_things_to_order_and_who.ItemsSource = products;
        }

        private void BTN_Cancel_Click(object sender, RoutedEventArgs e)
        {
            //close for nervus people
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
                    //give the need information from selected Product 
                    Product product = (Product)DTG_things_to_order_and_who.SelectedItem;
                    string Pname = product.ProductName;
                    int ProductID = product.ProductID;

                    //adds the Data to the Textbox
                    TB_nproduct.Text = Pname;
                    TB_productID.Text = ProductID.ToString();
                }
                else if (productoremployee == 1)
                {
                    //gives the need inforamtion from employee to the textbox
                    Employee employee = (Employee)DTG_things_to_order_and_who.SelectedItem;
                    string FName = employee.FirstName;
                    string LName = employee.LastName;

                    //combinds the FName(firstname) and LName(LastName) into fullName then adds it to the textbox
                    //adds ID to textbox
                    int WorkID = employee.WorkerID;
                    string fullName = FName + " " + LName;
                    TB_nworker.Text = fullName;
                    TB_workerID.Text = WorkID.ToString();
                }
                else
                {
                    //the huge big question if you get here i would be really surpised but its here if you some how do
                    MessageBox.Show($"how did you get here(adding stuff)");
                }
            }
            //if the CB is null it just uses Product list to add to the textboxes
            else if ( ProductorEmployee == null ) 
            {
                //give the need information from selected Product 
                Product product = (Product)DTG_things_to_order_and_who.SelectedItem;
                string Pname = product.ProductName;
                int ProductID = product.ProductID;

                //adds the Data to the Textbox
                TB_nproduct.Text = Pname;
                TB_productID.Text = ProductID.ToString();
            }
        }
        private void BTN_Complete_order_Click(object sender, RoutedEventArgs e)
        {
            //gets the information from the textboxes
            string name = TB_nworker.Text;
            string Productname = TB_nproduct.Text;

            int WorkerID = int.Parse(TB_workerID.Text);
            int productid = int.Parse(TB_productID.Text);
            //makes sure the information textbox qauntity is an int why its the only int right now
            //you can mess up on this page
            string amountString = TB_Quantity.Text;
            if (int.TryParse(amountString, out int Quantity))
            {
                //then it puts the data together and adds the data to the database
                Order_s order_S = new(0, productid, Quantity, Productname, name, 0, WorkerID);
                database.AddOrder_s(order_S);

                //to update the first page true it must be
                DialogResult = true;
                Close();
            }
            else 
            {
                //if the quantity is not a numbe
                MessageBox.Show($"Invalid input. Please enter only Numbers:{amountString}");
            }
        }
        private void BTN_save_change_Click(object sender, RoutedEventArgs e)
        {
            //gets the data from the Textbox
            string name = TB_nworker.Text;
            string Productname = TB_nproduct.Text;

            //we convert what needs to be converted
            int WorkerID = int.Parse(TB_workerID.Text);
            int productid = int.Parse(TB_productID.Text);
            int OrderID = int.Parse(TB_OrderID.Text);
            string amountString = TB_Quantity.Text;
            //we check if its an int
            if (int.TryParse(amountString, out int Quantity))
            {
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
            else
            {
                MessageBox.Show($"Invalid input. Please enter only Numbers:{amountString}");
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
