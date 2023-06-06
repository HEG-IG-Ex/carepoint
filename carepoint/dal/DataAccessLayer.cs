using carepoint.domain;
using carepoint.factory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carepoint.dao
{
    internal class DataAccessLayer
    {

        private static readonly DataAccessLayer instance = new DataAccessLayer();

        private DataAccessLayer()
        {
            
        }

        // Public static property to access the singleton instance
        public static DataAccessLayer getInstance
        {
            get { return instance; }
        }

        public Boolean createNewAppointment(Appointment app)
        {
            try
            {
                USR_DATA_DATASETTableAdapters.CRP_APPOINTMENTTableAdapter appTableAdapter = new USR_DATA_DATASETTableAdapters.CRP_APPOINTMENTTableAdapter();
                appTableAdapter.create(app.patient.id, app.doctor.id, app.appointmentDate, app.desc);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error canceling appointment: " + ex.Message);
                return false;
            }
        }

        public Boolean cancelAppointment(int appId, String cancelReason)
        {
            try
            {
                USR_DATA_DATASETTableAdapters.CRP_APPOINTMENTTableAdapter appTableAdapter = new USR_DATA_DATASETTableAdapters.CRP_APPOINTMENTTableAdapter();
                appTableAdapter.cancel(cancelReason, appId);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error canceling appointment: " + ex.Message);
                return false;
            }
        }
    }
}

