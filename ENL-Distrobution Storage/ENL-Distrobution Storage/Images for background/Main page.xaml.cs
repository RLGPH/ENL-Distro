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

namespace ENL_Distrobution_Storage.Images_for_background
{
    /// <summary>
    /// Interaction logic for Main_page.xaml
    /// </summary>
    public partial class Main_page : Window
    {
        public Main_page()
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
