using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

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
            string row = TB_row.Text;
            string shelf = TB_shelf.Text;
            int Row = int.Parse(row);
            int Shelf = int.Parse(shelf);
            string PLocationID = Shelf + "." + Row;
            
            /*Location location = new(Row, Shelf, PLocationID);
            database.AddPLocation(location);*/
            Product Newproduct = new(0,Amount,name, description,PLocationID);
            database.AddProduct(Newproduct);
            


            database.GetAllProducts();
            DialogResult = true;
            Close();
        }
    }
}