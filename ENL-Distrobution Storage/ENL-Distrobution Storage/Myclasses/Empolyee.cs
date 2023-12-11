using System.Threading.Channels;

namespace ENL_Distrobution_Storage
{
    public class Employee
    {
        public int WorkerID { get; set; }
        public int Amount { get; set; }
        public string Tlf { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Jobtitel { get; set; }
        public WorkStatus Status { get; set; }

        public enum WorkStatus
        {
            Free,
            WorkingOnOrders,
            Busy
        }

        public Employee(int workerID, int amount, string tlf, string firstName, string lastName, string email, string jobtitel, WorkStatus status)
        {
            WorkerID = workerID;
            Amount = amount;
            Tlf = tlf;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Jobtitel = jobtitel;
            Status = status;
        }
    }
}