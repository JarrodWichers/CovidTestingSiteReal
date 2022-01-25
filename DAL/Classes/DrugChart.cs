using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
   public class DrugChart
    {
        public int DrugChartID {get;set;}
        public string Description { get; set; }
        public string Dosage { get; set; }
        public int PatientID { get; set; }
        public int MedicationID { get; set; }
        public DateTime DateGiven { get; set; }
        public DateTime TimeGive { get; set; }

    }
}
