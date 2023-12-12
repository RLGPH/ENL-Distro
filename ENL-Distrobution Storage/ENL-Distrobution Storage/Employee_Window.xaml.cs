using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace ENL_Distrobution_Storage
{
    /// <summary>
    /// Interaction logic for Employee_Window.xaml
    /// </summary>
    public partial class Employee_Window : Window
    {
        readonly Employee employee;
        readonly Database database = new();
        public Employee_Window()
        {
            InitializeComponent();

            List<Employee> employee = database.employees;
            database.GetAllEmployees();
            DTG_Employee.ItemsSource = employee;
        }

        private void BTN_add_Click(object sender, RoutedEventArgs e)
        {
            EmployeeAddwindow employeeaddwindow = new(employee);
            bool? resault = employeeaddwindow.ShowDialog();
            if (resault == true) 
            {
                List<Employee> employee = database.employees;
                database.GetAllEmployees();
                DTG_Employee.ItemsSource = null;
                DTG_Employee.ItemsSource = employee;
            }
        }

        private void BTN_close_window_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BTN_edit_Click(object sender, RoutedEventArgs e)
        {
            string EditID = TB_ID_Select.Text;
            if (EditID != null)
            {
                int employeeID = int.Parse(EditID);
                if (employeeID > 0)
                {
                    Employee employee = (Employee)DTG_Employee.SelectedItem;
                    int amount = employee.Amount;
                    string tlf = employee.Tlf;
                    string FName = employee.FirstName;
                    string LName = employee.LastName;
                    string Mail = employee.Email;
                    string titel = employee.Jobtitel;
                    var status = employee.Status;

                    Employee employees = new(employeeID, amount, tlf, FName, LName, Mail, titel, status);
                    EmployeeAddwindow employeeAddwindow = new(employees);
                    bool? resault = employeeAddwindow.ShowDialog();
                    if (resault == true)
                    {
                        List<Employee> employe = database.employees;
                        database.GetAllEmployees();
                        DTG_Employee.ItemsSource = null;
                        DTG_Employee.ItemsSource = employe;
                    }
                }
                else
                {
                    MessageBox.Show($"Selected ID: {employeeID} please select ID");
                }
            }
        }

        private void BTN_remove_Click(object sender, RoutedEventArgs e)
        {
            List<Employee> employees = database.employees;
            if (DTG_Employee.SelectedItem is Employee selectedEmployee)
            {
                int id = selectedEmployee.WorkerID;
                MessageBox.Show($"Selected ID: {id}");

                
                database.DeleteEmployee(selectedEmployee);
            }
            else
            {
                // Handle the case where no item is selected
                MessageBox.Show("No item selected.");
            }
            database.GetAllEmployees();
            DTG_Employee.ItemsSource = null;
            DTG_Employee.ItemsSource = employees;
        }

        private void DTG_Employee_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DTG_Employee.SelectedItem != null)
            {
                Employee selectedEmplyee = (Employee)DTG_Employee.SelectedItem;
                int selectedEmployeeId = selectedEmplyee.WorkerID;
                TB_ID_Select.Text = selectedEmployeeId.ToString();
            }
        }
    }
}
