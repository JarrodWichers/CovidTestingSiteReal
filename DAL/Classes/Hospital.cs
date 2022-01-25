using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Hospital
    {
        public int HospitalID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string TelephoneNum { get; set; }
        public string Email { get; set; }
    }
}
