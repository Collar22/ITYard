using ITYardService.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace ITYardService
{
    
    public class UserRepository: IRepository
    {
        public static Dictionary<Guid, User> _users = new Dictionary<Guid, User>();
        private Logger logger = new Logger();
        public User[] All()
        {
            return _users.Values.ToArray();
        }
        public bool Insert(User user)
        {
            _users.Add(user._id, user);
            this.logger.LogInfo($"Add {user._username} with id - {user._id} to repository");
            return true;
        }
        public User GetById(Guid _id)
        {
            // return copy @user
           
          var user = _users[_id];
            Console.WriteLine($"this user {user._username} and password {user._password}");
            return user;
            
           // Console.WriteLine($"this user {_users[_id]._username} and password {_users[_id]._password}");
        }

        public void Update(Guid _id, User user)
        {
            _users[_id] = user;
            
        }
        public bool HardUpdate(Guid _id)
        {
            _users[_id] = new User("HardUpdate", "Password");
            return true;
        }

        public bool Delete(Guid _id)
        {
            if (_users.ContainsKey(_id))
            {
                this.logger.LogError($"Delete {DateTime.UtcNow} with id - {_id}");
                _users.Remove(_id);
                return true;
            }
            return false;
        }

        public void DisplayUserInfo(Guid _id)
        {
            Console.WriteLine($"Username - {_users[_id]._username} and password - {_users[_id]._password}");
        }

        List<object> IRepository.All()
        {
            throw new NotImplementedException();
        }

        private Dictionary<Guid, object> database;
        public void Insert(object item)
        {
            var entity = item as EntityBase;
            if (entity != null)
            {
                if (!database.ContainsKey(entity.Id))
                {
                    database.Add(entity.Id, entity);
                }
            }
        }       

        public void Update(Guid id, object item)
        {
            var entity = item as EntityBase;
            if (entity != null)
            {
                if (!database.ContainsKey(entity.Id))
                {
                    database[entity.Id] = entity;
                }
            }

        }

        object IRepository.GetById(Guid id)
        {
            var entity = database[id];
            if (!database.ContainsKey(id))
            {
                return entity;
            }
            return null;
        }
    }
}
