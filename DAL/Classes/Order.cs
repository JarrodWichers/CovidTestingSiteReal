using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Order
    {
        public int OrderID { get; set; }
        public int AdmissionID { get; set; }
        public int PrescriberID { get; set; }
        public int ReceivingNurseID { get; set; }        
        public string PaymentConfirmed { get; set; }
    }
}
