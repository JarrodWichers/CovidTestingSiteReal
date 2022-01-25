using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DrugAllergy
    {
        public int DrugAllergyID { get; set; }
        public int MedicalAllergyID { get; set; }
        public int MedicationID { get; set; }
    }
}
