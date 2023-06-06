using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carepoint.domain
{
    public class Appointment
    {
        public int id { get; set; }
        public DateTime appointmentDate { get; set; }
        public Patient patient { get; set; }
        public Doctor doctor { get; set; }
        public bool isCancelled { get; set; }
        public DateTime? cancellationDate { get; set; }
        public String desc { get; set; }

        public Appointment(DateTime appointmentDate, Patient patient, Doctor doctor, String desc)
        {
            this.appointmentDate = appointmentDate;
            this.patient = patient;
            this.doctor = doctor;
            this.desc = desc;
        }
    }
}
