using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserSingle
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        

        //Paketler
        public bool IsStandart { get; set; }
        public bool IsPlatinum { get; set; }
        public bool IsPremium { get; set; }

       
    }
}
