using EF.Core.Data;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Reflection;

namespace EF.Data
{
    public class EfDbContext : DbContext
    {
        public EfDbContext()
            : base("Data Source=.;Initial Catalog=DbTest;Integrated Security=True")
        {
        }

        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class, new()
        {
            return base.Set<TEntity>();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
           .Where(type => !String.IsNullOrEmpty(type.Namespace))
           .Where(type => type.BaseType != null && type.BaseType.IsGenericType
                && type.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>));
            foreach (var type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.Configurations.Add(configurationInstance);
            }
            modelBuilder.Entity<Customer>().ToTable($"Customer");
            modelBuilder.Entity<Address>().ToTable($"Address");
            base.OnModelCreating(modelBuilder);
        }
    }
}
