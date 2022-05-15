using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAdminInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             
             --interface segregation--
            Tek bir interface yerine kullanımlarına göre parçalanmış birden fazla interface ile işlemleri yürütmeliyiz. Yani her farklı sorumluluğun kendine özgü bir arayüzü 
            olması gerekmektedir. Böylece interface’i kullanan kişide sadece ihtiyacı olanlarla ilgilenmiş olur. Birden fazla amaç için yalnızca bir arayüzümüz var ise buna 
            gerektiğinden fazla method ya da özellik ekliyoruz demektir, bu da IS prensibine aykırı davrandığınız anlamına gelir..

             */


            //user
            User user = new User();
            user.UserName = "İstanbulleCocuq34";
            user.Password = "1234";
            user.AddComment("Ahaha bu ne biçim çimen!");

            User user2= new User();
            user2.UserName = "Ponçik Sılağğ";
            user2.Password = "1234";
            user2.AddComment("Çayır çimen geze geze oy!");

            //Admin
            Admin admin = new Admin();
            admin.UserName = "Admin34";
            admin.Password = "1234";
            admin.RemoveUser(user);

            Admin admin2 = new Admin();
            admin2.UserName = "Kral";
            admin2.Password = "Kral123";
            admin2.AddUser(user2);


            Console.Read();
        }
    }
}
