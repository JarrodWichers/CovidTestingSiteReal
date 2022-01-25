using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class MedicalAidDetail
    {
        public int MedicalAidDetailID { get; set; }
        public int MedicalAidID { get; set; }
        public int PatientID { get; set; }
        public string PlanName { get; set; }
        public string MedicalAidNumber { get; set; }
        public string HeadMemberName { get; set; }
        public string HeadMemberID { get; set; }
        public string HeadMemberNumber { get; set; }
    }
}
