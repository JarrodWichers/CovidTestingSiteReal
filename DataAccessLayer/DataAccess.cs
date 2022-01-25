using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Configuration;

namespace DataAccessLayer
{
    public class DataAccess
    {
        //This is just a connection we can work with so long.  When we get the just correct the connection Comment written by Dewaldt
        // Old string: "Data Source=sict-sql.mandela.ac.za, Intitial Catalog=WardCare24,User ID=HWMS08,Password=hwms08-2020;"
        public SqlConnection dbConn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString);
        SqlCommand dbCmd;
        DataTable dt;
        SqlDataAdapter dbAdapter;

        #region ONP400

        #region Nurse

        public DataTable GetTestRequests()
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }

            string sql = "GetNewTestRequests";
            dbCmd = new SqlCommand(sql, dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }

        public DataTable GetNurse()
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }

            string sql = "GetNurse";
            dbCmd = new SqlCommand(sql, dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }

        public DataTable SelectTestBookingByNurseID(int d, string d1)
        {
            try { dbConn.Open(); } catch { }
            string sql = "SelectTestBookingByNurseID";
            dbCmd = new SqlCommand(sql, dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@NurseID", d);
            dbCmd.Parameters.AddWithValue("@BookingDate", d1);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;

        }
        public DataTable GetMainMemberDetailsByID(int d)
        {
            try { dbConn.Open(); } catch { }
            string sql = "GetMainMemberByID";
            dbCmd = new SqlCommand(sql, dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@UserID", d);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;

        }

        public DataTable GetTestRequestsByRequestID(int d)
        {
            try { dbConn.Open(); } catch { }
            string sql = "GetTestRequestByRequestID";
            dbCmd = new SqlCommand(sql, dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@RequestID", d);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;

        }

        public int InsertTestResults(TestResult iTest)
        {
            try { dbConn.Open(); } catch { }
            string sql = "InsertNurseTestResutls";
            dbCmd = new SqlCommand(sql, dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@RequestID",iTest.RequestID);
            dbCmd.Parameters.AddWithValue("@PatientID", iTest.PatientID);
            dbCmd.Parameters.AddWithValue("@LabUserID", iTest.LabUserID);
            
            dbCmd.Parameters.AddWithValue("@Temperature", iTest.Temperature);
            dbCmd.Parameters.AddWithValue("@OxygenLevels", iTest.OxygenLevels);
            dbCmd.Parameters.AddWithValue("@BloodPressure", iTest.BloodPressure);

            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }

        public int InsertNurseFavSuburb(NurseFavSub n)
        {
            try { dbConn.Open(); } catch { }
            string sql = "InsertNurseFavSuburb";
            dbCmd = new SqlCommand(sql, dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@NurseID", n.NurseID);
            dbCmd.Parameters.AddWithValue("@SuburbID", n.SuburbID);
            

            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }

        public int InsertTestBooking(TestBooking n)
        {
            try { dbConn.Open(); } catch { }
            string sql = "InsertTestBooking";
            dbCmd = new SqlCommand(sql, dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@RequestID", n.RequestID);
            dbCmd.Parameters.AddWithValue("@BookingDate", n.BookingDate);
            dbCmd.Parameters.AddWithValue("@BookingTimeSlot", n.BookingTimeSlot);
            dbCmd.Parameters.AddWithValue("@NurseID", n.NurseID);


            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }


        #endregion
        #region MainMember

        public DataTable GetSuburb()
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }

            string sql = "GetSuburb";
            dbCmd = new SqlCommand(sql, dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }
        public DataTable GetMedicalAid()
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }

            string sql = "GetMedicalAid";
            dbCmd = new SqlCommand(sql, dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }

        public DataTable GetMainMembers()
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }

            string sql = "GetMain";
            dbCmd = new SqlCommand(sql, dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }

        public DataTable GetDependentByMainID(int d)
        {
            try { dbConn.Open(); } catch { }
            string sql = "GetDependentByMainID";
            dbCmd = new SqlCommand(sql, dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@MainMemberID", d);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;

        }
        public DataTable GetMedicalPlanByMedicalID(int d)
        {
            try { dbConn.Open(); } catch { }
            string sql = "GetMedicalPlanByMedicalID";
            dbCmd = new SqlCommand(sql, dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@MedicalAidID", d);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;

        }

        public int InsertDependant(Dependent iMember)
        {
            try { dbConn.Open(); } catch { }
            string sql = "InsertDependent";
            dbCmd = new SqlCommand(sql, dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@MainMemberID", iMember.MainMemberID);
            dbCmd.Parameters.AddWithValue("@UserID", iMember.UserID);
            dbCmd.Parameters.AddWithValue("@IDNumber", iMember.IDNumber);
            dbCmd.Parameters.AddWithValue("@FullName", iMember.FullName);
            dbCmd.Parameters.AddWithValue("@Surname", iMember.Surname);
            dbCmd.Parameters.AddWithValue("@CellNumber", iMember.CellNumber);
            dbCmd.Parameters.AddWithValue("@EmailAddress", iMember.EmailAddress);
            dbCmd.Parameters.AddWithValue("@AddressLine1", iMember.AddressLine1);
            dbCmd.Parameters.AddWithValue("@AddressLine2", iMember.AddressLine2);
            dbCmd.Parameters.AddWithValue("@SuburbID", iMember.SuburbID);
            dbCmd.Parameters.AddWithValue("@MedicalAid", iMember.MedicalAid);
            dbCmd.Parameters.AddWithValue("@MedicalAidPlanID", iMember.MedicalAidPlanID);
            dbCmd.Parameters.AddWithValue("@MedicalAidNumber", iMember.MedicalAidNumber);
            dbCmd.Parameters.AddWithValue("@ResponsiblePerson", iMember.ResponsiblePerson);

            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }

        public int InsertMainMember(MainMember iMember)
        {
            try { dbConn.Open(); } catch { }
            string sql = "InsertMainMember";
            dbCmd = new SqlCommand(sql, dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            
            dbCmd.Parameters.AddWithValue("@UserID", iMember.UserID);
            dbCmd.Parameters.AddWithValue("@IDNumber", iMember.IDNumber);
            dbCmd.Parameters.AddWithValue("@FullName", iMember.FullName);
            dbCmd.Parameters.AddWithValue("@Surname", iMember.Surname);
            dbCmd.Parameters.AddWithValue("@CellNumber", iMember.CellNumber);
            dbCmd.Parameters.AddWithValue("@EmailAddress", iMember.EmailAddress);
            dbCmd.Parameters.AddWithValue("@AddressLine1", iMember.AddressLine1);
            dbCmd.Parameters.AddWithValue("@AddressLine2", iMember.AddressLine2);
            dbCmd.Parameters.AddWithValue("@SuburbID", iMember.SuburbID);
            dbCmd.Parameters.AddWithValue("@MedicalAid", iMember.MedicalAid);
            dbCmd.Parameters.AddWithValue("@MedicalAidPlanID", iMember.MedicalAidPlanID);
            dbCmd.Parameters.AddWithValue("@MedicalAidNumber", iMember.MedicalAidNumber);
            dbCmd.Parameters.AddWithValue("@ResponsiblePerson", iMember.ResponsiblePerson);

            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }

        public int InsertTestRequest(TestRequest test)
        {
            try { dbConn.Open(); } catch { }
            string sql = "InsertTestRequest";
            dbCmd = new SqlCommand(sql, dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;

            dbCmd.Parameters.AddWithValue("@RequestDate", test.RequestDate);
            dbCmd.Parameters.AddWithValue("@RequestTime", test.RequestTime);
            dbCmd.Parameters.AddWithValue("@Status", test.Status);
            dbCmd.Parameters.AddWithValue("@RequestorID", test.RequestorID);
            dbCmd.Parameters.AddWithValue("@TestSubjectID", test.TestSubjectID);
            dbCmd.Parameters.AddWithValue("@TestAdressLine1", test.TestAdressLine1);
            dbCmd.Parameters.AddWithValue("@TestAdressLine2", test.TestAdressLine2);
            dbCmd.Parameters.AddWithValue("@TestSuburbID", test.TestSuburbID);
            

            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }

        public int InsertUser(User test)
        {
            try { dbConn.Open(); } catch { }
            string sql = "InsertUser";
            dbCmd = new SqlCommand(sql, dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;

            dbCmd.Parameters.AddWithValue("@Username", test.Username);
            dbCmd.Parameters.AddWithValue("@Password", test.Password);
            dbCmd.Parameters.AddWithValue("@Status", test.Status);
            dbCmd.Parameters.AddWithValue("@UserType", test.UserType);
            


            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }
        #endregion
        #endregion
        #region Report
        public DataTable ReportNurse(int d, string d1, string d2)
        {
            try { dbConn.Open(); } catch { }
            string sql = "ReportNurse";
            dbCmd = new SqlCommand(sql, dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@NurseID", d);
            dbCmd.Parameters.AddWithValue("@StartDate", d1);
            dbCmd.Parameters.AddWithValue("@EndDate", d2);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;

        }
        #endregion

        #region Login

        public DataTable GetUserLogin(string username, string password)
        {
            try { dbConn.Open(); } catch { }
            string sql = "GetUserLogin";
            dbCmd = new SqlCommand(sql, dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@Username", username);
            dbCmd.Parameters.AddWithValue("@Password", password);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }
        public DataTable GetLoginMainMember(int userID)
        {
            try { dbConn.Open(); } catch { }
            string sql = "GetMainMemberLogin";
            dbCmd = new SqlCommand(sql, dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@UserID", userID);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }
        public DataTable GetLoginNurse(int userID)
        {
            try { dbConn.Open(); } catch { }
            string sql = "GetLoginNurse";
            dbCmd = new SqlCommand(sql, dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@UserID", userID);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }

        public DataTable GetLoginManager(int userID)
        {
            try { dbConn.Open(); } catch { }
            string sql = "GetManagerLogin";
            dbCmd = new SqlCommand(sql, dbConn);
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Parameters.AddWithValue("@UserID", userID);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }


        #endregion
    }
}





