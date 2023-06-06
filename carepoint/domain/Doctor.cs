using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carepoint.domain
{
    public class Doctor : Person
    {
        public Doctor(int id, string username, string firsname, string lastname, string tel, string mail, double feePerConsult, DateTime startWorkDate, Specialty specialty) : base(id, username, firsname, lastname, tel, mail)
        {
            this.feePerConsult = feePerConsult;
            this.startWorkDate = startWorkDate;
            this.specialty = specialty;
        }

        public double feePerConsult { get; set; }
        public DateTime startWorkDate { get; set; }
        public Specialty specialty { get; set; }
    }
}
