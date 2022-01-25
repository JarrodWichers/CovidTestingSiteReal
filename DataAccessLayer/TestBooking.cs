using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class TestBooking
    {
        public int RequestID { get; set; }
        public string BookingDate { get; set; }
        public string BookingTimeSlot { get; set; }
        public int NurseID { get; set; }
    }
}
