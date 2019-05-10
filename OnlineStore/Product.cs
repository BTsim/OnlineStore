using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    class Product
    {
        public string ProductName { get; set; }
        public Int32 ProductId { get; set; }
        public double ProductPrice { get; set; }

        public void PriceChecker(Product product1, Product product2)
        {
            if (product1 > product2)
            {
                Console.WriteLine($"{product1}>{product2}");
            }
            else if (product1 == product2)
            {
                Console.WriteLine($"{product1}={product2}");
            }
            else
            {
                Console.WriteLine($"{product1}<{product2}");
            }
        }

        public static bool operator ==(Product prod1, Product prod2)
        {
            if (prod1.ProductPrice == prod2.ProductPrice)
            {
                return true;
            }
            return false;
        }



        public static bool operator !=(Product prod1, Product prod2)
        {
            if (prod1.ProductPrice != prod2.ProductPrice)
            {
                return true;
            }
            return false;
        }

        public static bool operator >(Product prod1, Product prod2)

        {
            return prod1.ProductPrice > prod2.ProductPrice;
        }

        public static bool operator <(Product prod1, Product prod2)
        {
            return prod1.ProductPrice < prod2.ProductPrice;
        }
    }
}
}
