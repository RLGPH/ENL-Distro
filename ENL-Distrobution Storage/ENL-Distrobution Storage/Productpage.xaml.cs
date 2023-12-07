using System;
using System.Collections.Generic;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Xml.Linq;

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
                int id = selectedProduct.ProductID;
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

        public void BTN_edit_Click(object sender, RoutedEventArgs e)
        {
            string EditID = TB_ID_Select.Text;
            int id = Convert.ToInt32(EditID);

            Location location = new Location(0, 0, id);
            database.GetPlocation(location);

            if (int.TryParse(EditID, out int editID))
            {
                // Find the item with the specified ID in the DataGrid
                Product selectedProduct = null;
                foreach (var item in DTG_products.Items)
                {
                    if (item is Product product && product.ProductID == editID)
                    {
                        selectedProduct = product;
                        break; // Stop searching after finding the match
                    }
                }

                if (selectedProduct != null)
                {
                    // Extract the ProductName from the selected item
                    string PName = selectedProduct.ProductName;
                    string PDescription = selectedProduct.ProductDescription;
                    int PAmount = selectedProduct.ProductAmount;
                }
                else
                {
                    // If the item with the specified ID was not found
                    MessageBox.Show("Product with the specified ID not found.");
                }
            }
            else
            {
                // Invalid ID format in the TextBox
                MessageBox.Show("Please enter a valid ID.");
            }
        }

        private void DTG_products_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DTG_products.SelectedItem != null)
            {
                Product selectedProduct = (Product)DTG_products.SelectedItem;
                int selectedProductId = selectedProduct.ProductID;
                TB_ID_Select.Text = selectedProductId.ToString();
            }
        }
    }
}