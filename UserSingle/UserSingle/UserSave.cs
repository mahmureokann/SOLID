using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserSingle
{
    public class UserSave
    {
        public static void Create(User user)
        {

            Console.WriteLine(user.UserName + " " + user.Password);

            Console.WriteLine("Kullanıcı kaydedildi!");
        }
    }
}
