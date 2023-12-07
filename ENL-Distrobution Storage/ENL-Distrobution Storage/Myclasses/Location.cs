namespace ENL_Distrobution_Storage
{
    
    public class Location
    {
        public int LocationID { get; set; }
        public int Row { get; set; }

        public int Shelf { get; set; }

        public Location(int row, int shelf, int locationID)
        {
            LocationID = locationID;
            Row = row;
            Shelf = shelf;   
        }
    }
}
