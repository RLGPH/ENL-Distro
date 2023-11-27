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

namespace ENL_Distrobution_Storage
{
    /// <summary>
    /// Interaction logic for OrderesAddWindow.xaml
    /// </summary>
    public partial class OrderesAddWindow : Window
    {
        public OrderesAddWindow()
        {
            InitializeComponent();
        }

        private void BTN_save_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BTN_Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
