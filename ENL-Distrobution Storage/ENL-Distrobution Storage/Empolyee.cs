using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENL_Distrobution_Storage
{
    public class Empolyee
    {
        public int ID;
        public int Amount;
        public string Tlf;
        public string FirstName;
        public string LastName;
        public string Email;
        public string Jobtitel;

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
