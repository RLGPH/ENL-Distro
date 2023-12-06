namespace ENL_Distrobution_Storage
{
    public class Product
    {
        public int ProductID { get; set; }
        public int ProductAmount { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string FormattedLocation => $"{ProductLocation?.Row}.{ProductLocation?.Shelf}";

        public Location ProductLocation { get; set; }

        public Product(int productId, int productAmount, string productName, string productDescription, Location productLocation)
        {
            ProductID = productId;
            ProductAmount = productAmount;
            ProductName = productName;
            ProductDescription = productDescription;
            ProductLocation = productLocation;
        }
    }
}