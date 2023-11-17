using System.Collections.Generic;
using System.Windows;

namespace ENL_Distrobution_Storage
{
    /// <summary>
    /// Interaction logic for Product_add_window.xaml
    /// </summary>
    public partial class Product_add_window : Window
    {
        Database database = new();
        public Product_add_window()
        {
            InitializeComponent();
        }

        private void BTN_Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BTN_save_Click(object sender, RoutedEventArgs e)
        {
            string name = TB_name.Text;
            string description = TB_description.Text;
            string amount = TB_amount.Text;
            int Amount = int.Parse(amount);

            Product Newproduct = new(0,Amount,1,name,description);
            database.AddProduct(Newproduct);

            database.GetAllProducts();
            DialogResult = true;
            Close();
        }
    }
}