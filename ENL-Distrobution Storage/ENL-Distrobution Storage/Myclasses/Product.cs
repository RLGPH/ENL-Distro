namespace ENL_Distrobution_Storage
{
    public class Product
    {
        public int ID { get; private set; }

        public int Amount { get; set; }

        public int PLocation { get; set; }

        public string ProductName { get; set; }

        public string Description { get; set; }

        public Product(int amount, int plocation, string productName, string description)
        {
            Amount = amount;

            PLocation = plocation;

            ProductName = productName;

            Description = description;
        }
    }
}