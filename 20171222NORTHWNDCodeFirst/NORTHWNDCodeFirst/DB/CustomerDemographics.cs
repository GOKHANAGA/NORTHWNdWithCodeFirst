using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NORTHWNDCodeFirst.DB
{
    public class CustomerDemographics
    {
        public int CustomerTypeID { get; set; }

        public ICollection<Customer> Customers { get; set; }
    }
}
