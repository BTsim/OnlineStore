using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    class Order
    {
        public List<Product> ProductsInOrder { get; set; }
        public Int32 OrderNumber { get; set; }
        public string OrderTime { get; set; }
        Account account { get; set; }
        public string Adress { get; set; }
        Sale SaleRate { get; set; };

    }
}
