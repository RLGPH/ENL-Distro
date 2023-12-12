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
            List<Order_s> order_s = database.order_s;
            database.GetAllOrders();
            DTG_Orders.ItemsSource = order_s;
        }

        private void BTN_Order_Click(object sender, RoutedEventArgs e)
        {
            OrderesAddWindow orderesAddWindow = new(order);
            bool? resault = orderesAddWindow.ShowDialog();
            if (resault == true) 
            {
                List<Order_s> order_S = database.order_s;
                database.GetAllOrders();
                DTG_Orders.ItemsSource = null;
                DTG_Orders.ItemsSource = order_S;
            }
        }

        private void BTN_edit_Order_Click(object sender, RoutedEventArgs e)
        {
            Order_s order =(Order_s)DTG_Orders.SelectedItem;
            if (order != null)
            {
                int orderid = order.OrdersID;
                int ProductID = order.ProduktID;
                int workerID = order.WorkerID;
                int quantity = order.OrderAmount;
                string WorkerN = order.NWorker;
                string ProductN = order.NProduct;
                var status = order.OStatus;

                Order_s orders = new(orderid, ProductID, quantity, ProductN, WorkerN, status, workerID);
                OrderesAddWindow orderesAddWindow = new(orders);
                bool? resault = orderesAddWindow.ShowDialog();
                if (resault == true)
                {
                    List<Order_s> order_S = database.order_s;
                    database.GetAllOrders();
                    DTG_Orders.ItemsSource = null;
                    DTG_Orders.ItemsSource = order_S;
                }
            }
        }

        private void DTG_Orders_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (DTG_Orders.SelectedItem != null)
            {
                Order_s selectedOrder = (Order_s)DTG_Orders.SelectedItem;
                int selectedOrderId = selectedOrder.OrdersID;
                TB_ID_Select.Text = selectedOrderId.ToString();
            }
        }

        private void BTN_remove_Click(object sender, RoutedEventArgs e)
        {
            List<Order_s> orders = database.order_s;
            if (DTG_Orders.SelectedItem is Order_s selectedOrder)
            {
                int id = selectedOrder.WorkerID;
                MessageBox.Show($"Selected ID: {id}");


                database.DeleteOrder_sByID(selectedOrder);
            }
            else
            {
                // Handle the case where no item is selected
                MessageBox.Show("No item selected.");
            }
            database.GetAllEmployees();
            DTG_Orders.ItemsSource = null;
            DTG_Orders.ItemsSource = orders;
        }

        private void BTN_close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
