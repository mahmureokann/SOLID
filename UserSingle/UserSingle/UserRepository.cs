using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserSingle
{
    public class UserRepository
    {
        public static User AddUser()
        {
            User user = new User();

            Console.WriteLine("Lütfen kullanıcı adı giriniz!");
            user.UserName = Console.ReadLine();

            Console.WriteLine("Lütfen şifre giriniz!");
            user.Password = Console.ReadLine();
            
            return user;


        }
    }
}
