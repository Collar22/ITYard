using System;
using System.Collections.Generic;
using System.Linq;

namespace ITYardService
{
    public class UserRepository
    {
        public static Dictionary<Guid, User> _users = new Dictionary<Guid, User>();

        public User[] All()
        {
            return _users.Values.ToArray();
        }
        public void Insert(User user)
        {
            _users.Add(user._id, user);
        }
        public void GetById(Guid _id)
        {
            /* return copy @user
            var user = new User();
            user = _users[_id];
            Console.WriteLine($"this user {user._username} and password {user._password}");
            */
            Console.WriteLine($"this user {_users[_id]._username} and password {_users[_id]._password}");
        }

        public bool Update(Guid _id, User user)
        {
            _users[_id] = user;
            return true;
        }
        public bool HardUpdate(Guid _id)
        {
            _users[_id] = new User("HardUpdate", "Password");
            return true;
        }

        public bool Delete(Guid _id)
        {
            if (_id != null)
            {
                _users.Remove(_id);
                return true;
            }
            return false;
        }

        public void DisplayUserInfo(Guid _id)
        {
            Console.WriteLine($"Username - {_users[_id]._username} and password - {_users[_id]._password}");
        }


    }
}
