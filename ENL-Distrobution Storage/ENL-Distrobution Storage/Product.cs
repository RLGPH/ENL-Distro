using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENL_Distrobution_Storage
{
    public class Product
    {
        public int ID { get; private set; }

        public int Antal { get; set; }

        public int Location { get; set; }

        public decimal Price {  get; set; }

        public string ProductName { get; set; }

        public string Description { get; set; }

        public Product(int id, int antal, int location, decimal price, string productName, string description) 
        {
            ID = id;
            
            Antal = antal;

            Location = location;

            Price = price;
            
            ProductName = productName;

            Description = description;   
        }
    }
}