using NORTHWNDCodeFirst.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NORTHWNDCodeFirst.DB
{
    public class NORTHWNDContext:DbContext
    {
        public NORTHWNDContext():base("Server=.;Database=NorthwindCode;Integrated Security=true;")
        {
            Database.SetInitializer<NORTHWNDContext>(new DropCreateDatabaseIfModelChanges<NORTHWNDContext>());
        }

        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Shipper> Shipper { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<CustomerDemographics> CustomerDemographic { get; set; }
        public DbSet<Territory> Territory { get; set; }
        public DbSet<Region> Region { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new OrderDetailsMap());
            modelBuilder.Configurations.Add(new OrderMap());
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new EmployeeMap());
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new CustomerDemographicsMap());
            modelBuilder.Configurations.Add(new TerritoryMap());
        }
    }
}
