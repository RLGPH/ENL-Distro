namespace ENL_Distrobution_Storage
{
    public class Order_s
    {
        public int OrdersID { get; set; }
        public int ProduktID { get; set; }
        public int OrderAmount { get; set; }
        public string Status { get; set; }
        public string Worker { get; set; }

        public Order_s(int ordersID, int produktID, int orderAmount, string status, string worker)
        {
            OrdersID = ordersID;
            ProduktID = produktID;
            OrderAmount = orderAmount;
            Status = status;
            Worker = worker;
        }
    }
}
