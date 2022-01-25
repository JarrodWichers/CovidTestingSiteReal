using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class TestResult
    {
        public int RequestID { get; set; }
        public int PatientID { get; set; }
        public int LabUserID { get; set; }
        public string TestResults { get; set; }
        public double Temperature { get; set; }
        public string BloodPressure { get; set; }
        public int OxygenLevels { get; set; }
    }
}
