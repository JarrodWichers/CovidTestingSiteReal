
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DataAccessLayer
{
    public class DataAccess
    {
        //This is just a connection we can work with so long.  When we get the just correct the connection Comment written by Dewaldt
        public SqlConnection dbConn = new SqlConnection("Data Source = localhost;");
        SqlCommand dbCmd;
        DataTable dt;
        SqlDataAdapter dbAdapter;


        #region CaseReport
        public DataTable GetCaseReportBySearch(int d)
        {
            try { dbConn.Open(); } catch { }
            string sql = "Sp_GetDataForCaseReport";
            dbCmd = new SqlCommand(sql, dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@", d);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;



        }


        #endregion

        #region MedicalReportSearch
        public DataTable GetCaseReportBySearchMedicalReport(int d)
        {
            try { dbConn.Open(); } catch { }
            string sql = "Sp_GetDataForCaseReport";
            dbCmd = new SqlCommand(sql, dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@", d);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;



        }


        #endregion


        #region TableHeartRate

        //Datatable for Measurement Table

        public DataTable GetHeartRate(int d)
        {
            try { dbConn.Open(); } catch { }
            string sql = "";
            dbCmd = new SqlCommand(sql, dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@", d);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;



        }

        //Datatable for averages on HeartRate Table will also get higest and lowest value

        public DataTable GetHeartRateAverages(int d)
        {
            try { dbConn.Open(); } catch { }
            string sql = "";
            dbCmd = new SqlCommand(sql, dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@", d);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;



        }
        #endregion



        #region NursesPatientObservation
        public int InsertObservation(int AdmissionID, DateTime date, DateTime time, string vitalBeingMeasured, int rate, int nurse)
        {
            try { dbConn.Open(); } catch { }
            string sql = "sp_InsertObservation";
            dbCmd = new SqlCommand(sql, dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@patientId", AdmissionID);
            dbCmd.Parameters.AddWithValue("@date", date);
            dbCmd.Parameters.AddWithValue("@time", time);
            dbCmd.Parameters.AddWithValue("@vitalBeingMeasured", vitalBeingMeasured);
            dbCmd.Parameters.AddWithValue("@rate", rate);
            dbCmd.Parameters.AddWithValue("@nurse", nurse);




            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbCmd.ExecuteNonQuery();
            return x;



            
        }
        public DataTable GetVitals()
        {
            try { dbConn.Open(); } catch { }
            string sql = "Sp_GetVital";
            dbCmd = new SqlCommand(sql, dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }
        #endregion



        #region PatientReport
        public DataTable searchPatientByCode(int d)
        {
            try { dbConn.Open(); } catch { }
            string sql = "Sp_GetPatientByCode";
            dbCmd = new SqlCommand(sql, dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@PatientCode", d);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;

        }

        public DataTable searchPatientByID(int d)
        {
            try { dbConn.Open(); } catch { }
            string sql = "Sp_GetPatientByIDNumber";
            dbCmd = new SqlCommand(sql, dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@PatientCode", d);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;

        }

        public DataTable SearchPatientByName(string d)
        {
            try { dbConn.Open(); } catch { }
            string sql = "Sp_GetPatientByName";
            dbCmd = new SqlCommand(sql, dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@PatientName", d);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;

        }

        #endregion

        #region RespirationTable
        // Respiration measurement table
        public DataTable GetRespirationRate()
        {
            try { dbConn.Open(); } catch { }
            string sql = "";
            dbCmd = new SqlCommand(sql, dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }

        //Datatable for averages on Respiration Table

        public DataTable GetRespirationAverages()
        {
            try
            {
                dbConn.Open();
            }
            catch { }
            string sql = "";
            dbCmd = new SqlCommand(sql, dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }
        #endregion

    

        #region TableBodyTemprature
        //data for Measurement table
        public DataTable GetBodyTemprature()
        {
            try { dbConn.Open(); } catch { }
            string sql = "";
            dbCmd = new SqlCommand(sql, dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }

        //Datatable for averages on HeartRate Table

        public DataTable GetBodyTempratureAverages()
        {
            try
            {
                dbConn.Open();
            }
            catch { }
            string sql = "";
            dbCmd = new SqlCommand(sql, dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }





        #endregion

        #region PersonalDetailsView
        public DataTable GetPersonalDetails(int d)
        {
            try { dbConn.Open(); } catch { }
            string sql = "";
            dbCmd = new SqlCommand(sql, dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@", d);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;

        }
        #endregion

        #region PersonalDetailsEdits

        public DataTable GetPersonalDetailsUpdate(int d)
        {


            try { dbConn.Open(); } catch { }
            string sql = "";
            dbCmd = new SqlCommand(sql, dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@", d);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }
        public int UpdatePersonalsDetails(int d)
        {
            try { dbConn.Open(); } catch { }
            string sql = "sp_UpdateEquipmentType";
            dbCmd = new SqlCommand(sql, dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;





            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }

        #endregion

        #region DrugChart
        public DataTable GetDrugChart(int d)
        {
            try { dbConn.Open(); } catch { }
            string sql = "";
            dbCmd = new SqlCommand(sql, dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@", d);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }

        #endregion
        #region Doctor
        public DataTable GetPatient()
        {
            try { dbConn.Open(); } catch { }
            string sql = "Sp_GetPatient";
            dbCmd = new SqlCommand(sql, dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;            
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;

        }

        public int InsertCheckup(int patientId, DateTime date, DateTime time, string description, string notes, string Doctor)
        {
            try { dbConn.Open(); } catch { }
            string sql = "sp_InsertCheckup";
            dbCmd = new SqlCommand(sql, dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@patientId", patientId);
            dbCmd.Parameters.AddWithValue("@date", date);
            dbCmd.Parameters.AddWithValue("@time", time);
            dbCmd.Parameters.AddWithValue("@description", description);
            dbCmd.Parameters.AddWithValue("@notes", notes);
            dbCmd.Parameters.AddWithValue("@Doctor", Doctor);




            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }

        public DataTable GetObservationByPatient(int d)
        {
            try { dbConn.Open(); } catch { }
            string sql = "Sp_GetObservationByPatient";
            dbCmd = new SqlCommand(sql, dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@PatientID", d);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;

        }

        public DataTable GetDrugChartByPatient(int d)
        {
            try { dbConn.Open(); } catch { }
            string sql = "Sp_GetDrugChartByPatient";
            dbCmd = new SqlCommand(sql, dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@PatientID", d);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;

        }

        public int DischargePatient(int patientId, DateTime date, DateTime dateOfAdmission, DateTime dateOfDischarge, DateTime time, string diagnosis, string condition, string Doctor)
        {
            try { dbConn.Open(); } catch { }
            string sql = "sp_DischargePatient";
            dbCmd = new SqlCommand(sql, dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@patientId", patientId);
            dbCmd.Parameters.AddWithValue("@date", date);
            dbCmd.Parameters.AddWithValue("@dateOfAdmission", dateOfAdmission);
            dbCmd.Parameters.AddWithValue("@dateOfDischarge", dateOfDischarge);
            dbCmd.Parameters.AddWithValue("@time", time);
            dbCmd.Parameters.AddWithValue("@diagnosis", diagnosis);
            dbCmd.Parameters.AddWithValue("@condition", condition);
            dbCmd.Parameters.AddWithValue("@Doctor", Doctor);




            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }

        public int InsertPrescription(string patientName,string insuranceNumber,int phoneNumber,string DrugNDC, string DrugName,int qty, int refills,string rxNote,string PrescriberName,int LicenseNumber,int DEANum,int presNumber, DateTime PrescrbedDate, DateTime ExpiryDate, DateTime time)
        {
            try { dbConn.Open(); } catch { }
            string sql = "sp_DischargePatient";
            dbCmd = new SqlCommand(sql, dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@patientName", patientName);
            dbCmd.Parameters.AddWithValue("@insuranceNumber", insuranceNumber);
            dbCmd.Parameters.AddWithValue("@phoneNumber", phoneNumber);
            dbCmd.Parameters.AddWithValue("@DrugNDC", DrugNDC);
            dbCmd.Parameters.AddWithValue("@DrugName", DrugName);
            dbCmd.Parameters.AddWithValue("@qty", qty);
            dbCmd.Parameters.AddWithValue("@refills", refills);
            dbCmd.Parameters.AddWithValue("@PrescrbedDate", PrescrbedDate);
            dbCmd.Parameters.AddWithValue("@ExpiryDate", ExpiryDate);
            dbCmd.Parameters.AddWithValue("@rxNote", rxNote);
            dbCmd.Parameters.AddWithValue("@PrescriberName", PrescriberName);
            dbCmd.Parameters.AddWithValue("@LicenseNumber", LicenseNumber);
            dbCmd.Parameters.AddWithValue("@DEANum", DEANum);
            dbCmd.Parameters.AddWithValue("@presNumber", presNumber);
            dbCmd.Parameters.AddWithValue("@time", time);
            




            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }
        public DataTable Report()
        {
            try { dbConn.Open(); } catch { }
            string sql = "Sp_GetPatient";
            dbCmd = new SqlCommand(sql, dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;

        }
        #endregion
    }
}




