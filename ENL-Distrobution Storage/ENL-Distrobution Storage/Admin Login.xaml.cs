using ENL_Distrobution_Storage;
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
    /// Interaction logic for Admin_Login.xaml
    /// </summary>
    public partial class Admin_Login : Window
    {
        readonly Database database;
        public Admin_Login()
        {
            InitializeComponent();
            database = new();
        }

        private void BTN_Admin_Login_Click(object sender, RoutedEventArgs e)
        {
            string Username = TB_Admin_User.Text;
            string Password1 = TB_Admin_Password_1.Text;
            string Password2 = TB_Password_2.Text;
            string seclevel = "Admin";
            bool Pass = database.Login(Password1, Username, Password2, seclevel);
            if (Pass == true)
            {
                Main_Page mainMenu = new(seclevel);
                mainMenu.Show();
                Close();
            }
            else if (Pass == false)
            {
                MessageBox.Show("The current back door code is (User: Admin) (FirstPassword: Admin)  (SecondPassword: Admin)" +
                                "\n if you type that in and then press login again you will get this text again just click OK");
                string BackDoor = "Admin";
                if (Username == BackDoor && Password1 == BackDoor && Password2 == BackDoor)
                {
                    MessageBox.Show(" this BackDoor will be removed when im completly done with the SQL Quory");
                    Main_Page mainMenu = new(seclevel);
                    mainMenu.Show();
                    Close();
                }
            }
        }

        private void BTN_Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new();
            main.Show();
            Close();
        }
    }
}
