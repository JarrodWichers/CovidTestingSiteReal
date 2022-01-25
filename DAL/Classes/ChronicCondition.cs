using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ChronicCondition
    {
        public int ChronicConditionID { get; set; }
        public int ConditionID { get; set; }
        public int PatientID { get; set; }
    }
}
