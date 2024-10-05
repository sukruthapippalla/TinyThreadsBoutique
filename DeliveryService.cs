using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyThreadsBoutique
{
    public class DeliveryService
    {
        //Method to place the order if the stock is available
        public bool PlaceOrder(Product product)
        {
            if(product.Stock > 0)
            {
                return true;
            }
            else
            {
                throw new ProductOutOfStockException();
            }
        }
    }
}
