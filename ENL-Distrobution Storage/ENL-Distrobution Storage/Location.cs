using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENL_Distrobution_Storage
{
    public class Location
    {
        public int Row;

        public int Shelf;

        public Location(int row, int shelf)
        {
            Row = row;
            Shelf = shelf;
        }
    }
}
