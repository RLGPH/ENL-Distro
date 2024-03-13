﻿using System;
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
        readonly Database database = new();

        public EmployeeAddwindow(Employee employees)
        {
            InitializeComponent();
            //makes sure only truly intialize this data when the if statemeants have been forfilled since if the if
            //statemeants wasnt here the programe would just die
            if (employees != null)
            {
                if (employees.WorkerID > 0)
                {
                    //gets all of the transferred data
                    int id = employees.WorkerID;
                    int amount = employees.Amount;
                    string FName = employees.FirstName;
                    string LName = employees.LastName;
                    string TLF = employees.Tlf;
                    string Mail = employees.Email;
                    string titel = employees.Jobtitel;

                    //makes sure status combobox is indexed to the right tag
                    int statusint = (int)employees.Status;
                    CB_Status.SelectedIndex = statusint;

                    //gives the data to the textboxes
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
            //make a completly new employee gets the data from the textboxes
            string FName = TB_First_name.Text;
            string LName = TB_Last_Name.Text;
            string TLF = TB_Tlf_number.Text;
            string mail = TB_Mail.Text;
            string Jobtitel = TB_Job_Tital.Text;

            //combinds and then uses the addemployee method and gives that data to it 
            Employee newemployee = new(0, 0, TLF, FName, LName, mail, Jobtitel, 0);
            database.ADDEmployee(newemployee);

            //give the true result to the previus page so it can reload the DTG then closes the page
            DialogResult = true;
            Close();
        }

        private void BTN_Cancel_Click(object sender, RoutedEventArgs e)
        {
            //once again for the nervus people
            Close();
        }

        private void BTN_Save_Change_Click(object sender, RoutedEventArgs e)
        {
            //gets all the data like before but now it has an ID and amount that currently amounts to nothing badum chh
            string FName = TB_First_name.Text;
            string LName = TB_Last_Name.Text;

            string TLF = TB_Tlf_number.Text;
            string mail = TB_Mail.Text;
            
            string Jobtitel = TB_Job_Tital.Text;
            int ID = int.Parse(TB_ID.Text);
            int amount = int.Parse(TB_Completed_oreders.Text);

            //get the combobox and makes an int that then is converted to employee.workstatus because an int cant 
            //from what the compiler tells be used direclty with an enum to select which it is
            ComboBoxItem employeeStatus = (ComboBoxItem)CB_Status.SelectedItem;
            int statusint = Convert.ToInt32(employeeStatus.Tag);

            Employee.WorkStatus status = (Employee.WorkStatus)statusint;

            //this joins the data back together and then sends it to the update method which then
            //sends it to the database
            Employee editemployee = new(ID, amount, TLF, FName, LName, mail, Jobtitel, status);
            database.UpdateEmployee(editemployee);

            //dialog true to reload the page from before
            DialogResult = true;
            Close();
        }
    }
}
