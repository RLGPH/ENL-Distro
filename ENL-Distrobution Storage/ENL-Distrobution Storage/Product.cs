﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENL_Distrobution_Storage
{
    public class Product
    {
        public int ID { get; set; }

        public int Antal { get; set; }

        public int Location { get; set; }

        public string ProductName { get; set; }

        public string Description { get; set; }

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