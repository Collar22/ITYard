using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITYardService
{
    public class User
    {
        public Guid _id;
        string _username;
        string _password { get; set; }

        public User()
        {
            this._id = Guid.NewGuid();
        }

        public User(string username, string password):this()
        {
            this._username = username;
            this._password = password;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Username - {this._username} and password - {this._password}");
        }
    }
}
