using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDIP
{
    public class Mantı : IProduct
    {
        public string MantıAd { get; set; }
        public void GetMalzeme()
        {
            Console.WriteLine("Mantı malzemeleri bıdı bıdı");
            Console.ReadLine();
        }
    }
}
