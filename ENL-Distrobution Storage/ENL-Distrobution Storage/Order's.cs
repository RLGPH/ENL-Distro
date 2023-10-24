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
        int OrdersID;
        int ProduktID;
        int OrderAmount;
        string Status;
        string Worker;
        
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
