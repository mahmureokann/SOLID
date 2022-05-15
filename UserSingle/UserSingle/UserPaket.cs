using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserSingle
{
    public class UserPaket
    {
        public static void AddUserPaket()
        {
            User user = new User();
            Console.WriteLine("Lütfen bir üyelik paketi seçiniz. Standart , Platinum , Premium");
            
            string value = Console.ReadLine();

            if (value == "Standart".ToLower())
            {
                user.IsStandart = true;
                Console.WriteLine("Standart paket seçildi");
            }
            else if (value == "Platinum".ToLower())
            {
                user.IsPlatinum = true;
                Console.WriteLine("Platinum paket seçildi");
            }
            else if (value == "Premium".ToLower())
            {
                user.IsPremium = true;
                Console.WriteLine("Premium paket seçildi");
            }
            else
            {
                Message.ErrorPacket();
            }

            Console.Read();

        }




    }
}
