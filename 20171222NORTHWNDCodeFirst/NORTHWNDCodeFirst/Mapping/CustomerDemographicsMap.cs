using NORTHWNDCodeFirst.DB;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NORTHWNDCodeFirst.Mapping
{
    public class CustomerDemographicsMap:EntityTypeConfiguration<CustomerDemographics>
    {
        public CustomerDemographicsMap()
        {
            HasKey(cd => cd.CustomerTypeID);
        }
    }
}
