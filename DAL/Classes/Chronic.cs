using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Chronic
    {
        public int ChronicID { get; set; }
        public int PatientID { get; set; }
        public int MedicationID { get; set; }
        public string Frequency { get; set; }

    }
}
