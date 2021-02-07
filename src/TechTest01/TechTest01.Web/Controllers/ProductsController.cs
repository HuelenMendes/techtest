using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechTest01.Services;
using TechTest01.Services.Catalog;
using TechTest01.Web.Models;

namespace TechTest01.Web.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Product
        private IProductService service = null;
        
        public ProductsController(IProductService service)
        {
            this.service = service;
        }
        
        public ActionResult Index()
        {
            var products = this.service.GetProducts().
                Select(p => new ProductsModel() { Id = p.Id,
                Name = p.Name,
                ImageUrl = p.ImageUrl,
                Slug = p.Slug
            }).ToArray();
            return View(products);
        }
    }
}