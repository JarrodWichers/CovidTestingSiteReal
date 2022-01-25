using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    /// <summary>
    /// DdW:  I'm renamning this too RoomCheckup, It's because in the future we might have to cater more equipment here other than bed.
    /// </summary>
    public class RoomCheckup
    {
        public int BedID { get; set; }
        public string ActionPerformed { get; set; }
        //DdW: I'm assuming status means occupied or not
        public string Status { get; set; }
        public string DatePerformed { get; set; }
        public string TimePerformed { get; set; }
        public int RoomID { get; set; }
    }
}
