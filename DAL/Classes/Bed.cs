using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Bed
    {
        public int BedID { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public int RoomID { get; set; }
    }
}
