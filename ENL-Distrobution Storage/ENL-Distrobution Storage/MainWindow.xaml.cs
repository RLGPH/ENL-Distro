using System.Windows;

namespace ENL_Distrobution_Storage
{
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Orders_Click(object sender, RoutedEventArgs e)
        {
            Order_Window order_Window = new Order_Window();
            order_Window.Show();
        }

        private void btn_Workers_Click(object sender, RoutedEventArgs e)
        {
            Employee_Window employee_Window = new Employee_Window();
            employee_Window.Show();
        }

        private void btn_Products_Click(object sender, RoutedEventArgs e)
        {
            Productpage productPage = new Productpage();
            productPage.Show();
        }
    }
}