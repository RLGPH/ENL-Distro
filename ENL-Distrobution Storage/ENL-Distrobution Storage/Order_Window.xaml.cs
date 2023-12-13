using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace ENL_Distrobution_Storage
{
    /// <summary>
    /// Interaction logic for Order_Window.xaml
    /// </summary>
    public partial class Order_Window : Window
    {
        readonly Order_s order;
        readonly Database database = new();
        public Order_Window()
        {
            InitializeComponent();
            //initialize the datagrid with info from the database
            List<Order_s> order_s = database.order_s;
            database.GetAllOrders();
            DTG_Orders.ItemsSource = order_s;
        }

        private void BTN_Order_Click(object sender, RoutedEventArgs e)
        {
            //opens orderaddwindow then waits for True or nothing wich would in my case be good enough as a false
            OrderesAddWindow orderesAddWindow = new(order);
            bool? resault = orderesAddWindow.ShowDialog();
            if (resault == true) 
            {
                //reloads the datagrid after the order has been made
                List<Order_s> order_S = database.order_s;
                database.GetAllOrders();
                DTG_Orders.ItemsSource = null;
                DTG_Orders.ItemsSource = order_S;
            }
        }

        private void BTN_edit_Order_Click(object sender, RoutedEventArgs e)
        {
            //gets the data from the selecteditem in the datagrid also makes sure that there is something and its not null
            Order_s order =(Order_s)DTG_Orders.SelectedItem;
            if (order != null)
            {
                //splits the data out and asigns some stuff the data
                int orderid = order.OrdersID;
                int ProductID = order.ProduktID;
                int workerID = order.WorkerID;
                int quantity = order.OrderAmount;
                string WorkerN = order.NWorker;
                string ProductN = order.NProduct;
                var status = order.OStatus;

                //sends the data to the ordersaddwindow and waits for the resault
                Order_s orders = new(orderid, ProductID, quantity, ProductN, WorkerN, status, workerID);
                OrderesAddWindow orderesAddWindow = new(orders);
                bool? resault = orderesAddWindow.ShowDialog();
                if (resault == true)
                {
                    //if its true then updates the datagrid
                    List<Order_s> order_S = database.order_s;
                    database.GetAllOrders();
                    DTG_Orders.ItemsSource = null;
                    DTG_Orders.ItemsSource = order_S;
                }
            }
        }

        private void DTG_Orders_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            //if you click an order on the datagrid it will the make the ID of that appear in the Textbox 
            //not needed but nice to have
            if (DTG_Orders.SelectedItem != null)
            {
                Order_s selectedOrder = (Order_s)DTG_Orders.SelectedItem;
                int selectedOrderId = selectedOrder.OrdersID;
                TB_ID_Select.Text = selectedOrderId.ToString();
            }
        }

        private void BTN_remove_Click(object sender, RoutedEventArgs e)
        {
            //takes the selected item from the datagrid and then gets its ID to delete the item
            List<Order_s> orders = database.order_s;
            if (DTG_Orders.SelectedItem is Order_s selectedOrder)
            {
                int id = selectedOrder.WorkerID;
                //opens messagebox to tell you the ID of the thing you delete
                MessageBox.Show($"Selected ID: {id}");

                //activates the method for deleting
                database.DeleteOrder_sByID(selectedOrder);

                database.GetAllEmployees();
                DTG_Orders.ItemsSource = null;
                DTG_Orders.ItemsSource = orders;
            }
            else
            {
                //if no item is selected
                MessageBox.Show("No item selected.");
            }
        }

        private void BTN_close_Click(object sender, RoutedEventArgs e)
        {
            //close button for nervus people
            Close();
        }
    }
}