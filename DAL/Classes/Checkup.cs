using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
   public class Checkup
    {
        public int CheckupID { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public string Time {get;set;}
        public string Notes {get;set;}
        public int DoctorID {get;set;}
        public int AdmissionID {get;set;}
}
}
