using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Dependent
    {
        public int MainMemberID { get; set; }
        public int UserID { get; set; }

        public string IDNumber { get; set; }
        public string FullName { get; set; }
        public string Surname { get; set; }
        public string CellNumber { get; set; }
        public string EmailAddress { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public int SuburbID { get; set; }
        public string MedicalAid { get; set; }
        public int MedicalAidPlanID { get; set; }
        public string MedicalAidNumber { get; set; }
        public string ResponsiblePerson { get; set; }
    }
}
