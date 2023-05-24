using carepoint.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using carepoint.domain;
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
        public static PersonFactory Instance
        {
            get { return instance; }
        }

        public Person CreateUser(Role role, DataRow dr)
        {
            int id = Convert.ToInt32(dr["id"]);
            string username = dr["per_username"].ToString();
            string firstname = dr["UserType"].ToString();
            string lastname = dr["UserType"].ToString();
            string tel = dr["tel"].ToString();
            string mail = dr["mail"].ToString();

            switch (role)
            {
                case Role.Patient:
                    return new Patient(id, username, firstname, lastname, tel, mail, new Insurance(Convert.ToInt32(dr["ins_id"]), dr["ins_name"].ToString()));
                case Role.Doctor:
                    return new Doctor(id, username, firstname, lastname, tel, mail, Convert.ToDouble(dr["doc_fee_per_consult"]), Convert.ToDateTime(dr["doc_start_work_date"]), new Specialty(Convert.ToInt32(dr["spe_id"]), dr["spe_name"].ToString()));
                case Role.Admin:
                    return new Admin(id, username, firstname, lastname, tel, mail);
                default:
                    throw new ArgumentException("Invalid user type.");
            }
        }
    }
}
