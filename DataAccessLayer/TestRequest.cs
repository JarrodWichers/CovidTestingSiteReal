using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class TestRequest
    {
        public string RequestDate { get; set; }
        public string RequestTime { get; set; }
        public string Status { get; set; }
        public int RequestorID { get; set; }
        public int TestSubjectID { get; set; }
        public string TestAdressLine1 { get; set; }
        public string TestAdressLine2 { get; set; }
        public int TestSuburbID { get; set; }


    }
}
