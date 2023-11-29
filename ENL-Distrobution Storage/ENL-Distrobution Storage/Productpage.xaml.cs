using System.Collections.Generic;
using System.Windows;

namespace ENL_Distrobution_Storage
{
    /// <summary>
    /// Interaction logic for Productpage.xaml
    /// </summary>
    public partial class Productpage : Window
    {
        public Database database = new();
        public Productpage()
        {
            InitializeComponent();
            database.GetAllProducts();
            List<Product> products = database.GetAllProducts();

            DTG_products.ItemsSource = products;
        }

        private void BTN_add_Click(object sender, RoutedEventArgs e)
        {
            Product_add_window product_Add_Window = new();
            bool? result = product_Add_Window.ShowDialog();
            if (result == true)
            {
                List<Product> products = database.products;
                database.GetAllProducts();
                DTG_products.ItemsSource = null;
                DTG_products.ItemsSource = products;
            }
        }
    

        private void BTN_close_window_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BTN_remove_Click(object sender, RoutedEventArgs e)
        {
            // Assuming DTG_products is the name of your DataGrid

            List<Product> products = database.products;
            if (DTG_products.SelectedItem is Product selectedProduct)
            {
                int id = selectedProduct.ID;
                MessageBox.Show($"Selected ID: {id}");

                // Call the RemoveProduct method directly from the Database class
                database.RemoveProduct(selectedProduct);

                database.GetAllProducts();
                DTG_products.ItemsSource = null;
                DTG_products.ItemsSource = products;
            }
            else
            {
                // Handle the case where no item is selected
                MessageBox.Show("No item selected.");
            }

        }

        private void BTN_edit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}