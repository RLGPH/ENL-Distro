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
    /// Interaction logic for EmployeeAddwindow.xaml
    /// </summary>
    public partial class EmployeeAddwindow : Window
    {
        Database database = new();
        Employee Employee;
        public EmployeeAddwindow(Employee employees)
        {
            InitializeComponent();
            database.GetEmployeeById(employees);
            if (employees.WorkerID > 0)
            {
                List<Employee> oneEmployees = database.oneEmployees;
                var extemployee = oneEmployees.Select(employee => new
                {
                    employee.WorkerID,
                    employee.FirstName,
                    employee.LastName,
                    employee.Tlf,
                    employee.Amount,
                    employee.Email,
                    employee.Jobtitel,
                    employee.Status
                }).ToList();

                TB_First_name.Text = extemployee.First().FirstName;
                TB_Last_Name.Text = extemployee.First().LastName;
                TB_Job_Tital.Text = extemployee.First().Jobtitel;
                TB_Mail.Text = extemployee.First().Email;
                TB_Tlf_number.Text = extemployee.First().Tlf;
                int WorkID =extemployee.First().WorkerID;
                TB_ID.Text = WorkID.ToString();
                
            }
        }

        private void BTN_ADD_Click(object sender, RoutedEventArgs e)
        {
            string FName = TB_First_name.Text;
            string LName = TB_Last_Name.Text;
            string TLF = TB_Tlf_number.Text;
            string mail = TB_Mail.Text;
            string Jobtitel = TB_Job_Tital.Text;

            Employee newemployee = new(0, 0, TLF, FName, LName, mail, Jobtitel, 0);
            database.ADDEmployee(newemployee);

            DialogResult = true;
            Close();
        }

        private void BTN_Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BTN_Save_Change_Click(object sender, RoutedEventArgs e)
        {
            string FName = TB_First_name.Text;
            string LName = TB_Last_Name.Text;
            string TLF = TB_Tlf_number.Text;
            string mail = TB_Mail.Text;
            string Jobtitel = TB_Job_Tital.Text;
            int ID = int.Parse(TB_ID.Text);

            Employee editemployee = new(ID,Employee.Amount,TLF,FName,LName,mail,Jobtitel,0);

        }
    }
}
