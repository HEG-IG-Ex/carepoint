using carepoint.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data;

namespace carepoint.factory
{
    internal class PersonFactory
    {

        private static readonly PersonFactory instance = new PersonFactory();

        private PersonFactory()
        {
        }

        // Public static property to access the singleton instance
        public static PersonFactory getInstance
        {
            get { return instance; }
        }

        public Person createPerson(DataRow person)
        {
            DataTable table = null;

            int id = Convert.ToInt16(person["PER_ID"]);
            Role role = (Role)Convert.ToInt16(person["PER_ROL_ID"]) - 1;
            string username = person["PER_USERNAME"].ToString();
            string firstname = person["PER_FIRSTNAME"].ToString();
            string lastname = person["PER_LASTNAME"].ToString();
            string tel = person["PER_TEL"].ToString();
            string mail = person["PER_MAIL"].ToString();

            switch (role)
            {
                case Role.Patient:
                    USR_DATA_DATASETTableAdapters.VW_PATIENTSTableAdapter patientTableAdapter = new USR_DATA_DATASETTableAdapters.VW_PATIENTSTableAdapter();
                    table = patientTableAdapter.GetDataById(id);
                    DataRow patient = table.Rows[0];
                    return new Patient(id, username, firstname, lastname, tel, mail, new Insurance(Convert.ToInt32(patient["PAT_INS_ID"]), patient["INS_NAME"].ToString()));
                case Role.Doctor:
                    USR_DATA_DATASETTableAdapters.VW_DOCTORSTableAdapter doctorTableAdapter = new USR_DATA_DATASETTableAdapters.VW_DOCTORSTableAdapter();
                    table = doctorTableAdapter.GetDataById(id);
                    DataRow doctor = table.Rows[0];
                    return new Doctor(id, username, firstname, lastname, tel, mail, Convert.ToDouble(doctor["DOC_FEE_PER_CONSULT"]), Convert.ToDateTime(doctor["DOC_START_WORK_DATE"]), new Specialty(Convert.ToInt32(doctor["DOC_SPE_ID"]), doctor["SPE_NAME"].ToString()));
                case Role.Admin:
                    //USR_DATA_DATASETTableAdapters.CRP_PERSONTableAdapter personTableAdapter = new USR_DATA_DATASETTableAdapters.CRP_PERSONTableAdapter();
                    //table = personTableAdapter.GetDataById(Convert.ToInt16(id));
                    return new Admin(id, username, firstname, lastname, tel, mail);
                default:
                    throw new ArgumentException("Invalid person type.");
            }
        }

        public Doctor createDoctor(DataRow row)
        {

            int id = Convert.ToInt32(row["PER_ID"]);
            string username = row["PER_USERNAME"].ToString();
            string firstName = row["PER_FIRSTNAME"].ToString();
            string lastName = row["PER_LASTNAME"].ToString();
            string tel = row["PER_TEL"].ToString();
            string email = row["PER_MAIL"].ToString();
            double feePerConsult = Convert.ToDouble(row["DOC_FEE_PER_CONSULT"]);
            DateTime startWorkDate = Convert.ToDateTime(row["DOC_START_WORK_DATE"]);
            int specialtyId = Convert.ToInt32(row["DOC_SPE_ID"]);
            string specialtyName = row["SPE_NAME"].ToString();

            Specialty specialty = new Specialty(specialtyId, specialtyName);
            return new Doctor(id, username, firstName, lastName, tel, email, feePerConsult, startWorkDate, specialty);
        }

        public Patient createPatient(DataRow row)
        {

            int id = Convert.ToInt32(row["PER_ID"]);
            string username = row["PER_USERNAME"].ToString();
            string firstName = row["PER_FIRSTNAME"].ToString();
            string lastName = row["PER_LASTNAME"].ToString();
            string tel = row["PER_TEL"].ToString();
            string email = row["PER_MAIL"].ToString();

            return new Patient(id, username, firstName, lastName, tel, email, new Insurance(Convert.ToInt32(row["PAT_INS_ID"]), row["INS_NAME"].ToString()));
        }
    }
}
