using NORTHWNDCodeFirst.DB;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NORTHWNDCodeFirst.Mapping
{
    class CategoryMap:EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            HasMany(c => c.Products).WithRequired(p => p.Category).HasForeignKey(f => f.CategoryID);
        }
    }
}
