using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carepoint.domain
{
    public enum Role
    {
        Admin,
        Patient,
        Doctor,

    }
    internal abstract class Person
    {
        public int id { get; private set; }
        public string username { get; private set; }

        public string firsname { get; private set; }

        public string lastname { get; private set; }

        public string tel { get; private set; }

        public string mail { get; private set; }

        protected Person(int id, string username, string firsname, string lastname, string tel, string mail)
        {
            this.id = id;
            this.username = username;
            this.firsname = firsname;
            this.lastname = lastname;
            this.tel = tel;
            this.mail = mail;
        }
    }
}
