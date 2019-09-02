using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTWINFORM
{
    class LoginObject
    {

        public LoginObject()
        {

        }
        public LoginObject(string u, string p)
        {
            Username = u;
            Password = p;
        }
        string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
