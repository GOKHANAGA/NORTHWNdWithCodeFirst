using NORTHWNDCodeFirst.DB;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NORTHWNDCodeFirst.Mapping
{
    class ProductMap:EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            HasMany(od => od.OrderDetails).WithRequired(p => p.Product).HasForeignKey(f => f.ProductID);
            HasRequired(p => p.Supplier).WithMany(s => s.Products).HasForeignKey(f => f.SupplierID);
        }
    }
}
