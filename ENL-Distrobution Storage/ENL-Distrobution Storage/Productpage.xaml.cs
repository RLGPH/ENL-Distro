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
        readonly Location location;
        public Database database = new();

        private readonly string userRank;
        public Productpage(string rank)
        {
            InitializeComponent();

            userRank = rank;

            database.GetAllProducts();
            List<Product> products = database.GetAllProducts();

            DTG_products.ItemsSource = products;
        }
        private void BTN_add_Click(object sender, RoutedEventArgs e)
        {
            Product_add_window product_Add_Window = new(location);
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
            Main_Page main_page = new(userRank);
            main_page.Show();

            Close();
        }

        private void BTN_remove_Click(object sender, RoutedEventArgs e)
        {
            List<Product> products = database.products;
            if (DTG_products.SelectedItem is Product selectedProduct)
            {
                database.RemoveProduct(selectedProduct);

                database.GetAllProducts();
                DTG_products.ItemsSource = null;
                DTG_products.ItemsSource = products;
            }
            else
            { 
                MessageBox.Show("No item selected.");
            }

        }

        public void BTN_edit_Click(object sender, RoutedEventArgs e)
        {
            string EditID = TB_ID_Select.Text;
            int id = Convert.ToInt32(EditID);

            Location location = new(0, 0, id);
            database.GetPlocation(location);

            Product_add_window product_Add_Window = new(location);
            product_Add_Window.Show();
            
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