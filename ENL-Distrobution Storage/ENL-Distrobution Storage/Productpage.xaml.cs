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

namespace ENL_Distrobution_Storage
{
    /// <summary>
    /// Interaction logic for Productpage.xaml
    /// </summary>
    public partial class Productpage : Window
    {
        private Database database;
        public Productpage()
        {
            InitializeComponent();
            
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            Product_add_window product_Add_Window = new Product_add_window(database);
            product_Add_Window.Show();
        }

        private void btn_close_window_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
 //Product_add_window product_Add_Window = new Product_add_window();
//product_Add_Window.Show();