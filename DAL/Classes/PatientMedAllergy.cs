using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class PatientMedAllergy
    {
        public int PatientMedAllergyID { get; set; }
        public int MedicalAllergyID { get; set; }
        public int PatientID { get; set; }
    }
}
