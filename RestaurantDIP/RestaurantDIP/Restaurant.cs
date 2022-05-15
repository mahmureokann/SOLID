using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDIP
{
    public class Restaurant
    {
        private List<IProduct> _product;
        public Restaurant(List<IProduct> products)
        {
            _product = products;
        }

        void GetRes()
        {
            foreach (IProduct product in _product)
            {
                product.GetMalzeme();
            }
        }
    }
}
