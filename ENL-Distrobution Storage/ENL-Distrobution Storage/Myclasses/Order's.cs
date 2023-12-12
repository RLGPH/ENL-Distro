namespace ENL_Distrobution_Storage
{
    public class Order_s
    {
        public int OrdersID { get; set; }
        public int ProduktID { get; set; }
        public int WorkerID { get; set; }
        public int OrderAmount { get; set; }
        public string NWorker { get; set; }
        public string NProduct {  get; set; }
        public OrderStatus OStatus { get; set; }

        public enum OrderStatus
        {
            Pending_Work,
            Being_Worked_On,
            Finished
        }

        public Order_s(int ordersID, int produktID, int orderAmount,string nproduct, string nworker, OrderStatus Ostatus, int workerID)
        {
            OrdersID = ordersID;
            ProduktID = produktID;
            OrderAmount = orderAmount;
            OStatus = Ostatus;
            NWorker = nworker;
            WorkerID = workerID; 
            NProduct = nproduct;
        }
    }
}
