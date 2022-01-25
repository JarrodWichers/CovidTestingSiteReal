using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Room
    {
        public int RoomID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int WardID { get; set; }

        //DD: Can we maybe add a bedID get and set method here please 
        //DD: Also I've added somehing in the NursesRoomAndBedForm.aspx that will allow nurses to make a comment on how changing the Patients location went
    }
}
