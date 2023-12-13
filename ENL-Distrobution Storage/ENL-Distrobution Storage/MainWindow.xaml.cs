using System.Windows;

namespace ENL_Distrobution_Storage
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BTN_Orders_Click(object sender, RoutedEventArgs e)
        {
            //opens oreder window
            Order_Window order_Window = new();
            order_Window.Show();
        }

        private void BTN_Workers_Click(object sender, RoutedEventArgs e)
        {
            //opens employee window
            Employee_Window employee_Window = new();
            employee_Window.Show();
        }

        private void BTN_Products_Click(object sender, RoutedEventArgs e)
        {
            //open productpage window
            Productpage productPage = new();
            productPage.Show();
        }
    }
}