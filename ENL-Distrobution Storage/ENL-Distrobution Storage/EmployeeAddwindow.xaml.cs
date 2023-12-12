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
            if (employees != null)
            {
                if (employees.WorkerID > 0)
                {
                    int id = employees.WorkerID;
                    int amount = employees.Amount;
                    string FName = employees.FirstName;
                    string LName = employees.LastName;
                    string TLF = employees.Tlf;
                    string Mail = employees.Email;
                    string titel = employees.Jobtitel;

                    int statusint = (int)employees.Status;

                    CB_Status.SelectedIndex = statusint;

                    TB_First_name.Text = FName;
                    TB_Last_Name.Text = LName;
                    TB_Job_Tital.Text = titel;
                    TB_Mail.Text = Mail;
                    TB_Tlf_number.Text = TLF;
                    TB_ID.Text = id.ToString();
                    TB_Completed_oreders.Text = amount.ToString();
                }
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
            int amount = int.Parse(TB_Completed_oreders.Text);

            ComboBoxItem employeeStatus = (ComboBoxItem)CB_Status.SelectedItem;
            int statusint = Convert.ToInt32(employeeStatus.Tag);

            Employee.WorkStatus status = (Employee.WorkStatus)statusint;

            Employee editemployee = new Employee(ID, amount, TLF, FName, LName, mail, Jobtitel, status);
            database.UpdateEmployee(editemployee);

            DialogResult = true;
            Close();
        }
    }
}
