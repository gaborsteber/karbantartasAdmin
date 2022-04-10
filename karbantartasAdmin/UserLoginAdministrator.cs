using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karbantartasAdmin
{
    public static class UserLoginAdministrator
    {
        public static bool _LoginOK { get; set; }
        public static int _userId { get; set; }
        public static string _username { get; set; }
        public static string _fullName { get; set; }
        public static int _roleId {get;set;}
        public static int _occupationId { get; set; }
        public static string _token { get; set; }
    }
}
