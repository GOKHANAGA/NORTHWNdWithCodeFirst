using NORTHWNDCodeFirst.DB;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NORTHWNDCodeFirst.Mapping
{
    public class TerritoryMap:EntityTypeConfiguration<Territory>
    {
        public TerritoryMap()
        {
            HasMany(t => t.Employees).WithMany(e => e.Territories);
            HasRequired(r => r.Region).WithMany(t => t.Territories).HasForeignKey(f => f.RegionID);
        }
    }
}
