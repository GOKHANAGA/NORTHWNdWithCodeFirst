using NORTHWNDCodeFirst.DB;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NORTHWNDCodeFirst.Mapping
{
    class OrderDetailsMap:EntityTypeConfiguration<OrderDetails>
    {
        public OrderDetailsMap()
        {
            HasKey(od => new { od.OrderID,od.ProductID});
           
        }
    }
}
