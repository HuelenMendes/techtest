using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTest01.Domain.Catalog;
using TechTest01.Repository.Repositories;
using TechTest01.Services.Catalog;

namespace TechTest01.Services
{
    public class ProductService : IProductService
    {
        private ProductRepository repository;

        public ProductService()
        {
            this.repository = new ProductRepository();
        }

        public Product GetById(int id)
        {
            return this.repository.GetByID(id);
        }

        public ICollection<Product> GetProducts()
        {
            return this.repository.GetAll();
        }
    }
}
