using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDIP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hamburger hamburger = new Hamburger();
            hamburger.HamAd = "BigAdam Hamburger";

            Mantı mantı = new Mantı();
            mantı.MantıAd = "BigMantı";

            Iskender ıskender = new Iskender();
            ıskender.IskenderAd = "Bigİskender";

            List<IProduct> products = new List<IProduct>();
            products.Add(hamburger);
            products.Add(mantı);
            products.Add(ıskender);

            Restaurant restaurant = new Restaurant(products);

            restaurant.GetRes();

            Console.Read();

        }
    }
}
