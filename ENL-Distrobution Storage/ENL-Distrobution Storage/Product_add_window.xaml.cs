using System.Windows;

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
        private void Btn_Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
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
                Amount = amount,
                PLocation = plocation,
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