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

    }
}
