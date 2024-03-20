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
            //used to get the employees list from the database
            List<Employee> employee = database.employees;
            database.GetAllEmployees();
            DTG_Employee.ItemsSource = employee;
        }

        private void BTN_add_Click(object sender, RoutedEventArgs e)
        {
            //opens the employee window and waits for it to send a true or false
            EmployeeAddwindow employeeaddwindow = new(employee);
            bool? resault = employeeaddwindow.ShowDialog();
            if (resault == true) 
            {
                //if its true then it gets to data from the database and redoes the list then gives it back to the DTG
                List<Employee> employee = database.employees;
                database.GetAllEmployees();
                DTG_Employee.ItemsSource = null;
                DTG_Employee.ItemsSource = employee;
            }
        }

        private void BTN_close_window_Click(object sender, RoutedEventArgs e)
        {
            //just a button for the people that are nervus about just closeing the page
            Close();
        }

        private void BTN_edit_Click(object sender, RoutedEventArgs e)
        {
            //takes id from the Text box and checks if there is anything in it
            string EditID = TB_ID_Select.Text;
            if (EditID != null)
            {
                //if there its changed to an int maybe should give it a safety net 
                if (int.TryParse(EditID, out int employeeID ) && employeeID > 0)
                {
                    //splits everything from the selected item
                    Employee employee = (Employee)DTG_Employee.SelectedItem;
                    int amount = employee.Amount;
                    string tlf = employee.Tlf;
                    string FName = employee.FirstName;
                    string LName = employee.LastName;
                    string Mail = employee.Email;
                    string titel = employee.Jobtitel;
                    var status = employee.Status;
                    string user = employee.Username;
                    string Password = employee.Password;
                    string AdminPassword = employee.AdminPassword;
                    string userrank = employee.UserRank;

                    //gives the split item to the employeeaddwindow
                    Employee employees = new(employeeID, amount, tlf, FName, LName, Mail, titel, status, user, Password, AdminPassword, userrank);
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
                    MessageBox.Show("Bad ID please select a different ID");
                }
            }
            else 
            {
                MessageBox.Show("if your trying to edit one the employees you might need to " +
                                "either write an ID or click on an employee");
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
                //this is so can click on an employee but its not needed for the operation of editing with the ID
                //its just here for options 
                Employee selectedEmplyee = (Employee)DTG_Employee.SelectedItem;
                int selectedEmployeeId = selectedEmplyee.WorkerID;
                TB_ID_Select.Text = selectedEmployeeId.ToString();
            }
        }
    }
}
