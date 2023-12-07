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

        private void Btn_add_Click(object sender, RoutedEventArgs e)
        {
            EmployeeAddwindow employeeaddwindow = new();
            employeeaddwindow.ShowDialog();
        }

        private void btn_close_window_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btn_remove_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_edit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
