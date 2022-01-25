using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class User
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string ContactNum { get; set; }
        public string Address { get; set; }
        public string Role { get; set; }
        public string MaritalStatus { get; set; }
        public string Gender { get; set; }
    }
}
