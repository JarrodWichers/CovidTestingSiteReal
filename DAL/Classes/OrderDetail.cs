using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class OrderDetail
    {
        public int OrderDetailID { get; set; }
        public int OrderID { get; set; }
        public int MedicationID { get; set; }
        public float Subtotal { get; set; }
        public int Quantity { get; set; }
    }
}
