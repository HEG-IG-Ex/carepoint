using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carepoint.domain
{
    public class Appointment
    {
        public enum Status
        {
            OPEN,
            CANCELLED,
            INVOICED
        }
        public int id { get; set; }
        public DateTime appointmentDate { get; set; }
        public Patient patient { get; set; }
        public Doctor doctor { get; set; }
        public string cancellationReason { get; set; }
        public DateTime? cancellationDate { get; set; }
        public Boolean isInvoiced { get; set; }
        public String desc { get; set; }

        public Appointment(int id, DateTime appointmentDate, Patient patient, Doctor doctor, string cancellationReason, DateTime? cancellationDate, Boolean isInvoiced, String desc)
        {
            this.id = id;   
            this.appointmentDate = appointmentDate;
            this.patient = patient;
            this.doctor = doctor;
            this.cancellationReason = cancellationReason;
            this.cancellationDate = cancellationDate;
            this.isInvoiced = isInvoiced;
            this.desc = desc;
        }

        public Appointment(DateTime appointmentDate, Patient patient, Doctor doctor, String desc)
        {
            this.appointmentDate = appointmentDate;
            this.patient = patient;
            this.doctor = doctor;
            this.desc = desc;
        }

        public Appointment(DateTime appointmentDate, Patient patient, Doctor doctor)
        {
            this.appointmentDate = appointmentDate;
            this.patient = patient;
            this.doctor = doctor;
        }



        public Status getStatus()
        {
            if(cancellationDate == null && !isInvoiced)
            {
                return Status.OPEN;
            } else if (cancellationDate != null)
            {
                return Status.CANCELLED;
            }
            else if(isInvoiced)
            {
                return Status.INVOICED;
            }

            return Status.OPEN;
            
        }
    }
}
