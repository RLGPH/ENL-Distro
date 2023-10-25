using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENL_Distrobution_Storage
{
    public class Product
    {
        public int ID;

        public int Antal;

        public int Location;

        public string ProductName;

        public string Description;

        public Product(int id, int antal, int location, string productName, string description) 
        {
            ID = id;
            
            Antal = antal;
            
            Location = location;
            
            ProductName = productName;

            Description = description;   
        }
    }
}
