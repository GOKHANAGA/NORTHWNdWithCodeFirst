using NORTHWNDCodeFirst.DB;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NORTHWNDCodeFirst.Mapping
{
    class EmployeeMap : EntityTypeConfiguration<Employee>
    {
        public EmployeeMap()
        {
            
            HasOptional(e => e.Employees).WithOptionalDependent(e => e.ReportsTo);
        }
    }
}
