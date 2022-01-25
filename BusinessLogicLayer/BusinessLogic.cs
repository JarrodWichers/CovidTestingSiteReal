using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BusinessLogic
    {
        DataAccess DAL = new DataAccess();

        #region nurse
        public DataTable GetNurse()
        {
            return DAL.GetNurse();
        }

            public DataTable GetTestRequestsByRequestID(int d)
        {
            return DAL.GetTestRequestsByRequestID(d);
        }
            public DataTable GetTestRequests()
        {
            return DAL.GetTestRequests();
        }
            public DataTable SelectTestBookingByNurseID(int d, string d1)
        {
            return DAL.SelectTestBookingByNurseID(d,d1);
        }
        public DataTable GetMainMemberDetailsByID(int d)
        {
            return DAL.GetMainMemberDetailsByID(d);
        }

            public int InsertTestResults(TestResult iTest)
        {
            return DAL.InsertTestResults(iTest);
        }

        public int InsertNurseFavSuburb(NurseFavSub n)
        {
            return DAL.InsertNurseFavSuburb(n);
        }

        public int InsertTestBooking(TestBooking n)
        {
            return DAL.InsertTestBooking(n);
        }

        #endregion

        #region MainMember

        public DataTable GetMedicalAid()
        {
            return DAL.GetMedicalAid();
        }

            public DataTable GetMedicalPlanByMedicalID(int d)
        {
            return DAL.GetMedicalPlanByMedicalID(d);
        }

            public DataTable GetDependentByMainID(int d)
        {
            return DAL.GetDependentByMainID(d);
        }


            public DataTable GetSuburb()
        {
            return DAL.GetSuburb();
        }
        public DataTable GetMainMembers()
        {
            return DAL.GetMainMembers();
        }

            public int InsertUser(User test)
        {
           return DAL.InsertUser(test);
        }

            public int InsertDependant(Dependent iMember)
        {
            return DAL.InsertDependant(iMember);
        }

        public int InsertMainMember(MainMember iMember)
        {
            return DAL.InsertMainMember(iMember);
        }

        public int InsertTestRequest(TestRequest test)
        {
            return DAL.InsertTestRequest(test);
        }

        #endregion

        public DataTable ReportNurse(int d, string d1, string d2)
        {
            return DAL.ReportNurse(d, d1, d2);
        }

            #region Login

            public DataTable GetUserLogin(string username, string password)
        {
            return DAL.GetUserLogin(username, password);
        }

        public DataTable GetLoginMainMember(int userID)
        {
            return DAL.GetLoginMainMember(userID);
        }

        public DataTable GetLoginNurse(int userID)
        {
            return DAL.GetLoginNurse(userID);
        }

        public DataTable GetLoginManager(int userID)
        {
            return DAL.GetLoginManager(userID);
        }


        #endregion
    }
}
