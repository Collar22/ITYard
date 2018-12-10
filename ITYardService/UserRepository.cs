using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITYardService
{
    public class UserRepository
    {
        public static Dictionary<Guid, User> _user = new Dictionary<Guid, User>();

        public User[] All()
        {
            return _user.Values.ToArray();
        }
        public void Insert(User user)
        {
            _user.Add(user._id, user);
        }
    }
}
