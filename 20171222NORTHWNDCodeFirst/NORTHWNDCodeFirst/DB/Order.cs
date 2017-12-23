using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NORTHWNDCodeFirst.DB
{
    public class Order
    {
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public int? EmployeeID { get; set; }
        public int? ShipVia { get; set; }

        public ICollection<OrderDetails> OrderDetails { get; set; }
        public Shipper Shipper { get; set; }
        public Customer Customer { get; set; }
        public Employee Employee { get; set; }
    }
}
