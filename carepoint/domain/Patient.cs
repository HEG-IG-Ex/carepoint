using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carepoint.domain
{
    internal class Patient : Person
    {

        public Insurance insurance { get; set; }

        public Patient(int id, string username, string firsname, string lastname, string tel, string mail, Insurance insurance) : base(id, username, firsname, lastname, tel, mail)
        {
            this.insurance = insurance;
        }

    }
}
