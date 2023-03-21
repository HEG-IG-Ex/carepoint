using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carepoint.business
{
    internal class User
    {
        private string username { get; set; }
        private string psw { get; set; }

        private string role { get; set; }

        public User(string username, string psw)
        {
            this.username = username;
            this.psw = psw;
            this.role = "patient";
        }
    }
}
