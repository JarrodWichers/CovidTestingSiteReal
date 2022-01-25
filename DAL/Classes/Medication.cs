using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Medication
    {
        public int MedicationID { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string Strength { get; set; }
        public string DrugType { get; set; }
        public string ScheduleNo { get; set; }
        public float UnitPrice { get; set; }
        public string ContainsPenicilin { get; set; }
        public int AlternativeID { get; set; }
    }
}
