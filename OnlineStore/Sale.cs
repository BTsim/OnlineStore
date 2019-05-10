using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    class Sale
    {
        public int SalePercent { get; set; }
        public List<Product> DiscountProducts { get; set; }
    }
}
