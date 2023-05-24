using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carepoint.domain
{
    internal class Admin : Person
    {
        public Admin(int id, string username, string firsname, string lastname, string tel, string mail) : base(id, username, firsname, lastname, tel, mail)
        {
        }
    }
}
