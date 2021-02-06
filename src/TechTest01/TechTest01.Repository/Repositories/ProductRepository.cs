using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTest01.Domain;
using TechTest01.Domain.Catalog;

namespace TechTest01.Repository.Repositories
{
    public class ProductRepository : IRepository<Product> 
    {
        internal ApplicationContext context;

        internal DbSet<Product> dbSet;
        public ProductRepository()
        {
            this.context = new ApplicationContext();
            this.dbSet = context.Set<Product>();
        }

        public ICollection<Product> GetAll()
        {
            return dbSet.ToArray<Product>();
        }

        public Product GetByID(object id)
        {
            return dbSet.Find(id);
        }
    }
}
