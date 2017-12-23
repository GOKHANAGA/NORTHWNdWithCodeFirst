using NORTHWNDCodeFirst.DB;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NORTHWNDCodeFirst.Mapping
{
    class OrderMap:EntityTypeConfiguration<Order>
    {
        public OrderMap()
        {
            HasMany(od => od.OrderDetails).WithRequired(o => o.Order).HasForeignKey(f => f.OrderID);
            HasRequired(s => s.Shipper).WithMany(o => o.Orders).HasForeignKey(f => f.ShipVia);
            HasRequired(o => o.Customer).WithMany(o => o.Orders).HasForeignKey(f => f.CustomerID);
            HasRequired(o => o.Employee).WithMany(e => e.Orders).HasForeignKey(f => f.EmployeeID);
        }
    }
}
