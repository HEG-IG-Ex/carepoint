using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carepoint.business
{
    public enum Role
    {
        Patient,
        Doctor,
        Admin
    }
    internal class User
    {
        public string username { get; private set; }
        public string psw { get; private set; }

        public Role role { get; private set; }

        public User(string username, string psw, Role role)
        {
            this.username = username;
            this.psw = psw;
            this.role = role;
        }
    }
}
