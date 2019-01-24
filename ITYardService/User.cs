using System;
using System.Security.Cryptography;
using System.Text;

namespace ITYardService
{
    public class User
    {
       
        public string _username;
        public string _password { get; set; }
        public Guid _id;
        public User()
        {
            this._id = Guid.NewGuid();
        }

        public User(string username, string password) : this()
        {
            this._username = username;
            this._password = StringUtil.Crypt(password);
        }


        public void DisplayInfo()
        {
            Console.WriteLine($"Username - {this._username} and password - {this._password}");
        }

                      
    }
}
