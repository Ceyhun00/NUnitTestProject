using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject
{
   public class Logindata
    {
        public Logindata(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public string Username { get; set; }

        public string Password { get; set; }
    }


}
