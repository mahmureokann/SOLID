using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAdminInterface
{
    public interface IManaged
    {
        void AddUser(User user);
        void RemoveUser(User user);
        
    }
}
