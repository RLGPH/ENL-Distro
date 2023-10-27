using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENL_Distrobution_Storage
{
    public class Employee
    {
        public int workerID { get; private set; }
        public int Amount { get; set; }
        public string Tlf { get; set; }
        public string FirstName {get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Jobtitel { get; set; }

        public Employee(int workeriD, int amount, string tlf, string firstName, string lastName, string email, string jobtitel)
        {
            workerID = workeriD;
            Amount = amount;
            Tlf = tlf;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Jobtitel = jobtitel;
        }
    }
}
