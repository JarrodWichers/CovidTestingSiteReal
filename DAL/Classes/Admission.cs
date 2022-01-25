using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Admission
    {
        public int AdmissionID { get; set; }
        public string PatientCode { get; set; }
        public string AdmissionReason { get; set; }
        public string AdmissionTime { get; set; }
        public string AdmissionDate { get; set; }
        public string DischargeTime { get; set; }
        public string DischargeDate { get; set; }
        public string DischargeReason { get; set; }
        public int PatientID { get; set; }
        public int BedID { get; set; }


    }
}
