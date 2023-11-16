using System.Windows;

namespace ENL_Distrobution_Storage
{
    /// <summary>
    /// Interaction logic for Product_add_window.xaml
    /// </summary>
    public partial class Product_add_window : Window
    {
        private Database _database = new();
        Productpage _productpage = new();
        public Product_add_window(Database database)
        {
            InitializeComponent();
            _database = database;
        }
        private void Btn_Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Btn_save_Click(object sender, RoutedEventArgs e)
        {
           
        }
    }
}