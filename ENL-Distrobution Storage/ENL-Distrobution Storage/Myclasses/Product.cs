namespace ENL_Distrobution_Storage
{
    public class Product
    {
        public int ID { get; set; }
        public int Amount { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public Product(int id, int amount, string productName, string description)
        {
            ID = id;
            Amount = amount;
            ProductName = productName;
            Description = description;
        }
    }
}