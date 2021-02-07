using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTest01.Domain.Catalog;

namespace TechTest01.Domain
{
   public sealed class ApplicationContext : DbContext
    {
        private static ApplicationContext instance = null;
        public static ApplicationContext GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new ApplicationContext();

                return instance;
            }
        }
        private ApplicationContext() : base("name=ApplicationContext")
        {
            Database.SetInitializer<ApplicationContext>(new TechDBInitializer());
        }

        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
