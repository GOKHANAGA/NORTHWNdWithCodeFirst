using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NORTHWNDCodeFirst.DB
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Employee ReportsTo { get; set; }

        public Employee Employees { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<Territory> Territories { get; set; }
    }
}
