using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTTest
{
    public class UserModel
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public UserModel()
        {
            Username = String.Empty;
            Password = String.Empty;
        }
    }
}
