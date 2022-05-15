using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserSingle
{
    public class UserValidator
    {
        public static bool Validator(User user)
        {
            if (string.IsNullOrWhiteSpace(user.UserName))
            {
                Message.ErrorGreeting("Kullanıcı Adı");
                return false;

            }
            if (string.IsNullOrWhiteSpace(user.Password))
            {
                Message.ErrorGreeting("Şifre");
                return false;
            }
            return true; //Bunun dışındakiler doğru dönecek.
        }
    }
}
