using CLMTB.Domain.Entities;
using CLMTB.Infrastructure.ORM.Configuration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLMTB.Infrastructure.ORM.Context
{
    public class EntityFrameworkContext : DbContext
    {
        public EntityFrameworkContext()
            : base("CLMTB")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<EntityFrameworkContext>());
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Athlete> Athletes { get; set; }
        public DbSet<Category> Categories { get; set; }

        public static EntityFrameworkContext Create()
        {
            return new EntityFrameworkContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.Add(new AthleteConfiguration());
            modelBuilder.Configurations.Add(new CategoryConfiguration());
        }

        public void Detach(object entity)
        {
            ((IObjectContextAdapter)this).ObjectContext.Detach(entity);
        }

        public override int SaveChanges()
        {
            try
            {
                return base.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                IEnumerable<string> errors = e.EntityValidationErrors.SelectMany(
                    x =>
                        x.ValidationErrors).Select(
                    x =>
                        String.Format("{0}: {1}", x.PropertyName, x.ErrorMessage));

                throw new DbEntityValidationException(String.Join("; ", errors), e.EntityValidationErrors);
            }
        }
    }
}