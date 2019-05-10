using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    class Account
    {
       User ShopUser { get; set; }
       public List<Order> CurrentOrders { get; set; }
       public List<Order> PreviousOrders { get; set; }
       public Sale CurrentSaleRate { get;set; }
    }
}
