using System.Windows;

namespace ENL_Distrobution_Storage
{
    public partial class MainWindow : Window
    {
        Database database = new();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BTN_Orders_Click(object sender, RoutedEventArgs e)
        {
            Order_Window order_Window = new();
            order_Window.Show();
        }

        private void BTN_Workers_Click(object sender, RoutedEventArgs e)
        {
            Employee_Window employee_Window = new();
            employee_Window.Show();
        }

        private void BTN_Products_Click(object sender, RoutedEventArgs e)
        {
            Productpage productPage = new();
            productPage.Show();
        }
    }
}