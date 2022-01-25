using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Ward
    {
        public int WardID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string TelephoneNum { get; set; }
        public int HospitalID { get; set; }
    }
}
