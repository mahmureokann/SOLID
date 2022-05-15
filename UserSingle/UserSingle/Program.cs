using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserSingle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Karşılama Mesajı
            Message.Greeting();

            //Bilgilendirme
            User user = UserRepository.AddUser();

            //Doğrulama
            bool isValid = UserValidator.Validator(user);
            if (!isValid)
            {
                Console.Read();
                return;
            }
            else
            {
                Message.Greeting();
            }
            //Console.Read();

            //Paket ekleme
            UserPaket.AddUserPaket();
            Console.Read();


            
        }
    }
}
