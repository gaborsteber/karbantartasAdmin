using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karbantartasAdmin
{
    class Login
    {
        private string username;
        private string password;
        private string token;

        public Login()
        {
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Token { get => token; set => token = value; }
    }
}
