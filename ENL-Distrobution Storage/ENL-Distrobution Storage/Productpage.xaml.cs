using System.Windows;

namespace ENL_Distrobution_Storage
{
    /// <summary>
    /// Interaction logic for Productpage.xaml
    /// </summary>
    public partial class Productpage : Window
    {
        public Database database;
        public Productpage()
        {
            InitializeComponent();
            Database database = new Database("Data Source=LAPTOP-BOMR24KV;Initial Catalog=ENL-Distribution;User Id=John Doe;Password=PassWord1234;Encrypt=False");

            database.GetAllProducts();
        }

        private void Btn_add_Click(object sender, RoutedEventArgs e)
        {
            // Create a new Product object
            Product newProduct = new Product(1, 2, 1, "Example Product", "This is an example product.");

            // Add the product to the database and list
            database.AddProduct(newProduct);

            Product_add_window product_Add_Window = new(database);
            product_Add_Window.Show();
        }

        private void Btn_close_window_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}