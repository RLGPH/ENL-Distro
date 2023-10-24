using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENL_Distrobution_Storage
{
    public class Empolyee
    {
        int ID;
        int Amount;
        string Tlf;
        string FirstName;
        string LastName;
        string Email;
        string Jobtitel;

        public Empolyee(int iD, int amount, string tlf, string firstName, string lastName, string email, string jobtitel)
        {
            ID = iD;
            Amount = amount;
            Tlf = tlf;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Jobtitel = jobtitel;
        }
    }
}
