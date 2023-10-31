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
using System.Windows.Navigation;
using System.Windows.Shapes;

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
