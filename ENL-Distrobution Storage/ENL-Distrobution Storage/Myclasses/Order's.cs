using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace ENL_Distrobution_Storage
{
    public class Order_s
    {
        public int OrdersID { get; private set; }
        public int ProduktID { get; private set; }
        public int OrderAmount { get; set; }
        public string Status { get; set; }
        public string Worker { get; set; }

        public Order_s(int ordersID, int produktID, int orderamount, string status, string worker) 
        {
            OrdersID = ordersID;
            ProduktID = produktID;
            OrderAmount = orderamount;
            Status = status;
            Worker = worker;
        }
    }
}
