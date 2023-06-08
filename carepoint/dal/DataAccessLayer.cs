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

        public Boolean updateDesc(String updateDesc, int appId)
        {
            try
            {
                USR_DATA_DATASETTableAdapters.CRP_APPOINTMENTTableAdapter appTableAdapter = new USR_DATA_DATASETTableAdapters.CRP_APPOINTMENTTableAdapter();
                appTableAdapter.updateDesc(updateDesc, appId);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating appointment: " + ex.Message);
                return false;
            }
        }

        public Appointment getAppointmentById(int appId)
        {
            USR_DATA_DATASETTableAdapters.CompleteAppointmentTableAdapter appTableAdapter = new USR_DATA_DATASETTableAdapters.CompleteAppointmentTableAdapter();
            DataTable compAppTable = appTableAdapter.GetById(appId);


            if (compAppTable.Rows.Count == 1)
            {
                DataRow appRow = compAppTable.Rows[0];
                int docId = Convert.ToInt16(appRow["APP_DOC_ID"]);
                int patId = Convert.ToInt16(appRow["APP_PAT_ID"]);
                DateTime createdDate = Convert.ToDateTime(appRow["APP_CREATED_DATE"]);
                DateTime appDate = Convert.ToDateTime(appRow["APP_APTN_DATE"]);
                string cnlReason = appRow.Field<string>("APP_CNL_REASON");
                DateTime? cnlDate = appRow.Field<DateTime?>("APP_CNL_DATE");
                Boolean isInvoiced = Convert.ToInt16(appRow["APP_IS_INVOICED"]) == 1;
                string desc = appRow["APP_DESC"].ToString();

                int id = Convert.ToInt32(appRow["PAT_ID"]);
                string username = appRow["PAT_USERNAME"].ToString();
                string firstName = appRow["PAT_FIRSTNAME"].ToString();
                string lastName = appRow["PAT_LASTNAME"].ToString();
                string tel = appRow["PAT_TEL"].ToString();
                string email = appRow["PAT_MAIL"].ToString();
                Patient pat = new Patient(id, username, firstName, lastName, tel, email, new Insurance(Convert.ToInt32(appRow["PAT_INS_ID"]), appRow["INS_NAME"].ToString()));

                Doctor doc = PersonFactory.getInstance.createDoctor(appRow);
                
                return new Appointment(appId, appDate, pat, doc, cnlReason, cnlDate, isInvoiced, desc);
            }
            return null;
           
        }

        public Boolean addServices(int appId, string code, int duration)
        {
            try
            {
                USR_DATA_DATASETTableAdapters.CRP_SERVICE_PROVIDEDTableAdapter serTableAdapter = new USR_DATA_DATASETTableAdapters.CRP_SERVICE_PROVIDEDTableAdapter();
                serTableAdapter.add(appId, code, duration);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating appointment: " + ex.Message);
                return false;
            }
        }

        public Boolean removeServices(int appId, string code)
        {
            try
            {
                USR_DATA_DATASETTableAdapters.CRP_SERVICE_PROVIDEDTableAdapter serTableAdapter = new USR_DATA_DATASETTableAdapters.CRP_SERVICE_PROVIDEDTableAdapter();
                serTableAdapter.delete(appId, code);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating appointment: " + ex.Message);
                return false;
            }
        }

        public DataTable getServicesProvided(int appId)
        {
            USR_DATA_DATASETTableAdapters.VW_SERVICES_PROVIDEDTableAdapter serProTableAdapter = new USR_DATA_DATASETTableAdapters.VW_SERVICES_PROVIDEDTableAdapter();
            return serProTableAdapter.GetDataById(appId);
        }

        public Boolean addPrescription(int appId, int medId, string prescription)
        {
            try
            {
                USR_DATA_DATASETTableAdapters.CRP_PRESCRIPTIONTableAdapter preTableAdapter = new USR_DATA_DATASETTableAdapters.CRP_PRESCRIPTIONTableAdapter();
                preTableAdapter.add(appId, medId, prescription);    
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating appointment: " + ex.Message);
                return false;
            }
        }

        public Boolean removePrescription(int appId, int medId)
        {
            try
            {
                USR_DATA_DATASETTableAdapters.CRP_PRESCRIPTIONTableAdapter preTableAdapter = new USR_DATA_DATASETTableAdapters.CRP_PRESCRIPTIONTableAdapter();
                preTableAdapter.delete(appId, medId);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating appointment: " + ex.Message);
                return false;
            }
        }

        public DataTable getPrescriptions(int appId)
        {
            USR_DATA_DATASETTableAdapters.VW_PRESCRIPTIONSTableAdapter preTableAdapter = new USR_DATA_DATASETTableAdapters.VW_PRESCRIPTIONSTableAdapter();
            return preTableAdapter.GetDataById(appId);
        }

        public DataTable getDoctorsAsCriteriaList()
        {
            USR_DATA_DATASETTableAdapters.VW_DOCTORSTableAdapter docTableAdapter = new USR_DATA_DATASETTableAdapters.VW_DOCTORSTableAdapter();
            return docTableAdapter.GetDocAsCriteriaList();
        }

        public DataTable getSpecialtyAsCriteriaList()
        {
            USR_DATA_DATASETTableAdapters.CRP_SPECIALTYTableAdapter speTableAdapter = new USR_DATA_DATASETTableAdapters.CRP_SPECIALTYTableAdapter();
            return speTableAdapter.GetData();
        }

        public DataTable getNextAvailabilities(Boolean isForDoctors, int id)
        {
            if (isForDoctors)
            {
                USR_DATA_DATASETTableAdapters.PKG_CAREPOINT_GETNEXTAVAILABILITYFORDOCTableAdapter q = new USR_DATA_DATASETTableAdapters.PKG_CAREPOINT_GETNEXTAVAILABILITYFORDOCTableAdapter();
                return q.GetData(id);
            }
            else
            {
                USR_DATA_DATASETTableAdapters.PKG_CAREPOINT_GETNEXTAVAILABILITYFORSPETableAdapter q = new USR_DATA_DATASETTableAdapters.PKG_CAREPOINT_GETNEXTAVAILABILITYFORSPETableAdapter();
                return q.GetData(id);
            }
        }

        public DataTable getNextAppointmentForDoctors(int docId)
        {
            USR_DATA_DATASETTableAdapters.VW_DOCTORS_APPTableAdapter docAppTableAdapter = new USR_DATA_DATASETTableAdapters.VW_DOCTORS_APPTableAdapter();
            return docAppTableAdapter.GetNextAppByDocId(docId);
        }

        public DataTable getPastAppointmentForDoctors(int docId)
        {
            USR_DATA_DATASETTableAdapters.VW_DOCTORS_APPTableAdapter docAppTableAdapter = new USR_DATA_DATASETTableAdapters.VW_DOCTORS_APPTableAdapter();
            return docAppTableAdapter.GetPastAppByDocId(docId);
        }

        public DataTable getNextAppointmentForPatient(int patId)
        {
            USR_DATA_DATASETTableAdapters.VW_PATIENTS_APPTableAdapter patAppTableAdapter = new USR_DATA_DATASETTableAdapters.VW_PATIENTS_APPTableAdapter();
            return patAppTableAdapter.GetNextAppByPatId(patId);
        }

        public DataTable getPastAppointmentForPatient(int patId)
        {
            USR_DATA_DATASETTableAdapters.VW_PATIENTS_APPTableAdapter patAppTableAdapter = new USR_DATA_DATASETTableAdapters.VW_PATIENTS_APPTableAdapter();
            return patAppTableAdapter.GetPastAppByPatId(patId);
        }

        public DataTable getInvoice(int appId)
        {
            USR_DATA_DATASETTableAdapters.PKG_CAREPOINT_GETINVOICEFORAPPOINTMENTTableAdapter invoicTableAdapter = new USR_DATA_DATASETTableAdapters.PKG_CAREPOINT_GETINVOICEFORAPPOINTMENTTableAdapter();
            return invoicTableAdapter.GetData(appId);
        }

        public Boolean closeAppointment(int appId)
        {
            try
            {
                // Update is_invoiced
                USR_DATA_DATASETTableAdapters.CRP_APPOINTMENTTableAdapter appTableAdapter = new USR_DATA_DATASETTableAdapters.CRP_APPOINTMENTTableAdapter();
                appTableAdapter.close(appId);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating appointment: " + ex.Message);
                return false;
            }

        }


    }
}

