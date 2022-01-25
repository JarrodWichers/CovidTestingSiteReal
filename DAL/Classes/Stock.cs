using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Stock
    {
        public int StockID { get; set; }
        public int MedicationID { get; set; }
        public int QtyInStock { get; set; }
    }
}
