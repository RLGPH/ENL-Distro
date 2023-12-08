using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace ENL_Distrobution_Storage
{
    /// <summary>
    /// Interaction logic for Product_add_window.xaml
    /// </summary>
    public partial class Product_add_window : Window
    {

        readonly Database database = new();
        public Product_add_window(Location location)
        {
            InitializeComponent();
            if (location != null)
            {
               
                List<Location> locations = database.GetPlocation(location);
                var extractedLocation = locations.Select(location => new { location.Row, location.Shelf, location.LocationID }).ToList();

                int row = extractedLocation.First().Row;
                int shelf = extractedLocation.First().Shelf;
                int Locationid = extractedLocation.First().LocationID;

                List<Product> products = database.GetAllProducts();

                Product foundProduct = database.GetProductById(Locationid);
                string name = foundProduct.ProductName;
                string description = foundProduct.ProductDescription;
                int amount = foundProduct.ProductAmount;
                if (Locationid > 0)
                {
                    TB_ID.Text = Locationid.ToString();
                    TB_name.Text = name;
                    TB_row.Text = row.ToString();
                    TB_shelf.Text = shelf.ToString();
                    TB_amount.Text = amount.ToString();
                    TB_description.Text = description;
                }
            }
        }

        private void BTN_Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BTN_Add_Click(object sender, RoutedEventArgs e)
        {
            string name = TB_name.Text;
            string description = TB_description.Text;
            
            string amount = TB_amount.Text;
            int Amount = int.Parse(amount);
            
            string row = TB_row.Text;
            string shelf = TB_shelf.Text;
            
            int Row = int.Parse(row);
            int Shelf = int.Parse(shelf);
            
            Location location = new(Row, Shelf, 0);
            database.AddPLocation(location);

            Product Newproduct = new(0,Amount,name, description, location);
            database.AddProduct(Newproduct);
            


            database.GetAllProducts();
            DialogResult = true;
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

            string Id = TB_ID.Text;
            int ID = int.Parse(Id);

            Location location = new(Row, Shelf, ID);

            Product Updateproduct = new(ID, Amount, name, description, location);
            
            database.UpdateProductandlocation(Updateproduct,location);
        }
    }
}