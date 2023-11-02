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
using System.Xml.Linq;

namespace ENL_Distrobution_Storage
{
    /// <summary>
    /// Interaction logic for Product_add_window.xaml
    /// </summary>
    public partial class Product_add_window : Window
    {
        private Database _database;
        public Product_add_window(Database database)
        {
            InitializeComponent();
            _database = database;
        }
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            // Get data from the text boxes
            string productName = tb_name.Text;
            string description = tb_description.Text;

            if (!int.TryParse(tb_amount.Text, out int amount))
            {
                MessageBox.Show("Invalid amount. Please enter a valid number.");
                return;
            }
            var newProduct = new Product
            {
                ID = id,
                Amount = amount,
                ProductName = productName,
                Description = description
            };

            
            _database.products.Add(newProduct);

            // Optionally, you can clear the text boxes after adding the product
            tb_name.Text = "Insert Name";
            tb_description.Text = "Description";
            tb_amount.Text = "0";
        }
    }
}