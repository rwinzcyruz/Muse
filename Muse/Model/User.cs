using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Muse.Model
{
    static class User
    {
        public static bool Login(string username, string password)
        {
            if (username == "admin" && password == "admin")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
