using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDIP
{
    public class Hamburger : IProduct
    {
        public string HamAd { get; set; }
        public void GetMalzeme()
        {
            Console.WriteLine("Hamburger malzemeleri bıdı bıdı");
            Console.ReadLine();
        }
    }
}
