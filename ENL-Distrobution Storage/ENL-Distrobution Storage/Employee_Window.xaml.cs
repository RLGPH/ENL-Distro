using System.Windows;

namespace ENL_Distrobution_Storage
{
    /// <summary>
    /// Interaction logic for Employee_Window.xaml
    /// </summary>
    public partial class Employee_Window : Window
    {
        public Employee_Window()
        {
            InitializeComponent();
        }

        private void BTN_add_Click(object sender, RoutedEventArgs e)
        {
            EmployeeAddwindow employeeaddwindow = new();
            employeeaddwindow.ShowDialog();
        }

        private void BTN_close_window_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BTN_edit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BTN_remove_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
