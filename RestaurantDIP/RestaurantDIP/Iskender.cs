using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDIP
{
    public class Iskender : IProduct
    {
        public string IskenderAd { get; set; }
        public void GetMalzeme()
        {
            Console.WriteLine("İskender malzemeleri bıdı bıdı");
            Console.ReadLine();
        }
    }
}
