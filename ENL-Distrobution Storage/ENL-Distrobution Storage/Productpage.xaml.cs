using System.Collections.Generic;
using System.Windows;

namespace ENL_Distrobution_Storage
{
    /// <summary>
    /// Interaction logic for Productpage.xaml
    /// </summary>
    public partial class Productpage : Window
    {
        public Database database= new();
        public Productpage()
        {
            InitializeComponent();
            database.GetAllProducts();
            List<Product> products = database.GetAllProducts();

            DTG_products.ItemsSource = products;
        }

        private void Btn_add_Click(object sender, RoutedEventArgs e)
        {
            List<Product> products = database.products;
            // Create a new Product object
            Product newProduct = new(1, 2, 1, "Example Product", "This is an example product.");

            // Add the product to the database and list
            database.AddProduct(newProduct);
            Product_add_window product_Add_Window = new(database);
            product_Add_Window.Show();
            database.GetAllProducts();
            DTG_products.ItemsSource = null;
            DTG_products.ItemsSource = products;
        }

        private void BTN_close_window_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}