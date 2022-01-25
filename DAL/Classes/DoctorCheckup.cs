using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DoctorCheckup
    {
        public int DoctorCheckupID { get; set; }
        public int DoctorID { get; set; }
        public int CheckupID { get; set; }
    }
}
