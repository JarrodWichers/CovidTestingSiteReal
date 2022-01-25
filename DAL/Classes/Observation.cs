using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Observation
    { 
        public int ObservationID { get; set; }
        public string Value { get; set; }        
        public string Date { get; set; }
        public string Time { get; set; }
        public int NurseID { get; set; }
        public int AdmissionID { get; set; }
        public int VitalID { get; set; }
    }
}
