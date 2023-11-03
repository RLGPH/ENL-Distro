using System.Windows;

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

        private void Btn_add_Click(object sender, RoutedEventArgs e)
        {
            Product_add_window product_Add_Window = new(database);
            product_Add_Window.Show();
        }

        private void Btn_close_window_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
//Product_add_window product_Add_Window = new Product_add_window();
//product_Add_Window.Show();