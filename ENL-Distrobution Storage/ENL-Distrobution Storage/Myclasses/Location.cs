namespace ENL_Distrobution_Storage
{
    
    public class Location
    {
        public string PLocationID {  get; private set; }
        public int Row { get; set; }

        public int Shelf { get; set; }

        public Location(int row, int shelf,string pLocationID)
        {
            Row = row;
            Shelf = shelf;
            PLocationID = pLocationID;
        }
    }
}
