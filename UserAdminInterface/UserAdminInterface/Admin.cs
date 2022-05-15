using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAdminInterface
{
    public class Admin : User, IManaged
    {
         
        public void AddUser(User user)
        {
            Console.WriteLine(user.UserName + " adlı kullanıcı eklendi \nMevcut şifre: "+user.Password);
            Console.WriteLine("Hoşgeldin "+user.UserName);
            Console.WriteLine("*****************************************************************");
           
        }

        public void RemoveUser(User user)
        {
           Console.WriteLine(user.UserName+ " adlı kullanıcı silindi!");
            Console.WriteLine("Hoşçakal "+user.UserName);
            Console.WriteLine("*************************************");
        }
    }
}
