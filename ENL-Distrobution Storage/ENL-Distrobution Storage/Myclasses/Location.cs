namespace ENL_Distrobution_Storage
{
    public class Location
    {
        public int Row { get; set; }

        public int Shelf { get; set; }

        public Location(int row, int shelf, string Place)
        {
            Row = row;
            Shelf = shelf;
            Place = row + "," + shelf;
        }
    }
}
