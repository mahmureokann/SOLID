using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAdminInterface
{
    public class User:IComment
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public void AddComment(string comment)
        {
            Console.WriteLine("User Name: "+UserName+" "+ "\nYorum: " + comment);
            Console.WriteLine("**************************************************");

        }










       // public User Admin { get; set; }

    }
}
