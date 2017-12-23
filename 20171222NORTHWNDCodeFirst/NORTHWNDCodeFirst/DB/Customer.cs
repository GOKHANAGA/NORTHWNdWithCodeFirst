using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NORTHWNDCodeFirst.DB
{
    public class Customer
    {
        public string CustomerID { get; set; }
        public string CompanyName { get; set; }

        public ICollection<Order> Orders { get; set; }
        public ICollection<CustomerDemographics> CustomerDemographics { get; set; }
    }
}
